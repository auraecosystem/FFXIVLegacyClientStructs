using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Sd.Whiz;

[Rtti(".?AVIWhizManager@Whiz@Sd@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IWhizManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113D3A8 (11 vfuncs)
}

[Rtti(".?AVWhizManager@Whiz@Sd@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WhizManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113D3D8 (11 vfuncs)
}

[Rtti(".?AVWhizObject@Whiz@Sd@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WhizObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113D460 (1 vfunc)
}
