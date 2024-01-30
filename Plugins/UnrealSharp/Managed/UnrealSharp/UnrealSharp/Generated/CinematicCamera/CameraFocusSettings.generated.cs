using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct]
public partial struct CameraFocusSettings
{
    // EnumProperty /Script/CinematicCamera.CameraFocusSettings:FocusMethod
    static readonly int FocusMethod_Offset;
    public UnrealSharp.CinematicCamera.ECameraFocusMethod FocusMethod;
    
    // FloatProperty /Script/CinematicCamera.CameraFocusSettings:ManualFocusDistance
    static readonly int ManualFocusDistance_Offset;
    public float ManualFocusDistance;
    
    // StructProperty /Script/CinematicCamera.CameraFocusSettings:TrackingFocusSettings
    static readonly int TrackingFocusSettings_Offset;
    public UnrealSharp.CinematicCamera.CameraTrackingFocusSettings TrackingFocusSettings;
    
    // BoolProperty /Script/CinematicCamera.CameraFocusSettings:bSmoothFocusChanges
    static readonly int bSmoothFocusChanges_Offset;
    static readonly IntPtr bSmoothFocusChanges_NativeProperty;
    public bool SmoothFocusChanges;
    
    // FloatProperty /Script/CinematicCamera.CameraFocusSettings:FocusSmoothingInterpSpeed
    static readonly int FocusSmoothingInterpSpeed_Offset;
    public float FocusSmoothingInterpSpeed;
    
    // FloatProperty /Script/CinematicCamera.CameraFocusSettings:FocusOffset
    static readonly int FocusOffset_Offset;
    public float FocusOffset;
    
    
    public static readonly int NativeDataSize;
    static CameraFocusSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraFocusSettings");
        
        FocusMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusMethod");
        ManualFocusDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ManualFocusDistance");
        TrackingFocusSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TrackingFocusSettings");
        bSmoothFocusChanges_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSmoothFocusChanges");
        bSmoothFocusChanges_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSmoothFocusChanges");
        FocusSmoothingInterpSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusSmoothingInterpSpeed");
        FocusOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraFocusSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            FocusMethod = BlittableMarshaller<UnrealSharp.CinematicCamera.ECameraFocusMethod>.FromNative(IntPtr.Add(InNativeStruct, FocusMethod_Offset), 0, null);
            ManualFocusDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ManualFocusDistance_Offset), 0, null);
            TrackingFocusSettings = UnrealSharp.CinematicCamera.CameraTrackingFocusSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, TrackingFocusSettings_Offset), 0, null);
            SmoothFocusChanges = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSmoothFocusChanges_NativeProperty, bSmoothFocusChanges_Offset);
            FocusSmoothingInterpSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusSmoothingInterpSpeed_Offset), 0, null);
            FocusOffset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FocusOffset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CinematicCamera.ECameraFocusMethod>.ToNative(IntPtr.Add(Buffer, FocusMethod_Offset), 0, null, FocusMethod);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ManualFocusDistance_Offset), 0, null, ManualFocusDistance);
            UnrealSharp.CinematicCamera.CameraTrackingFocusSettingsMarshaler.ToNative(IntPtr.Add(Buffer, TrackingFocusSettings_Offset), 0, null, TrackingFocusSettings);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSmoothFocusChanges_NativeProperty, bSmoothFocusChanges_Offset, SmoothFocusChanges);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusSmoothingInterpSpeed_Offset), 0, null, FocusSmoothingInterpSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FocusOffset_Offset), 0, null, FocusOffset);
        }
    }
}

public static class CameraFocusSettingsMarshaler
{
    public static CameraFocusSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraFocusSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraFocusSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraFocusSettings.NativeDataSize;
    }
}