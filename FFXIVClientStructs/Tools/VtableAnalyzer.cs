using System.Text;

namespace FFXIVClientStructs.Tools;

public static class VtableAnalyzer
{
    public const uint ImageBase = 0x00400000;
    public const uint TextVAStart = 0x00401000;
    public const uint TextVAEnd = 0x00F3D000;

    public record VtableFunction(
        int Index,
        uint Address,
        int EstimatedSize,
        int StackParamBytes,
        bool IsPureVirtual,
        bool IsStub,
        string? Signature);

    public static List<VtableFunction> AnalyzeVtable(byte[] exe, uint vtableVA, int entryCount)
    {
        var results = new List<VtableFunction>();
        var vtFileOff = (int)(vtableVA - ImageBase);

        for (var i = 0; i < entryCount; i++)
        {
            var funcVA = BitConverter.ToUInt32(exe, vtFileOff + (i * 4));
            if (funcVA < TextVAStart || funcVA >= TextVAEnd)
            {
                results.Add(new VtableFunction(i, funcVA, 0, 0, false, false, null));
                continue;
            }

            var funcOff = (int)(funcVA - ImageBase);
            var size = EstimateFunctionSize(exe, funcOff);
            var isPure = IsPureVirtualThunk(exe, funcOff);
            var isStub = size <= 6 && !isPure;
            var stackParams = CountStackParameters(exe, funcOff);
            var sig = BuildSignature(exe, funcOff, funcVA, stackParams);

            results.Add(new VtableFunction(i, funcVA, size, stackParams, isPure, isStub, sig));
        }

        return results;
    }

    public static int EstimateFunctionSize(byte[] exe, int funcOff)
    {
        if (funcOff < 0 || funcOff >= exe.Length - 5) return 0;

        for (var i = 0; i < 0x10000 && funcOff + i < exe.Length - 3; i++)
        {
            var off = funcOff + i;

            // RET
            if (exe[off] == 0xC3)
                return i + 1;

            // RET imm16
            if (exe[off] == 0xC2)
                return i + 3;

            // INT3 padding after a RET we might have missed
            if (i > 0 && exe[off] == 0xCC && exe[off - 1] == 0xC3)
                return i;
        }

        return 0;
    }

    public static bool IsPureVirtualThunk(byte[] exe, int funcOff)
    {
        if (funcOff < 0 || funcOff + 10 >= exe.Length) return false;

        // MSVC _purecall: commonly a jmp or call to the CRT purecall handler
        // Pattern: mov ecx, <const>; call _purecall  OR  push <msg>; call _purecall
        // Simplest check: very short function that calls a single target and that target
        // is shared by many vtable entries (heuristic)

        // Check for direct JMP: FF 25 (jmp [addr]) to a known purecall
        if (exe[funcOff] == 0xFF && exe[funcOff + 1] == 0x25)
            return true; // indirect jump thunk — likely purecall

        // Check for: push ebp; mov esp,ebp; push imm; call <purecall>; ...
        // Or ultra-short: call <addr>; int3
        if (exe[funcOff] == 0xE8 && funcOff + 5 < exe.Length)
        {
            if (exe[funcOff + 5] == 0xCC || exe[funcOff + 5] == 0xC3)
                return true;
        }

        return false;
    }

    public static int CountStackParameters(byte[] exe, int funcOff)
    {
        if (funcOff < 0 || funcOff >= exe.Length - 5) return 0;

        // Look for standard prologue: push ebp; mov ebp, esp; sub esp, N
        if (exe[funcOff] != 0x55 || exe[funcOff + 1] != 0x8B || exe[funcOff + 2] != 0xEC)
            return 0;

        // Scan for RET imm16 to get stdcall cleanup size
        for (var i = 3; i < 0x5000 && funcOff + i < exe.Length - 3; i++)
        {
            if (exe[funcOff + i] == 0xC2)
            {
                var cleanupBytes = BitConverter.ToUInt16(exe, funcOff + i + 1);
                if (cleanupBytes is > 0 and <= 0x80)
                    return cleanupBytes;
            }

            if (exe[funcOff + i] == 0xC3)
                return 0; // cdecl or thiscall with no extra params
        }

        return 0;
    }

    public static string BuildSignature(byte[] exe, int funcOff, uint funcVA, int stackParamBytes)
    {
        var sb = new StringBuilder();
        sb.Append($"0x{funcVA:X8}");

        var size = EstimateFunctionSize(exe, funcOff);
        if (size > 0) sb.Append($" ({size}B)");

        // thiscall is default for MSVC virtual functions (ecx = this)
        var paramCount = stackParamBytes / 4;
        sb.Append($" thiscall(this");
        for (var p = 0; p < paramCount; p++)
            sb.Append($", arg{p + 1}");
        sb.Append(')');

        return sb.ToString();
    }

    public static void DumpVtableAnalysis(byte[] exe, RttiDumper.RttiEntry entry, TextWriter writer)
    {
        if (!entry.VTableVA.HasValue || !entry.VtableEntryCount.HasValue) return;

        var funcs = AnalyzeVtable(exe, entry.VTableVA.Value, entry.VtableEntryCount.Value);

        writer.WriteLine($"// {entry.DemangledName}");
        writer.WriteLine($"// VTable: 0x{entry.VTableVA.Value:X8} ({entry.VtableEntryCount} entries)");
        writer.WriteLine();

        var pureCount = funcs.Count(f => f.IsPureVirtual);
        var stubCount = funcs.Count(f => f.IsStub);
        writer.WriteLine($"// Summary: {funcs.Count} total, {pureCount} pure virtual, {stubCount} stubs");
        writer.WriteLine();

        foreach (var f in funcs)
        {
            var flags = new List<string>();
            if (f.IsPureVirtual) flags.Add("PURE");
            if (f.IsStub) flags.Add("STUB");
            var flagStr = flags.Count > 0 ? $" [{string.Join(",", flags)}]" : "";
            writer.WriteLine($"vt[{f.Index,3}] {f.Signature ?? $"0x{f.Address:X8}"}{flagStr}");
        }
    }
}
