using System.Text;

namespace FFXIVClientStructs.Tools;

/// <summary>
/// Analyzes class constructors to extract struct field layouts.
/// Finds: allocation size, embedded sub-objects, field initialization offsets,
/// vtable stores, and sub-object types via RTTI cross-reference.
/// </summary>
public static class StructAnalyzer
{
    public const uint ImageBase = 0x00400000;
    public const int TextStart = 0x1000;
    public const int TextEnd = 0xB3C000;
    public const int RdataStart = 0x00B3E000;
    public const int RdataEnd = 0x00B3E000 + 0x00327000;

    public record FieldStore(uint VA, uint Offset, string Type, string Value);
    public record SubObject(uint Offset, uint CtorVA, string? ClassName, uint? VtableVA);

    public record InheritanceInfo(string ClassName, uint CtorVA, uint? VtableVA, List<FieldStore> Fields);

    public record StructLayout(
        string ClassName,
        uint? VtableVA,
        int VtableEntryCount,
        uint CtorVA,
        uint? AllocSize,
        List<FieldStore> Fields,
        List<SubObject> SubObjects,
        List<InheritanceInfo> BaseCtors = null!);

    public static StructLayout Analyze(byte[] exe, string className, string? exePath = null)
    {
        var rttiEntries = RttiDumper.ExtractAll(exePath ?? GetExePath(exe));

        var entry = rttiEntries.FirstOrDefault(e =>
            e.DemangledName.Contains(className, StringComparison.OrdinalIgnoreCase));

        if (entry == null)
            throw new InvalidOperationException($"Class '{className}' not found in RTTI");

        var ctorVA = FindConstructor(exe, entry.VTableVA);
        if (ctorVA == 0)
            throw new InvalidOperationException($"Constructor not found for '{className}'");

        var allocSize = FindAllocSize(exe, ctorVA);
        var fields = ExtractFieldStores(exe, ctorVA);
        var subObjects = ExtractSubObjects(exe, ctorVA, rttiEntries);
        var baseCtors = ExtractBaseCtorCalls(exe, ctorVA, rttiEntries);

        return new StructLayout(
            entry.DemangledName,
            entry.VTableVA,
            entry.VtableEntryCount ?? 0,
            ctorVA,
            allocSize,
            fields,
            subObjects,
            baseCtors);
    }

    public static uint FindConstructor(byte[] exe, uint? vtableVA)
    {
        if (!vtableVA.HasValue) return 0;

        var vtBytes = BitConverter.GetBytes(vtableVA.Value);

        // Scan .text for ANY instruction that stores this vtable pointer
        for (var i = TextStart; i < TextEnd - 10; i++)
        {
            if (exe[i] != 0xC7) continue;

            var modrm = exe[i + 1];
            var mod = (modrm >> 6) & 3;
            var reg = (modrm >> 3) & 7;
            var rm = modrm & 7;

            // Only match MOV r/m32, imm32 (opcode ext reg=0)
            if (reg != 0) continue;

            int immOffset;
            if (mod == 0 && rm != 4 && rm != 5)
                immOffset = 2; // [reg], no displacement
            else if (mod == 1 && rm != 4)
                immOffset = 3; // [reg+disp8]
            else if (mod == 2 && rm != 4)
                immOffset = 6; // [reg+disp32]
            else
                continue;

            if (i + immOffset + 4 > exe.Length) continue;

            // For ctor, we want stores to offset 0 (or small offset for MI base init)
            if (mod == 1 && exe[i + 2] > 8) continue; // disp8 > 8 unlikely for vtable init
            if (mod == 2)
            {
                var d = BitConverter.ToUInt32(exe, i + 2);
                if (d > 8) continue;
            }

            if (exe[i + immOffset] != vtBytes[0] || exe[i + immOffset + 1] != vtBytes[1] ||
                exe[i + immOffset + 2] != vtBytes[2] || exe[i + immOffset + 3] != vtBytes[3])
                continue;

            var funcStart = FindFuncStart(exe, (uint)(i + ImageBase));
            if (funcStart != 0) return funcStart;
        }

        return 0;
    }

