using System.Runtime.InteropServices;

namespace FFXIVClientStructs.STD;

// MSVC std::string (x86) with SSO - 28 bytes
[StructLayout(LayoutKind.Explicit, Size = 0x1C)]
public unsafe struct StdString
{
    // SSO buffer / heap pointer union
    [FieldOffset(0x00)] public fixed byte Buffer[16];
    [FieldOffset(0x00)] public byte* HeapPtr;
    [FieldOffset(0x10)] public uint Length;
    [FieldOffset(0x14)] public uint Capacity;

    public bool IsHeapAllocated => Capacity >= 16;

    public byte* DataPtr
    {
        get
        {
            fixed (byte* buf = Buffer)
                return IsHeapAllocated ? HeapPtr : buf;
        }
    }

    public override string ToString()
    {
        if (Length == 0) return string.Empty;
        return Marshal.PtrToStringAnsi((nint)DataPtr, (int)Length) ?? string.Empty;
    }
}
