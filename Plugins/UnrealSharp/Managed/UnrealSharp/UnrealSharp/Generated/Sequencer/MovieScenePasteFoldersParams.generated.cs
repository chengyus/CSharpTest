using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Sequencer;

[UStruct]
public partial struct MovieScenePasteFoldersParams
{
    // ObjectProperty /Script/Sequencer.MovieScenePasteFoldersParams:Sequence
    static readonly int Sequence_Offset;
    public UnrealSharp.MovieScene.MovieSceneSequence Sequence;
    
    // ObjectProperty /Script/Sequencer.MovieScenePasteFoldersParams:ParentFolder
    static readonly int ParentFolder_Offset;
    public UnrealSharp.MovieScene.MovieSceneFolder ParentFolder;
    
    
    public static readonly int NativeDataSize;
    static MovieScenePasteFoldersParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieScenePasteFoldersParams");
        
        Sequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sequence");
        ParentFolder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentFolder");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieScenePasteFoldersParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            Sequence = ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSequence>.FromNative(IntPtr.Add(InNativeStruct, Sequence_Offset), 0, null);
            ParentFolder = ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneFolder>.FromNative(IntPtr.Add(InNativeStruct, ParentFolder_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSequence>.ToNative(IntPtr.Add(Buffer, Sequence_Offset), 0, null, Sequence);
            ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneFolder>.ToNative(IntPtr.Add(Buffer, ParentFolder_Offset), 0, null, ParentFolder);
        }
    }
}

public static class MovieScenePasteFoldersParamsMarshaler
{
    public static MovieScenePasteFoldersParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieScenePasteFoldersParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieScenePasteFoldersParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieScenePasteFoldersParams.NativeDataSize;
    }
}