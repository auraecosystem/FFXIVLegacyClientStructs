using System.Runtime.InteropServices;

namespace FFXIVClientStructs.STD;

// MSVC std::map red-black tree node (x86)
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct StdMapNode<TKey, TValue>
    where TKey : unmanaged
    where TValue : unmanaged
{
    [FieldOffset(0x00)] public StdMapNode<TKey, TValue>* Left;
    [FieldOffset(0x04)] public StdMapNode<TKey, TValue>* Parent;
    [FieldOffset(0x08)] public StdMapNode<TKey, TValue>* Right;
    [FieldOffset(0x0C)] public byte Color; // 0=red, 1=black
    [FieldOffset(0x0D)] public byte IsNil;
    // Key and Value follow at +0x10 but alignment varies
}

// MSVC std::map header (x86) - 12 bytes
[StructLayout(LayoutKind.Explicit, Size = 0x0C)]
public unsafe struct StdMap
{
    [FieldOffset(0x00)] public nint Head;   // _Myhead (sentinel node)
    [FieldOffset(0x04)] public uint Size;   // _Mysize
    // allocator at +0x08
}
