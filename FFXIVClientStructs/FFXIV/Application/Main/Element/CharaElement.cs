using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Main.Element;

// Application::Main::Element::Chara::CharaElement
// UI element for character-related displays (HUD, nameplates, etc.)
// Vtable: 0x00FA7C50 (14 virtual methods)
// Ctor:   0x0058B4E0
// Size:   0xEF0 (3,824 bytes)
// Alloc:  push 0xEF0
// RTTI:   .?AVCharaElement@Chara@Element@Main@Application@@
[Rtti(".?AVCharaElement@Chara@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0xEF0)]
public unsafe struct CharaElement
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FA7C50
}

// Application::Main::Element::System::BootupElement
[Rtti(".?AVBootupElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct BootupElement
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Main::Element::System::CameraElement
[Rtti(".?AVCameraElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct CameraElement
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Main::Element::System::CustomControlElement
[Rtti(".?AVCustomControlElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct CustomControlElement
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Main::Element::System::CommonResourceElement
[Rtti(".?AVCommonResourceElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct CommonResourceElement
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Main::Element::System::TargetInfo
// Vtable: 0x00FA415C
// Used by CharaActor at +0x1354 and +0x13C8 (target + focus target)
[Rtti(".?AVTargetInfo@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x74)] // spacing from CharaActor: 0x13C8 - 0x1354 = 0x74
public unsafe struct TargetInfo
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FA415C
}
