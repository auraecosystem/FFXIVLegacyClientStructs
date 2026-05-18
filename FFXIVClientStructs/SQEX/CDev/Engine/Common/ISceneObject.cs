using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Common.ISceneObject;

// Crystal Tools ISceneObject — Interfaces for the scene object system.
// These pure interfaces define the contracts for actors, cameras, controllers,
// effects, etc. Concrete implementations live in Fw::SceneObject.

[Rtti(".?AVIDrawLayerManager@DrawLayer@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IDrawLayerManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB6DE0 (11 vfuncs)
}

// Inherits: IScheduleObject
[Rtti(".?AVIAccObject@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IAccObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01096E44 (34 vfuncs)
}

[Rtti(".?AVIActorContainer@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IActorContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109D72C (8 vfuncs)
}

[Rtti(".?AVIApplicationConfiguration@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IApplicationConfiguration
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109BE54 (17 vfuncs)
}

[Rtti(".?AVIBGLayoutController@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IBGLayoutController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109C850 (2 vfuncs)
}

[Rtti(".?AVICamera@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct ICamera
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109DCBC (10 vfuncs)
}

[Rtti(".?AVICameraContainer@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct ICameraContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109C86C (15 vfuncs)
}

[Rtti(".?AVICharacterController@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct ICharacterController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109D89C (32 vfuncs)
}

[Rtti(".?AVIClipIterator@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IClipIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098720 (4 vfuncs)
}

[Rtti(".?AVICompactionMemory@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct ICompactionMemory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109D0AC (3 vfuncs)
}

[Rtti(".?AVIEffect@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IEffect
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010B822C (56 vfuncs)
}

[Rtti(".?AVIEffectListener@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IEffectListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0105901C (6 vfuncs)
}

[Rtti(".?AVIInquiryPackResource@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IInquiryPackResource
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBB238 (4 vfuncs)
}

[Rtti(".?AVIMccListener@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IMccListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FE7E90 (4 vfuncs)
}

// Inherits: IScheduleObject
[Rtti(".?AVIMccObject@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IMccObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01033584 (47 vfuncs)
}

[Rtti(".?AVIMccParameter@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IMccParameter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0103355C (9 vfuncs)
}

[Rtti(".?AVIMotionController@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IMotionController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109E24C (32 vfuncs)
}

[Rtti(".?AVIMotionLayerController@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IMotionLayerController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109E1EC (23 vfuncs)
}

[Rtti(".?AVIPhysicsController@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IPhysicsController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109DE14 (18 vfuncs)
}

[Rtti(".?AVIResourceSceneGraph@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IResourceSceneGraph
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109CFDC (19 vfuncs)
}

[Rtti(".?AVIScheduleController@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IScheduleController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109D3DC (24 vfuncs)
}

[Rtti(".?AVIScheduleDataTransfer@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IScheduleDataTransfer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01096D54 (3 vfuncs)
}

[Rtti(".?AVIScheduleListener@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IScheduleListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF53AC (6 vfuncs)
}

[Rtti(".?AVIScheduleObject@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IScheduleObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010334DC (31 vfuncs)
}

[Rtti(".?AVIScheduleRegister@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IScheduleRegister
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109788C (31 vfuncs)
}

[Rtti(".?AVISoundController@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct ISoundController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109E570 (6 vfuncs)
}

[Rtti(".?AVIVfxActor@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IVfxActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010B6D8C (46 vfuncs)
}

[Rtti(".?AVIVfxActorListener@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IVfxActorListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01032B0C (2 vfuncs)
}

[Rtti(".?AVIVfxContainer@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IVfxContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109DD20 (11 vfuncs)
}

[Rtti(".?AVIWorld@ISceneObject@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IWorld
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109C7F0 (9 vfuncs)
}
