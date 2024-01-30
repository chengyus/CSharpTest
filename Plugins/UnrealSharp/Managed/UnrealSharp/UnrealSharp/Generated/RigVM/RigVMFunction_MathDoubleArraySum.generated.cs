using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleArraySum
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleArraySum:Sum
    static readonly int Sum_Offset;
    public double Sum;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleArraySum()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleArraySum");
        
        Sum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleArraySum(IntPtr InNativeStruct)
    {
        unsafe
        {
            Sum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Sum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Sum_Offset), 0, null, Sum);
        }
    }
}

public static class RigVMFunction_MathDoubleArraySumMarshaler
{
    public static RigVMFunction_MathDoubleArraySum FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleArraySum(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleArraySum obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleArraySum.NativeDataSize;
    }
}