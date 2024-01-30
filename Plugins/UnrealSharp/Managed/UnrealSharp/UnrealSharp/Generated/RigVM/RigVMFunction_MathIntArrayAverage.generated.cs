using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathIntArrayAverage
{
    // IntProperty /Script/RigVM.RigVMFunction_MathIntArrayAverage:Average
    static readonly int Average_Offset;
    public int Average;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathIntArrayAverage()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathIntArrayAverage");
        
        Average_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Average");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathIntArrayAverage(IntPtr InNativeStruct)
    {
        unsafe
        {
            Average = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Average_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Average_Offset), 0, null, Average);
        }
    }
}

public static class RigVMFunction_MathIntArrayAverageMarshaler
{
    public static RigVMFunction_MathIntArrayAverage FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathIntArrayAverage(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathIntArrayAverage obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathIntArrayAverage.NativeDataSize;
    }
}