    public static uint FindFuncStart(byte[] exe, uint va)
    {
        var fileOff = (int)(va - ImageBase);
        for (var i = fileOff; i > fileOff - 0x500 && i > 0; i--)
        {
            if (exe[i] == 0x55 && exe[i + 1] == 0x8B && exe[i + 2] == 0xEC)
            {
                if (i > 0 && (exe[i - 1] == 0xC3 || exe[i - 1] == 0xCC ||
                              exe[i - 1] == 0x90 || exe[i - 1] == 0xC2))
                    return (uint)(i + ImageBase);
            }
        }
        return 0;
    }

    public static uint? FindAllocSize(byte[] exe, uint ctorVA)
    {
        // Find callers of this ctor and look for push <size> before the call
        var fileOff = (int)(ctorVA - ImageBase);

        for (var i = TextStart; i < TextEnd - 5; i++)
        {
            if (exe[i] != 0xE8) continue;
            var rel = BitConverter.ToInt32(exe, i + 1);
            var dest = (uint)(i + 5 + ImageBase) + (uint)rel;
            if (dest != ctorVA) continue;

            // Found a call to ctor — scan backwards for push imm32
            for (var j = 1; j < 80; j++)
            {
                if (exe[i - j] == 0x68)
                {
                    var size = BitConverter.ToUInt32(exe, i - j + 1);
                    if (size is > 0x20 and < 0x100000)
                        return size;
                }
            }
        }
        return null;
    }

