using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct]
public partial struct NamedFilmbackPreset
{
    // StructProperty /Script/CinematicCamera.NamedFilmbackPreset:FilmbackSettings
    static readonly int FilmbackSettings_Offset;
    public UnrealSharp.CinematicCamera.CameraFilmbackSettings FilmbackSettings;
    
    
    public static readonly int NativeDataSize;
    static NamedFilmbackPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NamedFilmbackPreset");
        
        FilmbackSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmbackSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NamedFilmbackPreset(IntPtr InNativeStruct)
    {
        unsafe
        {
            FilmbackSettings = BlittableMarshaller<UnrealSharp.CinematicCamera.CameraFilmbackSettings>.FromNative(IntPtr.Add(InNativeStruct, FilmbackSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CinematicCamera.CameraFilmbackSettings>.ToNative(IntPtr.Add(Buffer, FilmbackSettings_Offset), 0, null, FilmbackSettings);
        }
    }
}

public static class NamedFilmbackPresetMarshaler
{
    public static NamedFilmbackPreset FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NamedFilmbackPreset(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NamedFilmbackPreset obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NamedFilmbackPreset.NativeDataSize;
    }
}