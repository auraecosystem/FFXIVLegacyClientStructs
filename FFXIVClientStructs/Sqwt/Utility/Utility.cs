using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Utility;

// ============================================================================
// Sqwt::Utility — Editor and widget helper types
//
// EditorControler manages text editing state. File handles resource loading.
// WidgetParts provides partial rendering for complex controls.
// ============================================================================

[Rtti(".?AVEditorControler@Utility@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct EditorControler
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01068194 (1 vfunc)
}

[Rtti(".?AVFile@Utility@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct File
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010681BC (1 vfunc)
}

[Rtti(".?AVWidgetParts@Utility@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WidgetParts
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0107B318 (4 vfuncs)
}

[Rtti(".?AVWidgetPartsActual@Utility@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WidgetPartsActual
{
    // Inherits: WidgetParts
    [FieldOffset(0x0000)] public nint VTable; // 0x0107B340 (4 vfuncs)
}

[Rtti(".?AVWidgetPartsRefference@Utility@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WidgetPartsRefference
{
    // Inherits: WidgetParts
    [FieldOffset(0x0000)] public nint VTable; // 0x0107B32C (4 vfuncs)
}
