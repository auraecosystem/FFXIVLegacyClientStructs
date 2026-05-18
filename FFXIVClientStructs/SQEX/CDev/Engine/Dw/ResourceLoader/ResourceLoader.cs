using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Dw.ResourceLoader;

// SQEX::CDev::Engine::Dw::ResourceLoader
// Hierarchy and resource data containers

[Rtti(".?AVIHierarchyData@ResourceLoader@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IHierarchyData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113BC24 (34 vfuncs)
}

/// <summary>Inherits DwResourceLoaderMemoryObject, IHierarchyData.</summary>
[Rtti(".?AVHierarchyDataContainer@ResourceLoader@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct HierarchyDataContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113BD64 (34 vfuncs)
}

[Rtti(".?AVIResourceData@ResourceLoader@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IResourceData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B9D4 (11 vfuncs)
}

/// <summary>Inherits IResourceData.</summary>
[Rtti(".?AVResourceData@ResourceLoader@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ResourceData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113BA20 (11 vfuncs)
}
