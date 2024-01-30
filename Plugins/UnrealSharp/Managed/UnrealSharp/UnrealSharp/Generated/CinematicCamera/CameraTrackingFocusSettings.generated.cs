using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UStruct]
public partial struct CameraTrackingFocusSettings
{
    // SoftObjectProperty /Script/CinematicCamera.CameraTrackingFocusSettings:ActorToTrack
    static readonly int ActorToTrack_Offset;
    public SoftObject<UnrealSharp.Engine.Actor> ActorToTrack;
    
    // StructProperty /Script/CinematicCamera.CameraTrackingFocusSettings:RelativeOffset
    static readonly int RelativeOffset_Offset;
    public System.DoubleNumerics.Vector3 RelativeOffset;
    
    // BoolProperty /Script/CinematicCamera.CameraTrackingFocusSettings:bDrawDebugTrackingFocusPoint
    static readonly int bDrawDebugTrackingFocusPoint_Offset;
    static readonly IntPtr bDrawDebugTrackingFocusPoint_NativeProperty;
    public bool DrawDebugTrackingFocusPoint;
    
    
    public static readonly int NativeDataSize;
    static CameraTrackingFocusSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraTrackingFocusSettings");
        
        ActorToTrack_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActorToTrack");
        RelativeOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RelativeOffset");
        bDrawDebugTrackingFocusPoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawDebugTrackingFocusPoint");
        bDrawDebugTrackingFocusPoint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDrawDebugTrackingFocusPoint");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraTrackingFocusSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ActorToTrack = BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.FromNative(IntPtr.Add(InNativeStruct, ActorToTrack_Offset), 0, null);
            RelativeOffset = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, RelativeOffset_Offset), 0, null);
            DrawDebugTrackingFocusPoint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDrawDebugTrackingFocusPoint_NativeProperty, bDrawDebugTrackingFocusPoint_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<SoftObject<UnrealSharp.Engine.Actor>>.ToNative(IntPtr.Add(Buffer, ActorToTrack_Offset), 0, null, ActorToTrack);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, RelativeOffset_Offset), 0, null, RelativeOffset);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDrawDebugTrackingFocusPoint_NativeProperty, bDrawDebugTrackingFocusPoint_Offset, DrawDebugTrackingFocusPoint);
        }
    }
}

public static class CameraTrackingFocusSettingsMarshaler
{
    public static CameraTrackingFocusSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraTrackingFocusSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraTrackingFocusSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraTrackingFocusSettings.NativeDataSize;
    }
}