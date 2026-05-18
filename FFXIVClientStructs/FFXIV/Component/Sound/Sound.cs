using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Sound;

[Rtti(".?AVSoundCache@Sound@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SoundCache
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F670B8 (4 vfuncs)
}

[Rtti(".?AVSoundCacheSound@Sound@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SoundCacheSound
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F67124 (4 vfuncs)
}

[Rtti(".?AVSoundCacheStream@Sound@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SoundCacheStream
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F671A4 (4 vfuncs)
}

[Rtti(".?AVSoundModule@Sound@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SoundModule
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F67038 (10 vfuncs)
}

[Rtti(".?AVSoundModuleInterface@Sound@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SoundModuleInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F66FF8 (9 vfuncs)
}

