using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Vfx.RenderInterface
{
    [Rtti(".?AVICore@RenderInterface@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ICore
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B565C (127 vfuncs)
    }

    namespace D3D9
    {
        [Rtti(".?AVID3D9HlslShader@D3D9@RenderInterface@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ID3D9HlslShader
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5874 (1 vfuncs)
        }

        [Rtti(".?AVID3D9Surface@D3D9@RenderInterface@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ID3D9Surface
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B5868 (2 vfuncs)
        }

        [Rtti(".?AVID3D9Texture@D3D9@RenderInterface@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ID3D9Texture
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B585C (2 vfuncs)
        }

        [Rtti(".?AVID3D9VertexDeclaration@D3D9@RenderInterface@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ID3D9VertexDeclaration
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B587C (2 vfuncs)
        }
    }
}
