using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorArrayAverage
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorArrayAverage:Average
    static readonly int Average_Offset;
    public System.DoubleNumerics.Vector3 Average;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorArrayAverage()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorArrayAverage");
        
        Average_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Average");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorArrayAverage(IntPtr InNativeStruct)
    {
        unsafe
        {
            Average = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Average_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Average_Offset), 0, null, Average);
        }
    }
}

public static class RigVMFunction_MathVectorArrayAverageMarshaler
{
    public static RigVMFunction_MathVectorArrayAverage FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorArrayAverage(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorArrayAverage obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorArrayAverage.NativeDataSize;
    }
}