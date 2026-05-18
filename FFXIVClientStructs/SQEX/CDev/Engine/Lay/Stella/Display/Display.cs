using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Lay.Stella.Display;

[Rtti(".?AVILayoutDisplayManager@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutDisplayManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109F16C (13 vfuncs)
}

[Rtti(".?AVILayoutDisplayUtils@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutDisplayUtils
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109F144 (9 vfuncs)
}

[Rtti(".?AVILayoutDrawable@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutDrawable
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBA38C (42 vfuncs)
}

[Rtti(".?AVILayoutDrawableFactory@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutDrawableFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F93158 (3 vfuncs)
}

[Rtti(".?AVILayoutInstanceObjectRenderer@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutInstanceObjectRenderer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109F1A4 (6 vfuncs)
}

[Rtti(".?AVILayoutRenderFrame@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutRenderFrame
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109F1C0 (6 vfuncs)
}

[Rtti(".?AVNullDisplayManager@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NullDisplayManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A865C (1 vfunc)
}

[Rtti(".?AVDummyDisplayUtils@NullDisplayManager@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NullDisplayManager_DummyDisplayUtils
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A8664 (9 vfuncs)
}

[Rtti(".?AVNullLayoutInstanceObjectRenderer@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NullLayoutInstanceObjectRenderer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109F1F8 (1 vfunc)
}

[Rtti(".?AVNullLayoutRenderFrame@Display@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NullLayoutRenderFrame
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109F21C (1 vfunc)
}