    public static List<FieldStore> ExtractFieldStores(byte[] exe, uint ctorVA)
    {
        var fields = new List<FieldStore>();
        var fileOff = (int)(ctorVA - ImageBase);
        var scanLen = 8192;

        for (var i = 0; i < scanLen && fileOff + i < exe.Length - 10; i++)
        {
            var off = fileOff + i;
            var va = ctorVA + (uint)i;

            // ---- DWORD immediate stores ----

            // C7 [mod 10] [rm] disp32 imm32 — mov [reg+disp32], imm32
            // rm: 0=eax, 1=ecx, 3=ebx, 6=esi, 7=edi (skip 4=SIB, 5=disp32-only)
            if (exe[off] == 0xC7)
            {
                var modrm = exe[off + 1];
                var mod = (modrm >> 6) & 3;
                var reg = (modrm >> 3) & 7;
                var rm = modrm & 7;

                if (reg == 0 && rm != 4 && rm != 5) // opcode ext = 0, no SIB, no disp-only
                {
                    if (mod == 2) // [reg+disp32]
                    {
                        var disp = BitConverter.ToUInt32(exe, off + 2);
                        var imm = BitConverter.ToUInt32(exe, off + 6);
                        if (disp is > 0 and < 0x10000)
                            fields.Add(new FieldStore(va, disp, "dword", $"0x{imm:X8}"));
                    }
                    else if (mod == 1) // [reg+disp8]
                    {
                        uint disp = exe[off + 2];
                        var imm = BitConverter.ToUInt32(exe, off + 3);
                        if (disp > 0)
                            fields.Add(new FieldStore(va, disp, "dword", $"0x{imm:X8}"));
                    }
                    else if (mod == 0) // [reg], disp=0
                    {
                        var imm = BitConverter.ToUInt32(exe, off + 2);
                        if (imm is >= 0x00F00000 and <= 0x01200000) continue; // vtable store, skip
                    }
                }
            }

            // ---- BYTE immediate stores ----

            // C6 [mod] [rm] disp imm8 — mov byte [reg+disp], imm8
            if (exe[off] == 0xC6)
            {
                var modrm = exe[off + 1];
                var mod = (modrm >> 6) & 3;
                var reg = (modrm >> 3) & 7;
                var rm = modrm & 7;

                if (reg == 0 && rm != 4 && rm != 5)
                {
                    if (mod == 2)
                    {
                        var disp = BitConverter.ToUInt32(exe, off + 2);
                        var imm = exe[off + 6];
                        if (disp is > 0 and < 0x10000)
                            fields.Add(new FieldStore(va, disp, "byte", $"0x{imm:X2}"));
                    }
                    else if (mod == 1)
                    {
                        uint disp = exe[off + 2];
                        var imm = exe[off + 3];
                        if (disp > 0)
                            fields.Add(new FieldStore(va, disp, "byte", $"0x{imm:X2}"));
                    }
                }
            }

            // ---- WORD immediate stores ----

            // 66 C7 [mod] [rm] disp imm16 — mov word [reg+disp], imm16
            if (exe[off] == 0x66 && exe[off + 1] == 0xC7)
            {
                var modrm = exe[off + 2];
                var mod = (modrm >> 6) & 3;
                var reg = (modrm >> 3) & 7;
                var rm = modrm & 7;

                if (reg == 0 && rm != 4 && rm != 5)
                {
                    if (mod == 2)
                    {
                        var disp = BitConverter.ToUInt32(exe, off + 3);
                        var imm = BitConverter.ToUInt16(exe, off + 7);
                        if (disp is > 0 and < 0x10000)
                            fields.Add(new FieldStore(va, disp, "word", $"0x{imm:X4}"));
                    }
                    else if (mod == 1)
                    {
                        uint disp = exe[off + 3];
                        var imm = BitConverter.ToUInt16(exe, off + 4);
                        if (disp > 0)
                            fields.Add(new FieldStore(va, disp, "word", $"0x{imm:X4}"));
                    }
                }
            }

            // ---- WORD register stores ----

            // 66 89 [mod] [rm] disp — mov word [reg+disp], reg16
            if (exe[off] == 0x66 && exe[off + 1] == 0x89)
            {
                var modrm = exe[off + 2];
                var mod = (modrm >> 6) & 3;
                var srcReg = (modrm >> 3) & 7;
                var rm = modrm & 7;
                string[] regNames = ["ax", "cx", "dx", "bx", "sp", "bp", "si", "di"];

                if (rm != 4 && rm != 5)
                {
                    if (mod == 2)
                    {
                        var disp = BitConverter.ToUInt32(exe, off + 3);
                        if (disp is > 0 and < 0x10000)
                            fields.Add(new FieldStore(va, disp, "word", regNames[srcReg]));
                    }
                    else if (mod == 1)
                    {
                        uint disp = exe[off + 3];
                        if (disp > 0)
                            fields.Add(new FieldStore(va, disp, "word", regNames[srcReg]));
                    }
                }
            }

            // ---- DWORD register stores ----

            // 89 [mod] [rm] disp — mov [reg+disp], reg32
            if (exe[off] == 0x89)
            {
                var modrm = exe[off + 1];
                var mod = (modrm >> 6) & 3;
                var srcReg = (modrm >> 3) & 7;
                var rm = modrm & 7;
                string[] regNames = ["eax", "ecx", "edx", "ebx", "esp", "ebp", "esi", "edi"];

                if (rm != 4 && rm != 5 && srcReg != rm) // skip self-store, no SIB
                {
                    if (mod == 2)
                    {
                        var disp = BitConverter.ToUInt32(exe, off + 2);
                        if (disp is > 0 and < 0x10000)
                            fields.Add(new FieldStore(va, disp, "dword", regNames[srcReg]));
                    }
                    else if (mod == 1)
                    {
                        uint disp = exe[off + 2];
                        if (disp > 0)
                            fields.Add(new FieldStore(va, disp, "dword", regNames[srcReg]));
                    }
                }
            }

            // ---- FLOAT stores ----

            // F3 0F 11 [modrm] — movss [reg+disp], xmmN
            if (exe[off] == 0xF3 && off + 1 < exe.Length && exe[off + 1] == 0x0F &&
                off + 2 < exe.Length && exe[off + 2] == 0x11)
            {
                var modrm = exe[off + 3];
                var mod = (modrm >> 6) & 3;
                var src = (modrm >> 3) & 7;
                var rm = modrm & 7;

                if (rm != 4 && rm != 5)
                {
                    if (mod == 2 && off + 8 <= exe.Length)
                    {
                        var disp = BitConverter.ToUInt32(exe, off + 4);
                        if (disp is > 0 and < 0x10000)
                            fields.Add(new FieldStore(va, disp, "float", $"xmm{src}"));
                    }
                    else if (mod == 1 && off + 5 <= exe.Length)
                    {
                        uint disp = exe[off + 4];
                        if (disp > 0)
                            fields.Add(new FieldStore(va, disp, "float", $"xmm{src}"));
                    }
                }
            }

            // ---- DOUBLE stores ----

            // F2 0F 11 [modrm] — movsd [reg+disp], xmmN
            if (exe[off] == 0xF2 && off + 1 < exe.Length && exe[off + 1] == 0x0F &&
                off + 2 < exe.Length && exe[off + 2] == 0x11)
            {
                var modrm = exe[off + 3];
                var mod = (modrm >> 6) & 3;
                var src = (modrm >> 3) & 7;
                var rm = modrm & 7;

                if (rm != 4 && rm != 5)
                {
                    if (mod == 2 && off + 8 <= exe.Length)
                    {
                        var disp = BitConverter.ToUInt32(exe, off + 4);
                        if (disp is > 0 and < 0x10000)
                            fields.Add(new FieldStore(va, disp, "double", $"xmm{src}"));
                    }
                    else if (mod == 1 && off + 5 <= exe.Length)
                    {
                        uint disp = exe[off + 4];
                        if (disp > 0)
                            fields.Add(new FieldStore(va, disp, "double", $"xmm{src}"));
                    }
                }
            }
        }

        return fields.DistinctBy(f => f.Offset).OrderBy(f => f.Offset).ToList();
    }

