using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectFilterAudioBusModulationSettings
{
    // ObjectProperty /Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:AudioBus
    static readonly int AudioBus_Offset;
    public UnrealSharp.Engine.AudioBus AudioBus;
    
    // IntProperty /Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:EnvelopeFollowerAttackTimeMsec
    static readonly int EnvelopeFollowerAttackTimeMsec_Offset;
    public int EnvelopeFollowerAttackTimeMsec;
    
    // IntProperty /Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:EnvelopeFollowerReleaseTimeMsec
    static readonly int EnvelopeFollowerReleaseTimeMsec_Offset;
    public int EnvelopeFollowerReleaseTimeMsec;
    
    // FloatProperty /Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:EnvelopeGainMultiplier
    static readonly int EnvelopeGainMultiplier_Offset;
    public float EnvelopeGainMultiplier;
    
    // FloatProperty /Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:MinFrequencyModulation
    static readonly int MinFrequencyModulation_Offset;
    public float MinFrequencyModulation;
    
    // FloatProperty /Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:MaxFrequencyModulation
    static readonly int MaxFrequencyModulation_Offset;
    public float MaxFrequencyModulation;
    
    // FloatProperty /Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:MinResonanceModulation
    static readonly int MinResonanceModulation_Offset;
    public float MinResonanceModulation;
    
    // FloatProperty /Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:MaxResonanceModulation
    static readonly int MaxResonanceModulation_Offset;
    public float MaxResonanceModulation;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectFilterAudioBusModulationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectFilterAudioBusModulationSettings");
        
        AudioBus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AudioBus");
        EnvelopeFollowerAttackTimeMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnvelopeFollowerAttackTimeMsec");
        EnvelopeFollowerReleaseTimeMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnvelopeFollowerReleaseTimeMsec");
        EnvelopeGainMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnvelopeGainMultiplier");
        MinFrequencyModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinFrequencyModulation");
        MaxFrequencyModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxFrequencyModulation");
        MinResonanceModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinResonanceModulation");
        MaxResonanceModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxResonanceModulation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectFilterAudioBusModulationSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            AudioBus = ObjectMarshaller<UnrealSharp.Engine.AudioBus>.FromNative(IntPtr.Add(InNativeStruct, AudioBus_Offset), 0, null);
            EnvelopeFollowerAttackTimeMsec = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, EnvelopeFollowerAttackTimeMsec_Offset), 0, null);
            EnvelopeFollowerReleaseTimeMsec = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, EnvelopeFollowerReleaseTimeMsec_Offset), 0, null);
            EnvelopeGainMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, EnvelopeGainMultiplier_Offset), 0, null);
            MinFrequencyModulation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinFrequencyModulation_Offset), 0, null);
            MaxFrequencyModulation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxFrequencyModulation_Offset), 0, null);
            MinResonanceModulation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinResonanceModulation_Offset), 0, null);
            MaxResonanceModulation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxResonanceModulation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.AudioBus>.ToNative(IntPtr.Add(Buffer, AudioBus_Offset), 0, null, AudioBus);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, EnvelopeFollowerAttackTimeMsec_Offset), 0, null, EnvelopeFollowerAttackTimeMsec);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, EnvelopeFollowerReleaseTimeMsec_Offset), 0, null, EnvelopeFollowerReleaseTimeMsec);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, EnvelopeGainMultiplier_Offset), 0, null, EnvelopeGainMultiplier);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinFrequencyModulation_Offset), 0, null, MinFrequencyModulation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxFrequencyModulation_Offset), 0, null, MaxFrequencyModulation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinResonanceModulation_Offset), 0, null, MinResonanceModulation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxResonanceModulation_Offset), 0, null, MaxResonanceModulation);
        }
    }
}

public static class SourceEffectFilterAudioBusModulationSettingsMarshaler
{
    public static SourceEffectFilterAudioBusModulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectFilterAudioBusModulationSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectFilterAudioBusModulationSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectFilterAudioBusModulationSettings.NativeDataSize;
    }
}