using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SubmixEffectTapDelaySettings
{
    // FloatProperty /Script/Synthesis.SubmixEffectTapDelaySettings:MaximumDelayLength
    static readonly int MaximumDelayLength_Offset;
    public float MaximumDelayLength;
    
    // FloatProperty /Script/Synthesis.SubmixEffectTapDelaySettings:InterpolationTime
    static readonly int InterpolationTime_Offset;
    public float InterpolationTime;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectTapDelaySettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectTapDelaySettings");
        
        MaximumDelayLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximumDelayLength");
        InterpolationTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpolationTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectTapDelaySettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaximumDelayLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaximumDelayLength_Offset), 0, null);
            InterpolationTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InterpolationTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaximumDelayLength_Offset), 0, null, MaximumDelayLength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InterpolationTime_Offset), 0, null, InterpolationTime);
        }
    }
}

public static class SubmixEffectTapDelaySettingsMarshaler
{
    public static SubmixEffectTapDelaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectTapDelaySettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectTapDelaySettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectTapDelaySettings.NativeDataSize;
    }
}