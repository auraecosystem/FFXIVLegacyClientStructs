using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Cut.Scheduler;

// SQEX::CDev::Engine::Cut::Scheduler — Cutscene system
// Complex timeline-based system with blocks, clips, actors, connections, conditions
// 40+ RTTI classes in this namespace alone

[Rtti(".?AVBlock@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct Block
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVClipBase@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct ClipBase
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVActorBase@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct ActorBase
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVConnection@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct Connection
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVCondition@Scheduler@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct Condition
{
    [FieldOffset(0x00)] public nint VTable;
}
