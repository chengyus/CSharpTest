using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathRBFInterpolateVectorQuat
{
    // StructProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateVectorQuat:Output
    static readonly int Output_Offset;
    public System.DoubleNumerics.Quaternion Output;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathRBFInterpolateVectorQuat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathRBFInterpolateVectorQuat");
        
        Output_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Output");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathRBFInterpolateVectorQuat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Output = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Output_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Output_Offset), 0, null, Output);
        }
    }
}

public static class RigVMFunction_MathRBFInterpolateVectorQuatMarshaler
{
    public static RigVMFunction_MathRBFInterpolateVectorQuat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathRBFInterpolateVectorQuat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathRBFInterpolateVectorQuat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathRBFInterpolateVectorQuat.NativeDataSize;
    }
}