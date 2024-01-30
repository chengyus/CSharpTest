using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathFloatArrayAverage
{
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatArrayAverage:Average
    static readonly int Average_Offset;
    public float Average;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathFloatArrayAverage()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathFloatArrayAverage");
        
        Average_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Average");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathFloatArrayAverage(IntPtr InNativeStruct)
    {
        unsafe
        {
            Average = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Average_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Average_Offset), 0, null, Average);
        }
    }
}

public static class RigVMFunction_MathFloatArrayAverageMarshaler
{
    public static RigVMFunction_MathFloatArrayAverage FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathFloatArrayAverage(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathFloatArrayAverage obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathFloatArrayAverage.NativeDataSize;
    }
}