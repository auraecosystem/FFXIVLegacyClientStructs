using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Script.Lua;

// Application::Script::Lua — Lua scripting engine integration
// 166 Lua bindings extracted from 0x00FD7A00-0x00FD8A00
//
// === Character/Actor API (CharaBase) ===
// _getPosition              — Vec3 position
// _getDirection             — facing direction
// _getOrientation           — full orientation
// _getLocation              — map/zone location
// _getStaticActorID         — persistent actor identifier
// _getDisplayName           — rendered name string
// _getLocalizedDisplayName  — localized name
// _getNameIndex             — name table index
// _getKind                  — actor type/kind
// _getGear                  — equipment data
// _getEquippingSlot         — specific equipment slot
//
// === Stats ===
// _getActorMainStat         — primary stats (STR/DEX/VIT/INT/MND/PIE)
// _getActorExtraStat        — secondary stats
// _getSubStatWaste          — waste sub-stat
// _getSubStatGuard          — guard/defense sub-stat
// _getSubStatChant          — chant sub-stat
// _getSubStatObject         — object sub-stat
// _getSubStatBreakage       — breakage sub-stat
// _getSubStatMotionPack     — motion pack sub-stat
// _getSubStatStatus         — status sub-stat
// _getSubStatMode           — sub-stat calculation mode
// _getGrandOnExtraStat      — grand company extra stat
// _getNetStatUser           — network user stat
// _getNetStatSystem         — network system stat
// _getSystemFlag            — system flags
//
// === Party/Group ===
// _getMember                — party member by index
// _countMember              — party size
// _isMember                 — membership check
// _isExistInClientMember    — client-side membership
// _isExistInWorldMember     — world-side membership
// _getMemberLocation        — member location
// _getMemberDisplayName     — member name
// _getGroup                 — group object
// _getAllGroup               — all groups
//
// === Target ===
// _getTargetCharacter       — current target actor
// _getCharacterByDisplayNameForTextCommand — lookup by name
// _getCurrentTargetCursor   — target cursor state
// _isTargetCursorControlEnabled — cursor control
// _getLookAtCharacter       — look-at target
// _getLastAttacker          — last attacker
//
// === Items/Inventory ===
// _getItem / _getAllItem    — inventory items
// _getEquippingItem        — equipped item
// _getCatalogID            — item catalog ID
// _getMaxStack             — max stack size
// _isStackable / _countStack
// _isRare                  — rare flag
// _getPackage / _getOwner  — item container
// _isLocking / _getLockingInfo
// _isDealing / _getDealingInfo / _getDealingAttached
// _isTrading / _getTradingItem
// _getItemPackageCapacity  — inventory capacity
// _getItemPackageFreeSpace — free slots
//
// === Interaction ===
// _isTalkable / _isEmotable / _isPushable / _isMapObj
// _isPushing / _isEnmity
// _isAccessibleInServer
// _play                     — play animation/emote
// _getEventPriority
//
// === UI/Widget ===
// _getParentWidget          — parent UI widget
// _getChildWidget           — child by index
// _countChildWidgets        — child count
// _getKeyboardFocusedWidget — focused widget
// _setKeyboardFocusedWidget — set focus
// _getWidgetContainerSize   — container dimensions
// _createWidgetInWidgetContainer
//
// === Config/Settings ===
// _getUserConfig            — user configuration
// _getUserMacroTitle/Icon/Data — user macros
// _parseTextCommand         — text command parser
//
// === Character Creation ===
// _canCreateActorByName     — name availability check
// _isInstanceOf             — type check
// _getMyPlayer              — local player reference
// _getFloatingOffset        — nameplate offset
// _isNameplateVisible       — nameplate visibility
// _setNameplateIcon/Gauge/Visible — nameplate control
// _setDisplayName           — override display name
//
// === Scoring/Achievements ===
// _encodeBonusPoint / _decodeBonusPoint
// _getAchievementTitle
// _getGMRank / _getBelongGrandCompany / _getGrandCompanyRank
//
// === Time/World ===
// _getServerTime            — server timestamp
// _getHydaelynHour/Day/Time/Moon — Eorzean time
// _getAreaType              — area classification
// _getRegion / _getZoneName — zone info
// _canRideChocobo / _isWarpRideChocobo — mount checks
// _canStealth               — stealth availability
// _isInn                    — inn flag
// _getSpecialEventWork      — event work data
//
// === Cutscenes ===
// _getPlayingCutSceneActor / _getPendingCutSceneActor
// _getQuestActorForCutSceneReplay
//
// === Hamlet Defense ===
// _countHamletSupplyRanking / _getHamletSupplyRanking

[Rtti(".?AVActorInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ActorInformation
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVBooleanInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct BooleanInformation
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVArrayInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ArrayInformation
{
    [FieldOffset(0x00)] public nint VTable;
}

[Rtti(".?AVAssignInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct AssignInformation
{
    [FieldOffset(0x00)] public nint VTable;
}

// Application::IRapture — Main application interface
// Vtable: 0x00F8CC00 (4 vfuncs)
[Rtti(".?AVIRapture@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct IRapture
{
    [FieldOffset(0x00)] public nint VTable;
}
