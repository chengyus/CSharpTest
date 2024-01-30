using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneSectionParameters
{
    // StructProperty /Script/MovieScene.MovieSceneSectionParameters:StartFrameOffset
    static readonly int StartFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber StartFrameOffset;
    
    // BoolProperty /Script/MovieScene.MovieSceneSectionParameters:bCanLoop
    static readonly int bCanLoop_Offset;
    public bool CanLoop;
    
    // StructProperty /Script/MovieScene.MovieSceneSectionParameters:EndFrameOffset
    static readonly int EndFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber EndFrameOffset;
    
    // StructProperty /Script/MovieScene.MovieSceneSectionParameters:FirstLoopStartFrameOffset
    static readonly int FirstLoopStartFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber FirstLoopStartFrameOffset;
    
    // FloatProperty /Script/MovieScene.MovieSceneSectionParameters:TimeScale
    static readonly int TimeScale_Offset;
    public float TimeScale;
    
    // IntProperty /Script/MovieScene.MovieSceneSectionParameters:HierarchicalBias
    static readonly int HierarchicalBias_Offset;
    public int HierarchicalBias;
    
    // EnumProperty /Script/MovieScene.MovieSceneSectionParameters:Flags
    static readonly int Flags_Offset;
    public UnrealSharp.MovieScene.EMovieSceneSubSectionFlags Flags;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneSectionParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneSectionParameters");
        
        StartFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartFrameOffset");
        bCanLoop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanLoop");
        EndFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndFrameOffset");
        FirstLoopStartFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FirstLoopStartFrameOffset");
        TimeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TimeScale");
        HierarchicalBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HierarchicalBias");
        Flags_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Flags");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneSectionParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, StartFrameOffset_Offset), 0, null);
            CanLoop = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCanLoop_Offset), 0, null);
            EndFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, EndFrameOffset_Offset), 0, null);
            FirstLoopStartFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, FirstLoopStartFrameOffset_Offset), 0, null);
            TimeScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TimeScale_Offset), 0, null);
            HierarchicalBias = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, HierarchicalBias_Offset), 0, null);
            Flags = BlittableMarshaller<UnrealSharp.MovieScene.EMovieSceneSubSectionFlags>.FromNative(IntPtr.Add(InNativeStruct, Flags_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, StartFrameOffset_Offset), 0, null, StartFrameOffset);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCanLoop_Offset), 0, null, CanLoop);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, EndFrameOffset_Offset), 0, null, EndFrameOffset);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, FirstLoopStartFrameOffset_Offset), 0, null, FirstLoopStartFrameOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TimeScale_Offset), 0, null, TimeScale);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, HierarchicalBias_Offset), 0, null, HierarchicalBias);
            BlittableMarshaller<UnrealSharp.MovieScene.EMovieSceneSubSectionFlags>.ToNative(IntPtr.Add(Buffer, Flags_Offset), 0, null, Flags);
        }
    }
}

public static class MovieSceneSectionParametersMarshaler
{
    public static MovieSceneSectionParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneSectionParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneSectionParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneSectionParameters.NativeDataSize;
    }
}