    public static List<SubObject> ExtractSubObjects(byte[] exe, uint ctorVA,
        List<RttiDumper.RttiEntry>? rttiEntries = null)
    {
        var subObjects = new List<SubObject>();
        var fileOff = (int)(ctorVA - ImageBase);
        var scanLen = 8192;

        var vtableNames = BuildVtableNameMap(rttiEntries);

        for (var i = 0; i < scanLen && fileOff + i < exe.Length - 10; i++)
        {
            var off = fileOff + i;
            if (exe[off] != 0x8D) continue;

            uint disp;
            int leaLen;
            var modrm = exe[off + 1];
            var mod = (modrm >> 6) & 3;
            var rm = modrm & 7;

            if (rm == 4 || rm == 5) continue; // skip SIB and disp-only

            if (mod == 2) // LEA reg, [rm+disp32]
            {
                disp = BitConverter.ToUInt32(exe, off + 2);
                leaLen = 6;
            }
            else if (mod == 1) // LEA reg, [rm+disp8]
            {
                disp = exe[off + 2];
                leaLen = 3;
            }
            else continue;

            if (disp is 0 or > 0x10000) continue;

            // Only match if destination is ecx (for thiscall)
            var dstReg = (modrm >> 3) & 7;
            if (dstReg != 1) continue; // ecx = 1

            uint ctorTarget = 0;
            for (var j = leaLen; j < 30 && off + j < exe.Length - 5; j++)
            {
                if (exe[off + j] != 0xE8) continue;
                var rel = BitConverter.ToInt32(exe, off + j + 1);
                ctorTarget = (uint)(off + j + 5 + ImageBase + rel);
                break;
            }

            if (ctorTarget == 0) continue;

            var (vtable, className) = FindVtableInFunction(exe, ctorTarget, vtableNames);
            subObjects.Add(new SubObject(disp, ctorTarget, className, vtable));
        }

        return subObjects.DistinctBy(s => s.Offset).OrderBy(s => s.Offset).ToList();
    }

    public static List<InheritanceInfo> ExtractBaseCtorCalls(byte[] exe, uint ctorVA,
        List<RttiDumper.RttiEntry>? rttiEntries = null)
    {
        var bases = new List<InheritanceInfo>();
        var fileOff = (int)(ctorVA - ImageBase);
        var vtableNames = BuildVtableNameMap(rttiEntries);

        // Scan early part of ctor for: MOV ecx, esi (or edi/ebx); CALL <base_ctor>
        // This is how MSVC calls base constructors (this ptr passed in ecx unchanged)
        for (var i = 0; i < 200 && fileOff + i < exe.Length - 7; i++)
        {
            var off = fileOff + i;

            // MOV ecx, esi: 8B CE / MOV ecx, edi: 8B CF / MOV ecx, ebx: 8B CB
            bool isThisPassthrough = (exe[off] == 0x8B && exe[off + 1] is 0xCE or 0xCF or 0xCB);
            // Or PUSH esi; ... but MOV ecx is the standard thiscall pattern
            if (!isThisPassthrough) continue;

            // Find CALL within next 10 bytes
            for (var j = 2; j < 10 && off + j < exe.Length - 5; j++)
            {
                if (exe[off + j] != 0xE8) continue;
                var rel = BitConverter.ToInt32(exe, off + j + 1);
                var target = (uint)(off + j + 5 + ImageBase + rel);

                if (target < ImageBase + TextStart || target >= ImageBase + TextEnd) continue;

                var (vtable, className) = FindVtableInFunction(exe, target, vtableNames);
                if (className != null)
                {
                    var baseFields = ExtractFieldStores(exe, target);
                    bases.Add(new InheritanceInfo(className, target, vtable, baseFields));
                }
                break;
            }
        }

        return bases;
    }

