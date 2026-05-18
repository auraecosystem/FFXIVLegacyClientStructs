using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Fw.Framework;

// Crystal Tools Fw::Framework — All manager/configuration types within the
// Framework subsystem of Fw. Includes graphics, draw, physics, sound,
// scheduler, memory compaction, and application configuration.

// Inherits: Memory::Object + IApplicationConfiguration
[Rtti(".?AVApplicationConfiguration@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)]
public unsafe struct ApplicationConfiguration
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109BE9C (17 vfuncs)
}

// Inherits: Memory::Object
[Rtti(".?AVFrameworkDrawManager@Draw@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct FrameworkDrawManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109BA7C (9 vfuncs)
}

// Inherits: Memory::Object
[Rtti(".?AVGraphicsManager@Graphics@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct GraphicsManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109AE70 (4 vfuncs)
}

[Rtti(".?AVMayaGrid@Graphics@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct MayaGrid
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109B894 (1 vfunc)
}

[Rtti(".?AVGrid@MayaGrid@Graphics@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct MayaGridGrid
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109B88C (1 vfunc)
}

// Inherits: Memory::Object
[Rtti(".?AVInitialConfiguration@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct InitialConfiguration
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F54A1C (1 vfunc)
}

// Inherits: Memory::Object
[Rtti(".?AVCompactionManager@Memory@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CompactionManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109BCE8 (1 vfunc)
}

// Inherits: Memory::Object
[Rtti(".?AVPhysicsManager@Physics@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct PhysicsManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109BDCC (1 vfunc)
}

[Rtti(".?AVPhysicsRenderer@PhysicsManager@Physics@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct PhysicsRenderer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109BE04 (19 vfuncs)
}

[Rtti(".?AVQixManager@Qix@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct QixManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109B254 (4 vfuncs)
}

// Inherits: Memory::Object
[Rtti(".?AVSchedulerManager@Scheduler@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct SchedulerManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBDF1C (7 vfuncs)
}

// Inherits: Memory::Object
[Rtti(".?AVSoundManager@Sound@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct SoundManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109BA48 (1 vfunc)
}
