using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.CDevVfx
{
    namespace Qix
    {
        [Rtti(".?AVCDevActor@Qix@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevActor
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B7064 (26 vfuncs)
        }

        [Rtti(".?AVCDevContext@Qix@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevContext
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B78D4 (12 vfuncs)

            [Rtti(".?AVVfxSetupProjectionMappingListner@CDevContext@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct VfxSetupProjectionMappingListner
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B78C4 (3 vfuncs)
            }
        }

        [Rtti(".?AVCDevEffect@Qix@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevEffect
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B892C (82 vfuncs)
        }

        [Rtti(".?AVCDevGroupEffect@Qix@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevGroupEffect
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B8D8C (65 vfuncs)
        }

        [Rtti(".?AVCDevHandleAdapter@Qix@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevHandleAdapter
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B96BC (9 vfuncs)
        }

        [Rtti(".?AVCDevUnconformableEffect@Qix@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevUnconformableEffect
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B8484 (84 vfuncs)
        }

        [Rtti(".?AVCDevWorld@Qix@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevWorld
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B80AC (3 vfuncs)
        }

        namespace Factory
        {
            [Rtti(".?AVEffectFactory@Factory@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct EffectFactory
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B5DAC (3 vfuncs)
            }

            [Rtti(".?AVEffectResourceNodeFactory@Factory@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct EffectResourceNodeFactory
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00FE942C (7 vfuncs)
            }

            [Rtti(".?AVLeafinsResourceNodeFactory@Factory@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LeafinsResourceNodeFactory
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00FE93AC (7 vfuncs)
            }

            [Rtti(".?AVLeafResourceNodeFactory@Factory@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LeafResourceNodeFactory
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00FE93CC (7 vfuncs)
            }

            [Rtti(".?AVModelResourceNodeFactory@Factory@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ModelResourceNodeFactory
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00FE93EC (7 vfuncs)
            }

            [Rtti(".?AVTextureResourceNodeFactory@Factory@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct TextureResourceNodeFactory
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00FE940C (7 vfuncs)
            }
        }

        namespace Resource
        {
            [Rtti(".?AVCDevResourceManager@Resource@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct CDevResourceManager
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B968C (1 vfunc)
            }
        }

        namespace Sgnode
        {
            [Rtti(".?AVBaseResourceSgnode@Sgnode@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct BaseResourceSgnode
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B5264 (31 vfuncs)
            }

            [Rtti(".?AVEffectResourceSgnode@Sgnode@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct EffectResourceSgnode
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B7434 (31 vfuncs)
            }

            [Rtti(".?AVLeafinsResourceSgnode@Sgnode@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct LeafinsResourceSgnode
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B6C84 (38 vfuncs)
            }

            [Rtti(".?AVModelResourceSgnode@Sgnode@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ModelResourceSgnode
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B7C3C (31 vfuncs)
            }

            [Rtti(".?AVRootResourceSgnode@Sgnode@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct RootResourceSgnode
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B913C (31 vfuncs)
            }

            [Rtti(".?AVTextureResourceSgnode@Sgnode@Qix@CDevVfx@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct TextureResourceSgnode
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010B7F4C (31 vfuncs)
            }
        }
    }

    namespace Renderer
    {
        [Rtti(".?AVPixelShader@Renderer@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct PixelShader
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5B4C (3 vfuncs)
        }

        [Rtti(".?AVRenderState@Renderer@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RenderState
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5B98 (3 vfuncs)
        }

        [Rtti(".?AVRenderTexture@Renderer@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RenderTexture
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5BA8 (8 vfuncs)
        }

        [Rtti(".?AVShaderPatch@Renderer@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ShaderPatch
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5B68 (11 vfuncs)
        }

        [Rtti(".?AVVertexShader@Renderer@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexShader
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5B5C (2 vfuncs)
        }
    }

    namespace RenderInterface
    {
        [Rtti(".?AVBaseTexture@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BaseTexture
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5CCC (13 vfuncs)
        }

        [Rtti(".?AVCore@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Core
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B590C (127 vfuncs)
        }

        [Rtti(".?AVCubeTexture@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CubeTexture
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5D74 (13 vfuncs)
        }

        [Rtti(".?AVIndexBuffer@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IndexBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5DBC (12 vfuncs)
        }

        [Rtti(".?AVPixelShader@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct PixelShader
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5C90 (14 vfuncs)
        }

        [Rtti(".?AVSurface@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Surface
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5B0C (10 vfuncs)
        }

        [Rtti(".?AVTexture@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Texture
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5D04 (13 vfuncs)
        }

        [Rtti(".?AVVertexBuffer@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5DF0 (9 vfuncs)
        }

        [Rtti(".?AVVertexDeclaration@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexDeclaration
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5B38 (4 vfuncs)
        }

        [Rtti(".?AVVertexShader@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexShader
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5C54 (14 vfuncs)
        }

        [Rtti(".?AVVolumeTexture@RenderInterface@CDevVfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VolumeTexture
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5D3C (13 vfuncs)
        }
    }
}
