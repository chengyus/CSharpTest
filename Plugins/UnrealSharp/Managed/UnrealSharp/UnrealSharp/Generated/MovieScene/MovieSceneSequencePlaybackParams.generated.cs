using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneSequencePlaybackParams
{
    // StructProperty /Script/MovieScene.MovieSceneSequencePlaybackParams:Frame
    static readonly int Frame_Offset;
    public UnrealSharp.CoreUObject.FrameTime Frame;
    
    // FloatProperty /Script/MovieScene.MovieSceneSequencePlaybackParams:Time
    static readonly int Time_Offset;
    public float Time;
    
    // EnumProperty /Script/MovieScene.MovieSceneSequencePlaybackParams:PositionType
    static readonly int PositionType_Offset;
    public UnrealSharp.MovieScene.EMovieScenePositionType PositionType;
    
    // EnumProperty /Script/MovieScene.MovieSceneSequencePlaybackParams:UpdateMethod
    static readonly int UpdateMethod_Offset;
    public UnrealSharp.MovieScene.EUpdatePositionMethod UpdateMethod;
    
    // BoolProperty /Script/MovieScene.MovieSceneSequencePlaybackParams:bHasJumped
    static readonly int bHasJumped_Offset;
    public bool HasJumped;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneSequencePlaybackParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneSequencePlaybackParams");
        
        Frame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frame");
        Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Time");
        PositionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PositionType");
        UpdateMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpdateMethod");
        bHasJumped_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHasJumped");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneSequencePlaybackParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            Frame = BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.FromNative(IntPtr.Add(InNativeStruct, Frame_Offset), 0, null);
            Time = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Time_Offset), 0, null);
            PositionType = BlittableMarshaller<UnrealSharp.MovieScene.EMovieScenePositionType>.FromNative(IntPtr.Add(InNativeStruct, PositionType_Offset), 0, null);
            UpdateMethod = BlittableMarshaller<UnrealSharp.MovieScene.EUpdatePositionMethod>.FromNative(IntPtr.Add(InNativeStruct, UpdateMethod_Offset), 0, null);
            HasJumped = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHasJumped_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.ToNative(IntPtr.Add(Buffer, Frame_Offset), 0, null, Frame);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Time_Offset), 0, null, Time);
            BlittableMarshaller<UnrealSharp.MovieScene.EMovieScenePositionType>.ToNative(IntPtr.Add(Buffer, PositionType_Offset), 0, null, PositionType);
            BlittableMarshaller<UnrealSharp.MovieScene.EUpdatePositionMethod>.ToNative(IntPtr.Add(Buffer, UpdateMethod_Offset), 0, null, UpdateMethod);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHasJumped_Offset), 0, null, HasJumped);
        }
    }
}

public static class MovieSceneSequencePlaybackParamsMarshaler
{
    public static MovieSceneSequencePlaybackParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneSequencePlaybackParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneSequencePlaybackParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneSequencePlaybackParams.NativeDataSize;
    }
}