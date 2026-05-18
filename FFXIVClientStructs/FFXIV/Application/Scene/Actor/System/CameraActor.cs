using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.System;

// ============================================================================
// Application::Scene::Actor::System::CameraActor
// Manages all camera perspectives: first/third person, character creation, etc.
//
// VTable: 0x00FB906C (164 virtual methods)
// RTTI:   .?AVCameraActor@System@Actor@Scene@Application@@
//
// Inheritance chain (from RTTI CHD):
//   CameraActor
//     <- CDevActor
//       <- RaptureActor (vt=0x00FEA50C)
//         <- SQEX::CDev::Engine::Fw::SceneObject::Actor (vt=0x0109CA94, 89 vfuncs)
//           <- IActor, IReferenceResource, SceneObjectMemoryObject, NonCopyable
//
// Related RTTI types:
//   CameraActorSchedulerListener (vt=0x00FB7B24, 13 vfuncs, 11 stubs)
//   CameraActorClipListener (vt=0x00FB7B5C, 11 vfuncs)
//   CamerarContext base (vt=0x00FF0ED4, 18 vfuncs) — note: typo in original binary
//   11 CameraActorContext types (all 18 vfuncs, inherit CamerarContext)
//
// String refs: CDev.Engine.Lay.Extrn.Cut/Vfx, CharaBias, VfxBias
// ============================================================================

[Rtti(".?AVCameraActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x400)]
public unsafe struct CameraActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB906C (164 vfuncs)
}

// ============================================================================
// CameraActorSchedulerListener — Cutscene scheduler callback for camera
//
// VTable: 0x00FB7B24 (13 virtual methods, 11 stubs)
// RTTI:   .?AVCameraActorSchedulerListener@...
//
// Inherits: RaptureActorSchedulerListenerBase (vt=0x00FB7ABC)
//           <- ISchedulerListener (vt=0x00FB7A84)
//
// Only vt[5] (7B) and vt[11] (106B) are real implementations.
// Same pattern as GameManagerActorSchedulerListener.
// ============================================================================

[Rtti(".?AVCameraActorSchedulerListener@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct CameraActorSchedulerListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7B24
}

// ============================================================================
// CameraActorClipListener — Clip/timeline event handler for camera
//
// VTable: 0x00FB7B5C (11 virtual methods)
// RTTI:   .?AVCameraActorClipListener@...
// Inherits: RaptureActorClipListener
// ============================================================================

[Rtti(".?AVCameraActorClipListener@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct CameraActorClipListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7B5C
}

// ============================================================================
// CamerarContext — Base class for all camera perspective modes
//
// VTable: 0x00FF0ED4 (18 virtual methods)
// RTTI:   .?AVCamerarContext@System@Actor@Scene@Application@@
//
// NOTE: The name "CamerarContext" is a typo in the original binary RTTI.
// The intended name is likely "CameraContext".
//
// All 11 derived context types share the same 18-vfunc interface:
//   vt[0]  = destructor
//   vt[1..17] = context-specific camera control methods
//              (activate, deactivate, update, getPosition, getTarget,
//               getUp, getFOV, getNearFar, etc.)
// ============================================================================

[Rtti(".?AVCamerarContext@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CamerarContext
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF0ED4 (18 vfuncs)
}

// 11 camera context types — all inherit CamerarContext (18 vfuncs each)

[Rtti(".?AVCameraActorContextCharaCreate@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextCharaCreate
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF0F74
}

[Rtti(".?AVCameraActorContextCharaFocus@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextCharaFocus
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF0FCC
}

[Rtti(".?AVCameraActorContextCharaSelect@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextCharaSelect
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF0F24
}

[Rtti(".?AVCameraActorContextFPS@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextFPS
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF101C
}

[Rtti(".?AVCameraActorContextFPS_Lock@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextFPS_Lock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF106C
}

[Rtti(".?AVCameraActorContextTPS@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextTPS
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF10BC
}

[Rtti(".?AVCameraActorContextTPS_Lock@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextTPS_Lock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF110C
}

[Rtti(".?AVCameraActorContextWowFPS@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextWowFPS
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF1164
}

[Rtti(".?AVCameraActorContextWowFPS_Lock@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextWowFPS_Lock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF11B4
}

[Rtti(".?AVCameraActorContextWowTPS@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextWowTPS
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF1204
}

[Rtti(".?AVCameraActorContextWowTPS_Lock@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CameraActorContextWowTPS_Lock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF125C
}
