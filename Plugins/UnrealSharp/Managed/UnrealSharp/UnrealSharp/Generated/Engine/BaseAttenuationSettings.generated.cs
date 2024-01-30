using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct BaseAttenuationSettings
{
    // EnumProperty /Script/Engine.BaseAttenuationSettings:DistanceAlgorithm
    static readonly int DistanceAlgorithm_Offset;
    public UnrealSharp.Engine.EAttenuationDistanceModel DistanceAlgorithm;
    
    // ByteProperty /Script/Engine.BaseAttenuationSettings:AttenuationShape
    static readonly int AttenuationShape_Offset;
    public UnrealSharp.Engine.EAttenuationShape AttenuationShape;
    
    // EnumProperty /Script/Engine.BaseAttenuationSettings:FalloffMode
    static readonly int FalloffMode_Offset;
    public UnrealSharp.Engine.ENaturalSoundFalloffMode FalloffMode;
    
    // FloatProperty /Script/Engine.BaseAttenuationSettings:dBAttenuationAtMax
    static readonly int dBAttenuationAtMax_Offset;
    public float dBAttenuationAtMax;
    
    // StructProperty /Script/Engine.BaseAttenuationSettings:AttenuationShapeExtents
    static readonly int AttenuationShapeExtents_Offset;
    public System.DoubleNumerics.Vector3 AttenuationShapeExtents;
    
    // FloatProperty /Script/Engine.BaseAttenuationSettings:ConeOffset
    static readonly int ConeOffset_Offset;
    public float ConeOffset;
    
    // FloatProperty /Script/Engine.BaseAttenuationSettings:FalloffDistance
    static readonly int FalloffDistance_Offset;
    public float FalloffDistance;
    
    // FloatProperty /Script/Engine.BaseAttenuationSettings:ConeSphereRadius
    static readonly int ConeSphereRadius_Offset;
    public float ConeSphereRadius;
    
    // FloatProperty /Script/Engine.BaseAttenuationSettings:ConeSphereFalloffDistance
    static readonly int ConeSphereFalloffDistance_Offset;
    public float ConeSphereFalloffDistance;
    
    // StructProperty /Script/Engine.BaseAttenuationSettings:CustomAttenuationCurve
    static readonly int CustomAttenuationCurve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve CustomAttenuationCurve;
    
    
    public static readonly int NativeDataSize;
    static BaseAttenuationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BaseAttenuationSettings");
        
        DistanceAlgorithm_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceAlgorithm");
        AttenuationShape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttenuationShape");
        FalloffMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FalloffMode");
        dBAttenuationAtMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "dBAttenuationAtMax");
        AttenuationShapeExtents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttenuationShapeExtents");
        ConeOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ConeOffset");
        FalloffDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FalloffDistance");
        ConeSphereRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ConeSphereRadius");
        ConeSphereFalloffDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ConeSphereFalloffDistance");
        CustomAttenuationCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomAttenuationCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BaseAttenuationSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DistanceAlgorithm = BlittableMarshaller<UnrealSharp.Engine.EAttenuationDistanceModel>.FromNative(IntPtr.Add(InNativeStruct, DistanceAlgorithm_Offset), 0, null);
            AttenuationShape = BlittableMarshaller<UnrealSharp.Engine.EAttenuationShape>.FromNative(IntPtr.Add(InNativeStruct, AttenuationShape_Offset), 0, null);
            FalloffMode = BlittableMarshaller<UnrealSharp.Engine.ENaturalSoundFalloffMode>.FromNative(IntPtr.Add(InNativeStruct, FalloffMode_Offset), 0, null);
            dBAttenuationAtMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, dBAttenuationAtMax_Offset), 0, null);
            AttenuationShapeExtents = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AttenuationShapeExtents_Offset), 0, null);
            ConeOffset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ConeOffset_Offset), 0, null);
            FalloffDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FalloffDistance_Offset), 0, null);
            ConeSphereRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ConeSphereRadius_Offset), 0, null);
            ConeSphereFalloffDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ConeSphereFalloffDistance_Offset), 0, null);
            CustomAttenuationCurve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomAttenuationCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EAttenuationDistanceModel>.ToNative(IntPtr.Add(Buffer, DistanceAlgorithm_Offset), 0, null, DistanceAlgorithm);
            BlittableMarshaller<UnrealSharp.Engine.EAttenuationShape>.ToNative(IntPtr.Add(Buffer, AttenuationShape_Offset), 0, null, AttenuationShape);
            BlittableMarshaller<UnrealSharp.Engine.ENaturalSoundFalloffMode>.ToNative(IntPtr.Add(Buffer, FalloffMode_Offset), 0, null, FalloffMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, dBAttenuationAtMax_Offset), 0, null, dBAttenuationAtMax);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AttenuationShapeExtents_Offset), 0, null, AttenuationShapeExtents);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ConeOffset_Offset), 0, null, ConeOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FalloffDistance_Offset), 0, null, FalloffDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ConeSphereRadius_Offset), 0, null, ConeSphereRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ConeSphereFalloffDistance_Offset), 0, null, ConeSphereFalloffDistance);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, CustomAttenuationCurve_Offset), 0, null, CustomAttenuationCurve);
        }
    }
}

public static class BaseAttenuationSettingsMarshaler
{
    public static BaseAttenuationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BaseAttenuationSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BaseAttenuationSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BaseAttenuationSettings.NativeDataSize;
    }
}