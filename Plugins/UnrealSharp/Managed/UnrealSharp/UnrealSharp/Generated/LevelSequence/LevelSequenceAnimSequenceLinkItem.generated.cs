using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LevelSequence;

[UStruct]
public partial struct LevelSequenceAnimSequenceLinkItem
{
    // StructProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:SkelTrackGuid
    static readonly int SkelTrackGuid_Offset;
    public UnrealSharp.CoreUObject.Guid SkelTrackGuid;
    
    // StructProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:PathToAnimSequence
    static readonly int PathToAnimSequence_Offset;
    public UnrealSharp.CoreUObject.SoftObjectPath PathToAnimSequence;
    
    // BoolProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:bExportTransforms
    static readonly int bExportTransforms_Offset;
    public bool ExportTransforms;
    
    // BoolProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:bExportMorphTargets
    static readonly int bExportMorphTargets_Offset;
    public bool ExportMorphTargets;
    
    // BoolProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:bExportAttributeCurves
    static readonly int bExportAttributeCurves_Offset;
    public bool ExportAttributeCurves;
    
    // BoolProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:bExportMaterialCurves
    static readonly int bExportMaterialCurves_Offset;
    public bool ExportMaterialCurves;
    
    // EnumProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:Interpolation
    static readonly int Interpolation_Offset;
    public UnrealSharp.Engine.EAnimInterpolationType Interpolation;
    
    // ByteProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:CurveInterpolation
    static readonly int CurveInterpolation_Offset;
    public UnrealSharp.Engine.ERichCurveInterpMode CurveInterpolation;
    
    // BoolProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:bRecordInWorldSpace
    static readonly int bRecordInWorldSpace_Offset;
    public bool RecordInWorldSpace;
    
    // BoolProperty /Script/LevelSequence.LevelSequenceAnimSequenceLinkItem:bEvaluateAllSkeletalMeshComponents
    static readonly int bEvaluateAllSkeletalMeshComponents_Offset;
    public bool EvaluateAllSkeletalMeshComponents;
    
    
    public static readonly int NativeDataSize;
    static LevelSequenceAnimSequenceLinkItem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LevelSequenceAnimSequenceLinkItem");
        
        SkelTrackGuid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SkelTrackGuid");
        PathToAnimSequence_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathToAnimSequence");
        bExportTransforms_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportTransforms");
        bExportMorphTargets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportMorphTargets");
        bExportAttributeCurves_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportAttributeCurves");
        bExportMaterialCurves_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExportMaterialCurves");
        Interpolation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Interpolation");
        CurveInterpolation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveInterpolation");
        bRecordInWorldSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecordInWorldSpace");
        bEvaluateAllSkeletalMeshComponents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEvaluateAllSkeletalMeshComponents");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LevelSequenceAnimSequenceLinkItem(IntPtr InNativeStruct)
    {
        unsafe
        {
            SkelTrackGuid = UnrealSharp.CoreUObject.GuidMarshaler.FromNative(IntPtr.Add(InNativeStruct, SkelTrackGuid_Offset), 0, null);
            PathToAnimSequence = UnrealSharp.CoreUObject.SoftObjectPathMarshaler.FromNative(IntPtr.Add(InNativeStruct, PathToAnimSequence_Offset), 0, null);
            ExportTransforms = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bExportTransforms_Offset), 0, null);
            ExportMorphTargets = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bExportMorphTargets_Offset), 0, null);
            ExportAttributeCurves = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bExportAttributeCurves_Offset), 0, null);
            ExportMaterialCurves = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bExportMaterialCurves_Offset), 0, null);
            Interpolation = BlittableMarshaller<UnrealSharp.Engine.EAnimInterpolationType>.FromNative(IntPtr.Add(InNativeStruct, Interpolation_Offset), 0, null);
            CurveInterpolation = BlittableMarshaller<UnrealSharp.Engine.ERichCurveInterpMode>.FromNative(IntPtr.Add(InNativeStruct, CurveInterpolation_Offset), 0, null);
            RecordInWorldSpace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecordInWorldSpace_Offset), 0, null);
            EvaluateAllSkeletalMeshComponents = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEvaluateAllSkeletalMeshComponents_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.GuidMarshaler.ToNative(IntPtr.Add(Buffer, SkelTrackGuid_Offset), 0, null, SkelTrackGuid);
            UnrealSharp.CoreUObject.SoftObjectPathMarshaler.ToNative(IntPtr.Add(Buffer, PathToAnimSequence_Offset), 0, null, PathToAnimSequence);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bExportTransforms_Offset), 0, null, ExportTransforms);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bExportMorphTargets_Offset), 0, null, ExportMorphTargets);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bExportAttributeCurves_Offset), 0, null, ExportAttributeCurves);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bExportMaterialCurves_Offset), 0, null, ExportMaterialCurves);
            BlittableMarshaller<UnrealSharp.Engine.EAnimInterpolationType>.ToNative(IntPtr.Add(Buffer, Interpolation_Offset), 0, null, Interpolation);
            BlittableMarshaller<UnrealSharp.Engine.ERichCurveInterpMode>.ToNative(IntPtr.Add(Buffer, CurveInterpolation_Offset), 0, null, CurveInterpolation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecordInWorldSpace_Offset), 0, null, RecordInWorldSpace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEvaluateAllSkeletalMeshComponents_Offset), 0, null, EvaluateAllSkeletalMeshComponents);
        }
    }
}

public static class LevelSequenceAnimSequenceLinkItemMarshaler
{
    public static LevelSequenceAnimSequenceLinkItem FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LevelSequenceAnimSequenceLinkItem(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LevelSequenceAnimSequenceLinkItem obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LevelSequenceAnimSequenceLinkItem.NativeDataSize;
    }
}