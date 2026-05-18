using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Xml;

[Rtti(".?AVDOM_Attr@Xml@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DOM_Attr
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0106C8A0 (10 vfuncs)
}

[Rtti(".?AVDOM_CDATASection@Xml@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DOM_CDATASection
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01129C48 (10 vfuncs)
}

[Rtti(".?AVDOM_Comment@Xml@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DOM_Comment
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01129C74 (10 vfuncs)
}

[Rtti(".?AVDOM_Document@Xml@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DOM_Document
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01076EB8 (10 vfuncs)
}

[Rtti(".?AVDOM_Text@Xml@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DOM_Text
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01129C1C (10 vfuncs)
}

