using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneDynamicBindingPayloadVariable
{
    
    public static readonly int NativeDataSize;
    static MovieSceneDynamicBindingPayloadVariable()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneDynamicBindingPayloadVariable");
        
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneDynamicBindingPayloadVariable(IntPtr InNativeStruct)
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

public static class MovieSceneDynamicBindingPayloadVariableMarshaler
{
    public static MovieSceneDynamicBindingPayloadVariable FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneDynamicBindingPayloadVariable(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneDynamicBindingPayloadVariable obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneDynamicBindingPayloadVariable.NativeDataSize;
    }
}