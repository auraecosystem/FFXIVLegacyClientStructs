using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Media.Player;

// Crystal Tools Media::Player — Video/media playback subsystem

[Rtti(".?AVIPlayer@Player@Media@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IPlayer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113C2C4 (20 vfuncs)
}

[Rtti(".?AVIPlayerFactory@Player@Media@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IPlayerFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110DEEC (2 vfuncs)
}

[Rtti(".?AVTextureRenderer@Win@Detail@Player@Media@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct TextureRenderer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113CC1C (8 vfuncs)
}

// Inherits: IPlayerFactory
[Rtti(".?AVDefaultPlayerFactory@Win@Player@Media@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct DefaultPlayerFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110DEF8 (2 vfuncs)
}

// 0Media::Win::Player — platform-specific player implementation
[Rtti(".?AVPlayer@Win@0Media@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct WinPlayer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113C39C (19 vfuncs)
}
