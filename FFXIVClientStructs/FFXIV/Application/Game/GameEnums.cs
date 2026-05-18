namespace FFXIVClientStructs.FFXIV.Application.Game;

// ============================================================================
// Game enums cross-referenced from Project Meteor server emulator.
// Server-side field names mapped to client binary structures.
// ============================================================================

// Stat modifier IDs used in BattleTemp, property packets, and buff/debuff system.
// 132 entries (0–131). Maps to SetActorPropetyPacket (opcode 0x0137) payloads.
public enum Modifier : ushort
{
    Hp = 0,
    Mp = 1,
    Tp = 2,

    // Primary stats
    Strength = 3,
    Vitality = 4,
    Dexterity = 5,
    Intelligence = 6,
    Mind = 7,
    Piety = 8,

    // Elemental resistances
    FireResistance = 9,
    IceResistance = 10,
    WindResistance = 11,
    EarthResistance = 12,
    LightningResistance = 13,
    WaterResistance = 14,

    // Physical secondary
    Accuracy = 15,
    Evasion = 16,
    Attack = 17,
    Defense = 18,

    // Physical critical
    CriticalHitRating = 19,
    CriticalHitEvasion = 20,
    CriticalHitAttackPower = 21,
    CriticalHitResilience = 22,

    // Magic secondary
    AttackMagicPotency = 23,
    HealingMagicPotency = 24,
    EnhancementMagicPotency = 25,
    EnfeeblingMagicPotency = 26,
    MagicAccuracy = 27,
    MagicEvasion = 28,

    // Crafting
    Craftsmanship = 29,
    MagicCraftsmanship = 30,
    Control = 31,
    Gathering = 32,
    Output = 33,
    Perception = 34,

    // Magic critical
    MagicCriticalHitRating = 35,
    MagicCriticalHitEvasion = 36,
    MagicCriticalHitPotency = 37,
    MagicCriticalHitResilience = 38,

    // Blocking
    Parry = 39,
    BlockRate = 40,
    Block = 41,

    // Elemental potencies
    FireMagicPotency = 42,
    IceMagicPotency = 43,
    WindMagicPotency = 44,
    EarthMagicPotency = 45,
    LightningMagicPotency = 46,
    WaterMagicPotency = 47,

    // Misc combat
    Regen = 48,
    Refresh = 49,
    StoreTp = 50,
    Enmity = 51,
    Spikes = 52,
    Haste = 53,

    ReducedDurabilityLoss = 56,
    IncreasedSpiritbondGain = 57,
    Damage = 58,
    Delay = 59,
    Fastcast = 60,
    MovementSpeed = 61,
    Exp = 62,
    RestingHp = 63,
    RestingMp = 64,

    // Attack property resistances
    SlashingResistance = 65,
    PiercingResistance = 66,
    BluntResistance = 67,
    ProjectileResistance = 68,
    SonicResistance = 69,
    BreathResistance = 70,
    PhysicalResistance = 71,
    MagicResistance = 72,

    // Status effect resistances
    SlowResistance = 73,
    PetrificationResistance = 74,
    ParalysisResistance = 75,
    SilenceResistance = 76,
    BlindResistance = 77,
    PoisonResistance = 78,
    StunResistance = 79,
    SleepResistance = 80,
    BindResistance = 81,
    HeavyResistance = 82,
    DoomResistance = 83,

    // Extended
    ConserveMp = 101,
    SpellInterruptResistance = 102,
    DoubleDownOdds = 103,
    HqDiscoveryRate = 104,

    None = 105,
    NameplateShown = 106,
    Targetable = 107,
    NameplateShown2 = 108,

    HpPercent = 109,
    MpPercent = 110,
    TpPercent = 111,

    AttackRange = 112,
    Raise = 113,
    MinimumHpLock = 114,
    MinimumMpLock = 115,
    MinimumTpLock = 116,
    AttackType = 117,
    CanBlock = 118,
    HitCount = 119,

    RawEvadeRate = 120,
    RawParryRate = 121,
    RawBlockRate = 122,
    RawResistRate = 123,
    RawHitRate = 124,
    RawCritRate = 125,

    DamageTakenDown = 126,
    Regain = 127,
    RegenDown = 128,
    Stoneskin = 129,
    KnockbackImmune = 130,
    Stealth = 131,
}

// BattleTemp.generalParameter[35] stat array indices.
// Maps to the server-side stat calculation pipeline.
public enum GeneralParameter : byte
{
    Strength = 3,
    Vitality = 4,
    Dexterity = 5,
    Intelligence = 6,
    Mind = 7,
    Piety = 8,

    ResistanceFire = 9,
    ResistanceIce = 10,
    ResistanceWind = 11,
    ResistanceLightning = 12,
    ResistanceEarth = 13,
    ResistanceWater = 14,

    Accuracy = 15,
    Evasion = 16,
    Attack = 17,
    NormalDefense = 18,

    AttackMagic = 23,
    HealMagic = 24,
    EnhancementMagicPotency = 25,
    EnfeeblingMagicPotency = 26,
    MagicAccuracy = 27,
    MagicEvasion = 28,

    CraftProcessing = 30,
    CraftMagicProcessing = 31,
    CraftProcessControl = 32,

    HarvestPotency = 33,
    HarvestLimit = 34,
    // Index 35 = HarvestRate (server uses 1-based)
}

// Actor SubState bitfield — packed status flags sent via SetActorSubStatePacket (0x0144).
public enum SubStateField : byte
{
    Breakage = 0,   // 8-bit, bitwise toggle by index 0–7
    ChantId = 1,    // current chant ID
    Guard = 2,      // 0–3 range
    Waste = 3,      // 0–3 range
    Mode = 4,       // mode bitfield
    MotionPack = 5, // ushort, motion pack identifier
}

// SetActorAppearancePacket (opcode 0x00D6) slot indices.
// 28 slots defining full character visual state.
public enum AppearanceSlot : byte
{
    Size = 0,
    ColorInfo = 1,
    FaceInfo = 2,
    HighlightHair = 3,
    Voice = 4,
    MainHand = 5,
    OffHand = 6,
    SpMainHand = 7,
    SpOffHand = 8,
    Throwing = 9,
    Pack = 10,
    Pouch = 11,
    HeadGear = 12,
    BodyGear = 13,
    LegsGear = 14,
    HandsGear = 15,
    FeetGear = 16,
    WaistGear = 17,
    NeckGear = 18,
    LeftEar = 19,
    RightEar = 20,
    RightWrist = 21,
    LeftWrist = 22,
    RightRingFinger = 23,
    LeftRingFinger = 24,
    RightIndexFinger = 25,
    LeftIndexFinger = 26,
    Unknown27 = 27,
}
