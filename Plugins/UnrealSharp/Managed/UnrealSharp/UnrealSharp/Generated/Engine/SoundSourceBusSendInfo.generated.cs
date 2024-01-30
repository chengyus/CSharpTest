using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundSourceBusSendInfo
{
    // FloatProperty /Script/Engine.SoundSourceBusSendInfo:MinSendLevel
    static readonly int MinSendLevel_Offset;
    public float MinSendLevel;
    
    // FloatProperty /Script/Engine.SoundSourceBusSendInfo:MaxSendLevel
    static readonly int MaxSendLevel_Offset;
    public float MaxSendLevel;
    
    // FloatProperty /Script/Engine.SoundSourceBusSendInfo:MinSendDistance
    static readonly int MinSendDistance_Offset;
    public float MinSendDistance;
    
    // FloatProperty /Script/Engine.SoundSourceBusSendInfo:MaxSendDistance
    static readonly int MaxSendDistance_Offset;
    public float MaxSendDistance;
    
    // StructProperty /Script/Engine.SoundSourceBusSendInfo:CustomSendLevelCurve
    static readonly int CustomSendLevelCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve CustomSendLevelCurve;
    
    
    public static readonly int NativeDataSize;
    static SoundSourceBusSendInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundSourceBusSendInfo");
        
        MinSendLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSendLevel");
        MaxSendLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxSendLevel");
        MinSendDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinSendDistance");
        MaxSendDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxSendDistance");
        CustomSendLevelCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomSendLevelCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundSourceBusSendInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            MinSendLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSendLevel_Offset), 0, null);
            MaxSendLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxSendLevel_Offset), 0, null);
            MinSendDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinSendDistance_Offset), 0, null);
            MaxSendDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxSendDistance_Offset), 0, null);
            CustomSendLevelCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomSendLevelCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinSendLevel_Offset), 0, null, MinSendLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxSendLevel_Offset), 0, null, MaxSendLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinSendDistance_Offset), 0, null, MinSendDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxSendDistance_Offset), 0, null, MaxSendDistance);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, CustomSendLevelCurve_Offset), 0, null, CustomSendLevelCurve);
        }
    }
}

public static class SoundSourceBusSendInfoMarshaler
{
    public static SoundSourceBusSendInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundSourceBusSendInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundSourceBusSendInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundSourceBusSendInfo.NativeDataSize;
    }
}