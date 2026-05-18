using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Dw.Renderer
{
    // SQEX::CDev::Engine::Dw::Renderer (Crystal Tools rendering subsystem)
    // Handles all GPU rendering: shaders, textures, materials, post-effects,
    // culling, shadows, lighting, PRT, mesh, models, wind
    //
    // Author: Yokimitsuro

    // ──────────────────────────────────────────────
    // Interfaces
    // ──────────────────────────────────────────────

    [Rtti(".?AVIRenderTarget@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IRenderTarget
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2EE8 (6 vfuncs)
    }

    [Rtti(".?AVIScreenFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IScreenFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F405C (3 vfuncs)
    }

    [Rtti(".?AV?$IShaderDriver@VPixelShader@Renderer@Dw@Engine@CDev@SQEX@@@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IShaderDriverPixelShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D3B9C (4 vfuncs)
    }

    [Rtti(".?AV?$IShaderDriver@VVertexShader@Renderer@Dw@Engine@CDev@SQEX@@@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IShaderDriverVertexShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D3B88 (4 vfuncs)
    }

    [Rtti(".?AVILightContainer@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ILightContainer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D62F4 (5 vfuncs)
    }

    [Rtti(".?AVLinkTag@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LinkTag
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D45F8 (2 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Managers
    // ──────────────────────────────────────────────

    [Rtti(".?AVRendererManager@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct RendererManager
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2FE4 (1 vfuncs)
    }

    [Rtti(".?AVShaderFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ShaderFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D467C (1 vfuncs)
    }

    [Rtti(".?AV?$ShaderManager@VPixelShader@Renderer@Dw@Engine@CDev@SQEX@@@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ShaderManagerPixelShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D465C (1 vfuncs)
    }

    [Rtti(".?AV?$ShaderManager@VVertexShader@Renderer@Dw@Engine@CDev@SQEX@@@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ShaderManagerVertexShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D4654 (1 vfuncs)
    }

    [Rtti(".?AVMaterialFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MaterialFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FAED4 (1 vfuncs)
    }

    [Rtti(".?AVCDevMaterialFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CDevMaterialFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FAF5C (1 vfuncs)
    }

    [Rtti(".?AVTextureFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TextureFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7B50 (3 vfuncs)
    }

    [Rtti(".?AVTextureFactoryDDS@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TextureFactoryDDS
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7B60 (3 vfuncs)
    }

    [Rtti(".?AVMeshFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MeshFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FAA68 (2 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Shaders
    // ──────────────────────────────────────────────

    [Rtti(".?AVPixelShader@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PixelShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F5B84 (2 vfuncs)
    }

    [Rtti(".?AVVertexShader@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VertexShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F5B78 (2 vfuncs)
    }

    [Rtti(".?AV?$IdenticalShaderSet@VPixelShader@Renderer@Dw@Engine@CDev@SQEX@@@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IdenticalShaderSetPixelShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D4670 (2 vfuncs)
    }

    [Rtti(".?AV?$IdenticalShaderSet@VVertexShader@Renderer@Dw@Engine@CDev@SQEX@@@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IdenticalShaderSetVertexShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D4664 (2 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Scene Objects
    // ──────────────────────────────────────────────

    [Rtti(".?AVCullingObject@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CullingObject
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F5C0C (7 vfuncs)
    }

    [Rtti(".?AVDrawableNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DrawableNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D4CA4 (21 vfuncs)
    }

    [Rtti(".?AVShapeWeight@DrawableObject@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DrawableObject_ShapeWeight
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D63AC (1 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Draw Tags
    // ──────────────────────────────────────────────

    [Rtti(".?AVDrawTag@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DrawTag
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010C7D00 (12 vfuncs)
    }

    [Rtti(".?AVDepthDrawTag@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DepthDrawTag
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D4BC4 (12 vfuncs)
    }

    [Rtti(".?AVMeshDrawTag@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MeshDrawTag
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7A04 (12 vfuncs)
    }

    [Rtti(".?AVProjectionShadowCasterDrawTag@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ProjectionShadowCasterDrawTag
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x011074D4 (12 vfuncs)
    }

    [Rtti(".?AVProjectionShadowReceiverDrawTag@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ProjectionShadowReceiverDrawTag
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01107508 (12 vfuncs)
    }

    [Rtti(".?AVTargetEffectCasterDrawTag@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TargetEffectCasterDrawTag
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01107460 (12 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Rendering / Textures
    // ──────────────────────────────────────────────

    [Rtti(".?AVRenderTexture@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct RenderTexture
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2F04 (6 vfuncs)
    }

    [Rtti(".?AVTextureInstanceContainer@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TextureInstanceContainer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F60AC (1 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Filters (IScreenFilter derivatives)
    // ──────────────────────────────────────────────

    [Rtti(".?AVAmbientOcclusionFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct AmbientOcclusionFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x011045A8 (3 vfuncs)
    }

    [Rtti(".?AVCellEdgeFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CellEdgeFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F7784 (3 vfuncs)
    }

    [Rtti(".?AVColorCorrectionFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ColorCorrectionFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01102360 (3 vfuncs)
    }

    [Rtti(".?AVDepthOfFieldFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DepthOfFieldFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F406C (3 vfuncs)
    }

    [Rtti(".?AVDepthShadowFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DepthShadowFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FBE58 (3 vfuncs)
    }

    [Rtti(".?AVGaussFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct GaussFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F7BE0 (3 vfuncs)
    }

    [Rtti(".?AVGlareFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct GlareFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01106568 (3 vfuncs)
    }

    [Rtti(".?AVLUTColorCorrectionFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LUTColorCorrectionFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01101EBC (3 vfuncs)
    }

    [Rtti(".?AVPlaneFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PlaneFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01101A18 (3 vfuncs)
    }

    [Rtti(".?AVScreenBlurFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ScreenBlurFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FCA34 (3 vfuncs)
    }

    [Rtti(".?AVVarianceBlurFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VarianceBlurFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F73B8 (3 vfuncs)
    }

    [Rtti(".?AVVolumetricCloudFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VolumetricCloudFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FC808 (3 vfuncs)
    }

    [Rtti(".?AVVolumetricLightFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VolumetricLightFilter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01103258 (3 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Shadow / Effect Casters
    // ──────────────────────────────────────────────

    [Rtti(".?AVBaseProjectionShadowCaster@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BaseProjectionShadowCaster
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010C7DB4 (3 vfuncs)
    }

    [Rtti(".?AVProjectionShadowCaster@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ProjectionShadowCaster
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01106604 (3 vfuncs)
    }

    [Rtti(".?AVProjectionShadowCollector@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ProjectionShadowCollector
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F6E24 (1 vfuncs)
    }

    [Rtti(".?AVBaseTargetEffectCaster@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BaseTargetEffectCaster
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F9320 (3 vfuncs)
    }

    [Rtti(".?AVTargetEffectCaster@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TargetEffectCaster
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x011065F4 (3 vfuncs)
    }

    [Rtti(".?AVTargetEffectCollector@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TargetEffectCollector
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F6E1C (1 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Lighting
    // ──────────────────────────────────────────────

    [Rtti(".?AVLightEnv@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LightEnv
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D577C (1 vfuncs)
    }

    [Rtti(".?AVLightSlot@LightEnv@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LightEnv_LightSlot
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D5774 (1 vfuncs)
    }

    [Rtti(".?AVLightSet@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LightSet
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D4E94 (1 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Materials
    // ──────────────────────────────────────────────

    [Rtti(".?AVMaterial@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Material
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D65C0 (1 vfuncs)
    }

    [Rtti(".?AVMaterialInstanceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MaterialInstanceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D646C (13 vfuncs)
    }

    [Rtti(".?AVDefaultConstantParamHandleCache@MaterialInstanceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MaterialInstanceNode_DefaultConstantParamHandleCache
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7224 (3 vfuncs)
    }

    [Rtti(".?AVPixelDefaultConstantParamHandleCache@MaterialInstanceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MaterialInstanceNode_PixelDefaultConstantParamHandleCache
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7244 (3 vfuncs)
    }

    [Rtti(".?AVSamplerIndexCache@MaterialInstanceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MaterialInstanceNode_SamplerIndexCache
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D721C (1 vfuncs)
    }

    [Rtti(".?AVVertexDefaultConstantParamHandleCache@MaterialInstanceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MaterialInstanceNode_VertexDefaultConstantParamHandleCache
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7234 (3 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Mesh
    // ──────────────────────────────────────────────

    [Rtti(".?AVMesh@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Mesh
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F9F8C (2 vfuncs)
    }

    [Rtti(".?AVMeshContainer@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MeshContainer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F9568 (1 vfuncs)
    }

    [Rtti(".?AVMatrixCollector@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MatrixCollector
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F9520 (1 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Models
    // ──────────────────────────────────────────────

    [Rtti(".?AVModelInstanceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ModelInstanceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D5D6C (21 vfuncs)
    }

    [Rtti(".?AVMeshInfo@ModelInstanceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ModelInstanceNode_MeshInfo
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D5D40 (1 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Resource Nodes
    // ──────────────────────────────────────────────

    [Rtti(".?AVMaterialResourceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MaterialResourceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FAEFC (15 vfuncs)
    }

    [Rtti(".?AVMaterialResourceNodeFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MaterialResourceNodeFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2C64 (7 vfuncs)
    }

    [Rtti(".?AVModelResourceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ModelResourceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FAAE4 (15 vfuncs)
    }

    [Rtti(".?AVModelResourceNodeFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ModelResourceNodeFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2BC8 (7 vfuncs)
    }

    [Rtti(".?AVTextureResourceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TextureResourceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7BCC (16 vfuncs)
    }

    [Rtti(".?AVTextureResourceNodeDDX@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TextureResourceNodeDDX
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FADDC (17 vfuncs)
    }

    [Rtti(".?AVTextureResourceNodeFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TextureResourceNodeFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2C24 (7 vfuncs)
    }

    [Rtti(".?AVTextureResourceNodeDDXFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TextureResourceNodeDDXFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2C44 (7 vfuncs)
    }

    [Rtti(".?AVShaderCodeResourceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ShaderCodeResourceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FB17C (15 vfuncs)
    }

    [Rtti(".?AVFactory@ShaderCodeResourceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ShaderCodeResourceNode_Factory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2CAC (7 vfuncs)
    }

    [Rtti(".?AVPRTBlockSetResourceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PRTBlockSetResourceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FB4C4 (15 vfuncs)
    }

    [Rtti(".?AVPRTBlockSetResourceNodeFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PRTBlockSetResourceNodeFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2CCC (7 vfuncs)
    }

    [Rtti(".?AVPRTStreamResourceNode@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PRTStreamResourceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010FB514 (15 vfuncs)
    }

    [Rtti(".?AVPRTStreamResourceNodeFactory@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PRTStreamResourceNodeFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F2D14 (7 vfuncs)
    }

    // ──────────────────────────────────────────────
    // PRT Data
    // ──────────────────────────────────────────────

    [Rtti(".?AVPRTDataBuffer@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PRTDataBuffer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F9AD0 (2 vfuncs)
    }

    [Rtti(".?AVPRTMaterialBuffer@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PRTMaterialBuffer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F9AE8 (2 vfuncs)
    }

    [Rtti(".?AVPRTVertexBuffer@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct PRTVertexBuffer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F9ADC (2 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Shader Drivers (main Renderer namespace)
    // ──────────────────────────────────────────────

    [Rtti(".?AVDepthBufferShaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DepthBufferShaderDriver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F6670 (4 vfuncs)
    }

    [Rtti(".?AVDepthBufferTrapezoidSceShaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DepthBufferTrapezoidSceShaderDriver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F665C (4 vfuncs)
    }

    [Rtti(".?AVDepthDrawShaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DepthDrawShaderDriver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F7F8C (4 vfuncs)
    }

    [Rtti(".?AVFlatColorShaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct FlatColorShaderDriver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F80C4 (4 vfuncs)
    }

    [Rtti(".?AVTextureProjectionShaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TextureProjectionShaderDriver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F84EC (4 vfuncs)
    }

    [Rtti(".?AVVarianceDepthDrawShaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VarianceDepthDrawShaderDriver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F6A84 (4 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Wind
    // ──────────────────────────────────────────────

    [Rtti(".?AVWindParameter@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct WindParameter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7B00 (1 vfuncs)
    }

    [Rtti(".?AVWindPowerSet@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct WindPowerSet
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7E1C (1 vfuncs)
    }

    [Rtti(".?AVMultiCurvePowerSet@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct MultiCurvePowerSet
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7E24 (1 vfuncs)
    }

    [Rtti(".?AVTimeOffsetPowerSet@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TimeOffsetPowerSet
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D7E2C (1 vfuncs)
    }

    // ──────────────────────────────────────────────
    // Misc
    // ──────────────────────────────────────────────

    [Rtti(".?AVSetupProjectionMappingListener@DrawManager@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DrawManager_SetupProjectionMappingListener
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B78B4 (3 vfuncs)
    }

    [Rtti(".?AVIReferenceSolver@InstanceCreator@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct InstanceCreator_IReferenceSolver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109CC08 (2 vfuncs)
    }

    [Rtti(".?AVResourceFinder@InstanceCreator@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct InstanceCreator_ResourceFinder
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F5734 (2 vfuncs)
    }

    [Rtti(".?AVTraverserCounter@ResourceFinder@InstanceCreator@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct InstanceCreator_ResourceFinder_TraverserCounter
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010F549C (2 vfuncs)
    }

    [Rtti(".?AV?$TDynamicPointerArray@VLightSet@Renderer@Dw@Engine@CDev@SQEX@@@Renderer@Dw@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct TDynamicPointerArrayLightSet
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109FD38 (1 vfuncs)
    }

    // ══════════════════════════════════════════════
    // Sub-namespace: ShaderDriver
    // ══════════════════════════════════════════════

    namespace ShaderDriver
    {
        [Rtti(".?AVAlphaOffsetShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AlphaOffsetShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010F8F2C (4 vfuncs)
        }

        [Rtti(".?AVCellShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CellShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010F8DA4 (4 vfuncs)
        }

        [Rtti(".?AVDistortionShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DistortionShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010F926C (4 vfuncs)
        }

        [Rtti(".?AVDrawEnvCubeBlendShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DrawEnvCubeBlendShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010F8E1C (4 vfuncs)
        }

        [Rtti(".?AVPixelLightShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct PixelLightShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D3BC4 (4 vfuncs)
        }

        [Rtti(".?AVPRTShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct PRTShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D4618 (4 vfuncs)
        }

        [Rtti(".?AVShadowMapShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ShadowMapShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D4684 (4 vfuncs)
        }

        [Rtti(".?AVSkyColorShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SkyColorShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D4640 (4 vfuncs)
        }

        [Rtti(".?AVTextureProjectionShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct TextureProjectionShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010F90B8 (4 vfuncs)
        }

        [Rtti(".?AVVertexLightShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexLightShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D3BB0 (4 vfuncs)
        }

        [Rtti(".?AVWaveAnimShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct WaveAnimShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D4604 (4 vfuncs)
        }

        [Rtti(".?AVZPixelClipShaderDriver@shaderDriver@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ZPixelClipShaderDriver
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D462C (4 vfuncs)
        }
    }

    // ══════════════════════════════════════════════
    // Sub-namespace: Resource
    // ══════════════════════════════════════════════

    namespace Resource
    {
        [Rtti(".?AVRecordBuilder@resource@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RecordBuilder
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0110754C (1 vfuncs)
        }

        [Rtti(".?AVRecordFolderBuilder@resource@Renderer@Dw@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RecordFolderBuilder
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01107554 (1 vfuncs)
        }
    }
}
