using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneSequencePlayToParams
{
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlayToParams:bExclusive
    static readonly int bExclusive_Offset;
    public bool Exclusive;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneSequencePlayToParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneSequencePlayToParams");
        
        bExclusive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExclusive");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneSequencePlayToParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            Exclusive = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bExclusive_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bExclusive_Offset), 0, null, Exclusive);
        }
    }
}

public static class MovieSceneSequencePlayToParamsMarshaler
{
    public static MovieSceneSequencePlayToParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneSequencePlayToParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneSequencePlayToParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneSequencePlayToParams.NativeDataSize;
    }
}