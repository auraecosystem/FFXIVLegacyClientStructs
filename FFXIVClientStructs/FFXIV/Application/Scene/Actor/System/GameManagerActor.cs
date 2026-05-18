using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.System;

// Application::Scene::Actor::System::GameManagerActor
// Vtable: 0x00FB8134 (164 virtual methods)
// Ctor:   0x00612270
// RTTI:   .?AVGameManagerActor@System@Actor@Scene@Application@@
//
// Multiple vtable stores during construction (multi-inheritance/init chain):
//   0x00FB8100 = GameManagerActorResourceEvent (intermediate base init)
//   0x00FB8134 = GameManagerActor (final vtable)
//   0x00FB83CC = TargetActor (base class in the inheritance chain)
//
// Sub-objects:
//   +0x0140: (ctor 0x007CCAF0)
//   +0x0144: vtable 0x00FB7D74 (unnamed sub-object)
//   +0x0160: PostEffectController (vtable 0x00FB7DC8)
//   +0x0570: (ctor 0x0061F5E0)
//
// PostEffectController manages: BlurFilter, ColorCorrectionFilter, CrossFade
[Rtti(".?AVGameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x600)] // estimated, alloc not yet confirmed
public unsafe struct GameManagerActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB8134

    // Inherited from TargetActor chain:
    // +0x04..+0x13F: base actor fields

    [FieldOffset(0x0144)] public nint SubObject_0144_VTable; // 0x00FB7D74

    // PostEffectController — handles all screen post-processing
    [FieldOffset(0x0160)] public nint PostEffectController_VTable; // 0x00FB7DC8
}

// Application::Scene::Actor::System::TargetActor (base class of GameManagerActor)
// Vtable: 0x00FB83CC
[Rtti(".?AVTargetActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)]
public unsafe struct TargetActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB83CC
}

// Application::Scene::Actor::System::GameManagerActor::PostEffectController
// Vtable: 0x00FB7DC8
[Rtti(".?AVPostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x400)]
public unsafe struct PostEffectController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7DC8
}
