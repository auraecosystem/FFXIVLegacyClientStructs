using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt;

// ============================================================================
// Sqwt — Square Enix Widget Toolkit
// Full WPF-inspired UI framework: XAML markup, data binding, templates,
// routed events, dependency properties, visual tree, input system, animations.
//
// 685 RTTI classes total. Hierarchy mirrors WPF:
//   Object → DependencyObject → Visual → UIElement → FrameworkElement → Control → ...
//
// Used for ALL of FFXIV 1.0's UI: character creation, HUD, menus, chat, config,
// map screen, nameplate overlays, login screens, etc.
// ============================================================================

// Object — Root of all Sqwt types (no vtable in RTTI, base allocator)
// RTTI present but no vtable entry

[Rtti(".?AVAllocatorBase@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct AllocatorBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01068D6C (1 vfunc)
}

[Rtti(".?AVDependencyObject@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct DependencyObject
{
    // Inherits: DependencyObjectBase → Object → AllocatorBase
    [FieldOffset(0x0000)] public nint VTable; // 0x010684B8 (14 vfuncs)
}

[Rtti(".?AVDependencyPropertyInfoBase@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct DependencyPropertyInfoBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA912C (6 vfuncs)
}

[Rtti(".?AVDependencyPropertyObject@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DependencyPropertyObject
{
    // Inherits: Object → AllocatorBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0107D08C (3 vfuncs)
}

[Rtti(".?AVSharedItemBase@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SharedItemBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F9D26C (3 vfuncs)
}

[Rtti(".?AVSharedItemContainerBase@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SharedItemContainerBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA25E8 (2 vfuncs)
}

[Rtti(".?AVEventArgs@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EventArgs
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0106848C (1 vfunc)
}

[Rtti(".?AVDelegate@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Delegate
{
    // Inherits: DelegateBase<Object, RoutedEventArgs> → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA0E14 (3 vfuncs)
}

[Rtti(".?AVCondition@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct Condition
{
    // Inherits: SharedItem → SharedItemBase, DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0107CEDC (2 vfuncs)
}

[Rtti(".?AVContentObject@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct ContentObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FCB0B0 (1 vfunc)
}

[Rtti(".?AVKeyListObject@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct KeyListObject
{
    // Inherits: Object → AllocatorBase
    [FieldOffset(0x0000)] public nint VTable; // 0x01068DC0 (3 vfuncs)
}

[Rtti(".?AVSqwtInterface@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct SqwtInterface
{
    [FieldOffset(0x0000)] public nint VTable;
}

[Rtti(".?AVFontInterface@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct FontInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA26D8 (9 vfuncs)
}

[Rtti(".?AVCandidateListInterface@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct CandidateListInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA27C4 (6 vfuncs)
}

[Rtti(".?AVInputBindingCollectionInterface@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct InputBindingCollectionInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F90F00 (2 vfuncs)
}

// ============================================================================
// Templates & Styling
// ============================================================================

[Rtti(".?AVControlTemplate@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ControlTemplate
{
    // Inherits: FrameworkTemplate → DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x00FCB0BC (16 vfuncs)
}

[Rtti(".?AVDataTemplate@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct DataTemplate
{
    // Inherits: FrameworkTemplate → DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106B224 (16 vfuncs)
}

[Rtti(".?AVStyle@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct Style
{
    // Inherits: FrameworkTemplate → DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0107BFFC (16 vfuncs)
}

// ============================================================================
// Triggers & Actions
// ============================================================================

[Rtti(".?AVTriggerBase@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct TriggerBase
{
    // Inherits: SharedItem → SharedItemBase, DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x01082650 (4 vfuncs)
}

[Rtti(".?AVTriggerAction@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct TriggerAction
{
    // Inherits: SharedItem → SharedItemBase, DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D6F0 (6 vfuncs)
}

[Rtti(".?AVTrigger@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct Trigger
{
    // Inherits: EventTrigger → TriggerBase → SharedItem
    [FieldOffset(0x0000)] public nint VTable; // 0x0107D0D8 (4 vfuncs)
}

[Rtti(".?AVMultiTrigger@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct MultiTrigger
{
    // Inherits: EventTrigger → TriggerBase → SharedItem
    [FieldOffset(0x0000)] public nint VTable; // 0x0107CE8C (4 vfuncs)
}

[Rtti(".?AVCommandTrigger@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct CommandTrigger
{
    // Inherits: ICommandSource<EventTrigger> → EventTrigger → TriggerBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0107D2D4 (4 vfuncs)
}

[Rtti(".?AVSetter@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct Setter
{
    // Inherits: TriggerAction → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0107D5F0 (6 vfuncs)
}
