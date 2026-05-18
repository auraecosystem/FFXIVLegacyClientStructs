using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Main.Element.Window;

[Rtti(".?AVRoutedEventHandler<WidgetEventHandler>@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RoutedEventHandlerWidgetEventHandler
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FC2204 (3 vfuncs)
}

[Rtti(".?AVSqwtElement@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SqwtElement
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FC2008 (14 vfuncs)
}

[Rtti(".?AVWindowPositionConfig@Window@Element@Main@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WindowPositionConfig
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FC2050 (1 vfunc)
}

