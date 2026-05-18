using System.Runtime.InteropServices;

namespace FFXIVClientStructs.FFXIV.Application.Network;

// ============================================================================
// Wire format structures — shared framing for all three IPC channels.
// Cross-referenced from Project Meteor: BasePacket.cs, SubPacket.cs.
//
// Transport stack: BasePacket → SubPacket[] → GameMessage (per-channel payload)
//
// PM constants:
//   BASEPACKET_SIZE  = 0x10 (16 bytes)
//   SUBPACKET_SIZE   = 0x10 (16 bytes)
//   GAMEMESSAGE_SIZE = 0x10 (16 bytes)
//   BUFFER_SIZE      = 0xFFFF (65535 bytes per-socket receive buffer)
//
// Encryption: Lobby channel uses Blowfish (16 rounds, 18-entry P-array, 4×256 S-boxes).
// Blowfish encrypts SubPacket data only (skips both headers). Key derived from
// SecurityHandshakePacket: ticketPhrase (0x40 bytes @ +0x34) + clientNumber (uint32).
// ============================================================================

// BasePacket connection type discriminator.
public enum ConnectionType : ushort
{
    Zone = 1, // TYPE_ZONE — map/zone server channel
    Chat = 2, // TYPE_CHAT — chat/world server channel
}

