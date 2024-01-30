using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct AnimNode_RetargetPoseFromMesh
{
    // WeakObjectProperty /Script/IKRig.AnimNode_RetargetPoseFromMesh:SourceMeshComponent
    static readonly int SourceMeshComponent_Offset;
    public WeakObject<UnrealSharp.Engine.SkeletalMeshComponent> SourceMeshComponent;
    
    // BoolProperty /Script/IKRig.AnimNode_RetargetPoseFromMesh:bUseAttachedParent
    static readonly int bUseAttachedParent_Offset;
    public bool UseAttachedParent;
    
    // ObjectProperty /Script/IKRig.AnimNode_RetargetPoseFromMesh:IKRetargeterAsset
    static readonly int IKRetargeterAsset_Offset;
    public UnrealSharp.IKRig.IKRetargeter IKRetargeterAsset;
    
    // StructProperty /Script/IKRig.AnimNode_RetargetPoseFromMesh:CustomRetargetProfile
    static readonly int CustomRetargetProfile_Offset;
    public UnrealSharp.IKRig.RetargetProfile CustomRetargetProfile;
    
    // BoolProperty /Script/IKRig.AnimNode_RetargetPoseFromMesh:bSuppressWarnings
    static readonly int bSuppressWarnings_Offset;
    public bool SuppressWarnings;
    
    // BoolProperty /Script/IKRig.AnimNode_RetargetPoseFromMesh:bCopyCurves
    static readonly int bCopyCurves_Offset;
    public bool CopyCurves;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_RetargetPoseFromMesh()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_RetargetPoseFromMesh");
        
        SourceMeshComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceMeshComponent");
        bUseAttachedParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseAttachedParent");
        IKRetargeterAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IKRetargeterAsset");
        CustomRetargetProfile_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomRetargetProfile");
        bSuppressWarnings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSuppressWarnings");
        bCopyCurves_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyCurves");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_RetargetPoseFromMesh(IntPtr InNativeStruct)
    {
        unsafe
        {
            SourceMeshComponent = BlittableMarshaller<WeakObject<UnrealSharp.Engine.SkeletalMeshComponent>>.FromNative(IntPtr.Add(InNativeStruct, SourceMeshComponent_Offset), 0, null);
            UseAttachedParent = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseAttachedParent_Offset), 0, null);
            IKRetargeterAsset = ObjectMarshaller<UnrealSharp.IKRig.IKRetargeter>.FromNative(IntPtr.Add(InNativeStruct, IKRetargeterAsset_Offset), 0, null);
            CustomRetargetProfile = UnrealSharp.IKRig.RetargetProfileMarshaler.FromNative(IntPtr.Add(InNativeStruct, CustomRetargetProfile_Offset), 0, null);
            SuppressWarnings = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSuppressWarnings_Offset), 0, null);
            CopyCurves = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCopyCurves_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<WeakObject<UnrealSharp.Engine.SkeletalMeshComponent>>.ToNative(IntPtr.Add(Buffer, SourceMeshComponent_Offset), 0, null, SourceMeshComponent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseAttachedParent_Offset), 0, null, UseAttachedParent);
            ObjectMarshaller<UnrealSharp.IKRig.IKRetargeter>.ToNative(IntPtr.Add(Buffer, IKRetargeterAsset_Offset), 0, null, IKRetargeterAsset);
            UnrealSharp.IKRig.RetargetProfileMarshaler.ToNative(IntPtr.Add(Buffer, CustomRetargetProfile_Offset), 0, null, CustomRetargetProfile);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSuppressWarnings_Offset), 0, null, SuppressWarnings);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCopyCurves_Offset), 0, null, CopyCurves);
        }
    }
}

public static class AnimNode_RetargetPoseFromMeshMarshaler
{
    public static AnimNode_RetargetPoseFromMesh FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_RetargetPoseFromMesh(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_RetargetPoseFromMesh obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_RetargetPoseFromMesh.NativeDataSize;
    }
}