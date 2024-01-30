using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UStruct]
public partial struct SubmixEffectDynamicsProcessorSettings
{
    // EnumProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:DynamicsProcessorType
    static readonly int DynamicsProcessorType_Offset;
    public UnrealSharp.AudioMixer.ESubmixEffectDynamicsProcessorType DynamicsProcessorType;
    
    // EnumProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:PeakMode
    static readonly int PeakMode_Offset;
    public UnrealSharp.AudioMixer.ESubmixEffectDynamicsPeakMode PeakMode;
    
    // EnumProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:LinkMode
    static readonly int LinkMode_Offset;
    public UnrealSharp.AudioMixer.ESubmixEffectDynamicsChannelLinkMode LinkMode;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:InputGainDb
    static readonly int InputGainDb_Offset;
    public float InputGainDb;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:ThresholdDb
    static readonly int ThresholdDb_Offset;
    public float ThresholdDb;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:Ratio
    static readonly int Ratio_Offset;
    public float Ratio;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KneeBandwidthDb
    static readonly int KneeBandwidthDb_Offset;
    public float KneeBandwidthDb;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:LookAheadMsec
    static readonly int LookAheadMsec_Offset;
    public float LookAheadMsec;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:AttackTimeMsec
    static readonly int AttackTimeMsec_Offset;
    public float AttackTimeMsec;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:ReleaseTimeMsec
    static readonly int ReleaseTimeMsec_Offset;
    public float ReleaseTimeMsec;
    
    // EnumProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KeySource
    static readonly int KeySource_Offset;
    public UnrealSharp.AudioMixer.ESubmixEffectDynamicsKeySource KeySource;
    
    // ObjectProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:ExternalAudioBus
    static readonly int ExternalAudioBus_Offset;
    public UnrealSharp.Engine.AudioBus ExternalAudioBus;
    
    // ObjectProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:ExternalSubmix
    static readonly int ExternalSubmix_Offset;
    public UnrealSharp.Engine.SoundSubmix ExternalSubmix;
    
    // BoolProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:bAnalogMode
    static readonly int bAnalogMode_Offset;
    static readonly IntPtr bAnalogMode_NativeProperty;
    public bool AnalogMode;
    
    // BoolProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:bBypass
    static readonly int bBypass_Offset;
    static readonly IntPtr bBypass_NativeProperty;
    public bool Bypass;
    
    // BoolProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:bKeyAudition
    static readonly int bKeyAudition_Offset;
    static readonly IntPtr bKeyAudition_NativeProperty;
    public bool KeyAudition;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KeyGainDb
    static readonly int KeyGainDb_Offset;
    public float KeyGainDb;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:OutputGainDb
    static readonly int OutputGainDb_Offset;
    public float OutputGainDb;
    
    // StructProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KeyHighshelf
    static readonly int KeyHighshelf_Offset;
    public UnrealSharp.AudioMixer.SubmixEffectDynamicProcessorFilterSettings KeyHighshelf;
    
    // StructProperty /Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KeyLowshelf
    static readonly int KeyLowshelf_Offset;
    public UnrealSharp.AudioMixer.SubmixEffectDynamicProcessorFilterSettings KeyLowshelf;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectDynamicsProcessorSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectDynamicsProcessorSettings");
        
