using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Memory;

// SQEX::CDev::Engine::Memory — Custom memory management
// Engine uses custom allocators throughout — not standard CRT heap

[Rtti(".?AVAllocatable@Memory@Base@Phieg@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct Allocatable
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVCompactionManager@Memory@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CompactionManager
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVComplexLink@Memory@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct ComplexLink
{
    [FieldOffset(0x00)] public nint VTable;
}
