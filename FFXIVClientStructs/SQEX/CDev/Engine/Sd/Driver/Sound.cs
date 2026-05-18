using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Sd.Driver;

// SQEX::CDev::Engine::Sd — Sound engine (XAudio2-based)
// Driver hierarchy: Bank -> Bus -> Voice, all through XA2 backend

[Rtti(".?AVBank@Driver@Sd@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct Bank
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVBus@Driver@Sd@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct Bus
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVBankController@Driver@Sd@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct BankController
{
    [FieldOffset(0x00)] public nint VTable;
}
