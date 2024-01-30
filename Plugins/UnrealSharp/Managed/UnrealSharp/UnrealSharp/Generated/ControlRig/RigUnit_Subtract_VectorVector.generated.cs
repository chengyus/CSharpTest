using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_Subtract_VectorVector
{
    
    public static readonly int NativeDataSize;
    static RigUnit_Subtract_VectorVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_Subtract_VectorVector");
        
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_Subtract_VectorVector(IntPtr InNativeStruct)
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

public static class RigUnit_Subtract_VectorVectorMarshaler
{
    public static RigUnit_Subtract_VectorVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_Subtract_VectorVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_Subtract_VectorVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_Subtract_VectorVector.NativeDataSize;
    }
}