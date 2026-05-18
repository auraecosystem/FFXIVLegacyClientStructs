using FFXIVClientStructs.Tools;

const string DefaultExePath = @"E:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV\ffxivgame.exe";
var outputDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!;

Console.WriteLine("=== FFXIV 1.0 (1.23b) Client Analysis Tool ===");
Console.WriteLine();

if (args.Length == 0)
{
    PrintUsage();
    return;
}

var exePath = DefaultExePath;
var argsList = args.ToList();

var exeIdx = argsList.IndexOf("--exe");
if (exeIdx >= 0 && exeIdx + 1 < argsList.Count)
{
    exePath = argsList[exeIdx + 1];
    argsList.RemoveRange(exeIdx, 2);
}

if (!File.Exists(exePath))
{
    Console.WriteLine($"ERROR: Executable not found: {exePath}");
    Console.WriteLine("Use --exe <path> to specify the location of ffxivgame.exe");
    return;
}

var cmd = argsList[0].ToLower();

if (cmd == "--rtti" || cmd == "--all")
{
    Console.Write("Extracting RTTI database...");
    var rttiOut = Path.Combine(outputDir, "ffxiv_1.0_rtti.txt");
    RttiDumper.DumpToFile(exePath, rttiOut);
    var entries = RttiDumper.ExtractAll(exePath);
    var withVt = entries.Count(e => e.VTableVA.HasValue);
    var withBases = entries.Count(e => e.BaseClasses is { Count: > 0 });
    Console.WriteLine($" done! {entries.Count} classes ({withVt} with vtables, {withBases} with inheritance info)");
    Console.WriteLine($"  -> {rttiOut}");
}

if (cmd == "--imports" || cmd == "--all")
{
    Console.Write("Extracting import table...");
    var importOut = Path.Combine(outputDir, "ffxiv_1.0_imports.txt");
    ImportTableDumper.DumpToFile(exePath, importOut);
    Console.WriteLine(" done!");
    Console.WriteLine($"  -> {importOut}");
}

if (cmd == "--vtable" && argsList.Count > 1)
{
    var className = argsList[1];
    Console.Write($"Extracting vtable for '{className}'...");
    var vtOut = Path.Combine(outputDir, $"vtable_{className.Replace("::", "_")}.txt");
    RttiDumper.DumpVtable(exePath, className, vtOut);
    Console.WriteLine(" done!");
    Console.WriteLine($"  -> {vtOut}");
}

