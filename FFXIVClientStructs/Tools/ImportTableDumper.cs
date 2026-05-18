using System.Text;

namespace FFXIVClientStructs.Tools;

/// <summary>
/// Extracts the import table from ffxivgame.exe (x86 PE) to document
/// which DLLs and functions the game depends on.
/// </summary>
public static class ImportTableDumper
{
    public const uint ImageBase = 0x00400000;

    public record ImportEntry(string DllName, List<string> Functions);

    public static List<ImportEntry> Extract(string exePath)
    {
        var bytes = File.ReadAllBytes(exePath);
        var peOff = BitConverter.ToInt32(bytes, 0x3C);
        var optOff = peOff + 24;

        var numSections = BitConverter.ToUInt16(bytes, peOff + 6);
        var optHeaderSize = BitConverter.ToUInt16(bytes, peOff + 20);
        var sectionTableOff = peOff + 24 + optHeaderSize;

        var importDirRVA = BitConverter.ToUInt32(bytes, optOff + 104);
        if (importDirRVA == 0) return new();

        var importFileOff = RvaToFileOffset(bytes, importDirRVA, sectionTableOff, numSections);
        if (importFileOff < 0) return new();

        var results = new List<ImportEntry>();

        for (var i = 0; ; i++)
        {
            var entryOff = importFileOff + (i * 20);
            var nameRVA = BitConverter.ToUInt32(bytes, entryOff + 12);
            if (nameRVA == 0) break;

            var nameFileOff = RvaToFileOffset(bytes, nameRVA, sectionTableOff, numSections);
            if (nameFileOff < 0) continue;

            var dllName = ReadCString(bytes, nameFileOff);
            var functions = new List<string>();

            var iltRVA = BitConverter.ToUInt32(bytes, entryOff);
            if (iltRVA == 0) iltRVA = BitConverter.ToUInt32(bytes, entryOff + 16);
            if (iltRVA == 0) { results.Add(new(dllName, functions)); continue; }

            var iltFileOff = RvaToFileOffset(bytes, iltRVA, sectionTableOff, numSections);
            if (iltFileOff < 0) { results.Add(new(dllName, functions)); continue; }

            for (var j = 0; ; j++)
            {
                var thunkVal = BitConverter.ToUInt32(bytes, iltFileOff + (j * 4));
                if (thunkVal == 0) break;

                if ((thunkVal & 0x80000000) != 0)
                {
                    functions.Add($"Ordinal #{thunkVal & 0xFFFF}");
                }
                else
                {
                    var hintNameFileOff = RvaToFileOffset(bytes, thunkVal, sectionTableOff, numSections);
                    if (hintNameFileOff >= 0)
                    {
                        var funcName = ReadCString(bytes, hintNameFileOff + 2);
                        functions.Add(funcName);
                    }
                }
            }

            results.Add(new(dllName, functions));
        }

        return results;
    }

    public static void DumpToFile(string exePath, string outputPath)
    {
        var imports = Extract(exePath);
        using var writer = new StreamWriter(outputPath);

        writer.WriteLine($"// FFXIV 1.0 (1.23b) Import Table");
        writer.WriteLine($"// Generated from: {Path.GetFileName(exePath)}");
        writer.WriteLine();

        foreach (var dll in imports)
        {
            writer.WriteLine($"[{dll.DllName}] ({dll.Functions.Count} imports)");
            foreach (var func in dll.Functions)
                writer.WriteLine($"  {func}");
            writer.WriteLine();
        }
    }

    private static int RvaToFileOffset(byte[] pe, uint rva, int sectionTableOff, int numSections)
    {
        for (var i = 0; i < numSections; i++)
        {
            var secOff = sectionTableOff + (i * 40);
            var va = BitConverter.ToUInt32(pe, secOff + 12);
            var rawSize = BitConverter.ToUInt32(pe, secOff + 16);
            var rawPtr = BitConverter.ToUInt32(pe, secOff + 20);
            var vSize = BitConverter.ToUInt32(pe, secOff + 8);

            if (rva >= va && rva < va + Math.Max(vSize, rawSize))
                return (int)(rawPtr + (rva - va));
        }
        return -1;
    }

    private static string ReadCString(byte[] data, int offset)
    {
        var end = offset;
        while (end < data.Length && data[end] != 0) end++;
        return Encoding.ASCII.GetString(data, offset, end - offset);
    }
}
