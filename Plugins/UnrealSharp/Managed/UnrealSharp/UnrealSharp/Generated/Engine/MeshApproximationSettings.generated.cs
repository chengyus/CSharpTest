using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MeshApproximationSettings
{
    // EnumProperty /Script/Engine.MeshApproximationSettings:OutputType
    static readonly int OutputType_Offset;
    public UnrealSharp.Engine.EMeshApproximationType OutputType;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:ApproximationAccuracy
    static readonly int ApproximationAccuracy_Offset;
    public float ApproximationAccuracy;
    
    // IntProperty /Script/Engine.MeshApproximationSettings:ClampVoxelDimension
    static readonly int ClampVoxelDimension_Offset;
    public int ClampVoxelDimension;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bAttemptAutoThickening
    static readonly int bAttemptAutoThickening_Offset;
    public bool AttemptAutoThickening;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:TargetMinThicknessMultiplier
    static readonly int TargetMinThicknessMultiplier_Offset;
    public float TargetMinThicknessMultiplier;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bIgnoreTinyParts
    static readonly int bIgnoreTinyParts_Offset;
    public bool IgnoreTinyParts;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:TinyPartSizeMultiplier
    static readonly int TinyPartSizeMultiplier_Offset;
    public float TinyPartSizeMultiplier;
    
    // EnumProperty /Script/Engine.MeshApproximationSettings:BaseCapping
    static readonly int BaseCapping_Offset;
    public UnrealSharp.Engine.EMeshApproximationBaseCappingType BaseCapping;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:WindingThreshold
    static readonly int WindingThreshold_Offset;
    public float WindingThreshold;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bFillGaps
    static readonly int bFillGaps_Offset;
    public bool FillGaps;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:GapDistance
    static readonly int GapDistance_Offset;
    public float GapDistance;
    
    // EnumProperty /Script/Engine.MeshApproximationSettings:OcclusionMethod
    static readonly int OcclusionMethod_Offset;
    public UnrealSharp.Engine.EOccludedGeometryFilteringPolicy OcclusionMethod;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bOccludeFromBottom
    static readonly int bOccludeFromBottom_Offset;
    public bool OccludeFromBottom;
    
    // EnumProperty /Script/Engine.MeshApproximationSettings:SimplifyMethod
    static readonly int SimplifyMethod_Offset;
    public UnrealSharp.Engine.EMeshApproximationSimplificationPolicy SimplifyMethod;
    
    // IntProperty /Script/Engine.MeshApproximationSettings:TargetTriCount
    static readonly int TargetTriCount_Offset;
    public int TargetTriCount;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:TrianglesPerM
    static readonly int TrianglesPerM_Offset;
    public float TrianglesPerM;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:GeometricDeviation
    static readonly int GeometricDeviation_Offset;
    public float GeometricDeviation;
    
    // EnumProperty /Script/Engine.MeshApproximationSettings:GroundClipping
    static readonly int GroundClipping_Offset;
    public UnrealSharp.Engine.EMeshApproximationGroundPlaneClippingPolicy GroundClipping;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:GroundClippingZHeight
    static readonly int GroundClippingZHeight_Offset;
    public float GroundClippingZHeight;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bEstimateHardNormals
    static readonly int bEstimateHardNormals_Offset;
    public bool EstimateHardNormals;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:HardNormalAngle
    static readonly int HardNormalAngle_Offset;
    public float HardNormalAngle;
    
    // EnumProperty /Script/Engine.MeshApproximationSettings:UVGenerationMethod
    static readonly int UVGenerationMethod_Offset;
    public UnrealSharp.Engine.EMeshApproximationUVGenerationPolicy UVGenerationMethod;
    
    // IntProperty /Script/Engine.MeshApproximationSettings:InitialPatchCount
    static readonly int InitialPatchCount_Offset;
    public int InitialPatchCount;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:CurvatureAlignment
    static readonly int CurvatureAlignment_Offset;
    public float CurvatureAlignment;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:MergingThreshold
    static readonly int MergingThreshold_Offset;
    public float MergingThreshold;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:MaxAngleDeviation
    static readonly int MaxAngleDeviation_Offset;
    public float MaxAngleDeviation;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bGenerateNaniteEnabledMesh
    static readonly int bGenerateNaniteEnabledMesh_Offset;
    public bool GenerateNaniteEnabledMesh;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:NaniteProxyTrianglePercent
    static readonly int NaniteProxyTrianglePercent_Offset;
    public float NaniteProxyTrianglePercent;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bSupportRayTracing
    static readonly int bSupportRayTracing_Offset;
    public bool SupportRayTracing;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bAllowDistanceField
    static readonly int bAllowDistanceField_Offset;
    public bool AllowDistanceField;
    
    // IntProperty /Script/Engine.MeshApproximationSettings:MultiSamplingAA
    static readonly int MultiSamplingAA_Offset;
    public int MultiSamplingAA;
    
    // IntProperty /Script/Engine.MeshApproximationSettings:RenderCaptureResolution
    static readonly int RenderCaptureResolution_Offset;
    public int RenderCaptureResolution;
    
    // StructProperty /Script/Engine.MeshApproximationSettings:MaterialSettings
    static readonly int MaterialSettings_Offset;
    public UnrealSharp.Engine.MaterialProxySettings MaterialSettings;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:CaptureFieldOfView
    static readonly int CaptureFieldOfView_Offset;
    public float CaptureFieldOfView;
    
    // FloatProperty /Script/Engine.MeshApproximationSettings:NearPlaneDist
    static readonly int NearPlaneDist_Offset;
    public float NearPlaneDist;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bUseRenderLODMeshes
    static readonly int bUseRenderLODMeshes_Offset;
    public bool UseRenderLODMeshes;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bEnableSimplifyPrePass
    static readonly int bEnableSimplifyPrePass_Offset;
    public bool EnableSimplifyPrePass;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bEnableParallelBaking
    static readonly int bEnableParallelBaking_Offset;
    public bool EnableParallelBaking;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bPrintDebugMessages
    static readonly int bPrintDebugMessages_Offset;
    public bool PrintDebugMessages;
    
    // BoolProperty /Script/Engine.MeshApproximationSettings:bEmitFullDebugMesh
    static readonly int bEmitFullDebugMesh_Offset;
    public bool EmitFullDebugMesh;
    
    
    public static readonly int NativeDataSize;
    static MeshApproximationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MeshApproximationSettings");
        
        OutputType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutputType");
        ApproximationAccuracy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ApproximationAccuracy");
        ClampVoxelDimension_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ClampVoxelDimension");
        bAttemptAutoThickening_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAttemptAutoThickening");
        TargetMinThicknessMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetMinThicknessMultiplier");
        bIgnoreTinyParts_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreTinyParts");
        TinyPartSizeMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TinyPartSizeMultiplier");
        BaseCapping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BaseCapping");
        WindingThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WindingThreshold");
        bFillGaps_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFillGaps");
        GapDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GapDistance");
        OcclusionMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionMethod");
        bOccludeFromBottom_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOccludeFromBottom");
        SimplifyMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SimplifyMethod");
        TargetTriCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetTriCount");
        TrianglesPerM_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TrianglesPerM");
        GeometricDeviation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GeometricDeviation");
        GroundClipping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GroundClipping");
        GroundClippingZHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GroundClippingZHeight");
        bEstimateHardNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEstimateHardNormals");
        HardNormalAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HardNormalAngle");
        UVGenerationMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UVGenerationMethod");
        InitialPatchCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialPatchCount");
        CurvatureAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurvatureAlignment");
        MergingThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MergingThreshold");
        MaxAngleDeviation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxAngleDeviation");
        bGenerateNaniteEnabledMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGenerateNaniteEnabledMesh");
        NaniteProxyTrianglePercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NaniteProxyTrianglePercent");
        bSupportRayTracing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSupportRayTracing");
        bAllowDistanceField_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowDistanceField");
        MultiSamplingAA_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MultiSamplingAA");
        RenderCaptureResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RenderCaptureResolution");
        MaterialSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaterialSettings");
        CaptureFieldOfView_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CaptureFieldOfView");
        NearPlaneDist_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NearPlaneDist");
        bUseRenderLODMeshes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseRenderLODMeshes");
        bEnableSimplifyPrePass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableSimplifyPrePass");
        bEnableParallelBaking_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableParallelBaking");
        bPrintDebugMessages_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPrintDebugMessages");
        bEmitFullDebugMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEmitFullDebugMesh");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MeshApproximationSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            OutputType = BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationType>.FromNative(IntPtr.Add(InNativeStruct, OutputType_Offset), 0, null);
            ApproximationAccuracy = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ApproximationAccuracy_Offset), 0, null);
            ClampVoxelDimension = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ClampVoxelDimension_Offset), 0, null);
            AttemptAutoThickening = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAttemptAutoThickening_Offset), 0, null);
            TargetMinThicknessMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetMinThicknessMultiplier_Offset), 0, null);
            IgnoreTinyParts = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIgnoreTinyParts_Offset), 0, null);
            TinyPartSizeMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TinyPartSizeMultiplier_Offset), 0, null);
            BaseCapping = BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationBaseCappingType>.FromNative(IntPtr.Add(InNativeStruct, BaseCapping_Offset), 0, null);
            WindingThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WindingThreshold_Offset), 0, null);
            FillGaps = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFillGaps_Offset), 0, null);
            GapDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GapDistance_Offset), 0, null);
            OcclusionMethod = BlittableMarshaller<UnrealSharp.Engine.EOccludedGeometryFilteringPolicy>.FromNative(IntPtr.Add(InNativeStruct, OcclusionMethod_Offset), 0, null);
            OccludeFromBottom = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOccludeFromBottom_Offset), 0, null);
            SimplifyMethod = BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationSimplificationPolicy>.FromNative(IntPtr.Add(InNativeStruct, SimplifyMethod_Offset), 0, null);
            TargetTriCount = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, TargetTriCount_Offset), 0, null);
            TrianglesPerM = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TrianglesPerM_Offset), 0, null);
            GeometricDeviation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GeometricDeviation_Offset), 0, null);
            GroundClipping = BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationGroundPlaneClippingPolicy>.FromNative(IntPtr.Add(InNativeStruct, GroundClipping_Offset), 0, null);
            GroundClippingZHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GroundClippingZHeight_Offset), 0, null);
            EstimateHardNormals = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEstimateHardNormals_Offset), 0, null);
            HardNormalAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HardNormalAngle_Offset), 0, null);
            UVGenerationMethod = BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationUVGenerationPolicy>.FromNative(IntPtr.Add(InNativeStruct, UVGenerationMethod_Offset), 0, null);
            InitialPatchCount = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, InitialPatchCount_Offset), 0, null);
            CurvatureAlignment = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CurvatureAlignment_Offset), 0, null);
            MergingThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MergingThreshold_Offset), 0, null);
            MaxAngleDeviation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxAngleDeviation_Offset), 0, null);
            GenerateNaniteEnabledMesh = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bGenerateNaniteEnabledMesh_Offset), 0, null);
            NaniteProxyTrianglePercent = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NaniteProxyTrianglePercent_Offset), 0, null);
            SupportRayTracing = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSupportRayTracing_Offset), 0, null);
            AllowDistanceField = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowDistanceField_Offset), 0, null);
            MultiSamplingAA = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MultiSamplingAA_Offset), 0, null);
            RenderCaptureResolution = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RenderCaptureResolution_Offset), 0, null);
            MaterialSettings = UnrealSharp.Engine.MaterialProxySettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, MaterialSettings_Offset), 0, null);
            CaptureFieldOfView = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CaptureFieldOfView_Offset), 0, null);
            NearPlaneDist = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NearPlaneDist_Offset), 0, null);
            UseRenderLODMeshes = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseRenderLODMeshes_Offset), 0, null);
            EnableSimplifyPrePass = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableSimplifyPrePass_Offset), 0, null);
            EnableParallelBaking = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableParallelBaking_Offset), 0, null);
            PrintDebugMessages = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPrintDebugMessages_Offset), 0, null);
            EmitFullDebugMesh = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEmitFullDebugMesh_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationType>.ToNative(IntPtr.Add(Buffer, OutputType_Offset), 0, null, OutputType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ApproximationAccuracy_Offset), 0, null, ApproximationAccuracy);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ClampVoxelDimension_Offset), 0, null, ClampVoxelDimension);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAttemptAutoThickening_Offset), 0, null, AttemptAutoThickening);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetMinThicknessMultiplier_Offset), 0, null, TargetMinThicknessMultiplier);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIgnoreTinyParts_Offset), 0, null, IgnoreTinyParts);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TinyPartSizeMultiplier_Offset), 0, null, TinyPartSizeMultiplier);
            BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationBaseCappingType>.ToNative(IntPtr.Add(Buffer, BaseCapping_Offset), 0, null, BaseCapping);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WindingThreshold_Offset), 0, null, WindingThreshold);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFillGaps_Offset), 0, null, FillGaps);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GapDistance_Offset), 0, null, GapDistance);
            BlittableMarshaller<UnrealSharp.Engine.EOccludedGeometryFilteringPolicy>.ToNative(IntPtr.Add(Buffer, OcclusionMethod_Offset), 0, null, OcclusionMethod);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOccludeFromBottom_Offset), 0, null, OccludeFromBottom);
            BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationSimplificationPolicy>.ToNative(IntPtr.Add(Buffer, SimplifyMethod_Offset), 0, null, SimplifyMethod);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, TargetTriCount_Offset), 0, null, TargetTriCount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TrianglesPerM_Offset), 0, null, TrianglesPerM);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GeometricDeviation_Offset), 0, null, GeometricDeviation);
            BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationGroundPlaneClippingPolicy>.ToNative(IntPtr.Add(Buffer, GroundClipping_Offset), 0, null, GroundClipping);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GroundClippingZHeight_Offset), 0, null, GroundClippingZHeight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEstimateHardNormals_Offset), 0, null, EstimateHardNormals);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HardNormalAngle_Offset), 0, null, HardNormalAngle);
            BlittableMarshaller<UnrealSharp.Engine.EMeshApproximationUVGenerationPolicy>.ToNative(IntPtr.Add(Buffer, UVGenerationMethod_Offset), 0, null, UVGenerationMethod);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, InitialPatchCount_Offset), 0, null, InitialPatchCount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CurvatureAlignment_Offset), 0, null, CurvatureAlignment);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MergingThreshold_Offset), 0, null, MergingThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxAngleDeviation_Offset), 0, null, MaxAngleDeviation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bGenerateNaniteEnabledMesh_Offset), 0, null, GenerateNaniteEnabledMesh);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NaniteProxyTrianglePercent_Offset), 0, null, NaniteProxyTrianglePercent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSupportRayTracing_Offset), 0, null, SupportRayTracing);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowDistanceField_Offset), 0, null, AllowDistanceField);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MultiSamplingAA_Offset), 0, null, MultiSamplingAA);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RenderCaptureResolution_Offset), 0, null, RenderCaptureResolution);
            UnrealSharp.Engine.MaterialProxySettingsMarshaler.ToNative(IntPtr.Add(Buffer, MaterialSettings_Offset), 0, null, MaterialSettings);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CaptureFieldOfView_Offset), 0, null, CaptureFieldOfView);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NearPlaneDist_Offset), 0, null, NearPlaneDist);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseRenderLODMeshes_Offset), 0, null, UseRenderLODMeshes);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableSimplifyPrePass_Offset), 0, null, EnableSimplifyPrePass);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableParallelBaking_Offset), 0, null, EnableParallelBaking);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPrintDebugMessages_Offset), 0, null, PrintDebugMessages);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEmitFullDebugMesh_Offset), 0, null, EmitFullDebugMesh);
        }
    }
}

public static class MeshApproximationSettingsMarshaler
{
    public static MeshApproximationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MeshApproximationSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MeshApproximationSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MeshApproximationSettings.NativeDataSize;
    }
}