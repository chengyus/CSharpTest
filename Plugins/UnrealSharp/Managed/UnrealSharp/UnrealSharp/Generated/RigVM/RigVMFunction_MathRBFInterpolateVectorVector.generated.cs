using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathRBFInterpolateVectorVector
{
    // StructProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateVectorVector:Output
    static readonly int Output_Offset;
    public System.DoubleNumerics.Vector3 Output;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathRBFInterpolateVectorVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathRBFInterpolateVectorVector");
        
        Output_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Output");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathRBFInterpolateVectorVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Output = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Output_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Output_Offset), 0, null, Output);
        }
    }
}

public static class RigVMFunction_MathRBFInterpolateVectorVectorMarshaler
{
    public static RigVMFunction_MathRBFInterpolateVectorVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathRBFInterpolateVectorVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathRBFInterpolateVectorVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathRBFInterpolateVectorVector.NativeDataSize;
    }
}