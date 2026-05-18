using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Fw.SceneObject;

// SQEX::CDev::Engine::Fw::SceneObject::ActorContainer
// Manages a collection of Actor instances in the scene
// RTTI: .?AVActorContainer@SceneObject@Fw@Engine@CDev@SQEX@@
[Rtti(".?AVActorContainer@SceneObject@Fw@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)] // size TBD
public unsafe struct ActorContainer
{
    [FieldOffset(0x00)] public nint VTable;
    // TODO: linked list / array of Actor*
}
