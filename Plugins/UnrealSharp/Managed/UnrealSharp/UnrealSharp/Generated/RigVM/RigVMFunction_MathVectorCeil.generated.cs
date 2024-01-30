using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorCeil
{
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorCeil()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorCeil");
        
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorCeil(IntPtr InNativeStruct)
    {
        unsafe
        {
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
        }
    }
}

public static class RigVMFunction_MathVectorCeilMarshaler
{
    public static RigVMFunction_MathVectorCeil FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorCeil(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorCeil obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorCeil.NativeDataSize;
    }
}