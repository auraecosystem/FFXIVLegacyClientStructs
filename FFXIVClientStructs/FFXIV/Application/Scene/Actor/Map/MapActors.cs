using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.Map;

// Application::Scene::Actor::Map::BgModel
// Static background geometry
[Rtti(".?AVBgModel@Instance@Map@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct BgModel
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Scene::Actor::Map::BgObject
// Interactive background objects
[Rtti(".?AVBgObject@Instance@Map@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct BgObject
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Scene::Actor::Map::BgPlate
// Ground plate geometry
[Rtti(".?AVBgPlate@Instance@Map@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct BgPlate
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Scene::Actor::Map::BgEffect
// Map visual effects
[Rtti(".?AVBgEffect@Instance@Map@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct BgEffect
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Scene::Actor::Map::CollisionBox
[Rtti(".?AVCollisionBox@Instance@Map@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct CollisionBox
{
    [FieldOffset(0x00)] public nint VTable;
}
