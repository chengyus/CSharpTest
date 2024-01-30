using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UStruct]
public partial struct SubmixEffectReverbSettings
{
    // BoolProperty /Script/AudioMixer.SubmixEffectReverbSettings:bBypassEarlyReflections
    static readonly int bBypassEarlyReflections_Offset;
    public bool BypassEarlyReflections;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:ReflectionsDelay
    static readonly int ReflectionsDelay_Offset;
    public float ReflectionsDelay;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:GainHF
    static readonly int GainHF_Offset;
    public float GainHF;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:ReflectionsGain
    static readonly int ReflectionsGain_Offset;
    public float ReflectionsGain;
    
    // BoolProperty /Script/AudioMixer.SubmixEffectReverbSettings:bBypassLateReflections
    static readonly int bBypassLateReflections_Offset;
    public bool BypassLateReflections;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:LateDelay
    static readonly int LateDelay_Offset;
    public float LateDelay;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:DecayTime
    static readonly int DecayTime_Offset;
    public float DecayTime;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:Density
    static readonly int Density_Offset;
    public float Density;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:Diffusion
    static readonly int Diffusion_Offset;
    public float Diffusion;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:AirAbsorptionGainHF
    static readonly int AirAbsorptionGainHF_Offset;
    public float AirAbsorptionGainHF;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:DecayHFRatio
    static readonly int DecayHFRatio_Offset;
    public float DecayHFRatio;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:LateGain
    static readonly int LateGain_Offset;
    public float LateGain;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:Gain
    static readonly int Gain_Offset;
    public float Gain;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:WetLevel
    static readonly int WetLevel_Offset;
    public float WetLevel;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectReverbSettings:DryLevel
    static readonly int DryLevel_Offset;
    public float DryLevel;
    
    // BoolProperty /Script/AudioMixer.SubmixEffectReverbSettings:bBypass
    static readonly int bBypass_Offset;
    public bool Bypass;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectReverbSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectReverbSettings");
        
        bBypassEarlyReflections_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypassEarlyReflections");
        ReflectionsDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReflectionsDelay");
        GainHF_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GainHF");
        ReflectionsGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReflectionsGain");
        bBypassLateReflections_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypassLateReflections");
        LateDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LateDelay");
        DecayTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DecayTime");
        Density_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Density");
        Diffusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Diffusion");
        AirAbsorptionGainHF_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AirAbsorptionGainHF");
        DecayHFRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DecayHFRatio");
        LateGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LateGain");
        Gain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Gain");
        WetLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetLevel");
        DryLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryLevel");
        bBypass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypass");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectReverbSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            BypassEarlyReflections = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bBypassEarlyReflections_Offset), 0, null);
            ReflectionsDelay = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReflectionsDelay_Offset), 0, null);
            GainHF = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GainHF_Offset), 0, null);
            ReflectionsGain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReflectionsGain_Offset), 0, null);
            BypassLateReflections = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bBypassLateReflections_Offset), 0, null);
            LateDelay = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LateDelay_Offset), 0, null);
            DecayTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DecayTime_Offset), 0, null);
            Density = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Density_Offset), 0, null);
            Diffusion = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Diffusion_Offset), 0, null);
            AirAbsorptionGainHF = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AirAbsorptionGainHF_Offset), 0, null);
            DecayHFRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DecayHFRatio_Offset), 0, null);
            LateGain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LateGain_Offset), 0, null);
            Gain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Gain_Offset), 0, null);
            WetLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WetLevel_Offset), 0, null);
            DryLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DryLevel_Offset), 0, null);
            Bypass = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bBypass_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bBypassEarlyReflections_Offset), 0, null, BypassEarlyReflections);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReflectionsDelay_Offset), 0, null, ReflectionsDelay);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GainHF_Offset), 0, null, GainHF);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReflectionsGain_Offset), 0, null, ReflectionsGain);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bBypassLateReflections_Offset), 0, null, BypassLateReflections);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LateDelay_Offset), 0, null, LateDelay);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DecayTime_Offset), 0, null, DecayTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Density_Offset), 0, null, Density);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Diffusion_Offset), 0, null, Diffusion);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AirAbsorptionGainHF_Offset), 0, null, AirAbsorptionGainHF);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DecayHFRatio_Offset), 0, null, DecayHFRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LateGain_Offset), 0, null, LateGain);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Gain_Offset), 0, null, Gain);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WetLevel_Offset), 0, null, WetLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DryLevel_Offset), 0, null, DryLevel);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bBypass_Offset), 0, null, Bypass);
        }
    }
}

public static class SubmixEffectReverbSettingsMarshaler
{
    public static SubmixEffectReverbSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectReverbSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectReverbSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectReverbSettings.NativeDataSize;
    }
}