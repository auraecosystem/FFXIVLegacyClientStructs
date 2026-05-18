using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqwt
{
    // ============================================================================
    // Sqwt Visual Tree — The rendering/layout backbone
    //
    // Hierarchy: Visual → UIElement → FrameworkElement → Control → ...
    //
    // Mirrors WPF's visual tree. FrameworkElement adds layout (Margin, Width,
    // Height, HorizontalAlignment, VerticalAlignment), data context, resource
    // dictionaries, styles, and triggers. UIElement adds input routing and
    // rendering. Visual is the base for anything that can be drawn.
    // ============================================================================

    namespace Media
    {
        [Rtti(".?AVVisual@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x30)]
        public unsafe struct Visual
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0106C58C (23 vfuncs)
        }

        [Rtti(".?AVBrush@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Brush
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01068D74 (4 vfuncs)
        }

        [Rtti(".?AVSolidColorBrush@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
        public unsafe struct SolidColorBrush
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0106EC34 (4 vfuncs)
        }

        [Rtti(".?AVFontColorBrush@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
        public unsafe struct FontColorBrush
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01068D88 (4 vfuncs)
        }

        [Rtti(".?AVTransform@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Transform
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01068D9C (4 vfuncs)
        }

        [Rtti(".?AVRotateTransform@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x10)]
        public unsafe struct RotateTransform
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0107815C (4 vfuncs)
        }

        [Rtti(".?AVScaleTransform@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x10)]
        public unsafe struct ScaleTransform
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01078148 (4 vfuncs)
        }

        [Rtti(".?AVDrawingContext@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x40)]
        public unsafe struct DrawingContext
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FA2704 (44 vfuncs)
        }

        [Rtti(".?AVPen@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Pen
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010743FC (1 vfunc)
        }

        [Rtti(".?AVRaptureImageSource@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RaptureImageSource
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01078194 (2 vfuncs)
        }

        [Rtti(".?AVFormattedText@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct FormattedText
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FA94EC (1 vfunc)
        }

        [Rtti(".?AVFormattedText2@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct FormattedText2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00FA94F4 (1 vfunc)
        }

        [Rtti(".?AVHitTestParameters@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x04)]
        public unsafe struct HitTestParameters
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x01075A64 (1 vfunc)
        }

        [Rtti(".?AVPointHitTestParameters@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
        public unsafe struct PointHitTestParameters
        {
            // Inherits: HitTestParameters
            [FieldOffset(0x0000)] public nint VTable; // 0x01075A6C (1 vfunc)
        }

        [Rtti(".?AVPointHitTestResult@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x04)]
        public unsafe struct PointHitTestResult
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010691C8 (1 vfunc)
        }

        [Rtti(".?AVMatrix@Media@Sqwt@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x44)]
        public unsafe struct Matrix
        {
            // Inherits: SQEX::CDev::Engine::Math::Matrix
            [FieldOffset(0x0000)] public nint VTable; // 0x01077D18 (1 vfunc)
        }
    }

    [Rtti(".?AVUIElement@Sqwt@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public unsafe struct UIElement
    {
        // Inherits: Visual → DependencyObject
        [FieldOffset(0x0000)] public nint VTable; // 0x0106C3CC (39 vfuncs)
    }

    [Rtti(".?AVFrameworkElement@Sqwt@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public unsafe struct FrameworkElement
    {
        // Inherits: UIElement → Visual → DependencyObject
        [FieldOffset(0x0000)] public nint VTable; // 0x0106ACBC (65 vfuncs)
    }

    [Rtti(".?AVFrameworkContentElement@Sqwt@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct FrameworkContentElement
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0107886C (2 vfuncs)
    }

    [Rtti(".?AVInputElement@Sqwt@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public unsafe struct InputElement
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x01069A6C (72 vfuncs)
    }

    [Rtti(".?AVWindow@Sqwt@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public unsafe struct Window
    {
        // Inherits: ContentControl → Control → FrameworkElement → UIElement → Visual
        [FieldOffset(0x0000)] public nint VTable; // 0x0106A0BC (79 vfuncs)
    }

    [Rtti(".?AVSizeChangedInfo@Sqwt@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public unsafe struct SizeChangedInfo
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0106C278 (1 vfunc)
    }

    [Rtti(".?AVVector@Sqwt@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public unsafe struct Vector
    {
        // Inherits: SQEX::CDev::Engine::Math::Vector
        [FieldOffset(0x0000)] public nint VTable; // 0x010771C4 (1 vfunc)
    }
}
