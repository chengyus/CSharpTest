using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct]
public partial struct NamedPlateCropPreset
{
    // StructProperty /Script/CinematicCamera.NamedPlateCropPreset:CropSettings
    static readonly int CropSettings_Offset;
    public UnrealSharp.CinematicCamera.PlateCropSettings CropSettings;
    
    
    public static readonly int NativeDataSize;
    static NamedPlateCropPreset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NamedPlateCropPreset");
        
        CropSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CropSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NamedPlateCropPreset(IntPtr InNativeStruct)
    {
        unsafe
        {
            CropSettings = BlittableMarshaller<UnrealSharp.CinematicCamera.PlateCropSettings>.FromNative(IntPtr.Add(InNativeStruct, CropSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CinematicCamera.PlateCropSettings>.ToNative(IntPtr.Add(Buffer, CropSettings_Offset), 0, null, CropSettings);
        }
    }
}

public static class NamedPlateCropPresetMarshaler
{
    public static NamedPlateCropPreset FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NamedPlateCropPreset(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NamedPlateCropPreset obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NamedPlateCropPreset.NativeDataSize;
    }
}