using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MeshProxySettings
{
    // IntProperty /Script/Engine.MeshProxySettings:ScreenSize
    static readonly int ScreenSize_Offset;
    public int ScreenSize;
    
    // FloatProperty /Script/Engine.MeshProxySettings:VoxelSize
    static readonly int VoxelSize_Offset;
    public float VoxelSize;
    
    // StructProperty /Script/Engine.MeshProxySettings:MaterialSettings
    static readonly int MaterialSettings_Offset;
    public UnrealSharp.Engine.MaterialProxySettings MaterialSettings;
    
    // FloatProperty /Script/Engine.MeshProxySettings:MergeDistance
    static readonly int MergeDistance_Offset;
    public float MergeDistance;
    
    // StructProperty /Script/Engine.MeshProxySettings:UnresolvedGeometryColor
    static readonly int UnresolvedGeometryColor_Offset;
    public UnrealSharp.CoreUObject.Color UnresolvedGeometryColor;
    
    // FloatProperty /Script/Engine.MeshProxySettings:MaxRayCastDist
    static readonly int MaxRayCastDist_Offset;
    public float MaxRayCastDist;
    
    // FloatProperty /Script/Engine.MeshProxySettings:HardAngleThreshold
    static readonly int HardAngleThreshold_Offset;
    public float HardAngleThreshold;
    
    // IntProperty /Script/Engine.MeshProxySettings:LightMapResolution
    static readonly int LightMapResolution_Offset;
    public int LightMapResolution;
    
    // ByteProperty /Script/Engine.MeshProxySettings:NormalCalculationMethod
    static readonly int NormalCalculationMethod_Offset;
    public UnrealSharp.Engine.EProxyNormalComputationMethod NormalCalculationMethod;
    
    // ByteProperty /Script/Engine.MeshProxySettings:LandscapeCullingPrecision
    static readonly int LandscapeCullingPrecision_Offset;
    public UnrealSharp.Engine.ELandscapeCullingPrecision LandscapeCullingPrecision;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bCalculateCorrectLODModel
    static readonly int bCalculateCorrectLODModel_Offset;
    static readonly IntPtr bCalculateCorrectLODModel_NativeProperty;
    public bool CalculateCorrectLODModel;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bOverrideVoxelSize
    static readonly int bOverrideVoxelSize_Offset;
    static readonly IntPtr bOverrideVoxelSize_NativeProperty;
    public bool OverrideVoxelSize;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bOverrideTransferDistance
    static readonly int bOverrideTransferDistance_Offset;
    static readonly IntPtr bOverrideTransferDistance_NativeProperty;
    public bool OverrideTransferDistance;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bUseHardAngleThreshold
    static readonly int bUseHardAngleThreshold_Offset;
    static readonly IntPtr bUseHardAngleThreshold_NativeProperty;
    public bool UseHardAngleThreshold;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bComputeLightMapResolution
    static readonly int bComputeLightMapResolution_Offset;
    static readonly IntPtr bComputeLightMapResolution_NativeProperty;
    public bool ComputeLightMapResolution;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bRecalculateNormals
    static readonly int bRecalculateNormals_Offset;
    static readonly IntPtr bRecalculateNormals_NativeProperty;
    public bool RecalculateNormals;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bUseLandscapeCulling
    static readonly int bUseLandscapeCulling_Offset;
    static readonly IntPtr bUseLandscapeCulling_NativeProperty;
    public bool UseLandscapeCulling;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bSupportRayTracing
    static readonly int bSupportRayTracing_Offset;
    static readonly IntPtr bSupportRayTracing_NativeProperty;
    public bool SupportRayTracing;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bAllowDistanceField
    static readonly int bAllowDistanceField_Offset;
    static readonly IntPtr bAllowDistanceField_NativeProperty;
    public bool AllowDistanceField;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bReuseMeshLightmapUVs
    static readonly int bReuseMeshLightmapUVs_Offset;
    static readonly IntPtr bReuseMeshLightmapUVs_NativeProperty;
    public bool ReuseMeshLightmapUVs;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bGroupIdenticalMeshesForBaking
    static readonly int bGroupIdenticalMeshesForBaking_Offset;
    static readonly IntPtr bGroupIdenticalMeshesForBaking_NativeProperty;
    public bool GroupIdenticalMeshesForBaking;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bCreateCollision
    static readonly int bCreateCollision_Offset;
    static readonly IntPtr bCreateCollision_NativeProperty;
    public bool CreateCollision;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bAllowVertexColors
    static readonly int bAllowVertexColors_Offset;
    static readonly IntPtr bAllowVertexColors_NativeProperty;
    public bool AllowVertexColors;
    
    // BoolProperty /Script/Engine.MeshProxySettings:bGenerateLightmapUVs
    static readonly int bGenerateLightmapUVs_Offset;
    static readonly IntPtr bGenerateLightmapUVs_NativeProperty;
    public bool GenerateLightmapUVs;
    
    // StructProperty /Script/Engine.MeshProxySettings:NaniteSettings
    static readonly int NaniteSettings_Offset;
    public UnrealSharp.Engine.MeshNaniteSettings NaniteSettings;
    
    
    public static readonly int NativeDataSize;
    static MeshProxySettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MeshProxySettings");
        
        ScreenSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScreenSize");
        VoxelSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VoxelSize");
        MaterialSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaterialSettings");
        MergeDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MergeDistance");
        UnresolvedGeometryColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UnresolvedGeometryColor");
        MaxRayCastDist_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxRayCastDist");
        HardAngleThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HardAngleThreshold");
        LightMapResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LightMapResolution");
        NormalCalculationMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalCalculationMethod");
        LandscapeCullingPrecision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LandscapeCullingPrecision");
        bCalculateCorrectLODModel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCalculateCorrectLODModel");
        bCalculateCorrectLODModel_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCalculateCorrectLODModel");
        bOverrideVoxelSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideVoxelSize");
        bOverrideVoxelSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverrideVoxelSize");
        bOverrideTransferDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideTransferDistance");
        bOverrideTransferDistance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverrideTransferDistance");
        bUseHardAngleThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseHardAngleThreshold");
        bUseHardAngleThreshold_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseHardAngleThreshold");
        bComputeLightMapResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bComputeLightMapResolution");
        bComputeLightMapResolution_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bComputeLightMapResolution");
        bRecalculateNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecalculateNormals");
        bRecalculateNormals_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRecalculateNormals");
        bUseLandscapeCulling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseLandscapeCulling");
        bUseLandscapeCulling_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseLandscapeCulling");
        bSupportRayTracing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSupportRayTracing");
        bSupportRayTracing_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSupportRayTracing");
        bAllowDistanceField_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowDistanceField");
        bAllowDistanceField_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowDistanceField");
        bReuseMeshLightmapUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReuseMeshLightmapUVs");
        bReuseMeshLightmapUVs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bReuseMeshLightmapUVs");
        bGroupIdenticalMeshesForBaking_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroupIdenticalMeshesForBaking");
        bGroupIdenticalMeshesForBaking_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroupIdenticalMeshesForBaking");
        bCreateCollision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCreateCollision");
        bCreateCollision_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCreateCollision");
        bAllowVertexColors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowVertexColors");
        bAllowVertexColors_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAllowVertexColors");
        bGenerateLightmapUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateLightmapUVs");
        bGenerateLightmapUVs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGenerateLightmapUVs");
        NaniteSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NaniteSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MeshProxySettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ScreenSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ScreenSize_Offset), 0, null);
            VoxelSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VoxelSize_Offset), 0, null);
            MaterialSettings = UnrealSharp.Engine.MaterialProxySettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, MaterialSettings_Offset), 0, null);
            MergeDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MergeDistance_Offset), 0, null);
            UnresolvedGeometryColor = BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(InNativeStruct, UnresolvedGeometryColor_Offset), 0, null);
            MaxRayCastDist = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxRayCastDist_Offset), 0, null);
            HardAngleThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HardAngleThreshold_Offset), 0, null);
            LightMapResolution = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, LightMapResolution_Offset), 0, null);
            NormalCalculationMethod = BlittableMarshaller<UnrealSharp.Engine.EProxyNormalComputationMethod>.FromNative(IntPtr.Add(InNativeStruct, NormalCalculationMethod_Offset), 0, null);
            LandscapeCullingPrecision = BlittableMarshaller<UnrealSharp.Engine.ELandscapeCullingPrecision>.FromNative(IntPtr.Add(InNativeStruct, LandscapeCullingPrecision_Offset), 0, null);
            CalculateCorrectLODModel = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCalculateCorrectLODModel_NativeProperty, bCalculateCorrectLODModel_Offset);
            OverrideVoxelSize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverrideVoxelSize_NativeProperty, bOverrideVoxelSize_Offset);
            OverrideTransferDistance = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverrideTransferDistance_NativeProperty, bOverrideTransferDistance_Offset);
            UseHardAngleThreshold = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseHardAngleThreshold_NativeProperty, bUseHardAngleThreshold_Offset);
            ComputeLightMapResolution = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bComputeLightMapResolution_NativeProperty, bComputeLightMapResolution_Offset);
            RecalculateNormals = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRecalculateNormals_NativeProperty, bRecalculateNormals_Offset);
            UseLandscapeCulling = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseLandscapeCulling_NativeProperty, bUseLandscapeCulling_Offset);
            SupportRayTracing = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSupportRayTracing_NativeProperty, bSupportRayTracing_Offset);
            AllowDistanceField = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAllowDistanceField_NativeProperty, bAllowDistanceField_Offset);
            ReuseMeshLightmapUVs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bReuseMeshLightmapUVs_NativeProperty, bReuseMeshLightmapUVs_Offset);
            GroupIdenticalMeshesForBaking = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroupIdenticalMeshesForBaking_NativeProperty, bGroupIdenticalMeshesForBaking_Offset);
            CreateCollision = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCreateCollision_NativeProperty, bCreateCollision_Offset);
            AllowVertexColors = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAllowVertexColors_NativeProperty, bAllowVertexColors_Offset);
            GenerateLightmapUVs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGenerateLightmapUVs_NativeProperty, bGenerateLightmapUVs_Offset);
            NaniteSettings = UnrealSharp.Engine.MeshNaniteSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, NaniteSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ScreenSize_Offset), 0, null, ScreenSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VoxelSize_Offset), 0, null, VoxelSize);
            UnrealSharp.Engine.MaterialProxySettingsMarshaler.ToNative(IntPtr.Add(Buffer, MaterialSettings_Offset), 0, null, MaterialSettings);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MergeDistance_Offset), 0, null, MergeDistance);
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(Buffer, UnresolvedGeometryColor_Offset), 0, null, UnresolvedGeometryColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxRayCastDist_Offset), 0, null, MaxRayCastDist);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HardAngleThreshold_Offset), 0, null, HardAngleThreshold);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, LightMapResolution_Offset), 0, null, LightMapResolution);
            BlittableMarshaller<UnrealSharp.Engine.EProxyNormalComputationMethod>.ToNative(IntPtr.Add(Buffer, NormalCalculationMethod_Offset), 0, null, NormalCalculationMethod);
            BlittableMarshaller<UnrealSharp.Engine.ELandscapeCullingPrecision>.ToNative(IntPtr.Add(Buffer, LandscapeCullingPrecision_Offset), 0, null, LandscapeCullingPrecision);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCalculateCorrectLODModel_NativeProperty, bCalculateCorrectLODModel_Offset, CalculateCorrectLODModel);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverrideVoxelSize_NativeProperty, bOverrideVoxelSize_Offset, OverrideVoxelSize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverrideTransferDistance_NativeProperty, bOverrideTransferDistance_Offset, OverrideTransferDistance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseHardAngleThreshold_NativeProperty, bUseHardAngleThreshold_Offset, UseHardAngleThreshold);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bComputeLightMapResolution_NativeProperty, bComputeLightMapResolution_Offset, ComputeLightMapResolution);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRecalculateNormals_NativeProperty, bRecalculateNormals_Offset, RecalculateNormals);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseLandscapeCulling_NativeProperty, bUseLandscapeCulling_Offset, UseLandscapeCulling);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSupportRayTracing_NativeProperty, bSupportRayTracing_Offset, SupportRayTracing);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAllowDistanceField_NativeProperty, bAllowDistanceField_Offset, AllowDistanceField);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bReuseMeshLightmapUVs_NativeProperty, bReuseMeshLightmapUVs_Offset, ReuseMeshLightmapUVs);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroupIdenticalMeshesForBaking_NativeProperty, bGroupIdenticalMeshesForBaking_Offset, GroupIdenticalMeshesForBaking);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCreateCollision_NativeProperty, bCreateCollision_Offset, CreateCollision);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAllowVertexColors_NativeProperty, bAllowVertexColors_Offset, AllowVertexColors);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGenerateLightmapUVs_NativeProperty, bGenerateLightmapUVs_Offset, GenerateLightmapUVs);
            UnrealSharp.Engine.MeshNaniteSettingsMarshaler.ToNative(IntPtr.Add(Buffer, NaniteSettings_Offset), 0, null, NaniteSettings);
        }
    }
}

public static class MeshProxySettingsMarshaler
{
    public static MeshProxySettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MeshProxySettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MeshProxySettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MeshProxySettings.NativeDataSize;
    }
}