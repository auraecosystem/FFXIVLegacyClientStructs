using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.Chara;

// Application::Scene::Actor::Chara::CharaActor
// VTable: 0x00FC0D34 (188 virtual methods)
// Ctor:   0x0065F180
// Size:   0x2BB0 (11,184 bytes)
// Alloc:  push 0x2BB0 @ 0x0079FB34
//
// Inheritance chain (from RTTI CHD):
//   CharaActor
//     <- CDevActor
//       <- RaptureActor (vt=0x00FEA50C)
//         <- SQEX::CDev::Engine::Fw::SceneObject::Actor (vt=0x0109CA94, 89 vfuncs)
//           <- IActor, IReferenceResource, SceneObjectMemoryObject, NonCopyable
//
// 188 vfuncs (largest actor vtable). 55 confirmed fields. 42 embedded sub-objects.
// Source path: D:\rapture\src\ExternalSdk\cdev\include\CDev/Engine/Fw/SceneObject/Actor.h
[Rtti(".?AVCharaActor@Chara@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x2BB0)]
public unsafe struct CharaActor
{
    // ======================== VTable & Base ========================
    [FieldOffset(0x0000)] public nint VTable; // 0x00FC0D34

    [FieldOffset(0x0004)] public nint SceneObjectPtr;
    // +0x0008..0x0048: Actor base region (inherited from CDev::Actor)
    //   +0x0048: SubObject ptr (from Actor base)

    // ======================== Actor Identity ========================
    [FieldOffset(0x009C)] public nint AllocatedObject;
    [FieldOffset(0x0138)] public int Handle; // init -1 (INVALID_HANDLE)
    [FieldOffset(0x0169)] public byte Enabled; // init 1

    // ======================== Transform ========================
    [FieldOffset(0x0154)] public float PositionX;
    [FieldOffset(0x0158)] public float PositionY;
    [FieldOffset(0x015C)] public ushort RotationPacked;
    [FieldOffset(0x0160)] public uint TransformFlags;

    // ======================== Visual System ========================
    // +0x01BC: sub-object (ctor 0x007A6120) — visual data block A
    [FieldOffset(0x0250)] public nint TextureManager_VTable; // RaptureTextureManager (vt=0x00FB6D94, 703B, 44 fields)
    // +0x035C: sub-object (ctor 0x007A6F70)
    // +0x0390: sub-object (ctor 0x007A60E0)
    // +0x03AC: sub-object (ctor 0x007A80A0)
    // +0x0438: sub-object (ctor 0x007B2240)

    // ======================== MCC Listeners ========================
    [FieldOffset(0x04C0)] public nint MccListener1_VTable; // IMccListener (vt=0x00FE7E90)
    // +0x0590: sub-object (ctor 0x007B72A0) — large block (~0x5C0 bytes)
    // +0x0B50: sub-object (ctor 0x007A60B0)
    // +0x0B80: sub-object (ctor 0x007A8280)
    // +0x0BF0: sub-object (ctor 0x007B82B0) — large block (~0x3D0 bytes)
    // +0x0FC0: sub-object (ctor 0x007B1180)
    // +0x1030: sub-object (ctor 0x007AB450)
    // +0x1070: sub-object (ctor 0x007A98E0)

    [FieldOffset(0x1110)] public nint MccListener2_VTable; // IMccListener (vt=0x00FE7E90)

    // ======================== Stats & Attributes ========================
    [FieldOffset(0x1170)] public uint MainStatParam1; // init 0xED (237)
    [FieldOffset(0x1174)] public uint MainStatParam2;
    [FieldOffset(0x1178)] public uint MainStatParam3; // init 0xC9 (201)
    [FieldOffset(0x117C)] public uint MainStatParam4;
    [FieldOffset(0x1180)] public uint MainStatParam5;
    [FieldOffset(0x1184)] public uint MainStatParam6;
    [FieldOffset(0x1188)] public byte StatDirtyFlag;

    // ======================== Cutscene System ========================
    [FieldOffset(0x118C)] public nint CutSceneManager_VTable; // CutSceneManager (vt=0x00FBEB1C, ctor=0x006355F0)
    [FieldOffset(0x11B8)] public uint CutSceneState;
    [FieldOffset(0x11BC)] public float CutSceneBlend;
    [FieldOffset(0x11E0)] public float CutSceneTimer;

    // ======================== Equipment / Visual State ========================
    // +0x1200: sub-object (ctor 0x0084A5B0)
    // +0x1264: sub-object (ctor 0x00849960)
    // +0x12C8: sub-object (ctor 0x00849870)
    [FieldOffset(0x12F0)] public uint EquipmentState;
    [FieldOffset(0x12F4)] public nint EquipmentDataPtr;
    // +0x12F8: sub-object (ctor 0x00445CF0) — small helper
    [FieldOffset(0x134C)] public uint VisualUpdateFlags;

    // ======================== Target System ========================
    [FieldOffset(0x1354)] public nint TargetInfo_VTable;      // TargetInfo (vt=0x00FA415C, size=0x74)
    [FieldOffset(0x13C8)] public nint FocusTargetInfo_VTable; // TargetInfo (vt=0x00FA415C, size=0x74)
    // +0x143C: sub-object (ctor 0x00855150)

    // ======================== Battle / Action System ========================
    // +0x1530: sub-object (ctor 0x008434C0)
    // +0x1650: sub-object (ctor 0x00853480)

    [FieldOffset(0x1690)] public fixed uint StatArray[10]; // 10 dwords, all zero-init

    // +0x1780: sub-object (ctor 0x0061D050) — large block (~0x9B0 bytes)

    // ======================== Misc Runtime State ========================
    [FieldOffset(0x1950)] public float Field_1950;
    [FieldOffset(0x1954)] public float Field_1954;
    [FieldOffset(0x1958)] public uint Capacity; // init 0x10
    [FieldOffset(0x195C)] public float Field_195C;
    [FieldOffset(0x1970)] public nint RuntimeContextPtr;

    // ======================== Rendering / LOD ========================
    // +0x2130: sub-object (ctor 0x007D0C70) — rendering context
    // +0x21AC: sub-object (ctor 0x00852940)

    [FieldOffset(0x21D4)] public nint ResourceEvent_VTable; // Component::Resource::ResourceEvent (vt=0x00F670A8)

    // +0x25E4: sub-object (ctor 0x00857830)
    // +0x2608: sub-object (ctor 0x00852EC0)
    // +0x2620: sub-object (ctor 0x00854B00)
    // +0x2830: sub-object (ctor 0x007D1400)

    // ======================== Action Controller ========================
    [FieldOffset(0x2858)] public nint ActionController_VTable; // CharaActionController (vt=0x0103E468)

    // ======================== Occlusion ========================
    [FieldOffset(0x2A8C)] public nint OcclusionBoundary_VTable;     // OcclusionBoundary (vt=0x010468D4)
    // +0x2ACC: sub-object (ctor 0x008526C0)
    // +0x2AE0: sub-object (ctor 0x007D1770)
    [FieldOffset(0x2AEC)] public nint OcclusionBoundaryAABB_VTable; // OcclusionBoundaryAABB (vt=0x010468E0)
    // +0x2AF0: sub-object (ctor 0x00857010)
    // +0x2AFC: sub-object (ctor 0x00856E50)

    // ======================== Tail Region ========================
    [FieldOffset(0x2B0C)] public uint TailFlags1;
    [FieldOffset(0x2B10)] public uint TailFlags2;
    [FieldOffset(0x2B14)] public uint TailFlags3;
    [FieldOffset(0x2B38)] public uint TailState1;
    [FieldOffset(0x2B3C)] public uint TailState2;
    [FieldOffset(0x2B40)] public uint TailState3;
    [FieldOffset(0x2B44)] public uint TailState4;

    // ======================== Effect / VFX ========================
    [FieldOffset(0x2B48)] public nint EffectResourceEvent_VTable; // EffectResourceResourceEvent (vt=0x00FC0CFC)
    [FieldOffset(0x2B5C)] public nint EffectContextPtr;

    // ======================== Cut Visual Controller ========================
    [FieldOffset(0x2B60)] public nint CutVisualCtrl_VTable; // CharaCutVisualCtrl (vt=0x0104447C, 1 vfunc, 7 sub-objects)

    // ======================== End-of-struct state ========================
    [FieldOffset(0x2B70)] public uint EndState1;
    [FieldOffset(0x2B74)] public nint EndPtr1;
    [FieldOffset(0x2B84)] public uint EndState2;
    [FieldOffset(0x2B88)] public uint EndState3;
    [FieldOffset(0x2B8C)] public nint EndPtr2;
    [FieldOffset(0x2B90)] public nint EndPtr3;
    [FieldOffset(0x2B94)] public uint EndFlags1;
    [FieldOffset(0x2B98)] public uint EndFlags2;
    [FieldOffset(0x2B9C)] public uint EndFlags3;
    [FieldOffset(0x2BA0)] public uint EndFlags4;
    // struct ends at 0x2BB0

    // ======================== Virtual Function Table ========================
    // 188 entries. 30 identified as stubs. Key functions:
    //
    // vt[0]   0x00669E20 (6B)    — destructor [STUB]
    // vt[1]   0x006207D0 (135B)  — Initialize
    // vt[7]   0x007CD1C0 (72B)   — Update
    // vt[23]  0x00661F00 (140B)  — thiscall(this, arg1, arg2) — SetPosition?
    // vt[24]  0x00661FC0 (140B)  — thiscall(this, arg1, arg2) — SetRotation?
    // vt[29]  0x0065B840 (257B)  — Tick/Process
    // vt[31]  0x0065B850 (241B)  — thiscall(this, arg1)
    // vt[38]  0x00660CD0 (166B)  — thiscall(this, arg1)
    // vt[48]  0x00A60620 (111B)  — thiscall(this, arg1..4) — 4-param handler
    // vt[68]  0x007CD360 (226B)  — large processor
    // vt[80]  0x00A60E30 (112B)  — state handler
    // vt[98]  0x007CE9F0 (139B)  — combat/action related
    // vt[102] 0x007CF490 (242B)  — largest non-trivial function
    // vt[134] 0x0065F940 (341B)  — major handler
    // vt[136] 0x006605E0 (395B)  — second largest function
    // vt[142] 0x006679C0 (320B)  — significant handler
    // vt[157] 0x00662D30 (100B)  — thiscall(this, arg1..3) — 3-param handler
    // vt[165] 0x00660D80 (375B)  — thiscall(this, arg1)
    // vt[166] 0x00660F70 (344B)  — thiscall(this, arg1)
}
