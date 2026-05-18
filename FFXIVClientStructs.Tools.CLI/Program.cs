using FFXIVClientStructs.Tools;

const string ExePath = @"E:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV\ffxivgame.exe";
var outputDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!;

Console.WriteLine("=== FFXIV 1.0 (1.23b) Client Analysis Tool ===");
Console.WriteLine();

if (args.Length == 0)
{
    Console.WriteLine("Usage:");
    Console.WriteLine("  --rtti              Dump full RTTI database (4358 classes)");
    Console.WriteLine("  --imports           Dump import table");
    Console.WriteLine("  --vtable <class>    Dump vtable for a specific class");
    Console.WriteLine("  --analyze <class>   Full struct analysis (ctor fields + sub-objects)");
    Console.WriteLine("  --all               Run all dumps");
    Console.WriteLine();
    Console.WriteLine($"Target: {ExePath}");
    return;
}

var cmd = args[0].ToLower();

if (cmd == "--rtti" || cmd == "--all")
{
    Console.Write("Extracting RTTI database...");
    var rttiOut = Path.Combine(outputDir, "ffxiv_1.0_rtti.txt");
    RttiDumper.DumpToFile(ExePath, rttiOut);
    var entries = RttiDumper.ExtractAll(ExePath);
    var withVt = entries.Count(e => e.VTableVA.HasValue);
    Console.WriteLine($" done! {entries.Count} classes ({withVt} with vtables)");
    Console.WriteLine($"  -> {rttiOut}");
}

if (cmd == "--imports" || cmd == "--all")
{
    Console.Write("Extracting import table...");
    var importOut = Path.Combine(outputDir, "ffxiv_1.0_imports.txt");
    ImportTableDumper.DumpToFile(ExePath, importOut);
    Console.WriteLine(" done!");
    Console.WriteLine($"  -> {importOut}");
}

if (cmd == "--vtable" && args.Length > 1)
{
    var className = args[1];
    Console.Write($"Extracting vtable for '{className}'...");
    var vtOut = Path.Combine(outputDir, $"vtable_{className.Replace("::", "_")}.txt");
    RttiDumper.DumpVtable(ExePath, className, vtOut);
    Console.WriteLine(" done!");
    Console.WriteLine($"  -> {vtOut}");
}

if (cmd == "--analyze" && args.Length > 1)
{
    var className = args[1];
    Console.WriteLine($"Analyzing struct '{className}'...");
    try
    {
        var exe = File.ReadAllBytes(ExePath);
        var layout = StructAnalyzer.Analyze(exe, className);

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

Console.WriteLine();
Console.WriteLine("Analysis complete.");
