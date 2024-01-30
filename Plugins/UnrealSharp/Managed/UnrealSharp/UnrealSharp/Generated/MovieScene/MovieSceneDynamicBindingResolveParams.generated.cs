using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneDynamicBindingResolveParams
{
    // ObjectProperty /Script/MovieScene.MovieSceneDynamicBindingResolveParams:Sequence
    static readonly int Sequence_Offset;
    public UnrealSharp.MovieScene.MovieSceneSequence Sequence;
    
    // StructProperty /Script/MovieScene.MovieSceneDynamicBindingResolveParams:ObjectBindingID
    static readonly int ObjectBindingID_Offset;
    public UnrealSharp.CoreUObject.Guid ObjectBindingID;
    
    // ObjectProperty /Script/MovieScene.MovieSceneDynamicBindingResolveParams:RootSequence
    static readonly int RootSequence_Offset;
    public UnrealSharp.MovieScene.MovieSceneSequence RootSequence;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneDynamicBindingResolveParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneDynamicBindingResolveParams");
        
        Sequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sequence");
        ObjectBindingID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ObjectBindingID");
        RootSequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootSequence");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneDynamicBindingResolveParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            Sequence = ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSequence>.FromNative(IntPtr.Add(InNativeStruct, Sequence_Offset), 0, null);
            ObjectBindingID = UnrealSharp.CoreUObject.GuidMarshaler.FromNative(IntPtr.Add(InNativeStruct, ObjectBindingID_Offset), 0, null);
            RootSequence = ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSequence>.FromNative(IntPtr.Add(InNativeStruct, RootSequence_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSequence>.ToNative(IntPtr.Add(Buffer, Sequence_Offset), 0, null, Sequence);
            UnrealSharp.CoreUObject.GuidMarshaler.ToNative(IntPtr.Add(Buffer, ObjectBindingID_Offset), 0, null, ObjectBindingID);
            ObjectMarshaller<UnrealSharp.MovieScene.MovieSceneSequence>.ToNative(IntPtr.Add(Buffer, RootSequence_Offset), 0, null, RootSequence);
        }
    }
}

public static class MovieSceneDynamicBindingResolveParamsMarshaler
{
    public static MovieSceneDynamicBindingResolveParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneDynamicBindingResolveParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneDynamicBindingResolveParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneDynamicBindingResolveParams.NativeDataSize;
    }
}