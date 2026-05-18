using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Log;

[Rtti(".?AVLogModuleInterface@Log@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LogModuleInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108D30 (10 vfuncs)
}

[Rtti(".?AVLogPage@Log@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LogPage
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C7E0 (3 vfuncs)
}

