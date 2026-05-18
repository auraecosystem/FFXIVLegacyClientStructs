using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Network;

// ============================================================================
// LobbyProtoChannel — Lobby server IPC (login, character select, world entry)
//
// 14 packet opcodes (vs Zone's 199). Handles:
//   - Service login (PlayOnline → game server auth)
//   - Lobby login (character list retrieval)
//   - Character operations (create, delete, rename)
//   - Game login (world server entry, zone transfer handoff)
//
// Has its own encryption layer (LobbyCryptEngine) for the auth flow.
// ============================================================================

[Rtti(".?AVServiceConsumerConnectionManager@LobbyProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x140)]
public unsafe struct LobbyConnectionManager
{
    // Inherits: ConnectionManagerTmpl<TLobbyDown, TLobbyUp> → ConnectionManager
    [FieldOffset(0x00)] public nint VTable; // 0x01127714 (4 vfuncs)
}

[Rtti(".?AVLobbyCryptEngine@ServiceConsumerConnectionManager@LobbyProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct LobbyCryptEngine
{
    // Inherits: CryptEngineInterface
    [FieldOffset(0x00)] public nint VTable; // 0x01127698 (9 vfuncs)
}

[Rtti(".?AVRaptureChannelManager@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)]
public unsafe struct LobbyChannelManager
{
    // Inherits: ChannelManagerOnSingleConnectionTmpl → ChannelManagerTmpl_LF → ChannelManagerCoreTmpl
    [FieldOffset(0x00)] public nint VTable; // 0x0112869C (25 vfuncs)
}

[Rtti(".?AVClientPacketBuilder@LobbyProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct LobbyClientPacketBuilder
{
    // Inherits: LobbyProtoUpPacketBuilder → PacketDataBuilder
    [FieldOffset(0x00)] public nint VTable; // 0x01127754 (4 vfuncs)
}

[Rtti(".?AVLobbyProtoDownDummyCallback@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct LobbyProtoDownCallback
{
    // 14 vfuncs — one handler per server→client lobby packet opcode
    // Inherits: LobbyProtoDownCallbackInterface → RecvCallbackInterface
    [FieldOffset(0x00)] public nint VTable; // 0x01128468 (14 vfuncs)
}

[Rtti(".?AVLobbyProtoDownCallbackInterface@LobbyProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct LobbyProtoDownCallbackInterface
{
    [FieldOffset(0x00)] public nint VTable; // 0x01127784 (14 vfuncs)
}

// Lobby client operations — login sequence state machines

[Rtti(".?AVOperationStep@LobbyClientMixin@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct LobbyOperationStep
{
    // Base for all lobby operation steps (23 vfuncs)
    // Inherits: LobbyRequestCallback
    [FieldOffset(0x00)] public nint VTable; // 0x01127F44
}

[Rtti(".?AVInitOperationStep@LobbyClientMixin@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe struct LobbyInitStep
{
    [FieldOffset(0x00)] public nint VTable; // 0x01128024 (23 vfuncs)
}

[Rtti(".?AVServiceLoginOperationStep@LobbyClientMixin@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe struct LobbyServiceLoginStep
{
    [FieldOffset(0x00)] public nint VTable; // 0x011280E4 (23 vfuncs)
}

[Rtti(".?AVLobbyLoginOperationStep@LobbyClientMixin@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe struct LobbyLoginStep
{
    [FieldOffset(0x00)] public nint VTable; // 0x01128084 (23 vfuncs)
}

[Rtti(".?AVGameLoginOperationStep@LobbyClientMixin@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe struct LobbyGameLoginStep
{
    [FieldOffset(0x00)] public nint VTable; // 0x01128144 (23 vfuncs)
}

[Rtti(".?AVLobbyCharaOperationStep@LobbyClientMixin@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe struct LobbyCharaOperationStep
{
    [FieldOffset(0x00)] public nint VTable; // 0x011281A4 (23 vfuncs)
}

// Lobby operation types

[Rtti(".?AVLobbyLoginOperation@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct LobbyLoginOperation
{
    [FieldOffset(0x00)] public nint VTable; // 0x01127FA4 (5 vfuncs)
}

[Rtti(".?AVServiceLoginOperation@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ServiceLoginOperation
{
    [FieldOffset(0x00)] public nint VTable; // 0x01127FBC (5 vfuncs)
}

[Rtti(".?AVGameLoginOperation@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct GameLoginOperation
{
    [FieldOffset(0x00)] public nint VTable; // 0x01127FEC (5 vfuncs)
}

[Rtti(".?AVCharaMakeOperation@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct CharaMakeOperation
{
    [FieldOffset(0x00)] public nint VTable; // 0x01127FD4 (5 vfuncs)
}

// Lobby operation parameters

[Rtti(".?AVLobbyLoginParam@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct LobbyLoginParam
{
    [FieldOffset(0x00)] public nint VTable; // 0x00F91AA0 (2 vfuncs)
}

[Rtti(".?AVGameLoginParam@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct GameLoginParam
{
    [FieldOffset(0x00)] public nint VTable; // 0x01127F38 (2 vfuncs)
}

[Rtti(".?AVCharaMakeParam@LobbyClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct CharaMakeParam
{
    [FieldOffset(0x00)] public nint VTable; // 0x01127F2C (2 vfuncs)
}
