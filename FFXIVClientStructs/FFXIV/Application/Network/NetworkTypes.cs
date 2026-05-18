using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Network;

// ============================================================================
// Top-level network module types.
//
// PM cross-ref session model:
//   - Session.sessionId maps to SubPacketHeader.targetId
//   - Session.Channel: ZONE or CHAT (two separate connections)
//   - Session tracks: characterName, currentZoneId, activeLinkshellName,
//     languageCode, actorInstanceList (visible actors), isUpdatesLocked
//   - World server routes SubPackets to zone servers by session routing table
// ============================================================================

[Rtti(".?AVNetworkModule@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct NetworkModule
{
    [FieldOffset(0x00)] public nint VTable; // 0x00F91B5C (1 vfunc)
}

[Rtti(".?AVLobbyClientModule@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct LobbyClientModule
{
    [FieldOffset(0x00)] public nint VTable; // 0x00F91AAC (1 vfunc)
}

[Rtti(".?AVMyGameLoginCallback@Network@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe struct MyGameLoginCallback
{
    // PM: SelectCharacterConfirmPacket payload (0x98 bytes) received after
    //   character selection. Contains: characterId (uint), sessionToken (64 bytes),
    //   worldIp (32 bytes), worldPort (ushort). Client connects to worldIp:worldPort
    //   with sessionToken to enter the game world.
    [FieldOffset(0x00)] public nint VTable; // 0x00F91AB4 (22 vfuncs)
}
