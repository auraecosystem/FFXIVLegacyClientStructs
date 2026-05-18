using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.GAM;

// Component::GAM — Game Attribute Manager
// Manages character data for lobby operations (chara make, chara select)

[Rtti(".?AVBase@GAM@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct Base
{
    [FieldOffset(0x00)] public nint VTable;
}

// CharaMakeData and ClientSelectData are stored in Network::Application::GameAttributeManager
// Used during character creation and login
