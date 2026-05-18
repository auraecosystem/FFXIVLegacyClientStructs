using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Lay.Stella.Resource;

[Rtti(".?AVLayoutResourceNodeFactory@Resource@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayoutResourceNodeFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A3124 (7 vfuncs)
}

[Rtti(".?AVLayResourceNode@Resource@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayResourceNode
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A31A4 (15 vfuncs)
}
