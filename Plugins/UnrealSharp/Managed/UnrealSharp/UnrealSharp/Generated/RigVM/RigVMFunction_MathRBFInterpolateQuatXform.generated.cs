using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathRBFInterpolateQuatXform
{
    // StructProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatXform:Output
    static readonly int Output_Offset;
    public UnrealSharp.Transform Output;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathRBFInterpolateQuatXform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathRBFInterpolateQuatXform");
        
        Output_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Output");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathRBFInterpolateQuatXform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Output = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Output_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Output_Offset), 0, null, Output);
        }
    }
}

public static class RigVMFunction_MathRBFInterpolateQuatXformMarshaler
{
    public static RigVMFunction_MathRBFInterpolateQuatXform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathRBFInterpolateQuatXform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathRBFInterpolateQuatXform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathRBFInterpolateQuatXform.NativeDataSize;
    }
}