        DynamicsProcessorType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DynamicsProcessorType");
        PeakMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PeakMode");
        LinkMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LinkMode");
        InputGainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InputGainDb");
        ThresholdDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ThresholdDb");
        Ratio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Ratio");
        KneeBandwidthDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KneeBandwidthDb");
        LookAheadMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LookAheadMsec");
        AttackTimeMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttackTimeMsec");
        ReleaseTimeMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReleaseTimeMsec");
        KeySource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeySource");
        ExternalAudioBus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExternalAudioBus");
        ExternalSubmix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExternalSubmix");
        bAnalogMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAnalogMode");
        bAnalogMode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAnalogMode");
        bBypass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypass");
        bBypass_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bBypass");
        bKeyAudition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bKeyAudition");
        bKeyAudition_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bKeyAudition");
        KeyGainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeyGainDb");
        OutputGainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutputGainDb");
        KeyHighshelf_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeyHighshelf");
        KeyLowshelf_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeyLowshelf");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectDynamicsProcessorSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DynamicsProcessorType = BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsProcessorType>.FromNative(IntPtr.Add(InNativeStruct, DynamicsProcessorType_Offset), 0, null);
            PeakMode = BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsPeakMode>.FromNative(IntPtr.Add(InNativeStruct, PeakMode_Offset), 0, null);
            LinkMode = BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsChannelLinkMode>.FromNative(IntPtr.Add(InNativeStruct, LinkMode_Offset), 0, null);
            InputGainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InputGainDb_Offset), 0, null);
            ThresholdDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ThresholdDb_Offset), 0, null);
            Ratio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Ratio_Offset), 0, null);
            KneeBandwidthDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, KneeBandwidthDb_Offset), 0, null);
            LookAheadMsec = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LookAheadMsec_Offset), 0, null);
            AttackTimeMsec = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AttackTimeMsec_Offset), 0, null);
            ReleaseTimeMsec = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReleaseTimeMsec_Offset), 0, null);
            KeySource = BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsKeySource>.FromNative(IntPtr.Add(InNativeStruct, KeySource_Offset), 0, null);
            ExternalAudioBus = ObjectMarshaller<UnrealSharp.Engine.AudioBus>.FromNative(IntPtr.Add(InNativeStruct, ExternalAudioBus_Offset), 0, null);
            ExternalSubmix = ObjectMarshaller<UnrealSharp.Engine.SoundSubmix>.FromNative(IntPtr.Add(InNativeStruct, ExternalSubmix_Offset), 0, null);
            AnalogMode = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAnalogMode_NativeProperty, bAnalogMode_Offset);
            Bypass = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bBypass_NativeProperty, bBypass_Offset);
            KeyAudition = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bKeyAudition_NativeProperty, bKeyAudition_Offset);
            KeyGainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, KeyGainDb_Offset), 0, null);
            OutputGainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OutputGainDb_Offset), 0, null);
            KeyHighshelf = UnrealSharp.AudioMixer.SubmixEffectDynamicProcessorFilterSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, KeyHighshelf_Offset), 0, null);
            KeyLowshelf = UnrealSharp.AudioMixer.SubmixEffectDynamicProcessorFilterSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, KeyLowshelf_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsProcessorType>.ToNative(IntPtr.Add(Buffer, DynamicsProcessorType_Offset), 0, null, DynamicsProcessorType);
            BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsPeakMode>.ToNative(IntPtr.Add(Buffer, PeakMode_Offset), 0, null, PeakMode);
            BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsChannelLinkMode>.ToNative(IntPtr.Add(Buffer, LinkMode_Offset), 0, null, LinkMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InputGainDb_Offset), 0, null, InputGainDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ThresholdDb_Offset), 0, null, ThresholdDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Ratio_Offset), 0, null, Ratio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, KneeBandwidthDb_Offset), 0, null, KneeBandwidthDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LookAheadMsec_Offset), 0, null, LookAheadMsec);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AttackTimeMsec_Offset), 0, null, AttackTimeMsec);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReleaseTimeMsec_Offset), 0, null, ReleaseTimeMsec);
            BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsKeySource>.ToNative(IntPtr.Add(Buffer, KeySource_Offset), 0, null, KeySource);
            ObjectMarshaller<UnrealSharp.Engine.AudioBus>.ToNative(IntPtr.Add(Buffer, ExternalAudioBus_Offset), 0, null, ExternalAudioBus);
            ObjectMarshaller<UnrealSharp.Engine.SoundSubmix>.ToNative(IntPtr.Add(Buffer, ExternalSubmix_Offset), 0, null, ExternalSubmix);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAnalogMode_NativeProperty, bAnalogMode_Offset, AnalogMode);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bBypass_NativeProperty, bBypass_Offset, Bypass);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bKeyAudition_NativeProperty, bKeyAudition_Offset, KeyAudition);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, KeyGainDb_Offset), 0, null, KeyGainDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OutputGainDb_Offset), 0, null, OutputGainDb);
            UnrealSharp.AudioMixer.SubmixEffectDynamicProcessorFilterSettingsMarshaler.ToNative(IntPtr.Add(Buffer, KeyHighshelf_Offset), 0, null, KeyHighshelf);
            UnrealSharp.AudioMixer.SubmixEffectDynamicProcessorFilterSettingsMarshaler.ToNative(IntPtr.Add(Buffer, KeyLowshelf_Offset), 0, null, KeyLowshelf);
        }
    }
}

public static class SubmixEffectDynamicsProcessorSettingsMarshaler
{
    public static SubmixEffectDynamicsProcessorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectDynamicsProcessorSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectDynamicsProcessorSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectDynamicsProcessorSettings.NativeDataSize;
    }
}