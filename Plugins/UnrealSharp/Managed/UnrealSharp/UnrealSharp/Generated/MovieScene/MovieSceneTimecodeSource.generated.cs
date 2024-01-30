using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneTimecodeSource
{
    // StructProperty /Script/MovieScene.MovieSceneTimecodeSource:Timecode
    static readonly int Timecode_Offset;
    public UnrealSharp.CoreUObject.Timecode Timecode;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneTimecodeSource()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneTimecodeSource");
        
        Timecode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Timecode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneTimecodeSource(IntPtr InNativeStruct)
    {
        unsafe
        {
            Timecode = UnrealSharp.CoreUObject.TimecodeMarshaler.FromNative(IntPtr.Add(InNativeStruct, Timecode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.TimecodeMarshaler.ToNative(IntPtr.Add(Buffer, Timecode_Offset), 0, null, Timecode);
        }
    }
}

public static class MovieSceneTimecodeSourceMarshaler
{
    public static MovieSceneTimecodeSource FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneTimecodeSource(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneTimecodeSource obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneTimecodeSource.NativeDataSize;
    }
}