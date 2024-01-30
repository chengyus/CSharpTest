using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct ModularSynthPreset
{
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bEnablePolyphony
    static readonly int bEnablePolyphony_Offset;
    static readonly IntPtr bEnablePolyphony_NativeProperty;
    public bool EnablePolyphony;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:Osc1Type
    static readonly int Osc1Type_Offset;
    public UnrealSharp.Synthesis.ESynth1OscType Osc1Type;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc1Gain
    static readonly int Osc1Gain_Offset;
    public float Osc1Gain;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc1Octave
    static readonly int Osc1Octave_Offset;
    public float Osc1Octave;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc1Semitones
    static readonly int Osc1Semitones_Offset;
    public float Osc1Semitones;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc1Cents
    static readonly int Osc1Cents_Offset;
    public float Osc1Cents;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc1PulseWidth
    static readonly int Osc1PulseWidth_Offset;
    public float Osc1PulseWidth;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:Osc2Type
    static readonly int Osc2Type_Offset;
    public UnrealSharp.Synthesis.ESynth1OscType Osc2Type;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc2Gain
    static readonly int Osc2Gain_Offset;
    public float Osc2Gain;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc2Octave
    static readonly int Osc2Octave_Offset;
    public float Osc2Octave;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc2Semitones
    static readonly int Osc2Semitones_Offset;
    public float Osc2Semitones;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc2Cents
    static readonly int Osc2Cents_Offset;
    public float Osc2Cents;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Osc2PulseWidth
    static readonly int Osc2PulseWidth_Offset;
    public float Osc2PulseWidth;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Portamento
    static readonly int Portamento_Offset;
    public float Portamento;
    
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bEnableUnison
    static readonly int bEnableUnison_Offset;
    static readonly IntPtr bEnableUnison_NativeProperty;
    public bool EnableUnison;
    
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bEnableOscillatorSync
    static readonly int bEnableOscillatorSync_Offset;
    static readonly IntPtr bEnableOscillatorSync_NativeProperty;
    public bool EnableOscillatorSync;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Spread
    static readonly int Spread_Offset;
    public float Spread;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:Pan
    static readonly int Pan_Offset;
    public float Pan;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:LFO1Frequency
    static readonly int LFO1Frequency_Offset;
    public float LFO1Frequency;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:LFO1Gain
    static readonly int LFO1Gain_Offset;
    public float LFO1Gain;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:LFO1Type
    static readonly int LFO1Type_Offset;
    public UnrealSharp.Synthesis.ESynthLFOType LFO1Type;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:LFO1Mode
    static readonly int LFO1Mode_Offset;
    public UnrealSharp.Synthesis.ESynthLFOMode LFO1Mode;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:LFO1PatchType
    static readonly int LFO1PatchType_Offset;
    public UnrealSharp.Synthesis.ESynthLFOPatchType LFO1PatchType;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:LFO2Frequency
    static readonly int LFO2Frequency_Offset;
    public float LFO2Frequency;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:LFO2Gain
    static readonly int LFO2Gain_Offset;
    public float LFO2Gain;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:LFO2Type
    static readonly int LFO2Type_Offset;
    public UnrealSharp.Synthesis.ESynthLFOType LFO2Type;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:LFO2Mode
    static readonly int LFO2Mode_Offset;
    public UnrealSharp.Synthesis.ESynthLFOMode LFO2Mode;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:LFO2PatchType
    static readonly int LFO2PatchType_Offset;
    public UnrealSharp.Synthesis.ESynthLFOPatchType LFO2PatchType;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:GainDb
    static readonly int GainDb_Offset;
    public float GainDb;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:AttackTime
    static readonly int AttackTime_Offset;
    public float AttackTime;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:DecayTime
    static readonly int DecayTime_Offset;
    public float DecayTime;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:SustainGain
    static readonly int SustainGain_Offset;
    public float SustainGain;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ReleaseTime
    static readonly int ReleaseTime_Offset;
    public float ReleaseTime;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:ModEnvPatchType
    static readonly int ModEnvPatchType_Offset;
    public UnrealSharp.Synthesis.ESynthModEnvPatch ModEnvPatchType;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:ModEnvBiasPatchType
    static readonly int ModEnvBiasPatchType_Offset;
    public UnrealSharp.Synthesis.ESynthModEnvBiasPatch ModEnvBiasPatchType;
    
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bInvertModulationEnvelope
    static readonly int bInvertModulationEnvelope_Offset;
    static readonly IntPtr bInvertModulationEnvelope_NativeProperty;
    public bool InvertModulationEnvelope;
    
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bInvertModulationEnvelopeBias
    static readonly int bInvertModulationEnvelopeBias_Offset;
    static readonly IntPtr bInvertModulationEnvelopeBias_NativeProperty;
    public bool InvertModulationEnvelopeBias;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ModulationEnvelopeDepth
    static readonly int ModulationEnvelopeDepth_Offset;
    public float ModulationEnvelopeDepth;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ModulationEnvelopeAttackTime
    static readonly int ModulationEnvelopeAttackTime_Offset;
    public float ModulationEnvelopeAttackTime;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ModulationEnvelopeDecayTime
    static readonly int ModulationEnvelopeDecayTime_Offset;
    public float ModulationEnvelopeDecayTime;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ModulationEnvelopeSustainGain
    static readonly int ModulationEnvelopeSustainGain_Offset;
    public float ModulationEnvelopeSustainGain;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ModulationEnvelopeReleaseTime
    static readonly int ModulationEnvelopeReleaseTime_Offset;
    public float ModulationEnvelopeReleaseTime;
    
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bLegato
    static readonly int bLegato_Offset;
    static readonly IntPtr bLegato_NativeProperty;
    public bool Legato;
    
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bRetrigger
    static readonly int bRetrigger_Offset;
    static readonly IntPtr bRetrigger_NativeProperty;
    public bool Retrigger;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:FilterFrequency
    static readonly int FilterFrequency_Offset;
    public float FilterFrequency;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:FilterQ
    static readonly int FilterQ_Offset;
    public float FilterQ;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:FilterType
    static readonly int FilterType_Offset;
    public UnrealSharp.Synthesis.ESynthFilterType FilterType;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:FilterAlgorithm
    static readonly int FilterAlgorithm_Offset;
    public UnrealSharp.Synthesis.ESynthFilterAlgorithm FilterAlgorithm;
    
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bStereoDelayEnabled
    static readonly int bStereoDelayEnabled_Offset;
    static readonly IntPtr bStereoDelayEnabled_NativeProperty;
    public bool StereoDelayEnabled;
    
    // EnumProperty /Script/Synthesis.ModularSynthPreset:StereoDelayMode
    static readonly int StereoDelayMode_Offset;
    public UnrealSharp.Synthesis.ESynthStereoDelayMode StereoDelayMode;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:StereoDelayTime
    static readonly int StereoDelayTime_Offset;
    public float StereoDelayTime;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:StereoDelayFeedback
    static readonly int StereoDelayFeedback_Offset;
    public float StereoDelayFeedback;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:StereoDelayWetlevel
    static readonly int StereoDelayWetlevel_Offset;
    public float StereoDelayWetlevel;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:StereoDelayRatio
    static readonly int StereoDelayRatio_Offset;
    public float StereoDelayRatio;
    
    // BoolProperty /Script/Synthesis.ModularSynthPreset:bChorusEnabled
    static readonly int bChorusEnabled_Offset;
    static readonly IntPtr bChorusEnabled_NativeProperty;
    public bool ChorusEnabled;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ChorusDepth
    static readonly int ChorusDepth_Offset;
    public float ChorusDepth;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ChorusFeedback
    static readonly int ChorusFeedback_Offset;
    public float ChorusFeedback;
    
    // FloatProperty /Script/Synthesis.ModularSynthPreset:ChorusFrequency
    static readonly int ChorusFrequency_Offset;
    public float ChorusFrequency;
    
    
    public static readonly int NativeDataSize;
    static ModularSynthPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ModularSynthPreset");
        
        bEnablePolyphony_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnablePolyphony");
        bEnablePolyphony_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnablePolyphony");
        Osc1Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc1Type");
        Osc1Gain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc1Gain");
        Osc1Octave_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc1Octave");
        Osc1Semitones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc1Semitones");
        Osc1Cents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc1Cents");
        Osc1PulseWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc1PulseWidth");
        Osc2Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc2Type");
        Osc2Gain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc2Gain");
        Osc2Octave_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc2Octave");
        Osc2Semitones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc2Semitones");
        Osc2Cents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc2Cents");
        Osc2PulseWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Osc2PulseWidth");
        Portamento_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Portamento");
        bEnableUnison_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableUnison");
        bEnableUnison_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableUnison");
        bEnableOscillatorSync_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableOscillatorSync");
        bEnableOscillatorSync_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableOscillatorSync");
        Spread_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spread");
        Pan_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pan");
        LFO1Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO1Frequency");
        LFO1Gain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO1Gain");
        LFO1Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO1Type");
        LFO1Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO1Mode");
        LFO1PatchType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO1PatchType");
        LFO2Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO2Frequency");
        LFO2Gain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO2Gain");
        LFO2Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO2Type");
        LFO2Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO2Mode");
        LFO2PatchType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFO2PatchType");
        GainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GainDb");
        AttackTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttackTime");
        DecayTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DecayTime");
        SustainGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SustainGain");
        ReleaseTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReleaseTime");
        ModEnvPatchType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModEnvPatchType");
        ModEnvBiasPatchType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModEnvBiasPatchType");
        bInvertModulationEnvelope_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInvertModulationEnvelope");
        bInvertModulationEnvelope_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bInvertModulationEnvelope");
        bInvertModulationEnvelopeBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInvertModulationEnvelopeBias");
        bInvertModulationEnvelopeBias_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bInvertModulationEnvelopeBias");
        ModulationEnvelopeDepth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationEnvelopeDepth");
        ModulationEnvelopeAttackTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationEnvelopeAttackTime");
        ModulationEnvelopeDecayTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationEnvelopeDecayTime");
        ModulationEnvelopeSustainGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationEnvelopeSustainGain");
        ModulationEnvelopeReleaseTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationEnvelopeReleaseTime");
        bLegato_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLegato");
        bLegato_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLegato");
        bRetrigger_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRetrigger");
        bRetrigger_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRetrigger");
        FilterFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterFrequency");
        FilterQ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterQ");
        FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterType");
        FilterAlgorithm_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterAlgorithm");
        bStereoDelayEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bStereoDelayEnabled");
        bStereoDelayEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bStereoDelayEnabled");
        StereoDelayMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StereoDelayMode");
        StereoDelayTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StereoDelayTime");
        StereoDelayFeedback_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StereoDelayFeedback");
        StereoDelayWetlevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StereoDelayWetlevel");
        StereoDelayRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StereoDelayRatio");
        bChorusEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bChorusEnabled");
        bChorusEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bChorusEnabled");
        ChorusDepth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChorusDepth");
        ChorusFeedback_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChorusFeedback");
        ChorusFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChorusFrequency");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ModularSynthPreset(IntPtr InNativeStruct)
    {
        unsafe
        {
            EnablePolyphony = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnablePolyphony_NativeProperty, bEnablePolyphony_Offset);
            Osc1Type = BlittableMarshaller<UnrealSharp.Synthesis.ESynth1OscType>.FromNative(IntPtr.Add(InNativeStruct, Osc1Type_Offset), 0, null);
            Osc1Gain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc1Gain_Offset), 0, null);
            Osc1Octave = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc1Octave_Offset), 0, null);
            Osc1Semitones = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc1Semitones_Offset), 0, null);
            Osc1Cents = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc1Cents_Offset), 0, null);
            Osc1PulseWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc1PulseWidth_Offset), 0, null);
            Osc2Type = BlittableMarshaller<UnrealSharp.Synthesis.ESynth1OscType>.FromNative(IntPtr.Add(InNativeStruct, Osc2Type_Offset), 0, null);
            Osc2Gain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc2Gain_Offset), 0, null);
            Osc2Octave = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc2Octave_Offset), 0, null);
            Osc2Semitones = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc2Semitones_Offset), 0, null);
            Osc2Cents = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc2Cents_Offset), 0, null);
            Osc2PulseWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Osc2PulseWidth_Offset), 0, null);
            Portamento = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Portamento_Offset), 0, null);
            EnableUnison = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableUnison_NativeProperty, bEnableUnison_Offset);
            EnableOscillatorSync = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableOscillatorSync_NativeProperty, bEnableOscillatorSync_Offset);
            Spread = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Spread_Offset), 0, null);
            Pan = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Pan_Offset), 0, null);
            LFO1Frequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LFO1Frequency_Offset), 0, null);
            LFO1Gain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LFO1Gain_Offset), 0, null);
            LFO1Type = BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOType>.FromNative(IntPtr.Add(InNativeStruct, LFO1Type_Offset), 0, null);
            LFO1Mode = BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOMode>.FromNative(IntPtr.Add(InNativeStruct, LFO1Mode_Offset), 0, null);
            LFO1PatchType = BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOPatchType>.FromNative(IntPtr.Add(InNativeStruct, LFO1PatchType_Offset), 0, null);
            LFO2Frequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LFO2Frequency_Offset), 0, null);
            LFO2Gain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LFO2Gain_Offset), 0, null);
            LFO2Type = BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOType>.FromNative(IntPtr.Add(InNativeStruct, LFO2Type_Offset), 0, null);
            LFO2Mode = BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOMode>.FromNative(IntPtr.Add(InNativeStruct, LFO2Mode_Offset), 0, null);
            LFO2PatchType = BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOPatchType>.FromNative(IntPtr.Add(InNativeStruct, LFO2PatchType_Offset), 0, null);
            GainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GainDb_Offset), 0, null);
            AttackTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AttackTime_Offset), 0, null);
            DecayTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DecayTime_Offset), 0, null);
            SustainGain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SustainGain_Offset), 0, null);
            ReleaseTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReleaseTime_Offset), 0, null);
            ModEnvPatchType = BlittableMarshaller<UnrealSharp.Synthesis.ESynthModEnvPatch>.FromNative(IntPtr.Add(InNativeStruct, ModEnvPatchType_Offset), 0, null);
            ModEnvBiasPatchType = BlittableMarshaller<UnrealSharp.Synthesis.ESynthModEnvBiasPatch>.FromNative(IntPtr.Add(InNativeStruct, ModEnvBiasPatchType_Offset), 0, null);
            InvertModulationEnvelope = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bInvertModulationEnvelope_NativeProperty, bInvertModulationEnvelope_Offset);
            InvertModulationEnvelopeBias = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bInvertModulationEnvelopeBias_NativeProperty, bInvertModulationEnvelopeBias_Offset);
            ModulationEnvelopeDepth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ModulationEnvelopeDepth_Offset), 0, null);
            ModulationEnvelopeAttackTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ModulationEnvelopeAttackTime_Offset), 0, null);
            ModulationEnvelopeDecayTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ModulationEnvelopeDecayTime_Offset), 0, null);
            ModulationEnvelopeSustainGain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ModulationEnvelopeSustainGain_Offset), 0, null);
            ModulationEnvelopeReleaseTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ModulationEnvelopeReleaseTime_Offset), 0, null);
            Legato = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bLegato_NativeProperty, bLegato_Offset);
            Retrigger = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRetrigger_NativeProperty, bRetrigger_Offset);
            FilterFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilterFrequency_Offset), 0, null);
            FilterQ = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilterQ_Offset), 0, null);
            FilterType = BlittableMarshaller<UnrealSharp.Synthesis.ESynthFilterType>.FromNative(IntPtr.Add(InNativeStruct, FilterType_Offset), 0, null);
            FilterAlgorithm = BlittableMarshaller<UnrealSharp.Synthesis.ESynthFilterAlgorithm>.FromNative(IntPtr.Add(InNativeStruct, FilterAlgorithm_Offset), 0, null);
            StereoDelayEnabled = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bStereoDelayEnabled_NativeProperty, bStereoDelayEnabled_Offset);
            StereoDelayMode = BlittableMarshaller<UnrealSharp.Synthesis.ESynthStereoDelayMode>.FromNative(IntPtr.Add(InNativeStruct, StereoDelayMode_Offset), 0, null);
            StereoDelayTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StereoDelayTime_Offset), 0, null);
            StereoDelayFeedback = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StereoDelayFeedback_Offset), 0, null);
            StereoDelayWetlevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StereoDelayWetlevel_Offset), 0, null);
            StereoDelayRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StereoDelayRatio_Offset), 0, null);
            ChorusEnabled = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bChorusEnabled_NativeProperty, bChorusEnabled_Offset);
            ChorusDepth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ChorusDepth_Offset), 0, null);
            ChorusFeedback = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ChorusFeedback_Offset), 0, null);
            ChorusFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ChorusFrequency_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnablePolyphony_NativeProperty, bEnablePolyphony_Offset, EnablePolyphony);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynth1OscType>.ToNative(IntPtr.Add(Buffer, Osc1Type_Offset), 0, null, Osc1Type);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc1Gain_Offset), 0, null, Osc1Gain);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc1Octave_Offset), 0, null, Osc1Octave);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc1Semitones_Offset), 0, null, Osc1Semitones);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc1Cents_Offset), 0, null, Osc1Cents);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc1PulseWidth_Offset), 0, null, Osc1PulseWidth);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynth1OscType>.ToNative(IntPtr.Add(Buffer, Osc2Type_Offset), 0, null, Osc2Type);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc2Gain_Offset), 0, null, Osc2Gain);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc2Octave_Offset), 0, null, Osc2Octave);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc2Semitones_Offset), 0, null, Osc2Semitones);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc2Cents_Offset), 0, null, Osc2Cents);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Osc2PulseWidth_Offset), 0, null, Osc2PulseWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Portamento_Offset), 0, null, Portamento);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableUnison_NativeProperty, bEnableUnison_Offset, EnableUnison);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableOscillatorSync_NativeProperty, bEnableOscillatorSync_Offset, EnableOscillatorSync);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Spread_Offset), 0, null, Spread);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Pan_Offset), 0, null, Pan);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LFO1Frequency_Offset), 0, null, LFO1Frequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LFO1Gain_Offset), 0, null, LFO1Gain);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOType>.ToNative(IntPtr.Add(Buffer, LFO1Type_Offset), 0, null, LFO1Type);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOMode>.ToNative(IntPtr.Add(Buffer, LFO1Mode_Offset), 0, null, LFO1Mode);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOPatchType>.ToNative(IntPtr.Add(Buffer, LFO1PatchType_Offset), 0, null, LFO1PatchType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LFO2Frequency_Offset), 0, null, LFO2Frequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LFO2Gain_Offset), 0, null, LFO2Gain);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOType>.ToNative(IntPtr.Add(Buffer, LFO2Type_Offset), 0, null, LFO2Type);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOMode>.ToNative(IntPtr.Add(Buffer, LFO2Mode_Offset), 0, null, LFO2Mode);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthLFOPatchType>.ToNative(IntPtr.Add(Buffer, LFO2PatchType_Offset), 0, null, LFO2PatchType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GainDb_Offset), 0, null, GainDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AttackTime_Offset), 0, null, AttackTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DecayTime_Offset), 0, null, DecayTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SustainGain_Offset), 0, null, SustainGain);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReleaseTime_Offset), 0, null, ReleaseTime);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthModEnvPatch>.ToNative(IntPtr.Add(Buffer, ModEnvPatchType_Offset), 0, null, ModEnvPatchType);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthModEnvBiasPatch>.ToNative(IntPtr.Add(Buffer, ModEnvBiasPatchType_Offset), 0, null, ModEnvBiasPatchType);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bInvertModulationEnvelope_NativeProperty, bInvertModulationEnvelope_Offset, InvertModulationEnvelope);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bInvertModulationEnvelopeBias_NativeProperty, bInvertModulationEnvelopeBias_Offset, InvertModulationEnvelopeBias);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ModulationEnvelopeDepth_Offset), 0, null, ModulationEnvelopeDepth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ModulationEnvelopeAttackTime_Offset), 0, null, ModulationEnvelopeAttackTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ModulationEnvelopeDecayTime_Offset), 0, null, ModulationEnvelopeDecayTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ModulationEnvelopeSustainGain_Offset), 0, null, ModulationEnvelopeSustainGain);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ModulationEnvelopeReleaseTime_Offset), 0, null, ModulationEnvelopeReleaseTime);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bLegato_NativeProperty, bLegato_Offset, Legato);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRetrigger_NativeProperty, bRetrigger_Offset, Retrigger);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilterFrequency_Offset), 0, null, FilterFrequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilterQ_Offset), 0, null, FilterQ);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthFilterType>.ToNative(IntPtr.Add(Buffer, FilterType_Offset), 0, null, FilterType);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthFilterAlgorithm>.ToNative(IntPtr.Add(Buffer, FilterAlgorithm_Offset), 0, null, FilterAlgorithm);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bStereoDelayEnabled_NativeProperty, bStereoDelayEnabled_Offset, StereoDelayEnabled);
            BlittableMarshaller<UnrealSharp.Synthesis.ESynthStereoDelayMode>.ToNative(IntPtr.Add(Buffer, StereoDelayMode_Offset), 0, null, StereoDelayMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StereoDelayTime_Offset), 0, null, StereoDelayTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StereoDelayFeedback_Offset), 0, null, StereoDelayFeedback);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StereoDelayWetlevel_Offset), 0, null, StereoDelayWetlevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StereoDelayRatio_Offset), 0, null, StereoDelayRatio);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bChorusEnabled_NativeProperty, bChorusEnabled_Offset, ChorusEnabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ChorusDepth_Offset), 0, null, ChorusDepth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ChorusFeedback_Offset), 0, null, ChorusFeedback);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ChorusFrequency_Offset), 0, null, ChorusFrequency);
        }
    }
}

public static class ModularSynthPresetMarshaler
{
    public static ModularSynthPreset FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ModularSynthPreset(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ModularSynthPreset obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ModularSynthPreset.NativeDataSize;
    }
}