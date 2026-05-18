using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Main;

[Rtti(".?AVMainModule@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MainModule
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F9142C (1 vfunc)
}

[Rtti(".?AVMainPacket@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MainPacket
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F90EF8 (1 vfunc)
}

[Rtti(".?AVQueue<MainPacket>@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct QueueMainPacket
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F90FDC (1 vfunc)
}

[Rtti(".?AVRaptureElement@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RaptureElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F91138 (14 vfuncs)
}

[Rtti(".?AVRaptureElementContainer@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RaptureElementContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F912E4 (81 vfuncs)
}

[Rtti(".?AVShellCommandContainer@Shell@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Shell_ShellCommandContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA5ECC (1 vfunc)
}

[Rtti(".?AVShellCommandModule@Shell@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Shell_ShellCommandModule
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA5EC4 (1 vfunc)
}

[Rtti(".?AVTestEvent@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TestEvent
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F90FE4 (2 vfuncs)
}

[Rtti(".?AVTestOsk@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TestOsk
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F90FF0 (7 vfuncs)
}

