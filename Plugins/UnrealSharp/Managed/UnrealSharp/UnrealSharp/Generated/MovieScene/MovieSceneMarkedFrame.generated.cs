using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneMarkedFrame
{
    // StructProperty /Script/MovieScene.MovieSceneMarkedFrame:FrameNumber
    static readonly int FrameNumber_Offset;
    public UnrealSharp.CoreUObject.FrameNumber FrameNumber;
    
    // BoolProperty /Script/MovieScene.MovieSceneMarkedFrame:bIsDeterminismFence
    static readonly int bIsDeterminismFence_Offset;
    public bool IsDeterminismFence;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneMarkedFrame()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneMarkedFrame");
        
        FrameNumber_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrameNumber");
        bIsDeterminismFence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsDeterminismFence");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneMarkedFrame(IntPtr InNativeStruct)
    {
        unsafe
        {
            FrameNumber = BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(InNativeStruct, FrameNumber_Offset), 0, null);
            IsDeterminismFence = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsDeterminismFence_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(Buffer, FrameNumber_Offset), 0, null, FrameNumber);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsDeterminismFence_Offset), 0, null, IsDeterminismFence);
        }
    }
}

public static class MovieSceneMarkedFrameMarshaler
{
    public static MovieSceneMarkedFrame FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneMarkedFrame(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneMarkedFrame obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneMarkedFrame.NativeDataSize;
    }
}