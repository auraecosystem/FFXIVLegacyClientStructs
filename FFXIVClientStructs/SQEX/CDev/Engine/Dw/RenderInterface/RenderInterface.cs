using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Dw.RenderInterface
{
    // SQEX::CDev::Engine::Dw::RenderInterface
    // GPU resource handles — textures, surfaces, shaders

    /// <summary>Inherits BaseTexture.</summary>
    [Rtti(".?AVCubeTexture@RenderInterface@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CubeTexture
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0105D5AC (3 vfuncs)
    }

    [Rtti(".?AV?$ShaderHandle@VPixelShader@Renderer@Dw@Engine@CDev@SQEX@@@RenderInterface@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ShaderHandlePixelShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F5B6C (2 vfuncs)
    }

    [Rtti(".?AV?$ShaderHandle@VVertexShader@Renderer@Dw@Engine@CDev@SQEX@@@RenderInterface@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ShaderHandleVertexShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F5B60 (2 vfuncs)
    }

    [Rtti(".?AVSurface@RenderInterface@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Surface
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0113C388 (3 vfuncs)
    }

    namespace D3d9
    {
        // SQEX::CDev::Engine::Dw::RenderInterface::D3d9

        [Rtti(".?AV?$Surface@VSurfaceImp@D3d9@RenderInterface@Dw@Engine@CDev@SQEX@@@D3d9@RenderInterface@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SurfaceTemplate
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113C378 (3 vfuncs)
        }

        [Rtti(".?AV?$Texture@VTextureImp@D3d9@RenderInterface@Dw@Engine@CDev@SQEX@@@D3d9@RenderInterface@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct TextureTemplate
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0105D59C (3 vfuncs)
        }
    }
}
