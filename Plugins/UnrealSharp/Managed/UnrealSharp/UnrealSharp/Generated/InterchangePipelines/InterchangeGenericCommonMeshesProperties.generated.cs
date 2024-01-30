// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangePipelines;

[UClass]
public partial class InterchangeGenericCommonMeshesProperties : UnrealSharp.InterchangeCore.InterchangePipelineBase
{
    
    static InterchangeGenericCommonMeshesProperties()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeGenericCommonMeshesProperties");
        
        ForceAllMeshAsType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ForceAllMeshAsType");
        bImportLods_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bImportLods");
        bBakeMeshes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBakeMeshes");
        VertexColorImportOption_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VertexColorImportOption");
        VertexOverrideColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VertexOverrideColor");
        bRecomputeNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecomputeNormals");
        bRecomputeTangents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecomputeTangents");
        bUseMikkTSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseMikkTSpace");
        bComputeWeightedNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bComputeWeightedNormals");
        bUseHighPrecisionTangentBasis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseHighPrecisionTangentBasis");
        bUseFullPrecisionUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseFullPrecisionUVs");
        bUseBackwardsCompatibleF16TruncUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseBackwardsCompatibleF16TruncUVs");
        bRemoveDegenerates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRemoveDegenerates");
        
        
        
    }
    
    protected InterchangeGenericCommonMeshesProperties(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // EnumProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:ForceAllMeshAsType
    static readonly int ForceAllMeshAsType_Offset;
    
    public UnrealSharp.InterchangePipelines.EInterchangeForceMeshType ForceAllMeshAsType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.InterchangePipelines.EInterchangeForceMeshType>.FromNative(IntPtr.Add(NativeObject, ForceAllMeshAsType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.InterchangePipelines.EInterchangeForceMeshType>.ToNative(IntPtr.Add(NativeObject, ForceAllMeshAsType_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bImportLods
    static readonly int bImportLods_Offset;
    
    public bool bImportLods
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bImportLods_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bImportLods_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bBakeMeshes
    static readonly int bBakeMeshes_Offset;
    
    public bool bBakeMeshes
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bBakeMeshes_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bBakeMeshes_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:VertexColorImportOption
    static readonly int VertexColorImportOption_Offset;
    
    public UnrealSharp.InterchangePipelines.EInterchangeVertexColorImportOption VertexColorImportOption
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.InterchangePipelines.EInterchangeVertexColorImportOption>.FromNative(IntPtr.Add(NativeObject, VertexColorImportOption_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.InterchangePipelines.EInterchangeVertexColorImportOption>.ToNative(IntPtr.Add(NativeObject, VertexColorImportOption_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:VertexOverrideColor
    static readonly int VertexOverrideColor_Offset;
    
    public UnrealSharp.CoreUObject.Color VertexOverrideColor
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(NativeObject, VertexOverrideColor_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(NativeObject, VertexOverrideColor_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bRecomputeNormals
    static readonly int bRecomputeNormals_Offset;
    
    public bool bRecomputeNormals
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRecomputeNormals_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bRecomputeNormals_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bRecomputeTangents
    static readonly int bRecomputeTangents_Offset;
    
    public bool bRecomputeTangents
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRecomputeTangents_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bRecomputeTangents_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bUseMikkTSpace
    static readonly int bUseMikkTSpace_Offset;
    
    public bool bUseMikkTSpace
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseMikkTSpace_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseMikkTSpace_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bComputeWeightedNormals
    static readonly int bComputeWeightedNormals_Offset;
    
    public bool bComputeWeightedNormals
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bComputeWeightedNormals_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bComputeWeightedNormals_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bUseHighPrecisionTangentBasis
    static readonly int bUseHighPrecisionTangentBasis_Offset;
    
    public bool bUseHighPrecisionTangentBasis
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseHighPrecisionTangentBasis_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseHighPrecisionTangentBasis_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bUseFullPrecisionUVs
    static readonly int bUseFullPrecisionUVs_Offset;
    
    public bool bUseFullPrecisionUVs
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseFullPrecisionUVs_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseFullPrecisionUVs_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bUseBackwardsCompatibleF16TruncUVs
    static readonly int bUseBackwardsCompatibleF16TruncUVs_Offset;
    
    public bool bUseBackwardsCompatibleF16TruncUVs
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseBackwardsCompatibleF16TruncUVs_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseBackwardsCompatibleF16TruncUVs_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/InterchangePipelines.InterchangeGenericCommonMeshesProperties:bRemoveDegenerates
    static readonly int bRemoveDegenerates_Offset;
    
    public bool bRemoveDegenerates
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRemoveDegenerates_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bRemoveDegenerates_Offset), 0, this, value);
        }
    }
    
    
}