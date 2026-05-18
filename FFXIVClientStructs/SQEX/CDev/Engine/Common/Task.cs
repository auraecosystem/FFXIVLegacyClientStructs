using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Common.Task;

[Rtti(".?AVInstance@Task@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct Instance
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01093A00 (1 vfunc)
}

[Rtti(".?AVPerfInfo@Task@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct PerfInfo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01093734 (1 vfunc)
}

[Rtti(".?AVPerfInfo2@Task@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct PerfInfo2
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01093744 (1 vfunc)
}

[Rtti(".?AVPerformanceCollecter@Task@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct PerformanceCollecter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109373C (1 vfunc)
}

[Rtti(".?AVPerformanceCollecterManager@Task@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct PerformanceCollecterManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01093CD8 (1 vfunc)
}
