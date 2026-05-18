using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Phieg.Controller
{
    [Rtti(".?AVCharacterProxy@Controller@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CharacterProxy
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A9444 (1 vfuncs)
    }

    [Rtti(".?AVDefaultIKRaycast@Controller@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DefaultIKRaycast
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A940C (2 vfuncs)
    }

    [Rtti(".?AVIJointObjectProxy@Controller@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IJointObjectProxy
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109DDAC (17 vfuncs)
    }

    [Rtti(".?AVIMeshProxy@Controller@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IMeshProxy
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109DDF4 (7 vfuncs)
    }

    [Rtti(".?AVPhysicsInstance@Controller@Phieg@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PhysicsInstance
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010A9048 (1 vfuncs)
    }

    namespace Clipping
    {
        [Rtti(".?AVClippingInstance@Clipping@Controller@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ClippingInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A9554 (14 vfuncs)
        }
    }

    namespace IK
    {
        [Rtti(".?AVIKInstance@IK@Controller@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IKInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A91B8 (14 vfuncs)
        }
    }

    namespace Misc
    {
        [Rtti(".?AVBaseInstance@Misc@Controller@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BaseInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A8FF0 (14 vfuncs)
        }

        [Rtti(".?AVChainInstance@Misc@Controller@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ChainInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A9664 (14 vfuncs)
        }
    }

    namespace Overlap
    {
        [Rtti(".?AVOverlapInstance@Overlap@Controller@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct OverlapInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A94C0 (14 vfuncs)
        }
    }

    namespace Ragdoll
    {
        [Rtti(".?AVRagdollInstance@Ragdoll@Controller@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RagdollInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A94FC (14 vfuncs)
        }
    }

    namespace StaticBody
    {
        [Rtti(".?AVStaticBodyInstance@StaticBody@Controller@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct StaticBodyInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A947C (14 vfuncs)
        }
    }

    namespace Wind
    {
        [Rtti(".?AVWindGroupInstance@Wind@Controller@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct WindGroupInstance
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A96A8 (14 vfuncs)
        }
    }
}
