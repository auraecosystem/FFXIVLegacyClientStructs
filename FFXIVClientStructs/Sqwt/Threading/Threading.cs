using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Threading;

// ============================================================================
// Sqwt::Threading — Threading primitives for the UI framework
//
// Mutex for synchronization, Thread wraps Sqex::Thread, Timer for periodic
// callbacks. ParameterizedThreadStartBase is the delegate type for thread
// entry points (used by XamlReader for async XAML parsing).
// ============================================================================

[Rtti(".?AVMutex@Threading@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct Mutex
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01068494 (1 vfunc)
}

[Rtti(".?AVThread@Threading@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct Thread
{
    // Inherits: Sqex::Thread → Sqex::Misc::NonCopyable
    [FieldOffset(0x0000)] public nint VTable; // 0x010830F8 (4 vfuncs)
}

[Rtti(".?AVTimer@Threading@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct Timer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01077208 (1 vfunc)
}

[Rtti(".?AVParameterizedThreadStartBase@Threading@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe struct ParameterizedThreadStartBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010712C0 (2 vfuncs)
}
