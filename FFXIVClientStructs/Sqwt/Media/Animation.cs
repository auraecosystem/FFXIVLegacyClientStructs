using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Media.Animation;

// ============================================================================
// Sqwt::Media::Animation — Timeline-based animation system
//
// WPF-style animations. Timeline → TimelineGroup/AnimationTimeline.
// Storyboard orchestrates multiple timelines. DoubleAnimation for numeric
// interpolation. BeginStoryboard/PauseStoryboard/etc. are trigger actions
// that control storyboard playback from XAML triggers.
// ============================================================================

// ======================== Base Types ========================

[Rtti(".?AVAnimatable@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct Animatable
{
    // Inherits: DependencyObject → DependencyObjectBase → Object
    [FieldOffset(0x0000)] public nint VTable; // 0x0107C9C4 (14 vfuncs)
}

// ======================== Timelines ========================

[Rtti(".?AVTimelineGroup@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x28)]
public unsafe struct TimelineGroup
{
    // Inherits: Timeline → Animatable → DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0107C24C (24 vfuncs)
}

[Rtti(".?AVParallelTimeline@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x28)]
public unsafe struct ParallelTimeline
{
    // Inherits: TimelineGroup → Timeline → Animatable
    [FieldOffset(0x0000)] public nint VTable; // 0x0107C2BC (24 vfuncs)
}

[Rtti(".?AVStoryboard@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct Storyboard
{
    // Inherits: ParallelTimeline → TimelineGroup → Timeline
    [FieldOffset(0x0000)] public nint VTable; // 0x0107C32C (24 vfuncs)
}

[Rtti(".?AVAnimationTimeline@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x28)]
public unsafe struct AnimationTimeline
{
    // Inherits: Timeline → Animatable → DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D5F4 (24 vfuncs)
}

[Rtti(".?AVDoubleAnimation@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct DoubleAnimation
{
    // Inherits: DoubleAnimationBase → AnimationTimeline → Timeline
    [FieldOffset(0x0000)] public nint VTable; // 0x0107DCD4 (24 vfuncs)
}

[Rtti(".?AVPropertyAnimationUsingKeyFrames@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct PropertyAnimationUsingKeyFrames
{
    // Inherits: AnimationTimeline → Timeline → Animatable
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D734 (24 vfuncs)
}

[Rtti(".?AVTimelineCollection@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TimelineCollection
{
    // Inherits: SharedItemContainer<Timeline> → SharedItemContainerBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D70C (5 vfuncs)
}

[Rtti(".?AVStringKeyFrame@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct StringKeyFrame
{
    // Inherits: DependencyObject → DependencyObjectBase → Object
    [FieldOffset(0x0000)] public nint VTable; // 0x01084DEC (14 vfuncs)
}

// ======================== Storyboard Actions ========================

[Rtti(".?AVBeginStoryboard@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct BeginStoryboard
{
    // Inherits: TriggerAction → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0106D7D4 (6 vfuncs)
}

[Rtti(".?AVPauseStoryboard@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct PauseStoryboard
{
    // Inherits: TriggerAction → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0107DA14 (6 vfuncs)
}

[Rtti(".?AVResumeStoryboard@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct ResumeStoryboard
{
    // Inherits: TriggerAction → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0107D974 (6 vfuncs)
}

[Rtti(".?AVStopStoryboard@Animation@Media@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct StopStoryboard
{
    // Inherits: TriggerAction → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x0107DAB4 (6 vfuncs)
}
