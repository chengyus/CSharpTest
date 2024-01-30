using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigEditor;

[UStruct]
public partial struct ControlRigSequencerBindingProxy
{
    // StructProperty /Script/ControlRigEditor.ControlRigSequencerBindingProxy:Proxy
    static readonly int Proxy_Offset;
    public UnrealSharp.MovieScene.MovieSceneBindingProxy Proxy;
    
    // ObjectProperty /Script/ControlRigEditor.ControlRigSequencerBindingProxy:ControlRig
    static readonly int ControlRig_Offset;
    public UnrealSharp.ControlRig.ControlRig ControlRig;
    
    // ObjectProperty /Script/ControlRigEditor.ControlRigSequencerBindingProxy:Track
    static readonly int Track_Offset;
    public UnrealSharp.ControlRig.MovieSceneControlRigParameterTrack Track;
    
    
    public static readonly int NativeDataSize;
    static ControlRigSequencerBindingProxy()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigSequencerBindingProxy");
        
        Proxy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Proxy");
        ControlRig_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlRig");
        Track_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Track");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigSequencerBindingProxy(IntPtr InNativeStruct)
    {
        unsafe
        {
            Proxy = UnrealSharp.MovieScene.MovieSceneBindingProxyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Proxy_Offset), 0, null);
            ControlRig = ObjectMarshaller<UnrealSharp.ControlRig.ControlRig>.FromNative(IntPtr.Add(InNativeStruct, ControlRig_Offset), 0, null);
            Track = ObjectMarshaller<UnrealSharp.ControlRig.MovieSceneControlRigParameterTrack>.FromNative(IntPtr.Add(InNativeStruct, Track_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.MovieScene.MovieSceneBindingProxyMarshaler.ToNative(IntPtr.Add(Buffer, Proxy_Offset), 0, null, Proxy);
            ObjectMarshaller<UnrealSharp.ControlRig.ControlRig>.ToNative(IntPtr.Add(Buffer, ControlRig_Offset), 0, null, ControlRig);
            ObjectMarshaller<UnrealSharp.ControlRig.MovieSceneControlRigParameterTrack>.ToNative(IntPtr.Add(Buffer, Track_Offset), 0, null, Track);
        }
    }
}

public static class ControlRigSequencerBindingProxyMarshaler
{
    public static ControlRigSequencerBindingProxy FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigSequencerBindingProxy(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigSequencerBindingProxy obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigSequencerBindingProxy.NativeDataSize;
    }
}