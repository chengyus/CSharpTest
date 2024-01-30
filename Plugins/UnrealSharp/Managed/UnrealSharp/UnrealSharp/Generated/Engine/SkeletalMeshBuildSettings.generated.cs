using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SkeletalMeshBuildSettings
{
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bRecomputeNormals
    static readonly int bRecomputeNormals_Offset;
    static readonly IntPtr bRecomputeNormals_NativeProperty;
    public bool RecomputeNormals;
    
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bRecomputeTangents
    static readonly int bRecomputeTangents_Offset;
    static readonly IntPtr bRecomputeTangents_NativeProperty;
    public bool RecomputeTangents;
    
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bUseMikkTSpace
    static readonly int bUseMikkTSpace_Offset;
    static readonly IntPtr bUseMikkTSpace_NativeProperty;
    public bool UseMikkTSpace;
    
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bComputeWeightedNormals
    static readonly int bComputeWeightedNormals_Offset;
    static readonly IntPtr bComputeWeightedNormals_NativeProperty;
    public bool ComputeWeightedNormals;
    
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bRemoveDegenerates
    static readonly int bRemoveDegenerates_Offset;
    static readonly IntPtr bRemoveDegenerates_NativeProperty;
    public bool RemoveDegenerates;
    
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bUseHighPrecisionTangentBasis
    static readonly int bUseHighPrecisionTangentBasis_Offset;
    static readonly IntPtr bUseHighPrecisionTangentBasis_NativeProperty;
    public bool UseHighPrecisionTangentBasis;
    
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bUseHighPrecisionSkinWeights
    static readonly int bUseHighPrecisionSkinWeights_Offset;
    static readonly IntPtr bUseHighPrecisionSkinWeights_NativeProperty;
    public bool UseHighPrecisionSkinWeights;
    
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bUseFullPrecisionUVs
    static readonly int bUseFullPrecisionUVs_Offset;
    static readonly IntPtr bUseFullPrecisionUVs_NativeProperty;
    public bool UseFullPrecisionUVs;
    
    // BoolProperty /Script/Engine.SkeletalMeshBuildSettings:bUseBackwardsCompatibleF16TruncUVs
    static readonly int bUseBackwardsCompatibleF16TruncUVs_Offset;
    static readonly IntPtr bUseBackwardsCompatibleF16TruncUVs_NativeProperty;
    public bool UseBackwardsCompatibleF16TruncUVs;
    
    // FloatProperty /Script/Engine.SkeletalMeshBuildSettings:ThresholdPosition
    static readonly int ThresholdPosition_Offset;
    public float ThresholdPosition;
    
    // FloatProperty /Script/Engine.SkeletalMeshBuildSettings:ThresholdTangentNormal
    static readonly int ThresholdTangentNormal_Offset;
    public float ThresholdTangentNormal;
    
    // FloatProperty /Script/Engine.SkeletalMeshBuildSettings:ThresholdUV
    static readonly int ThresholdUV_Offset;
    public float ThresholdUV;
    
    // FloatProperty /Script/Engine.SkeletalMeshBuildSettings:MorphThresholdPosition
    static readonly int MorphThresholdPosition_Offset;
    public float MorphThresholdPosition;
    
    // IntProperty /Script/Engine.SkeletalMeshBuildSettings:BoneInfluenceLimit
    static readonly int BoneInfluenceLimit_Offset;
    public int BoneInfluenceLimit;
    
    
    public static readonly int NativeDataSize;
    static SkeletalMeshBuildSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SkeletalMeshBuildSettings");
        
        bRecomputeNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecomputeNormals");
        bRecomputeNormals_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRecomputeNormals");
        bRecomputeTangents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecomputeTangents");
        bRecomputeTangents_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRecomputeTangents");
        bUseMikkTSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseMikkTSpace");
        bUseMikkTSpace_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseMikkTSpace");
        bComputeWeightedNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bComputeWeightedNormals");
        bComputeWeightedNormals_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bComputeWeightedNormals");
        bRemoveDegenerates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRemoveDegenerates");
        bRemoveDegenerates_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRemoveDegenerates");
        bUseHighPrecisionTangentBasis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseHighPrecisionTangentBasis");
        bUseHighPrecisionTangentBasis_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseHighPrecisionTangentBasis");
        bUseHighPrecisionSkinWeights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseHighPrecisionSkinWeights");
        bUseHighPrecisionSkinWeights_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseHighPrecisionSkinWeights");
        bUseFullPrecisionUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseFullPrecisionUVs");
        bUseFullPrecisionUVs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseFullPrecisionUVs");
        bUseBackwardsCompatibleF16TruncUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseBackwardsCompatibleF16TruncUVs");
        bUseBackwardsCompatibleF16TruncUVs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseBackwardsCompatibleF16TruncUVs");
        ThresholdPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ThresholdPosition");
        ThresholdTangentNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ThresholdTangentNormal");
        ThresholdUV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ThresholdUV");
        MorphThresholdPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MorphThresholdPosition");
        BoneInfluenceLimit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneInfluenceLimit");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SkeletalMeshBuildSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            RecomputeNormals = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRecomputeNormals_NativeProperty, bRecomputeNormals_Offset);
            RecomputeTangents = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRecomputeTangents_NativeProperty, bRecomputeTangents_Offset);
            UseMikkTSpace = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseMikkTSpace_NativeProperty, bUseMikkTSpace_Offset);
            ComputeWeightedNormals = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bComputeWeightedNormals_NativeProperty, bComputeWeightedNormals_Offset);
            RemoveDegenerates = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRemoveDegenerates_NativeProperty, bRemoveDegenerates_Offset);
            UseHighPrecisionTangentBasis = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseHighPrecisionTangentBasis_NativeProperty, bUseHighPrecisionTangentBasis_Offset);
            UseHighPrecisionSkinWeights = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseHighPrecisionSkinWeights_NativeProperty, bUseHighPrecisionSkinWeights_Offset);
            UseFullPrecisionUVs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseFullPrecisionUVs_NativeProperty, bUseFullPrecisionUVs_Offset);
            UseBackwardsCompatibleF16TruncUVs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseBackwardsCompatibleF16TruncUVs_NativeProperty, bUseBackwardsCompatibleF16TruncUVs_Offset);
            ThresholdPosition = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ThresholdPosition_Offset), 0, null);
            ThresholdTangentNormal = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ThresholdTangentNormal_Offset), 0, null);
            ThresholdUV = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ThresholdUV_Offset), 0, null);
            MorphThresholdPosition = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MorphThresholdPosition_Offset), 0, null);
            BoneInfluenceLimit = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BoneInfluenceLimit_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRecomputeNormals_NativeProperty, bRecomputeNormals_Offset, RecomputeNormals);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRecomputeTangents_NativeProperty, bRecomputeTangents_Offset, RecomputeTangents);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseMikkTSpace_NativeProperty, bUseMikkTSpace_Offset, UseMikkTSpace);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bComputeWeightedNormals_NativeProperty, bComputeWeightedNormals_Offset, ComputeWeightedNormals);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRemoveDegenerates_NativeProperty, bRemoveDegenerates_Offset, RemoveDegenerates);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseHighPrecisionTangentBasis_NativeProperty, bUseHighPrecisionTangentBasis_Offset, UseHighPrecisionTangentBasis);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseHighPrecisionSkinWeights_NativeProperty, bUseHighPrecisionSkinWeights_Offset, UseHighPrecisionSkinWeights);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseFullPrecisionUVs_NativeProperty, bUseFullPrecisionUVs_Offset, UseFullPrecisionUVs);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseBackwardsCompatibleF16TruncUVs_NativeProperty, bUseBackwardsCompatibleF16TruncUVs_Offset, UseBackwardsCompatibleF16TruncUVs);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ThresholdPosition_Offset), 0, null, ThresholdPosition);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ThresholdTangentNormal_Offset), 0, null, ThresholdTangentNormal);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ThresholdUV_Offset), 0, null, ThresholdUV);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MorphThresholdPosition_Offset), 0, null, MorphThresholdPosition);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BoneInfluenceLimit_Offset), 0, null, BoneInfluenceLimit);
        }
    }
}

public static class SkeletalMeshBuildSettingsMarshaler
{
    public static SkeletalMeshBuildSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SkeletalMeshBuildSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SkeletalMeshBuildSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SkeletalMeshBuildSettings.NativeDataSize;
    }
}