if (cmd == "--vtfuncs" && argsList.Count > 1)
{
    var className = argsList[1];
    Console.WriteLine($"Analyzing vtable functions for '{className}'...");
    try
    {
        var entries = RttiDumper.ExtractAll(exePath);
        var entry = entries.FirstOrDefault(e =>
            e.DemangledName.Contains(className, StringComparison.OrdinalIgnoreCase));

        if (entry == null || !entry.VTableVA.HasValue)
            throw new InvalidOperationException($"Class '{className}' not found or has no vtable");

        var exe = File.ReadAllBytes(exePath);
        var outPath = Path.Combine(outputDir, $"vtfuncs_{className.Replace("::", "_")}.txt");
        using var writer = new StreamWriter(outPath);
        VtableAnalyzer.DumpVtableAnalysis(exe, entry, writer);
        VtableAnalyzer.DumpVtableAnalysis(exe, entry, Console.Out);
        Console.WriteLine();
        Console.WriteLine($"  -> {outPath}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"  ERROR: {ex.Message}");
    }
}

if (cmd == "--analyze" && argsList.Count > 1)
{
    var className = argsList[1];
    Console.WriteLine($"Analyzing struct '{className}'...");
    try
    {
        var exe = File.ReadAllBytes(exePath);
        var layout = StructAnalyzer.Analyze(exe, className, exePath);

        var outPath = Path.Combine(outputDir, $"struct_{className.Replace("::", "_")}.txt");
        using var writer = new StreamWriter(outPath);
        StructAnalyzer.DumpAnalysis(layout, writer);

        StructAnalyzer.DumpAnalysis(layout, Console.Out);
        Console.WriteLine();
        Console.WriteLine($"  -> {outPath}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"  ERROR: {ex.Message}");
        Console.WriteLine("  (Class may be abstract, template-only, or use a non-standard init pattern)");
    }
}

if (cmd == "--hierarchy" && argsList.Count > 1)
{
    var className = argsList[1];
    Console.WriteLine($"Building hierarchy for '{className}'...");
    try
    {
        var outPath = Path.Combine(outputDir, $"hierarchy_{className.Replace("::", "_")}.txt");
        using var writer = new StreamWriter(outPath);
        RttiDumper.DumpHierarchy(exePath, className, writer);

        RttiDumper.DumpHierarchy(exePath, className, Console.Out);
        Console.WriteLine();
        Console.WriteLine($"  -> {outPath}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"  ERROR: {ex.Message}");
    }
}

if (cmd == "--search" && argsList.Count > 1)
{
    var pattern = argsList[1];
    Console.WriteLine($"Searching for classes matching '{pattern}'...");
    var matches = RttiDumper.SearchClasses(exePath, pattern);
    Console.WriteLine($"Found {matches.Count} matches:");
    Console.WriteLine();
    foreach (var m in matches)
    {
        var vt = m.VTableVA.HasValue ? $"vt=0x{m.VTableVA.Value:X8}" : "no vtable";
        var count = m.VtableEntryCount.HasValue ? $"{m.VtableEntryCount.Value} vfuncs" : "";
        var bases = m.BaseClasses is { Count: > 0 } ? $" : {string.Join(", ", m.BaseClasses.Take(3))}" : "";
        Console.WriteLine($"  {m.DemangledName,-80} {vt} {count}{bases}");
    }
}

if (cmd == "--strings" && argsList.Count > 1)
{
    var className = argsList[1];
    Console.WriteLine($"Extracting string references for '{className}'...");
    try
    {
        var entries = RttiDumper.ExtractAll(exePath);
        var entry = entries.FirstOrDefault(e =>
            e.DemangledName.Contains(className, StringComparison.OrdinalIgnoreCase));

        if (entry == null)
            throw new InvalidOperationException($"Class '{className}' not found in RTTI");

        var exe = File.ReadAllBytes(exePath);
        var ctorVA = StructAnalyzer.FindConstructor(exe, entry.VTableVA);
        if (ctorVA == 0)
            throw new InvalidOperationException($"Constructor not found for '{className}'");

        var strings = StringExtractor.ExtractFromFunction(exe, ctorVA);

        // Also scan vtable functions for strings
        if (entry.VTableVA.HasValue && entry.VtableEntryCount.HasValue)
        {
            var vtFileOff = (int)(entry.VTableVA.Value - 0x00400000u);
            for (var i = 0; i < Math.Min(entry.VtableEntryCount.Value, 50); i++)
            {
                var funcVA = BitConverter.ToUInt32(exe, vtFileOff + (i * 4));
                if (funcVA >= 0x00401000 && funcVA < 0x00F3D000)
                {
                    var funcStrings = StringExtractor.ExtractFromFunction(exe, funcVA, 2048);
                    foreach (var s in funcStrings)
                        strings.Add(s);
                }
            }
        }

        var unique = strings.DistinctBy(s => s.Value).OrderBy(s => s.Value).ToList();
        var outPath = Path.Combine(outputDir, $"strings_{className.Replace("::", "_")}.txt");
        using var writer = new StreamWriter(outPath);

        writer.WriteLine($"// String references in/around {entry.DemangledName}");
        writer.WriteLine($"// Constructor: 0x{ctorVA:X8}");
        writer.WriteLine($"// {unique.Count} unique strings found");
        writer.WriteLine();

        foreach (var s in unique)
            writer.WriteLine($"0x{s.InstructionVA:X8}  -> 0x{s.StringVA:X8}  \"{s.Value}\"");

        Console.WriteLine($"Found {unique.Count} unique strings");
        foreach (var s in unique.Take(30))
            Console.WriteLine($"  0x{s.InstructionVA:X8}  \"{s.Value}\"");
        if (unique.Count > 30)
            Console.WriteLine($"  ... and {unique.Count - 30} more");

        Console.WriteLine();
        Console.WriteLine($"  -> {outPath}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"  ERROR: {ex.Message}");
    }
}

if (cmd == "--findstr" && argsList.Count > 1)
{
    var searchStr = argsList[1];
    Console.WriteLine($"Finding cross-references to string '{searchStr}'...");
    var exe = File.ReadAllBytes(exePath);
    var xrefs = StringExtractor.FindStringXrefs(exe, searchStr);

    Console.WriteLine($"Found {xrefs.Count} xrefs:");
    foreach (var x in xrefs)
    {
        var funcStart = StructAnalyzer.FindFuncStart(exe, x.InstructionVA);
        var funcInfo = funcStart != 0 ? $" (in func 0x{funcStart:X8})" : "";
        Console.WriteLine($"  0x{x.InstructionVA:X8}{funcInfo}  \"{x.Value}\"");
    }
}

Console.WriteLine();
Console.WriteLine("Analysis complete.");

static void PrintUsage()
{
    Console.WriteLine("Usage:");
    Console.WriteLine("  --rtti                Dump full RTTI database (4358 classes)");
    Console.WriteLine("  --imports             Dump import table");
    Console.WriteLine("  --vtable <class>      Dump vtable for a specific class");
    Console.WriteLine("  --vtfuncs <class>     Analyze vtable functions (size, params, stubs)");
    Console.WriteLine("  --analyze <class>     Full struct analysis (ctor fields + sub-objects)");
    Console.WriteLine("  --hierarchy <class>   Show inheritance hierarchy (bases + derived)");
    Console.WriteLine("  --search <pattern>    Search classes by name pattern");
    Console.WriteLine("  --strings <class>     Extract string references from class functions");
    Console.WriteLine("  --findstr <string>    Find all xrefs to a string literal");
    Console.WriteLine("  --all                 Run all dumps (rtti + imports)");
    Console.WriteLine();
    Console.WriteLine("Options:");
    Console.WriteLine("  --exe <path>          Override path to ffxivgame.exe");
    Console.WriteLine();
    Console.WriteLine($"Default target: {DefaultExePath}");
}
