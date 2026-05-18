using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.DocumentModel;

// ============================================================================
// Sqwt::DocumentModel — Text document model for TextBox/LogControl
//
// TextDocument is the base for all document types. Element represents a
// segment of text content. LineTextDocument/WrapTextDocument provide
// different line-breaking strategies. Used by TextBoxBase and the game's
// chat log (LogControl).
// ============================================================================

[Rtti(".?AVTextDocument@DocumentModel@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct TextDocument
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA91BC (23 vfuncs)
}

[Rtti(".?AVElement@DocumentModel@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Element
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA90B4 (5 vfuncs)
}

[Rtti(".?AVLineTextDocument@DocumentModel@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe struct LineTextDocument
{
    // Inherits: TextDocument
    [FieldOffset(0x0000)] public nint VTable; // 0x01077C0C (23 vfuncs)
}

[Rtti(".?AVWrapTextDocument@DocumentModel@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe struct WrapTextDocument
{
    // Inherits: TextDocument
    [FieldOffset(0x0000)] public nint VTable; // 0x01077C6C (23 vfuncs)
}

[Rtti(".?AVLineTextElement@DocumentModel@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct LineTextElement
{
    // Inherits: Element
    [FieldOffset(0x0000)] public nint VTable; // 0x01077B94 (5 vfuncs)
}

[Rtti(".?AVWrapTextElement@DocumentModel@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct WrapTextElement
{
    // Inherits: Element
    [FieldOffset(0x0000)] public nint VTable; // 0x01077BAC (5 vfuncs)
}

[Rtti(".?AVLineTextElementContainerBase@DocumentModel@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LineTextElementContainerBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01077B5C (13 vfuncs)
}

[Rtti(".?AVLineTextElementContainer@DocumentModel@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct LineTextElementContainer
{
    // Inherits: LineTextElementContainerBase
    [FieldOffset(0x0000)] public nint VTable; // 0x01077BD4 (13 vfuncs)
}
