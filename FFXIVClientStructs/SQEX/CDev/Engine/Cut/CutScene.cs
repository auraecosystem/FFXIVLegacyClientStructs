using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Cut
{
    [Rtti(".?AVCutScenePlayer@0Cut@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CutScenePlayer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01093F08 (1 vfunc)

        [Rtti(".?AVCutSceneItemObject@CutScenePlayer@1Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSceneItemObject
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01093F00 (1 vfunc)
        }

        [Rtti(".?AVCutSceneObject@CutScenePlayer@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSceneObject
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010942E4 (69 vfuncs)
        }
    }

    namespace Listeners
    {
        [Rtti(".?AVCutBGListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutBGListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE690 (7 vfuncs)
        }

        [Rtti(".?AVCutCameraListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutCameraListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE6B4 (19 vfuncs)
        }

        [Rtti(".?AVCutDrawEnvListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutDrawEnvListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE704 (5 vfuncs)
        }

        [Rtti(".?AVCutEffectListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutEffectListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE71C (12 vfuncs)
        }

        [Rtti(".?AVCutLightEnvListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutLightEnvListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE750 (4 vfuncs)
        }

        [Rtti(".?AVCutLightListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutLightListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE764 (16 vfuncs)
        }

        [Rtti(".?AVCutMotionListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutMotionListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE7DC (15 vfuncs)
        }

        [Rtti(".?AVCutPackListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutPackListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE854 (7 vfuncs)
        }

        [Rtti(".?AVCutResourceListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutResourceListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE874 (6 vfuncs)
        }

        [Rtti(".?AVCutScheduleListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutScheduleListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE7A8 (12 vfuncs)
        }

        [Rtti(".?AVCutSoundListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CutSoundListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE81C (13 vfuncs)
        }

        [Rtti(".?AVListenerInstances@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ListenerInstances
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FBE488 (2 vfuncs)
        }

        [Rtti(".?AVMccListener@Listeners@Cut@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct MccListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01094FFC (4 vfuncs)
        }
    }
}
