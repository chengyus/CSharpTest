using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathRBFInterpolateQuatQuat
{
    // StructProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatQuat:Output
    static readonly int Output_Offset;
    public System.DoubleNumerics.Quaternion Output;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathRBFInterpolateQuatQuat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathRBFInterpolateQuatQuat");
        
        Output_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Output");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathRBFInterpolateQuatQuat(IntPtr InNativeStruct)
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

public static class RigVMFunction_MathRBFInterpolateQuatQuatMarshaler
{
    public static RigVMFunction_MathRBFInterpolateQuatQuat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathRBFInterpolateQuatQuat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathRBFInterpolateQuatQuat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathRBFInterpolateQuatQuat.NativeDataSize;
    }
}