using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Lay.Stella
{
    [Rtti(".?AVLayoutMemoryObject@Stella@Lay@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LayoutMemoryObject
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x00F56498 (1 vfunc)
    }

    namespace API.Interfaces
    {
        [Rtti(".?AVILayoutSystem@Interfaces@API@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ILayoutSystem
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A1DDC (16 vfuncs)
        }
    }

    namespace Common
    {
        [Rtti(".?AVChronograph@Common@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Chronograph
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A8CB0 (1 vfunc)
        }

        [Rtti(".?AVPeriod@Chronograph@Common@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Chronograph_Period
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A8CA8 (1 vfunc)
        }

        [Rtti(".?AVPeriodPool@Chronograph@Common@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Chronograph_PeriodPool
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A8B00 (1 vfunc)
        }

        [Rtti(".?AVFixedMemory@Common@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct FixedMemory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F564A0 (1 vfunc)
        }

        [Rtti(".?AVPointerMapBase@Common@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct PointerMapBase
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A85EC (1 vfunc)
        }

        [Rtti(".?AVPropertyMap@Common@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct PropertyMap
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A87F0 (1 vfunc)
        }

        [Rtti(".?AVStatisticsInfo@Common@Stella@Lay@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct StatisticsInfo
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A87C8 (1 vfunc)
        }

        namespace PAX
        {
            [Rtti(".?AVTFixedArrayedList@PAX@Common@Stella@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct TFixedArrayedList
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109FB20 (1 vfunc)
            }

            [Rtti(".?AVIListElemVisitor@TFixedArrayedList@PAX@Common@Stella@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct TFixedArrayedList_IListElemVisitor
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x0109FABC (4 vfuncs)
            }
        }

        namespace StatisticsUtils
        {
            [Rtti(".?AVHistogram@StatisticsUtils@Common@Stella@Lay@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct Histogram
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x010A8710 (1 vfunc)
            }
        }
    }
}
