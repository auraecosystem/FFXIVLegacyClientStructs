using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Dw.Animation;

// SQEX::CDev::Engine::Dw::Animation
// Skeletal animation system — curves, motion layers, controllers

// ===================== Interfaces =====================

[Rtti(".?AVICurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098C48 (8 vfuncs)
}

[Rtti(".?AVIMotionCurveContainer@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IMotionCurveContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098B40 (14 vfuncs)
}

[Rtti(".?AVIMotionLayer@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IMotionLayer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B244 (27 vfuncs)
}

// ===================== Core =====================

/// <summary>Inherits DwAnimationMemoryObject.</summary>
[Rtti(".?AVAnimationController@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AnimationController
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B34C (1 vfuncs)
}

/// <summary>Inherits DwAnimationMemoryObject.</summary>
[Rtti(".?AVAnimationManager@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AnimationManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B234 (1 vfuncs)
}

[Rtti(".?AVAnimationResourceNode@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AnimationResourceNode
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01099454 (15 vfuncs)
}

/// <summary>Inherits ReferencedResourceNodeFactory.</summary>
[Rtti(".?AVAnimationResourceNodeFactory@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AnimationResourceNodeFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FF6688 (7 vfuncs)
}

/// <summary>Inherits DwAnimationMemoryObject.</summary>
[Rtti(".?AVRootAnimationManager@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RootAnimationManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109E2D0 (1 vfuncs)
}

// ===================== Curve Implementations =====================

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVCompressedCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CompressedCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B808 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVCompressedQuatCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CompressedQuatCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B900 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVConstantCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ConstantCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098D34 (8 vfuncs)
}

/// <summary>Inherits ICurve, DwAnimationMemoryObject.</summary>
[Rtti(".?AVEditableCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EditableCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010996F8 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVFixedCompressedCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FixedCompressedCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01099BE4 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVFixedCompressedQuatCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FixedCompressedQuatCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01099A14 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVFixedCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FixedCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098C88 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVFixedCurve16@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FixedCurve16
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098CC8 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVFixedFloat3Curve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FixedFloat3Curve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01099AE4 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVFixedQuantizedQuaternionCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FixedQuantizedQuaternionCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098D10 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVFixedQuaternionCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FixedQuaternionCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109990C (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVFloat3Curve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Float3Curve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B71C (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVLinearCurve16@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LinearCurve16
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098CEC (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVQuantizedQuaternionCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct QuantizedQuaternionCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B610 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVQuaternionCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct QuaternionCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B514 (8 vfuncs)
}

/// <summary>Inherits ICurve.</summary>
[Rtti(".?AVStepCurve@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StepCurve
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098D58 (8 vfuncs)
}

// ===================== Motion =====================

/// <summary>Inherits DwAnimationMemoryObject, IMotionCurveContainer.</summary>
[Rtti(".?AVDynamicMotionCurveContainer@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DynamicMotionCurveContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098BDC (14 vfuncs)
}

/// <summary>Inherits DwAnimationMemoryObject.</summary>
[Rtti(".?AVMotionComponent@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionComponent
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B9C4 (1 vfuncs)
}

/// <summary>Inherits IMotionLayer, DwAnimationMemoryObject.</summary>
[Rtti(".?AVMotionControlLayer@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionControlLayer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113B2B4 (28 vfuncs)
}

/// <summary>Inherits AnimationObject, IMotionCurveContainer.</summary>
[Rtti(".?AVMotionCurveContainer@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionCurveContainer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01098B7C (14 vfuncs)
}