    private static Dictionary<uint, string> BuildVtableNameMap(List<RttiDumper.RttiEntry>? rttiEntries)
    {
        var vtableNames = new Dictionary<uint, string>();
        if (rttiEntries != null)
            foreach (var e in rttiEntries.Where(e => e.VTableVA.HasValue))
                vtableNames.TryAdd(e.VTableVA!.Value, e.DemangledName);
        return vtableNames;
    }

    private static (uint? vtable, string? className) FindVtableInFunction(
        byte[] exe, uint funcVA, Dictionary<uint, string> vtableNames)
    {
        var funcOff = (int)(funcVA - ImageBase);
        if (funcOff < 0 || funcOff >= exe.Length - 10) return (null, null);

        for (var k = 0; k < 300 && funcOff + k < exe.Length - 6; k++)
        {
            if (exe[funcOff + k] != 0xC7) continue;
            var modrm = exe[funcOff + k + 1];
            var mod = (modrm >> 6) & 3;
            var reg = (modrm >> 3) & 7;
            var rm = modrm & 7;

            if (reg != 0) continue; // must be MOV [r/m], imm32

            int immOff;
            if (mod == 0 && rm != 4 && rm != 5) immOff = 2;
            else if (mod == 1 && rm != 4) immOff = 3;
            else continue;

            if (funcOff + k + immOff + 4 > exe.Length) continue;

            var vt = BitConverter.ToUInt32(exe, funcOff + k + immOff);
            if (vt is >= 0x00F40000 and <= 0x01200000)
            {
                vtableNames.TryGetValue(vt, out var name);
                return (vt, name);
            }
        }

        return (null, null);
    }

    public static void DumpAnalysis(StructLayout layout, TextWriter writer)
    {
        writer.WriteLine($"// {layout.ClassName}");
        writer.WriteLine($"// VTable: {(layout.VtableVA.HasValue ? $"0x{layout.VtableVA.Value:X8}" : "none")} ({layout.VtableEntryCount} vfuncs)");
        writer.WriteLine($"// Ctor:   0x{layout.CtorVA:X8}");
        writer.WriteLine($"// Size:   {(layout.AllocSize.HasValue ? $"0x{layout.AllocSize.Value:X} ({layout.AllocSize.Value} bytes)" : "unknown")}");
        writer.WriteLine();

        if (layout.BaseCtors is { Count: > 0 })
        {
            writer.WriteLine("// === Base Class Constructors ===");
            foreach (var b in layout.BaseCtors)
            {
                var vt = b.VtableVA.HasValue ? $"vt=0x{b.VtableVA.Value:X8}" : "no vtable";
                writer.WriteLine($"//   {b.ClassName} (ctor=0x{b.CtorVA:X8}, {vt}, {b.Fields.Count} fields)");
            }
            writer.WriteLine();
        }

        writer.WriteLine($"// === Fields (from constructor init) === [{layout.Fields.Count} total]");
        foreach (var f in layout.Fields)
            writer.WriteLine($"// +0x{f.Offset:X4} [{f.Type,-6}] = {f.Value}  (@ 0x{f.VA:X8})");

        if (layout.SubObjects.Count > 0)
        {
            writer.WriteLine();
            writer.WriteLine($"// === Embedded Sub-Objects === [{layout.SubObjects.Count} total]");
            foreach (var s in layout.SubObjects)
            {
                var name = s.ClassName ?? "unknown";
                var vt = s.VtableVA.HasValue ? $"vt=0x{s.VtableVA.Value:X8}" : "no vtable";
                writer.WriteLine($"// +0x{s.Offset:X4} {name} ({vt}, ctor=0x{s.CtorVA:X8})");
            }
        }
    }

    private static string GetExePath(byte[] _) =>
        @"E:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV\ffxivgame.exe";
}
