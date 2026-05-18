using System.Runtime.InteropServices;
using System.Text;

namespace FFXIVClientStructs.Tools;

/// <summary>
/// Extracts RTTI information from ffxivgame.exe (1.23b, x86 MSVC)
/// including TypeDescriptors, Complete Object Locators, and vtable addresses.
/// </summary>
public static class RttiDumper
{
    public const uint ImageBase = 0x00400000;
    public const int RdataFileStart = 0x00B3E000;
    public const int RdataFileEnd = 0x00B3E000 + 0x00327000;
    public const uint TextVAStart = 0x00401000;
    public const uint TextVAEnd = 0x00F3D000;

    public record RttiEntry(
        string MangledName,
        string DemangledName,
        uint TypeDescriptorVA,
        uint? CompleteObjectLocatorVA,
        uint? VTableVA,
        uint? FirstVtableEntry,
        int? VtableEntryCount);

    public static List<RttiEntry> ExtractAll(string exePath)
    {
        var bytes = File.ReadAllBytes(exePath);
        var text = Encoding.ASCII.GetString(bytes);
        var results = new List<RttiEntry>();

        var idx = 0;
        while (true)
        {
            idx = text.IndexOf(".?AV", idx, StringComparison.Ordinal);
            if (idx < 0) break;

            var end = text.IndexOf("@@", idx, StringComparison.Ordinal);
            if (end < 0) { idx++; continue; }
            end += 2;

            if (end < text.Length && text[end] == '@') end++;

            var mangledName = text[idx..end];
            var tdFileOff = idx - 8;
            var tdVA = (uint)(tdFileOff + ImageBase);

            var demangled = Demangle(mangledName);

            // Find COL referencing this TypeDescriptor
            uint? colVA = null;
            uint? vtVA = null;
            uint? firstEntry = null;
            int? vtCount = null;

            var tdBytes = BitConverter.GetBytes(tdVA);
            for (var i = RdataFileStart; i < RdataFileEnd - 20; i += 4)
            {
                if (bytes[i + 12] == tdBytes[0] && bytes[i + 13] == tdBytes[1] &&
                    bytes[i + 14] == tdBytes[2] && bytes[i + 15] == tdBytes[3])
                {
                    var sig = BitConverter.ToUInt32(bytes, i);
                    if (sig != 0) continue; // x86 COL signature = 0
                    colVA = (uint)(i + ImageBase);

                    // Find vtable: scan for pointer to COL (vtable[-1])
                    var colBytes = BitConverter.GetBytes(colVA.Value);
                    for (var j = RdataFileStart; j < RdataFileEnd - 4; j += 4)
                    {
                        if (bytes[j] == colBytes[0] && bytes[j + 1] == colBytes[1] &&
                            bytes[j + 2] == colBytes[2] && bytes[j + 3] == colBytes[3])
                        {
                            var candidateVt = (uint)(j + 4 + ImageBase);
                            var first = BitConverter.ToUInt32(bytes, j + 4);
                            if (first >= TextVAStart && first < TextVAEnd)
                            {
                                vtVA = candidateVt;
                                firstEntry = first;

                                // Count vtable entries
                                var count = 0;
                                for (var k = 0; k < 500; k++)
                                {
                                    var entry = BitConverter.ToUInt32(bytes, j + 4 + (k * 4));
                                    if (entry < TextVAStart || entry >= TextVAEnd) break;
                                    count++;
                                }
                                vtCount = count;
                                break;
                            }
                        }
                    }
                    break;
                }
            }

            results.Add(new RttiEntry(mangledName, demangled, tdVA, colVA, vtVA, firstEntry, vtCount));
            idx = end;
        }

        return results;
    }

    public static string Demangle(string mangled)
    {
        // Strip .?AV prefix and trailing @@
        var name = mangled;
        if (name.StartsWith(".?AV")) name = name[4..];
        if (name.EndsWith("@@")) name = name[..^2];

        // Split by @ and reverse to get C++ namespace::class
        var parts = name.Split('@', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(parts);
        return string.Join("::", parts);
    }

    public static void DumpToFile(string exePath, string outputPath)
    {
        var entries = ExtractAll(exePath);
        using var writer = new StreamWriter(outputPath);

        writer.WriteLine($"// FFXIV 1.0 (1.23b) RTTI Database — {entries.Count} classes");
        writer.WriteLine($"// Generated from: {Path.GetFileName(exePath)}");
        writer.WriteLine($"// Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        writer.WriteLine();
        writer.WriteLine("// Format: Demangled | VTable VA | VFunc Count | TypeDescriptor VA | Mangled");
        writer.WriteLine("// -------------------------------------------------------------------------");

        foreach (var e in entries.OrderBy(x => x.DemangledName))
        {
            var vt = e.VTableVA.HasValue ? $"0x{e.VTableVA.Value:X8}" : "          ";
            var count = e.VtableEntryCount.HasValue ? $"{e.VtableEntryCount.Value,3}" : "   ";
            writer.WriteLine($"{e.DemangledName,-90} | {vt} | {count} | 0x{e.TypeDescriptorVA:X8} | {e.MangledName}");
        }
    }

    public static void DumpVtable(string exePath, string className, string outputPath)
    {
        var entries = ExtractAll(exePath);
        var entry = entries.FirstOrDefault(e =>
            e.DemangledName.Contains(className, StringComparison.OrdinalIgnoreCase));

        if (entry == null || !entry.VTableVA.HasValue)
            throw new InvalidOperationException($"Class '{className}' not found or has no vtable");

        var bytes = File.ReadAllBytes(exePath);
        var fileOff = (int)(entry.VTableVA.Value - ImageBase);

        using var writer = new StreamWriter(outputPath);
        writer.WriteLine($"// {entry.DemangledName}");
        writer.WriteLine($"// VTable: 0x{entry.VTableVA.Value:X8} ({entry.VtableEntryCount} entries)");
        writer.WriteLine();

        for (var i = 0; i < entry.VtableEntryCount; i++)
        {
            var addr = BitConverter.ToUInt32(bytes, fileOff + (i * 4));
            writer.WriteLine($"vt[{i,3}] = 0x{addr:X8}");
        }
    }
}
