using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_CopyPoseFromMesh
{
    // WeakObjectProperty /Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:SourceMeshComponent
    static readonly int SourceMeshComponent_Offset;
    public WeakObject<UnrealSharp.Engine.SkeletalMeshComponent> SourceMeshComponent;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:bUseAttachedParent
    static readonly int bUseAttachedParent_Offset;
    static readonly IntPtr bUseAttachedParent_NativeProperty;
    public bool UseAttachedParent;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:bCopyCurves
    static readonly int bCopyCurves_Offset;
    static readonly IntPtr bCopyCurves_NativeProperty;
    public bool CopyCurves;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:bCopyCustomAttributes
    static readonly int bCopyCustomAttributes_Offset;
    public bool CopyCustomAttributes;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:bUseMeshPose
    static readonly int bUseMeshPose_Offset;
    static readonly IntPtr bUseMeshPose_NativeProperty;
    public bool UseMeshPose;
    
    // NameProperty /Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh:RootBoneToCopy
    static readonly int RootBoneToCopy_Offset;
    public Name RootBoneToCopy;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_CopyPoseFromMesh()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_CopyPoseFromMesh");
        
        SourceMeshComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceMeshComponent");
        bUseAttachedParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseAttachedParent");
        bUseAttachedParent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseAttachedParent");
        bCopyCurves_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyCurves");
        bCopyCurves_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCopyCurves");
        bCopyCustomAttributes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyCustomAttributes");
        bUseMeshPose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseMeshPose");
        bUseMeshPose_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseMeshPose");
        RootBoneToCopy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootBoneToCopy");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_CopyPoseFromMesh(IntPtr InNativeStruct)
    {
        unsafe
        {
            SourceMeshComponent = BlittableMarshaller<WeakObject<UnrealSharp.Engine.SkeletalMeshComponent>>.FromNative(IntPtr.Add(InNativeStruct, SourceMeshComponent_Offset), 0, null);
            UseAttachedParent = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseAttachedParent_NativeProperty, bUseAttachedParent_Offset);
            CopyCurves = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCopyCurves_NativeProperty, bCopyCurves_Offset);
            CopyCustomAttributes = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCopyCustomAttributes_Offset), 0, null);
            UseMeshPose = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseMeshPose_NativeProperty, bUseMeshPose_Offset);
            RootBoneToCopy = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, RootBoneToCopy_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<WeakObject<UnrealSharp.Engine.SkeletalMeshComponent>>.ToNative(IntPtr.Add(Buffer, SourceMeshComponent_Offset), 0, null, SourceMeshComponent);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseAttachedParent_NativeProperty, bUseAttachedParent_Offset, UseAttachedParent);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCopyCurves_NativeProperty, bCopyCurves_Offset, CopyCurves);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCopyCustomAttributes_Offset), 0, null, CopyCustomAttributes);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseMeshPose_NativeProperty, bUseMeshPose_Offset, UseMeshPose);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, RootBoneToCopy_Offset), 0, null, RootBoneToCopy);
        }
    }
}

public static class AnimNode_CopyPoseFromMeshMarshaler
{
    public static AnimNode_CopyPoseFromMesh FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_CopyPoseFromMesh(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_CopyPoseFromMesh obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_CopyPoseFromMesh.NativeDataSize;
    }
}