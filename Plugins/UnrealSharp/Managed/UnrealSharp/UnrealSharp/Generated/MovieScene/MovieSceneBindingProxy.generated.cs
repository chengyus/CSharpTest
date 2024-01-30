using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneBindingProxy
{
    // StructProperty /Script/MovieScene.MovieSceneBindingProxy:BindingID
    static readonly int BindingID_Offset;
    public UnrealSharp.CoreUObject.Guid BindingID;
    
    // ObjectProperty /Script/MovieScene.MovieSceneBindingProxy:Sequence
    static readonly int Sequence_Offset;
    public UnrealSharp.MovieScene.MovieSceneSequence Sequence;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneBindingProxy()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneBindingProxy");
        
        BindingID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BindingID");
        Sequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sequence");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneBindingProxy(IntPtr InNativeStruct)
    {
        unsafe
        {
            BindingID = UnrealSharp.CoreUObject.GuidMarshaler.FromNative(IntPtr.Add(InNativeStruct, BindingID_Offset), 0, null);
            Sequence = ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSequence>.FromNative(IntPtr.Add(InNativeStruct, Sequence_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.GuidMarshaler.ToNative(IntPtr.Add(Buffer, BindingID_Offset), 0, null, BindingID);
            ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSequence>.ToNative(IntPtr.Add(Buffer, Sequence_Offset), 0, null, Sequence);
        }
    }
}

public static class MovieSceneBindingProxyMarshaler
{
    public static MovieSceneBindingProxy FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneBindingProxy(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneBindingProxy obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneBindingProxy.NativeDataSize;
    }
}