using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathIntArraySum
{
    // IntProperty /Script/RigVM.RigVMFunction_MathIntArraySum:Sum
    static readonly int Sum_Offset;
    public int Sum;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathIntArraySum()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathIntArraySum");
        
        Sum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathIntArraySum(IntPtr InNativeStruct)
    {
        unsafe
        {
            Sum = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Sum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Sum_Offset), 0, null, Sum);
        }
    }
}

public static class RigVMFunction_MathIntArraySumMarshaler
{
    public static RigVMFunction_MathIntArraySum FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathIntArraySum(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathIntArraySum obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathIntArraySum.NativeDataSize;
    }
}