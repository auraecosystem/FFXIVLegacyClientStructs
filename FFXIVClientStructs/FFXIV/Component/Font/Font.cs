using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Font;

[Rtti(".?AVBitmapFont@Font@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BitmapFont
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C194 (19 vfuncs)
}

[Rtti(".?AVFontDrawInterface@Font@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FontDrawInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110BFE8 (9 vfuncs)
}

[Rtti(".?AVFontInterface@Font@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FontInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110BFA4 (16 vfuncs)
}

[Rtti(".?AVFontModuleInterface@Font@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FontModuleInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108ACC (7 vfuncs)
}

[Rtti(".?AVOsFont@Font@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct OsFont
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C434 (19 vfuncs)
}

