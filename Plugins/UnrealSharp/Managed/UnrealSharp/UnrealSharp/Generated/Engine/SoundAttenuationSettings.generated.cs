using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundAttenuationSettings
{
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bAttenuate
    static readonly int bAttenuate_Offset;
    static readonly IntPtr bAttenuate_NativeProperty;
    public bool Attenuate;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bSpatialize
    static readonly int bSpatialize_Offset;
    static readonly IntPtr bSpatialize_NativeProperty;
    public bool Spatialize;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bAttenuateWithLPF
    static readonly int bAttenuateWithLPF_Offset;
    static readonly IntPtr bAttenuateWithLPF_NativeProperty;
    public bool AttenuateWithLPF;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnableListenerFocus
    static readonly int bEnableListenerFocus_Offset;
    static readonly IntPtr bEnableListenerFocus_NativeProperty;
    public bool EnableListenerFocus;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnableFocusInterpolation
    static readonly int bEnableFocusInterpolation_Offset;
    static readonly IntPtr bEnableFocusInterpolation_NativeProperty;
    public bool EnableFocusInterpolation;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnableOcclusion
    static readonly int bEnableOcclusion_Offset;
    static readonly IntPtr bEnableOcclusion_NativeProperty;
    public bool EnableOcclusion;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bUseComplexCollisionForOcclusion
    static readonly int bUseComplexCollisionForOcclusion_Offset;
    static readonly IntPtr bUseComplexCollisionForOcclusion_NativeProperty;
    public bool UseComplexCollisionForOcclusion;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnableReverbSend
    static readonly int bEnableReverbSend_Offset;
    static readonly IntPtr bEnableReverbSend_NativeProperty;
    public bool EnableReverbSend;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnablePriorityAttenuation
    static readonly int bEnablePriorityAttenuation_Offset;
    static readonly IntPtr bEnablePriorityAttenuation_NativeProperty;
    public bool EnablePriorityAttenuation;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bApplyNormalizationToStereoSounds
    static readonly int bApplyNormalizationToStereoSounds_Offset;
    static readonly IntPtr bApplyNormalizationToStereoSounds_NativeProperty;
    public bool ApplyNormalizationToStereoSounds;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnableLogFrequencyScaling
    static readonly int bEnableLogFrequencyScaling_Offset;
    static readonly IntPtr bEnableLogFrequencyScaling_NativeProperty;
    public bool EnableLogFrequencyScaling;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnableSubmixSends
    static readonly int bEnableSubmixSends_Offset;
    static readonly IntPtr bEnableSubmixSends_NativeProperty;
    public bool EnableSubmixSends;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnableSourceDataOverride
    static readonly int bEnableSourceDataOverride_Offset;
    static readonly IntPtr bEnableSourceDataOverride_NativeProperty;
    public bool EnableSourceDataOverride;
    
    // BoolProperty /Script/Engine.SoundAttenuationSettings:bEnableSendToAudioLink
    static readonly int bEnableSendToAudioLink_Offset;
    static readonly IntPtr bEnableSendToAudioLink_NativeProperty;
    public bool EnableSendToAudioLink;
    
    // ByteProperty /Script/Engine.SoundAttenuationSettings:SpatializationAlgorithm
    static readonly int SpatializationAlgorithm_Offset;
    public UnrealSharp.Engine.ESoundSpatializationAlgorithm SpatializationAlgorithm;
    
    // ObjectProperty /Script/Engine.SoundAttenuationSettings:AudioLinkSettingsOverride
    static readonly int AudioLinkSettingsOverride_Offset;
    public UnrealSharp.AudioLinkCore.AudioLinkSettingsAbstract AudioLinkSettingsOverride;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:BinauralRadius
    static readonly int BinauralRadius_Offset;
    public float BinauralRadius;
    
    // StructProperty /Script/Engine.SoundAttenuationSettings:CustomLowpassAirAbsorptionCurve
    static readonly int CustomLowpassAirAbsorptionCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve CustomLowpassAirAbsorptionCurve;
    
    // StructProperty /Script/Engine.SoundAttenuationSettings:CustomHighpassAirAbsorptionCurve
    static readonly int CustomHighpassAirAbsorptionCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve CustomHighpassAirAbsorptionCurve;
    
    // EnumProperty /Script/Engine.SoundAttenuationSettings:AbsorptionMethod
    static readonly int AbsorptionMethod_Offset;
    public UnrealSharp.Engine.EAirAbsorptionMethod AbsorptionMethod;
    
    // ByteProperty /Script/Engine.SoundAttenuationSettings:OcclusionTraceChannel
    static readonly int OcclusionTraceChannel_Offset;
    public UnrealSharp.Engine.ECollisionChannel OcclusionTraceChannel;
    
    // EnumProperty /Script/Engine.SoundAttenuationSettings:ReverbSendMethod
    static readonly int ReverbSendMethod_Offset;
    public UnrealSharp.Engine.EReverbSendMethod ReverbSendMethod;
    
    // EnumProperty /Script/Engine.SoundAttenuationSettings:PriorityAttenuationMethod
    static readonly int PriorityAttenuationMethod_Offset;
    public UnrealSharp.Engine.EPriorityAttenuationMethod PriorityAttenuationMethod;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:NonSpatializedRadiusStart
    static readonly int NonSpatializedRadiusStart_Offset;
    public float NonSpatializedRadiusStart;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:NonSpatializedRadiusEnd
    static readonly int NonSpatializedRadiusEnd_Offset;
    public float NonSpatializedRadiusEnd;
    
    // EnumProperty /Script/Engine.SoundAttenuationSettings:NonSpatializedRadiusMode
    static readonly int NonSpatializedRadiusMode_Offset;
    public UnrealSharp.Engine.ENonSpatializedRadiusSpeakerMapMode NonSpatializedRadiusMode;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:StereoSpread
    static readonly int StereoSpread_Offset;
    public float StereoSpread;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:LPFRadiusMin
    static readonly int LPFRadiusMin_Offset;
    public float LPFRadiusMin;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:LPFRadiusMax
    static readonly int LPFRadiusMax_Offset;
    public float LPFRadiusMax;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:LPFFrequencyAtMin
    static readonly int LPFFrequencyAtMin_Offset;
    public float LPFFrequencyAtMin;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:LPFFrequencyAtMax
    static readonly int LPFFrequencyAtMax_Offset;
    public float LPFFrequencyAtMax;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:HPFFrequencyAtMin
    static readonly int HPFFrequencyAtMin_Offset;
    public float HPFFrequencyAtMin;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:HPFFrequencyAtMax
    static readonly int HPFFrequencyAtMax_Offset;
    public float HPFFrequencyAtMax;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:FocusAzimuth
    static readonly int FocusAzimuth_Offset;
    public float FocusAzimuth;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:NonFocusAzimuth
    static readonly int NonFocusAzimuth_Offset;
    public float NonFocusAzimuth;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:FocusDistanceScale
    static readonly int FocusDistanceScale_Offset;
    public float FocusDistanceScale;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:NonFocusDistanceScale
    static readonly int NonFocusDistanceScale_Offset;
    public float NonFocusDistanceScale;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:FocusPriorityScale
    static readonly int FocusPriorityScale_Offset;
    public float FocusPriorityScale;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:NonFocusPriorityScale
    static readonly int NonFocusPriorityScale_Offset;
    public float NonFocusPriorityScale;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:FocusVolumeAttenuation
    static readonly int FocusVolumeAttenuation_Offset;
    public float FocusVolumeAttenuation;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:NonFocusVolumeAttenuation
    static readonly int NonFocusVolumeAttenuation_Offset;
    public float NonFocusVolumeAttenuation;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:FocusAttackInterpSpeed
    static readonly int FocusAttackInterpSpeed_Offset;
    public float FocusAttackInterpSpeed;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:FocusReleaseInterpSpeed
    static readonly int FocusReleaseInterpSpeed_Offset;
    public float FocusReleaseInterpSpeed;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:OcclusionLowPassFilterFrequency
    static readonly int OcclusionLowPassFilterFrequency_Offset;
    public float OcclusionLowPassFilterFrequency;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:OcclusionVolumeAttenuation
    static readonly int OcclusionVolumeAttenuation_Offset;
    public float OcclusionVolumeAttenuation;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:OcclusionInterpolationTime
    static readonly int OcclusionInterpolationTime_Offset;
    public float OcclusionInterpolationTime;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:ReverbWetLevelMin
    static readonly int ReverbWetLevelMin_Offset;
    public float ReverbWetLevelMin;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:ReverbWetLevelMax
    static readonly int ReverbWetLevelMax_Offset;
    public float ReverbWetLevelMax;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:ReverbDistanceMin
    static readonly int ReverbDistanceMin_Offset;
    public float ReverbDistanceMin;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:ReverbDistanceMax
    static readonly int ReverbDistanceMax_Offset;
    public float ReverbDistanceMax;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:ManualReverbSendLevel
    static readonly int ManualReverbSendLevel_Offset;
    public float ManualReverbSendLevel;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:PriorityAttenuationMin
    static readonly int PriorityAttenuationMin_Offset;
    public float PriorityAttenuationMin;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:PriorityAttenuationMax
    static readonly int PriorityAttenuationMax_Offset;
    public float PriorityAttenuationMax;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:PriorityAttenuationDistanceMin
    static readonly int PriorityAttenuationDistanceMin_Offset;
    public float PriorityAttenuationDistanceMin;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:PriorityAttenuationDistanceMax
    static readonly int PriorityAttenuationDistanceMax_Offset;
    public float PriorityAttenuationDistanceMax;
    
    // FloatProperty /Script/Engine.SoundAttenuationSettings:ManualPriorityAttenuation
    static readonly int ManualPriorityAttenuation_Offset;
    public float ManualPriorityAttenuation;
    
    // StructProperty /Script/Engine.SoundAttenuationSettings:CustomReverbSendCurve
    static readonly int CustomReverbSendCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve CustomReverbSendCurve;
    
    // StructProperty /Script/Engine.SoundAttenuationSettings:CustomPriorityAttenuationCurve
    static readonly int CustomPriorityAttenuationCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve CustomPriorityAttenuationCurve;
    
    // StructProperty /Script/Engine.SoundAttenuationSettings:PluginSettings
    static readonly int PluginSettings_Offset;
    public UnrealSharp.Engine.SoundAttenuationPluginSettings PluginSettings;
    
    
    public static readonly int NativeDataSize;
    static SoundAttenuationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundAttenuationSettings");
        
        bAttenuate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAttenuate");
        bAttenuate_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAttenuate");
        bSpatialize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSpatialize");
        bSpatialize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSpatialize");
        bAttenuateWithLPF_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAttenuateWithLPF");
        bAttenuateWithLPF_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAttenuateWithLPF");
        bEnableListenerFocus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableListenerFocus");
        bEnableListenerFocus_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableListenerFocus");
        bEnableFocusInterpolation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableFocusInterpolation");
        bEnableFocusInterpolation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableFocusInterpolation");
        bEnableOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableOcclusion");
        bEnableOcclusion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableOcclusion");
        bUseComplexCollisionForOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseComplexCollisionForOcclusion");
        bUseComplexCollisionForOcclusion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseComplexCollisionForOcclusion");
        bEnableReverbSend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableReverbSend");
        bEnableReverbSend_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableReverbSend");
        bEnablePriorityAttenuation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnablePriorityAttenuation");
        bEnablePriorityAttenuation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnablePriorityAttenuation");
        bApplyNormalizationToStereoSounds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyNormalizationToStereoSounds");
        bApplyNormalizationToStereoSounds_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bApplyNormalizationToStereoSounds");
        bEnableLogFrequencyScaling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableLogFrequencyScaling");
        bEnableLogFrequencyScaling_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableLogFrequencyScaling");
        bEnableSubmixSends_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableSubmixSends");
        bEnableSubmixSends_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableSubmixSends");
        bEnableSourceDataOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableSourceDataOverride");
        bEnableSourceDataOverride_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableSourceDataOverride");
        bEnableSendToAudioLink_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableSendToAudioLink");
        bEnableSendToAudioLink_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableSendToAudioLink");
        SpatializationAlgorithm_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpatializationAlgorithm");
        AudioLinkSettingsOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AudioLinkSettingsOverride");
        BinauralRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BinauralRadius");
        CustomLowpassAirAbsorptionCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomLowpassAirAbsorptionCurve");
        CustomHighpassAirAbsorptionCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomHighpassAirAbsorptionCurve");
        AbsorptionMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AbsorptionMethod");
        OcclusionTraceChannel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionTraceChannel");
        ReverbSendMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbSendMethod");
        PriorityAttenuationMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PriorityAttenuationMethod");
        NonSpatializedRadiusStart_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NonSpatializedRadiusStart");
        NonSpatializedRadiusEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NonSpatializedRadiusEnd");
        NonSpatializedRadiusMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NonSpatializedRadiusMode");
        StereoSpread_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StereoSpread");
        LPFRadiusMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LPFRadiusMin");
        LPFRadiusMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LPFRadiusMax");
        LPFFrequencyAtMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LPFFrequencyAtMin");
        LPFFrequencyAtMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LPFFrequencyAtMax");
        HPFFrequencyAtMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HPFFrequencyAtMin");
        HPFFrequencyAtMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HPFFrequencyAtMax");
        FocusAzimuth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusAzimuth");
        NonFocusAzimuth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NonFocusAzimuth");
        FocusDistanceScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusDistanceScale");
        NonFocusDistanceScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NonFocusDistanceScale");
        FocusPriorityScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusPriorityScale");
        NonFocusPriorityScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NonFocusPriorityScale");
        FocusVolumeAttenuation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusVolumeAttenuation");
        NonFocusVolumeAttenuation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NonFocusVolumeAttenuation");
        FocusAttackInterpSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusAttackInterpSpeed");
        FocusReleaseInterpSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusReleaseInterpSpeed");
        OcclusionLowPassFilterFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionLowPassFilterFrequency");
        OcclusionVolumeAttenuation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionVolumeAttenuation");
        OcclusionInterpolationTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionInterpolationTime");
        ReverbWetLevelMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbWetLevelMin");
        ReverbWetLevelMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbWetLevelMax");
        ReverbDistanceMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbDistanceMin");
        ReverbDistanceMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbDistanceMax");
        ManualReverbSendLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ManualReverbSendLevel");
        PriorityAttenuationMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PriorityAttenuationMin");
        PriorityAttenuationMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PriorityAttenuationMax");
        PriorityAttenuationDistanceMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PriorityAttenuationDistanceMin");
        PriorityAttenuationDistanceMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PriorityAttenuationDistanceMax");
        ManualPriorityAttenuation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ManualPriorityAttenuation");
        CustomReverbSendCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomReverbSendCurve");
        CustomPriorityAttenuationCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomPriorityAttenuationCurve");
        PluginSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PluginSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundAttenuationSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Attenuate = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAttenuate_NativeProperty, bAttenuate_Offset);
            Spatialize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSpatialize_NativeProperty, bSpatialize_Offset);
            AttenuateWithLPF = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAttenuateWithLPF_NativeProperty, bAttenuateWithLPF_Offset);
            EnableListenerFocus = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableListenerFocus_NativeProperty, bEnableListenerFocus_Offset);
            EnableFocusInterpolation = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableFocusInterpolation_NativeProperty, bEnableFocusInterpolation_Offset);
            EnableOcclusion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableOcclusion_NativeProperty, bEnableOcclusion_Offset);
            UseComplexCollisionForOcclusion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseComplexCollisionForOcclusion_NativeProperty, bUseComplexCollisionForOcclusion_Offset);
            EnableReverbSend = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableReverbSend_NativeProperty, bEnableReverbSend_Offset);
            EnablePriorityAttenuation = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnablePriorityAttenuation_NativeProperty, bEnablePriorityAttenuation_Offset);
            ApplyNormalizationToStereoSounds = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bApplyNormalizationToStereoSounds_NativeProperty, bApplyNormalizationToStereoSounds_Offset);
            EnableLogFrequencyScaling = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableLogFrequencyScaling_NativeProperty, bEnableLogFrequencyScaling_Offset);
            EnableSubmixSends = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableSubmixSends_NativeProperty, bEnableSubmixSends_Offset);
            EnableSourceDataOverride = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableSourceDataOverride_NativeProperty, bEnableSourceDataOverride_Offset);
            EnableSendToAudioLink = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableSendToAudioLink_NativeProperty, bEnableSendToAudioLink_Offset);
            SpatializationAlgorithm = BlittableMarshaller<UnrealSharp.Engine.ESoundSpatializationAlgorithm>.FromNative(IntPtr.Add(InNativeStruct, SpatializationAlgorithm_Offset), 0, null);
            AudioLinkSettingsOverride = ObjectMarshaller<UnrealSharp.AudioLinkCore.AudioLinkSettingsAbstract>.FromNative(IntPtr.Add(InNativeStruct, AudioLinkSettingsOverride_Offset), 0, null);
            BinauralRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BinauralRadius_Offset), 0, null);
            CustomLowpassAirAbsorptionCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomLowpassAirAbsorptionCurve_Offset), 0, null);
            CustomHighpassAirAbsorptionCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomHighpassAirAbsorptionCurve_Offset), 0, null);
            AbsorptionMethod = BlittableMarshaller<UnrealSharp.Engine.EAirAbsorptionMethod>.FromNative(IntPtr.Add(InNativeStruct, AbsorptionMethod_Offset), 0, null);
            OcclusionTraceChannel = BlittableMarshaller<UnrealSharp.Engine.ECollisionChannel>.FromNative(IntPtr.Add(InNativeStruct, OcclusionTraceChannel_Offset), 0, null);
            ReverbSendMethod = BlittableMarshaller<UnrealSharp.Engine.EReverbSendMethod>.FromNative(IntPtr.Add(InNativeStruct, ReverbSendMethod_Offset), 0, null);
            PriorityAttenuationMethod = BlittableMarshaller<UnrealSharp.Engine.EPriorityAttenuationMethod>.FromNative(IntPtr.Add(InNativeStruct, PriorityAttenuationMethod_Offset), 0, null);
            NonSpatializedRadiusStart = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NonSpatializedRadiusStart_Offset), 0, null);
            NonSpatializedRadiusEnd = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NonSpatializedRadiusEnd_Offset), 0, null);
            NonSpatializedRadiusMode = BlittableMarshaller<UnrealSharp.Engine.ENonSpatializedRadiusSpeakerMapMode>.FromNative(IntPtr.Add(InNativeStruct, NonSpatializedRadiusMode_Offset), 0, null);
            StereoSpread = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StereoSpread_Offset), 0, null);
            LPFRadiusMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LPFRadiusMin_Offset), 0, null);
            LPFRadiusMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LPFRadiusMax_Offset), 0, null);
            LPFFrequencyAtMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LPFFrequencyAtMin_Offset), 0, null);
            LPFFrequencyAtMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LPFFrequencyAtMax_Offset), 0, null);
            HPFFrequencyAtMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HPFFrequencyAtMin_Offset), 0, null);
            HPFFrequencyAtMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HPFFrequencyAtMax_Offset), 0, null);
            FocusAzimuth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusAzimuth_Offset), 0, null);
            NonFocusAzimuth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NonFocusAzimuth_Offset), 0, null);
            FocusDistanceScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusDistanceScale_Offset), 0, null);
            NonFocusDistanceScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NonFocusDistanceScale_Offset), 0, null);
            FocusPriorityScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusPriorityScale_Offset), 0, null);
            NonFocusPriorityScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NonFocusPriorityScale_Offset), 0, null);
            FocusVolumeAttenuation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusVolumeAttenuation_Offset), 0, null);
            NonFocusVolumeAttenuation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NonFocusVolumeAttenuation_Offset), 0, null);
            FocusAttackInterpSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusAttackInterpSpeed_Offset), 0, null);
            FocusReleaseInterpSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusReleaseInterpSpeed_Offset), 0, null);
            OcclusionLowPassFilterFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OcclusionLowPassFilterFrequency_Offset), 0, null);
            OcclusionVolumeAttenuation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OcclusionVolumeAttenuation_Offset), 0, null);
            OcclusionInterpolationTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OcclusionInterpolationTime_Offset), 0, null);
            ReverbWetLevelMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReverbWetLevelMin_Offset), 0, null);
            ReverbWetLevelMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReverbWetLevelMax_Offset), 0, null);
            ReverbDistanceMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReverbDistanceMin_Offset), 0, null);
            ReverbDistanceMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReverbDistanceMax_Offset), 0, null);
            ManualReverbSendLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ManualReverbSendLevel_Offset), 0, null);
            PriorityAttenuationMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PriorityAttenuationMin_Offset), 0, null);
            PriorityAttenuationMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PriorityAttenuationMax_Offset), 0, null);
            PriorityAttenuationDistanceMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PriorityAttenuationDistanceMin_Offset), 0, null);
            PriorityAttenuationDistanceMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PriorityAttenuationDistanceMax_Offset), 0, null);
            ManualPriorityAttenuation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ManualPriorityAttenuation_Offset), 0, null);
            CustomReverbSendCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomReverbSendCurve_Offset), 0, null);
            CustomPriorityAttenuationCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomPriorityAttenuationCurve_Offset), 0, null);
            PluginSettings = UnrealSharp.Engine.SoundAttenuationPluginSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, PluginSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAttenuate_NativeProperty, bAttenuate_Offset, Attenuate);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSpatialize_NativeProperty, bSpatialize_Offset, Spatialize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAttenuateWithLPF_NativeProperty, bAttenuateWithLPF_Offset, AttenuateWithLPF);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableListenerFocus_NativeProperty, bEnableListenerFocus_Offset, EnableListenerFocus);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableFocusInterpolation_NativeProperty, bEnableFocusInterpolation_Offset, EnableFocusInterpolation);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableOcclusion_NativeProperty, bEnableOcclusion_Offset, EnableOcclusion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseComplexCollisionForOcclusion_NativeProperty, bUseComplexCollisionForOcclusion_Offset, UseComplexCollisionForOcclusion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableReverbSend_NativeProperty, bEnableReverbSend_Offset, EnableReverbSend);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnablePriorityAttenuation_NativeProperty, bEnablePriorityAttenuation_Offset, EnablePriorityAttenuation);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bApplyNormalizationToStereoSounds_NativeProperty, bApplyNormalizationToStereoSounds_Offset, ApplyNormalizationToStereoSounds);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableLogFrequencyScaling_NativeProperty, bEnableLogFrequencyScaling_Offset, EnableLogFrequencyScaling);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableSubmixSends_NativeProperty, bEnableSubmixSends_Offset, EnableSubmixSends);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableSourceDataOverride_NativeProperty, bEnableSourceDataOverride_Offset, EnableSourceDataOverride);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableSendToAudioLink_NativeProperty, bEnableSendToAudioLink_Offset, EnableSendToAudioLink);
            BlittableMarshaller<UnrealSharp.Engine.ESoundSpatializationAlgorithm>.ToNative(IntPtr.Add(Buffer, SpatializationAlgorithm_Offset), 0, null, SpatializationAlgorithm);
            ObjectMarshaller<UnrealSharp.AudioLinkCore.AudioLinkSettingsAbstract>.ToNative(IntPtr.Add(Buffer, AudioLinkSettingsOverride_Offset), 0, null, AudioLinkSettingsOverride);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BinauralRadius_Offset), 0, null, BinauralRadius);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, CustomLowpassAirAbsorptionCurve_Offset), 0, null, CustomLowpassAirAbsorptionCurve);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, CustomHighpassAirAbsorptionCurve_Offset), 0, null, CustomHighpassAirAbsorptionCurve);
            BlittableMarshaller<UnrealSharp.Engine.EAirAbsorptionMethod>.ToNative(IntPtr.Add(Buffer, AbsorptionMethod_Offset), 0, null, AbsorptionMethod);
            BlittableMarshaller<UnrealSharp.Engine.ECollisionChannel>.ToNative(IntPtr.Add(Buffer, OcclusionTraceChannel_Offset), 0, null, OcclusionTraceChannel);
            BlittableMarshaller<UnrealSharp.Engine.EReverbSendMethod>.ToNative(IntPtr.Add(Buffer, ReverbSendMethod_Offset), 0, null, ReverbSendMethod);
            BlittableMarshaller<UnrealSharp.Engine.EPriorityAttenuationMethod>.ToNative(IntPtr.Add(Buffer, PriorityAttenuationMethod_Offset), 0, null, PriorityAttenuationMethod);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NonSpatializedRadiusStart_Offset), 0, null, NonSpatializedRadiusStart);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NonSpatializedRadiusEnd_Offset), 0, null, NonSpatializedRadiusEnd);
            BlittableMarshaller<UnrealSharp.Engine.ENonSpatializedRadiusSpeakerMapMode>.ToNative(IntPtr.Add(Buffer, NonSpatializedRadiusMode_Offset), 0, null, NonSpatializedRadiusMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StereoSpread_Offset), 0, null, StereoSpread);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LPFRadiusMin_Offset), 0, null, LPFRadiusMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LPFRadiusMax_Offset), 0, null, LPFRadiusMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LPFFrequencyAtMin_Offset), 0, null, LPFFrequencyAtMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LPFFrequencyAtMax_Offset), 0, null, LPFFrequencyAtMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HPFFrequencyAtMin_Offset), 0, null, HPFFrequencyAtMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HPFFrequencyAtMax_Offset), 0, null, HPFFrequencyAtMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusAzimuth_Offset), 0, null, FocusAzimuth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NonFocusAzimuth_Offset), 0, null, NonFocusAzimuth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusDistanceScale_Offset), 0, null, FocusDistanceScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NonFocusDistanceScale_Offset), 0, null, NonFocusDistanceScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusPriorityScale_Offset), 0, null, FocusPriorityScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NonFocusPriorityScale_Offset), 0, null, NonFocusPriorityScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusVolumeAttenuation_Offset), 0, null, FocusVolumeAttenuation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NonFocusVolumeAttenuation_Offset), 0, null, NonFocusVolumeAttenuation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusAttackInterpSpeed_Offset), 0, null, FocusAttackInterpSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusReleaseInterpSpeed_Offset), 0, null, FocusReleaseInterpSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OcclusionLowPassFilterFrequency_Offset), 0, null, OcclusionLowPassFilterFrequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OcclusionVolumeAttenuation_Offset), 0, null, OcclusionVolumeAttenuation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OcclusionInterpolationTime_Offset), 0, null, OcclusionInterpolationTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReverbWetLevelMin_Offset), 0, null, ReverbWetLevelMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReverbWetLevelMax_Offset), 0, null, ReverbWetLevelMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReverbDistanceMin_Offset), 0, null, ReverbDistanceMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReverbDistanceMax_Offset), 0, null, ReverbDistanceMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ManualReverbSendLevel_Offset), 0, null, ManualReverbSendLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PriorityAttenuationMin_Offset), 0, null, PriorityAttenuationMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PriorityAttenuationMax_Offset), 0, null, PriorityAttenuationMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PriorityAttenuationDistanceMin_Offset), 0, null, PriorityAttenuationDistanceMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PriorityAttenuationDistanceMax_Offset), 0, null, PriorityAttenuationDistanceMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ManualPriorityAttenuation_Offset), 0, null, ManualPriorityAttenuation);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, CustomReverbSendCurve_Offset), 0, null, CustomReverbSendCurve);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, CustomPriorityAttenuationCurve_Offset), 0, null, CustomPriorityAttenuationCurve);
            UnrealSharp.Engine.SoundAttenuationPluginSettingsMarshaler.ToNative(IntPtr.Add(Buffer, PluginSettings_Offset), 0, null, PluginSettings);
        }
    }
}

public static class SoundAttenuationSettingsMarshaler
{
    public static SoundAttenuationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundAttenuationSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundAttenuationSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundAttenuationSettings.NativeDataSize;
    }
}