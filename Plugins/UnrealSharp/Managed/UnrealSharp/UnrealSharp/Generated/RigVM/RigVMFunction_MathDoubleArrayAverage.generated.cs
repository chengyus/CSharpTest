using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleArrayAverage
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleArrayAverage:Average
    static readonly int Average_Offset;
    public double Average;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleArrayAverage()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleArrayAverage");
        
        Average_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Average");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleArrayAverage(IntPtr InNativeStruct)
    {
        unsafe
        {
            Average = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Average_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Average_Offset), 0, null, Average);
        }
    }
}

public static class RigVMFunction_MathDoubleArrayAverageMarshaler
{
    public static RigVMFunction_MathDoubleArrayAverage FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleArrayAverage(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleArrayAverage obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleArrayAverage.NativeDataSize;
    }
}