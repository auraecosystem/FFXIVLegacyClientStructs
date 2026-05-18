using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Phieg.RigidDynamics
{
    [Rtti(".?AVBoxShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BoxShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A98C8 (3 vfuncs)
    }

    [Rtti(".?AVCapsuleShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CapsuleShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A98B8 (3 vfuncs)
    }

    [Rtti(".?AVConvexShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ConvexShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A9A54 (3 vfuncs)
    }

    [Rtti(".?AVCylinderShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CylinderShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A9910 (3 vfuncs)
    }

    [Rtti(".?AVEllipseShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct EllipseShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A9900 (3 vfuncs)
    }

    [Rtti(".?AVHemiSphereShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct HemiSphereShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A98E8 (3 vfuncs)
    }

    [Rtti(".?AVPlaneShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PlaneShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A9A08 (3 vfuncs)
    }

    [Rtti(".?AVRigidBody@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct RigidBody
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A9878 (1 vfuncs)
    }

    [Rtti(".?AVShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Shape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A9888 (3 vfuncs)
    }

    [Rtti(".?AVSphereShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct SphereShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A989C (5 vfuncs)
    }

    [Rtti(".?AV?$TDynamicPointerArray@VRigidBody@RigidDynamics@Phieg@Engine@CDev@SQEX@@@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TDynamicPointerArrayRigidBody
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109EAA4 (1 vfuncs)
    }

    [Rtti(".?AVTriangleMeshShape@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TriangleMeshShape
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A98D8 (3 vfuncs)
    }

    namespace Detail
    {
        [Rtti(".?AVChildSolveInstance@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ChildSolveInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA274 (19 vfuncs)
        }

        [Rtti(".?AVChildThread@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ChildThread
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA0C8 (2 vfuncs)
        }

        [Rtti(".?AVConvexBufferedProxy@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ConvexBufferedProxy
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA260 (4 vfuncs)
        }

        [Rtti(".?AVGeneralThreadMessage@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct GeneralThreadMessage
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA2D8 (13 vfuncs)
        }

        [Rtti(".?AVParentSolveInstance@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ParentSolveInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA16C (17 vfuncs)
        }

        [Rtti(".?AVParentThread@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ParentThread
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A9A70 (2 vfuncs)
        }

        [Rtti(".?AVSolveInstance@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SolveInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA124 (17 vfuncs)
        }

        [Rtti(".?AVTaskRunnable@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct TaskRunnable
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA0DC (17 vfuncs)
        }

        [Rtti(".?AVThreadMessage@Detail@RigidDynamics@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ThreadMessage
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA2C4 (4 vfuncs)
        }
    }
}
