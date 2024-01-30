using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathMatrixFromTransformV2
{
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixFromTransformV2:Value
    static readonly int Value_Offset;
    public UnrealSharp.Transform Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathMatrixFromTransformV2:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Matrix4x4 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathMatrixFromTransformV2()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathMatrixFromTransformV2");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathMatrixFromTransformV2(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Matrix4x4>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Matrix4x4>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathMatrixFromTransformV2Marshaler
{
    public static RigVMFunction_MathMatrixFromTransformV2 FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathMatrixFromTransformV2(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathMatrixFromTransformV2 obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathMatrixFromTransformV2.NativeDataSize;
    }
}