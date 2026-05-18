// Project: FFXIVLegacyClientStructs
// FFXIV 1.0 (1.23b) Client Structures
// Author: Yokimitsuro

using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Lay.Stella.Layout;

// =====================================================================
// Core Interfaces
// =====================================================================

[Rtti(".?AVIInstanceObjectSearch@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IInstanceObjectSearch
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBF790 (2 vfuncs)
}

[Rtti(".?AVILayoutBaseObjectCreator@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutBaseObjectCreator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A53E4 (8 vfuncs)
}

[Rtti(".?AVILayoutBaseObjectManager@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutBaseObjectManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A1E84 (22 vfuncs)
}

[Rtti(".?AVILayoutBlock@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A330C (45 vfuncs)
}

[Rtti(".?AVILayoutBlockListener@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutBlockListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A2058 (2 vfuncs)
}

[Rtti(".?AVILayoutBlockManager@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutBlockManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBF79C (17 vfuncs)
}

[Rtti(".?AVILayoutEnvironmentInfoController@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutEnvironmentInfoController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A86BC (5 vfuncs)
}

[Rtti(".?AVILayoutInstanceObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutInstanceObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A3E44 (78 vfuncs)
}

[Rtti(".?AVILayoutInstanceSharedFolder@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutInstanceSharedFolder
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A43A4 (38 vfuncs)
}

[Rtti(".?AVILayoutManager@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A2074 (125 vfuncs)
}

[Rtti(".?AVILayoutManagerListener@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutManagerListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A102C (8 vfuncs)
}

[Rtti(".?AVILayoutObjectFactory@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutObjectFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A2DFC (32 vfuncs)
}

[Rtti(".?AVILayoutObjectFactoryCore@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutObjectFactoryCore
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBF87C (19 vfuncs)
}

[Rtti(".?AVILayoutResourceBindInfo@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutResourceBindInfo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBF7E4 (8 vfuncs)
}

[Rtti(".?AVILayoutSetupListener@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutSetupListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A8690 (3 vfuncs)
}

[Rtti(".?AVILayoutUnitInfo@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutUnitInfo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A4554 (64 vfuncs)
}

[Rtti(".?AVILayoutUnitInfoListener@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutUnitInfoListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109F6FC (2 vfuncs)
}

[Rtti(".?AVILayoutWorld@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutWorld
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A2F84 (34 vfuncs)
}

[Rtti(".?AVILayoutWorldGlobalTime@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILayoutWorldGlobalTime
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBF9B0 (3 vfuncs)
}

// =====================================================================
// Base Object Interfaces
// =====================================================================

[Rtti(".?AVIAttributeBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IAttributeBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A592C (53 vfuncs)
}

[Rtti(".?AVIBGChipModelBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IBGChipModelBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A5A9C (64 vfuncs)
}

[Rtti(".?AVIBGPartsModelBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IBGPartsModelBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A5DAC (64 vfuncs)
}

[Rtti(".?AVICameraBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICameraBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A6074 (41 vfuncs)
}

[Rtti(".?AVICharacterBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICharacterBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A6124 (64 vfuncs)
}

[Rtti(".?AVICollisionBoxBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICollisionBoxBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A640C (41 vfuncs)
}

[Rtti(".?AVICubeMapBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICubeMapBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A64BC (44 vfuncs)
}

[Rtti(".?AVIEnemyPathBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IEnemyPathBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A6774 (65 vfuncs)
}

[Rtti(".?AVILightBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILightBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A6954 (48 vfuncs)
}

[Rtti(".?AVINullBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct INullBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A6B34 (39 vfuncs)
}

[Rtti(".?AVIOcclusionBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IOcclusionBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A6C8C (41 vfuncs)
}

[Rtti(".?AVIPositionMarkerBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IPositionMarkerBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A6DE4 (39 vfuncs)
}

[Rtti(".?AVIScreenEnvBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IScreenEnvBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A72A4 (255 vfuncs)
}

[Rtti(".?AVISEBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ISEBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A7B74 (43 vfuncs)
}

[Rtti(".?AVITimeLineBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ITimeLineBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A7D3C (44 vfuncs)
}

[Rtti(".?AVITriggerBoxBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ITriggerBoxBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A7F4C (42 vfuncs)
}

[Rtti(".?AVIUnitTreeBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IUnitTreeBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A80D4 (44 vfuncs)
}

[Rtti(".?AVIVfxBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IVfxBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A826C (45 vfuncs)
}

[Rtti(".?AVIWindBaseObject@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IWindBaseObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A838C (52 vfuncs)
}

// =====================================================================
// Instance Object Property Interfaces
// =====================================================================

[Rtti(".?AVIAttributeInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IAttributeInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A369C (33 vfuncs)
}

[Rtti(".?AVICharacterInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICharacterInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A3B8C (37 vfuncs)
}

[Rtti(".?AVICollisionBoxInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICollisionBoxInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A3CCC (37 vfuncs)
}

[Rtti(".?AVILightInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ILightInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A48E4 (42 vfuncs)
}

[Rtti(".?AVIOcclusionInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IOcclusionInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A4B4C (33 vfuncs)
}

[Rtti(".?AVIScreenEnvInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IScreenEnvInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A4C6C (38 vfuncs)
}

[Rtti(".?AVISEInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ISEInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A4DB4 (37 vfuncs)
}

[Rtti(".?AVITimeLineInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ITimeLineInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A4F1C (34 vfuncs)
}

[Rtti(".?AVITriggerBoxInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ITriggerBoxInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A50AC (44 vfuncs)
}

// =====================================================================
// Concrete Types
// =====================================================================

[Rtti(".?AVBGChipInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BGChipInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A3978 (1 vfunc)
}

[Rtti(".?AVGlobalTimeMotionInfo@BGModelInstanceObjectPropertyUtils@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BGModelInstanceObjectPropertyUtils_GlobalTimeMotionInfo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A89C4 (1 vfunc)
}

[Rtti(".?AVCopyOnWriteData@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CopyOnWriteData
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A2288 (1 vfunc)
}

[Rtti(".?AVDefaultSetupListenerWithReferenceResource@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DefaultSetupListenerWithReferenceResource
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A86B0 (1 vfunc)
}

[Rtti(".?AVLayoutBlockManager@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayoutBlockManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A8774 (1 vfunc)
}

[Rtti(".?AVLayoutClassifiedBaseObjectContainer@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayoutClassifiedBaseObjectContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A1FA8 (1 vfunc)
}

[Rtti(".?AVLayoutEnvironmentInfoController@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayoutEnvironmentInfoController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A86D4 (5 vfuncs)
}

[Rtti(".?AVLayoutInstanceObjectPropertyBase@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayoutInstanceObjectPropertyBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A899C (8 vfuncs)
}

[Rtti(".?AVBlockLocalCallbackListener@LayoutManager@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayoutManager_BlockLocalCallbackListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A2064 (2 vfuncs)
}

[Rtti(".?AV_RigidBodyCollisionListener@TriggerBoxInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TriggerBoxInstanceObjectProperty_RigidBodyCollisionListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A5098 (3 vfuncs)
}

[Rtti(".?AVUnitTreeInstanceObjectTable@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct UnitTreeInstanceObjectTable
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A4790 (7 vfuncs)
}

[Rtti(".?AVVfxInstanceObjectProperty@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct VfxInstanceObjectProperty
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A53D0 (3 vfuncs)
}

// =====================================================================
// Internal/Helper Types
// =====================================================================

[Rtti(".?AV_BaseObjectContainerIterator@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BaseObjectContainerIterator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A1F50 (1 vfunc)
}

[Rtti(".?AV_BinAddrInstanceObjectSearcher@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BinAddrInstanceObjectSearcher
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A226C (2 vfuncs)
}

[Rtti(".?AV_CubeMapBaseObjectListenerForUpdateDrawEnv@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CubeMapBaseObjectListenerForUpdateDrawEnv
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A6590 (1 vfunc)
}

[Rtti(".?AV_DefaultLayoutWorldGlobalTime@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DefaultLayoutWorldGlobalTime
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A3020 (1 vfunc)
}

[Rtti(".?AV_WindBaseObjectListenerForUpdateDrawEnv@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WindBaseObjectListenerForUpdateDrawEnv
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A8480 (1 vfunc)
}

// =====================================================================
// Misc
// =====================================================================

[Rtti(".?AVTGridSpace2D@?$PAVILayoutBlock@Layout@Stella@Lay@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TGridSpace2D
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010A871C (1 vfunc)
}
