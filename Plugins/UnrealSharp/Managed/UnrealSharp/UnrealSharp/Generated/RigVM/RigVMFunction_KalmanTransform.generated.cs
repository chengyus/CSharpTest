using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_KalmanTransform
{
    // StructProperty /Script/RigVM.RigVMFunction_KalmanTransform:Value
    static readonly int Value_Offset;
    public UnrealSharp.Transform Value;
    
    // IntProperty /Script/RigVM.RigVMFunction_KalmanTransform:BufferSize
    static readonly int BufferSize_Offset;
    public int BufferSize;
    
    // StructProperty /Script/RigVM.RigVMFunction_KalmanTransform:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_KalmanTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_KalmanTransform");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        BufferSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BufferSize");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_KalmanTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            BufferSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BufferSize_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BufferSize_Offset), 0, null, BufferSize);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_KalmanTransformMarshaler
{
    public static RigVMFunction_KalmanTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_KalmanTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_KalmanTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_KalmanTransform.NativeDataSize;
    }
}