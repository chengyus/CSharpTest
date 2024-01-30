using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_KalmanFloat
{
    // FloatProperty /Script/RigVM.RigVMFunction_KalmanFloat:Value
    static readonly int Value_Offset;
    public float Value;
    
    // IntProperty /Script/RigVM.RigVMFunction_KalmanFloat:BufferSize
    static readonly int BufferSize_Offset;
    public int BufferSize;
    
    // FloatProperty /Script/RigVM.RigVMFunction_KalmanFloat:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_KalmanFloat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_KalmanFloat");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        BufferSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BufferSize");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_KalmanFloat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            BufferSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BufferSize_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BufferSize_Offset), 0, null, BufferSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_KalmanFloatMarshaler
{
    public static RigVMFunction_KalmanFloat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_KalmanFloat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_KalmanFloat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_KalmanFloat.NativeDataSize;
    }
}