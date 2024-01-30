using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SubmixEffectStereoToQuadSettings
{
    // BoolProperty /Script/Synthesis.SubmixEffectStereoToQuadSettings:bFlipChannels
    static readonly int bFlipChannels_Offset;
    public bool FlipChannels;
    
    // FloatProperty /Script/Synthesis.SubmixEffectStereoToQuadSettings:RearChannelGain
    static readonly int RearChannelGain_Offset;
    public float RearChannelGain;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectStereoToQuadSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectStereoToQuadSettings");
        
        bFlipChannels_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFlipChannels");
        RearChannelGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RearChannelGain");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectStereoToQuadSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            FlipChannels = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFlipChannels_Offset), 0, null);
            RearChannelGain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RearChannelGain_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFlipChannels_Offset), 0, null, FlipChannels);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RearChannelGain_Offset), 0, null, RearChannelGain);
        }
    }
}

public static class SubmixEffectStereoToQuadSettingsMarshaler
{
    public static SubmixEffectStereoToQuadSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectStereoToQuadSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectStereoToQuadSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectStereoToQuadSettings.NativeDataSize;
    }
}