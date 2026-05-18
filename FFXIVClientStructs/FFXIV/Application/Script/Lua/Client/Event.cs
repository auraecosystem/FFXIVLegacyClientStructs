using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.FFXIV.Application.Script.Lua.Client.Event;

[Rtti(".?AVBase@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Base
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056C5C (12 vfuncs)
}

[Rtti(".?AVCommand@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Command
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056C90 (12 vfuncs)
}

[Rtti(".?AVCommandBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056CC4 (12 vfuncs)
}

[Rtti(".?AVCommandNonBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CommandNonBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056CF8 (12 vfuncs)
}

[Rtti(".?AVEmote@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Emote
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056D2C (12 vfuncs)
}

[Rtti(".?AVEmoteBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EmoteBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056D60 (12 vfuncs)
}

[Rtti(".?AVEmoteNonBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EmoteNonBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056D94 (12 vfuncs)
}

[Rtti(".?AVExecutionBlockEventBase@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExecutionBlockEventBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01057004 (10 vfuncs)
}

[Rtti(".?AVExecutionClientSideBlockEvent@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExecutionClientSideBlockEvent
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01057080 (10 vfuncs)
}

[Rtti(".?AVClientOrderEventWaitingResumeChecker@ExecutionClientSideBlockEvent@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExecutionClientSideBlockEvent_ClientOrderEventWaitingResumeChecker
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056DC8 (3 vfuncs)
}

[Rtti(".?AVExecutionClientSideNonBlockEvent@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExecutionClientSideNonBlockEvent
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0105705C (3 vfuncs)
}

[Rtti(".?AVExecutionEventBase@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExecutionEventBase
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056FF4 (3 vfuncs)
}

[Rtti(".?AVExecutionServerSideBlockEvent@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ExecutionServerSideBlockEvent
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01057030 (10 vfuncs)
}

[Rtti(".?AVFormManager@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FormManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056FE0 (4 vfuncs)
}

[Rtti(".?AVNotice@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Notice
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056DD8 (12 vfuncs)
}

[Rtti(".?AVNoticeBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NoticeBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056E0C (12 vfuncs)
}

[Rtti(".?AVNoticeNonBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct NoticeNonBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056E40 (12 vfuncs)
}

[Rtti(".?AVOwnerAbsence@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct OwnerAbsence
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056FAC (12 vfuncs)
}

[Rtti(".?AVPlayerManager@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PlayerManager
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0105706C (4 vfuncs)
}

[Rtti(".?AVPush@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Push
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056EA8 (12 vfuncs)
}

[Rtti(".?AVPushBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PushBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056EDC (12 vfuncs)
}

[Rtti(".?AVPushNonBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PushNonBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056F10 (12 vfuncs)
}

[Rtti(".?AVTalk@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct Talk
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056E74 (12 vfuncs)
}

[Rtti(".?AVTalkBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TalkBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056F44 (12 vfuncs)
}

[Rtti(".?AVTalkNonBlock@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TalkNonBlock
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01056F78 (12 vfuncs)
}

[Rtti(".?AVUICommandEventParameter@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct UICommandEventParameter
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5300 (3 vfuncs)
}

[Rtti(".?AVUICommandEventParameterWithInt@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct UICommandEventParameterWithInt
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5310 (3 vfuncs)
}

[Rtti(".?AVUICommandEventParameterWithString@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct UICommandEventParameterWithString
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5330 (3 vfuncs)
}

[Rtti(".?AVUICommandEventParameterWithTwoInt@Event@Client@Script@Lua@Application@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct UICommandEventParameterWithTwoInt
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FD5320 (3 vfuncs)
}

