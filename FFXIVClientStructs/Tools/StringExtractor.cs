using System.Text;

namespace FFXIVClientStructs.Tools;

public static class StringExtractor
{
    public const uint ImageBase = 0x00400000;
    public const int TextStart = 0x1000;
    public const int TextEnd = 0xB3C000;
    public const int RdataStart = 0x00B3E000;
    public const int RdataEnd = 0x00B3E000 + 0x00327000;

    public record StringRef(uint InstructionVA, uint StringVA, string Value);

    public static List<StringRef> ExtractFromFunction(byte[] exe, uint funcVA, int maxScanBytes = 4096)
    {
        var results = new List<StringRef>();
        var funcOff = (int)(funcVA - ImageBase);
        if (funcOff < 0 || funcOff >= exe.Length) return results;

        var seen = new HashSet<uint>();

        for (var i = 0; i < maxScanBytes && funcOff + i < exe.Length - 5; i++)
        {
            var off = funcOff + i;
            var va = funcVA + (uint)i;
            uint strVA = 0;

            // PUSH imm32 (68 xx xx xx xx) — string pointer as function argument
            if (exe[off] == 0x68)
            {
                strVA = BitConverter.ToUInt32(exe, off + 1);
            }
            // MOV reg, imm32 (B8+r xx xx xx xx) — loading string address into register
            else if (exe[off] is >= 0xB8 and <= 0xBF)
            {
                strVA = BitConverter.ToUInt32(exe, off + 1);
            }
            // MOV [reg+disp], imm32 — could be storing a string pointer
            else if (exe[off] == 0xC7)
            {
                var modrm = exe[off + 1];
                var mod = (modrm >> 6) & 3;
                var reg = (modrm >> 3) & 7;
                var rm = modrm & 7;
                if (reg == 0 && rm != 4 && rm != 5)
                {
                    if (mod == 2 && off + 10 <= exe.Length)
                        strVA = BitConverter.ToUInt32(exe, off + 6);
                    else if (mod == 1 && off + 7 <= exe.Length)
                        strVA = BitConverter.ToUInt32(exe, off + 3);
                }
            }

            if (strVA == 0) continue;

            var strFileOff = (int)(strVA - ImageBase);
            if (strFileOff < RdataStart || strFileOff >= RdataEnd) continue;
            if (seen.Contains(strVA)) continue;

            var str = ReadCString(exe, strFileOff, 256);
            if (str == null || str.Length < 2) continue;
            if (!IsPrintable(str)) continue;

            seen.Add(strVA);
            results.Add(new StringRef(va, strVA, str));
        }

        return results;
    }

    public static List<StringRef> FindStringXrefs(byte[] exe, string searchString)
    {
        var results = new List<StringRef>();

        // Find the string in .rdata
        var searchBytes = Encoding.ASCII.GetBytes(searchString);
        var strVAs = new List<uint>();

        for (var i = RdataStart; i < RdataEnd - searchBytes.Length; i++)
        {
            var match = true;
            for (var j = 0; j < searchBytes.Length; j++)
            {
                if (exe[i + j] != searchBytes[j]) { match = false; break; }
            }
            if (match && (i + searchBytes.Length >= exe.Length || exe[i + searchBytes.Length] == 0))
                strVAs.Add((uint)(i + ImageBase));
        }

        foreach (var strVA in strVAs)
        {
            var strBytes = BitConverter.GetBytes(strVA);
            var str = ReadCString(exe, (int)(strVA - ImageBase), 256) ?? searchString;

            for (var i = TextStart; i < TextEnd - 5; i++)
            {
                // PUSH imm32
                if (exe[i] == 0x68 &&
                    exe[i + 1] == strBytes[0] && exe[i + 2] == strBytes[1] &&
                    exe[i + 3] == strBytes[2] && exe[i + 4] == strBytes[3])
                {
                    results.Add(new StringRef((uint)(i + ImageBase), strVA, str));
                }
            }
        }

        return results;
    }

    private static string? ReadCString(byte[] data, int offset, int maxLen)
    {
        if (offset < 0 || offset >= data.Length) return null;
        var end = offset;
        while (end < data.Length && end - offset < maxLen && data[end] != 0) end++;
        if (end == offset) return null;
        return Encoding.ASCII.GetString(data, offset, end - offset);
    }

    private static bool IsPrintable(string s)
    {
        foreach (var c in s)
            if (c < 0x20 || c > 0x7E) return false;
        return true;
    }
}
