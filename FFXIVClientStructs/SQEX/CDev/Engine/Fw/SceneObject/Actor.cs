using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Fw.SceneObject;

// Crystal Tools Fw::SceneObject — Concrete implementations of the
// ISceneObject interfaces. Actor is the base for all scene actors;
// Controllers, DrawLayer, Camera, Motion, etc. are sub-components.

[Rtti(".?AVActor@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct Actor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109CA94 (89 vfuncs)
    [FieldOffset(0x0048)] public nint SubObject;
}

[Rtti(".?AVCameraContainer@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct CameraContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109C8AC (17 vfuncs)
}

// Controllers:: sub-namespace types

// Inherits: IScheduleObject
[Rtti(".?AVAccObject@Controllers@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct AccObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109D57C (39 vfuncs)
}

[Rtti(".?AVBGLayoutController@Controllers@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BGLayoutController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109C85C (2 vfuncs)
}

[Rtti(".?AVMccObject@Controllers@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct MccObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109D4BC (47 vfuncs)
}

[Rtti(".?AVMccParameter@Controllers@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MccParameter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01033644 (9 vfuncs)
}

[Rtti(".?AVPhysicsController@Controllers@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct PhysicsController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109DE84 (18 vfuncs)
}

[Rtti(".?AVSoundController@Controllers@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct SoundController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109E6A0 (6 vfuncs)
}

// DrawLayer:: sub-namespace types

[Rtti(".?AVDrawLayerManager@DrawLayer@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct DrawLayerManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB6E38 (11 vfuncs)
}

// Top-level SceneObject types

[Rtti(".?AVIModelObjectFactory@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IModelObjectFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FEA4BC (2 vfuncs)
}

[Rtti(".?AVMatrixCamera@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct MatrixCamera
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109DCE8 (12 vfuncs)
}

[Rtti(".?AVModelObjectContainer@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct ModelObjectContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109E74C (5 vfuncs)
}

[Rtti(".?AVMotionController@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct MotionController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109E464 (32 vfuncs)
}

[Rtti(".?AVMotionLayerController@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct MotionLayerController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109E2DC (23 vfuncs)
}

[Rtti(".?AVRSGAdapter@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct RSGAdapter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109CC14 (2 vfuncs)
}

[Rtti(".?AVVfxContainer@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct VfxContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109DD80 (6 vfuncs)
}
