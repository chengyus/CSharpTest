using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCacheTracks;

[UStruct]
public partial struct MovieSceneGeometryCacheParams
{
    // ObjectProperty /Script/GeometryCacheTracks.MovieSceneGeometryCacheParams:GeometryCacheAsset
    static readonly int GeometryCacheAsset_Offset;
    public UnrealSharp.GeometryCache.GeometryCache GeometryCacheAsset;
    
    // StructProperty /Script/GeometryCacheTracks.MovieSceneGeometryCacheParams:FirstLoopStartFrameOffset
    static readonly int FirstLoopStartFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber FirstLoopStartFrameOffset;
    
    // StructProperty /Script/GeometryCacheTracks.MovieSceneGeometryCacheParams:StartFrameOffset
    static readonly int StartFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber StartFrameOffset;
    
    // StructProperty /Script/GeometryCacheTracks.MovieSceneGeometryCacheParams:EndFrameOffset
    static readonly int EndFrameOffset_Offset;
    public UnrealSharp.CoreUObject.FrameNumber EndFrameOffset;
    
    // FloatProperty /Script/GeometryCacheTracks.MovieSceneGeometryCacheParams:PlayRate
    static readonly int PlayRate_Offset;
    public float PlayRate;
    
    // BoolProperty /Script/GeometryCacheTracks.MovieSceneGeometryCacheParams:bReverse
    static readonly int bReverse_Offset;
    static readonly IntPtr bReverse_NativeProperty;
    public bool Reverse;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneGeometryCacheParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneGeometryCacheParams");
        
        GeometryCacheAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GeometryCacheAsset");
        FirstLoopStartFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FirstLoopStartFrameOffset");
        StartFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartFrameOffset");
        EndFrameOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndFrameOffset");
        PlayRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayRate");
        bReverse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReverse");
        bReverse_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bReverse");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneGeometryCacheParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            GeometryCacheAsset = ObjectMarshaller<UnrealSharp.GeometryCache.GeometryCache>.FromNative(IntPtr.Add(InNativeStruct, GeometryCacheAsset_Offset), 0, null);
            FirstLoopStartFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, FirstLoopStartFrameOffset_Offset), 0, null);
            StartFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, StartFrameOffset_Offset), 0, null);
            EndFrameOffset = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, EndFrameOffset_Offset), 0, null);
            PlayRate = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PlayRate_Offset), 0, null);
            Reverse = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bReverse_NativeProperty, bReverse_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.GeometryCache.GeometryCache>.ToNative(IntPtr.Add(Buffer, GeometryCacheAsset_Offset), 0, null, GeometryCacheAsset);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, FirstLoopStartFrameOffset_Offset), 0, null, FirstLoopStartFrameOffset);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, StartFrameOffset_Offset), 0, null, StartFrameOffset);
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, EndFrameOffset_Offset), 0, null, EndFrameOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PlayRate_Offset), 0, null, PlayRate);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bReverse_NativeProperty, bReverse_Offset, Reverse);
        }
    }
}

public static class MovieSceneGeometryCacheParamsMarshaler
{
    public static MovieSceneGeometryCacheParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneGeometryCacheParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneGeometryCacheParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneGeometryCacheParams.NativeDataSize;
    }
}