# FFXIVLegacyClientStructs

Reverse-engineered client structures for **Final Fantasy XIV 1.0** (version 1.23b, the final patch before the Calamity shutdown).

Inspired by [aers/FFXIVClientStructs](https://github.com/aers/FFXIVClientStructs) which covers the modern FFXIV client. That project is **completely incompatible** with 1.0 — different architecture (x64 vs x86), different engine (Luminous-derived vs Crystal Tools), different memory layouts. This project fills that gap.

## Target Binary

| Property | Value |
|---|---|
| Executable | `ffxivgame.exe` |
| Game Version | `2012.09.19.0001` |
| Boot Version | `2010.09.18.0000` |
| Architecture | **x86 (32-bit)** |
| ImageBase | `0x00400000` |
| SizeOfImage | `0x00F99000` (15.6 MB) |
| Engine | Crystal Tools (SQEX::CDev::Engine) |
| Renderer | DirectX 9 |
| Sound | XAudio2 |
| UI Framework | Sqwt (Square Enix Widget Toolkit) |
| Physics | Phieg (custom, not Havok) |
| Networking | Custom RUDP2 over WinSock2 + WinHTTP |

Since 1.23b was the last patch ever released, **all addresses are frozen forever** — no signature scanning needed (though it's included for documentation purposes).

## What's Inside

### RTTI Database
**4,358 classes** extracted from the binary with full MSVC mangled/demangled names, vtable virtual addresses, virtual function counts, and **inheritance hierarchies** (via ClassHierarchyDescriptor → BaseClassArray chain). 3,877 classes have vtable addresses resolved.

Top-level namespaces:
- `SQEX::CDev::Engine` (1,492 classes) — Core Crystal Tools engine: Framework, Rendering (Dw), Layout (Stella/Lay), Sound (Sd), VFX (Qix), Physics (Phieg), Cutscene scheduler (Cut), Memory management
- `Application::Scene::Actor` (273) — Game actors: CharaActor, CameraActor, GameManagerActor, Map instances
- `Application::Lua::Script` (242) — Lua scripting bindings (166 documented Lua API functions)
- `Application::Main::Element` (221) — UI elements and HUD
- `Application::Network` (300+) — Three IPC channels: Zone, Lobby, Chat (each with packet builders and connection managers)
- `Sqwt` (685 classes) — Full WPF-inspired UI framework with XAML markup, data binding, templates, routed events, animations, dependency properties, visual tree, input system, document model

### C# Struct Library
Explicit-layout structs mapping game memory, organized to mirror the original C++ namespace hierarchy. Key structs with confirmed data from RE:

| Struct | Size | VTable | VFuncs | Notes |
|---|---|---|---|---|
| `CharaActor` | 0x2BB0 (11,184 bytes) | 0x00FC0D34 | 188 | Player/NPC/enemy actor. 40 embedded sub-objects including CharaActionController, CutSceneManager, OcclusionBoundary, 2x TargetInfo |
| `CharaElement` | 0xEF0 (3,824 bytes) | 0x00FA7C50 | 14 | Character UI element |
| `TargetActor` | ~0x09C0 | 0x00FB83CC | 160 | Base for system actors. 79 fields, 16 sub-objects, 37-entry property array at +0x0914 |
| `GameManagerActor` | ~0x09C0 | 0x00FB8134 | 164 | Central manager. PostEffectController (15 screen-space filters), inherits TargetActor |
| `BootupActor` | ~0x09C0 | 0x00FB86C4 | 164 | Boot/login sequence. Near-identical to TargetActor, inherits through CDevActor |
| `CameraActor` | ~0x400 | 0x00FB906C | 164 | Camera manager. 11 context types (FPS/TPS/WoW/CharaCreate/CharaFocus/CharaSelect) |
| `PostEffectController` | ~0x410 | 0x00FB7DC8 | 3 | 15 PostFilterBase-derived filters: Blur, ColorCorrection, CrossFade, DoF, Fog, Gamma, Glare, Latitude, LUT, PlaneFade, Shadow, SSAO, TargetEffect ×3, VolLight |
| `Actor` (base) | ~0x100 | 0x0109CA94 | 89 | Base for all scene actors |
| `SocketBase` | 0x1A4 (420 bytes) | 0x011132DC | 18 | WinSock2 abstraction. Mutex, ring buffers, stats counters, endpoint info |
| `RUDPImpl` | ~0x300 | 0x01113378 | 14 | RUDP2 state machine. Retransmission, selective ACK, keepalive |

### Sqwt UI Framework (685 RTTI classes)
Square Enix Widget Toolkit — a full WPF-inspired UI framework used for all of FFXIV 1.0's interface: character creation, HUD, menus, chat, config, map screen, nameplate overlays, and login screens.

**Core hierarchy** mirrors WPF: `Object → DependencyObject → Visual → UIElement → FrameworkElement → Control → ...`

| Subsystem | Struct Count | Key Types |
|---|---|---|
| **Core** | 20+ | AllocatorBase, DependencyObject, DependencyPropertyInfoBase, ControlTemplate, DataTemplate, Style, TriggerBase, Trigger, Setter, EventArgs, Delegate |
| **Visual Tree** | 10+ | Visual (23 vfuncs), UIElement (39), FrameworkElement (65), Window (79), InputElement (72), Brush, SolidColorBrush, Transform, DrawingContext (44), Matrix |
| **Controls** | 35+ | Control (70), ContentControl (71), Button (73), CheckBox (76), ComboBox (72), TabControl (72), Panel (68), StackPanel, Canvas, Border, Image, ProgressBar (73), ScrollContentPresenter, TextChangedEventArgs |
| **Controls::Primitives** | 15+ | ToggleButton (76), RepeatButton (73), Selector (72), ScrollBar (73), TextBoxBase (94 — largest), Thumb (71), Track (67), Popup (65), BulletDecorator, IScrollInfo (31) |
| **Input** | 30+ | InputDevice, KeyboardDevice (7), Mouse, Keyboard, InputGesture (11), KeyGesture, MouseGesture, PadGesture, CharGesture, ICommand (4), NullCommand, CommandBinding, Cursor (65), Anchor (65), MouseElement |
| **Animation** | 15+ | Animatable (14), TimelineGroup (24), ParallelTimeline (24), Storyboard (24), AnimationTimeline (24), DoubleAnimation (24), BeginStoryboard, PauseStoryboard, ResumeStoryboard, StopStoryboard, StringKeyFrame |
| **Markup (XAML)** | 80+ | ConfigurationFactor (8), ControlCreateBase (9), XamlReader, XamlReaderAsync, 40+ MarkupObject types, 30+ ConfigurationFactor-derived factories |
| **Data** | 5+ | BindingBase (4), Binding (6), IValueConverter (18), SqwtXmlDataMaker (17), XmlAttr (10) |
| **DocumentModel** | 8+ | TextDocument (23), Element (5), LineTextDocument, WrapTextDocument, LineTextElement, WrapTextElement |
| **Threading** | 4 | Mutex, Thread (4), Timer, ParameterizedThreadStartBase |
| **Xml** | 3 | XmlDocument (3), XmlElemenBase (8), XmlElement (3) |
| **Utility** | 5 | EditorControler, File, WidgetParts, WidgetPartsActual, WidgetPartsRefference |

### Network Architecture
Three IPC channels, each with its own connection manager, packet builder, socket thread, and buffer infrastructure:

| Channel | Opcodes | Purpose |
|---|---|---|
| **ZoneProtoChannel** | 199 | Game world: movement, combat, inventory, NPCs, status effects |
| **LobbyProtoChannel** | 14 | Login: auth, character list/create/delete, world entry. Has crypto engine |
| **ChatProtoChannel** | 10 | Chat: say, shout, tell, party, linkshell, system messages |

Transport stack: `SocketBase → SocketWinsock → SocketImpl → RUDPSocket → RUDP2::RUDPImpl`

RUDP2 segment types: SYN, ACK, DAT, EAK (selective ack), NUL (keepalive), RST (reset) — follows RFC 908/1151 naming.

### Project Meteor Cross-Reference
Server-side field names from [Project Meteor](https://bitbucket.org/Ioncannon/project-meteor-server) mapped to client binary structures:

- **Modifier enum** (132 entries) — stat/property IDs used in `SetActorProperty` (0x0137) and buff system
- **BattleTemp.generalParameter[35]** — runtime stat indices (STR=3, VIT=4, DEX=5, INT=6, MND=7, PIE=8, elemental resist 9–14, Acc/Eva/Atk/Def 15–18, magic 23–28, craft 30–34)
- **SubState** bitfield — breakage, chantId, guard, waste, mode, motionPack
- **28 AppearanceSlot** indices — character visual state (gear slots 5–27, face/body 0–4)
- **ParameterSave** — HP[8], MP, 40 recast timers, skill slots, ability cost points
- **Zone opcodes** (150+) — `AddActor` 0x00CA, `SetPosition` 0x00CE, `SetAppearance` 0x00D6, `SetState` 0x0134, `CommandResult` 0x0139, `SetStatus` 0x0177, etc.
- **Wire format** — BasePacket (0x10) → SubPacket (0x10) → GameMessage (0x10, opcode at +0x02)

### Lua Script API (166 bindings)
Complete extraction of the Lua-exposed client API. 242 RTTI classes under `Application::Lua::Script`, with 109 bindings mapped to exact registration addresses in the 0x00749900–0x00757100 range. Organized into 13 categories:

| Category | Count | Address Range | Key Functions |
|---|---|---|---|
| World/Zone | 9 | 0x7499D9–0x74A459 | `_getRegion`, `_getZoneName`, `_canRideChocobo`, `_isInn` |
| Character/Actor | 22 | 0x74A5A9–0x74C289 | `_getPosition`, `_getDirection`, `_getActorMainStat`, `_getSubStat*` |
| Party/Group | 12 | 0x74C529–0x74D789 | `_getMember`, `_countMember`, `_getMemberLocation` |
| Items/Inventory | 21 | 0x74DB79–0x7561D9 | `_getItem`, `_getCatalogID`, `_isStackable`, `_isRare` |
| Grand Company | 4 | 0x74F319–0x74F709 | `_getGMRank`, `_getBelongGrandCompany` |
| Interaction | 9 | 0x74F8F9–0x750B59 | `_play`, `_isTalkable`, `_isEmotable`, `_isPushable` |
| UI/Widgets | 7 | 0x750F49–0x757049 | `_getParentWidget`, `_getChildWidget`, `_setKeyboardFocusedWidget` |
| Target/Cursor | 5 | 0x751339–0x7521A9 | `_getTargetCharacter`, `_getLookAtCharacter`, `_getLastAttacker` |
| Config/Macro | 5 | 0x751B19–0x752059 | `_getUserConfig`, `_parseTextCommand`, `_getUserMacro*` |
| Player/Time | 12 | 0x752839–0x753B29 | `_getMyPlayer`, `_getServerTime`, `_getHydaelynHour/Day/Time/Moon` |
| Nameplate | 3 | 0x72E979–0x72EC19 | `_setNameplateIcon/Gauge/Visible` |

Engine infrastructure: GameEngine (ErrorHandler 68 vfuncs, SharedWorkInterface 28 vfuncs, StackOperator 9 vfuncs), 11 Work::Information types (29 vfuncs each), Memory subsystem (Container 20 vfuncs, Operator 16 vfuncs), 50+ Command::Network packet receivers, 9 Item command types.

### Analysis Tools

The `FFXIVClientStructs.Tools.CLI` project provides automated analysis directly from the exe:

```
--rtti              Dump full RTTI database (4,358 classes with inheritance)
--imports           Dump import table (21 DLLs, ~400 functions)
--vtable <class>    Dump complete vtable for any RTTI class
--vtfuncs <class>   Analyze vtable functions: size, params, stub/pure detection
--analyze <class>   Extract struct layout from constructor: field offsets, sizes, embedded sub-objects, base ctor chain
--hierarchy <class> Show full inheritance tree (base classes + derived classes)
--search <pattern>  Search classes by name pattern
--strings <class>   Extract string references from class constructor and vtable functions
--findstr <string>  Find all cross-references to a string literal in .text
--all               Run all dumps (rtti + imports)
--exe <path>        Override path to ffxivgame.exe
```

Examples:
```
dotnet run -- --analyze CharaActor

// Application::Scene::Actor::Chara::CharaActor
// VTable: 0x00FC0D34 (188 vfuncs)
// Ctor:   0x0065F180
// Size:   0x2BB0 (11184 bytes)
//
// === Base Class Constructors ===
//   RaptureActor (ctor=0x..., vt=0x00FEA50C, 12 fields)
//
// === Fields (from constructor init) === [44 total]
// +0x0154 [float ] = xmm0
// +0x0158 [float ] = xmm0
// +0x1170 [dword ] = 0x000000ED
// +0x1178 [dword ] = 0x000000C9
// ...
// === Embedded Sub-Objects === [40 total]
// +0x2858 CharaActionController (vt=0x0103E468)
// +0x2B60 CharaCutVisualCtrl (vt=0x0104447C)
```

```
dotnet run -- --hierarchy CharaActor

// Inheritance hierarchy for: Application::Scene::Actor::Chara::CharaActor
//
// Direct + transitive bases:
//   <- Application::Scene::Actor::CDevActor
//   <- Application::Scene::RaptureActor (vt=0x00FEA50C)
//   <- SQEX::CDev::Engine::Fw::SceneObject::Actor (vt=0x0109CA94)
//   <- SQEX::CDev::Engine::Common::ISceneObject::IActor
//   <- SQEX::CDev::Engine::Common::Misc::NonCopyable
```

```
dotnet run -- --vtfuncs CharaActor

// Summary: 188 total, 0 pure virtual, 30 stubs
// vt[  0] 0x00669E20 (6B) thiscall(this) [STUB]
// vt[  1] 0x006207D0 (135B) thiscall(this)
// vt[ 23] 0x00661F00 (140B) thiscall(this, arg1, arg2)
// ...
```

## Building

Requires .NET 8.0 SDK.

```bash
dotnet build --configuration Release
```

## Project Structure

```
FFXIVClientStructs/
  Attributes/         Custom attributes for marking RE data
  Interop/            SignatureScanner, Memory, Pointer<T>, GameInfo
  STD/                MSVC x86 std::string, std::vector, std::map
  SQEX/CDev/Engine/   Crystal Tools engine subsystems
  FFXIV/Application/  Game-layer structs (actors, network channels, Lua, UI, game enums)
  FFXIV/Component/    IPC channel base framework (NetBuffer, ConnectionManager)
  Sqex/Socket/        Transport layer (SocketBase, RUDP2 segments, Poller)
  Sqwt/               UI framework (685 classes)
    SqwtCore.cs        Core types, templates, triggers, dependency properties
    Visual.cs          Visual tree, UIElement, FrameworkElement, Window, Media types
    Controls/          Controls (35+) and Primitives (15+)
    Input/             Input devices, gestures, commands, bindings, visual overlays
    Media/             Animation system (timelines, storyboards)
    Markup/            XAML parsing, control factories, markup objects (80+)
    Data/              Data binding, value converters
    DocumentModel/     Text document model for TextBox/LogControl
    Threading/         Mutex, Thread, Timer
    Xml/               XML DOM wrappers
    Utility/           Editor and widget helpers
  Tools/              RttiDumper, ImportTableDumper, StructAnalyzer, VtableAnalyzer, StringExtractor

FFXIVClientStructs.Tools.CLI/
  Console tool for automated binary analysis

ffxiv_1.0_rtti.txt      Full RTTI database (pre-generated)
ffxiv_1.0_imports.txt   Import table dump (pre-generated)
```

## Status

This is an **active RE project**. The infrastructure, tools, and RTTI database are complete. Individual struct field mappings are being filled in progressively through static analysis and runtime verification. Contributions welcome — the binary is frozen, so all findings are permanent.

## Related Projects

- [aers/FFXIVClientStructs](https://github.com/aers/FFXIVClientStructs) — Modern FFXIV client structs (completely different engine/architecture)
- [Seventh Umbral](https://github.com/jpd002/SeventhUmbral) — FFXIV 1.0 server emulator
- [Project Meteor](https://bitbucket.org/Ioncannon/project-meteor-server) — Another 1.0 server emulator

## License

[MIT](LICENSE)
