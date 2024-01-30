using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangePipelines;

[UStruct]
public partial struct InterchangePipelineMeshesUtilitiesContext
{
    
    public static readonly int NativeDataSize;
    static InterchangePipelineMeshesUtilitiesContext()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterchangePipelineMeshesUtilitiesContext");
        
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterchangePipelineMeshesUtilitiesContext(IntPtr InNativeStruct)
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

public static class InterchangePipelineMeshesUtilitiesContextMarshaler
{
    public static InterchangePipelineMeshesUtilitiesContext FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterchangePipelineMeshesUtilitiesContext(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterchangePipelineMeshesUtilitiesContext obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterchangePipelineMeshesUtilitiesContext.NativeDataSize;
    }
}