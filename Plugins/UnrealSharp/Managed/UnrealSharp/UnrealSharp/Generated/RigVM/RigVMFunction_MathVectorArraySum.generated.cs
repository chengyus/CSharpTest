using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorArraySum
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorArraySum:Sum
    static readonly int Sum_Offset;
    public System.DoubleNumerics.Vector3 Sum;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorArraySum()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorArraySum");
        
        Sum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorArraySum(IntPtr InNativeStruct)
    {
        unsafe
        {
            Sum = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Sum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Sum_Offset), 0, null, Sum);
        }
    }
}

public static class RigVMFunction_MathVectorArraySumMarshaler
{
    public static RigVMFunction_MathVectorArraySum FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorArraySum(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorArraySum obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorArraySum.NativeDataSize;
    }
}