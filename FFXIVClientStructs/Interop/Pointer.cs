using System.Runtime.CompilerServices;

namespace FFXIVClientStructs.Interop;

public readonly unsafe struct Pointer<T> where T : unmanaged
{
    public readonly T* Value;

    public Pointer(T* value) => Value = value;

    public bool IsNull => Value == null;
    public ref T Ref => ref Unsafe.AsRef<T>(Value);

    public static implicit operator Pointer<T>(T* value) => new(value);
    public static implicit operator T*(Pointer<T> pointer) => pointer.Value;
    public static implicit operator bool(Pointer<T> pointer) => pointer.Value != null;

    public override string ToString() => $"0x{(nint)Value:X8}";
}
