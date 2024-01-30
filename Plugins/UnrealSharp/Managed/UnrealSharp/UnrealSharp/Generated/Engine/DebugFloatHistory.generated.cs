using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DebugFloatHistory
{
    // IntProperty /Script/Engine.DebugFloatHistory:MaxSamples
    static readonly int MaxSamples_Offset;
    public int MaxSamples;
    
    // FloatProperty /Script/Engine.DebugFloatHistory:MinValue
    static readonly int MinValue_Offset;
    public float MinValue;
    
    // FloatProperty /Script/Engine.DebugFloatHistory:MaxValue
    static readonly int MaxValue_Offset;
    public float MaxValue;
    
    // BoolProperty /Script/Engine.DebugFloatHistory:bAutoAdjustMinMax
    static readonly int bAutoAdjustMinMax_Offset;
    public bool AutoAdjustMinMax;
    
    
    public static readonly int NativeDataSize;
    static DebugFloatHistory()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DebugFloatHistory");
        
        MaxSamples_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxSamples");
        MinValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinValue");
        MaxValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxValue");
        bAutoAdjustMinMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoAdjustMinMax");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DebugFloatHistory(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaxSamples = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxSamples_Offset), 0, null);
            MinValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinValue_Offset), 0, null);
            MaxValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxValue_Offset), 0, null);
            AutoAdjustMinMax = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAutoAdjustMinMax_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxSamples_Offset), 0, null, MaxSamples);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinValue_Offset), 0, null, MinValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxValue_Offset), 0, null, MaxValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAutoAdjustMinMax_Offset), 0, null, AutoAdjustMinMax);
        }
    }
}

public static class DebugFloatHistoryMarshaler
{
    public static DebugFloatHistory FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DebugFloatHistory(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DebugFloatHistory obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DebugFloatHistory.NativeDataSize;
    }
}