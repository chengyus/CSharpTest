using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorFromDouble
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathVectorFromDouble:Value
    static readonly int Value_Offset;
    public double Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorFromDouble:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorFromDouble()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorFromDouble");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorFromDouble(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathVectorFromDoubleMarshaler
{
    public static RigVMFunction_MathVectorFromDouble FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorFromDouble(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorFromDouble obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorFromDouble.NativeDataSize;
    }
}