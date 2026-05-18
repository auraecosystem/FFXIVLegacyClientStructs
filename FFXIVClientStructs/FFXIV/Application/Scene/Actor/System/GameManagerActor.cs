using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.System;

// ============================================================================
// Application::Scene::Actor::System::TargetActor
// Base class for GameManagerActor (and likely BootupActor).
//
// VTable: 0x00FB83CC (160 virtual methods, 47 stubs)
// Ctor:   0x00612FC0
// Size:   ~0x09C0 (estimated from field range +0x0000..+0x09B4)
// RTTI:   .?AVTargetActor@System@Actor@Scene@Application@@
//
// Inheritance chain (from RTTI CHD):
//   TargetActor
//     <- RaptureActor (vt=0x00FEA50C)
//       <- SQEX::CDev::Engine::Fw::SceneObject::Actor (vt=0x0109CA94, 89 vfuncs)
//         <- IActor, IReferenceResource, SceneObjectMemoryObject, NonCopyable
//
// NOTE: Unlike CharaActor/BootupActor/CameraActor, TargetActor does NOT
// inherit through CDevActor — it connects directly to RaptureActor.
//
// 79 fields from ctor init. 16 embedded sub-objects.
// String refs: Actor.cpp, EID_NAME, EID_BODY_DYN, LightSet, DArray,
//              PriorityDatabase::GetActorPriorityOffset, CreateActorConstraint
// Source: D:\rapture\src\ExternalSdk\cdev\include\CDev/Engine/Fw/SceneObject/Actor.h
// ============================================================================

