using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Common.Timer;

// Inherits: Memory::Object
[Rtti(".?AVTimerCallback@Timer@Common@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct TimerCallback
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01133A00 (1 vfunc)
}
