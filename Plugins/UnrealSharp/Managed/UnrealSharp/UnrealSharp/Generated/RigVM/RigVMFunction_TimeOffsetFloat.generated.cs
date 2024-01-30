using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_TimeOffsetFloat
{
    // FloatProperty /Script/RigVM.RigVMFunction_TimeOffsetFloat:Value
    static readonly int Value_Offset;
    public float Value;
    
    // FloatProperty /Script/RigVM.RigVMFunction_TimeOffsetFloat:SecondsAgo
    static readonly int SecondsAgo_Offset;
    public float SecondsAgo;
    
    // IntProperty /Script/RigVM.RigVMFunction_TimeOffsetFloat:BufferSize
    static readonly int BufferSize_Offset;
    public int BufferSize;
    
    // FloatProperty /Script/RigVM.RigVMFunction_TimeOffsetFloat:TimeRange
    static readonly int TimeRange_Offset;
    public float TimeRange;
    
    // FloatProperty /Script/RigVM.RigVMFunction_TimeOffsetFloat:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_TimeOffsetFloat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_TimeOffsetFloat");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        SecondsAgo_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondsAgo");
        BufferSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BufferSize");
        TimeRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TimeRange");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_TimeOffsetFloat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            SecondsAgo = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SecondsAgo_Offset), 0, null);
            BufferSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BufferSize_Offset), 0, null);
            TimeRange = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TimeRange_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SecondsAgo_Offset), 0, null, SecondsAgo);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BufferSize_Offset), 0, null, BufferSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TimeRange_Offset), 0, null, TimeRange);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_TimeOffsetFloatMarshaler
{
    public static RigVMFunction_TimeOffsetFloat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_TimeOffsetFloat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_TimeOffsetFloat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_TimeOffsetFloat.NativeDataSize;
    }
}