using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Dw.Animation;

// SQEX::CDev::Engine::Dw::Animation
// Skeletal animation system

[Rtti(".?AVAnimationController@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct AnimationController
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVAnimationManager@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe struct AnimationManager
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVAnimationObject@Animation@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct AnimationObject
{
    [FieldOffset(0x00)] public nint VTable;
}
