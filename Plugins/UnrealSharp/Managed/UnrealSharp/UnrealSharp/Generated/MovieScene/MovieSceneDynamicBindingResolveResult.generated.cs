using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct]
public partial struct MovieSceneDynamicBindingResolveResult
{
    // ObjectProperty /Script/MovieScene.MovieSceneDynamicBindingResolveResult:Object
    static readonly int Object_Offset;
    public UnrealSharp.CoreUObject.Object Object;
    
    // BoolProperty /Script/MovieScene.MovieSceneDynamicBindingResolveResult:bIsPossessedObject
    static readonly int bIsPossessedObject_Offset;
    public bool IsPossessedObject;
    
    
    public static readonly int NativeDataSize;
    static MovieSceneDynamicBindingResolveResult()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovieSceneDynamicBindingResolveResult");
        
        Object_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Object");
        bIsPossessedObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsPossessedObject");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovieSceneDynamicBindingResolveResult(IntPtr InNativeStruct)
    {
        unsafe
        {
            Object = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, Object_Offset), 0, null);
            IsPossessedObject = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsPossessedObject_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, Object_Offset), 0, null, Object);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsPossessedObject_Offset), 0, null, IsPossessedObject);
        }
    }
}

public static class MovieSceneDynamicBindingResolveResultMarshaler
{
    public static MovieSceneDynamicBindingResolveResult FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovieSceneDynamicBindingResolveResult(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovieSceneDynamicBindingResolveResult obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovieSceneDynamicBindingResolveResult.NativeDataSize;
    }
}