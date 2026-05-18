using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Component.Network.IpcChannel;

// ============================================================================
// Component::Network::IpcChannel — Base framework for IPC protocol channels
//
// Architecture: each channel (Zone/Lobby/Chat) instantiates the same template
// infrastructure with its own protocol-specific up/down types:
//
//   PacketBufferBase → PacketBufferTmpl<TProto>
//   NetBufferBase → NetBufferTmpl<TProto> → NetBufferFactoryTmpl<TProto>
//   ConnectionManager → ConnectionManagerTmpl<TDown,TUp>
//   ChannelManagerBase → ChannelManagerCoreTmpl → ChannelManagerTmpl_LF → ChannelManagerOnSingleConnectionTmpl
//   EntityBase (data context)
//
// TProtoDown = server→client packets (receive/dispatch)
// TProtoUp   = client→server packets (build/send)
// ============================================================================

[Rtti(".?AVPacketBufferBase@IpcChannel@Network@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct PacketBufferBase
{
    [FieldOffset(0x00)] public nint VTable; // base (1 vfunc)
}

[Rtti(".?AVNetBufferBase@IpcChannel@Network@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct NetBufferBase
{
    [FieldOffset(0x00)] public nint VTable; // base (3 vfuncs)
}

[Rtti(".?AVConnectionManager@IpcChannel@Network@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public unsafe struct ConnectionManager
{
    [FieldOffset(0x00)] public nint VTable; // base for all channel-specific connection managers
}

[Rtti(".?AVChannelManagerBase@IpcChannel@Network@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x80)]
public unsafe struct ChannelManagerBase
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVEntityBase@IpcChannel@Network@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct EntityBase
{
    [FieldOffset(0x00)] public nint VTable;
}
