using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt.Data;

// ============================================================================
// Sqwt::Data — Data binding and value converters
//
// WPF-style data binding. BindingBase/Binding connect UI properties to data
// sources. IValueConverter transforms values between source and target types.
// SqwtXmlDataMaker loads data from XML for binding. XmlAttr wraps DOM
// attributes for the binding system.
// ============================================================================

[Rtti(".?AVBindingBase@Data@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct BindingBase
{
    // Inherits: SharedItem → SharedItemBase, DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x01079C88 (4 vfuncs)
}

[Rtti(".?AVBinding@Data@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe struct Binding
{
    // Inherits: BindingBase → SharedItem → SharedItemBase
    [FieldOffset(0x0000)] public nint VTable; // 0x01079CD8 (6 vfuncs)
}

[Rtti(".?AVIValueConverter@Data@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct IValueConverter
{
    // Inherits: DependencyObject → DependencyObjectBase → Object
    [FieldOffset(0x0000)] public nint VTable; // 0x0107A1BC (18 vfuncs)
}

[Rtti(".?AVSqwtXmlDataMaker@Data@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct SqwtXmlDataMaker
{
    // Inherits: ResourceDictionary → DependencyObject
    [FieldOffset(0x0000)] public nint VTable; // 0x0106C904 (17 vfuncs)
}

[Rtti(".?AVXmlAttr@Data@Sqwt@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct XmlAttr
{
    // Inherits: Component::Xml::DOM_Attr → DOM_Node
    [FieldOffset(0x0000)] public nint VTable; // 0x0106C8CC (10 vfuncs)
}
