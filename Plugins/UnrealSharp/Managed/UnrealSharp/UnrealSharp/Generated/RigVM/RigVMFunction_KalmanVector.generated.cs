using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_KalmanVector
{
    // StructProperty /Script/RigVM.RigVMFunction_KalmanVector:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // IntProperty /Script/RigVM.RigVMFunction_KalmanVector:BufferSize
    static readonly int BufferSize_Offset;
    public int BufferSize;
    
    // StructProperty /Script/RigVM.RigVMFunction_KalmanVector:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_KalmanVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_KalmanVector");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        BufferSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BufferSize");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_KalmanVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            BufferSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BufferSize_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BufferSize_Offset), 0, null, BufferSize);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_KalmanVectorMarshaler
{
    public static RigVMFunction_KalmanVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_KalmanVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_KalmanVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_KalmanVector.NativeDataSize;
    }
}