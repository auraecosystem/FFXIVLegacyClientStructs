using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Math;

// Crystal Tools Math subsystem
// Note: VectorA, MatrixA, and other math types have no vtable (POD types).

[Rtti(".?AVDelegateHolderBase@?$Delegate07@AAVVectorA@Math@Engine@CDev@SQEX@@@@Math@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DelegateHolderBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0105A880 (2 vfuncs)
}