[Rtti(".?AVTargetActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x09C0)]
public unsafe struct TargetActor
{
    // ======================== VTable & Base ========================
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB83CC (160 vfuncs)

    // Actor base region (from CDev::Engine::Fw::SceneObject::Actor)
    [FieldOffset(0x0004)] public float BaseFieldA; // xmm0 init
    [FieldOffset(0x0008)] public float BaseFieldB; // xmm0 init
    [FieldOffset(0x000C)] public float BaseFieldC; // xmm0 init
    [FieldOffset(0x000F)] public byte InitFlag; // init 0x00
    [FieldOffset(0x0010)] public int InvalidId; // init 0xFFFFFFFE (-2, sentinel)

    // +0x0048: SubObject ptr (inherited from Actor base)

    // ======================== Transform ========================
    [FieldOffset(0x00D0)] public float TransformFloat; // xmm0 init (from RaptureActor base)

    // ======================== Actor References ========================
    [FieldOffset(0x0124)] public uint ReferenceA; // edi init
    [FieldOffset(0x0128)] public uint ReferenceB; // edi init
    [FieldOffset(0x012C)] public uint ReferenceC; // eax
    [FieldOffset(0x0130)] public uint ReferenceD; // eax
    [FieldOffset(0x0134)] public uint ReferenceE; // eax
    [FieldOffset(0x0138)] public uint ReferenceF; // eax
    [FieldOffset(0x013C)] public uint ReferenceG; // eax

    // ======================== Embedded Sub-Objects ========================
    // +0x013C: GameManagerActorSchedulerListener (vt=0x00FB7B8C, ctor=0x0061F9E0, 13 vfuncs)
    // +0x0140: unknown (no vtable, ctor=0x007CCAF0)
    [FieldOffset(0x0140)] public uint SubObject_0140;
    // +0x0144: unknown (no vtable, ctor=0x0061FD20)

    // ======================== Layout Sub-Objects ========================
    // +0x0160: unknown (no vtable, ctor=0x006125E0)
    // +0x0164: unknown (no vtable, ctor=0x0060FA50, gap=0x2C)
    [FieldOffset(0x0168)] public byte StateFlags; // init 0x20
    [FieldOffset(0x0169)] public byte StateCleared; // init 0x00

    [FieldOffset(0x0174)] public uint Field_0174; // eax

    // ======================== Resource Management ========================
    [FieldOffset(0x0184)] public uint ResourceA; // ecx — from CreateModel / CreateActorConstraint
    [FieldOffset(0x018C)] public uint ResourceB; // eax

    // +0x0190: unknown (no vtable, ctor=0x0060FAB0, gap=0x28)

    [FieldOffset(0x01A8)] public uint Field_01A8; // eax

    // ======================== Timing / Animation ========================
    // +0x01B8: unknown (no vtable, ctor=0x0061FDD0, gap=0x48)
    [FieldOffset(0x01B8)] public uint TimingA; // edx
    [FieldOffset(0x01C4)] public uint TimingB; // ecx
    [FieldOffset(0x01C8)] public uint TimingC; // eax
    [FieldOffset(0x01CC)] public float TimingFloatA; // xmm0
    [FieldOffset(0x01D0)] public float TimingFloatB; // xmm1
    [FieldOffset(0x01D4)] public float TimingFloatC; // xmm2
    [FieldOffset(0x01D8)] public float TimingFloatD; // xmm3
    [FieldOffset(0x01E0)] public uint TimingD; // eax
    [FieldOffset(0x01EC)] public uint TimingE; // edx
    [FieldOffset(0x01F8)] public uint TimingF; // ecx

    // ======================== Rendering ========================
    // +0x0200: unknown (no vtable, ctor=0x0060FBC0, gap=0x30)
    // +0x0230: unknown (no vtable, ctor=0x0060FC00, gap=0x80)
    //   EID_NAME string ref, "CDev.Engine.Lay.Common.DArray"
    [FieldOffset(0x0230)] public float RenderFloat; // xmm0 init
    [FieldOffset(0x0240)] public byte RenderFlag; // init 0x00

    // +0x02B0: unknown (no vtable, ctor=0x0060FC20, gap=0x70)
    [FieldOffset(0x02AC)] public float VisualFloat; // xmm0 init

    // +0x0320: unknown (no vtable, ctor=0x0060FCA0, gap=0x20)
    // +0x0340: unknown (no vtable, ctor=0x00610200, gap=0x1F0) — large block

    // ======================== Action / State ========================
    [FieldOffset(0x03E4)] public float ActionFloat; // xmm0 init
    [FieldOffset(0x03E8)] public uint ActionState; // eax
    [FieldOffset(0x03F0)] public uint ActionConfig; // eax

    [FieldOffset(0x0480)] public byte TaskFlag; // init 0x00

    // ======================== Layout Manager ========================
    // +0x0530: unknown (no vtable, ctor=0x0061D390, gap=0x130)
    // +0x0660: unknown (no vtable, ctor=0x0060FCF0, gap=0x50)
    // +0x06B0: unknown (no vtable, ctor=0x0060FD30, gap=0x14)
    // +0x06C4: unknown (no vtable, ctor=0x00612CD0)

    // ======================== Task Configuration Array ========================
    // From RaptureActor base. 37 consecutive dwords forming a task/property table.
    // String ref: "diff <= (PriorityDatabase::GetActorPriorityOffset()*4)"
    // Likely task list priority offsets or property configuration indices.
    [FieldOffset(0x0910)] public uint PropertyArrayBase; // edx — array control field
    [FieldOffset(0x0914)] public fixed uint PropertyArray[37]; // [0x0914..0x09B4], 37 dwords
}

// ============================================================================
// Application::Scene::Actor::System::GameManagerActor
// Central game manager — orchestrates rendering, post-processing, cutscenes.
//
// VTable: 0x00FB8134 (164 virtual methods = TargetActor's 160 + 4 new)
// Ctor:   0x00612270
// Size:   ~0x09C0 (inherits TargetActor base, adds PostEffectController)
// RTTI:   .?AVGameManagerActor@System@Actor@Scene@Application@@
//
// Vtable stores during construction (multi-init chain):
//   0x00FB80E0 = GameManagerActorResourceEvent (intermediate)
//   0x00FB8100 = GameManagerActorResourceEvent (intermediate)
//   0x00FB8134 = GameManagerActor (final vtable)
//   0x00FB83CC = TargetActor (base class)
//
// 44 fields from ctor analysis. 18 embedded sub-objects.
// Unique sub-objects vs TargetActor:
//   +0x000C: ctor 0x0060F840 (NEW — not in TargetActor)
//   +0x0018: ctor 0x0060F8C0 (NEW — not in TargetActor)
//   +0x0144: vt=0x00FB7D74 (overrides TargetActor's unnamed at same offset)
//   +0x0160: PostEffectController (vt=0x00FB7DC8, overrides TargetActor's ctor)
//   +0x0340: ctor 0x006102F0 (overrides TargetActor's 0x00610200)
//   +0x0570: ctor 0x0061F5E0 (NEW — not in TargetActor)
//
// String refs: CharaBias, VfxBias, CDev.Engine.Lay.Extrn.Cut/Vfx,
//              EID_NAME, EID_BODY_DYN
// ============================================================================

[Rtti(".?AVGameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x09C0)]
public unsafe struct GameManagerActor
{
    // ======================== VTable & Base ========================
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB8134 (164 vfuncs)

    // Inherited: TargetActor base (+0x0000..+0x09B4)

    // ======================== GameManagerActor-Specific Fields ========================
    // These sub-objects exist in GMA but not in TargetActor:
    // +0x000C: unknown (no vtable, ctor=0x0060F840)
    // +0x0018: unknown (no vtable, ctor=0x0060F8C0)
    [FieldOffset(0x0018)] public uint GmaSubA; // ecx — exclusive to GMA
    [FieldOffset(0x0030)] public byte GmaFlag; // init 0x01

    [FieldOffset(0x0083)] public byte GmaState; // init 0x00

    // ======================== GMA Render Config ========================
    [FieldOffset(0x00A4)] public float RenderConfigFloat; // xmm0
    [FieldOffset(0x00A8)] public uint RenderConfigA; // eax
    [FieldOffset(0x00B0)] public uint RenderConfigB; // eax
    [FieldOffset(0x00B8)] public uint RenderConfigC; // ebx

    // ======================== Sub-Object Overrides ========================
    // +0x0144: vt=0x00FB7D74, ctor=0x00631BE0 (GMA overrides TargetActor's ctor at this slot)
    [FieldOffset(0x0144)] public nint SubObject_0144_VTable; // 0x00FB7D74

    // ======================== PostEffectController ========================
    // Post-processing filter orchestrator. Manages 15 screen-space effects.
    // GMA overrides TargetActor's sub-object at +0x0160 with this controller.
    [FieldOffset(0x0160)] public nint PostEffectController_VTable; // 0x00FB7DC8 (3 vfuncs)

    // ======================== GMA Layout Biases ========================
    // String refs: "CharaBias", "VfxBias" — render priority/layer biases
    [FieldOffset(0x0168)] public uint CharaBiasConfig; // ecx
    [FieldOffset(0x017C)] public uint LayoutBiasA; // edx
    [FieldOffset(0x0184)] public uint LayoutBiasB; // ecx
    [FieldOffset(0x0188)] public float LayoutBiasFloat; // xmm0
    [FieldOffset(0x018C)] public uint LayoutBiasC; // edx

    // ======================== Cutscene / VFX Layout ========================
    // String refs: "CDev.Engine.Lay.Extrn.Cut", "CDev.Engine.Lay.Extrn.Vfx"
    [FieldOffset(0x04C4)] public uint CutsceneLayoutState; // ecx
    [FieldOffset(0x04E0)] public float VfxLayoutFloat; // xmm0

    // +0x0570: unknown (no vtable, ctor=0x0061F5E0) — GMA-exclusive sub-object
}

// ============================================================================
// PostEffectController — Screen-space post-processing orchestrator
//
// VTable:  0x00FB7DC8 (3 virtual methods)
// Ctor:    0x0061FA40
// RTTI:    .?AVPostEffectController@GameManagerActor@System@Actor@Scene@Application@@
// Inherits: EffectControllerInterface
//
// Manages 15 PostFilterBase-derived filters, each with 1 vfunc:
//   PlaneFade       0x00FB7C0C    CrossFade         0x00FB7C14
//   GlareFilter     0x00FB7C1C    GammaCallibration 0x00FB7C24  [sic — original typo]
//   SsaoFilter      0x00FB7C2C    TargetEffectFilter  0x00FB7C34
//   TargetEffectFilter2 0x00FB7C3C TargetEffectFilter3 0x00FB7C44
//   DofFilter       0x00FB7C4C    VolLightFilter    0x00FB7C54
//   ColorCorrectionFilter 0x00FB7C5C  LUTColorCorrectionFilter 0x00FB7C64
//   BlurFilter      0x00FB7C6C    LatitudeFilter    0x00FB7C74
//   FogFilter       0x00FB7C7C    ShadowFilter      0x00FB7C84
// ============================================================================

[Rtti(".?AVPostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x410)]
public unsafe struct PostEffectController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7DC8 (3 vfuncs)
}

[Rtti(".?AVEffectControllerInterface@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct EffectControllerInterface
{
    [FieldOffset(0x0000)] public nint VTable;
}

// ============================================================================
// PostFilterBase — Base class for all post-processing filters
//
// VTable: 0x00FB7C04 (1 virtual method)
// Size:   0x80 (128 bytes)
// RTTI:   .?AVPostFilterBase@PostEffectController@GameManagerActor@...
//
// 17 fields from ctor analysis. 3 embedded sub-objects.
// All 15 derived filter types override the single vfunc (apply/update).
// ============================================================================

[Rtti(".?AVPostFilterBase@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct PostFilterBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C04 (1 vfunc)

    [FieldOffset(0x0004)] public uint ControllerPtr; // ecx — back-pointer to PostEffectController
    // +0x0008: sub-object (no vtable, ctor=0x0061ED20)
    [FieldOffset(0x000C)] public uint ParamA; // ecx
    [FieldOffset(0x0010)] public uint ParamB; // ecx
    [FieldOffset(0x0015)] public byte Enabled; // init 0x00
    [FieldOffset(0x0018)] public uint ParamC; // ecx
    // +0x0020: sub-object (no vtable, ctor=0x00445CF0)
    [FieldOffset(0x0024)] public uint FilterDataA; // edx
    [FieldOffset(0x0028)] public uint FilterDataB; // edx
    [FieldOffset(0x002C)] public ushort FilterDataC; // dx
    [FieldOffset(0x002E)] public ushort FilterDataD; // dx
    [FieldOffset(0x0030)] public uint FilterDataE; // ecx
    [FieldOffset(0x0034)] public uint FilterDataF; // ecx
    [FieldOffset(0x0074)] public float Intensity; // xmm0 init
    [FieldOffset(0x0078)] public uint StateA; // eax
    [FieldOffset(0x007C)] public uint StateB; // eax
}

// Derived filter types — all inherit PostFilterBase (0x80), override 1 vfunc

[Rtti(".?AVPlaneFade@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct PlaneFade
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C0C
}

[Rtti(".?AVCrossFade@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct CrossFade
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C14
}

[Rtti(".?AVGlareFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct GlareFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C1C
}

[Rtti(".?AVGammaCallibration@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct GammaCallibration
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C24
}

[Rtti(".?AVSsaoFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct SsaoFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C2C
}

[Rtti(".?AVTargetEffectFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct TargetEffectFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C34
}

[Rtti(".?AVTargetEffectFilter2@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct TargetEffectFilter2
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C3C
}

[Rtti(".?AVTargetEffectFilter3@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct TargetEffectFilter3
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C44
}

[Rtti(".?AVDofFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct DofFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C4C
}

[Rtti(".?AVVolLightFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct VolLightFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C54
}

[Rtti(".?AVColorCorrectionFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct ColorCorrectionFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C5C
}

[Rtti(".?AVLUTColorCorrectionFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct LUTColorCorrectionFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C64
}

[Rtti(".?AVBlurFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct BlurFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C6C
}

[Rtti(".?AVLatitudeFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct LatitudeFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C74
}

[Rtti(".?AVFogFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct FogFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C7C
}

[Rtti(".?AVShadowFilter@PostEffectController@GameManagerActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct ShadowFilter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7C84
}

// ============================================================================
// GameManagerActorSchedulerListener — Cutscene scheduler callback
//
// VTable: 0x00FB7B8C (13 virtual methods, 11 stubs)
// Ctor:   0x0061F9E0
// RTTI:   .?AVGameManagerActorSchedulerListener@...
//
// Inherits: RaptureActorSchedulerListenerBase (vt=0x00FB7ABC)
//           <- ISchedulerListener (vt=0x00FB7A84)
//
// Embedded at TargetActor+0x013C, BootupActor+0x013C.
// Only vt[5] (7B) and vt[11] (106B) are real implementations.
// ============================================================================

[Rtti(".?AVGameManagerActorSchedulerListener@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct GameManagerActorSchedulerListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB7B8C
}
