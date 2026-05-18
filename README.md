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
- `Sqwt` (250+) — Full WPF-inspired UI framework with XAML markup, data binding, templates, commands

### C# Struct Library
Explicit-layout structs mapping game memory, organized to mirror the original C++ namespace hierarchy. Key structs with confirmed data from RE:

| Struct | Size | VTable | VFuncs | Notes |
|---|---|---|---|---|
| `CharaActor` | 0x2BB0 (11,184 bytes) | 0x00FC0D34 | 188 | Player/NPC/enemy actor. 40 embedded sub-objects including CharaActionController, CutSceneManager, OcclusionBoundary, 2x TargetInfo |
| `CharaElement` | 0xEF0 (3,824 bytes) | 0x00FA7C50 | 14 | Character UI element |
| `GameManagerActor` | ~0x600 | 0x00FB8134 | 164 | Central manager. PostEffectController, inherits TargetActor |
| `Actor` (base) | ~0x100 | 0x0109CA94 | 89 | Base for all scene actors |
| `BootupActor` | — | 0x00FB86C4 | 164 | Boot/login sequence manager |

### Lua Script API (166 bindings)
Complete extraction of the Lua-exposed client API, including:
- Character data: `_getPosition`, `_getDirection`, `_getOrientation`, `_getActorMainStat`, `_getDisplayName`
- Stats: `_getSubStatWaste/Guard/Chant/Object/Breakage/MotionPack/Status`
- Targeting: `_getTargetCharacter`, `_getLookAtCharacter`, `_getLastAttacker`
- Inventory: `_getItem`, `_getEquippingItem`, `_getCatalogID`, `_isStackable`, `_isRare`
- Party: `_getMember`, `_countMember`, `_getMemberLocation`
- World: `_getServerTime`, `_getHydaelynHour/Day/Time/Moon`, `_getRegion`, `_getZoneName`
- UI: Widget tree traversal, keyboard focus, container management

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
  FFXIV/Application/  Game-layer structs (actors, network, Lua, UI)
  Sqwt/               UI framework types
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
