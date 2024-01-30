using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct TapDelayInfo
{
    // EnumProperty /Script/Synthesis.TapDelayInfo:TapLineMode
    static readonly int TapLineMode_Offset;
    public UnrealSharp.Synthesis.ETapLineMode TapLineMode;
    
    // FloatProperty /Script/Synthesis.TapDelayInfo:DelayLength
    static readonly int DelayLength_Offset;
    public float DelayLength;
    
    // FloatProperty /Script/Synthesis.TapDelayInfo:Gain
    static readonly int Gain_Offset;
    public float Gain;
    
    // IntProperty /Script/Synthesis.TapDelayInfo:OutputChannel
    static readonly int OutputChannel_Offset;
    public int OutputChannel;
    
    // FloatProperty /Script/Synthesis.TapDelayInfo:PanInDegrees
    static readonly int PanInDegrees_Offset;
    public float PanInDegrees;
    
    
    public static readonly int NativeDataSize;
    static TapDelayInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TapDelayInfo");
        
        TapLineMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TapLineMode");
        DelayLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DelayLength");
        Gain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Gain");
        OutputChannel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutputChannel");
        PanInDegrees_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PanInDegrees");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TapDelayInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            TapLineMode = BlittableMarshaller<UnrealSharp.Synthesis.ETapLineMode>.FromNative(IntPtr.Add(InNativeStruct, TapLineMode_Offset), 0, null);
            DelayLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DelayLength_Offset), 0, null);
            Gain = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Gain_Offset), 0, null);
            OutputChannel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, OutputChannel_Offset), 0, null);
            PanInDegrees = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PanInDegrees_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ETapLineMode>.ToNative(IntPtr.Add(Buffer, TapLineMode_Offset), 0, null, TapLineMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DelayLength_Offset), 0, null, DelayLength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Gain_Offset), 0, null, Gain);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, OutputChannel_Offset), 0, null, OutputChannel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PanInDegrees_Offset), 0, null, PanInDegrees);
        }
    }
}

public static class TapDelayInfoMarshaler
{
    public static TapDelayInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TapDelayInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TapDelayInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TapDelayInfo.NativeDataSize;
    }
}