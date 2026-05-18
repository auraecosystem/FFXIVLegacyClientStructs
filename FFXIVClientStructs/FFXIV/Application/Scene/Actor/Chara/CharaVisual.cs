using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.Chara;

// Inheritance chain:
//   CharaVisualBase
//     <- CDevActorSetResourceWithExcelEvent (vt=0x00FBBBF4)
//       <- CDevActorSetResourceEvent
//         <- CDevActorResourceEvent (vt=0x00FB7DA8)
//           <- Component::Resource::ResourceEvent (vt=0x00F670A8)
//             <- RaptureFileEvent (vt=0x00F93138)
//               <- Component::Resource::FileEvent (vt=0x00F930E8)
//
// Derived: CharaVisual, CharaCutVisual, WeaponVisual
[Rtti(".?AVCharaVisualBase@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct CharaVisualBase
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVCharaVisual@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)]
public unsafe struct CharaVisual
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVCharaCutVisual@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct CharaCutVisual
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVWeaponVisual@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct WeaponVisual
{
    [FieldOffset(0x00)] public nint VTable;
}

// CharaActionController — manages action execution, combos, animation triggers
// 5 vfuncs. Embedded in CharaActor at +0x2858.
// vt[1] = 0x008450B0 (539B) — main Update function
// vt[3] = 0x00845430 (203B) — action processor
[Rtti(".?AVCharaActionController@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x234)]
public unsafe struct CharaActionController
{
    [FieldOffset(0x00)] public nint VTable; // 0x0103E468 (5 vfuncs)
    // Size estimated from gap: next sub-object at +0x2A8C, this at +0x2858 → 0x234
}

[Rtti(".?AVCharaWeaponController@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct CharaWeaponController
{
    [FieldOffset(0x00)] public nint VTable;
}

// CharaCutVisualCtrl — cutscene visual state controller
// Embedded in CharaActor at +0x2B60. 1 vfunc. 6 confirmed fields, 7 sub-objects.
[Rtti(".?AVCharaCutVisualCtrl@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x50)]
public unsafe struct CharaCutVisualCtrl
{
    [FieldOffset(0x00)] public nint VTable; // 0x0104447C (1 vfunc)
    [FieldOffset(0x04)] public nint OwnerActorPtr;
    [FieldOffset(0x08)] public nint QueryHandle_VTable; // QueryHandle (vt=0x00FBC4F8)
    [FieldOffset(0x0C)] public uint State;
    [FieldOffset(0x38)] public uint CutVisualState;
    [FieldOffset(0x3C)] public nint CutVisualDataPtr;
    [FieldOffset(0x40)] public uint CutVisualFlags;
    // Size estimated from gap: struct ends at +0x2BB0, this at +0x2B60 → 0x50
}

// EffectResourceResourceEvent — VFX resource loading for character effects
// Embedded in CharaActor at +0x2B48.
[Rtti(".?AVEffectResourceResourceEvent@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe struct EffectResourceResourceEvent
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FC0CFC
    // Size estimated from gap: next sub-object at +0x2B60, this at +0x2B48 → 0x18
}

// CharaActorClipListener — cutscene clip notification handler
[Rtti(".?AVCharaActorClipListener@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct CharaActorClipListener
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FC0B44 (12 vfuncs)
}

// RaptureTextureManager — character texture loading and management
// Embedded in CharaActor at +0x0250.
// 703 bytes, 44 confirmed fields, 2 sub-objects.
[Rtti(".?AVRaptureTextureManager@Misc@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x2BF)]
public unsafe struct RaptureTextureManager
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FB6D94 (2 vfuncs)
    [FieldOffset(0x04)] public nint OwnerRef;
    [FieldOffset(0x08)] public nint TextureArrayPtr;
    [FieldOffset(0x0C)] public nint SecondaryVTable; // 0x00FB6E10
    [FieldOffset(0x30)] public uint NullMarker; // ASCII "null" = 0x6E756C6C
    [FieldOffset(0x83)] public byte TextureLoadState;
    [FieldOffset(0x0154)] public float TextureScaleU;
    [FieldOffset(0x0158)] public float TextureScaleV;
    [FieldOffset(0x015C)] public float TextureOffsetU;
    [FieldOffset(0x0210)] public uint TextureFlags; // init 1
    [FieldOffset(0x0240)] public byte TextureReady; // init 1
}
