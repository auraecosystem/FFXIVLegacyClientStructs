using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Xml;

// ============================================================================
// Sqwt::Xml — XML DOM wrappers for resource dictionaries
//
// Thin wrappers around Component::Xml DOM types, used by the XAML parser
// and resource dictionary system.
// ============================================================================

[Rtti(".?AVXmlDocument@Xml@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XmlDocument
{
    // Inherits: Object → AllocatorBase, Component::Xml::DOM_Document
    [FieldOffset(0x0000)] public nint VTable; // 0x01076FC0 (3 vfuncs)
}

[Rtti(".?AVXmlElemenBase@Xml@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XmlElemenBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01076EE4 (8 vfuncs)
}

[Rtti(".?AVXmlElement@Xml@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct XmlElement
{
    // Inherits: Object → AllocatorBase, Component::Xml::DOM_Element
    [FieldOffset(0x0000)] public nint VTable; // 0x01079F1C (3 vfuncs)
}
