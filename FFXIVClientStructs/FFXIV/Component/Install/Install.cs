using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Install;

[Rtti(".?AVInstallDecoder@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallDecoder
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110D550 (14 vfuncs)
}

[Rtti(".?AVInstallEncoder@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallEncoder
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110BAE8 (14 vfuncs)
}

[Rtti(".?AVInstallModule@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallModule
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010513E4 (3 vfuncs)
}

[Rtti(".?AVInstallModuleInterface@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallModuleInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010513D4 (3 vfuncs)
}

[Rtti(".?AVInstallerInterface@InstallModuleInterface@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallModuleInterface_InstallerInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110BAAC (14 vfuncs)
}

[Rtti(".?AVInstallReader@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallReader
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110D4DC (4 vfuncs)
}

[Rtti(".?AVInstallUnpacker@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallUnpacker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110D53C (4 vfuncs)
}

[Rtti(".?AVInstallWriter@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallWriter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110D510 (4 vfuncs)
}

[Rtti(".?AVQueue@PAVWriteEntry@InstallWriter@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallWriter_PAVWriteEntry_Queue
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110D508 (1 vfunc)
}

[Rtti(".?AVWriteEntry@InstallWriter@Install@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct InstallWriter_WriteEntry
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0110D4F0 (5 vfuncs)
}

