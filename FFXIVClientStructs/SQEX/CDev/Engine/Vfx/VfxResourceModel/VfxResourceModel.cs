using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Vfx.VfxResourceModel
{
    [Rtti(".?AVIVfxModelResourceObject@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IVfxModelResourceObject
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D237C (1 vfuncs)
    }

    [Rtti(".?AVVfxAnimationResource@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxAnimationResource
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D2EF4 (10 vfuncs)
    }

    [Rtti(".?AVVfxMaterialResource@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxMaterialResource
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D28D8 (1 vfuncs)
    }

    [Rtti(".?AVVfxModelInstanceResource@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxModelInstanceResource
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D2C00 (1 vfuncs)
    }

    [Rtti(".?AVVfxModelResource@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxModelResource
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D2C14 (42 vfuncs)
    }

    [Rtti(".?AVVfxModelTextureReplacementInfo@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxModelTextureReplacementInfo
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D2C0C (1 vfuncs)
    }

    [Rtti(".?AVVfxMultPrimitiveBuffer@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxMultPrimitiveBuffer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D30CC (13 vfuncs)
    }

    [Rtti(".?AVVfxShader@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxShader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D2384 (1 vfuncs)
    }

    [Rtti(".?AVVfxSinglePrimitiveBuffer@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxSinglePrimitiveBuffer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D3098 (12 vfuncs)
    }

    [Rtti(".?AVVfxTexture@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct VfxTexture
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010D2BF8 (1 vfuncs)
    }

    namespace Material
    {
        [Rtti(".?AVDataTableMap@Material@VfxResourceModel@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DataTableMap
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010D26E0 (12 vfuncs)
        }
    }
}
