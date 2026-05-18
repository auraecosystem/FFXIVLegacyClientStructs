using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Patch;

[Rtti(".?AVPatchDownloadBase@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PatchDownloadBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010672C0 (7 vfuncs)
}

[Rtti(".?AVPatchDownloadInterface@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PatchDownloadInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01067260 (7 vfuncs)
}

[Rtti(".?AVPatchInstallImpl@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PatchInstallImpl
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010673B0 (4 vfuncs)
}

[Rtti(".?AVPatchTorrentDownload@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PatchTorrentDownload
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010673FC (7 vfuncs)
}

[Rtti(".?AVTorrentDownloadImpl@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TorrentDownloadImpl
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0106744C (11 vfuncs)
}

[Rtti(".?AVVersionCheckImpl@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct VersionCheckImpl
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010671F8 (4 vfuncs)
}

[Rtti(".?AVZiPatchApply@ZiPatch@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ZiPatch_ZiPatchApply
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01067898 (2 vfuncs)
}

[Rtti(".?AVZiPatchFile@ZiPatch@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ZiPatch_ZiPatchFile
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01067998 (5 vfuncs)
}

[Rtti(".?AVZiPatchReader@ZiPatch@Patch@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ZiPatch_ZiPatchReader
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01067990 (1 vfunc)
}

