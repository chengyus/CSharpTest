using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct OptionalMovieSceneBlendType
{
    // EnumProperty /Script/MovieScene.OptionalMovieSceneBlendType:BlendType
    static readonly int BlendType_Offset;
    public UnrealSharp.MovieScene.EMovieSceneBlendType BlendType;
    
    // BoolProperty /Script/MovieScene.OptionalMovieSceneBlendType:bIsValid
    static readonly int bIsValid_Offset;
    public bool IsValid;
    
    
    public static readonly int NativeDataSize;
    static OptionalMovieSceneBlendType()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("OptionalMovieSceneBlendType");
        
        BlendType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendType");
        bIsValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsValid");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public OptionalMovieSceneBlendType(IntPtr InNativeStruct)
    {
        unsafe
        {
            BlendType = BlittableMarshaller<UnrealSharp.MovieScene.EMovieSceneBlendType>.FromNative(IntPtr.Add(InNativeStruct, BlendType_Offset), 0, null);
            IsValid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsValid_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.MovieScene.EMovieSceneBlendType>.ToNative(IntPtr.Add(Buffer, BlendType_Offset), 0, null, BlendType);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsValid_Offset), 0, null, IsValid);
        }
    }
}

public static class OptionalMovieSceneBlendTypeMarshaler
{
    public static OptionalMovieSceneBlendType FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new OptionalMovieSceneBlendType(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, OptionalMovieSceneBlendType obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return OptionalMovieSceneBlendType.NativeDataSize;
    }
}