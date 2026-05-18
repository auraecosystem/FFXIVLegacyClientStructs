using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Input;

// ============================================================================
// Sqwt::Input — Input devices, gestures, commands, and bindings
//
// WPF-style input system. InputDevice → {Keyboard, Mouse, Pad}Device.
// InputGesture → {Key, Mouse, Pad, Char}Gesture for input recognition.
// ICommand/RoutedCommand for command routing. InputBinding links gestures to
// commands. Cursor/Anchor/MouseElement are visual overlays for input feedback.
// ============================================================================

// ======================== Input Devices ========================

[Rtti(".?AVInputDevice@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct InputDevice
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2600 (1 vfunc)
}

[Rtti(".?AVKeyboardDevice@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct KeyboardDevice
{
    // Inherits: InputDevice
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2608 (7 vfuncs)
}

[Rtti(".?AVNullKeyboardDevice@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NullKeyboardDevice
{
    // Inherits: KeyboardDevice → InputDevice
    [FieldOffset(0x0000)] public nint VTable; // 0x010771D4 (7 vfuncs)
}

[Rtti(".?AVKeyboard@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct Keyboard
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01069664 (1 vfunc)
}

[Rtti(".?AVMouse@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct Mouse
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01067F44 (1 vfunc)
}

// ======================== Input Gestures ========================

[Rtti(".?AVInputGesture@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InputGesture
{
    // Inherits: SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2E9C (11 vfuncs)
}

[Rtti(".?AVKeyGesture@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct KeyGesture
{
    // Inherits: InputGesture → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x00FC5AA4 (11 vfuncs)
}

[Rtti(".?AVMouseGesture@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct MouseGesture
{
    // Inherits: InputGesture → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D7F0 (11 vfuncs)
}

[Rtti(".?AVPadGesture@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct PadGesture
{
    // Inherits: InputGesture → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x00FC5AD4 (11 vfuncs)
}

[Rtti(".?AVCharGesture@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct CharGesture
{
    // Inherits: InputGesture → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D820 (11 vfuncs)
}

[Rtti(".?AVInputGestureCollection@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct InputGestureCollection
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0106A768 (1 vfunc)
}

// ======================== Commands ========================

[Rtti(".?AVICommand@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICommand
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0106A728 (4 vfuncs)
}

[Rtti(".?AVNullCommand@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct NullCommand
{
    // Inherits: RoutedCommand → ICommand → SharedItem
    [FieldOffset(0x0000)] public nint VTable; // 0x0106A6C4 (4 vfuncs)
}

[Rtti(".?AVCommandBinding@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandBinding
{
    // Inherits: SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA67DC (2 vfuncs)
}

[Rtti(".?AVCommandBindingCollection@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct CommandBindingCollection
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01069B90 (1 vfunc)
}

[Rtti(".?AVCommandBindingEventHandlerCollection@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandBindingEventHandlerCollection
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA67B4 (5 vfuncs)
}

[Rtti(".?AVExecuteCommandAction@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct ExecuteCommandAction
{
    // Inherits: ICommandSource<TriggerAction> → TriggerAction → SharedItem
    [FieldOffset(0x0000)] public nint VTable; // 0x0107D7F4 (6 vfuncs)
}

// ======================== Input Bindings ========================

[Rtti(".?AVKeyBinding@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct KeyBinding
{
    // Inherits: InputBinding → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x00FC49BC (3 vfuncs)
}

[Rtti(".?AVMouseBinding@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct MouseBinding
{
    // Inherits: InputBinding → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D658 (3 vfuncs)
}

[Rtti(".?AVPadBinding@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct PadBinding
{
    // Inherits: InputBinding → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x00FC49CC (3 vfuncs)
}

[Rtti(".?AVInputBindingCollection@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct InputBindingCollection
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2ECC (1 vfunc)
}

// ======================== Visual Elements ========================

[Rtti(".?AVCursor@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct Cursor
{
    // Inherits: FrameworkElement → UIElement → Visual
    [FieldOffset(0x0000)] public nint VTable; // 0x01067CB4 (65 vfuncs)
}

[Rtti(".?AVCursors@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct Cursors
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0107B6A0 (1 vfunc)
}

[Rtti(".?AVAnchor@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct Anchor
{
    // Inherits: FrameworkElement → UIElement → Visual
    [FieldOffset(0x0000)] public nint VTable; // 0x01084CA4 (65 vfuncs)
}

[Rtti(".?AVAnchorElement@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct AnchorElement
{
    // Inherits: FrameworkElement → UIElement → Visual
    [FieldOffset(0x0000)] public nint VTable; // 0x010697C4 (65 vfuncs)
}

[Rtti(".?AVAnchors@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct Anchors
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0107AC70 (1 vfunc)
}

[Rtti(".?AVMouseElement@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct MouseElement
{
    // Inherits: FrameworkElement → UIElement → Visual
    [FieldOffset(0x0000)] public nint VTable; // 0x0106808C (65 vfuncs)
}

// ======================== Event Args ========================

[Rtti(".?AVMouseEventArgs@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MouseEventArgs
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2640 (2 vfuncs)
}

[Rtti(".?AVTextCompositionEventArgs@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TextCompositionEventArgs
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA264C (2 vfuncs)
}

[Rtti(".?AVCandidateEventArgs@Input@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CandidateEventArgs
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA27B8 (2 vfuncs)
}
