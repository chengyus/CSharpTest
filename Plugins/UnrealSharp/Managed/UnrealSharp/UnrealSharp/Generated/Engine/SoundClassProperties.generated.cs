using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundClassProperties
{
    // FloatProperty /Script/Engine.SoundClassProperties:Volume
    static readonly int Volume_Offset;
    public float Volume;
    
    // FloatProperty /Script/Engine.SoundClassProperties:Pitch
    static readonly int Pitch_Offset;
    public float Pitch;
    
    // FloatProperty /Script/Engine.SoundClassProperties:LowPassFilterFrequency
    static readonly int LowPassFilterFrequency_Offset;
    public float LowPassFilterFrequency;
    
    // FloatProperty /Script/Engine.SoundClassProperties:AttenuationDistanceScale
    static readonly int AttenuationDistanceScale_Offset;
    public float AttenuationDistanceScale;
    
    // FloatProperty /Script/Engine.SoundClassProperties:LFEBleed
    static readonly int LFEBleed_Offset;
    public float LFEBleed;
    
    // FloatProperty /Script/Engine.SoundClassProperties:VoiceCenterChannelVolume
    static readonly int VoiceCenterChannelVolume_Offset;
    public float VoiceCenterChannelVolume;
    
    // FloatProperty /Script/Engine.SoundClassProperties:RadioFilterVolume
    static readonly int RadioFilterVolume_Offset;
    public float RadioFilterVolume;
    
    // FloatProperty /Script/Engine.SoundClassProperties:RadioFilterVolumeThreshold
    static readonly int RadioFilterVolumeThreshold_Offset;
    public float RadioFilterVolumeThreshold;
    
    // BoolProperty /Script/Engine.SoundClassProperties:bApplyEffects
    static readonly int bApplyEffects_Offset;
    static readonly IntPtr bApplyEffects_NativeProperty;
    public bool ApplyEffects;
    
    // BoolProperty /Script/Engine.SoundClassProperties:bAlwaysPlay
    static readonly int bAlwaysPlay_Offset;
    static readonly IntPtr bAlwaysPlay_NativeProperty;
    public bool AlwaysPlay;
    
    // BoolProperty /Script/Engine.SoundClassProperties:bIsUISound
    static readonly int bIsUISound_Offset;
    static readonly IntPtr bIsUISound_NativeProperty;
    public bool IsUISound;
    
    // BoolProperty /Script/Engine.SoundClassProperties:bIsMusic
    static readonly int bIsMusic_Offset;
    static readonly IntPtr bIsMusic_NativeProperty;
    public bool IsMusic;
    
    // BoolProperty /Script/Engine.SoundClassProperties:bCenterChannelOnly
    static readonly int bCenterChannelOnly_Offset;
    static readonly IntPtr bCenterChannelOnly_NativeProperty;
    public bool CenterChannelOnly;
    
    // BoolProperty /Script/Engine.SoundClassProperties:bApplyAmbientVolumes
    static readonly int bApplyAmbientVolumes_Offset;
    static readonly IntPtr bApplyAmbientVolumes_NativeProperty;
    public bool ApplyAmbientVolumes;
    
    // BoolProperty /Script/Engine.SoundClassProperties:bReverb
    static readonly int bReverb_Offset;
    static readonly IntPtr bReverb_NativeProperty;
    public bool Reverb;
    
    // FloatProperty /Script/Engine.SoundClassProperties:Default2DReverbSendAmount
    static readonly int Default2DReverbSendAmount_Offset;
    public float Default2DReverbSendAmount;
    
    // StructProperty /Script/Engine.SoundClassProperties:ModulationSettings
    static readonly int ModulationSettings_Offset;
    public UnrealSharp.Engine.SoundModulationDefaultSettings ModulationSettings;
    
    // ByteProperty /Script/Engine.SoundClassProperties:OutputTarget
    static readonly int OutputTarget_Offset;
    public UnrealSharp.Engine.EAudioOutputTarget OutputTarget;
    
    // EnumProperty /Script/Engine.SoundClassProperties:LoadingBehavior
    static readonly int LoadingBehavior_Offset;
    public UnrealSharp.Engine.ESoundWaveLoadingBehavior LoadingBehavior;
    
    // ObjectProperty /Script/Engine.SoundClassProperties:DefaultSubmix
    static readonly int DefaultSubmix_Offset;
    public UnrealSharp.Engine.SoundSubmix DefaultSubmix;
    
    
    public static readonly int NativeDataSize;
    static SoundClassProperties()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundClassProperties");
        
        Volume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Volume");
        Pitch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pitch");
        LowPassFilterFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowPassFilterFrequency");
        AttenuationDistanceScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttenuationDistanceScale");
        LFEBleed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFEBleed");
        VoiceCenterChannelVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VoiceCenterChannelVolume");
        RadioFilterVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RadioFilterVolume");
        RadioFilterVolumeThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RadioFilterVolumeThreshold");
        bApplyEffects_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyEffects");
        bApplyEffects_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bApplyEffects");
        bAlwaysPlay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAlwaysPlay");
        bAlwaysPlay_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAlwaysPlay");
        bIsUISound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsUISound");
        bIsUISound_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsUISound");
        bIsMusic_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsMusic");
        bIsMusic_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsMusic");
        bCenterChannelOnly_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCenterChannelOnly");
        bCenterChannelOnly_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCenterChannelOnly");
        bApplyAmbientVolumes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyAmbientVolumes");
        bApplyAmbientVolumes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bApplyAmbientVolumes");
        bReverb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReverb");
        bReverb_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bReverb");
        Default2DReverbSendAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Default2DReverbSendAmount");
        ModulationSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulationSettings");
        OutputTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutputTarget");
        LoadingBehavior_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LoadingBehavior");
        DefaultSubmix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultSubmix");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundClassProperties(IntPtr InNativeStruct)
    {
        unsafe
        {
            Volume = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Volume_Offset), 0, null);
            Pitch = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Pitch_Offset), 0, null);
            LowPassFilterFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LowPassFilterFrequency_Offset), 0, null);
            AttenuationDistanceScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AttenuationDistanceScale_Offset), 0, null);
            LFEBleed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LFEBleed_Offset), 0, null);
            VoiceCenterChannelVolume = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VoiceCenterChannelVolume_Offset), 0, null);
            RadioFilterVolume = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RadioFilterVolume_Offset), 0, null);
            RadioFilterVolumeThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RadioFilterVolumeThreshold_Offset), 0, null);
            ApplyEffects = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bApplyEffects_NativeProperty, bApplyEffects_Offset);
            AlwaysPlay = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAlwaysPlay_NativeProperty, bAlwaysPlay_Offset);
            IsUISound = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIsUISound_NativeProperty, bIsUISound_Offset);
            IsMusic = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIsMusic_NativeProperty, bIsMusic_Offset);
            CenterChannelOnly = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCenterChannelOnly_NativeProperty, bCenterChannelOnly_Offset);
            ApplyAmbientVolumes = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bApplyAmbientVolumes_NativeProperty, bApplyAmbientVolumes_Offset);
            Reverb = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bReverb_NativeProperty, bReverb_Offset);
            Default2DReverbSendAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Default2DReverbSendAmount_Offset), 0, null);
            ModulationSettings = UnrealSharp.Engine.SoundModulationDefaultSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, ModulationSettings_Offset), 0, null);
            OutputTarget = BlittableMarshaller<UnrealSharp.Engine.EAudioOutputTarget>.FromNative(IntPtr.Add(InNativeStruct, OutputTarget_Offset), 0, null);
            LoadingBehavior = BlittableMarshaller<UnrealSharp.Engine.ESoundWaveLoadingBehavior>.FromNative(IntPtr.Add(InNativeStruct, LoadingBehavior_Offset), 0, null);
            DefaultSubmix = ObjectMarshaller<UnrealSharp.Engine.SoundSubmix>.FromNative(IntPtr.Add(InNativeStruct, DefaultSubmix_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Volume_Offset), 0, null, Volume);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Pitch_Offset), 0, null, Pitch);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LowPassFilterFrequency_Offset), 0, null, LowPassFilterFrequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AttenuationDistanceScale_Offset), 0, null, AttenuationDistanceScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LFEBleed_Offset), 0, null, LFEBleed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VoiceCenterChannelVolume_Offset), 0, null, VoiceCenterChannelVolume);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RadioFilterVolume_Offset), 0, null, RadioFilterVolume);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RadioFilterVolumeThreshold_Offset), 0, null, RadioFilterVolumeThreshold);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bApplyEffects_NativeProperty, bApplyEffects_Offset, ApplyEffects);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAlwaysPlay_NativeProperty, bAlwaysPlay_Offset, AlwaysPlay);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIsUISound_NativeProperty, bIsUISound_Offset, IsUISound);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIsMusic_NativeProperty, bIsMusic_Offset, IsMusic);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCenterChannelOnly_NativeProperty, bCenterChannelOnly_Offset, CenterChannelOnly);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bApplyAmbientVolumes_NativeProperty, bApplyAmbientVolumes_Offset, ApplyAmbientVolumes);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bReverb_NativeProperty, bReverb_Offset, Reverb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Default2DReverbSendAmount_Offset), 0, null, Default2DReverbSendAmount);
            UnrealSharp.Engine.SoundModulationDefaultSettingsMarshaler.ToNative(IntPtr.Add(Buffer, ModulationSettings_Offset), 0, null, ModulationSettings);
            BlittableMarshaller<UnrealSharp.Engine.EAudioOutputTarget>.ToNative(IntPtr.Add(Buffer, OutputTarget_Offset), 0, null, OutputTarget);
            BlittableMarshaller<UnrealSharp.Engine.ESoundWaveLoadingBehavior>.ToNative(IntPtr.Add(Buffer, LoadingBehavior_Offset), 0, null, LoadingBehavior);
            ObjectMarshaller<UnrealSharp.Engine.SoundSubmix>.ToNative(IntPtr.Add(Buffer, DefaultSubmix_Offset), 0, null, DefaultSubmix);
        }
    }
}

public static class SoundClassPropertiesMarshaler
{
    public static SoundClassProperties FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundClassProperties(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundClassProperties obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundClassProperties.NativeDataSize;
    }
}