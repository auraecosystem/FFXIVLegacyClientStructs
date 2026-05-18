using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Controls;

// ============================================================================
// Sqwt::Controls — UI control library
//
// WPF-style control hierarchy. All controls derive from FrameworkElement.
// Control adds template-based rendering (ControlTemplate).
// ContentControl adds a single content child.
// ItemsControl adds a collection of items + item containers.
// Panel provides layout for child elements (Canvas, StackPanel, Grid, etc.)
// ============================================================================

// ======================== Base Controls ========================

[Rtti(".?AVControl@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x90)]
public unsafe struct Control
{
    // Inherits: FrameworkElement → UIElement → Visual → DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106BB54 (70 vfuncs)
}

[Rtti(".?AVContentControl@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct ContentControl
{
    // Inherits: Control → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0106B634 (71 vfuncs)
}

[Rtti(".?AVHeaderedContentControl@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct HeaderedContentControl
{
    // Inherits: ContentControl → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x01071654 (72 vfuncs)
}

[Rtti(".?AVItemsControl@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct ItemsControl
{
    // Inherits: Control → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0106FADC (71 vfuncs)
}

[Rtti(".?AVContentPresenter@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct ContentPresenter
{
    // Inherits: FrameworkElement → UIElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107A9B4 (66 vfuncs)
}

// ======================== Buttons ========================

[Rtti(".?AVButton@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct Button
{
    // Inherits: ButtonBase → ICommandSource<ContentControl> → ContentControl
    [FieldOffset(0x0000)] public nint VTable; // 0x01073CAC (73 vfuncs)
}

[Rtti(".?AVCheckBox@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct CheckBox
{
    // Inherits: ToggleButton → ButtonBase → ContentControl
    [FieldOffset(0x0000)] public nint VTable; // 0x0107EE5C (76 vfuncs)
}

[Rtti(".?AVRadioButton@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct RadioButton
{
    // Inherits: ToggleButton → ButtonBase → ContentControl
    [FieldOffset(0x0000)] public nint VTable; // 0x0107411C (76 vfuncs)
}

// ======================== Selection ========================

[Rtti(".?AVComboBox@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0xA0)]
public unsafe struct ComboBox
{
    // Inherits: Selector → ItemsControl → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x01070BAC (72 vfuncs)
}

[Rtti(".?AVComboBoxItem@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct ComboBoxItem
{
    // Inherits: ListBoxItem → ContentControl → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x010807FC (71 vfuncs)
}

[Rtti(".?AVListBoxItem@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct ListBoxItem
{
    // Inherits: ContentControl → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x0107AFB4 (71 vfuncs)
}

[Rtti(".?AVTabControl@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0xA0)]
public unsafe struct TabControl
{
    // Inherits: Selector → ItemsControl → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x01081654 (72 vfuncs)
}

[Rtti(".?AVTabItem@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct TabItem
{
    // Inherits: HeaderedContentControl → ContentControl → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x01080E6C (74 vfuncs)
}

[Rtti(".?AVTabItemBorder@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct TabItemBorder
{
    // Inherits: ContentPresenter → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x01080C24 (66 vfuncs)
}

// ======================== Layout Panels ========================

[Rtti(".?AVPanel@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct Panel
{
    // Inherits: FrameworkElement → UIElement → Visual
    [FieldOffset(0x0000)] public nint VTable; // 0x01078B74 (68 vfuncs)
}

[Rtti(".?AVCanvas@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct Canvas
{
    // Inherits: Panel → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107FFCC (68 vfuncs)
}

[Rtti(".?AVStackPanel@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct StackPanel
{
    // Inherits: Panel → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107F304 (68 vfuncs)
}

[Rtti(".?AVDockPanel@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct DockPanel
{
    // Inherits: Panel → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x01075D44 (68 vfuncs)
}

[Rtti(".?AVWrapPanel@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct WrapPanel
{
    // Inherits: Panel → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107FBD4 (68 vfuncs)
}

[Rtti(".?AVVirtualizingStackPanel@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x90)]
public unsafe struct VirtualizingStackPanel
{
    // Inherits: VirtualizingPanel → Panel → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107F7B4 (68 vfuncs)
}

// ======================== Visual Elements ========================

[Rtti(".?AVBorder@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct Border
{
    // Inherits: Decorator → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107E01C (65 vfuncs)
}

[Rtti(".?AVImage@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct Image
{
    // Inherits: FrameworkElement → UIElement → Visual
    [FieldOffset(0x0000)] public nint VTable; // 0x0108040C (65 vfuncs)
}

[Rtti(".?AVProgressBar@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct ProgressBar
{
    // Inherits: RangeBase → RangeBaseData → Control
    [FieldOffset(0x0000)] public nint VTable; // 0x0107E9D4 (73 vfuncs)
}

// ======================== Game-Specific Icons ========================

[Rtti(".?AVHateIcon@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct HateIcon
{
    // Inherits: IconControl → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x01081F74 (66 vfuncs)
}

[Rtti(".?AVTimerIcon@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct TimerIcon
{
    // Inherits: IconControl → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x010824B4 (66 vfuncs)
}

// ======================== Text ========================

[Rtti(".?AVTextChangedEventArgs@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TextChangedEventArgs
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA90FC (2 vfuncs)
}

// ======================== Grid Definitions ========================

[Rtti(".?AVColumnDefinition@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct ColumnDefinition
{
    // Inherits: DefinitionBase → FrameworkContentElement
    [FieldOffset(0x0000)] public nint VTable; // 0x01078878 (2 vfuncs)
}

[Rtti(".?AVRowDefinition@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct RowDefinition
{
    // Inherits: DefinitionBase → FrameworkContentElement
    [FieldOffset(0x0000)] public nint VTable; // 0x0107A21C (2 vfuncs)
}

// ======================== Scroll ========================

[Rtti(".?AVScrollContentPresenter@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x88)]
public unsafe struct ScrollContentPresenter
{
    // Inherits: ContentPresenter → FrameworkElement
    [FieldOffset(0x0000)] public nint VTable; // 0x010829A4 (66 vfuncs)
}

// ======================== Sound ========================

[Rtti(".?AVSoundPlayerAction@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct SoundPlayerAction
{
    // Inherits: TriggerAction → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0107D8D0 (6 vfuncs)
}

// ======================== Item Container Generator ========================

[Rtti(".?AVIItemContainerGenerator@Controls@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IItemContainerGenerator
{
    // Inherits: Object → AllocatorBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0108306C (11 vfuncs)
}
