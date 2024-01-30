using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Sequencer;

[UStruct]
public partial struct MovieScenePasteSectionsParams
{
    // StructProperty /Script/Sequencer.MovieScenePasteSectionsParams:Time
    static readonly int Time_Offset;
    public UnrealSharp.CoreUObject.FrameTime Time;
    
    
    public static readonly int NativeDataSize;
    static MovieScenePasteSectionsParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieScenePasteSectionsParams");
        
        Time_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Time");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieScenePasteSectionsParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            Time = BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.FromNative(IntPtr.Add(InNativeStruct, Time_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameTime>.ToNative(IntPtr.Add(Buffer, Time_Offset), 0, null, Time);
        }
    }
}

public static class MovieScenePasteSectionsParamsMarshaler
{
    public static MovieScenePasteSectionsParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieScenePasteSectionsParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieScenePasteSectionsParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieScenePasteSectionsParams.NativeDataSize;
    }
}