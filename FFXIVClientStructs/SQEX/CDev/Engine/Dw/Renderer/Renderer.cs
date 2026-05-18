using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Dw.Renderer;

// SQEX::CDev::Engine::Dw::Renderer (Crystal Tools rendering subsystem)
// Handles all GPU rendering: shaders, textures, post-effects, culling
//
// Key RTTI classes:
//   CullingObject — frustum culling
//   BaseProjectionShadowCaster — shadow mapping
//   BaseTargetEffectCaster — render targets
//   AmbientOcclusionFilter — SSAO
//   CellEdgeFilter — toon outline
//   ColorCorrectionFilter — color grading
//   CDevMaterialFactory — material system

[Rtti(".?AVCullingObject@Renderer@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct CullingObject
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVAmbientOcclusionFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct AmbientOcclusionFilter
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVColorCorrectionFilter@Renderer@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct ColorCorrectionFilter
{
    [FieldOffset(0x00)] public nint VTable;
}
