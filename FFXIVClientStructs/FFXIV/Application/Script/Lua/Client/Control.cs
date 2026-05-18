using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Script.Lua.Client.Control;

[Rtti(".?AVActorBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ActorBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD4FE4 (34 vfuncs)
}

[Rtti(".?AVAreaBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AreaBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD63D4 (35 vfuncs)
}

[Rtti(".?AVCharaBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CharaBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5CAC (41 vfuncs)
}

[Rtti(".?AVSetNameplateMessageListener@CharaBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CharaBase_SetNameplateMessageListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD76C8 (2 vfuncs)
}

[Rtti(".?AVTextModuleListener@SetNameplateMessageListener@CharaBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CharaBase_SetNameplateMessageListener_TextModuleListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD76D4 (2 vfuncs)
}

[Rtti(".?AVCommandBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDF83C (34 vfuncs)
}

[Rtti(".?AVCommandDebuggerBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandDebuggerBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD510C (34 vfuncs)
}

[Rtti(".?AVCommandEventRelationActorBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandEventRelationActorBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD507C (21 vfuncs)
}

[Rtti(".?AVCommandEventRelationControlBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandEventRelationControlBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD4F6C (21 vfuncs)
}

[Rtti(".?AVCommandEventRelationItemBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandEventRelationItemBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5514 (21 vfuncs)
}

[Rtti(".?AVCreateClientItemResumeChecker@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CreateClientItemResumeChecker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5958 (3 vfuncs)
}

[Rtti(".?AVCutScene@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CutScene
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD597C (34 vfuncs)
}

[Rtti(".?AVInitializationClipArguments@CutScene@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CutScene_InitializationClipArguments
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD6178 (1 vfunc)
}

[Rtti(".?AVPlayingResumeChecker@CutScene@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CutScene_PlayingResumeChecker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD51AC (3 vfuncs)
}

[Rtti(".?AVDebug@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Debug
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD51DC (34 vfuncs)
}

[Rtti(".?AVDebugBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DebugBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5274 (34 vfuncs)
}

[Rtti(".?AVDesktopUtil@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DesktopUtil
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDFC9C (38 vfuncs)
}

[Rtti(".?AVDesktopWidget@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DesktopWidget
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5B8C (38 vfuncs)
}

[Rtti(".?AVAppendMessageResumeChecker@DesktopWidget@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DesktopWidget_AppendMessageResumeChecker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5340 (3 vfuncs)
}

[Rtti(".?AVTargetTutorialResumeChecker@DesktopWidget@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DesktopWidget_TargetTutorialResumeChecker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5350 (3 vfuncs)
}

[Rtti(".?AVDirectorBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DirectorBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5D6C (34 vfuncs)
}

[Rtti(".?AVGlobal@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Global
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD60AC (34 vfuncs)
}

[Rtti(".?AVOnInitResumeChecker@Global@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Global_OnInitResumeChecker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD539C (3 vfuncs)
}

[Rtti(".?AVGroupBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct GroupBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD53CC (34 vfuncs)
}

[Rtti(".?AVImportantItem@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ImportantItem
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5C40 (6 vfuncs)
}

[Rtti(".?AVItem@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Item
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5A14 (6 vfuncs)
}

[Rtti(".?AVItemBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5484 (34 vfuncs)
}

[Rtti(".?AVItemBuilder@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemBuilder
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5C68 (6 vfuncs)
}

[Rtti(".?AVItemManager@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD7618 (2 vfuncs)
}

[Rtti(".?AVItemSheetLoadRequest@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemSheetLoadRequest
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5A40 (4 vfuncs)
}

[Rtti(".?AVItemSheetLoadRequestInterface@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemSheetLoadRequestInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5198 (4 vfuncs)
}

[Rtti(".?AVItemSheetLoadRequestSimple@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemSheetLoadRequestSimple
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5580 (4 vfuncs)
}

[Rtti(".?AVItemSheetLoadRequestTerminator@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemSheetLoadRequestTerminator
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD556C (4 vfuncs)
}

[Rtti(".?AVItemSheetLoader@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemSheetLoader
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5A30 (3 vfuncs)
}

[Rtti(".?AVLoadFinishedListenerInterface@ItemSheet@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ItemSheet_LoadFinishedListenerInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD50D4 (2 vfuncs)
}

[Rtti(".?AVJudgeBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct JudgeBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDFD44 (34 vfuncs)
}

[Rtti(".?AVMath@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Math
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD559C (34 vfuncs)
}

[Rtti(".?AVMoneyItem@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MoneyItem
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5A54 (6 vfuncs)
}

[Rtti(".?AVMyPlayer@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MyPlayer
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD785C (133 vfuncs)
}

[Rtti(".?AVNormalItem@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NormalItem
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5C84 (6 vfuncs)
}

[Rtti(".?AVNpcBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NpcBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD647C (41 vfuncs)
}

[Rtti(".?AVBgSchedulerResumeChecker@NpcBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NpcBase_BgSchedulerResumeChecker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5654 (3 vfuncs)
}

[Rtti(".?AVPlayerBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PlayerBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5E04 (133 vfuncs)
}

[Rtti(".?AVPrivateAreaBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PrivateAreaBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD653C (35 vfuncs)
}

[Rtti(".?AVQuestBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct QuestBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDFDDC (34 vfuncs)
}

[Rtti(".?AVSendStoryboardCommandPickUpWithInt@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SendStoryboardCommandPickUpWithInt
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD572C (2 vfuncs)
}

[Rtti(".?AVSendStoryboardCommandPickUpWithNone@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SendStoryboardCommandPickUpWithNone
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD57A8 (2 vfuncs)
}

[Rtti(".?AVSendStoryboardCommandPickUpWithString@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SendStoryboardCommandPickUpWithString
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5744 (2 vfuncs)
}

[Rtti(".?AVSendStoryboardCommandPickUpWithTwoInts@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SendStoryboardCommandPickUpWithTwoInts
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5738 (2 vfuncs)
}

[Rtti(".?AVSetPropertyPickUpWithBool@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetPropertyPickUpWithBool
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD568C (2 vfuncs)
}

[Rtti(".?AVSetPropertyPickUpWithFloat@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetPropertyPickUpWithFloat
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5698 (2 vfuncs)
}

[Rtti(".?AVSetPropertyPickUpWithFourFloat@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetPropertyPickUpWithFourFloat
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD56BC (2 vfuncs)
}

[Rtti(".?AVSetPropertyPickUpWithInt@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetPropertyPickUpWithInt
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5680 (2 vfuncs)
}

[Rtti(".?AVSetPropertyPickUpWithString@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetPropertyPickUpWithString
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD56A4 (2 vfuncs)
}

[Rtti(".?AVSetPropertyPickUpWithTwoFloat@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetPropertyPickUpWithTwoFloat
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD56B0 (2 vfuncs)
}

[Rtti(".?AVSpreadSheet@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SpreadSheet
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD7744 (34 vfuncs)
}

[Rtti(".?AVSpreadSheetLoadedDataDisappearListenerInterface@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SpreadSheetLoadedDataDisappearListenerInterface
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDF974 (2 vfuncs)
}

[Rtti(".?AVLoadDataFunctionEndCallback@SpreadSheet@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SpreadSheet_LoadDataFunctionEndCallback
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5CA0 (2 vfuncs)
}

[Rtti(".?AVLoadDataFunctionEndCallbackFinder@SpreadSheet@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SpreadSheet_LoadDataFunctionEndCallbackFinder
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5714 (2 vfuncs)
}

[Rtti(".?AVLoadDataResumeChecker@SpreadSheet@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SpreadSheet_LoadDataResumeChecker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD6160 (3 vfuncs)
}

[Rtti(".?AVStatusBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StatusBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDF8DC (34 vfuncs)
}

[Rtti(".?AVString@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct String
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDFE74 (34 vfuncs)
}

[Rtti(".?AVTable@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Table
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FDFF0C (34 vfuncs)
}

[Rtti(".?AVTypeChecker<ActorBase>@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TypeCheckerActorBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5928 (2 vfuncs)
}

[Rtti(".?AVTypeChecker<CharaBase>@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TypeCheckerCharaBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5934 (2 vfuncs)
}

[Rtti(".?AVTypeChecker<NpcBase>@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TypeCheckerNpcBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD594C (2 vfuncs)
}

[Rtti(".?AVTypeChecker<PlayerBase>@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TypeCheckerPlayerBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5940 (2 vfuncs)
}

[Rtti(".?AVWidgetBase@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WidgetBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5A74 (38 vfuncs)
}

[Rtti(".?AVWidgetHandle@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WidgetHandle
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD57D4 (34 vfuncs)
}

[Rtti(".?AVWorldMaster@Control@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WorldMaster
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5864 (34 vfuncs)
}

