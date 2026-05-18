using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Fw.SceneObject;

// SQEX::CDev::Engine::Fw::SceneObject::Actor
// Base class for all scene actors in Crystal Tools
// Vtable: 0x0109CA94 (89 virtual methods)
// Init:   0x00A60620
// RTTI:   .?AVActor@SceneObject@Fw@Engine@CDev@SQEX@@
//
// Actor uses ESI as this-ptr in ctor. Accesses [esi+0x48] for a sub-object pointer.
// Init sequence checks [esi+0x48]!=NULL, calls vt[0x34] (index 13), constructs
// sub-objects via Controller pattern.
//
// 89 virtual methods form the base for ALL game actors:
//   vt[0]  = dtor (per-class)
//   vt[1]  = 0x006207D0 (shared)
//   vt[2]  = 0x006204F0 (shared)
//   vt[3]  = 0x00620590 (shared)
//   vt[4]  = 0x00620640 (shared)
//   vt[5]  = 0x00620700 (shared)
//   vt[6]  = 0x00620880 (shared)
//   vt[7]  = per-class (init/update?)
//   vt[8]  = 0x00620940 (shared)
//   vt[9]  = 0x00621430 (shared)
//   vt[10] = 0x00621460 (shared)
//   vt[11] = per-class
//   vt[12] = 0x00776340 (shared across ALL actors)
//   vt[13] = 0x00A602A0 (shared across ALL actors)
[Rtti(".?AVActor@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct Actor
{
    [FieldOffset(0x00)] public nint VTable;

    // Known field from ctor analysis: sub-object pointer at +0x48
    [FieldOffset(0x48)] public nint SubObject;
}
