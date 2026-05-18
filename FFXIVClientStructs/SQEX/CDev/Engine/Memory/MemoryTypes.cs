using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Memory
{
    [Rtti(".?AVComplexLink@Memory@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ComplexLink
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x00F56630 (11 vfuncs)
    }

    [Rtti(".?AVIAllocator@Memory@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IAllocator
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109D02C (4 vfuncs)
    }

    [Rtti(".?AVIModule@Memory@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IModule
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x00F56570 (11 vfuncs)
    }

    [Rtti(".?AVSystemHeap@Memory@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct SystemHeap
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x00F56600 (11 vfuncs)
    }

    namespace Alternative
    {
        [Rtti(".?AVIBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56740 (3 vfuncs)
        }

        [Rtti(".?AVIDebugBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IDebugBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56788 (10 vfuncs)
        }

        [Rtti(".?AVIDebugSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IDebugSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F567B4 (3 vfuncs)
        }

        [Rtti(".?AVIHandle@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IHandle
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56750 (13 vfuncs)
        }

        [Rtti(".?AVIHandleListener@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IHandleListener
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56CCC (3 vfuncs)
        }

        [Rtti(".?AVISpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ISpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F566FC (16 vfuncs)
        }

        [Rtti(".?AVLink@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Link
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F567C4 (2 vfuncs)
        }

        [Rtti(".?AVFixedAllocatorCompound@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct FixedAllocatorCompound
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F54FBC (1 vfunc)
        }

        [Rtti(".?AVHandle@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Handle
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A7E38 (2 vfuncs)
        }

        [Rtti(".?AVSeparateHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SeparateHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56818 (2 vfuncs)

            [Rtti(".?AVHandleListenerElement@SeparateHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct HandleListenerElement
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00F56824 (2 vfuncs)
            }
        }

        [Rtti(".?AVSeparateHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SeparateHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56834 (16 vfuncs)
        }

        [Rtti(".?AVDebugSeparateHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugSeparateHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56878 (10 vfuncs)
        }

        [Rtti(".?AVDebugSeparateHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugSeparateHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F568A4 (3 vfuncs)
        }

        [Rtti(".?AVRemovableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RemovableHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56DC8 (2 vfuncs)

            [Rtti(".?AVHandleListener@RemovableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct HandleListener
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00F56CF0 (3 vfuncs)
            }

            [Rtti(".?AVHandleListenerElement@RemovableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct HandleListenerElement
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00F56DD4 (2 vfuncs)
            }
        }

        [Rtti(".?AVRemovableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct RemovableHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56D3C (16 vfuncs)

            [Rtti(".?AVSerializer@RemovableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct Serializer
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00F56CE8 (1 vfunc)

                [Rtti(".?AVChunk@Serializer@RemovableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
                [StructLayout(LayoutKind.Explicit, Size = 0x08)]
                public unsafe struct Chunk
                {
                    [FieldOffset(0x0000)] public nint VTable; // 0x00F56CDC (2 vfuncs)
                }
            }
        }

        [Rtti(".?AVDebugRemovableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugRemovableHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56D00 (10 vfuncs)
        }

        [Rtti(".?AVDebugRemovableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugRemovableHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56D2C (3 vfuncs)
        }

        [Rtti(".?AVReceivableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ReceivableHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56E70 (2 vfuncs)

            [Rtti(".?AVHandleListenerElement@ReceivableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct HandleListenerElement
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00F56E7C (2 vfuncs)
            }

            [Rtti(".?AVResolveElement@ReceivableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ResolveElement
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00F56E88 (2 vfuncs)
            }
        }

        [Rtti(".?AVReceivableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ReceivableHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56DE4 (16 vfuncs)
        }

        [Rtti(".?AVDebugReceivableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugReceivableHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56E94 (10 vfuncs)
        }

        [Rtti(".?AVDebugReceivableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugReceivableHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56EC0 (3 vfuncs)
        }

        [Rtti(".?AVDetachableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DetachableHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56F60 (2 vfuncs)

            [Rtti(".?AVHandleListenerElement@DetachableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct HandleListenerElement
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00F56F6C (2 vfuncs)
            }

            [Rtti(".?AVResolveElement@DetachableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
            [StructLayout(LayoutKind.Explicit, Size = 0x08)]
            public unsafe struct ResolveElement
            {
                [FieldOffset(0x0000)] public nint VTable; // 0x00F56F78 (2 vfuncs)
            }
        }

        [Rtti(".?AVDetachableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DetachableHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56ED4 (16 vfuncs)
        }

        [Rtti(".?AVDebugDetachableHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugDetachableHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56F84 (10 vfuncs)
        }

        [Rtti(".?AVDebugDetachableHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugDetachableHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F56FB0 (3 vfuncs)
        }

        [Rtti(".?AVSystemHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SystemHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F5700C (2 vfuncs)
        }

        [Rtti(".?AVSystemHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SystemHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F5701C (16 vfuncs)
        }

        [Rtti(".?AVDebugSystemHeapBlock@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugSystemHeapBlock
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F57060 (10 vfuncs)
        }

        [Rtti(".?AVDebugSystemHeapSpace@Alternative@Memory@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DebugSystemHeapSpace
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F5708C (3 vfuncs)
        }
    }
}
