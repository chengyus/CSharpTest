using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MeshReductionSettings
{
    // FloatProperty /Script/Engine.MeshReductionSettings:PercentTriangles
    static readonly int PercentTriangles_Offset;
    public float PercentTriangles;
    
    // FloatProperty /Script/Engine.MeshReductionSettings:PercentVertices
    static readonly int PercentVertices_Offset;
    public float PercentVertices;
    
    // FloatProperty /Script/Engine.MeshReductionSettings:MaxDeviation
    static readonly int MaxDeviation_Offset;
    public float MaxDeviation;
    
    // FloatProperty /Script/Engine.MeshReductionSettings:PixelError
    static readonly int PixelError_Offset;
    public float PixelError;
    
    // FloatProperty /Script/Engine.MeshReductionSettings:WeldingThreshold
    static readonly int WeldingThreshold_Offset;
    public float WeldingThreshold;
    
    // FloatProperty /Script/Engine.MeshReductionSettings:HardAngleThreshold
    static readonly int HardAngleThreshold_Offset;
    public float HardAngleThreshold;
    
    // IntProperty /Script/Engine.MeshReductionSettings:BaseLODModel
    static readonly int BaseLODModel_Offset;
    public int BaseLODModel;
    
    // ByteProperty /Script/Engine.MeshReductionSettings:SilhouetteImportance
    static readonly int SilhouetteImportance_Offset;
    public UnrealSharp.Engine.EMeshFeatureImportance SilhouetteImportance;
    
    // ByteProperty /Script/Engine.MeshReductionSettings:TextureImportance
    static readonly int TextureImportance_Offset;
    public UnrealSharp.Engine.EMeshFeatureImportance TextureImportance;
    
    // ByteProperty /Script/Engine.MeshReductionSettings:ShadingImportance
    static readonly int ShadingImportance_Offset;
    public UnrealSharp.Engine.EMeshFeatureImportance ShadingImportance;
    
    // BoolProperty /Script/Engine.MeshReductionSettings:bRecalculateNormals
    static readonly int bRecalculateNormals_Offset;
    static readonly IntPtr bRecalculateNormals_NativeProperty;
    public bool RecalculateNormals;
    
    // BoolProperty /Script/Engine.MeshReductionSettings:bGenerateUniqueLightmapUVs
    static readonly int bGenerateUniqueLightmapUVs_Offset;
    static readonly IntPtr bGenerateUniqueLightmapUVs_NativeProperty;
    public bool GenerateUniqueLightmapUVs;
    
    // BoolProperty /Script/Engine.MeshReductionSettings:bKeepSymmetry
    static readonly int bKeepSymmetry_Offset;
    static readonly IntPtr bKeepSymmetry_NativeProperty;
    public bool KeepSymmetry;
    
    // BoolProperty /Script/Engine.MeshReductionSettings:bVisibilityAided
    static readonly int bVisibilityAided_Offset;
    static readonly IntPtr bVisibilityAided_NativeProperty;
    public bool VisibilityAided;
    
    // BoolProperty /Script/Engine.MeshReductionSettings:bCullOccluded
    static readonly int bCullOccluded_Offset;
    static readonly IntPtr bCullOccluded_NativeProperty;
    public bool CullOccluded;
    
    // EnumProperty /Script/Engine.MeshReductionSettings:TerminationCriterion
    static readonly int TerminationCriterion_Offset;
    public UnrealSharp.Engine.EStaticMeshReductionTerimationCriterion TerminationCriterion;
    
    // ByteProperty /Script/Engine.MeshReductionSettings:VisibilityAggressiveness
    static readonly int VisibilityAggressiveness_Offset;
    public UnrealSharp.Engine.EMeshFeatureImportance VisibilityAggressiveness;
    
    // ByteProperty /Script/Engine.MeshReductionSettings:VertexColorImportance
    static readonly int VertexColorImportance_Offset;
    public UnrealSharp.Engine.EMeshFeatureImportance VertexColorImportance;
    
    
    public static readonly int NativeDataSize;
    static MeshReductionSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MeshReductionSettings");
        
        PercentTriangles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PercentTriangles");
        PercentVertices_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PercentVertices");
        MaxDeviation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDeviation");
        PixelError_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PixelError");
        WeldingThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WeldingThreshold");
        HardAngleThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HardAngleThreshold");
        BaseLODModel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseLODModel");
        SilhouetteImportance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SilhouetteImportance");
        TextureImportance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextureImportance");
        ShadingImportance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShadingImportance");
        bRecalculateNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecalculateNormals");
        bRecalculateNormals_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bRecalculateNormals");
        bGenerateUniqueLightmapUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateUniqueLightmapUVs");
        bGenerateUniqueLightmapUVs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGenerateUniqueLightmapUVs");
        bKeepSymmetry_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bKeepSymmetry");
        bKeepSymmetry_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bKeepSymmetry");
        bVisibilityAided_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bVisibilityAided");
        bVisibilityAided_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bVisibilityAided");
        bCullOccluded_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCullOccluded");
        bCullOccluded_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCullOccluded");
        TerminationCriterion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TerminationCriterion");
        VisibilityAggressiveness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VisibilityAggressiveness");
        VertexColorImportance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VertexColorImportance");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MeshReductionSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            PercentTriangles = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PercentTriangles_Offset), 0, null);
            PercentVertices = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PercentVertices_Offset), 0, null);
            MaxDeviation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxDeviation_Offset), 0, null);
            PixelError = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PixelError_Offset), 0, null);
            WeldingThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WeldingThreshold_Offset), 0, null);
            HardAngleThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HardAngleThreshold_Offset), 0, null);
            BaseLODModel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BaseLODModel_Offset), 0, null);
            SilhouetteImportance = BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.FromNative(IntPtr.Add(InNativeStruct, SilhouetteImportance_Offset), 0, null);
            TextureImportance = BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.FromNative(IntPtr.Add(InNativeStruct, TextureImportance_Offset), 0, null);
            ShadingImportance = BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.FromNative(IntPtr.Add(InNativeStruct, ShadingImportance_Offset), 0, null);
            RecalculateNormals = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bRecalculateNormals_NativeProperty, bRecalculateNormals_Offset);
            GenerateUniqueLightmapUVs = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGenerateUniqueLightmapUVs_NativeProperty, bGenerateUniqueLightmapUVs_Offset);
            KeepSymmetry = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bKeepSymmetry_NativeProperty, bKeepSymmetry_Offset);
            VisibilityAided = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bVisibilityAided_NativeProperty, bVisibilityAided_Offset);
            CullOccluded = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCullOccluded_NativeProperty, bCullOccluded_Offset);
            TerminationCriterion = BlittableMarshaller<UnrealSharp.Engine.EStaticMeshReductionTerimationCriterion>.FromNative(IntPtr.Add(InNativeStruct, TerminationCriterion_Offset), 0, null);
            VisibilityAggressiveness = BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.FromNative(IntPtr.Add(InNativeStruct, VisibilityAggressiveness_Offset), 0, null);
            VertexColorImportance = BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.FromNative(IntPtr.Add(InNativeStruct, VertexColorImportance_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PercentTriangles_Offset), 0, null, PercentTriangles);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PercentVertices_Offset), 0, null, PercentVertices);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxDeviation_Offset), 0, null, MaxDeviation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PixelError_Offset), 0, null, PixelError);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WeldingThreshold_Offset), 0, null, WeldingThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HardAngleThreshold_Offset), 0, null, HardAngleThreshold);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BaseLODModel_Offset), 0, null, BaseLODModel);
            BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.ToNative(IntPtr.Add(Buffer, SilhouetteImportance_Offset), 0, null, SilhouetteImportance);
            BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.ToNative(IntPtr.Add(Buffer, TextureImportance_Offset), 0, null, TextureImportance);
            BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.ToNative(IntPtr.Add(Buffer, ShadingImportance_Offset), 0, null, ShadingImportance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bRecalculateNormals_NativeProperty, bRecalculateNormals_Offset, RecalculateNormals);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGenerateUniqueLightmapUVs_NativeProperty, bGenerateUniqueLightmapUVs_Offset, GenerateUniqueLightmapUVs);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bKeepSymmetry_NativeProperty, bKeepSymmetry_Offset, KeepSymmetry);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bVisibilityAided_NativeProperty, bVisibilityAided_Offset, VisibilityAided);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCullOccluded_NativeProperty, bCullOccluded_Offset, CullOccluded);
            BlittableMarshaller<UnrealSharp.Engine.EStaticMeshReductionTerimationCriterion>.ToNative(IntPtr.Add(Buffer, TerminationCriterion_Offset), 0, null, TerminationCriterion);
            BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.ToNative(IntPtr.Add(Buffer, VisibilityAggressiveness_Offset), 0, null, VisibilityAggressiveness);
            BlittableMarshaller<UnrealSharp.Engine.EMeshFeatureImportance>.ToNative(IntPtr.Add(Buffer, VertexColorImportance_Offset), 0, null, VertexColorImportance);
        }
    }
}

public static class MeshReductionSettingsMarshaler
{
    public static MeshReductionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MeshReductionSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MeshReductionSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MeshReductionSettings.NativeDataSize;
    }
}