using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Sequencer;

[UStruct]
public partial struct MovieScenePasteBindingsParams
{
    // ObjectProperty /Script/Sequencer.MovieScenePasteBindingsParams:ParentFolder
    static readonly int ParentFolder_Offset;
    public UnrealSharp.MovieScene.MovieSceneFolder ParentFolder;
    
    // BoolProperty /Script/Sequencer.MovieScenePasteBindingsParams:bDuplicateExistingActors
    static readonly int bDuplicateExistingActors_Offset;
    public bool DuplicateExistingActors;
    
    
    public static readonly int NativeDataSize;
    static MovieScenePasteBindingsParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieScenePasteBindingsParams");
        
        ParentFolder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentFolder");
        bDuplicateExistingActors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDuplicateExistingActors");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieScenePasteBindingsParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParentFolder = ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneFolder>.FromNative(IntPtr.Add(InNativeStruct, ParentFolder_Offset), 0, null);
            DuplicateExistingActors = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDuplicateExistingActors_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneFolder>.ToNative(IntPtr.Add(Buffer, ParentFolder_Offset), 0, null, ParentFolder);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDuplicateExistingActors_Offset), 0, null, DuplicateExistingActors);
        }
    }
}

public static class MovieScenePasteBindingsParamsMarshaler
{
    public static MovieScenePasteBindingsParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieScenePasteBindingsParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieScenePasteBindingsParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieScenePasteBindingsParams.NativeDataSize;
    }
}