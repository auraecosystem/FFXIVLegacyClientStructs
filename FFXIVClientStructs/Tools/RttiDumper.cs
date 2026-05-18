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
        int? VtableEntryCount,
        List<string>? BaseClasses = null);

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

            List<string>? baseClasses = null;
            if (colVA.HasValue)
            {
                var colFileOff = (int)(colVA.Value - ImageBase);
                var chdVA = BitConverter.ToUInt32(bytes, colFileOff + 16);
                if (chdVA >= ImageBase && chdVA < ImageBase + (uint)bytes.Length)
                {
                    var chdFileOff = (int)(chdVA - ImageBase);
                    var numBases = BitConverter.ToInt32(bytes, chdFileOff + 8);
                    var bcaVA = BitConverter.ToUInt32(bytes, chdFileOff + 12);

                    if (numBases is > 0 and < 100 && bcaVA >= ImageBase && bcaVA < ImageBase + (uint)bytes.Length)
                    {
                        baseClasses = new List<string>();
                        var bcaFileOff = (int)(bcaVA - ImageBase);
                        for (var b = 1; b < numBases; b++)
                        {
                            var bcdVA = BitConverter.ToUInt32(bytes, bcaFileOff + (b * 4));
                            if (bcdVA < ImageBase || bcdVA >= ImageBase + (uint)bytes.Length) continue;
                            var bcdFileOff = (int)(bcdVA - ImageBase);
                            var baseTdVA = BitConverter.ToUInt32(bytes, bcdFileOff);
                            if (baseTdVA < ImageBase || baseTdVA >= ImageBase + (uint)bytes.Length) continue;
                            var baseTdFileOff = (int)(baseTdVA - ImageBase);
                            var baseTdNameOff = baseTdFileOff + 8;
                            if (baseTdNameOff < bytes.Length)
                            {
                                var nameEnd = baseTdNameOff;
                                while (nameEnd < bytes.Length && bytes[nameEnd] != 0) nameEnd++;
                                var baseName = Encoding.ASCII.GetString(bytes, baseTdNameOff, nameEnd - baseTdNameOff);
                                if (baseName.StartsWith(".?AV"))
                                    baseClasses.Add(Demangle(baseName));
                            }
                        }
                    }
                }
            }

            results.Add(new RttiEntry(mangledName, demangled, tdVA, colVA, vtVA, firstEntry, vtCount, baseClasses));
            idx = end;
        }

        return results;
    }

    public static string Demangle(string mangled)
    {
        var name = mangled;
        if (name.StartsWith(".?AV")) name = name[4..];
        else if (name.StartsWith(".?AU")) name = name[4..]; // struct tag
        if (name.EndsWith("@@")) name = name[..^2];

        // Handle template instantiations: V?$ClassName@VParam@ns@@@ns@@
        if (name.StartsWith("?$"))
        {
            name = name[2..];
            var atIdx = name.IndexOf('@');
            if (atIdx > 0)
            {
                var templateName = name[..atIdx];
                var rest = name[(atIdx + 1)..];
                var templateParams = new List<string>();
                var outerParts = new List<string>();
                var depth = 0;
                var current = new StringBuilder();

                foreach (var c in rest)
                {
                    if (c == '@')
                    {
                        if (current.Length > 0)
                        {
                            if (current.ToString().StartsWith("V") || current.ToString().StartsWith("U"))
                            {
                                if (depth == 0)
                                    templateParams.Add(current.ToString()[1..]);
                                else
                                    outerParts.Add(current.ToString());
                            }
                            else
                                outerParts.Add(current.ToString());
                            current.Clear();
                        }
                    }
                    else
                        current.Append(c);
                }

                outerParts.Reverse();
                var ns = outerParts.Count > 0 ? string.Join("::", outerParts) + "::" : "";
                var tparams = templateParams.Count > 0 ? $"<{string.Join(", ", templateParams)}>" : "";
                return $"{ns}{templateName}{tparams}";
            }
        }

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

    public static void DumpHierarchy(string exePath, string className, TextWriter writer)
    {
        var entries = ExtractAll(exePath);
        var entry = entries.FirstOrDefault(e =>
            e.DemangledName.Contains(className, StringComparison.OrdinalIgnoreCase));

        if (entry == null)
            throw new InvalidOperationException($"Class '{className}' not found in RTTI");

        writer.WriteLine($"// Inheritance hierarchy for: {entry.DemangledName}");
        writer.WriteLine();

        if (entry.BaseClasses != null && entry.BaseClasses.Count > 0)
        {
            writer.WriteLine("// Direct + transitive bases:");
            foreach (var bc in entry.BaseClasses)
            {
                var baseEntry = entries.FirstOrDefault(e => e.DemangledName == bc);
                var vtInfo = baseEntry?.VTableVA != null ? $"vt=0x{baseEntry.VTableVA.Value:X8}" : "no vtable";
                writer.WriteLine($"//   <- {bc} ({vtInfo})");
            }
        }
        else
            writer.WriteLine("// No base classes (root type)");

        writer.WriteLine();
        writer.WriteLine("// Derived classes:");
        var derived = entries.Where(e =>
            e.BaseClasses != null && e.BaseClasses.Contains(entry.DemangledName)).ToList();

        if (derived.Count > 0)
            foreach (var d in derived.OrderBy(d => d.DemangledName))
                writer.WriteLine($"//   -> {d.DemangledName}");
        else
            writer.WriteLine("//   (none found)");
    }

    public static List<RttiEntry> SearchClasses(string exePath, string pattern)
    {
        var entries = ExtractAll(exePath);
        return entries.Where(e =>
            e.DemangledName.Contains(pattern, StringComparison.OrdinalIgnoreCase) ||
            e.MangledName.Contains(pattern, StringComparison.OrdinalIgnoreCase))
            .OrderBy(e => e.DemangledName)
            .ToList();
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
