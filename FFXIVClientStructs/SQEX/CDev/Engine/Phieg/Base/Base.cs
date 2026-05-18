using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Phieg.Base
{
    namespace Memory
    {
        [Rtti(".?AVCDevMemoryAllocator@Memory@Base@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CDevMemoryAllocator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F552D0 (4 vfuncs)
        }

        [Rtti(".?AVDefaultCompactionMemory@Memory@Base@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DefaultCompactionMemory
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010A8F20 (3 vfuncs)
        }

        [Rtti(".?AVDefaultMemoryAllocator@Memory@Base@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct DefaultMemoryAllocator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F570B4 (4 vfuncs)
        }

        [Rtti(".?AVIMemoryAllocator@Memory@Base@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IMemoryAllocator
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x00F552BC (4 vfuncs)
        }
    }

    namespace Misc
    {
        [Rtti(".?AVIDebugRenderable@Misc@Base@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IDebugRenderable
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109BD7C (19 vfuncs)
        }

        [Rtti(".?AVIMessageHandler@Misc@Base@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IMessageHandler
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x0109BD6C (2 vfuncs)
        }
    }

    namespace Threading
    {
        [Rtti(".?AVIRunnable@Threading@Base@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct IRunnable
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA0AC (2 vfuncs)
        }

        [Rtti(".?AVWin32Thread@Threading@Base@Phieg@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct Win32Thread
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AA0C0 (1 vfuncs)
        }
    }
}
