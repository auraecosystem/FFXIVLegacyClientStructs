namespace FFXIVClientStructs.SQEX.CDev.Engine.Cut.Plugins;

using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

// ============================================================================
// Interfaces (14)
// ============================================================================

[Rtti(".?AVIClipListenerHolder@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IClipListenerHolder
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBDE9C (14 vfuncs)
}

[Rtti(".?AVICutBGListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutBGListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE494 (7 vfuncs)
}

[Rtti(".?AVICutCameraListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutCameraListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE4B4 (19 vfuncs)
}

[Rtti(".?AVICutCharacterListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutCharacterListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01094E8C (45 vfuncs)
}

[Rtti(".?AVICutDrawEnvListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutDrawEnvListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE504 (5 vfuncs)
}

[Rtti(".?AVICutEffectListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutEffectListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE51C (12 vfuncs)
}

[Rtti(".?AVICutLightEnvListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutLightEnvListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE550 (4 vfuncs)
}

[Rtti(".?AVICutLightListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutLightListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE564 (16 vfuncs)
}

[Rtti(".?AVICutMotionListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutMotionListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE5DC (15 vfuncs)
}

[Rtti(".?AVICutPackListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutPackListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE654 (7 vfuncs)
}

[Rtti(".?AVICutPostEffectListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutPostEffectListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010952BC (34 vfuncs)
}

[Rtti(".?AVICutResourceListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutResourceListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE674 (6 vfuncs)
}

[Rtti(".?AVICutScheduleListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutScheduleListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE5A8 (12 vfuncs)
}

[Rtti(".?AVICutSoundListener@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ICutSoundListener
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBE61C (13 vfuncs)
}

// ============================================================================
// Schedulers (4)
// ============================================================================

[Rtti(".?AVAccScheduler@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AccScheduler
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109765C (21 vfuncs)
}

[Rtti(".?AVAccSchedulerFactory@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AccSchedulerFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01096D64 (4 vfuncs)
}

[Rtti(".?AVMccScheduler@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MccScheduler
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109715C (30 vfuncs)
}

[Rtti(".?AVMccSchedulerFactory@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MccSchedulerFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097790 (5 vfuncs)
}

// ============================================================================
// Actors (8)
// ============================================================================

[Rtti(".?AVActionActor@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ActionActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109771C (25 vfuncs)
}

[Rtti(".?AVCharacterActor@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CharacterActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01133A0C (24 vfuncs)
}

[Rtti(".?AVLayerActor@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayerActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01096C1C (24 vfuncs)
}

[Rtti(".?AVLayoutActor@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LayoutActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01133D74 (24 vfuncs)
}

[Rtti(".?AVMapActor@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MapActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01133A74 (24 vfuncs)
}

[Rtti(".?AVMotionActor@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01096CEC (24 vfuncs)
}

[Rtti(".?AVScheduleActor@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScheduleActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01133C14 (24 vfuncs)
}

[Rtti(".?AVSoundActor@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SoundActor
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01133B44 (24 vfuncs)
}

// ============================================================================
// Camera (5)
// ============================================================================

[Rtti(".?AVCameraObject@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CameraObject
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01096354 (3 vfuncs)

    [Rtti(".?AVIEventListener@CameraObject@Plugins@Cut@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IEventListener
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010953D8 (2 vfuncs)
    }
}

[Rtti(".?AVCameraObjectFactory@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CameraObjectFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097384 (2 vfuncs)
}

[Rtti(".?AVCameraResourceNode@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CameraResourceNode
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010974DC (15 vfuncs)
}

[Rtti(".?AVCameraResourceNodeFactory@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CameraResourceNodeFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010957E8 (7 vfuncs)
}

// ============================================================================
// Misc (3)
// ============================================================================

[Rtti(".?AVAccMccActorContainerFactory@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AccMccActorContainerFactory
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01097784 (1 vfuncs)
}

[Rtti(".?AVClipListenerHolder@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipListenerHolder
{
    [FieldOffset(0x0000)] public nint VTable; // 0x00FBDF14 (1 vfuncs)
}

[Rtti(".?AVPushPopActorInfo@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PushPopActorInfo
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011362E8 (1 vfuncs)
}

// ============================================================================
// Clips (67)
// ============================================================================

[Rtti(".?AVAutoMoveClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct AutoMoveClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011352B4 (42 vfuncs)
}

[Rtti(".?AVBGActionClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BGActionClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01136634 (42 vfuncs)
}

[Rtti(".?AVBGMStopClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BGMStopClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011394C4 (42 vfuncs)
}

[Rtti(".?AVBGMVolumeClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BGMVolumeClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011396A4 (42 vfuncs)
}

[Rtti(".?AVBlurClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct BlurClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01137F8C (42 vfuncs)
}

[Rtti(".?AVCameraClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CameraClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010955DC (42 vfuncs)
}

[Rtti(".?AVClippingClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClippingClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01139814 (42 vfuncs)
}

[Rtti(".?AVClipSyncClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ClipSyncClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109604C (42 vfuncs)
}

[Rtti(".?AVColorCorrectionClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ColorCorrectionClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113810C (42 vfuncs)
}

[Rtti(".?AVConstrainClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ConstrainClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01136954 (42 vfuncs)
}

[Rtti(".?AVCreateModelClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CreateModelClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01134DF4 (42 vfuncs)
}

[Rtti(".?AVCrossFadeClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CrossFadeClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01136EAC (42 vfuncs)
}

[Rtti(".?AVCullingOnOffClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct CullingOnOffClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01136D3C (42 vfuncs)
}

[Rtti(".?AVDeleteModelClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DeleteModelClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01134EAC (42 vfuncs)
}

[Rtti(".?AVDepthOfFieldClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct DepthOfFieldClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011370A4 (42 vfuncs)
}

[Rtti(".?AVEffectTurnOffClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EffectTurnOffClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01139004 (42 vfuncs)
}

[Rtti(".?AVEndSubScheduleClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EndSubScheduleClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01135DB4 (42 vfuncs)
}

[Rtti(".?AVEnvMapClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct EnvMapClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0109650C (42 vfuncs)
}

[Rtti(".?AVFadeScreenClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FadeScreenClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01135C3C (42 vfuncs)
}

[Rtti(".?AVFogClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FogClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01139AFC (42 vfuncs)
}

[Rtti(".?AVFogParamClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FogParamClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01095EDC (42 vfuncs)
}

[Rtti(".?AVFootSeOnOffClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FootSeOnOffClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113755C (42 vfuncs)
}

[Rtti(".?AVFrameSyncClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct FrameSyncClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x010961BC (42 vfuncs)
}

[Rtti(".?AVGetStringClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct GetStringClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01134D34 (44 vfuncs)
}

[Rtti(".?AVGlareClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct GlareClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01137264 (42 vfuncs)
}

[Rtti(".?AVIKTargetClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IKTargetClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01138CE4 (43 vfuncs)
}

[Rtti(".?AVIKTargetLimitClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IKTargetLimitClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011391E4 (42 vfuncs)
}

[Rtti(".?AVIndividualShadowClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct IndividualShadowClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113843C (42 vfuncs)
}

[Rtti(".?AVKillClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct KillClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01135744 (42 vfuncs)
}

[Rtti(".?AVLatitudeClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LatitudeClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011373DC (42 vfuncs)
}

[Rtti(".?AVLightAddClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LightAddClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01135A84 (42 vfuncs)
}

[Rtti(".?AVLightClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LightClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01095934 (45 vfuncs)
}

[Rtti(".?AVLoadClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LoadClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113460C (42 vfuncs)
}

[Rtti(".?AVLocalCameraClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LocalCameraClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01095874 (43 vfuncs)
}

[Rtti(".?AVLUTColorCorrectionClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct LUTColorCorrectionClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01139984 (42 vfuncs)
}

[Rtti(".?AVMotionClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011348B4 (42 vfuncs)
}

[Rtti(".?AVMotionClip_@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionClipV2
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01139C84 (42 vfuncs)
}

[Rtti(".?AVMotionCommandClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionCommandClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01133E9C (42 vfuncs)
}

[Rtti(".?AVMotionEndBlendClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionEndBlendClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01136184 (42 vfuncs)
}

[Rtti(".?AVMotionLabelClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct MotionLabelClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01135454 (42 vfuncs)
}

[Rtti(".?AVPhysicsCollectEnableClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PhysicsCollectEnableClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01138894 (42 vfuncs)
}

[Rtti(".?AVPhysicsEnableClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PhysicsEnableClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011367E4 (42 vfuncs)
}

[Rtti(".?AVPhysicsEnableDrawClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PhysicsEnableDrawClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01138724 (42 vfuncs)
}

[Rtti(".?AVPhysicsPauseClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PhysicsPauseClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01138A04 (42 vfuncs)
}

[Rtti(".?AVPhysicsResetClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PhysicsResetClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01138B74 (42 vfuncs)
}

[Rtti(".?AVPushPopClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct PushPopClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011362FC (42 vfuncs)
}

[Rtti(".?AVRootMoveClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct RootMoveClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011364B4 (42 vfuncs)
}

[Rtti(".?AVScheduleActorClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScheduleActorClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01135E6C (42 vfuncs)
}

[Rtti(".?AVScheduleClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ScheduleClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01134A84 (42 vfuncs)
}

[Rtti(".?AVSEClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SEClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113503C (42 vfuncs)
}

[Rtti(".?AVSelectSkipClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SelectSkipClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01137CAC (42 vfuncs)
}

[Rtti(".?AVSendMessageClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SendMessageClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113590C (44 vfuncs)
}

[Rtti(".?AVSetGlobalPosClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SetGlobalPosClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01138E94 (42 vfuncs)
}

[Rtti(".?AVSEVolumeClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SEVolumeClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011385AC (44 vfuncs)
}

[Rtti(".?AVShadowClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ShadowClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113783C (42 vfuncs)
}

[Rtti(".?AVShadowDirectionClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ShadowDirectionClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011379BC (42 vfuncs)
}

[Rtti(".?AVShadowOnOffClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct ShadowOnOffClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01137B3C (42 vfuncs)
}

[Rtti(".?AVStartSubScheduleClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StartSubScheduleClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01135CFC (42 vfuncs)
}

[Rtti(".?AVStopSkipClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct StopSkipClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01137E1C (42 vfuncs)
}

[Rtti(".?AVSwitchCameraClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct SwitchCameraClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011376CC (42 vfuncs)
}

[Rtti(".?AVTextLabelClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TextLabelClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x011355C4 (42 vfuncs)
}

[Rtti(".?AVTransformClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct TransformClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01095C34 (44 vfuncs)
}

[Rtti(".?AVUnconstrainClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct UnconstrainClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01136B3C (42 vfuncs)
}

[Rtti(".?AVUnloadClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct UnloadClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01134474 (42 vfuncs)
}

[Rtti(".?AVVolumetricLightClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct VolumetricLightClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x0113829C (42 vfuncs)
}

[Rtti(".?AVWindClip@Plugins@Cut@Engine@CDev@SQEX@@")]
[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe struct WindClip
{
    [FieldOffset(0x0000)] public nint VTable; // 0x01139354 (42 vfuncs)
}
