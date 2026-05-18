using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Resource;

[Rtti(".?AVFileEvent@Resource@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FileEvent
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F930E8 (3 vfuncs)
}

[Rtti(".?AVFileThread@Resource@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FileThread
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108944 (4 vfuncs)
}

[Rtti(".?AVResourceEvent@Resource@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceEvent
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F670A8 (3 vfuncs)
}

[Rtti(".?AVResourceInterface@Resource@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C484 (14 vfuncs)
}

[Rtti(".?AVResourceModule@Resource@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceModule
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108C3C (11 vfuncs)
}

[Rtti(".?AVResourceModuleBase@Resource@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceModuleBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108B3C (11 vfuncs)
}

[Rtti(".?AVResourceModuleInterface@Resource@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceModuleInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108B10 (10 vfuncs)
}

