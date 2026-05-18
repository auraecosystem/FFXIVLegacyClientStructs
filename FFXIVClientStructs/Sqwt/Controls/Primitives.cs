using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Controls.Primitives;

// ============================================================================
// Sqwt::Controls::Primitives — Low-level building blocks for complex controls
//
// ButtonBase, ToggleButton, RangeBase, ScrollBar, TextBoxBase, Thumb, etc.
// These are typically not used directly in XAML but composed inside templates.
// ============================================================================

[Rtti(".?AVToggleButton@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct ToggleButton
{
    // Inherits: ButtonBase → ICommandSource<ContentControl> → ContentControl → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x0106F2B4 (76 vfuncs)
}

[Rtti(".?AVRepeatButton@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct RepeatButton
{
    // Inherits: ButtonBase → ICommandSource<ContentControl> → ContentControl → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x01079924 (73 vfuncs)
}

[Rtti(".?AVSelector@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0xA0)]
public unsafe struct Selector
{
    // Inherits: ItemsControl → Control → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x01072874 (72 vfuncs)
}

[Rtti(".?AVScrollBar@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct ScrollBar
{
    // Inherits: RangeBase → RangeBaseData → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x0107798C (73 vfuncs)
}

[Rtti(".?AVTextBoxBase@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0xC0)]
public unsafe struct TextBoxBase
{
    // Inherits: Control → FrameworkElement → UIElement
    // Largest primitive by vfunc count (94) — handles text editing, selection,
    // caret, IME/composition, scrolling, undo/redo
    [FieldOffset(0x0000)] public nint VTable; // 0x0107573C (94 vfuncs)
}

[Rtti(".?AVThumb@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x90)]
public unsafe struct Thumb
{
    // Inherits: Control → FrameworkElement
    // Draggable handle used in scrollbars and sliders
    [FieldOffset(0x0000)] public nint VTable; // 0x0108488C (71 vfuncs)
}

[Rtti(".?AVTrack@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct Track
{
    // Inherits: FrameworkElement → UIElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107A54C (67 vfuncs)
}

[Rtti(".?AVPopup@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct Popup
{
    // Inherits: FrameworkElement → UIElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107BE8C (65 vfuncs)
}

[Rtti(".?AVBulletDecorator@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct BulletDecorator
{
    // Inherits: Decorator → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x01084424 (65 vfuncs)
}

[Rtti(".?AVIScrollInfo@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IScrollInfo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01073164 (31 vfuncs)
}

[Rtti(".?AVScrollEventArgs@Primitives@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScrollEventArgs
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01077840 (2 vfuncs)
}
