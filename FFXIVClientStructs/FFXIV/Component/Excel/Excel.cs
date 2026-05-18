using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Excel;

[Rtti(".?AVExcelEntry@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExcelEntry
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108D24 (1 vfunc)
}

[Rtti(".?AVExcelLanguageEvent@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExcelLanguageEvent
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00F8CBF4 (2 vfuncs)
}

[Rtti(".?AVExcelModule@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExcelModule
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108C00 (11 vfuncs)
}

[Rtti(".?AVExcelModuleInterface@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExcelModuleInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01108BB0 (11 vfuncs)
}

[Rtti(".?AVExcelSheet@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExcelSheet
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C6D4 (20 vfuncs)
}

[Rtti(".?AVExcelSheetInterface@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExcelSheetInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C5A4 (18 vfuncs)
}

[Rtti(".?AVExcelSheetKeeper@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExcelSheetKeeper
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110B850 (1 vfunc)
}

[Rtti(".?AVExcelSubSheet@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExcelSubSheet
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110DC94 (3 vfuncs)
}

[Rtti(".?AVCacheAll@PAVExcelEntry@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PAVExcelEntry_CacheAll
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C670 (9 vfuncs)
}

[Rtti(".?AVCacheInterface@PAVExcelEntry@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PAVExcelEntry_CacheInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C5F0 (9 vfuncs)
}

[Rtti(".?AVCacheList@PAVExcelEntry@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PAVExcelEntry_CacheList
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C638 (9 vfuncs)
}

[Rtti(".?AVCacheMap@PAVExcelEntry@Excel@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PAVExcelEntry_CacheMap
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110C698 (9 vfuncs)
}

