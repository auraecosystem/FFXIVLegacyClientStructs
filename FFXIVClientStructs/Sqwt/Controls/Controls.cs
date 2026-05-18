using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Controls;

// Sqwt — Square Enix Widget Toolkit
// Full WPF-inspired UI framework with XAML-like markup, bindings, templates, commands
// Used for ALL of FFXIV 1.0's UI (character creation, HUD, menus, chat, etc.)

[Rtti(".?AVControl@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct Control
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVButton@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct Button
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVCheckBox@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct CheckBox
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVComboBox@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct ComboBox
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVContentControl@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct ContentControl
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVCanvas@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe struct Canvas
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVBorder@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe struct Border
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVContentPresenter@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe struct ContentPresenter
{
    [FieldOffset(0x00)] public nint VTable;
}
