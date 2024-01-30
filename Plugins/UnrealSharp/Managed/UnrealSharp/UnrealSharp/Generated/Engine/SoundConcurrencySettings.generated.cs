using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundConcurrencySettings
{
    // IntProperty /Script/Engine.SoundConcurrencySettings:MaxCount
    static readonly int MaxCount_Offset;
    public int MaxCount;
    
    // BoolProperty /Script/Engine.SoundConcurrencySettings:bLimitToOwner
    static readonly int bLimitToOwner_Offset;
    static readonly IntPtr bLimitToOwner_NativeProperty;
    public bool LimitToOwner;
    
    // BoolProperty /Script/Engine.SoundConcurrencySettings:bVolumeScaleCanRelease
    static readonly int bVolumeScaleCanRelease_Offset;
    static readonly IntPtr bVolumeScaleCanRelease_NativeProperty;
    public bool VolumeScaleCanRelease;
    
    // ByteProperty /Script/Engine.SoundConcurrencySettings:ResolutionRule
    static readonly int ResolutionRule_Offset;
    public UnrealSharp.Engine.EMaxConcurrentResolutionRule ResolutionRule;
    
    // FloatProperty /Script/Engine.SoundConcurrencySettings:RetriggerTime
    static readonly int RetriggerTime_Offset;
    public float RetriggerTime;
    
    // EnumProperty /Script/Engine.SoundConcurrencySettings:VolumeScaleMode
    static readonly int VolumeScaleMode_Offset;
    public UnrealSharp.Engine.EConcurrencyVolumeScaleMode VolumeScaleMode;
    
    // FloatProperty /Script/Engine.SoundConcurrencySettings:VolumeScaleAttackTime
    static readonly int VolumeScaleAttackTime_Offset;
    public float VolumeScaleAttackTime;
    
    // FloatProperty /Script/Engine.SoundConcurrencySettings:VolumeScaleReleaseTime
    static readonly int VolumeScaleReleaseTime_Offset;
    public float VolumeScaleReleaseTime;
    
    // FloatProperty /Script/Engine.SoundConcurrencySettings:VoiceStealReleaseTime
    static readonly int VoiceStealReleaseTime_Offset;
    public float VoiceStealReleaseTime;
    
    
    public static readonly int NativeDataSize;
    static SoundConcurrencySettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundConcurrencySettings");
        
        MaxCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxCount");
        bLimitToOwner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLimitToOwner");
        bLimitToOwner_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLimitToOwner");
        bVolumeScaleCanRelease_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bVolumeScaleCanRelease");
        bVolumeScaleCanRelease_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bVolumeScaleCanRelease");
        ResolutionRule_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ResolutionRule");
        RetriggerTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RetriggerTime");
        VolumeScaleMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeScaleMode");
        VolumeScaleAttackTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeScaleAttackTime");
        VolumeScaleReleaseTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeScaleReleaseTime");
        VoiceStealReleaseTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VoiceStealReleaseTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundConcurrencySettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaxCount = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxCount_Offset), 0, null);
            LimitToOwner = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bLimitToOwner_NativeProperty, bLimitToOwner_Offset);
            VolumeScaleCanRelease = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bVolumeScaleCanRelease_NativeProperty, bVolumeScaleCanRelease_Offset);
            ResolutionRule = BlittableMarshaller<UnrealSharp.Engine.EMaxConcurrentResolutionRule>.FromNative(IntPtr.Add(InNativeStruct, ResolutionRule_Offset), 0, null);
            RetriggerTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RetriggerTime_Offset), 0, null);
            VolumeScaleMode = BlittableMarshaller<UnrealSharp.Engine.EConcurrencyVolumeScaleMode>.FromNative(IntPtr.Add(InNativeStruct, VolumeScaleMode_Offset), 0, null);
            VolumeScaleAttackTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VolumeScaleAttackTime_Offset), 0, null);
            VolumeScaleReleaseTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VolumeScaleReleaseTime_Offset), 0, null);
            VoiceStealReleaseTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VoiceStealReleaseTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxCount_Offset), 0, null, MaxCount);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bLimitToOwner_NativeProperty, bLimitToOwner_Offset, LimitToOwner);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bVolumeScaleCanRelease_NativeProperty, bVolumeScaleCanRelease_Offset, VolumeScaleCanRelease);
            BlittableMarshaller<UnrealSharp.Engine.EMaxConcurrentResolutionRule>.ToNative(IntPtr.Add(Buffer, ResolutionRule_Offset), 0, null, ResolutionRule);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RetriggerTime_Offset), 0, null, RetriggerTime);
            BlittableMarshaller<UnrealSharp.Engine.EConcurrencyVolumeScaleMode>.ToNative(IntPtr.Add(Buffer, VolumeScaleMode_Offset), 0, null, VolumeScaleMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VolumeScaleAttackTime_Offset), 0, null, VolumeScaleAttackTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VolumeScaleReleaseTime_Offset), 0, null, VolumeScaleReleaseTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VoiceStealReleaseTime_Offset), 0, null, VoiceStealReleaseTime);
        }
    }
}

public static class SoundConcurrencySettingsMarshaler
{
    public static SoundConcurrencySettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundConcurrencySettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundConcurrencySettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundConcurrencySettings.NativeDataSize;
    }
}