using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Vfx.Renderer;

[Rtti(".?AVIPixelShader@Renderer@Vfx@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IPixelShader
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010B58C8 (3 vfuncs)
}

[Rtti(".?AVIRenderState@Renderer@Vfx@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IRenderState
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010B5888 (3 vfuncs)
}

[Rtti(".?AVIRenderTexture@Renderer@Vfx@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IRenderTexture
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010B58E4 (8 vfuncs)
}

[Rtti(".?AVIShaderPatch@Renderer@Vfx@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IShaderPatch
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010B5898 (11 vfuncs)
}

[Rtti(".?AVIVertexShader@Renderer@Vfx@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IVertexShader
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010B58D8 (2 vfuncs)
}
