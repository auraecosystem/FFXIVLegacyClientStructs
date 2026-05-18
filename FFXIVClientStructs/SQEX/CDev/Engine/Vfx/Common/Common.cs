using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Vfx.Common
{
    namespace Camera
    {
        [Rtti(".?AVD2Camera@Camera@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct D2Camera
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113DFBC (27 vfuncs)
        }

        [Rtti(".?AVSphereCamera@Camera@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct SphereCamera
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113DECC (27 vfuncs)
        }
    }

    namespace Io
    {
        [Rtti(".?AVPrinter@Io@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Printer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F5763C (1 vfuncs)
        }
    }

    namespace Map
    {
        [Rtti(".?AVBaseMap@Map@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BaseMap
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F576B4 (12 vfuncs)
        }

        [Rtti(".?AVResourceIdMap@Map@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceIdMap
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113E6F4 (12 vfuncs)
        }

        [Rtti(".?AVResourceMap@Map@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ResourceMap
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113E264 (12 vfuncs)
        }
    }

    namespace Memory
    {
        [Rtti(".?AVHandle@Memory@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Handle
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B98CC (19 vfuncs)
        }

        [Rtti(".?AVLinkHandle@Memory@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LinkHandle
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B9A4C (20 vfuncs)
        }

        [Rtti(".?AVMemoryMap@Memory@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct MemoryMap
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F57678 (14 vfuncs)
        }
    }

    namespace Pool
    {
        [Rtti(".?AVUsIntPool@Pool@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct UsIntPool
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113E600 (2 vfuncs)
        }
    }

    namespace Thread
    {
        [Rtti(".?AVBaseThread@Thread@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BaseThread
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113DE3C (2 vfuncs)
        }

        [Rtti(".?AVMutex@Thread@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Mutex
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113DE24 (1 vfuncs)
        }

        [Rtti(".?AVUnlockCondition@Thread@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct UnlockCondition
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113E02C (1 vfuncs)
        }

        [Rtti(".?AVWorkerThread@Thread@Common@Vfx@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct WorkerThread
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0113E7E0 (2 vfuncs)
        }
    }
}
