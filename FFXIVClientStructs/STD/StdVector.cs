using System.Runtime.InteropServices;

namespace FFXIVClientStructs.STD;

// MSVC std::vector<T> (x86) - 12 bytes
[StructLayout(LayoutKind.Explicit, Size = 0x0C)]
public unsafe struct StdVector<T> where T : unmanaged
{
    [FieldOffset(0x00)] public T* First;
    [FieldOffset(0x04)] public T* Last;
    [FieldOffset(0x08)] public T* End;

    public int Count => First == null ? 0 : (int)(Last - First);
    public int Capacity => First == null ? 0 : (int)(End - First);

    public ref T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();
            return ref First[index];
        }
    }
}
