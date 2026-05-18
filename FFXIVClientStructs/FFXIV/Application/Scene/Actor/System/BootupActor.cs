using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.System;

// Application::Scene::Actor::System::BootupActor
// Manages boot sequence: login, character selection, data center
// Vtable: 0x00FB86C4 (164 virtual methods)
// RTTI: .?AVBootupActor@System@Actor@Scene@Application@@
[Rtti(".?AVBootupActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x400)] // size TBD
public unsafe struct BootupActor
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FB86C4
}
