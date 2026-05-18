using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Network;

// ============================================================================
// ZoneProtoChannel — Game world IPC (zone server communication)
//
// The primary gameplay network channel. Handles all in-game packet types
// including movement, combat, inventory, status effects, NPC interaction, etc.
//
// The ZoneProtoDownDummyCallback has 199 virtual functions — one per
// server→client packet opcode. This is the most complex channel by far.
// ============================================================================

[Rtti(".?AVSocketThread@ZoneProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct ZoneSocketThread
{
    // Inherits: Sqex::Thread, NonCopyable
    [FieldOffset(0x00)] public nint VTable; // 0x01129710 (4 vfuncs)
}

[Rtti(".?AVServiceConsumerConnectionManager@ZoneProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x120)]
public unsafe struct ZoneConnectionManager
{
    // Inherits: ConnectionManagerTmpl<TZoneDown, TZoneUp> → ConnectionManager
    [FieldOffset(0x00)] public nint VTable; // 0x01129768 (4 vfuncs)
}

[Rtti(".?AVRaptureChannelManager@ZoneClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)]
public unsafe struct ZoneChannelManager
{
    // Inherits: ChannelManagerOnSingleConnectionTmpl → ChannelManagerTmpl_LF → ChannelManagerCoreTmpl
    [FieldOffset(0x00)] public nint VTable; // 0x01129094 (25 vfuncs)
}

[Rtti(".?AVClientPacketBuilder@ZoneProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ZoneClientPacketBuilder
{
    // Inherits: ZoneProtoUpPacketBuilder → PacketDataBuilder
    [FieldOffset(0x00)] public nint VTable; // 0x01129AE8 (4 vfuncs)
}

[Rtti(".?AVZoneProtoDownDummyCallback@ZoneClient@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct ZoneProtoDownCallback
{
    // 199 vfuncs — one handler per server→client zone packet opcode.
    // Inherits: ZoneProtoDownCallbackInterface → RecvCallbackInterface
    //
    // PM cross-ref (key opcodes → vfunc slot):
    //   0x00CA AddActor, 0x00CB RemoveActor, 0x00CE SetActorPosition,
    //   0x00D6 SetActorAppearance, 0x0134 SetActorState, 0x0137 SetActorProperty,
    //   0x0139 CommandResultX01, 0x013A CommandResultX10, 0x0144 SetActorSubState,
    //   0x0177 SetActorStatus, 0x0179 SetActorStatusAll
    // Full enum: see ZoneOpcode in PacketOpcodes.cs
    [FieldOffset(0x00)] public nint VTable; // 0x01128B4C (199 vfuncs)
}

// Zone NetBuffer types (packet serialization/deserialization)

[Rtti(".?AVNetBufferTmpl@TZoneProtoDown@ZoneProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct ZoneDownNetBuffer
{
    [FieldOffset(0x00)] public nint VTable; // 0x01128EB4 (3 vfuncs)
}

[Rtti(".?AVNetBufferTmpl@TZoneProtoUp@ZoneProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct ZoneUpNetBuffer
{
    [FieldOffset(0x00)] public nint VTable; // 0x01128EA4 (3 vfuncs)
}

[Rtti(".?AVPacketBufferTmpl@TZoneProtoDown@ZoneProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe struct ZoneDownPacketBuffer
{
    [FieldOffset(0x00)] public nint VTable; // 0x00F91B30 (1 vfunc)
}

[Rtti(".?AVPacketBufferTmpl@TZoneProtoUp@ZoneProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe struct ZoneUpPacketBuffer
{
    [FieldOffset(0x00)] public nint VTable; // 0x01129ACC (1 vfunc)
}

[Rtti(".?AVNetBufferQueueCoreTmpl@TZoneProtoUp@ZoneProtoChannel@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct ZoneUpNetBufferQueue
{
    [FieldOffset(0x00)] public nint VTable; // 0x01128ECC (3 vfuncs)
}
