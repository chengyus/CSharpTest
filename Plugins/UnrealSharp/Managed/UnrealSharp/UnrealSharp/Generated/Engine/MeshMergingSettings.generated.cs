using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MeshMergingSettings
{
    // IntProperty /Script/Engine.MeshMergingSettings:TargetLightMapResolution
    static readonly int TargetLightMapResolution_Offset;
    public int TargetLightMapResolution;
    
    // StructProperty /Script/Engine.MeshMergingSettings:MaterialSettings
    static readonly int MaterialSettings_Offset;
    public UnrealSharp.Engine.MaterialProxySettings MaterialSettings;
    
    // EnumProperty /Script/Engine.MeshMergingSettings:LODSelectionType
    static readonly int LODSelectionType_Offset;
    public UnrealSharp.Engine.EMeshLODSelectionType LODSelectionType;
    
    // IntProperty /Script/Engine.MeshMergingSettings:SpecificLOD
    static readonly int SpecificLOD_Offset;
    public int SpecificLOD;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bGenerateLightMapUV
    static readonly int bGenerateLightMapUV_Offset;
    static readonly IntPtr bGenerateLightMapUV_NativeProperty;
    public bool GenerateLightMapUV;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bComputedLightMapResolution
    static readonly int bComputedLightMapResolution_Offset;
    static readonly IntPtr bComputedLightMapResolution_NativeProperty;
    public bool ComputedLightMapResolution;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bPivotPointAtZero
    static readonly int bPivotPointAtZero_Offset;
    static readonly IntPtr bPivotPointAtZero_NativeProperty;
    public bool PivotPointAtZero;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bMergePhysicsData
    static readonly int bMergePhysicsData_Offset;
    static readonly IntPtr bMergePhysicsData_NativeProperty;
    public bool MergePhysicsData;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bMergeMeshSockets
    static readonly int bMergeMeshSockets_Offset;
    static readonly IntPtr bMergeMeshSockets_NativeProperty;
    public bool MergeMeshSockets;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bMergeMaterials
    static readonly int bMergeMaterials_Offset;
    static readonly IntPtr bMergeMaterials_NativeProperty;
    public bool MergeMaterials;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bBakeVertexDataToMesh
    static readonly int bBakeVertexDataToMesh_Offset;
    static readonly IntPtr bBakeVertexDataToMesh_NativeProperty;
    public bool BakeVertexDataToMesh;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bUseVertexDataForBakingMaterial
    static readonly int bUseVertexDataForBakingMaterial_Offset;
    static readonly IntPtr bUseVertexDataForBakingMaterial_NativeProperty;
    public bool UseVertexDataForBakingMaterial;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bUseTextureBinning
    static readonly int bUseTextureBinning_Offset;
    static readonly IntPtr bUseTextureBinning_NativeProperty;
    public bool UseTextureBinning;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bUseLandscapeCulling
    static readonly int bUseLandscapeCulling_Offset;
    static readonly IntPtr bUseLandscapeCulling_NativeProperty;
    public bool UseLandscapeCulling;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bIncludeImposters
    static readonly int bIncludeImposters_Offset;
    static readonly IntPtr bIncludeImposters_NativeProperty;
    public bool IncludeImposters;
    
    // BoolProperty /Script/Engine.MeshMergingSettings:bSupportRayTracing
    static readonly int bSupportRayTracing_Offset;
    static readonly IntPtr bSupportRayTracing_NativeProperty;
    public bool SupportRayTracing;
    
    // StructProperty /Script/Engine.MeshMergingSettings:NaniteSettings
    static readonly int NaniteSettings_Offset;
    public UnrealSharp.Engine.MeshNaniteSettings NaniteSettings;
    
    
    public static readonly int NativeDataSize;
    static MeshMergingSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MeshMergingSettings");
        
        TargetLightMapResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetLightMapResolution");
        MaterialSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaterialSettings");
        LODSelectionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LODSelectionType");
        SpecificLOD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpecificLOD");
        bGenerateLightMapUV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateLightMapUV");
        bGenerateLightMapUV_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGenerateLightMapUV");
        bComputedLightMapResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bComputedLightMapResolution");
        bComputedLightMapResolution_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bComputedLightMapResolution");
        bPivotPointAtZero_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPivotPointAtZero");
        bPivotPointAtZero_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bPivotPointAtZero");
        bMergePhysicsData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMergePhysicsData");
        bMergePhysicsData_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bMergePhysicsData");
        bMergeMeshSockets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMergeMeshSockets");
        bMergeMeshSockets_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bMergeMeshSockets");
        bMergeMaterials_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMergeMaterials");
        bMergeMaterials_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bMergeMaterials");
        bBakeVertexDataToMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBakeVertexDataToMesh");
        bBakeVertexDataToMesh_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bBakeVertexDataToMesh");
        bUseVertexDataForBakingMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseVertexDataForBakingMaterial");
        bUseVertexDataForBakingMaterial_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseVertexDataForBakingMaterial");
        bUseTextureBinning_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseTextureBinning");
        bUseTextureBinning_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseTextureBinning");
        bUseLandscapeCulling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseLandscapeCulling");
        bUseLandscapeCulling_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseLandscapeCulling");
        bIncludeImposters_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeImposters");
        bIncludeImposters_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIncludeImposters");
        bSupportRayTracing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSupportRayTracing");
        bSupportRayTracing_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSupportRayTracing");
        NaniteSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NaniteSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MeshMergingSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            TargetLightMapResolution = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, TargetLightMapResolution_Offset), 0, null);
            MaterialSettings = UnrealSharp.Engine.MaterialProxySettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, MaterialSettings_Offset), 0, null);
            LODSelectionType = BlittableMarshaller<UnrealSharp.Engine.EMeshLODSelectionType>.FromNative(IntPtr.Add(InNativeStruct, LODSelectionType_Offset), 0, null);
            SpecificLOD = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SpecificLOD_Offset), 0, null);
            GenerateLightMapUV = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGenerateLightMapUV_NativeProperty, bGenerateLightMapUV_Offset);
            ComputedLightMapResolution = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bComputedLightMapResolution_NativeProperty, bComputedLightMapResolution_Offset);
            PivotPointAtZero = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bPivotPointAtZero_NativeProperty, bPivotPointAtZero_Offset);
            MergePhysicsData = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bMergePhysicsData_NativeProperty, bMergePhysicsData_Offset);
            MergeMeshSockets = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bMergeMeshSockets_NativeProperty, bMergeMeshSockets_Offset);
            MergeMaterials = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bMergeMaterials_NativeProperty, bMergeMaterials_Offset);
            BakeVertexDataToMesh = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bBakeVertexDataToMesh_NativeProperty, bBakeVertexDataToMesh_Offset);
            UseVertexDataForBakingMaterial = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseVertexDataForBakingMaterial_NativeProperty, bUseVertexDataForBakingMaterial_Offset);
            UseTextureBinning = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseTextureBinning_NativeProperty, bUseTextureBinning_Offset);
            UseLandscapeCulling = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseLandscapeCulling_NativeProperty, bUseLandscapeCulling_Offset);
            IncludeImposters = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIncludeImposters_NativeProperty, bIncludeImposters_Offset);
            SupportRayTracing = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSupportRayTracing_NativeProperty, bSupportRayTracing_Offset);
            NaniteSettings = UnrealSharp.Engine.MeshNaniteSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, NaniteSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, TargetLightMapResolution_Offset), 0, null, TargetLightMapResolution);
            UnrealSharp.Engine.MaterialProxySettingsMarshaler.ToNative(IntPtr.Add(Buffer, MaterialSettings_Offset), 0, null, MaterialSettings);
            BlittableMarshaller<UnrealSharp.Engine.EMeshLODSelectionType>.ToNative(IntPtr.Add(Buffer, LODSelectionType_Offset), 0, null, LODSelectionType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SpecificLOD_Offset), 0, null, SpecificLOD);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGenerateLightMapUV_NativeProperty, bGenerateLightMapUV_Offset, GenerateLightMapUV);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bComputedLightMapResolution_NativeProperty, bComputedLightMapResolution_Offset, ComputedLightMapResolution);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bPivotPointAtZero_NativeProperty, bPivotPointAtZero_Offset, PivotPointAtZero);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bMergePhysicsData_NativeProperty, bMergePhysicsData_Offset, MergePhysicsData);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bMergeMeshSockets_NativeProperty, bMergeMeshSockets_Offset, MergeMeshSockets);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bMergeMaterials_NativeProperty, bMergeMaterials_Offset, MergeMaterials);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bBakeVertexDataToMesh_NativeProperty, bBakeVertexDataToMesh_Offset, BakeVertexDataToMesh);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseVertexDataForBakingMaterial_NativeProperty, bUseVertexDataForBakingMaterial_Offset, UseVertexDataForBakingMaterial);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseTextureBinning_NativeProperty, bUseTextureBinning_Offset, UseTextureBinning);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseLandscapeCulling_NativeProperty, bUseLandscapeCulling_Offset, UseLandscapeCulling);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIncludeImposters_NativeProperty, bIncludeImposters_Offset, IncludeImposters);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSupportRayTracing_NativeProperty, bSupportRayTracing_Offset, SupportRayTracing);
            UnrealSharp.Engine.MeshNaniteSettingsMarshaler.ToNative(IntPtr.Add(Buffer, NaniteSettings_Offset), 0, null, NaniteSettings);
        }
    }
}

public static class MeshMergingSettingsMarshaler
{
    public static MeshMergingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MeshMergingSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MeshMergingSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MeshMergingSettings.NativeDataSize;
    }
}