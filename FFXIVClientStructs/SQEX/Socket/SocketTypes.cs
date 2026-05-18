using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.Sqex.Socket;

// ============================================================================
// Sqex::Socket — Transport layer
// Custom WinSock2 abstraction with RUDP (Reliable UDP) protocol
// Stack: SocketBase → SocketWinsock → SocketImpl → RUDPSocket → RUDP2::RUDPImpl
//
// PM cross-ref: ClientConnection wraps a TCP Socket with:
//   - byte[0xFFFF] receive buffer (matches BUFFER_SIZE constant)
//   - CircularBuffer<byte> incomingStream (1024 bytes staging)
//   - BlockingCollection<BasePacket> SendPacketQueue (100 lobby, 1000 world)
//   - lastPartialSize (int) for fragmented packet reassembly
//   - Blowfish cipher state (lobby only, set after SecurityHandshake)
//
// Async receive flow: BeginReceive → ReceiveCallback → BuildPacket loop →
//   FlushQueuedSendPackets → re-arm BeginReceive. Partial packets preserved
//   across receive calls via lastPartialSize + buffer shift.
// ============================================================================

[Rtti(".?AVSocketBase@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x1A4)]
public unsafe struct SocketBase
{
    [FieldOffset(0x00)] public nint VTable; // 0x011132DC (18 vfuncs)

    // PM: ClientConnection.socket — one TCP socket per channel connection.
    [FieldOffset(0x04)] public int SocketHandle; // init -1 (INVALID_SOCKET)
    [FieldOffset(0x08)] public nint CallbackContext;

    // +0x0C: Sqex::Thread::Mutex (embedded)
    [FieldOffset(0x0C)] public nint MutexVTable; // Sqex::Thread::Mutex, vt=0x00F67878

    [FieldOffset(0x11)] public byte Initialized; // init 1

    // Stats counters block (+0x2C to +0x4C, all zero-init)
    [FieldOffset(0x2C)] public uint StatBytesSent;
    [FieldOffset(0x30)] public uint StatBytesReceived;
    [FieldOffset(0x34)] public uint StatPacketsSent;
    [FieldOffset(0x38)] public uint StatPacketsReceived;
    [FieldOffset(0x3C)] public uint StatRetransmits;
    [FieldOffset(0x40)] public uint StatDropped;
    [FieldOffset(0x44)] public uint StatErrors;
    [FieldOffset(0x48)] public uint StatTimeouts;
    [FieldOffset(0x4C)] public uint StatQueueDepth;

    // Protocol config — RUDP2 segment/window negotiated during SYN handshake.
    [FieldOffset(0x50)] public uint MaxSegmentSize;  // init 0x78 = 120 bytes (RUDP2 MSS)
    [FieldOffset(0x54)] public uint MaxWindowSize;   // init 0x708 = 1800 bytes (RUDP2 window)

    // More stats/state (+0x58 to +0x74, zero-init)
    [FieldOffset(0x58)] public uint SendQueueSize;
    [FieldOffset(0x5C)] public uint RecvQueueSize;
    [FieldOffset(0x60)] public uint PendingAcks;
    [FieldOffset(0x64)] public uint RetransmitCount;
    [FieldOffset(0x68)] public uint DuplicateCount;
    [FieldOffset(0x6C)] public uint OutOfOrderCount;
    [FieldOffset(0x70)] public uint WindowFull;
    [FieldOffset(0x74)] public uint FlowControl;

    // Timestamps
    [FieldOffset(0x78)] public uint TimestampA;
    [FieldOffset(0x7C)] public uint TimestampB;
    [FieldOffset(0x80)] public uint TimestampC;
    [FieldOffset(0x84)] public uint TimestampD;

    [FieldOffset(0x88)] public uint ConnectionFlags;
    [FieldOffset(0x8C)] public uint ConnectionState; // PM: connected/disconnected/handshaking
    [FieldOffset(0x90)] public nint BufferPtr;
    [FieldOffset(0x94)] public uint SequenceNumber; // init 0 — RUDP2 segment sequence tracking

    // +0x98: sub-object (no vtable, ctor 0x00452A40)
    [FieldOffset(0x9C)] public nint AllocatorPtr;
    [FieldOffset(0xA0)] public nint PollerRef;

    // +0xA4: sub-object (no vtable, ctor 0x008F0280)

    // Timing block
    [FieldOffset(0xB4)] public uint TimerA;
    [FieldOffset(0xB8)] public uint TimerB;
    [FieldOffset(0xBC)] public uint TimerC;
    [FieldOffset(0xC0)] public uint TimerD;

    // +0xC4, +0xB0: sub-objects (same ctor 0x00CC3B80 — likely send/recv ring buffers)
    [FieldOffset(0xC8)] public uint RingBufferHead;
    [FieldOffset(0xCC)] public uint RingBufferTail;
    [FieldOffset(0xD0)] public uint RingBufferCapacity;
    [FieldOffset(0xD4)] public uint RingBufferCount;

    // Send/recv buffer pointers
    // PM: byte[0xFFFF] buffer per connection + CircularBuffer<byte>(1024) staging.
    [FieldOffset(0xE0)] public nint SendBuffer;
    [FieldOffset(0xE8)] public nint RecvBuffer;
    [FieldOffset(0xEC)] public uint RecvBufferState; // init 0 — PM: lastPartialSize
    [FieldOffset(0xF0)] public nint BufferAllocA;
    [FieldOffset(0xF4)] public nint BufferAllocB;

    // Segmented buffer arrays (+0xF8 to +0x170 at 0x28 stride — likely 3 buffer slots)
    [FieldOffset(0xF8)] public nint BufferSlot0;
    [FieldOffset(0x120)] public nint BufferSlot1;
    [FieldOffset(0x148)] public nint BufferSlot2;
    [FieldOffset(0x170)] public nint BufferSlot3;

    // Endpoint info
    [FieldOffset(0x180)] public nint EndpointInfo;
    [FieldOffset(0x188)] public nint EndpointAddr;
    [FieldOffset(0x18C)] public uint EndpointState;
    [FieldOffset(0x190)] public nint EndpointExtra;
    [FieldOffset(0x194)] public nint EndpointExtra2;
    [FieldOffset(0x198)] public nint ContextA;
    [FieldOffset(0x19C)] public nint ContextB;
    [FieldOffset(0x1A0)] public uint ContextFlags;
}

[Rtti(".?AVSocketImpl@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x1B0)]
public unsafe struct SocketImpl
{
    // Inherits: SocketWinsock → SocketBase
    [FieldOffset(0x00)] public nint VTable; // 0x0111332C (18 vfuncs, overrides SocketBase)
}

[Rtti(".?AVRUDPSocket@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x200)]
public unsafe struct RUDPSocket
{
    // Inherits: SocketCallbackHandler, SocketInfomationReport
    [FieldOffset(0x00)] public nint VTable; // 0x011134DC (16 vfuncs)
}

// ============================================================================
// Sqex::Socket::PollerBase — Socket I/O multiplexing (select/poll)
// ============================================================================

[Rtti(".?AVPollerBase@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct PollerBase
{
    [FieldOffset(0x00)] public nint VTable; // 0x01116FFC (9 vfuncs)
}

[Rtti(".?AVPollerImpl@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x50)]
public unsafe struct PollerImpl
{
    // Inherits: PollerWinsock → PollerBase
    [FieldOffset(0x00)] public nint VTable; // 0x01114254 (9 vfuncs)
}

[Rtti(".?AVPeerSocket@PollerBase@Socket@Sqex@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct PollerPeerSocket
{
    [FieldOffset(0x00)] public nint VTable; // 0x0111427C (1 vfunc)
}
