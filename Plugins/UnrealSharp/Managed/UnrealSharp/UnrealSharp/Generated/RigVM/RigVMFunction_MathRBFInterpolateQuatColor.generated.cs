using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathRBFInterpolateQuatColor
{
    // StructProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatColor:Output
    static readonly int Output_Offset;
    public UnrealSharp.CoreUObject.LinearColor Output;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathRBFInterpolateQuatColor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathRBFInterpolateQuatColor");
        
        Output_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Output");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathRBFInterpolateQuatColor(IntPtr InNativeStruct)
    {
        unsafe
        {
            Output = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Output_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Output_Offset), 0, null, Output);
        }
    }
}

public static class RigVMFunction_MathRBFInterpolateQuatColorMarshaler
{
    public static RigVMFunction_MathRBFInterpolateQuatColor FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathRBFInterpolateQuatColor(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathRBFInterpolateQuatColor obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathRBFInterpolateQuatColor.NativeDataSize;
    }
}