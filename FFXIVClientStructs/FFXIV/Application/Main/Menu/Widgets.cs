using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Main.Menu;

// Application::Main::Menu — Game UI widgets (50+ RTTI classes)
// All game-specific UI windows built on the Sqwt framework

// Chat
[Rtti(".?AVCommunication@Widget@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct CommunicationWidget
{
    [FieldOffset(0x00)] public nint VTable;
}

// Equipment / Inventory
[Rtti(".?AVActionEquipWidget@Widget@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct ActionEquipWidget
{
    [FieldOffset(0x00)] public nint VTable;
}

// Config screens
[Rtti(".?AVConfigWidget@Widget@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct ConfigWidget
{
    [FieldOffset(0x00)] public nint VTable;
}

// Aetheryte list
[Rtti(".?AVAetheryteListWidget@Widget@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct AetheryteListWidget
{
    [FieldOffset(0x00)] public nint VTable;
}

// Community menu
[Rtti(".?AVCommunityMenuWidget@Widget@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct CommunityMenuWidget
{
    [FieldOffset(0x00)] public nint VTable;
}

// Bazaar
[Rtti(".?AVBazaarEditWidget@Widget@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct BazaarEditWidget
{
    [FieldOffset(0x00)] public nint VTable;
}
