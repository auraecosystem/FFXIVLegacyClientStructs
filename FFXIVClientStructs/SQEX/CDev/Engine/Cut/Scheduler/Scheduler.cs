using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Cut.Scheduler;

// SQEX::CDev::Engine::Cut::Scheduler
// Cutscene scheduling system — timeline management, actors, blocks, clips,
// resources, connections, conditions, and register-based logic clips.
// 58 RTTI types mapped from FFXIV binary.

// ================================
// Iterators
// ================================

[Rtti(".?AVListenerIterator@Scheduler@1Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ListenerIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01094268 (1 vfunc)
}

// ================================
// Interfaces
// ================================

[Rtti(".?AVIScheduleActor@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IScheduleActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097D5C (24 vfuncs)
}

[Rtti(".?AVIScheduleActorEventListener@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IScheduleActorEventListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01139BAC (2 vfuncs)
}

[Rtti(".?AVISchedulerListener@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ISchedulerListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7A84 (12 vfuncs)
}

[Rtti(".?AVISEVolume@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ISEVolume
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01134F58 (4 vfuncs)
}

[Rtti(".?AVIInquiryGameActor@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IInquiryGameActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBB260 (2 vfuncs)
}

// ================================
// Actor System
// ================================

[Rtti(".?AVActorBase@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ActorBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097DC4 (24 vfuncs)
}

[Rtti(".?AVActorContainer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ActorContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097F68 (1 vfunc)
}

[Rtti(".?AVActorContainerFactory@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ActorContainerFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010989A0 (1 vfunc)
}

[Rtti(".?AVActorFactory@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ActorFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097AF8 (1 vfunc)
}

[Rtti(".?AVActorIterator@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ActorIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097F60 (1 vfunc)
}

[Rtti(".?AVCommonActor@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommonActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010987C4 (24 vfuncs)
}

[Rtti(".?AVVirtualActor@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct VirtualActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098A2C (24 vfuncs)
}

// ================================
// Block System
// ================================

[Rtti(".?AVBlock@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Block
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098AC8 (8 vfuncs)
}

[Rtti(".?AVBlockContainer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BlockContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010985E4 (1 vfunc)
}

[Rtti(".?AVBlockFactory@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BlockFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098AC0 (1 vfunc)
}

[Rtti(".?AVBlockInstance@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BlockInstance
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098630 (1 vfunc)
}

[Rtti(".?AVBlockInstanceContainer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BlockInstanceContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098648 (1 vfunc)
}

// ================================
// Clip System
// ================================

[Rtti(".?AVClipContainer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097F58 (1 vfunc)
}

[Rtti(".?AVClipContainerFactory@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipContainerFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098650 (1 vfunc)
}

[Rtti(".?AVClipDataIterator@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipDataIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098A90 (1 vfunc)
}

[Rtti(".?AVClipIterator@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098748 (4 vfuncs)
}

[Rtti(".?AVClipIteratorContainsHierarchy@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipIteratorContainsHierarchy
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098734 (4 vfuncs)
}

[Rtti(".?AVClipListenerHolderContainer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipListenerHolderContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBEBAC (1 vfunc)
}

[Rtti(".?AVClipParameter@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipParameter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097B00 (1 vfunc)
}

// ================================
// Concrete Clips
// ================================

[Rtti(".?AVCalculateRegisterClip@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CalculateRegisterClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113A7DC (42 vfuncs)
}

[Rtti(".?AVGetNumberRegisterClip@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct GetNumberRegisterClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113A9DC (42 vfuncs)
}

[Rtti(".?AVGetStringRegisterClip@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct GetStringRegisterClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113AB4C (42 vfuncs)
}

[Rtti(".?AVIfClip@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IfClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010988EC (42 vfuncs)
}

[Rtti(".?AVNumberClip@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NumberClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113AF9C (42 vfuncs)
}

[Rtti(".?AVSetNumberRegisterClip@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetNumberRegisterClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113ACBC (42 vfuncs)
}

[Rtti(".?AVSetStringRegisterClip@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetStringRegisterClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113AE2C (42 vfuncs)
}

[Rtti(".?AVStringClip@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StringClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B10C (42 vfuncs)
}

[Rtti(".?AVLightBlock@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LightBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098AEC (8 vfuncs)
}

// ================================
// Resource System
// ================================

[Rtti(".?AVAccResourceNode@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AccResourceNode
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098194 (15 vfuncs)
}

[Rtti(".?AVCutSceneResourceData@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CutSceneResourceData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109800C (1 vfunc)
}

[Rtti(".?AVCutSceneResourceNode@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CutSceneResourceNode
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109839C (15 vfuncs)
}

[Rtti(".?AVCutSceneResourceNodeFactory@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CutSceneResourceNodeFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109D12C (7 vfuncs)
}

[Rtti(".?AVMccResourceNode@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MccResourceNode
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010980E4 (15 vfuncs)
}

[Rtti(".?AVLocalResourceContainer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LocalResourceContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097F70 (1 vfunc)
}

[Rtti(".?AVResourceReference@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceReference
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098604 (10 vfuncs)
}

// ================================
// Data / Iterator
// ================================

[Rtti(".?AVChunkIterator@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ChunkIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010985F4 (1 vfunc)
}

[Rtti(".?AVChunkIterator8@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ChunkIterator8
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010985FC (1 vfunc)
}

[Rtti(".?AVCondition@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Condition
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098AB0 (1 vfunc)
}

[Rtti(".?AVConditionDataIterator@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ConditionDataIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098AB8 (1 vfunc)
}

[Rtti(".?AVConnection@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Connection
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098640 (1 vfunc)
}

[Rtti(".?AVConnectionDataIterator@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ConnectionDataIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098638 (1 vfunc)
}

[Rtti(".?AVDataPack@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DataPack
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098A98 (1 vfunc)
}

[Rtti(".?AVDataPackContainer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DataPackContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098AA8 (1 vfunc)
}

[Rtti(".?AVDataPackIterator@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DataPackIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098AA0 (1 vfunc)
}

// ================================
// Schedule / Management
// ================================

[Rtti(".?AVCutLeaf@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CutLeaf
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097864 (9 vfuncs)
}

[Rtti(".?AVIfTrack@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IfTrack
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098998 (1 vfunc)
}

[Rtti(".?AVPreviewParameter@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PreviewParameter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010984D0 (1 vfunc)
}

[Rtti(".?AV?$RegistClassFactory@VIClip@Scheduler@Cut@Engine@CDev@SQEX@@@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RegistClassFactoryIClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097AAC (1 vfunc)
}

[Rtti(".?AVScheduleDataTransfer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScheduleDataTransfer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01096E30 (3 vfuncs)
}

[Rtti(".?AVScheduleRegister@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScheduleRegister
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010989AC (31 vfuncs)
}

[Rtti(".?AVSchedulerParameter@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SchedulerParameter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01093EF8 (1 vfunc)
}

[Rtti(".?AVScheduleTimer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScheduleTimer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097B64 (1 vfunc)
}

[Rtti(".?AVTrackContainer@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TrackContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010985EC (1 vfunc)
}
