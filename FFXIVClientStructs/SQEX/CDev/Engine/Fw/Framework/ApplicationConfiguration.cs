using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Fw.Framework;

// SQEX::CDev::Engine::Fw::Framework::ApplicationConfiguration
// RTTI: .?AVApplicationConfiguration@Framework@Fw@Engine@CDev@SQEX@@
[Rtti(".?AVApplicationConfiguration@Framework@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)] // size TBD
public unsafe struct ApplicationConfiguration
{
    [FieldOffset(0x00)] public nint VTable;
    // Contains window handle, resolution, graphics config, etc.
}
