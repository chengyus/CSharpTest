using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScriptingEditor;

[UStruct]
public partial struct SequencerBoundObjects
{
    // StructProperty /Script/SequencerScriptingEditor.SequencerBoundObjects:BindingProxy
    static readonly int BindingProxy_Offset;
    public UnrealSharp.MovieScene.MovieSceneBindingProxy BindingProxy;
    
    
    public static readonly int NativeDataSize;
    static SequencerBoundObjects()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SequencerBoundObjects");
        
        BindingProxy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BindingProxy");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SequencerBoundObjects(IntPtr InNativeStruct)
    {
        unsafe
        {
            BindingProxy = UnrealSharp.MovieScene.MovieSceneBindingProxyMarshaler.FromNative(IntPtr.Add(InNativeStruct, BindingProxy_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.MovieScene.MovieSceneBindingProxyMarshaler.ToNative(IntPtr.Add(Buffer, BindingProxy_Offset), 0, null, BindingProxy);
        }
    }
}

public static class SequencerBoundObjectsMarshaler
{
    public static SequencerBoundObjects FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SequencerBoundObjects(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SequencerBoundObjects obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SequencerBoundObjects.NativeDataSize;
    }
}