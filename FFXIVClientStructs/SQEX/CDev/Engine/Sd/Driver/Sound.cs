using System.Runtime.InteropServices;
using FFXIVClientStructs.Attributes;

namespace FFXIVClientStructs.SQEX.CDev.Engine.Sd.Driver
{
    // SQEX::CDev::Engine::Sd::Driver — Sound driver subsystem (XAudio2-based)
    // Handles banks, buses, voices, effects, filters, streaming, DSP

    [Rtti(".?AVActualBank@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ActualBank
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B26AC (43 vfuncs)
    }

    [Rtti(".?AVBandEliminateFilterBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BandEliminateFilterBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD22C (17 vfuncs)
    }

    [Rtti(".?AVBandpassFilterBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BandpassFilterBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD1E4 (17 vfuncs)
    }

    [Rtti(".?AVBankController@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BankController
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010ACACC (1 vfuncs)
    }

    [Rtti(".?AVBus@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Bus
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD994 (8 vfuncs)
    }

    [Rtti(".?AVBusController@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct BusController
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AC9BC (1 vfuncs)
    }

    [Rtti(".?AVCompressorBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CompressorBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AF274 (17 vfuncs)
    }

    [Rtti(".?AVConfigReader@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ConfigReader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AEC70 (1 vfuncs)
    }

    [Rtti(".?AVCycleSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct CycleSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B179C (97 vfuncs)
    }

    [Rtti(".?AVDefaultSoundResourceNode@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DefaultSoundResourceNode
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B4C94 (17 vfuncs)
    }

    [Rtti(".?AVDelayStreamSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DelayStreamSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B1CFC (97 vfuncs)
    }

    [Rtti(".?AVDialogSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DialogSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B140C (97 vfuncs)
    }

    [Rtti(".?AVDynamicValue@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DynamicValue
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010ACB10 (7 vfuncs)
    }

    [Rtti(".?AVDynamixStreamSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct DynamixStreamSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B20E4 (97 vfuncs)
    }

    [Rtti(".?AVEffectController@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct EffectController
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD550 (1 vfuncs)
    }

    [Rtti(".?AVEngineSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct EngineSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B0E94 (97 vfuncs)
    }

    [Rtti(".?AVEqualizerBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct EqualizerBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD900 (13 vfuncs)
    }

    [Rtti(".?AVFilterBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct FilterBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD10C (17 vfuncs)
    }

    [Rtti(".?AVFixedPositionSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct FixedPositionSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B084C (97 vfuncs)
    }

    [Rtti(".?AVFixedVolumeSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct FixedVolumeSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B0AA4 (97 vfuncs)
    }

    [Rtti(".?AVGranularPitchShiftBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct GranularPitchShiftBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AF0C4 (12 vfuncs)
    }

    [Rtti(".?AVGranularSynthesizerBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct GranularSynthesizerBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AF184 (17 vfuncs)
    }

    [Rtti(".?AVHighpassFilterBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct HighpassFilterBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD19C (17 vfuncs)
    }

    [Rtti(".?AVIDataTransfer@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IDataTransfer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B464C (25 vfuncs)
    }

    [Rtti(".?AVIDSPBus@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IDSPBus
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AEE58 (2 vfuncs)
    }

    [Rtti(".?AVIEffect@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IEffect
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD0E0 (9 vfuncs)
    }

    [Rtti(".?AVISound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ISound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B0514 (93 vfuncs)
    }

    [Rtti(".?AVISoundDriver@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ISoundDriver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0113D724 (75 vfuncs)
    }

    [Rtti(".?AVIStreamReader@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IStreamReader
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x00F6717C (4 vfuncs)
    }

    [Rtti(".?AVIStreamReaderEx@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IStreamReaderEx
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD5DC (3 vfuncs)
    }

    [Rtti(".?AVIStreamReadThreadEventReceiver@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IStreamReadThreadEventReceiver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B2A24 (2 vfuncs)
    }

    [Rtti(".?AVIVoice@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct IVoice
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B413C (55 vfuncs)
    }

    [Rtti(".?AVLowpassFilterBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct LowpassFilterBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AD154 (17 vfuncs)
    }

    [Rtti(".?AVOggVorbisDataTransfer@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct OggVorbisDataTransfer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B437C (25 vfuncs)
    }

    [Rtti(".?AVOggVorbisStreamDataTransfer@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct OggVorbisStreamDataTransfer
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B45A4 (26 vfuncs)
    }

    [Rtti(".?AVOggVorbisStreamDataTransferEx@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct OggVorbisStreamDataTransferEx
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B47E4 (28 vfuncs)
    }

    [Rtti(".?AVOrderSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct OrderSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B15D4 (97 vfuncs)
    }

    [Rtti(".?AVReverbController@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ReverbController
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010ACA84 (1 vfuncs)
    }

    [Rtti(".?AVRootSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct RootSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B068C (96 vfuncs)
    }

    [Rtti(".?AVSoundDriver@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct SoundDriver
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0113D854 (75 vfuncs)
    }

    [Rtti(".?AVSoundResourceNodeFactory@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct SoundResourceNodeFactory
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0109D10C (7 vfuncs)
    }

    [Rtti(".?AVStereoSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct StereoSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B107C (97 vfuncs)
    }

    [Rtti(".?AVStreamBank@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct StreamBank
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B2924 (44 vfuncs)
    }

    [Rtti(".?AVStreamBankEx@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct StreamBankEx
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B2A3C (43 vfuncs)
    }

    [Rtti(".?AVStreamReadThread@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct StreamReadThread
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B2E9C (1 vfuncs)
    }

    [Rtti(".?AVStreamSoundEx@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct StreamSoundEx
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B2384 (97 vfuncs)
    }

    [Rtti(".?AVStringendoEffectBase@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct StringendoEffectBase
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010AF35C (11 vfuncs)
    }

    [Rtti(".?AVSurround4chSound@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct Surround4chSound
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B0C6C (97 vfuncs)
    }

    [Rtti(".?AVToolBank@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ToolBank
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x010B25BC (43 vfuncs)
    }

    [Rtti(".?AVToolBankController@Driver@Sd@Engine@CDev@SQEX@@")]
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public unsafe struct ToolBankController
    {
        [FieldOffset(0x0000)] public nint VTable; // 0x0113D9C0 (1 vfuncs)
    }

    // ══════════════════════════════════════════════
    // Sub-namespace: XA2
    // ══════════════════════════════════════════════

    namespace XA2
    {
        [Rtti(".?AVAdpcmStreamDataTransferEx@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AdpcmStreamDataTransferEx
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B46B4 (28 vfuncs)
        }

        [Rtti(".?AVAudioBounceXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AudioBounceXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AE16C (9 vfuncs)
        }

        [Rtti(".?AVEngineCallback@AudioXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct AudioXA2_EngineCallback
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010ADE68 (3 vfuncs)
        }

        [Rtti(".?AVBandEliminateFilterXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BandEliminateFilterXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AD364 (17 vfuncs)
        }

        [Rtti(".?AVBandpassFilterXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BandpassFilterXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AD314 (17 vfuncs)
        }

        [Rtti(".?AVBusXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct BusXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AEE64 (2 vfuncs)
        }

        [Rtti(".?AVCompressorXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct CompressorXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AF2BC (17 vfuncs)
        }

        [Rtti(".?AVGranularPitchShiftXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct GranularPitchShiftXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AF0F8 (12 vfuncs)
        }

        [Rtti(".?AVGranularSynthesizerXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct GranularSynthesizerXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AF1CC (18 vfuncs)
        }

        [Rtti(".?AVHighpassFilterXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct HighpassFilterXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AD2CC (17 vfuncs)
        }

        [Rtti(".?AVLowpassFilterXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct LowpassFilterXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AD284 (17 vfuncs)
        }

        [Rtti(".?AVMasterBusXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct MasterBusXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AF048 (8 vfuncs)
        }

        [Rtti(".?AVProLogicIIzXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ProLogicIIzXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AE334 (9 vfuncs)
        }

        [Rtti(".?AVReverbXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct ReverbXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AE76C (19 vfuncs)
        }

        [Rtti(".?AVStereoDownmixerXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct StereoDownmixerXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AE2B4 (9 vfuncs)
        }

        [Rtti(".?AVStreamDataTransferADPCM@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct StreamDataTransferADPCM
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B44E4 (25 vfuncs)
        }

        [Rtti(".?AVStringendoEffectXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct StringendoEffectXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010AF38C (11 vfuncs)
        }

        [Rtti(".?AVVoiceXA2@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct VoiceXA2
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B425C (55 vfuncs)
        }

        [Rtti(".?AVXAPOAudioBounce@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XAPOAudioBounce
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B312C (15 vfuncs)
        }

        [Rtti(".?AVXAPOCompressor@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XAPOCompressor
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B395C (16 vfuncs)
        }

        [Rtti(".?AVXAPOGranularPitchShift@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XAPOGranularPitchShift
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B3674 (16 vfuncs)
        }

        [Rtti(".?AVXAPOGranularSynthesizer@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XAPOGranularSynthesizer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B37D4 (15 vfuncs)
        }

        [Rtti(".?AVXAPOIIRFilter@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XAPOIIRFilter
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B324C (16 vfuncs)
        }

        [Rtti(".?AVXAPOPrologicIIz@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XAPOPrologicIIz
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B349C (15 vfuncs)
        }

        [Rtti(".?AVXAPOStereoMixdown@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XAPOStereoMixdown
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B3394 (15 vfuncs)
        }

        [Rtti(".?AVXAPOStringendoEffect@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XAPOStringendoEffect
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B3ABC (16 vfuncs)
        }

        [Rtti(".?AVXWMAStreamDataTransfer@XA2@Driver@Sd@Engine@CDev@SQEX@@")]
        [StructLayout(LayoutKind.Explicit, Size = 0x08)]
        public unsafe struct XWMAStreamDataTransfer
        {
            [FieldOffset(0x0000)] public nint VTable; // 0x010B443C (25 vfuncs)
        }
    }
}
