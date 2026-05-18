using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.System;

// Application::Scene::Actor::System::CameraActor
// Manages camera contexts: FPS, TPS, CharaCreate, CharaSelect, etc.
// RTTI: .?AVCameraActor@System@Actor@Scene@Application@@
// Related RTTI classes:
//   CameraActorContextFPS, CameraActorContextTPS,
//   CameraActorContextWowFPS, CameraActorContextWowTPS,
//   CameraActorContextCharaCreate, CameraActorContextCharaSelect
[Rtti(".?AVCameraActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x300)] // size TBD
public unsafe struct CameraActor
{
    [FieldOffset(0x00)] public nint VTable;
}
