using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Lay.Default.External
{
    [Rtti(".?AVLayExternalManagerConnector@External@Default@Lay@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LayExternalManagerConnector
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A026C (6 vfuncs)
    }

    namespace Cut.Scheduler
    {
        [Rtti(".?AVLayCutCharacterListener@Listener@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayCutCharacterListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109E774 (45 vfuncs)
        }

        [Rtti(".?AVLayScheduler@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayScheduler
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A0464 (23 vfuncs)
        }

        [Rtti(".?AVLaySchedulerFactory@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LaySchedulerFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109F814 (4 vfuncs)
        }

        [Rtti(".?AVLaySchedulerManager@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LaySchedulerManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109E860 (12 vfuncs)
        }

        [Rtti(".?AVLaySchedulerManipulator@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LaySchedulerManipulator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109F504 (2 vfuncs)
        }

        namespace Actor
        {
            [Rtti(".?AVLaySchedulerSystemActor@Actor@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LaySchedulerSystemActor
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109F79C (26 vfuncs)
            }

            [Rtti(".?AVLaySchedulerUnitActor@Actor@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LaySchedulerUnitActor
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109F714 (27 vfuncs)
            }

            [Rtti(".?AVLaySchedulerUnitMemberActor@Actor@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LaySchedulerUnitMemberActor
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109F674 (27 vfuncs)
            }
        }

        namespace Clip
        {
            [Rtti(".?AVLaySchedulerClipBase@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LaySchedulerClipBase
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x01038018 (1 vfuncs)
            }

            [Rtti(".?AVLayAnimationClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayAnimationClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A0C5C (42 vfuncs)
            }

            [Rtti(".?AVLayCollisionOnOffClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayCollisionOnOffClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A0654 (42 vfuncs)
            }

            [Rtti(".?AVLayAmbientLightClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayAmbientLightClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A13FC (45 vfuncs)
            }

            [Rtti(".?AVLayDirectionalLightClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayDirectionalLightClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A131C (45 vfuncs)
            }

            [Rtti(".?AVLayEnvMapClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayEnvMapClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A107C (42 vfuncs)
            }

            [Rtti(".?AVLayFogParamClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayFogParamClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A0E34 (42 vfuncs)
            }

            [Rtti(".?AVLayGetNumberClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayGetNumberClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A18C4 (44 vfuncs)
            }

            [Rtti(".?AVLayMovePosClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayMovePosClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A1684 (42 vfuncs)
            }

            [Rtti(".?AVLayPointLightClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayPointLightClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A1234 (45 vfuncs)
            }

            [Rtti(".?AVLayRandomClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayRandomClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A1804 (42 vfuncs)
            }

            [Rtti(".?AVLaySEClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LaySEClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A0A5C (42 vfuncs)
            }

            [Rtti(".?AVLaySetPosClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LaySetPosClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A15B4 (42 vfuncs)
            }

            [Rtti(".?AVLayShowHideClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayShowHideClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A1744 (42 vfuncs)
            }

            [Rtti(".?AVLaySpotLightClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LaySpotLightClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A1154 (45 vfuncs)
            }

            [Rtti(".?AVLayTransformClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayTransformClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A14DC (44 vfuncs)
            }

            [Rtti(".?AVLayVFXClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayVFXClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A0834 (42 vfuncs)
            }

            [Rtti(".?AVLayWindParamClip@Clip@Scheduler@Cut@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayWindParamClip
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A0D64 (42 vfuncs)
            }
        }
    }

    namespace Dw
    {
        [Rtti(".?AVLayDefaultDisplayManager@Dw@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayDefaultDisplayManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109F3AC (1 vfuncs)
        }

        [Rtti(".?AVLayDefaultLayoutDisplayUtils@Dw@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayDefaultLayoutDisplayUtils
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109F224 (9 vfuncs)
        }

        [Rtti(".?AVLayDefaultModelObject@Dw@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayDefaultModelObject
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109EFF8 (3 vfuncs)
        }

        [Rtti(".?AVLayDefaultModelObjectFactory@Dw@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayDefaultModelObjectFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109AFB4 (1 vfuncs)
        }

        [Rtti(".?AVLayDrawManager@Dw@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayDrawManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A043C (1 vfuncs)
        }

        namespace DrawEnv
        {
            [Rtti(".?AVLayoutDrawEnvContainer@DrawEnv@Dw@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayoutDrawEnvContainer
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109EC78 (1 vfuncs)
            }

            [Rtti(".?AVLayoutDrawEnvObject@DrawEnv@Dw@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayoutDrawEnvObject
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109FDF8 (2 vfuncs)
            }

            [Rtti(".?AVLayDrawEnvWindManipulator@DrawEnv@Dw@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayDrawEnvWindManipulator
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A1D78 (1 vfuncs)
            }
        }
    }

    namespace Phieg
    {
        [Rtti(".?AVLayPhysicsManager@Phieg@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayPhysicsManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109EA70 (1 vfuncs)
        }

        [Rtti(".?AVLayRigidBodyManipulator@Phieg@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayRigidBodyManipulator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109FA3C (2 vfuncs)
        }

        namespace CollisionUtils
        {
            [Rtti(".?AVILayPhiegRigidBodyVisitor@CollisionUtils@Phieg@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ILayPhiegRigidBodyVisitor
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109EA84 (3 vfuncs)
            }

            [Rtti(".?AVLayPhiegInstObjCollectVisitorDistAscend@CollisionUtils@Phieg@External@Default@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LayPhiegInstObjCollectVisitorDistAscend
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109FB38 (1 vfuncs)
            }
        }
    }

    namespace Sd
    {
        [Rtti(".?AVLaySoundManager@Sd@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LaySoundManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A013C (23 vfuncs)
        }
    }

    namespace Vfx
    {
        [Rtti(".?AVLayEffectManager@Vfx@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayEffectManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A022C (1 vfuncs)
        }

        [Rtti(".?AVLayEffectManipulator@Vfx@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayEffectManipulator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A1B30 (1 vfuncs)
        }

        [Rtti(".?AVLayEffectManipulatorLeaf@LayEffectManipulator@Vfx@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LayEffectManipulator_LayEffectManipulatorLeaf
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A1A70 (10 vfuncs)
        }

        [Rtti(".?AV_DefaultLayEffectManipulatorFactory@Vfx@External@Default@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DefaultLayEffectManipulatorFactory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A0240 (1 vfuncs)
        }
    }
}
