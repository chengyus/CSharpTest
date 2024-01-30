using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

[UStruct]
public partial struct MovieSceneCameraShakeSourceTrigger
{
    // ClassProperty /Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger:ShakeClass
    static readonly int ShakeClass_Offset;
    public SubclassOf<UnrealSharp.Engine.CameraShakeBase> ShakeClass;
    
    // FloatProperty /Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger:PlayScale
    static readonly int PlayScale_Offset;
    public float PlayScale;
    
    // EnumProperty /Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger:PlaySpace
    static readonly int PlaySpace_Offset;
    public UnrealSharp.Engine.ECameraShakePlaySpace PlaySpace;
    
    // StructProperty /Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger:UserDefinedPlaySpace
    static readonly int UserDefinedPlaySpace_Offset;
    public UnrealSharp.Rotator UserDefinedPlaySpace;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneCameraShakeSourceTrigger()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneCameraShakeSourceTrigger");
        
        ShakeClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShakeClass");
        PlayScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayScale");
        PlaySpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaySpace");
        UserDefinedPlaySpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UserDefinedPlaySpace");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneCameraShakeSourceTrigger(IntPtr InNativeStruct)
    {
        unsafe
        {
            ShakeClass = SubclassOfMarshaller<UnrealSharp.Engine.CameraShakeBase>.FromNative(IntPtr.Add(InNativeStruct, ShakeClass_Offset), 0, null);
            PlayScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PlayScale_Offset), 0, null);
            PlaySpace = BlittableMarshaller<UnrealSharp.Engine.ECameraShakePlaySpace>.FromNative(IntPtr.Add(InNativeStruct, PlaySpace_Offset), 0, null);
            UserDefinedPlaySpace = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, UserDefinedPlaySpace_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            SubclassOfMarshaller<UnrealSharp.Engine.CameraShakeBase>.ToNative(IntPtr.Add(Buffer, ShakeClass_Offset), 0, null, ShakeClass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PlayScale_Offset), 0, null, PlayScale);
            BlittableMarshaller<UnrealSharp.Engine.ECameraShakePlaySpace>.ToNative(IntPtr.Add(Buffer, PlaySpace_Offset), 0, null, PlaySpace);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, UserDefinedPlaySpace_Offset), 0, null, UserDefinedPlaySpace);
        }
    }
}

public static class MovieSceneCameraShakeSourceTriggerMarshaler
{
    public static MovieSceneCameraShakeSourceTrigger FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneCameraShakeSourceTrigger(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneCameraShakeSourceTrigger obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneCameraShakeSourceTrigger.NativeDataSize;
    }
}