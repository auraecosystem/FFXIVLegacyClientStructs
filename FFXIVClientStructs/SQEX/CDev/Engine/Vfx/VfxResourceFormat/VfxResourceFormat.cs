using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Vfx.VfxResourceFormat
{
    [Rtti(".?AVIVfxResourceFile@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IVfxResourceFile
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010CDFD4 (16 vfuncs)
    }

    [Rtti(".?AVVfxResourceFile@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxResourceFile
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010CE01C (17 vfuncs)
    }

    [Rtti(".?AVVfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxResourceBaseAttribute
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D14D4 (6 vfuncs)

        [Rtti(".?AVIVfxResourceFileAttributeObject@VfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IVfxResourceFileAttributeObject
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CDFBC (5 vfuncs)
        }

        [Rtti(".?AVVfxResourceFileAttributeLibrary@VfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VfxResourceFileAttributeLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D13EC (7 vfuncs)
        }

        [Rtti(".?AVChunkInfo@VfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ChunkInfo
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1024 (5 vfuncs)
        }

        [Rtti(".?AVDataTable@VfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DataTable
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1C58 (5 vfuncs)
        }

        [Rtti(".?AVFileInfo@VfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct FileInfo
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010CE1D0 (5 vfuncs)
        }

        [Rtti(".?AVIndex@VfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Index
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D14F0 (5 vfuncs)
        }

        [Rtti(".?AVName@VfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Name
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1354 (5 vfuncs)
        }

        [Rtti(".?AVNameLibrary@VfxResourceBaseAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct NameLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1508 (7 vfuncs)
        }
    }

    [Rtti(".?AVVfxResourceAnimationAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxResourceAnimationAttribute
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D18E8 (6 vfuncs)

        [Rtti(".?AVAnimation@VfxResourceAnimationAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Animation
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D16BC (5 vfuncs)
        }

        [Rtti(".?AVAnimationChunkInfo@VfxResourceAnimationAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AnimationChunkInfo
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D10B4 (6 vfuncs)
        }

        [Rtti(".?AVAnimationKey@VfxResourceAnimationAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AnimationKey
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1688 (5 vfuncs)
        }

        [Rtti(".?AVAnimationKeySet@VfxResourceAnimationAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AnimationKeySet
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D16A0 (6 vfuncs)
        }

        [Rtti(".?AVAnimationKeySetLibrary@VfxResourceAnimationAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AnimationKeySetLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D16D4 (7 vfuncs)
        }

        [Rtti(".?AVAnimationLibrary@VfxResourceAnimationAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AnimationLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D16F4 (7 vfuncs)
        }
    }

    [Rtti(".?AVVfxResourceInstanceAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxResourceInstanceAttribute
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D160C (6 vfuncs)

        [Rtti(".?AVIndexGroupValue@VfxResourceInstanceAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IndexGroupValue
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D140C (6 vfuncs)
        }

        [Rtti(".?AVIndexGroupValueLibrary@VfxResourceInstanceAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IndexGroupValueLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1548 (7 vfuncs)
        }

        [Rtti(".?AVInstanceChunkInfo@VfxResourceInstanceAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct InstanceChunkInfo
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1008 (6 vfuncs)
        }

        [Rtti(".?AVInstanceValue@VfxResourceInstanceAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct InstanceValue
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1588 (5 vfuncs)
        }

        [Rtti(".?AVInstanceValueLibrary@VfxResourceInstanceAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct InstanceValueLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1528 (7 vfuncs)
        }

        [Rtti(".?AVMultiIndexGroupValue@VfxResourceInstanceAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct MultiIndexGroupValue
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D14BC (5 vfuncs)
        }

        [Rtti(".?AVMultiIndexGroupValueLibrary@VfxResourceInstanceAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct MultiIndexGroupValueLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1568 (7 vfuncs)
        }
    }

    [Rtti(".?AVVfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxResourceModelAttribute
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D2284 (6 vfuncs)

        [Rtti(".?AVIndexBuffer@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IndexBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D19E4 (6 vfuncs)
        }

        [Rtti(".?AVIndexBufferLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IndexBufferLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1D08 (7 vfuncs)
        }

        [Rtti(".?AVMaterial@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Material
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1978 (6 vfuncs)
        }

        [Rtti(".?AVMaterialLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct MaterialLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1CC8 (7 vfuncs)
        }

        [Rtti(".?AVModelBuffer@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ModelBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D19CC (5 vfuncs)
        }

        [Rtti(".?AVModelBufferLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ModelBufferLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1D48 (7 vfuncs)
        }

        [Rtti(".?AVModelChunkInfo@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ModelChunkInfo
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D114C (6 vfuncs)
        }

        [Rtti(".?AVNode@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Node
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1A8C (6 vfuncs)
        }

        [Rtti(".?AVNodeLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct NodeLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1D88 (7 vfuncs)
        }

        [Rtti(".?AVNodeValue@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct NodeValue
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1FF8 (5 vfuncs)
        }

        [Rtti(".?AVNodeValueLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct NodeValueLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1D68 (7 vfuncs)
        }

        [Rtti(".?AVResourceID@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceID
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1C90 (5 vfuncs)
        }

        [Rtti(".?AVResourceIDLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceIDLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1C70 (7 vfuncs)
        }

        [Rtti(".?AVShader@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Shader
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1960 (5 vfuncs)
        }

        [Rtti(".?AVShaderLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ShaderLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1CA8 (7 vfuncs)
        }

        [Rtti(".?AVSpriteBuffer@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SpriteBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D19B4 (5 vfuncs)
        }

        [Rtti(".?AVSpriteBufferLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SpriteBufferLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1D28 (7 vfuncs)
        }

        [Rtti(".?AVVertexBuffer@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexBuffer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1994 (7 vfuncs)
        }

        [Rtti(".?AVVertexBufferLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexBufferLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1CE8 (7 vfuncs)
        }

        [Rtti(".?AVVertexDeclaration@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexDeclaration
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D226C (5 vfuncs)
        }

        [Rtti(".?AVVertexDeclarationLibrary@VfxResourceModelAttribute@VfxResourceFormat@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VertexDeclarationLibrary
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D1DA8 (7 vfuncs)
        }
    }
}
