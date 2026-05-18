using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Actor.System;

// ============================================================================
// Application::Scene::Actor::System::BootupActor
// Manages boot/login sequence: data center selection, character list, world entry.
//
// VTable: 0x00FB86C4 (164 virtual methods, 50 stubs)
// Ctor:   0x006132C0
// Size:   ~0x09C0 (estimated from field range +0x0000..+0x09B4)
// RTTI:   .?AVBootupActor@System@Actor@Scene@Application@@
//
// Inheritance chain (from RTTI CHD):
//   BootupActor
//     <- CDevActor
//       <- RaptureActor (vt=0x00FEA50C)
//         <- SQEX::CDev::Engine::Fw::SceneObject::Actor (vt=0x0109CA94, 89 vfuncs)
//           <- IActor, IReferenceResource, SceneObjectMemoryObject, NonCopyable
//
// 70 fields from ctor init. 16 embedded sub-objects.
// Nearly identical layout to TargetActor — shares the same base field structure,
// sub-object slots, and property array at +0x0914..+0x09B4.
//
// Key difference from TargetActor:
//   - Inherits through CDevActor (TargetActor does not)
//   - 164 vfuncs (4 more than TargetActor's 160)
//   - vt[0] = 0x006215E0 (own dtor, TargetActor = 0x00620EC0)
//   - vt[103] = 0x0061FF60 (7B, real) vs TargetActor = 0x00AB7340 (3B, stub)
//   - vt[141] = 0x006177D0 (54B) vs TargetActor = 0x00776340 (3B, stub)
//   - vt[157] = 0x00617070 (39B) vs TargetActor = 0x006131B0 (37B)
//   - vt[160..163] = 4 extra slots (all stubs/small)
//   - Has unique field at +0x00E4 (float, not present in TargetActor)
//
// String refs: same base set as TargetActor (Actor.cpp, EID_NAME, EID_BODY_DYN,
//              PriorityDatabase, CreateActorConstraint, CreateModel, LightSet)
// ============================================================================

[Rtti(".?AVBootupActor@System@Actor@Scene@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x09C0)]
public unsafe struct BootupActor
{
    // ======================== VTable & Base ========================
    [FieldOffset(0x0000)] public nint VTable; // 0x00FB86C4 (164 vfuncs)

    // Actor base region (from CDev::Engine::Fw::SceneObject::Actor → RaptureActor)
    [FieldOffset(0x0004)] public float BaseFieldA; // xmm0 init
    [FieldOffset(0x0008)] public float BaseFieldB; // xmm0 init
    [FieldOffset(0x000C)] public float BaseFieldC; // xmm0 init
    // +0x000F/+0x0010 NOT initialized by BootupActor (unlike TargetActor)

    // ======================== Transform ========================
    [FieldOffset(0x00D0)] public float TransformFloat; // xmm0 init
    [FieldOffset(0x00E4)] public float BootupSpecificFloat; // xmm0 init (unique to BootupActor)

    // ======================== Scheduler Listener ========================
    // Same embedded object as TargetActor
    // +0x013C: GameManagerActorSchedulerListener (vt=0x00FB7B8C, ctor=0x0061F9E0)
    [FieldOffset(0x013C)] public uint SchedulerListener; // ebx init
    [FieldOffset(0x0140)] public uint SubObject_0140; // ebx init
    // +0x0140: unknown (no vtable, ctor=0x007CCAF0) — shared with TargetActor
    // +0x0144: unknown (no vtable, ctor=0x0061FD20) — shared with TargetActor

    // ======================== Layout Sub-Objects ========================
    // +0x0160: unknown (no vtable, ctor=0x006125E0) — shared with TargetActor
    // +0x0164: unknown (no vtable, ctor=0x0060FA50) — shared with TargetActor
    // +0x0190: unknown (no vtable, ctor=0x0060FAB0) — shared with TargetActor

    [FieldOffset(0x0174)] public uint Field_0174; // eax

    // ======================== Resource Management ========================
    [FieldOffset(0x0184)] public uint ResourceA; // ecx
    [FieldOffset(0x018C)] public uint ResourceB; // eax
    [FieldOffset(0x01A8)] public uint Field_01A8; // eax

    // ======================== Timing / Animation ========================
    // +0x01B8: unknown (no vtable, ctor=0x0061FDD0) — shared with TargetActor
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
    // +0x0200: unknown (no vtable, ctor=0x0060FBC0) — shared with TargetActor
    // +0x0230: unknown (no vtable, ctor=0x0060FC00) — shared with TargetActor
    [FieldOffset(0x0230)] public float RenderFloat; // xmm0 init
    [FieldOffset(0x0240)] public byte RenderFlag; // init 0x00

    // +0x02B0: unknown (no vtable, ctor=0x0060FC20) — shared with TargetActor
    [FieldOffset(0x02AC)] public float VisualFloat; // xmm0 init

    // +0x0320: unknown (no vtable, ctor=0x0060FCA0) — shared with TargetActor
    // +0x0340: unknown (no vtable, ctor=0x00610200) — shared with TargetActor

    // ======================== Action / State ========================
    [FieldOffset(0x03E4)] public float ActionFloat; // xmm0 init
    [FieldOffset(0x03E8)] public uint ActionState; // eax
    [FieldOffset(0x03F0)] public uint ActionConfig; // eax
    [FieldOffset(0x0480)] public byte TaskFlag; // init 0x00

    // ======================== Layout Manager ========================
    // +0x0530: unknown (no vtable, ctor=0x0061D390) — shared with TargetActor
    // +0x0660: unknown (no vtable, ctor=0x0060FCF0) — shared with TargetActor
    // +0x06B0: unknown (no vtable, ctor=0x0060FD30) — shared with TargetActor
    // +0x06C4: unknown (no vtable, ctor=0x00612CD0) — shared with TargetActor

    // ======================== Task Configuration Array ========================
    // Identical to TargetActor. 37 consecutive dwords.
    [FieldOffset(0x0910)] public uint PropertyArrayBase; // edx
    [FieldOffset(0x0914)] public fixed uint PropertyArray[37]; // [0x0914..0x09B4]
}
