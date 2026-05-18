using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Main.Element.System;

[Rtti(".?AVClientWorkElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClientWorkElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA42B0 (14 vfuncs)
}

[Rtti(".?AVSSDReader@CustomControlElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CustomControlElement_SSDReader
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA444C (3 vfuncs)
}

[Rtti(".?AVCutManagerElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CutManagerElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA4DB8 (14 vfuncs)
}

[Rtti(".?AVGameManagerElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct GameManagerElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA4AA8 (14 vfuncs)
}

[Rtti(".?AVMainElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MainElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA4F18 (14 vfuncs)
}

[Rtti(".?AVPhaseManager@MainElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MainElement_PhaseManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA4474 (6 vfuncs)
}

[Rtti(".?AVMouseEventHandler<CameraElement>@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MouseEventHandlerCameraElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA5108 (3 vfuncs)
}

[Rtti(".?AVMouseEventHandler<TargetElement>@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MouseEventHandlerTargetElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA5118 (3 vfuncs)
}

[Rtti(".?AVExecutedRoutedEventHandler<PhaseCredit>@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_ExecutedRoutedEventHandlerPhaseCredit
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD0E80 (3 vfuncs)
}

[Rtti(".?AVPhaseAig@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseAig
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD0250 (6 vfuncs)
}

[Rtti(".?AVPhaseCISLogin@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseCISLogin
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD0650 (6 vfuncs)
}

[Rtti(".?AVPhaseCredit@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseCredit
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD0E54 (6 vfuncs)
}

[Rtti(".?AVPhaseDemo@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseDemo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD1AA0 (6 vfuncs)
}

[Rtti(".?AVPhaseEsrb@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseEsrb
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA44AC (6 vfuncs)
}

[Rtti(".?AVPhaseExit@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseExit
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD0A18 (6 vfuncs)
}

[Rtti(".?AVPhaseGame@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseGame
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD12CC (6 vfuncs)
}

[Rtti(".?AVPhaseInstall@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseInstall
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD1E8C (6 vfuncs)
}

[Rtti(".?AVPhaseInstallMain@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseInstallMain
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD1EA8 (6 vfuncs)
}

[Rtti(".?AVPhaseLogo@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseLogo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA44C8 (6 vfuncs)
}

[Rtti(".?AVPhaseOptimizeTest@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseOptimizeTest
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD169C (6 vfuncs)
}

[Rtti(".?AVPhasePatchManager@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhasePatchManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD204C (6 vfuncs)
}

[Rtti(".?AVPhasePsnWaiting@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhasePsnWaiting
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD29B8 (6 vfuncs)
}

[Rtti(".?AVPhaseShandaLogo@Phase@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Phase_PhaseShandaLogo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA4490 (6 vfuncs)
}

[Rtti(".?AVScreenshotManagerElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScreenshotManagerElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA4C08 (14 vfuncs)
}

[Rtti(".?AVTargetElement@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TargetElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA50C4 (16 vfuncs)
}

[Rtti(".?AVTargetWidget@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TargetWidget
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA44EC (10 vfuncs)
}

[Rtti(".?AVTargetWidgetWindow@System@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TargetWidgetWindow
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FA44E4 (1 vfunc)
}