// SubPacket type discriminator — determines payload interpretation.
public enum SubPacketType : ushort
{
    SessionInit = 0x01,  // Hello/handshake (world server login, carries sessionId @ +0x14)
    Control0x02 = 0x02,  // Control response (fixed 0x28 bytes)
    GameMessage = 0x03,  // Opcode-dispatched game message (has GameMessageHeader)
    ServerPing = 0x07,   // Server keepalive ping (8 bytes: actorId + timestamp)
    ClientPong = 0x08,   // Client keepalive response (8 bytes: sessionId + timestamp)
    // >= 0x1000: World/inter-server routing (SessionBegin=0x1000, SessionEnd=0x1001, etc.)
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public struct BasePacketHeader
{
    [FieldOffset(0x00)] public byte IsAuthenticated; // 1 = Blowfish-encrypted, 0 = plaintext
    [FieldOffset(0x01)] public byte IsCompressed;    // 1 = zlib compressed, 0 = raw
    [FieldOffset(0x02)] public ushort ConnectionType; // see ConnectionType enum
    [FieldOffset(0x04)] public ushort PacketSize;     // total bytes including this header
    [FieldOffset(0x06)] public ushort NumSubPackets;
    [FieldOffset(0x08)] public ulong Timestamp;       // milliseconds since epoch (UTC)
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public struct SubPacketHeader
{
    [FieldOffset(0x00)] public ushort SubPacketSize; // total bytes including this header
    [FieldOffset(0x02)] public ushort Type;          // see SubPacketType enum
    [FieldOffset(0x04)] public uint SourceId;        // actor/character ID (sender)
    [FieldOffset(0x08)] public uint TargetId;        // session ID (recipient)
    [FieldOffset(0x0C)] public uint Unknown0C;       // always 0x00
}

[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public struct GameMessageHeader
{
    [FieldOffset(0x00)] public ushort Unknown00; // always 0x14
    [FieldOffset(0x02)] public ushort Opcode;    // see ZoneOpcode / LobbyOpcode enums
    [FieldOffset(0x04)] public uint Unknown04;   // always 0x00
    [FieldOffset(0x08)] public uint Timestamp;   // unix timestamp (seconds)
    [FieldOffset(0x0C)] public uint Unknown0C;   // always 0x00
}

// PM magic actor IDs used as sourceId in server-originated packets.
public static class PacketConstants
{
    public const uint LobbyServerActorId = 0xE0006868;
    public const uint PingActorId = 0x0E016EE5;
    public const int BufferSize = 0xFFFF; // 65535 bytes per-socket receive buffer
    public const int LobbyPort = 54994;   // FFXIV_LOBBY_PORT
}

// ============================================================================
// Zone server packet opcodes (server→client).
// Maps 1:1 with ZoneProtoDownCallback's 199 vfunc dispatch table.
// Cross-referenced from Project Meteor Map Server packet definitions.
// ============================================================================
public enum ZoneOpcode : ushort
{
    // System
    Pong = 0x0001,
    _0x02 = 0x0002,
    SendMessage = 0x0003,
    SetMap = 0x0005,
    DeleteAllActors = 0x0007,
    SetMusic = 0x000C,
    SetWeather = 0x000D,
    Logout = 0x000E,
    _0x0F = 0x000F,
    SetDalamud = 0x0010,
    Quit = 0x0011,

    // Actor management
    AddActor = 0x00CA,
    RemoveActor = 0x00CB,
    ActorInstantiate = 0x00CC,
    SetActorPosition = 0x00CE,
    MoveActorToPosition = 0x00CF,
    SetActorSpeed = 0x00D0,
    SetActorTargetAnimated = 0x00D3,
    SetActorAppearance = 0x00D6,
    SetActorBGProperties = 0x00D8,
    PlayBGAnimation = 0x00D9,
    PlayAnimationOnActor = 0x00DA,
    SetActorTarget = 0x00DB,
    ActorDoEmote = 0x00E1,
    _0xE2 = 0x00E2,
    ActorSpecialGraphic = 0x00E3,
    StartCountdown = 0x00E5,

    // Events
    EventStart = 0x012D,
    EventUpdate = 0x012E,
    KickEvent = 0x012F,
    RunEventFunction = 0x0130,
    EndEvent = 0x0131,
    _0x132 = 0x0132,

    // Data / state
    GenericData = 0x0133,
    SetActorState = 0x0134,
    SetEventStatus = 0x0136,
    SetActorProperty = 0x0137,
    CommandResultX01 = 0x0139,
    CommandResultX10 = 0x013A,
    CommandResultX18 = 0x013B,
    CommandResultX00 = 0x013C,
    SetActorName = 0x013D,
    DeleteGroup = 0x0143,
    SetActorSubState = 0x0144,
    SetActorIcon = 0x0145,

    // Inventory
    InventorySetBegin = 0x0146,
    InventorySetEnd = 0x0147,
    InventoryListX01 = 0x0148,
    InventoryListX08 = 0x0149,
    InventoryItemX16 = 0x014A,
    InventoryListX32 = 0x014B,
    InventoryListX64 = 0x014C,
    LinkedItemListX01 = 0x014D,
    LinkedItemListX08 = 0x014E,
    LinkedItemListX16 = 0x014F,
    LinkedItemListX32 = 0x0150,
    LinkedItemListX64 = 0x0151,
    InventoryRemoveX01 = 0x0152,
    InventoryRemoveX08 = 0x0153,
    InventoryRemoveX16 = 0x0154,
    InventoryRemoveX32 = 0x0155,
    InventoryRemoveX64 = 0x0156,

    // Game messages
    GameMessageWithActorX01 = 0x0157,
    GameMessageWithActorX02 = 0x0158,
    GameMessageWithActorX03 = 0x0159,
    GameMessageWithActorX04 = 0x015A,
    GameMessageWithActorX05 = 0x015B,
    GameMessageWithCustomSenderX01 = 0x015C,
    GameMessageWithCustomSenderX02 = 0x015D,
    GameMessageWithCustomSenderX03 = 0x015E,
    GameMessageWithCustomSenderX04 = 0x015F,
    GameMessageWithCustomSenderX05 = 0x0160,
    GameMessageWithDispIdSenderX01 = 0x0161,
    GameMessageWithDispIdSenderX02 = 0x0162,
    GameMessageWithDispIdSenderX03 = 0x0163,
    GameMessageWithDispIdSenderX04 = 0x0164,
    GameMessageWithDispIdSenderX05 = 0x0165,

    // Event conditions
    SetNoticeEventCondition = 0x016B,
    SetEmoteEventCondition = 0x016C,
    InventoryBeginChange = 0x016D,
    InventoryEndChange = 0x016E,
    SetPushEventConditionCircle = 0x016F,
    SetPushEventConditionFan = 0x0170,
    SetPushEventConditionTriggerBox = 0x0175,

    // Status effects
    SetActorStatus = 0x0177,
    SetActorStatusAll = 0x0179,
    SynchGroupWorkValues = 0x017A,
    SetActorIsZoning = 0x017B,

    // Groups
    GroupHeader = 0x017C,
    GroupMembersBegin = 0x017D,
    GroupMembersEnd = 0x017E,
    GroupMembersX08 = 0x017F,
    GroupMembersX16 = 0x0180,
    GroupMembersX32 = 0x0181,
    GroupMembersX64 = 0x0182,
    ContentMembersX08 = 0x0183,
    ContentMembersX16 = 0x0184,
    ContentMembersX32 = 0x0185,
    ContentMembersX64 = 0x0186,
    CreateNamedGroup = 0x0188,
    CreateNamedGroupMultiple = 0x0189,

    // Player data
    SetGrandCompany = 0x0194,
    SetSpecialEventWork = 0x0196,
    SetCurrentMountChocobo = 0x0197,
    SetChocoboName = 0x0198,
    SetHasChocobo = 0x0199,
    SetCompletedAchievements = 0x019A,
    SetLatestAchievements = 0x019B,
    SetAchievementPoints = 0x019C,
    SetPlayerTitle = 0x019D,
    AchievementEarned = 0x019E,
    SendAchievementRate = 0x019F,
    SetCurrentMountGoobbue = 0x01A0,
    SetHasGoobbue = 0x01A1,
    SetCutsceneBook = 0x01A3,
    SetCurrentJob = 0x01A4,
    SetPlayerItemStorage = 0x01A5,
    SetPlayerDream = 0x01A7,
}

// Lobby server→client packet opcodes.
// Maps 1:1 with LobbyProtoDownCallback's 14 vfunc dispatch table.
public enum LobbyOpcode : ushort
{
    Error = 0x0002,
    ServiceLoginReply = 0x0007,
    LobbyLoginReply = 0x0008,
    CharacterList = 0x000D,
    GameLoginReply = 0x000E,
    CharaMakeReply = 0x000F,
    ImportList = 0x0010,
    RetainerList = 0x0011,
    VersionInfo = 0x0012,
    WorldList = 0x0015,
}

// Lobby client→server packet opcodes.
// Sent via LobbyClientPacketBuilder.
public enum LobbyClientOpcode : ushort
{
    GetCharacters = 0x03,
    SelectCharacter = 0x04,
    SessionAcknowledgement = 0x05,
    ModifyCharacter = 0x0B,
}
