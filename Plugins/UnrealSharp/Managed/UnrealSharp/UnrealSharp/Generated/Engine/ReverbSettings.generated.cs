using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ReverbSettings
{
    // BoolProperty /Script/Engine.ReverbSettings:bApplyReverb
    static readonly int bApplyReverb_Offset;
    public bool ApplyReverb;
    
    // ObjectProperty /Script/Engine.ReverbSettings:ReverbEffect
    static readonly int ReverbEffect_Offset;
    public UnrealSharp.Engine.ReverbEffect ReverbEffect;
    
    // ObjectProperty /Script/Engine.ReverbSettings:ReverbPluginEffect
    static readonly int ReverbPluginEffect_Offset;
    public UnrealSharp.Engine.SoundEffectSubmixPreset ReverbPluginEffect;
    
    // FloatProperty /Script/Engine.ReverbSettings:Volume
    static readonly int Volume_Offset;
    public float Volume;
    
    // FloatProperty /Script/Engine.ReverbSettings:FadeTime
    static readonly int FadeTime_Offset;
    public float FadeTime;
    
    
    public static readonly int NativeDataSize;
    static ReverbSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ReverbSettings");
        
        bApplyReverb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyReverb");
        ReverbEffect_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbEffect");
        ReverbPluginEffect_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReverbPluginEffect");
        Volume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Volume");
        FadeTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FadeTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ReverbSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ApplyReverb = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplyReverb_Offset), 0, null);
            ReverbEffect = ObjectMarshaller<UnrealSharp.Engine.ReverbEffect>.FromNative(IntPtr.Add(InNativeStruct, ReverbEffect_Offset), 0, null);
            ReverbPluginEffect = ObjectMarshaller<UnrealSharp.Engine.SoundEffectSubmixPreset>.FromNative(IntPtr.Add(InNativeStruct, ReverbPluginEffect_Offset), 0, null);
            Volume = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Volume_Offset), 0, null);
            FadeTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FadeTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplyReverb_Offset), 0, null, ApplyReverb);
            ObjectMarshaller<UnrealSharp.Engine.ReverbEffect>.ToNative(IntPtr.Add(Buffer, ReverbEffect_Offset), 0, null, ReverbEffect);
            ObjectMarshaller<UnrealSharp.Engine.SoundEffectSubmixPreset>.ToNative(IntPtr.Add(Buffer, ReverbPluginEffect_Offset), 0, null, ReverbPluginEffect);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Volume_Offset), 0, null, Volume);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FadeTime_Offset), 0, null, FadeTime);
        }
    }
}

public static class ReverbSettingsMarshaler
{
    public static ReverbSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ReverbSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ReverbSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ReverbSettings.NativeDataSize;
    }
}