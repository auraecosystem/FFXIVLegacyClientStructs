using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Lay.Stella.External
{
    [Rtti(".?AVILayExternalManagerConnector@External@Stella@Lay@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ILayExternalManagerConnector
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A0250 (6 vfuncs)
    }

    [Rtti(".?AVILayExternalObjectManager@External@Stella@Lay@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ILayExternalObjectManager
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A8A94 (10 vfuncs)
    }

    [Rtti(".?AVLayExternalObjectManager@External@Stella@Lay@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LayExternalObjectManager
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A8AEC (1 vfuncs)
    }

    namespace Cut.Scheduler
    {
        [Rtti(".?AVILaySchedulerManager@Scheduler@Cut@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILaySchedulerManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109E840 (3 vfuncs)
        }

        [Rtti(".?AVILaySchedulerManipulator@Scheduler@Cut@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILaySchedulerManipulator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109F3CC (31 vfuncs)
        }
    }

    namespace Dw
    {
        [Rtti(".?AVILayDrawManager@Dw@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayDrawManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A03CC (12 vfuncs)
        }

        namespace DrawEnv
        {
            [Rtti(".?AVILayDrawEnvWindManipulator@DrawEnv@Dw@External@Stella@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ILayDrawEnvWindManipulator
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A1D48 (5 vfuncs)
            }

            [Rtti(".?AVILayoutDrawEnvContainer@DrawEnv@Dw@External@Stella@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ILayoutDrawEnvContainer
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109EBE0 (9 vfuncs)
            }

            [Rtti(".?AVILayoutDrawEnvObject@DrawEnv@Dw@External@Stella@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ILayoutDrawEnvObject
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109FC84 (44 vfuncs)
            }
        }
    }

    namespace Phieg
    {
        [Rtti(".?AVILayPhysicsManager@Phieg@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayPhysicsManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109EA00 (12 vfuncs)
        }

        [Rtti(".?AVRaycastResult@ILayPhysicsManager@Phieg@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayPhysicsManager_RaycastResult
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A85C4 (1 vfuncs)
        }

        [Rtti(".?AVILayRigidBodyCollisionListener@Phieg@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayRigidBodyCollisionListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A5088 (3 vfuncs)
        }

        [Rtti(".?AVILayRigidBodyManipulator@Phieg@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayRigidBodyManipulator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109F834 (45 vfuncs)
        }
    }

    namespace Sd
    {
        [Rtti(".?AVILaySoundManager@Sd@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILaySoundManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A00DC (23 vfuncs)
        }
    }

    namespace Vfx
    {
        [Rtti(".?AVILayEffectManager@Vfx@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayEffectManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A01F0 (5 vfuncs)
        }

        [Rtti(".?AVILayEffectManipulator@Vfx@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayEffectManipulator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A19FC (28 vfuncs)
        }

        [Rtti(".?AVILayEffectManipulatorFactory@Vfx@External@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayEffectManipulatorFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A0208 (2 vfuncs)
        }
    }
}
