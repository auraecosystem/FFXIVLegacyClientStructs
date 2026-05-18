using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.Chara;

// Application::Scene::Actor::Chara::CharaActor
// Vtable: 0x00FC0D34 (188 virtual methods)
// Ctor:   0x0065F180
// Size:   0x2BB0 (11,184 bytes)
// Alloc:  push 0x2BB0 @ 0x0079FB34
// RTTI:   .?AVCharaActor@Chara@Actor@Scene@Application@@
//
// Inherits CDevActor chain. 188 vfuncs (largest actor vtable in the game).
// Lua API: 166 bindings via CharaBase script layer (see _getPosition etc.)
[Rtti(".?AVCharaActor@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x2BB0)]
public unsafe struct CharaActor
{
    [FieldOffset(0x0000)] public nint VTable;

    // --- Actor base region (inherited from CDevActor chain) ---
    [FieldOffset(0x009C)] public nint AllocatedObject;

    [FieldOffset(0x0138)] public int Handle; // init -1 (invalid)

    // Possible position / transform region:
    [FieldOffset(0x0154)] public float Field_154; // init 0.0
    [FieldOffset(0x0158)] public float Field_158; // init 0.0
    [FieldOffset(0x015C)] public ushort Field_15C;
    [FieldOffset(0x0160)] public uint Field_160;
    [FieldOffset(0x0164)] public byte Field_164;
    [FieldOffset(0x0168)] public byte Field_168;
    [FieldOffset(0x0169)] public byte Enabled; // init 1

    // --- Embedded sub-objects (identified via ctor LEA+CALL chains) ---
    // +0x016C: sub-object (ctor 0x007A67D0)
    // +0x01BC: sub-object (ctor 0x007A6120)
    // +0x035C: sub-object (ctor 0x007A6F70)
    // +0x0390: sub-object (ctor 0x007A60E0)
    // +0x03AC: sub-object (ctor 0x007A80A0)
    // +0x0438: sub-object (ctor 0x007B2240)

    // +0x04C0: IMccListener (vtable 0x00FE7E90)
    [FieldOffset(0x04C0)] public nint MccListener1_VTable;

    // +0x0590: sub-object (ctor 0x007B72A0)
    // +0x0B50: sub-object (ctor 0x007A60B0)
    // +0x0B80: sub-object (ctor 0x007A8280)
    // +0x0BF0: sub-object (ctor 0x007B82B0)
    // +0x0FC0: sub-object (ctor 0x007B1180)
    // +0x1030: sub-object (ctor 0x007AB450)
    // +0x1070: sub-object (ctor 0x007A98E0)

    // +0x1110: IMccListener (vtable 0x00FE7E90)
    [FieldOffset(0x1110)] public nint MccListener2_VTable;

    // --- Character stat/attribute region ---
    [FieldOffset(0x1170)] public uint MainStatParam1; // init 0xED (237)
    [FieldOffset(0x1174)] public uint MainStatParam2;
    [FieldOffset(0x1178)] public uint MainStatParam3; // init 0xC9 (201)
    [FieldOffset(0x117C)] public uint MainStatParam4;
    [FieldOffset(0x1180)] public uint MainStatParam5;
    [FieldOffset(0x1184)] public uint MainStatParam6;

    // +0x118C: CutSceneManager (vtable 0x00FBEB1C, ctor 0x006355F0)
    [FieldOffset(0x118C)] public nint CutSceneManager_VTable;

    [FieldOffset(0x11B8)] public uint Field_11B8;

    // +0x1200: sub-object (ctor 0x0084A5B0) — possibly CharaVisual
    // +0x1264: sub-object (ctor 0x00849960)
    // +0x12C8: sub-object (ctor 0x00849870)
    [FieldOffset(0x12F0)] public nint Field_12F0;
    [FieldOffset(0x12F4)] public nint Field_12F4;

    // +0x12F8: sub-object (ctor 0x00445CF0)
    [FieldOffset(0x134C)] public uint Field_134C;

    // +0x1354: TargetInfo (vtable 0x00FA415C)
    [FieldOffset(0x1354)] public nint TargetInfo1_VTable;
    // +0x13C8: TargetInfo (vtable 0x00FA415C) — second target (focus target?)
    [FieldOffset(0x13C8)] public nint TargetInfo2_VTable;

    // +0x143C: sub-object (ctor 0x00855150)
    // +0x1530: sub-object (ctor 0x008434C0)
    // +0x1650: sub-object (ctor 0x00853480)

    // Stat array region:
    [FieldOffset(0x1690)] public fixed uint StatArray[10]; // 10 dwords, all init 0

    // +0x1780: sub-object (ctor 0x0061D050)

    [FieldOffset(0x1958)] public uint Capacity; // init 0x10

    [FieldOffset(0x1970)] public nint Field_1970;

    // +0x2130: sub-object (ctor 0x007D0C70)
    // +0x21AC: sub-object (ctor 0x00852940)

    // +0x21D4: ResourceEvent (vtable 0x00F670A8)
    [FieldOffset(0x21D4)] public nint ResourceEvent_VTable;

    // +0x25E4: sub-object (ctor 0x00857830)
    // +0x2608: sub-object (ctor 0x00852EC0)
    // +0x2620: sub-object (ctor 0x00854B00)
    // +0x2830: sub-object (ctor 0x007D1400)

    // +0x2858: CharaActionController (vtable 0x0103E468)
    [FieldOffset(0x2858)] public nint ActionController_VTable;

    // +0x2A8C: OcclusionBoundary (vtable 0x010468D4)
    [FieldOffset(0x2A8C)] public nint OcclusionBoundary_VTable;

    // +0x2AEC: OcclusionBoundaryAABB (vtable 0x010468E0)
    [FieldOffset(0x2AEC)] public nint OcclusionBoundaryAABB_VTable;

    // +0x2B48: EffectResourceResourceEvent (vtable 0x00FC0CFC)
    [FieldOffset(0x2B48)] public nint EffectResourceEvent_VTable;

    // +0x2B60: CharaCutVisualCtrl (vtable 0x0104447C)
    [FieldOffset(0x2B60)] public nint CutVisualCtrl_VTable;
}
