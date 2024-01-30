using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MeshBuildSettings
{
    // BoolProperty /Script/Engine.MeshBuildSettings:bUseMikkTSpace
    static readonly int bUseMikkTSpace_Offset;
    static readonly IntPtr bUseMikkTSpace_NativeProperty;
    public bool UseMikkTSpace;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bRecomputeNormals
    static readonly int bRecomputeNormals_Offset;
    static readonly IntPtr bRecomputeNormals_NativeProperty;
    public bool RecomputeNormals;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bRecomputeTangents
    static readonly int bRecomputeTangents_Offset;
    static readonly IntPtr bRecomputeTangents_NativeProperty;
    public bool RecomputeTangents;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bComputeWeightedNormals
    static readonly int bComputeWeightedNormals_Offset;
    static readonly IntPtr bComputeWeightedNormals_NativeProperty;
    public bool ComputeWeightedNormals;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bRemoveDegenerates
    static readonly int bRemoveDegenerates_Offset;
    static readonly IntPtr bRemoveDegenerates_NativeProperty;
    public bool RemoveDegenerates;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bBuildReversedIndexBuffer
    static readonly int bBuildReversedIndexBuffer_Offset;
    static readonly IntPtr bBuildReversedIndexBuffer_NativeProperty;
    public bool BuildReversedIndexBuffer;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bUseHighPrecisionTangentBasis
    static readonly int bUseHighPrecisionTangentBasis_Offset;
    static readonly IntPtr bUseHighPrecisionTangentBasis_NativeProperty;
    public bool UseHighPrecisionTangentBasis;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bUseFullPrecisionUVs
    static readonly int bUseFullPrecisionUVs_Offset;
    static readonly IntPtr bUseFullPrecisionUVs_NativeProperty;
    public bool UseFullPrecisionUVs;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bUseBackwardsCompatibleF16TruncUVs
    static readonly int bUseBackwardsCompatibleF16TruncUVs_Offset;
    static readonly IntPtr bUseBackwardsCompatibleF16TruncUVs_NativeProperty;
    public bool UseBackwardsCompatibleF16TruncUVs;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bGenerateLightmapUVs
    static readonly int bGenerateLightmapUVs_Offset;
    static readonly IntPtr bGenerateLightmapUVs_NativeProperty;
    public bool GenerateLightmapUVs;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bGenerateDistanceFieldAsIfTwoSided
    static readonly int bGenerateDistanceFieldAsIfTwoSided_Offset;
    static readonly IntPtr bGenerateDistanceFieldAsIfTwoSided_NativeProperty;
    public bool GenerateDistanceFieldAsIfTwoSided;
    
    // BoolProperty /Script/Engine.MeshBuildSettings:bSupportFaceRemap
    static readonly int bSupportFaceRemap_Offset;
    static readonly IntPtr bSupportFaceRemap_NativeProperty;
    public bool SupportFaceRemap;
    
    // IntProperty /Script/Engine.MeshBuildSettings:MinLightmapResolution
    static readonly int MinLightmapResolution_Offset;
    public int MinLightmapResolution;
    
    // IntProperty /Script/Engine.MeshBuildSettings:SrcLightmapIndex
    static readonly int SrcLightmapIndex_Offset;
    public int SrcLightmapIndex;
    
    // IntProperty /Script/Engine.MeshBuildSettings:DstLightmapIndex
    static readonly int DstLightmapIndex_Offset;
    public int DstLightmapIndex;
    
    // StructProperty /Script/Engine.MeshBuildSettings:BuildScale3D
    static readonly int BuildScale3D_Offset;
    public System.DoubleNumerics.Vector3 BuildScale3D;
    
    // FloatProperty /Script/Engine.MeshBuildSettings:DistanceFieldResolutionScale
    static readonly int DistanceFieldResolutionScale_Offset;
    public float DistanceFieldResolutionScale;
    
    // ObjectProperty /Script/Engine.MeshBuildSettings:DistanceFieldReplacementMesh
    static readonly int DistanceFieldReplacementMesh_Offset;
    public UnrealSharp.Engine.StaticMesh DistanceFieldReplacementMesh;
    
    // IntProperty /Script/Engine.MeshBuildSettings:MaxLumenMeshCards
    static readonly int MaxLumenMeshCards_Offset;
    public int MaxLumenMeshCards;
    
    
    public static readonly int NativeDataSize;
    static MeshBuildSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MeshBuildSettings");
        
        bUseMikkTSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseMikkTSpace");
        bUseMikkTSpace_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseMikkTSpace");
        bRecomputeNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecomputeNormals");
        bRecomputeNormals_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRecomputeNormals");
        bRecomputeTangents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecomputeTangents");
        bRecomputeTangents_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRecomputeTangents");
        bComputeWeightedNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bComputeWeightedNormals");
        bComputeWeightedNormals_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bComputeWeightedNormals");
        bRemoveDegenerates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRemoveDegenerates");
        bRemoveDegenerates_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRemoveDegenerates");
        bBuildReversedIndexBuffer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBuildReversedIndexBuffer");
        bBuildReversedIndexBuffer_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bBuildReversedIndexBuffer");
        bUseHighPrecisionTangentBasis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseHighPrecisionTangentBasis");
        bUseHighPrecisionTangentBasis_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseHighPrecisionTangentBasis");
        bUseFullPrecisionUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseFullPrecisionUVs");
        bUseFullPrecisionUVs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseFullPrecisionUVs");
        bUseBackwardsCompatibleF16TruncUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseBackwardsCompatibleF16TruncUVs");
        bUseBackwardsCompatibleF16TruncUVs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseBackwardsCompatibleF16TruncUVs");
        bGenerateLightmapUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateLightmapUVs");
        bGenerateLightmapUVs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGenerateLightmapUVs");
        bGenerateDistanceFieldAsIfTwoSided_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateDistanceFieldAsIfTwoSided");
        bGenerateDistanceFieldAsIfTwoSided_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGenerateDistanceFieldAsIfTwoSided");
        bSupportFaceRemap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSupportFaceRemap");
        bSupportFaceRemap_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSupportFaceRemap");
        MinLightmapResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinLightmapResolution");
        SrcLightmapIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SrcLightmapIndex");
        DstLightmapIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DstLightmapIndex");
        BuildScale3D_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BuildScale3D");
        DistanceFieldResolutionScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceFieldResolutionScale");
        DistanceFieldReplacementMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceFieldReplacementMesh");
        MaxLumenMeshCards_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxLumenMeshCards");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MeshBuildSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            UseMikkTSpace = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseMikkTSpace_NativeProperty, bUseMikkTSpace_Offset);
            RecomputeNormals = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRecomputeNormals_NativeProperty, bRecomputeNormals_Offset);
            RecomputeTangents = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRecomputeTangents_NativeProperty, bRecomputeTangents_Offset);
            ComputeWeightedNormals = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bComputeWeightedNormals_NativeProperty, bComputeWeightedNormals_Offset);
            RemoveDegenerates = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRemoveDegenerates_NativeProperty, bRemoveDegenerates_Offset);
            BuildReversedIndexBuffer = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bBuildReversedIndexBuffer_NativeProperty, bBuildReversedIndexBuffer_Offset);
            UseHighPrecisionTangentBasis = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseHighPrecisionTangentBasis_NativeProperty, bUseHighPrecisionTangentBasis_Offset);
            UseFullPrecisionUVs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseFullPrecisionUVs_NativeProperty, bUseFullPrecisionUVs_Offset);
            UseBackwardsCompatibleF16TruncUVs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseBackwardsCompatibleF16TruncUVs_NativeProperty, bUseBackwardsCompatibleF16TruncUVs_Offset);
            GenerateLightmapUVs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGenerateLightmapUVs_NativeProperty, bGenerateLightmapUVs_Offset);
            GenerateDistanceFieldAsIfTwoSided = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGenerateDistanceFieldAsIfTwoSided_NativeProperty, bGenerateDistanceFieldAsIfTwoSided_Offset);
            SupportFaceRemap = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSupportFaceRemap_NativeProperty, bSupportFaceRemap_Offset);
            MinLightmapResolution = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MinLightmapResolution_Offset), 0, null);
            SrcLightmapIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SrcLightmapIndex_Offset), 0, null);
            DstLightmapIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, DstLightmapIndex_Offset), 0, null);
            BuildScale3D = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, BuildScale3D_Offset), 0, null);
            DistanceFieldResolutionScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DistanceFieldResolutionScale_Offset), 0, null);
            DistanceFieldReplacementMesh = ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.FromNative(IntPtr.Add(InNativeStruct, DistanceFieldReplacementMesh_Offset), 0, null);
            MaxLumenMeshCards = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxLumenMeshCards_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseMikkTSpace_NativeProperty, bUseMikkTSpace_Offset, UseMikkTSpace);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRecomputeNormals_NativeProperty, bRecomputeNormals_Offset, RecomputeNormals);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRecomputeTangents_NativeProperty, bRecomputeTangents_Offset, RecomputeTangents);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bComputeWeightedNormals_NativeProperty, bComputeWeightedNormals_Offset, ComputeWeightedNormals);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRemoveDegenerates_NativeProperty, bRemoveDegenerates_Offset, RemoveDegenerates);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bBuildReversedIndexBuffer_NativeProperty, bBuildReversedIndexBuffer_Offset, BuildReversedIndexBuffer);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseHighPrecisionTangentBasis_NativeProperty, bUseHighPrecisionTangentBasis_Offset, UseHighPrecisionTangentBasis);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseFullPrecisionUVs_NativeProperty, bUseFullPrecisionUVs_Offset, UseFullPrecisionUVs);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseBackwardsCompatibleF16TruncUVs_NativeProperty, bUseBackwardsCompatibleF16TruncUVs_Offset, UseBackwardsCompatibleF16TruncUVs);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGenerateLightmapUVs_NativeProperty, bGenerateLightmapUVs_Offset, GenerateLightmapUVs);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGenerateDistanceFieldAsIfTwoSided_NativeProperty, bGenerateDistanceFieldAsIfTwoSided_Offset, GenerateDistanceFieldAsIfTwoSided);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSupportFaceRemap_NativeProperty, bSupportFaceRemap_Offset, SupportFaceRemap);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MinLightmapResolution_Offset), 0, null, MinLightmapResolution);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SrcLightmapIndex_Offset), 0, null, SrcLightmapIndex);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, DstLightmapIndex_Offset), 0, null, DstLightmapIndex);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, BuildScale3D_Offset), 0, null, BuildScale3D);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DistanceFieldResolutionScale_Offset), 0, null, DistanceFieldResolutionScale);
            ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.ToNative(IntPtr.Add(Buffer, DistanceFieldReplacementMesh_Offset), 0, null, DistanceFieldReplacementMesh);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxLumenMeshCards_Offset), 0, null, MaxLumenMeshCards);
        }
    }
}

public static class MeshBuildSettingsMarshaler
{
    public static MeshBuildSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MeshBuildSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MeshBuildSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MeshBuildSettings.NativeDataSize;
    }
}