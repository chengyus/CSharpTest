using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MinimalViewInfo
{
    // StructProperty /Script/Engine.MinimalViewInfo:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/Engine.MinimalViewInfo:Rotation
    static readonly int Rotation_Offset;
    public UnrealSharp.Rotator Rotation;
    
    // FloatProperty /Script/Engine.MinimalViewInfo:FOV
    static readonly int FOV_Offset;
    public float FOV;
    
    // FloatProperty /Script/Engine.MinimalViewInfo:OrthoWidth
    static readonly int OrthoWidth_Offset;
    public float OrthoWidth;
    
    // FloatProperty /Script/Engine.MinimalViewInfo:OrthoNearClipPlane
    static readonly int OrthoNearClipPlane_Offset;
    public float OrthoNearClipPlane;
    
    // FloatProperty /Script/Engine.MinimalViewInfo:OrthoFarClipPlane
    static readonly int OrthoFarClipPlane_Offset;
    public float OrthoFarClipPlane;
    
    // FloatProperty /Script/Engine.MinimalViewInfo:PerspectiveNearClipPlane
    static readonly int PerspectiveNearClipPlane_Offset;
    public float PerspectiveNearClipPlane;
    
    // FloatProperty /Script/Engine.MinimalViewInfo:AspectRatio
    static readonly int AspectRatio_Offset;
    public float AspectRatio;
    
    // BoolProperty /Script/Engine.MinimalViewInfo:bConstrainAspectRatio
    static readonly int bConstrainAspectRatio_Offset;
    static readonly IntPtr bConstrainAspectRatio_NativeProperty;
    public bool ConstrainAspectRatio;
    
    // BoolProperty /Script/Engine.MinimalViewInfo:bUseFieldOfViewForLOD
    static readonly int bUseFieldOfViewForLOD_Offset;
    static readonly IntPtr bUseFieldOfViewForLOD_NativeProperty;
    public bool UseFieldOfViewForLOD;
    
    // ByteProperty /Script/Engine.MinimalViewInfo:ProjectionMode
    static readonly int ProjectionMode_Offset;
    public UnrealSharp.Engine.ECameraProjectionMode ProjectionMode;
    
    // FloatProperty /Script/Engine.MinimalViewInfo:PostProcessBlendWeight
    static readonly int PostProcessBlendWeight_Offset;
    public float PostProcessBlendWeight;
    
    // StructProperty /Script/Engine.MinimalViewInfo:PostProcessSettings
    static readonly int PostProcessSettings_Offset;
    public UnrealSharp.Engine.PostProcessSettings PostProcessSettings;
    
    // StructProperty /Script/Engine.MinimalViewInfo:OffCenterProjectionOffset
    static readonly int OffCenterProjectionOffset_Offset;
    public System.DoubleNumerics.Vector2 OffCenterProjectionOffset;
    
    
    public static readonly int NativeDataSize;
    static MinimalViewInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MinimalViewInfo");
        
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        FOV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FOV");
        OrthoWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OrthoWidth");
        OrthoNearClipPlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OrthoNearClipPlane");
        OrthoFarClipPlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OrthoFarClipPlane");
        PerspectiveNearClipPlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PerspectiveNearClipPlane");
        AspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AspectRatio");
        bConstrainAspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bConstrainAspectRatio");
        bConstrainAspectRatio_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bConstrainAspectRatio");
        bUseFieldOfViewForLOD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseFieldOfViewForLOD");
        bUseFieldOfViewForLOD_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseFieldOfViewForLOD");
        ProjectionMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProjectionMode");
        PostProcessBlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PostProcessBlendWeight");
        PostProcessSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PostProcessSettings");
        OffCenterProjectionOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OffCenterProjectionOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MinimalViewInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
            Rotation = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
            FOV = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FOV_Offset), 0, null);
            OrthoWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OrthoWidth_Offset), 0, null);
            OrthoNearClipPlane = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OrthoNearClipPlane_Offset), 0, null);
            OrthoFarClipPlane = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OrthoFarClipPlane_Offset), 0, null);
            PerspectiveNearClipPlane = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PerspectiveNearClipPlane_Offset), 0, null);
            AspectRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AspectRatio_Offset), 0, null);
            ConstrainAspectRatio = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bConstrainAspectRatio_NativeProperty, bConstrainAspectRatio_Offset);
            UseFieldOfViewForLOD = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseFieldOfViewForLOD_NativeProperty, bUseFieldOfViewForLOD_Offset);
            ProjectionMode = BlittableMarshaller<UnrealSharp.Engine.ECameraProjectionMode>.FromNative(IntPtr.Add(InNativeStruct, ProjectionMode_Offset), 0, null);
            PostProcessBlendWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PostProcessBlendWeight_Offset), 0, null);
            PostProcessSettings = UnrealSharp.Engine.PostProcessSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, PostProcessSettings_Offset), 0, null);
            OffCenterProjectionOffset = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, OffCenterProjectionOffset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FOV_Offset), 0, null, FOV);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OrthoWidth_Offset), 0, null, OrthoWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OrthoNearClipPlane_Offset), 0, null, OrthoNearClipPlane);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OrthoFarClipPlane_Offset), 0, null, OrthoFarClipPlane);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PerspectiveNearClipPlane_Offset), 0, null, PerspectiveNearClipPlane);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AspectRatio_Offset), 0, null, AspectRatio);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bConstrainAspectRatio_NativeProperty, bConstrainAspectRatio_Offset, ConstrainAspectRatio);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseFieldOfViewForLOD_NativeProperty, bUseFieldOfViewForLOD_Offset, UseFieldOfViewForLOD);
            BlittableMarshaller<UnrealSharp.Engine.ECameraProjectionMode>.ToNative(IntPtr.Add(Buffer, ProjectionMode_Offset), 0, null, ProjectionMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PostProcessBlendWeight_Offset), 0, null, PostProcessBlendWeight);
            UnrealSharp.Engine.PostProcessSettingsMarshaler.ToNative(IntPtr.Add(Buffer, PostProcessSettings_Offset), 0, null, PostProcessSettings);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, OffCenterProjectionOffset_Offset), 0, null, OffCenterProjectionOffset);
        }
    }
}

public static class MinimalViewInfoMarshaler
{
    public static MinimalViewInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MinimalViewInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MinimalViewInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MinimalViewInfo.NativeDataSize;
    }
}