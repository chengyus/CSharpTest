using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathFloatArraySum
{
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatArraySum:Sum
    static readonly int Sum_Offset;
    public float Sum;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathFloatArraySum()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathFloatArraySum");
        
        Sum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathFloatArraySum(IntPtr InNativeStruct)
    {
        unsafe
        {
            Sum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Sum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Sum_Offset), 0, null, Sum);
        }
    }
}

public static class RigVMFunction_MathFloatArraySumMarshaler
{
    public static RigVMFunction_MathFloatArraySum FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathFloatArraySum(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathFloatArraySum obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathFloatArraySum.NativeDataSize;
    }
}