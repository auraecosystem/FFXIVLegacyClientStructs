using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.Chara;

// Application::Scene::Actor::Chara::CharaVisualBase
// RTTI: .?AVCharaVisualBase@Chara@Actor@Scene@Application@@
[Rtti(".?AVCharaVisualBase@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)] // size TBD
public unsafe struct CharaVisualBase
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Scene::Actor::Chara::CharaVisual
// RTTI: .?AVCharaVisual@Chara@Actor@Scene@Application@@
[Rtti(".?AVCharaVisual@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)] // size TBD
public unsafe struct CharaVisual
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Scene::Actor::Chara::CharaActionController
// RTTI: .?AVCharaActionController@Chara@Actor@Scene@Application@@
[Rtti(".?AVCharaActionController@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)] // size TBD
public unsafe struct CharaActionController
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Scene::Actor::Chara::CharaWeaponController
// RTTI: .?AVCharaWeaponController@Chara@Actor@Scene@Application@@
[Rtti(".?AVCharaWeaponController@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)] // size TBD
public unsafe struct CharaWeaponController
{
    [FieldOffset(0x00)] public nint VTable;
}
