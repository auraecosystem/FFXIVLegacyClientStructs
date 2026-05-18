using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Fw.SceneObject;

// SQEX::CDev::Engine::Fw::SceneObject::BaseWorld
// Root world container for the scene graph
// RTTI: .?AVBaseWorld@SceneObject@Fw@Engine@CDev@SQEX@@
// Vtable: not directly found (may be abstract/template instantiated)
[Rtti(".?AVBaseWorld@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)] // size TBD
public unsafe struct BaseWorld
{
    [FieldOffset(0x00)] public nint VTable;
    // TODO: world contains ActorContainer list, scene graph root, etc.
}
