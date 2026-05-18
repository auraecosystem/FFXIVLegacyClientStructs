using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Network;

// ============================================================================
// ChatProtoChannel — Chat server IPC
//
// Separate from Zone channel. 10 packet opcodes covering:
//   - Say, Shout, Tell, Party chat
//   - Linkshell messages
//   - System messages
//   - GM communication
//
// Has its own SocketThread and connection lifecycle independent of Zone.
// ============================================================================

[Rtti(".?AVSocketThread@ChatProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct ChatSocketThread
{
    // Inherits: Sqex::Thread, NonCopyable
    [FieldOffset(0x00)] public nint VTable; // 0x011291E0 (4 vfuncs)
}

[Rtti(".?AVServiceConsumerConnectionManager@ChatProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x120)]
public unsafe struct ChatConnectionManager
{
    // Inherits: ConnectionManagerTmpl<TChatDown, TChatUp> → ConnectionManager
    [FieldOffset(0x00)] public nint VTable; // 0x01129248 (4 vfuncs)
}

[Rtti(".?AVRaptureChannelManager@ChatClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)]
public unsafe struct ChatChannelManager
{
    // Inherits: ChannelManagerOnSingleConnectionTmpl → ChannelManagerTmpl_LF → ChannelManagerCoreTmpl
    [FieldOffset(0x00)] public nint VTable; // 0x011295A4 (26 vfuncs)
}

[Rtti(".?AVClientPacketBuilder@ChatProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ChatClientPacketBuilder
{
    // Inherits: ChatProtoUpPacketBuilder → PacketDataBuilder
    [FieldOffset(0x00)] public nint VTable; // 0x0113E8D0 (4 vfuncs)
}

[Rtti(".?AVChatProtoDownDummyCallback@ChatClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct ChatProtoDownCallback
{
    // 10 vfuncs — one handler per server→client chat packet opcode
    // Inherits: ChatProtoDownCallbackInterface → RecvCallbackInterface
    [FieldOffset(0x00)] public nint VTable; // 0x01129360 (10 vfuncs)
}
