using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Vfx.Qix
{
    [Rtti(".?AVBaseActor@Qix@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BaseActor
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010BE754 (26 vfuncs)
    }

    [Rtti(".?AVBaseUpdatableEffect@Qix@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BaseUpdatableEffect
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010BDFCC (81 vfuncs)
    }

    [Rtti(".?AVContext@Qix@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Context
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010BBBD4 (12 vfuncs)
    }

    [Rtti(".?AVEffectCullingObject@Qix@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct EffectCullingObject
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010CAFA0 (7 vfuncs)
    }

    [Rtti(".?AVGroupVfxActorListener@GroupEffect@Qix@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct GroupEffect_GroupVfxActorListener
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010C4F40 (2 vfuncs)
    }

    [Rtti(".?AVLeaf@Qix@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Leaf
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010C3434 (6 vfuncs)
    }

    [Rtti(".?AVManager@Qix@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Manager
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010BB628 (4 vfuncs)
    }

    [Rtti(".?AVSprite@Qix@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Sprite
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010C90EC (1 vfunc)
    }

    namespace Data
    {
        [Rtti(".?AVLeaf@Data@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Leaf
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C8EE4 (25 vfuncs)
        }

        [Rtti(".?AVLeafins@Data@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Leafins
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CD7CC (25 vfuncs)
        }
    }

    namespace Debug
    {
        [Rtti(".?AVStateManager@Debug@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct StateManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010BCB64 (6 vfuncs)
        }

        namespace Player
        {
            [Rtti(".?AVVeffbinPlayer@Player@Debug@Qix@Vfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct VeffbinPlayer
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010C6920 (6 vfuncs)
            }
        }
    }

    namespace Draw
    {
        [Rtti(".?AVEffectDrawableObject@Draw@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct EffectDrawableObject
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CA62C (25 vfuncs)
        }

        [Rtti(".?AVScreenManager@Draw@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ScreenManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010BEE8C (7 vfuncs)
        }
    }

    namespace ExResource
    {
        [Rtti(".?AVExBaseResource@ExResource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ExBaseResource
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C0AEC (43 vfuncs)
        }

        [Rtti(".?AVExEffectResource@ExResource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ExEffectResource
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C318C (43 vfuncs)
        }

        [Rtti(".?AVExLeafinsResource@ExResource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ExLeafinsResource
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C2794 (51 vfuncs)
        }

        [Rtti(".?AVExModelResource@ExResource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ExModelResource
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C38E4 (43 vfuncs)
        }

        [Rtti(".?AVExResourceManager@ExResource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ExResourceManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C8170 (6 vfuncs)
        }

        [Rtti(".?AVExTextureResource@ExResource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ExTextureResource
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C412C (43 vfuncs)
        }
    }

    namespace Graph
    {
        [Rtti(".?AVIGenesisBuffer@Graph@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IGenesisBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D0E54 (14 vfuncs)
        }

        [Rtti(".?AVRingGenesisBuffer@Graph@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RingGenesisBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CF028 (14 vfuncs)
        }

        [Rtti(".?AVSureGenesisBuffer@Graph@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SureGenesisBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CEF54 (14 vfuncs)
        }
    }

    namespace Map
    {
        [Rtti(".?AVControlModuleMap@Map@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ControlModuleMap
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C8848 (12 vfuncs)
        }
    }

    namespace Node
    {
        [Rtti(".?AVEffectDrawTag@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct EffectDrawTag
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D05AC (13 vfuncs)
        }

        [Rtti(".?AVProjectionMappingCaster@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ProjectionMappingCaster
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C7E2C (3 vfuncs)
        }

        [Rtti(".?AVProjectionMappingCasterDrawTag@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ProjectionMappingCasterDrawTag
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C7DC4 (12 vfuncs)
        }

        [Rtti(".?AVProjectionMappingCollector@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ProjectionMappingCollector
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C7E3C (1 vfunc)
        }

        [Rtti(".?AVProjectionMappingReceiverDrawTag@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ProjectionMappingReceiverDrawTag
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C7DF8 (12 vfuncs)
        }

        [Rtti(".?AVQixDrawableObject@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct QixDrawableObject
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CE79C (25 vfuncs)
        }

        [Rtti(".?AVQixDrawTag@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct QixDrawTag
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D0B14 (14 vfuncs)
        }

        [Rtti(".?AVQixSpliteDrawableObject@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct QixSpliteDrawableObject
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CFF1C (21 vfuncs)
        }

        [Rtti(".?AVQixSpliteDrawTag@Node@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct QixSpliteDrawTag
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CFE8C (12 vfuncs)
        }
    }

    namespace Pool
    {
        [Rtti(".?AVUnitInstancePool@Pool@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct UnitInstancePool
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CED6C (2 vfuncs)
        }
    }

    namespace Resource
    {
        [Rtti(".?AVBaseResource@Resource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BaseResource
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D0904 (4 vfuncs)
        }

        [Rtti(".?AVModelTextureReplacementInfo@Resource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ModelTextureReplacementInfo
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CE064 (1 vfunc)
        }

        [Rtti(".?AVQixDummyModel@Resource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct QixDummyModel
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CDDD4 (44 vfuncs)
        }

        [Rtti(".?AVQixDummyTexture@Resource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct QixDummyTexture
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CE43C (6 vfuncs)
        }

        [Rtti(".?AVQixModel@Resource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct QixModel
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CE074 (44 vfuncs)

            [Rtti(".?AVTextureReplacementInfo@QixModel@Resource@Qix@Vfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct TextureReplacementInfo
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010CE06C (1 vfunc)
            }
        }

        [Rtti(".?AVQixTexture@Resource@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct QixTexture
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CE2F0 (6 vfuncs)
        }

        namespace Shader
        {
            [Rtti(".?AVShaderManager@Shader@Resource@Qix@Vfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ShaderManager
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010C0724 (1 vfunc)
            }
        }
    }

    namespace Thread
    {
        [Rtti(".?AVEffectThread@Thread@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct EffectThread
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010C7F88 (3 vfuncs)
        }

        [Rtti(".?AVThreadManager@Thread@Qix@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ThreadManager
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010BE8EC (1 vfunc)
        }
    }
}
