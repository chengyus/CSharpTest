using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolPresetAsset;

[UStruct]
public partial struct InteractiveToolPresetStore
{
    
    public static readonly int NativeDataSize;
    static InteractiveToolPresetStore()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InteractiveToolPresetStore");
        
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InteractiveToolPresetStore(IntPtr InNativeStruct)
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

public static class InteractiveToolPresetStoreMarshaler
{
    public static InteractiveToolPresetStore FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InteractiveToolPresetStore(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InteractiveToolPresetStore obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InteractiveToolPresetStore.NativeDataSize;
    }
}