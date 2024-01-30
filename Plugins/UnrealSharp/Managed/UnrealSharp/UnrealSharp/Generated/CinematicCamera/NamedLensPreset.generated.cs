using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct]
public partial struct NamedLensPreset
{
    // StructProperty /Script/CinematicCamera.NamedLensPreset:LensSettings
    static readonly int LensSettings_Offset;
    public UnrealSharp.CinematicCamera.CameraLensSettings LensSettings;
    
    
    public static readonly int NativeDataSize;
    static NamedLensPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NamedLensPreset");
        
        LensSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LensSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NamedLensPreset(IntPtr InNativeStruct)
    {
        unsafe
        {
            LensSettings = BlittableMarshaller<UnrealSharp.CinematicCamera.CameraLensSettings>.FromNative(IntPtr.Add(InNativeStruct, LensSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CinematicCamera.CameraLensSettings>.ToNative(IntPtr.Add(Buffer, LensSettings_Offset), 0, null, LensSettings);
        }
    }
}

public static class NamedLensPresetMarshaler
{
    public static NamedLensPreset FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NamedLensPreset(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NamedLensPreset obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NamedLensPreset.NativeDataSize;
    }
}