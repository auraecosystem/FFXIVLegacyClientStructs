using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Vfx.Qix;

// SQEX::CDev::Engine::Vfx::Qix — Visual effects engine
// "Qix" is the internal name for the VFX subsystem

[Rtti(".?AVBaseActor@Qix@Vfx@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct BaseActor
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVContext@Qix@Vfx@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct Context
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVBaseUpdatableEffect@Qix@Vfx@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct BaseUpdatableEffect
{
    [FieldOffset(0x00)] public nint VTable;
}
