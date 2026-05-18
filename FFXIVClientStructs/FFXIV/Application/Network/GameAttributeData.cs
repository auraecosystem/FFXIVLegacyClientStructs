using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Network;

// ============================================================================
// GameAttributeManager::Data — Network-serializable game state collections
//
// These are ParameterCollectionBase derivatives that map network packet
// fields to game attributes. Each collection type corresponds to a specific
// packet flow or game state context.
//
// All inherit: ParameterCollectionBase → ParameterBase → Base (23 vfuncs)
// Each has a companion MetadataProvider (6 vfuncs).
// ============================================================================

[Rtti(".?AVPlayer@0Data@GameAttributeManager@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct GAMPlayerData
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FAB90C (23 vfuncs)
}

[Rtti(".?AVPlayerPlayer@0Data@GameAttributeManager@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct GAMPlayerPlayerData
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FAB98C (23 vfuncs)
}

[Rtti(".?AVZoneInitData@0Data@GameAttributeManager@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct GAMZoneInitData
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FABA0C (23 vfuncs)
}

[Rtti(".?AVClientSelectData@0Data@GameAttributeManager@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct GAMClientSelectData
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FAB80C (23 vfuncs)
}

[Rtti(".?AVClientSelectDataN@0Data@GameAttributeManager@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct GAMClientSelectDataN
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FAB88C (23 vfuncs)
}

[Rtti(".?AVCharaMakeData@0Data@GameAttributeManager@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct GAMCharaMakeData
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FAB78C (23 vfuncs)
}
