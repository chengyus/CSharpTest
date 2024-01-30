using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct LightmassWorldInfoSettings
{
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:StaticLightingLevelScale
    static readonly int StaticLightingLevelScale_Offset;
    public float StaticLightingLevelScale;
    
    // IntProperty /Script/Engine.LightmassWorldInfoSettings:NumIndirectLightingBounces
    static readonly int NumIndirectLightingBounces_Offset;
    public int NumIndirectLightingBounces;
    
    // IntProperty /Script/Engine.LightmassWorldInfoSettings:NumSkyLightingBounces
    static readonly int NumSkyLightingBounces_Offset;
    public int NumSkyLightingBounces;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:IndirectLightingQuality
    static readonly int IndirectLightingQuality_Offset;
    public float IndirectLightingQuality;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:IndirectLightingSmoothness
    static readonly int IndirectLightingSmoothness_Offset;
    public float IndirectLightingSmoothness;
    
    // StructProperty /Script/Engine.LightmassWorldInfoSettings:EnvironmentColor
    static readonly int EnvironmentColor_Offset;
    public UnrealSharp.CoreUObject.Color EnvironmentColor;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:EnvironmentIntensity
    static readonly int EnvironmentIntensity_Offset;
    public float EnvironmentIntensity;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:DiffuseBoost
    static readonly int DiffuseBoost_Offset;
    public float DiffuseBoost;
    
    // ByteProperty /Script/Engine.LightmassWorldInfoSettings:VolumeLightingMethod
    static readonly int VolumeLightingMethod_Offset;
    public UnrealSharp.Engine.EVolumeLightingMethod VolumeLightingMethod;
    
    // BoolProperty /Script/Engine.LightmassWorldInfoSettings:bUseAmbientOcclusion
    static readonly int bUseAmbientOcclusion_Offset;
    static readonly IntPtr bUseAmbientOcclusion_NativeProperty;
    public bool UseAmbientOcclusion;
    
    // BoolProperty /Script/Engine.LightmassWorldInfoSettings:bGenerateAmbientOcclusionMaterialMask
    static readonly int bGenerateAmbientOcclusionMaterialMask_Offset;
    static readonly IntPtr bGenerateAmbientOcclusionMaterialMask_NativeProperty;
    public bool GenerateAmbientOcclusionMaterialMask;
    
    // BoolProperty /Script/Engine.LightmassWorldInfoSettings:bVisualizeMaterialDiffuse
    static readonly int bVisualizeMaterialDiffuse_Offset;
    static readonly IntPtr bVisualizeMaterialDiffuse_NativeProperty;
    public bool VisualizeMaterialDiffuse;
    
    // BoolProperty /Script/Engine.LightmassWorldInfoSettings:bVisualizeAmbientOcclusion
    static readonly int bVisualizeAmbientOcclusion_Offset;
    static readonly IntPtr bVisualizeAmbientOcclusion_NativeProperty;
    public bool VisualizeAmbientOcclusion;
    
    // BoolProperty /Script/Engine.LightmassWorldInfoSettings:bCompressLightmaps
    static readonly int bCompressLightmaps_Offset;
    static readonly IntPtr bCompressLightmaps_NativeProperty;
    public bool CompressLightmaps;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:VolumetricLightmapDetailCellSize
    static readonly int VolumetricLightmapDetailCellSize_Offset;
    public float VolumetricLightmapDetailCellSize;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:VolumetricLightmapMaximumBrickMemoryMb
    static readonly int VolumetricLightmapMaximumBrickMemoryMb_Offset;
    public float VolumetricLightmapMaximumBrickMemoryMb;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:VolumetricLightmapSphericalHarmonicSmoothing
    static readonly int VolumetricLightmapSphericalHarmonicSmoothing_Offset;
    public float VolumetricLightmapSphericalHarmonicSmoothing;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:VolumeLightSamplePlacementScale
    static readonly int VolumeLightSamplePlacementScale_Offset;
    public float VolumeLightSamplePlacementScale;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:DirectIlluminationOcclusionFraction
    static readonly int DirectIlluminationOcclusionFraction_Offset;
    public float DirectIlluminationOcclusionFraction;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:IndirectIlluminationOcclusionFraction
    static readonly int IndirectIlluminationOcclusionFraction_Offset;
    public float IndirectIlluminationOcclusionFraction;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:OcclusionExponent
    static readonly int OcclusionExponent_Offset;
    public float OcclusionExponent;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:FullyOccludedSamplesFraction
    static readonly int FullyOccludedSamplesFraction_Offset;
    public float FullyOccludedSamplesFraction;
    
    // FloatProperty /Script/Engine.LightmassWorldInfoSettings:MaxOcclusionDistance
    static readonly int MaxOcclusionDistance_Offset;
    public float MaxOcclusionDistance;
    
    
    public static readonly int NativeDataSize;
    static LightmassWorldInfoSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LightmassWorldInfoSettings");
        
        StaticLightingLevelScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticLightingLevelScale");
        NumIndirectLightingBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumIndirectLightingBounces");
        NumSkyLightingBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumSkyLightingBounces");
        IndirectLightingQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IndirectLightingQuality");
        IndirectLightingSmoothness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IndirectLightingSmoothness");
        EnvironmentColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnvironmentColor");
        EnvironmentIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnvironmentIntensity");
        DiffuseBoost_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DiffuseBoost");
        VolumeLightingMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeLightingMethod");
        bUseAmbientOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseAmbientOcclusion");
        bUseAmbientOcclusion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseAmbientOcclusion");
        bGenerateAmbientOcclusionMaterialMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateAmbientOcclusionMaterialMask");
        bGenerateAmbientOcclusionMaterialMask_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGenerateAmbientOcclusionMaterialMask");
        bVisualizeMaterialDiffuse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bVisualizeMaterialDiffuse");
        bVisualizeMaterialDiffuse_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bVisualizeMaterialDiffuse");
        bVisualizeAmbientOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bVisualizeAmbientOcclusion");
        bVisualizeAmbientOcclusion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bVisualizeAmbientOcclusion");
        bCompressLightmaps_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCompressLightmaps");
        bCompressLightmaps_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCompressLightmaps");
        VolumetricLightmapDetailCellSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumetricLightmapDetailCellSize");
        VolumetricLightmapMaximumBrickMemoryMb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumetricLightmapMaximumBrickMemoryMb");
        VolumetricLightmapSphericalHarmonicSmoothing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumetricLightmapSphericalHarmonicSmoothing");
        VolumeLightSamplePlacementScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeLightSamplePlacementScale");
        DirectIlluminationOcclusionFraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DirectIlluminationOcclusionFraction");
        IndirectIlluminationOcclusionFraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IndirectIlluminationOcclusionFraction");
        OcclusionExponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionExponent");
        FullyOccludedSamplesFraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FullyOccludedSamplesFraction");
        MaxOcclusionDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxOcclusionDistance");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LightmassWorldInfoSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            StaticLightingLevelScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, StaticLightingLevelScale_Offset), 0, null);
            NumIndirectLightingBounces = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumIndirectLightingBounces_Offset), 0, null);
            NumSkyLightingBounces = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumSkyLightingBounces_Offset), 0, null);
            IndirectLightingQuality = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, IndirectLightingQuality_Offset), 0, null);
            IndirectLightingSmoothness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, IndirectLightingSmoothness_Offset), 0, null);
            EnvironmentColor = BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(InNativeStruct, EnvironmentColor_Offset), 0, null);
            EnvironmentIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, EnvironmentIntensity_Offset), 0, null);
            DiffuseBoost = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DiffuseBoost_Offset), 0, null);
            VolumeLightingMethod = BlittableMarshaller<UnrealSharp.Engine.EVolumeLightingMethod>.FromNative(IntPtr.Add(InNativeStruct, VolumeLightingMethod_Offset), 0, null);
            UseAmbientOcclusion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseAmbientOcclusion_NativeProperty, bUseAmbientOcclusion_Offset);
            GenerateAmbientOcclusionMaterialMask = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGenerateAmbientOcclusionMaterialMask_NativeProperty, bGenerateAmbientOcclusionMaterialMask_Offset);
            VisualizeMaterialDiffuse = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bVisualizeMaterialDiffuse_NativeProperty, bVisualizeMaterialDiffuse_Offset);
            VisualizeAmbientOcclusion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bVisualizeAmbientOcclusion_NativeProperty, bVisualizeAmbientOcclusion_Offset);
            CompressLightmaps = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCompressLightmaps_NativeProperty, bCompressLightmaps_Offset);
            VolumetricLightmapDetailCellSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VolumetricLightmapDetailCellSize_Offset), 0, null);
            VolumetricLightmapMaximumBrickMemoryMb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VolumetricLightmapMaximumBrickMemoryMb_Offset), 0, null);
            VolumetricLightmapSphericalHarmonicSmoothing = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VolumetricLightmapSphericalHarmonicSmoothing_Offset), 0, null);
            VolumeLightSamplePlacementScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VolumeLightSamplePlacementScale_Offset), 0, null);
            DirectIlluminationOcclusionFraction = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DirectIlluminationOcclusionFraction_Offset), 0, null);
            IndirectIlluminationOcclusionFraction = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, IndirectIlluminationOcclusionFraction_Offset), 0, null);
            OcclusionExponent = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OcclusionExponent_Offset), 0, null);
            FullyOccludedSamplesFraction = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FullyOccludedSamplesFraction_Offset), 0, null);
            MaxOcclusionDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxOcclusionDistance_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, StaticLightingLevelScale_Offset), 0, null, StaticLightingLevelScale);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumIndirectLightingBounces_Offset), 0, null, NumIndirectLightingBounces);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumSkyLightingBounces_Offset), 0, null, NumSkyLightingBounces);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, IndirectLightingQuality_Offset), 0, null, IndirectLightingQuality);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, IndirectLightingSmoothness_Offset), 0, null, IndirectLightingSmoothness);
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(Buffer, EnvironmentColor_Offset), 0, null, EnvironmentColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, EnvironmentIntensity_Offset), 0, null, EnvironmentIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DiffuseBoost_Offset), 0, null, DiffuseBoost);
            BlittableMarshaller<UnrealSharp.Engine.EVolumeLightingMethod>.ToNative(IntPtr.Add(Buffer, VolumeLightingMethod_Offset), 0, null, VolumeLightingMethod);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseAmbientOcclusion_NativeProperty, bUseAmbientOcclusion_Offset, UseAmbientOcclusion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGenerateAmbientOcclusionMaterialMask_NativeProperty, bGenerateAmbientOcclusionMaterialMask_Offset, GenerateAmbientOcclusionMaterialMask);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bVisualizeMaterialDiffuse_NativeProperty, bVisualizeMaterialDiffuse_Offset, VisualizeMaterialDiffuse);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bVisualizeAmbientOcclusion_NativeProperty, bVisualizeAmbientOcclusion_Offset, VisualizeAmbientOcclusion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCompressLightmaps_NativeProperty, bCompressLightmaps_Offset, CompressLightmaps);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VolumetricLightmapDetailCellSize_Offset), 0, null, VolumetricLightmapDetailCellSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VolumetricLightmapMaximumBrickMemoryMb_Offset), 0, null, VolumetricLightmapMaximumBrickMemoryMb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VolumetricLightmapSphericalHarmonicSmoothing_Offset), 0, null, VolumetricLightmapSphericalHarmonicSmoothing);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VolumeLightSamplePlacementScale_Offset), 0, null, VolumeLightSamplePlacementScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DirectIlluminationOcclusionFraction_Offset), 0, null, DirectIlluminationOcclusionFraction);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, IndirectIlluminationOcclusionFraction_Offset), 0, null, IndirectIlluminationOcclusionFraction);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OcclusionExponent_Offset), 0, null, OcclusionExponent);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FullyOccludedSamplesFraction_Offset), 0, null, FullyOccludedSamplesFraction);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxOcclusionDistance_Offset), 0, null, MaxOcclusionDistance);
        }
    }
}

public static class LightmassWorldInfoSettingsMarshaler
{
    public static LightmassWorldInfoSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LightmassWorldInfoSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LightmassWorldInfoSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LightmassWorldInfoSettings.NativeDataSize;
    }
}