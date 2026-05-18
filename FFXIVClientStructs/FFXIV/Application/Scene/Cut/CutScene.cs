using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Scene.Cut
{
    [Rtti(".?AVCRaptureInquiryGameActor@Cut@Scene@Application@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CRaptureInquiryGameActor
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x00FBB26C (2 vfuncs)
    }

    [Rtti(".?AVInquiryPackResource@Cut@Scene@Application@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct InquiryPackResource
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x00FBB24C (4 vfuncs)
    }

    namespace Scheduler
    {
        [Rtti(".?AVCDevSchedulerManager@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevSchedulerManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBEAF0 (7 vfuncs)
        }

        [Rtti(".?AVCutSceneCreator@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSceneCreator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE478 (1 vfuncs)
        }

        [Rtti(".?AVCutSceneManager@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSceneManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBEB1C (1 vfuncs)
        }

        [Rtti(".?AVCutSceneObjectContainer@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSceneObjectContainer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBEB10 (2 vfuncs)
        }

        [Rtti(".?AVCutSceneObjectContainerSchedulerListener@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSceneObjectContainerSchedulerListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBDF70 (13 vfuncs)
        }

        [Rtti(".?AVCutSceneObjectController@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSceneObjectController
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE480 (1 vfuncs)
        }

        [Rtti(".?AVCutSceneObjectControllerSchedulerListener@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSceneObjectControllerSchedulerListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBDF3C (12 vfuncs)
        }

        [Rtti(".?AVICutSceneObjectContainer@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ICutSceneObjectContainer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBDFA8 (2 vfuncs)
        }

        [Rtti(".?AVRaptureProxyActor@Scheduler@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureProxyActor
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FB94E4 (35 vfuncs)
        }
    }

    namespace Listeners
    {
        [Rtti(".?AVRaptureClipListenerHolder@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureClipListenerHolder
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBEAE8 (1 vfuncs)
        }

        [Rtti(".?AVRaptureCutCameraListener@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureCutCameraListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01037A2C (19 vfuncs)
        }

        [Rtti(".?AVRaptureCutCharacterListener@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureCutCharacterListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE8BC (45 vfuncs)
        }

        [Rtti(".?AVRaptureCutLightEnvListener@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureCutLightEnvListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBEA98 (4 vfuncs)
        }

        [Rtti(".?AVRaptureCutLightListener@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureCutLightListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBEA54 (16 vfuncs)
        }

        [Rtti(".?AVRaptureCutPostEffectListener@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureCutPostEffectListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE974 (34 vfuncs)
        }

        [Rtti(".?AVRaptureCutResourceListener@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureCutResourceListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBEA34 (6 vfuncs)
        }

        [Rtti(".?AVRaptureCutScheduleListener@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureCutScheduleListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBEA00 (12 vfuncs)
        }

        [Rtti(".?AVRaptureListenerInstances@Listeners@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureListenerInstances
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE8AC (2 vfuncs)
        }
    }

    namespace Register
    {
        [Rtti(".?AVBaseRaptureParameter@Register@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BaseRaptureParameter
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FE7EA4 (1 vfuncs)
        }

        [Rtti(".?AVFindVins@Register@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct FindVins
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0105E23C (11 vfuncs)
        }

        namespace Listener
        {
            [Rtti(".?AVRaptureMoveRegisterListener@Listener@Register@Cut@Scene@Application@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct RaptureMoveRegisterListener
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00FF53C8 (12 vfuncs)
            }

            [Rtti(".?AVRaptureMoveRegisterScheduleControllerListener@Listener@Register@Cut@Scene@Application@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct RaptureMoveRegisterScheduleControllerListener
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00FF53FC (6 vfuncs)
            }
        }
    }

    namespace CutScenePlayer
    {
        [Rtti(".?AVCutScenePlayerControl@CutScenePlayer@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutScenePlayerControl
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FEF2B0 (12 vfuncs)
        }

        [Rtti(".?AVICutScenePlayerControl@CutScenePlayer@Cut@Scene@Application@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ICutScenePlayerControl
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FEF27C (12 vfuncs)
        }
    }
}
