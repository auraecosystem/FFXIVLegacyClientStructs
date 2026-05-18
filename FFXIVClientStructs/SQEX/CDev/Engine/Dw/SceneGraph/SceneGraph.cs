using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Dw.SceneGraph;

// SQEX::CDev::Engine::Dw::SceneGraph
// Scene graph node hierarchy for the rendering engine

[Rtti(".?AVAttributedNode@SceneGraph@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe struct AttributedNode
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVCharacterSkeletonNode@SceneGraph@Dw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct CharacterSkeletonNode
{
    [FieldOffset(0x00)] public nint VTable;
}
