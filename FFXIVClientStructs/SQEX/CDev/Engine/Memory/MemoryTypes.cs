using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Memory;

// Crystal Tools Memory subsystem — Custom allocators, heap management,
// and the Alternative memory system with Block/Space/Handle abstractions.

[Rtti(".?AVIModule@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IModule
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56570 (11 vfuncs)
}

[Rtti(".?AVIAllocator@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct IAllocator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109D02C (4 vfuncs)
}

// Inherits: IModule
[Rtti(".?AVSystemHeap@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct SystemHeap
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56600 (11 vfuncs)
}

// Inherits: IModule
[Rtti(".?AVComplexLink@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct ComplexLink
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56630 (11 vfuncs)
}

// --- Alternative sub-namespace ---

[Rtti(".?AVIBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct AlternativeIBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56740 (3 vfuncs)
}

[Rtti(".?AVIHandle@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct AlternativeIHandle
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56750 (13 vfuncs)
}

[Rtti(".?AVIHandleListener@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct AlternativeIHandleListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56CCC (3 vfuncs)
}

// IDebugBlock, IDebugSpace also exist in Alternative but are debug-only variants
// IDebugBlock: vt=0x00F56788 (10 vfuncs), IDebugSpace: vt=0x00F567B4 (3 vfuncs)

[Rtti(".?AVISpace@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct AlternativeISpace
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F566FC (16 vfuncs)
}

[Rtti(".?AVLink@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AlternativeLink
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F567C4 (2 vfuncs)
}

// Inherits: IHandle + IBlock + Link
[Rtti(".?AVHandle@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct AlternativeHandle
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A7E38 (2 vfuncs)
}

[Rtti(".?AVFixedAllocatorCompound@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct AlternativeFixedAllocatorCompound
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F54FBC (1 vfunc)
}

[Rtti(".?AVSeparateHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AlternativeSeparateHeapBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56818 (2 vfuncs)
}

// Inherits: ISpace
[Rtti(".?AVSeparateHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct AlternativeSeparateHeapSpace
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56834 (16 vfuncs)
}

[Rtti(".?AVRemovableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AlternativeRemovableHeapBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56DC8 (2 vfuncs)
}

// Inherits: ISpace
[Rtti(".?AVRemovableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct AlternativeRemovableHeapSpace
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56D3C (16 vfuncs)
}

[Rtti(".?AVReceivableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AlternativeReceivableHeapBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56E70 (2 vfuncs)
}

// Inherits: ISpace
[Rtti(".?AVReceivableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct AlternativeReceivableHeapSpace
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F56ED4 (16 vfuncs)
}

[Rtti(".?AVSystemHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AlternativeSystemHeapBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F5700C (2 vfuncs)
}

// Inherits: ISpace
[Rtti(".?AVSystemHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct AlternativeSystemHeapSpace
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F5701C (16 vfuncs)
}
