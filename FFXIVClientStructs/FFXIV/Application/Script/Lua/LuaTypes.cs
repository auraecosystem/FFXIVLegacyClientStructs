using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Script.Lua;

// ============================================================================
// Application::Script::Lua — Lua scripting engine integration
//
// 242 RTTI classes under Application::Lua::Script.
// 166 Lua API bindings registered in the 0x00749900–0x00757100 range.
//
// Architecture:
//   Component::Lua::GameEngine — Core Lua VM wrapper (LuaControl, LuaObject,
//     ErrorHandler 68 vfuncs, SharedWorkInterface 28 vfuncs, MemoryAllocator,
//     StackOperator variants, ResumeChecker, LuaThreadEndListener)
//
//   Application::Lua::Script::Client — Game-specific bindings:
//     - Control subclasses register the 166 API functions
//     - Command::Item — inventory update pipeline (9 command types, 10 vfuncs each)
//     - Command::Network — 50+ packet receivers (achievements, jobs, events, etc.)
//     - Command::System — sub-stat changes, chocobo, vehicle, debug
//     - ErrorHandler — 69 vfuncs (wraps GameEngine::ErrorHandler 68 vfuncs)
//     - ActorWorkSync — 3 vfuncs, syncs Lua state ↔ game actor
//
// Registration pattern: each binding is a PUSH <string_VA> followed by
// PUSH <handler_VA>, then CALL to the registration function.
// All string VAs point into .rdata at 0x00FD7A00–0x00FD8A00.
// ============================================================================

// ======================== World / Zone / Hamlet ========================
// Registration region: 0x007499D9–0x0074A459
public static class LuaWorldBindings
{
    public const uint GetStaticActorID = 0x007499D9;
    public const uint GetRegion = 0x00749B29;
    public const uint GetZoneName = 0x00749C79;
    public const uint CanRideChocobo = 0x00749DC9;
    public const uint IsWarpRideChocobo = 0x00749F19;
    public const uint CanStealth = 0x0074A069;
    public const uint IsInn = 0x0074A1B9;
    public const uint CountHamletSupplyRanking = 0x0074A309;
    public const uint GetHamletSupplyRanking = 0x0074A459;
}

// ======================== Character / Actor Core ========================
// Registration region: 0x0074A5A9–0x0074C289
public static class LuaCharaBindings
{
    public const uint GetPosition = 0x0074A5A9;
    public const uint GetDirection = 0x0074A6F9;
    public const uint GetOrientation = 0x0074A849;
    public const uint GetGear = 0x0074A999;
    public const uint GetActorMainStat = 0x0074AAE9;
    public const uint GetSubStatWaste = 0x0074AC39;
    public const uint GetSubStatGuard = 0x0074AD89;
    public const uint GetSubStatChant = 0x0074AED9;
    public const uint GetSubStatObject = 0x0074B029;
    public const uint GetSubStatBreakage = 0x0074B179;
    public const uint GetSubStatMotionPack = 0x0074B2C9;
    public const uint GetSubStatStatus = 0x0074B419;
    public const uint GetActorExtraStat = 0x0074B569;
    public const uint GetGrandOnExtraStat = 0x0074B6B9;
    public const uint GetNetStatUser = 0x0074B809;
    public const uint GetNetStatSystem = 0x0074B959;
    public const uint GetSystemFlag = 0x0074BAA9;
    public const uint IsAccessibleInServer = 0x0074BBF9;
    public const uint GetLocalizedDisplayName = 0x0074BD49;
    public const uint GetDisplayName = 0x0074BFE9;
    public const uint IsNameplateVisible = 0x0074C139;
    public const uint GetFloatingOffset = 0x0074C289;
}

