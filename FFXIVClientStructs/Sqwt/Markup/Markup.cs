using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Markup;

// ============================================================================
// Sqwt::Markup — XAML parsing, control factories, and markup objects
//
// ConfigurationFactor is the base for all XAML element factories.
// ControlCreateBase extends it for control instantiation.
// MarkupObject is the runtime representation of a parsed XAML node.
// XamlReader / XamlReaderAsync handle XAML document parsing.
// ============================================================================

// ======================== Factory Base Types ========================

[Rtti(".?AVConfigurationFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ConfigurationFactor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA26B4 (8 vfuncs)
}

[Rtti(".?AVControlCreateBase@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ControlCreateBase
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA27E0 (9 vfuncs)
}

[Rtti(".?AVWindowCreateFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WindowCreateFactor
{
    // Inherits: ControlCreateBase → ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083BA4 (9 vfuncs)
}

[Rtti(".?AVDesktopWindowCreateFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DesktopWindowCreateFactor
{
    // Inherits: ControlCreateBase → ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083BCC (9 vfuncs)
}

[Rtti(".?AVResourceDictionaryFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceDictionaryFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2BCC (9 vfuncs)
}

// ======================== Markup Objects ========================

[Rtti(".?AVInputBindingMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InputBindingMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2CCC (9 vfuncs)
}

[Rtti(".?AVInputBindingsMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InputBindingsMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2658 (9 vfuncs)
}

[Rtti(".?AVTriggerMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TriggerMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DA14 (9 vfuncs)
}

[Rtti(".?AVEventTriggerMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EventTriggerMarkupObject
{
    // Inherits: TriggerMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DA3C (9 vfuncs)
}

[Rtti(".?AVMultiTriggerMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MultiTriggerMarkupObject
{
    // Inherits: EventTriggerMarkupObject → TriggerMarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DA64 (9 vfuncs)
}

[Rtti(".?AVCommandTriggerMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandTriggerMarkupObject
{
    // Inherits: TriggerMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DAD4 (9 vfuncs)
}

[Rtti(".?AVTriggersMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TriggersMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D9F0 (8 vfuncs)
}

[Rtti(".?AVTriggerActionMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TriggerActionMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DB20 (8 vfuncs)
}

[Rtti(".?AVMultiTriggerConditionsMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MultiTriggerConditionsMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DA8C (8 vfuncs)
}

[Rtti(".?AVTimelineMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TimelineMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DB44 (8 vfuncs)
}

[Rtti(".?AVSetterMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetterMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DB68 (8 vfuncs)
}

[Rtti(".?AVSetterValueMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetterValueMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DB98 (8 vfuncs)
}

[Rtti(".?AVRoutedCommandMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RoutedCommandMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D87C (8 vfuncs)
}

[Rtti(".?AVTemplateMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TemplateMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D858 (8 vfuncs)
}

[Rtti(".?AVRenderTransformMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RenderTransformMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DBCC (8 vfuncs)
}

[Rtti(".?AVTransformMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TransformMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DBF0 (8 vfuncs)
}

[Rtti(".?AVBeginStoryboardMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BeginStoryboardMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DAFC (8 vfuncs)
}

[Rtti(".?AVStoryboardMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StoryboardMarkupObject
{
    // Inherits: TimelineMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DC38 (8 vfuncs)
}

[Rtti(".?AVDoubleAnimationMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DoubleAnimationMarkupObject
{
    // Inherits: TimelineMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DC5C (8 vfuncs)
}

[Rtti(".?AVPropertyAnimationUsingKeyFramesMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PropertyAnimationUsingKeyFramesMarkupObject
{
    // Inherits: TimelineMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DC80 (8 vfuncs)
}

[Rtti(".?AVDiscreteValueKeyFrameMarkupObject@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DiscreteValueKeyFrameMarkupObject
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DCA4 (8 vfuncs)
}

// ======================== XAML Data Objects ========================

[Rtti(".?AVXamlStaticResource@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlStaticResource
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x00F9D2B4 (8 vfuncs)
}

[Rtti(".?AVXamlResourceDictionary@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlResourceDictionary
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA2680 (9 vfuncs)
}

[Rtti(".?AVXamlSqwtXmlDataMaker@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlSqwtXmlDataMaker
{
    // Inherits: XamlResourceDictionary → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D9A4 (9 vfuncs)
}

[Rtti(".?AVXamlDataBinding@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlDataBinding
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DD1C (8 vfuncs)
}

[Rtti(".?AVXamlFrameworkTemplate@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlFrameworkTemplate
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D9CC (8 vfuncs)
}

[Rtti(".?AVXamlResources@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlResources
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D980 (8 vfuncs)
}

[Rtti(".?AVXamlTemplate@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlTemplate
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D95C (8 vfuncs)
}

[Rtti(".?AVXamlGrid@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlGrid
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D8A0 (8 vfuncs)
}

[Rtti(".?AVXamlGridColumnDefinitions@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlGridColumnDefinitions
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DCC8 (8 vfuncs)
}

[Rtti(".?AVXamlGridRowDefinitions@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlGridRowDefinitions
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DCEC (8 vfuncs)
}

[Rtti(".?AVXamlIconControl@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlIconControl
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D8CC (8 vfuncs)
}

[Rtti(".?AVXamlIconData@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlIconData
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D92C (8 vfuncs)
}

[Rtti(".?AVXamlIconDatas@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlIconDatas
{
    // Inherits: MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D8FC (8 vfuncs)
}

// ======================== XAML Input Bindings ========================

[Rtti(".?AVXamlKeyBinding@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlKeyBinding
{
    // Inherits: InputBindingMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DD40 (9 vfuncs)
}

[Rtti(".?AVXamlMouseBinding@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlMouseBinding
{
    // Inherits: InputBindingMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DD68 (9 vfuncs)
}

[Rtti(".?AVXamlPadBinding@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlPadBinding
{
    // Inherits: InputBindingMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DD90 (9 vfuncs)
}

[Rtti(".?AVXamlCharBinding@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XamlCharBinding
{
    // Inherits: InputBindingMarkupObject → MarkupObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106DDB8 (9 vfuncs)
}

// ======================== XAML Reader ========================

[Rtti(".?AVXamlReader@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct XamlReader
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01071324 (1 vfunc)
}

[Rtti(".?AVXamlReaderAsync@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct XamlReaderAsync
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010712F8 (1 vfunc)
}

[Rtti(".?AVXamlControlContainer@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct XamlControlContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010724D4 (1 vfunc)
}

// ======================== Configuration Factors ========================

[Rtti(".?AVBindingFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BindingFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010834A0 (8 vfuncs)
}

[Rtti(".?AVSetterFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetterFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010834C4 (8 vfuncs)
}

[Rtti(".?AVCommonTemplateFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommonTemplateFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x0108350C (8 vfuncs)
}

[Rtti(".?AVTriggersFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TriggersFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083338 (8 vfuncs)
}

[Rtti(".?AVTriggerFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TriggerFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083554 (8 vfuncs)
}

[Rtti(".?AVEventTriggerFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EventTriggerFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083530 (8 vfuncs)
}

[Rtti(".?AVMultiTriggerFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MultiTriggerFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x0108359C (8 vfuncs)
}

[Rtti(".?AVCommandTriggerFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandTriggerFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083578 (8 vfuncs)
}

[Rtti(".?AVConditionFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ConditionFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010835E4 (8 vfuncs)
}

[Rtti(".?AVStoryboardFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StoryboardFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083708 (8 vfuncs)
}

[Rtti(".?AVDoubleAnimationFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DoubleAnimationFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x0108372C (8 vfuncs)
}

[Rtti(".?AVBeginStoryboardFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BeginStoryboardFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083630 (8 vfuncs)
}

[Rtti(".?AVPauseStoryboardFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PauseStoryboardFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083678 (8 vfuncs)
}

[Rtti(".?AVResumeStoryboardFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResumeStoryboardFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x0108369C (8 vfuncs)
}

[Rtti(".?AVStopStoryboardFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StopStoryboardFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083654 (8 vfuncs)
}

[Rtti(".?AVResourceFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010832F0 (8 vfuncs)
}

[Rtti(".?AVStaticResourceFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StaticResourceFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083434 (8 vfuncs)
}

[Rtti(".?AVRenderTransformFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RenderTransformFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083314 (8 vfuncs)
}

[Rtti(".?AVRotateTransformFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RotateTransformFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083458 (8 vfuncs)
}

[Rtti(".?AVScaleTransformFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScaleTransformFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x0108347C (8 vfuncs)
}

[Rtti(".?AVColumnDefinitionFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ColumnDefinitionFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010833C8 (8 vfuncs)
}

[Rtti(".?AVRowDefinitionFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RowDefinitionFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083410 (8 vfuncs)
}

[Rtti(".?AVInputBindingsFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InputBindingsFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010832CC (8 vfuncs)
}

[Rtti(".?AVIconControlIconDatasFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IconControlIconDatasFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x0108335C (8 vfuncs)
}

[Rtti(".?AVIconDataFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IconDataFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083380 (8 vfuncs)
}

[Rtti(".?AVMergedDictionariesFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MergedDictionariesFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010834E8 (8 vfuncs)
}

[Rtti(".?AVSoundPlayActionFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SoundPlayActionFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010836C0 (8 vfuncs)
}

[Rtti(".?AVExecuteCommandActionFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExecuteCommandActionFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010836E4 (8 vfuncs)
}

[Rtti(".?AVSetterActionFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetterActionFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010857C4 (8 vfuncs)
}

[Rtti(".?AVMultiTriggerConditionsFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MultiTriggerConditionsFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010835C0 (8 vfuncs)
}

[Rtti(".?AVGridColumnDefinitionsFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct GridColumnDefinitionsFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010833A4 (8 vfuncs)
}

[Rtti(".?AVGridRowDefinitionsFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct GridRowDefinitionsFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x010833EC (8 vfuncs)
}

[Rtti(".?AVPropertyAnimationUsingKeyFramesFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PropertyAnimationUsingKeyFramesFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083750 (8 vfuncs)
}

[Rtti(".?AVDiscreteValueKeyFrameFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DiscreteValueKeyFrameFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083774 (8 vfuncs)
}

[Rtti(".?AVTemplateFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TemplateFactor
{
    // Inherits: ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01084FD0 (8 vfuncs)
}

// ======================== Binding Factors ========================

[Rtti(".?AVKeyBindingFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct KeyBindingFactor
{
    // Inherits: BindingFactorBase → ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083C44 (9 vfuncs)
}

[Rtti(".?AVMouseBindingFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MouseBindingFactor
{
    // Inherits: BindingFactorBase → ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083C6C (9 vfuncs)
}

[Rtti(".?AVPadBindingFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PadBindingFactor
{
    // Inherits: BindingFactorBase → ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083C94 (9 vfuncs)
}

[Rtti(".?AVXmlDataMakerFactor@Markup@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XmlDataMakerFactor
{
    // Inherits: ResourceDictionaryFactor → ConfigurationFactor
    [FieldOffset(0x0000)] public nint VTable; // 0x01083608 (9 vfuncs)
}
