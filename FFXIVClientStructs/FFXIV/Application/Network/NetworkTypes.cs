using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Network;

// SQEX::Socket::RUDP2::ACKSegment — custom reliable UDP transport
[Rtti(".?AVACKSegment@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct ACKSegment
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Network::Component::ConnectionManager
// Manages IPC connections to lobby/zone/chat servers
[Rtti(".?AVConnectionManager@IpcChannel@Network@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct ConnectionManager
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::Network::Component::ChannelManagerBase
[Rtti(".?AVChannelManagerBase@IpcChannel@Network@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct ChannelManagerBase
{
    [FieldOffset(0x00)] public nint VTable;
}

// Protocol channels (from RTTI):
//   ZoneProtoChannel — game world IPC
//   LobbyProtoChannel — lobby/character select IPC
//   ChatProtoChannel — chat system IPC
// Each has: ClientPacketBuilder, ServiceConsumerConnectionManager