// ======================== Location / Party / Score ========================
// Registration region: 0x0074C529–0x0074D789
public static class LuaPartyBindings
{
    public const uint GetLocation = 0x0074C529;
    public const uint GetLookAtCharacter = 0x0074C679;
    public const uint EncodeBonusPoint = 0x0074C919;
    public const uint DecodeBonusPoint = 0x0074CA69;
    public const uint GetMember = 0x0074CBB9;
    public const uint CountMember = 0x0074CD09;
    public const uint GetKind = 0x0074CE59;
    public const uint IsExistInClientMember = 0x0074CFA9;
    public const uint IsExistInWorldMember = 0x0074D0F9;
    public const uint IsMember = 0x0074D249;
    public const uint GetMemberLocation = 0x0074D399;
    public const uint GetMemberDisplayName = 0x0074D789;
}

// ======================== Items / Inventory ========================
// Registration region: 0x0074DB79–0x0074F1C9 (+ 0x00755DE9–0x007561D9)
public static class LuaItemBindings
{
    public const uint GetCatalogID = 0x0074DB79;
    public const uint GetMaxStack = 0x0074DCC9;
    public const uint IsStackable = 0x0074DE19;
    public const uint CountStack = 0x0074DF69;
    public const uint IsRare = 0x0074E0B9;
    public const uint GetPackage = 0x0074E359;
    public const uint GetOwner = 0x0074E4A9;
    public const uint GetNameIndex = 0x0074E5F9;
    public const uint IsLocking = 0x0074E749;
    public const uint GetLockingInfo = 0x0074E899;
    public const uint IsDealing = 0x0074E9E9;
    public const uint GetDealingInfo = 0x0074EC89;
    public const uint GetDealingAttached = 0x0074EDD9;
    public const uint IsTrading = 0x0074EF29;
    public const uint GetEquippingSlot = 0x0074F1C9;
    // Late-registered block
    public const uint GetItem = 0x00750229;
    public const uint GetAllItem = 0x00750379;
    public const uint GetEquippingItem = 0x00755DE9;
    public const uint GetItemPackageCapacity = 0x007560B9;
    public const uint GetItemPackageFreeSpace = 0x007561D9;
    public const uint GetTradingItem = 0x00756719;
}

// ======================== Grand Company / Achievements ========================
// Registration region: 0x0074F319–0x0074F709
public static class LuaGrandCompanyBindings
{
    public const uint GetGMRank = 0x0074F319;
    public const uint GetBelongGrandCompany = 0x0074F469;
    public const uint GetGrandCompanyRank = 0x0074F5B9;
    public const uint GetAchievementTitle = 0x0074F709;
}

// ======================== Interaction / Events ========================
// Registration region: 0x0074F8F9–0x00750B59
public static class LuaInteractionBindings
{
    public const uint Play = 0x0074F8F9;
    public const uint GetEventPriority = 0x0074FB99;
    public const uint GetPlayingCutSceneActor = 0x0074FE39;
    public const uint IsTalkable = 0x007504C9;
    public const uint IsEmotable = 0x00750619;
    public const uint IsPushable = 0x00750769;
    public const uint IsMapObj = 0x007508B9;
    public const uint IsPushing = 0x00750A09;
    public const uint IsEnmity = 0x00750B59;
}

// ======================== UI / Widgets ========================
// Registration region: 0x00750F49–0x007511E9 (+ 0x00757049)
public static class LuaWidgetBindings
{
    public const uint GetParentWidget = 0x00750F49;
    public const uint CountChildWidgets = 0x00751099;
    public const uint GetChildWidget = 0x007511E9;
    public const uint GetKeyboardFocusedWidget = 0x00751729;
    public const uint SetKeyboardFocusedWidget = 0x00751879;
    public const uint GetWidgetContainerSize = 0x007522F9;
    public const uint CreateWidgetInWidgetContainer = 0x00757049;
}

// ======================== Target / Cursor ========================
// Registration region: 0x00751339–0x007519C9
public static class LuaTargetBindings
{
    public const uint GetCurrentTargetCursor = 0x00751339;
    public const uint GetTargetCharacter = 0x00751489;
    public const uint GetCharacterByDisplayNameForTextCommand = 0x007515D9;
    public const uint IsTargetCursorControlEnabled = 0x007519C9;
    public const uint GetLastAttacker = 0x007521A9;
}

