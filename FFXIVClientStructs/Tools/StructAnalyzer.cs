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

    public record StructLayout(
        string ClassName,
        uint? VtableVA,
        int VtableEntryCount,
        uint CtorVA,
        uint? AllocSize,
        List<FieldStore> Fields,
        List<SubObject> SubObjects);

    public static StructLayout Analyze(byte[] exe, string className)
    {
        var rttiEntries = RttiDumper.ExtractAll(GetExePath(exe));

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

        return new StructLayout(
            entry.DemangledName,
            entry.VTableVA,
            entry.VtableEntryCount ?? 0,
            ctorVA,
            allocSize,
            fields,
            subObjects);
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
        var scanLen = 4096;

        for (var i = 0; i < scanLen && fileOff + i < exe.Length - 10; i++)
        {
            var off = fileOff + i;
            var va = ctorVA + (uint)i;

            // C7 86 disp32 imm32 — mov [esi+disp32], imm32
            if (exe[off] == 0xC7 && exe[off + 1] == 0x86)
            {
                var disp = BitConverter.ToUInt32(exe, off + 2);
                var imm = BitConverter.ToUInt32(exe, off + 6);
                if (disp is > 0 and < 0x10000)
                    fields.Add(new FieldStore(va, disp, "dword", $"0x{imm:X8}"));
            }

            // C7 46 disp8 imm32 — mov [esi+disp8], imm32
            if (exe[off] == 0xC7 && exe[off + 1] == 0x46)
            {
                var disp = exe[off + 2];
                var imm = BitConverter.ToUInt32(exe, off + 3);
                if (disp > 0)
                    fields.Add(new FieldStore(va, disp, "dword", $"0x{imm:X8}"));
            }

            // F3 0F 11 86 disp32 — movss [esi+disp32], xmmN
            if (exe[off] == 0xF3 && exe[off + 1] == 0x0F && exe[off + 2] == 0x11 &&
                exe[off + 3] == 0x86)
            {
                var disp = BitConverter.ToUInt32(exe, off + 4);
                var src = (exe[off + 3] >> 3) & 7;
                if (disp is > 0 and < 0x10000)
                    fields.Add(new FieldStore(va, disp, "float", $"xmm{src}"));
            }

            // C6 86 disp32 imm8 — mov byte [esi+disp32], imm8
            if (exe[off] == 0xC6 && exe[off + 1] == 0x86)
            {
                var disp = BitConverter.ToUInt32(exe, off + 2);
                var imm = exe[off + 6];
                if (disp is > 0 and < 0x10000)
                    fields.Add(new FieldStore(va, disp, "byte", $"0x{imm:X2}"));
            }

            // 66 89 9E disp32 — mov word [esi+disp32], bx
            if (exe[off] == 0x66 && exe[off + 1] == 0x89 && exe[off + 2] == 0x9E)
            {
                var disp = BitConverter.ToUInt32(exe, off + 3);
                if (disp is > 0 and < 0x10000)
                    fields.Add(new FieldStore(va, disp, "word", "bx"));
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

        // Build vtable -> name map
        var vtableNames = new Dictionary<uint, string>();
        if (rttiEntries != null)
            foreach (var e in rttiEntries.Where(e => e.VTableVA.HasValue))
                vtableNames.TryAdd(e.VTableVA!.Value, e.DemangledName);

        for (var i = 0; i < scanLen && fileOff + i < exe.Length - 10; i++)
        {
            var off = fileOff + i;

            // LEA ecx, [esi+disp32]: 8D 8E xx xx xx xx
            if (exe[off] != 0x8D || exe[off + 1] != 0x8E) continue;
            var disp = BitConverter.ToUInt32(exe, off + 2);
            if (disp is 0 or > 0x10000) continue;

            // Find the CALL that follows
            uint ctorTarget = 0;
            for (var j = 6; j < 30 && off + j < exe.Length - 5; j++)
            {
                if (exe[off + j] != 0xE8) continue;
                var rel = BitConverter.ToInt32(exe, off + j + 1);
                ctorTarget = (uint)(off + j + 5 + ImageBase + rel);
                break;
            }

            if (ctorTarget == 0) continue;

            // Find vtable in sub-constructor
            var subCtorOff = (int)(ctorTarget - ImageBase);
            uint? vtable = null;
            string? className = null;

            for (var k = 0; k < 300 && subCtorOff + k < exe.Length - 6; k++)
            {
                if (exe[subCtorOff + k] == 0xC7 &&
                    (exe[subCtorOff + k + 1] is 0x01 or 0x06 or 0x00 or 0x07))
                {
                    var vt = BitConverter.ToUInt32(exe, subCtorOff + k + 2);
                    if (vt is >= 0x00F40000 and <= 0x01200000)
                    {
                        vtable = vt;
                        vtableNames.TryGetValue(vt, out className);
                        break;
                    }
                }
            }

            subObjects.Add(new SubObject(disp, ctorTarget, className, vtable));
        }

        return subObjects.DistinctBy(s => s.Offset).OrderBy(s => s.Offset).ToList();
    }

    public static void DumpAnalysis(StructLayout layout, TextWriter writer)
    {
        writer.WriteLine($"// {layout.ClassName}");
        writer.WriteLine($"// VTable: {(layout.VtableVA.HasValue ? $"0x{layout.VtableVA.Value:X8}" : "none")} ({layout.VtableEntryCount} vfuncs)");
        writer.WriteLine($"// Ctor:   0x{layout.CtorVA:X8}");
        writer.WriteLine($"// Size:   {(layout.AllocSize.HasValue ? $"0x{layout.AllocSize.Value:X} ({layout.AllocSize.Value} bytes)" : "unknown")}");
        writer.WriteLine();

        writer.WriteLine("// === Fields (from constructor init) ===");
        foreach (var f in layout.Fields)
            writer.WriteLine($"// +0x{f.Offset:X4} [{f.Type,-5}] = {f.Value}  (@ 0x{f.VA:X8})");

        writer.WriteLine();
        writer.WriteLine("// === Embedded Sub-Objects ===");
        foreach (var s in layout.SubObjects)
        {
            var name = s.ClassName ?? "unknown";
            var vt = s.VtableVA.HasValue ? $"vt=0x{s.VtableVA.Value:X8}" : "no vtable";
            writer.WriteLine($"// +0x{s.Offset:X4} {name} ({vt}, ctor=0x{s.CtorVA:X8})");
        }
    }

    private static string GetExePath(byte[] _) =>
        @"E:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV\ffxivgame.exe";
}
