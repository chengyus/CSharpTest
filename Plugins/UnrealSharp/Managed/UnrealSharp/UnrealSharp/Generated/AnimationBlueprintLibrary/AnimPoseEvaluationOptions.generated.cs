using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationBlueprintLibrary;

[UStruct]
public partial struct AnimPoseEvaluationOptions
{
    // EnumProperty /Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:EvaluationType
    static readonly int EvaluationType_Offset;
    public UnrealSharp.AnimationBlueprintLibrary.EAnimDataEvalType EvaluationType;
    
    // BoolProperty /Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:bShouldRetarget
    static readonly int bShouldRetarget_Offset;
    public bool ShouldRetarget;
    
    // BoolProperty /Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:bExtractRootMotion
    static readonly int bExtractRootMotion_Offset;
    public bool ExtractRootMotion;
    
    // BoolProperty /Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:bIncorporateRootMotionIntoPose
    static readonly int bIncorporateRootMotionIntoPose_Offset;
    public bool IncorporateRootMotionIntoPose;
    
    // ObjectProperty /Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:OptionalSkeletalMesh
    static readonly int OptionalSkeletalMesh_Offset;
    public UnrealSharp.Engine.SkeletalMesh OptionalSkeletalMesh;
    
    // BoolProperty /Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:bRetrieveAdditiveAsFullPose
    static readonly int bRetrieveAdditiveAsFullPose_Offset;
    public bool RetrieveAdditiveAsFullPose;
    
    // BoolProperty /Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:bEvaluateCurves
    static readonly int bEvaluateCurves_Offset;
    public bool EvaluateCurves;
    
    
    public static readonly int NativeDataSize;
    static AnimPoseEvaluationOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimPoseEvaluationOptions");
        
        EvaluationType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EvaluationType");
        bShouldRetarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShouldRetarget");
        bExtractRootMotion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bExtractRootMotion");
        bIncorporateRootMotionIntoPose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncorporateRootMotionIntoPose");
        OptionalSkeletalMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OptionalSkeletalMesh");
        bRetrieveAdditiveAsFullPose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRetrieveAdditiveAsFullPose");
        bEvaluateCurves_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEvaluateCurves");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimPoseEvaluationOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            EvaluationType = BlittableMarshaller<UnrealSharp.AnimationBlueprintLibrary.EAnimDataEvalType>.FromNative(IntPtr.Add(InNativeStruct, EvaluationType_Offset), 0, null);
            ShouldRetarget = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShouldRetarget_Offset), 0, null);
            ExtractRootMotion = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bExtractRootMotion_Offset), 0, null);
            IncorporateRootMotionIntoPose = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncorporateRootMotionIntoPose_Offset), 0, null);
            OptionalSkeletalMesh = ObjectMarshaller<UnrealSharp.Engine.SkeletalMesh>.FromNative(IntPtr.Add(InNativeStruct, OptionalSkeletalMesh_Offset), 0, null);
            RetrieveAdditiveAsFullPose = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRetrieveAdditiveAsFullPose_Offset), 0, null);
            EvaluateCurves = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEvaluateCurves_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AnimationBlueprintLibrary.EAnimDataEvalType>.ToNative(IntPtr.Add(Buffer, EvaluationType_Offset), 0, null, EvaluationType);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShouldRetarget_Offset), 0, null, ShouldRetarget);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bExtractRootMotion_Offset), 0, null, ExtractRootMotion);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncorporateRootMotionIntoPose_Offset), 0, null, IncorporateRootMotionIntoPose);
            ObjectMarshaller<UnrealSharp.Engine.SkeletalMesh>.ToNative(IntPtr.Add(Buffer, OptionalSkeletalMesh_Offset), 0, null, OptionalSkeletalMesh);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRetrieveAdditiveAsFullPose_Offset), 0, null, RetrieveAdditiveAsFullPose);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEvaluateCurves_Offset), 0, null, EvaluateCurves);
        }
    }
}

public static class AnimPoseEvaluationOptionsMarshaler
{
    public static AnimPoseEvaluationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimPoseEvaluationOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimPoseEvaluationOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimPoseEvaluationOptions.NativeDataSize;
    }
}