using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct]
public partial struct CameraLookatTrackingSettings
{
    // BoolProperty /Script/CinematicCamera.CameraLookatTrackingSettings:bEnableLookAtTracking
    static readonly int bEnableLookAtTracking_Offset;
    static readonly IntPtr bEnableLookAtTracking_NativeProperty;
    public bool EnableLookAtTracking;
    
    // BoolProperty /Script/CinematicCamera.CameraLookatTrackingSettings:bDrawDebugLookAtTrackingPosition
    static readonly int bDrawDebugLookAtTrackingPosition_Offset;
    static readonly IntPtr bDrawDebugLookAtTrackingPosition_NativeProperty;
    public bool DrawDebugLookAtTrackingPosition;
    
    // FloatProperty /Script/CinematicCamera.CameraLookatTrackingSettings:LookAtTrackingInterpSpeed
    static readonly int LookAtTrackingInterpSpeed_Offset;
    public float LookAtTrackingInterpSpeed;
    
    // SoftObjectProperty /Script/CinematicCamera.CameraLookatTrackingSettings:ActorToTrack
    static readonly int ActorToTrack_Offset;
    public SoftObject<UnrealSharp.Engine.Actor> ActorToTrack;
    
    // StructProperty /Script/CinematicCamera.CameraLookatTrackingSettings:RelativeOffset
    static readonly int RelativeOffset_Offset;
    public System.DoubleNumerics.Vector3 RelativeOffset;
    
    // BoolProperty /Script/CinematicCamera.CameraLookatTrackingSettings:bAllowRoll
    static readonly int bAllowRoll_Offset;
    static readonly IntPtr bAllowRoll_NativeProperty;
    public bool AllowRoll;
    
    
    public static readonly int NativeDataSize;
    static CameraLookatTrackingSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraLookatTrackingSettings");
        
        bEnableLookAtTracking_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableLookAtTracking");
        bEnableLookAtTracking_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableLookAtTracking");
        bDrawDebugLookAtTrackingPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawDebugLookAtTrackingPosition");
        bDrawDebugLookAtTrackingPosition_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDrawDebugLookAtTrackingPosition");
        LookAtTrackingInterpSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LookAtTrackingInterpSpeed");
        ActorToTrack_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActorToTrack");
        RelativeOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RelativeOffset");
        bAllowRoll_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowRoll");
        bAllowRoll_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowRoll");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraLookatTrackingSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            EnableLookAtTracking = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnableLookAtTracking_NativeProperty, bEnableLookAtTracking_Offset);
            DrawDebugLookAtTrackingPosition = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDrawDebugLookAtTrackingPosition_NativeProperty, bDrawDebugLookAtTrackingPosition_Offset);
            LookAtTrackingInterpSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LookAtTrackingInterpSpeed_Offset), 0, null);
            ActorToTrack = BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.FromNative(IntPtr.Add(InNativeStruct, ActorToTrack_Offset), 0, null);
            RelativeOffset = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, RelativeOffset_Offset), 0, null);
            AllowRoll = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAllowRoll_NativeProperty, bAllowRoll_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnableLookAtTracking_NativeProperty, bEnableLookAtTracking_Offset, EnableLookAtTracking);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDrawDebugLookAtTrackingPosition_NativeProperty, bDrawDebugLookAtTrackingPosition_Offset, DrawDebugLookAtTrackingPosition);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LookAtTrackingInterpSpeed_Offset), 0, null, LookAtTrackingInterpSpeed);
            BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.ToNative(IntPtr.Add(Buffer, ActorToTrack_Offset), 0, null, ActorToTrack);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, RelativeOffset_Offset), 0, null, RelativeOffset);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAllowRoll_NativeProperty, bAllowRoll_Offset, AllowRoll);
        }
    }
}

public static class CameraLookatTrackingSettingsMarshaler
{
    public static CameraLookatTrackingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraLookatTrackingSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraLookatTrackingSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraLookatTrackingSettings.NativeDataSize;
    }
}