// ======================== Config / Macro / Text ========================
// Registration region: 0x00751B19–0x00752059
public static class LuaConfigBindings
{
    public const uint GetUserConfig = 0x00751B19;
    public const uint GetUserMacroTitle = 0x00751C69;
    public const uint GetUserMacroIcon = 0x00751DB9;
    public const uint GetUserMacroData = 0x00751F09;
    public const uint ParseTextCommand = 0x00752059;
}

// ======================== Player / Time / Cutscene ========================
// Registration region: 0x00752839–0x007536A9
public static class LuaPlayerBindings
{
    public const uint GetMyPlayer = 0x00752839;
    public const uint GetServerTime = 0x00752989;
    public const uint GetPendingCutSceneActor = 0x00752AD9;
    public const uint GetHydaelynHour = 0x00752C29;
    public const uint GetHydaelynDay = 0x00752D79;
    public const uint GetHydaelynTime = 0x00752EC9;
    public const uint GetHydaelynMoon = 0x00753019;
    public const uint GetSpecialEventWork = 0x007532B9;
    public const uint CanCreateActorByName = 0x00753409;
    public const uint IsInstanceOf = 0x00753559;
    public const uint GetQuestActorForCutSceneReplay = 0x007536A9;
    public const uint GetAreaType = 0x00753B29;
}

// ======================== Late-registered / Misc ========================
// Registration region: 0x00754F79–0x00755609
public static class LuaMiscBindings
{
    public const uint GetSubStatMode = 0x00754F79;
    public const uint SetDisplayName = 0x00755219;
    public const uint GetGroup = 0x00755369;
    public const uint GetAllGroup = 0x00755609;
}

// ======================== Nameplate (separate registration) ========================
// Registration region: 0x0072E979–0x0072EC19
public static class LuaNameplateBindings
{
    public const uint SetNameplateIcon = 0x0072E979;
    public const uint SetNameplateGauge = 0x0072EAC9;
    public const uint SetNameplateVisible = 0x0072EC19;
}

// ============================================================================
// Lua engine runtime types — GameEngine infrastructure
// ============================================================================

