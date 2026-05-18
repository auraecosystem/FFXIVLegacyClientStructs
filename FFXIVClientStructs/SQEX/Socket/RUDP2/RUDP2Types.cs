using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqex.Socket.RUDP2;

// ============================================================================
// RUDP2 — Square Enix custom Reliable UDP protocol
//
// Segment types follow standard RUDP (RFC 908/1151) naming:
//   SYN  — connection initiation (carries MSS + max outstanding segments)
//   ACK  — acknowledgement (carries acked sequence number)
//   DAT  — data payload (carries sequence number + payload bytes)
//   EAK  — extended/selective acknowledgement (out-of-order segment recovery)
//   NUL  — keepalive/heartbeat (no payload)
//   RST  — connection reset (teardown)
//
// All segments inherit from RUDPSegment (5 vfuncs).
// RUDPImpl manages the state machine and retransmission.
//
// PM note: Project Meteor uses TCP directly (no RUDP). The RUDP2 layer exists
// only in the client binary's Crystal Tools engine. The PM server accepts raw
// TCP and frames BasePacket/SubPacket headers directly on the stream. The
// client's RUDP2 layer sits below this framing — it provides reliable delivery
// over UDP, then the IPC channel layer handles BasePacket/SubPacket parsing.
// ============================================================================

[Rtti(".?AVRUDPSegment@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct RUDPSegment
{
    [FieldOffset(0x00)] public nint VTable; // 0x01114294 (5 vfuncs)

    // vt[0] = 0x00D51A80 (31B) — destructor
    // vt[1] = 0x009D364D (76B) — serialize?
    // vt[2] = 0x009D364D (76B) — deserialize?
    // vt[3] = 0x00D51960 (5B)  — getType (STUB in base)
    // vt[4] = 0x00D51970 (22B) — getSize
}

[Rtti(".?AVSYNSegment@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct SYNSegment
{
    [FieldOffset(0x00)] public nint VTable; // 0x01114324 (5 vfuncs)
    // SYN carries: max segment size, max outstanding segments, connection options
}

[Rtti(".?AVACKSegment@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x24)]
public unsafe struct ACKSegment
{
    [FieldOffset(0x00)] public nint VTable; // 0x011142AC (5 vfuncs)
    // ACK carries: acknowledged sequence number
}

[Rtti(".?AVDATSegment@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct DATSegment
{
    [FieldOffset(0x00)] public nint VTable; // 0x011142DC (5 vfuncs)
    // DAT carries: sequence number, data payload
}

[Rtti(".?AVEAKSegment@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x28)]
public unsafe struct EAKSegment
{
    [FieldOffset(0x00)] public nint VTable; // 0x011142F4 (5 vfuncs)
    // EAK = Extended ACK (selective acknowledgement of out-of-order segments)
}

[Rtti(".?AVNULSegment@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct NULSegment
{
    [FieldOffset(0x00)] public nint VTable; // 0x0111430C (5 vfuncs)
    // NUL = keepalive heartbeat, no payload
}

[Rtti(".?AVRSTSegment@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x24)]
public unsafe struct RSTSegment
{
    [FieldOffset(0x00)] public nint VTable; // 0x011142C4 (5 vfuncs)
    // RST = connection reset
}

[Rtti(".?AVRUDPImpl@RUDP2@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x300)]
public unsafe struct RUDPImpl
{
    // Inherits: SocketCallbackHandler, SocketInfomationReport
    [FieldOffset(0x00)] public nint VTable; // 0x01113378 (14 vfuncs)

    // RUDP state machine: manages SYN/ACK handshake, segment retransmission,
    // selective acknowledgement (EAK), keepalive (NUL), and connection teardown (RST).
    // Wraps SocketBase for raw UDP I/O.
}
