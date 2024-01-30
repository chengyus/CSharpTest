using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundEngine;

[UStruct]
public partial struct MetaSoundBuilderNodeOutputHandle
{
    
    public static readonly int NativeDataSize;
    static MetaSoundBuilderNodeOutputHandle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MetaSoundBuilderNodeOutputHandle");
        
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MetaSoundBuilderNodeOutputHandle(IntPtr InNativeStruct)
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

public static class MetaSoundBuilderNodeOutputHandleMarshaler
{
    public static MetaSoundBuilderNodeOutputHandle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MetaSoundBuilderNodeOutputHandle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MetaSoundBuilderNodeOutputHandle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MetaSoundBuilderNodeOutputHandle.NativeDataSize;
    }
}