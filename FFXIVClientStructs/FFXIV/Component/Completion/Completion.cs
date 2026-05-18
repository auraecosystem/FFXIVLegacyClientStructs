using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Completion;

[Rtti(".?AVCategoryData@Completion@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CategoryData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C7F8 (7 vfuncs)
}

[Rtti(".?AVCategoryDataCache@Completion@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CategoryDataCache
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C818 (7 vfuncs)
}

[Rtti(".?AVCompletionModule@Completion@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CompletionModule
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108E40 (11 vfuncs)
}

[Rtti(".?AVCompletionModuleInterface@Completion@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CompletionModuleInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108DC4 (11 vfuncs)
}