// Component::Lua::GameEngine::LuaObject — base for all Lua-visible objects (1 vfunc)
[Rtti(".?AVLuaObject@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct LuaObject
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110E300 (1 vfunc)
}

// Component::Lua::GameEngine::ErrorHandler — Lua error/exception handler (68 vfuncs)
[Rtti(".?AVErrorHandler@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct LuaErrorHandler
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110E564 (68 vfuncs)
}

// Application-level error handler override (69 vfuncs, adds 1 over base)
[Rtti(".?AVErrorHandler@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public unsafe struct AppErrorHandler
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FE0184 (69 vfuncs)
}

// SharedWorkInterface — Lua ↔ game state sync (28 vfuncs)
[Rtti(".?AVSharedWorkInterface@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct SharedWorkInterface
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FD404C (28 vfuncs)
}

// ActorWorkSync — syncs Lua actor state with game (3 vfuncs)
[Rtti(".?AVActorWorkSync@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ActorWorkSync
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FE044C (3 vfuncs)
}

// LuaManyTentativeControlCreator — factory for complex Lua controls (22 vfuncs)
[Rtti(".?AVLuaManyTentativeControlCreator@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct LuaManyTentativeControlCreator
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FD4EEC (22 vfuncs)
}

// ============================================================================
// Lua Work types — data containers for Lua ↔ game state
// All inherit: InitializeInformation → SetValueListenerInterface → LgeInformationBase
// All have 29 vfuncs.
// ============================================================================

[Rtti(".?AVActorInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ActorInformation
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110FF0C (29 vfuncs)
}

[Rtti(".?AVBooleanInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct BooleanInformation
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110FBC4 (29 vfuncs)
}

[Rtti(".?AVArrayInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct ArrayInformation
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110F804 (29 vfuncs)
}

[Rtti(".?AVArray2DInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct Array2DInformation
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110F87C (29 vfuncs)
}

[Rtti(".?AVAssignInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct AssignInformation
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110F78C (29 vfuncs)
}

[Rtti(".?AVFloatInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct FloatInformation
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110FE1C (29 vfuncs)
}

[Rtti(".?AVInteger8Information@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct Integer8Information
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110FC3C (29 vfuncs)
}

[Rtti(".?AVInteger16Information@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct Integer16Information
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110FCB4 (29 vfuncs)
}

[Rtti(".?AVInteger24Information@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct Integer24Information
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110FD2C (29 vfuncs)
}

[Rtti(".?AVInteger32Information@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct Integer32Information
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110FDA4 (29 vfuncs)
}

[Rtti(".?AVIndividualIndexInformation@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct IndividualIndexInformation
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110FFFC (29 vfuncs)
}

// ============================================================================
// Lua Memory subsystem — work memory containers and access control
// ============================================================================

[Rtti(".?AVContainerInterface@Memory@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct WorkMemoryContainerInterface
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110E1B4 (20 vfuncs)
}

[Rtti(".?AVContainerBase@Memory@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct WorkMemoryContainerBase
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110EE14 (20 vfuncs)
}

[Rtti(".?AVSingleThreadContainer@Memory@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct WorkSingleThreadContainer
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110EE6C (20 vfuncs)
}

[Rtti(".?AVMultiThreadContainer@Memory@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct WorkMultiThreadContainer
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110EEC4 (20 vfuncs)
}

[Rtti(".?AVOperator@Memory@Work@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct WorkMemoryOperator
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110E2AC (16 vfuncs)
}

// ============================================================================
// Lua Stack / Parameter system
// ============================================================================

[Rtti(".?AVStackOperatorInterface@Parameter@GameEngine@Lua@Component@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct StackOperatorInterface
{
    [FieldOffset(0x00)] public nint VTable; // 0x0110DF10 (9 vfuncs)
}

// ============================================================================
// Application::IRapture — Main application interface
// ============================================================================

[Rtti(".?AVIRapture@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct IRapture
{
    [FieldOffset(0x00)] public nint VTable; // 0x00F8CC00 (4 vfuncs)
}

// ============================================================================
// Lua Script Command system — packet receivers and item commands
//
// 50+ Network receivers under Command::Network (2 vfuncs each, inherit CommandInterface)
// 9 Item command types under Command::Item (10 vfuncs each, inherit ItemCommandBase)
// Key receivers: AchievementIdReceiver, JobChangeReceiver, HateStatusReceiver,
//   SetEventStatusReceiver, SetTalkEventConditionReceiver, SendLogReceiver,
//   SyncMemoryReceiver, UserDataReceiver
// ============================================================================

[Rtti(".?AVCommandInterface@Command@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct CommandInterface
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FDF980 (2 vfuncs)
}

[Rtti(".?AVCommandUpdaterBase@Command@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe struct CommandUpdaterBase
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FE1200 (5 vfuncs)
}

[Rtti(".?AVItemCommandBase@Item@Command@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public unsafe struct ItemCommandBase
{
    [FieldOffset(0x00)] public nint VTable; // 0x010570AC (10 vfuncs)
}

// ============================================================================
// Lua Script Event system
//
// Global::InitializerInterface — actor/scene initialization callback (2 vfuncs)
// Debug::GetAllCharacterFilter — debug character enumeration (2 vfuncs)
// ============================================================================

[Rtti(".?AVInitializerInterface@Global@Control@Common@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct GlobalInitializerInterface
{
    [FieldOffset(0x00)] public nint VTable; // 0x00FDF8C8 (2 vfuncs)
}
