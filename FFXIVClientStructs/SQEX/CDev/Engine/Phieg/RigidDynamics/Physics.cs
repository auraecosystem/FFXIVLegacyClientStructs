using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Phieg.RigidDynamics;

// SQEX::CDev::Engine::Phieg — "Phieg" physics engine (SQEX custom, not Havok)
// Handles rigid body dynamics, collision shapes, cloth simulation

[Rtti(".?AVBoxShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct BoxShape
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVCapsuleShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CapsuleShape
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVConvexShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct ConvexShape
{
    [FieldOffset(0x00)] public nint VTable;
}
