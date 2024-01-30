// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PoseableMeshComponent : UnrealSharp.Engine.SkinnedMeshComponent
{
    
    static PoseableMeshComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PoseableMeshComponent");
        
        
        SetBoneTransformByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBoneTransformByName");
        SetBoneTransformByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBoneTransformByName_NativeFunction);
        SetBoneTransformByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneTransformByName_NativeFunction, "BoneName");
        SetBoneTransformByName_InTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneTransformByName_NativeFunction, "InTransform");
        SetBoneTransformByName_BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneTransformByName_NativeFunction, "BoneSpace");
        SetBoneScaleByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBoneScaleByName");
        SetBoneScaleByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBoneScaleByName_NativeFunction);
        SetBoneScaleByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneScaleByName_NativeFunction, "BoneName");
        SetBoneScaleByName_InScale3D_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneScaleByName_NativeFunction, "InScale3D");
        SetBoneScaleByName_BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneScaleByName_NativeFunction, "BoneSpace");
        SetBoneRotationByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBoneRotationByName");
        SetBoneRotationByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBoneRotationByName_NativeFunction);
        SetBoneRotationByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneRotationByName_NativeFunction, "BoneName");
        SetBoneRotationByName_InRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneRotationByName_NativeFunction, "InRotation");
        SetBoneRotationByName_BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneRotationByName_NativeFunction, "BoneSpace");
        SetBoneLocationByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBoneLocationByName");
        SetBoneLocationByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBoneLocationByName_NativeFunction);
        SetBoneLocationByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneLocationByName_NativeFunction, "BoneName");
        SetBoneLocationByName_InLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneLocationByName_NativeFunction, "InLocation");
        SetBoneLocationByName_BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBoneLocationByName_NativeFunction, "BoneSpace");
        ResetBoneTransformByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResetBoneTransformByName");
        ResetBoneTransformByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ResetBoneTransformByName_NativeFunction);
        ResetBoneTransformByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ResetBoneTransformByName_NativeFunction, "BoneName");
        GetBoneTransformByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetBoneTransformByName");
        GetBoneTransformByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetBoneTransformByName_NativeFunction);
        GetBoneTransformByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneTransformByName_NativeFunction, "BoneName");
        GetBoneTransformByName_BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneTransformByName_NativeFunction, "BoneSpace");
        GetBoneTransformByName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneTransformByName_NativeFunction, "ReturnValue");
        GetBoneScaleByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetBoneScaleByName");
        GetBoneScaleByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetBoneScaleByName_NativeFunction);
        GetBoneScaleByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneScaleByName_NativeFunction, "BoneName");
        GetBoneScaleByName_BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneScaleByName_NativeFunction, "BoneSpace");
        GetBoneScaleByName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneScaleByName_NativeFunction, "ReturnValue");
        GetBoneRotationByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetBoneRotationByName");
        GetBoneRotationByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetBoneRotationByName_NativeFunction);
        GetBoneRotationByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneRotationByName_NativeFunction, "BoneName");
        GetBoneRotationByName_BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneRotationByName_NativeFunction, "BoneSpace");
        GetBoneRotationByName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneRotationByName_NativeFunction, "ReturnValue");
        GetBoneLocationByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetBoneLocationByName");
        GetBoneLocationByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetBoneLocationByName_NativeFunction);
        GetBoneLocationByName_BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneLocationByName_NativeFunction, "BoneName");
        GetBoneLocationByName_BoneSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneLocationByName_NativeFunction, "BoneSpace");
        GetBoneLocationByName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBoneLocationByName_NativeFunction, "ReturnValue");
        CopyPoseFromSkeletalComponent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CopyPoseFromSkeletalComponent");
        CopyPoseFromSkeletalComponent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CopyPoseFromSkeletalComponent_NativeFunction);
        CopyPoseFromSkeletalComponent_InComponentToCopy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CopyPoseFromSkeletalComponent_NativeFunction, "InComponentToCopy");
        
        
    }
    
    protected PoseableMeshComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.PoseableMeshComponent:SetBoneTransformByName
    static readonly IntPtr SetBoneTransformByName_NativeFunction;
    static readonly int SetBoneTransformByName_ParamsSize;
    static readonly int SetBoneTransformByName_BoneName_Offset;
    static readonly int SetBoneTransformByName_InTransform_Offset;
    static readonly int SetBoneTransformByName_BoneSpace_Offset;
    
    public void SetBoneTransformByName(Name boneName, UnrealSharp.Transform inTransform, UnrealSharp.Engine.EBoneSpaces boneSpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBoneTransformByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneTransformByName_BoneName_Offset), 0, null, boneName);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneTransformByName_InTransform_Offset), 0, null, inTransform);
            BlittableMarshaller<UnrealSharp.Engine.EBoneSpaces>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneTransformByName_BoneSpace_Offset), 0, null, boneSpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBoneTransformByName_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:SetBoneScaleByName
    static readonly IntPtr SetBoneScaleByName_NativeFunction;
    static readonly int SetBoneScaleByName_ParamsSize;
    static readonly int SetBoneScaleByName_BoneName_Offset;
    static readonly int SetBoneScaleByName_InScale3D_Offset;
    static readonly int SetBoneScaleByName_BoneSpace_Offset;
    
    public void SetBoneScaleByName(Name boneName, System.DoubleNumerics.Vector3 inScale3D, UnrealSharp.Engine.EBoneSpaces boneSpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBoneScaleByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneScaleByName_BoneName_Offset), 0, null, boneName);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneScaleByName_InScale3D_Offset), 0, null, inScale3D);
            BlittableMarshaller<UnrealSharp.Engine.EBoneSpaces>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneScaleByName_BoneSpace_Offset), 0, null, boneSpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBoneScaleByName_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:SetBoneRotationByName
    static readonly IntPtr SetBoneRotationByName_NativeFunction;
    static readonly int SetBoneRotationByName_ParamsSize;
    static readonly int SetBoneRotationByName_BoneName_Offset;
    static readonly int SetBoneRotationByName_InRotation_Offset;
    static readonly int SetBoneRotationByName_BoneSpace_Offset;
    
    public void SetBoneRotationByName(Name boneName, UnrealSharp.Rotator inRotation, UnrealSharp.Engine.EBoneSpaces boneSpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBoneRotationByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneRotationByName_BoneName_Offset), 0, null, boneName);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneRotationByName_InRotation_Offset), 0, null, inRotation);
            BlittableMarshaller<UnrealSharp.Engine.EBoneSpaces>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneRotationByName_BoneSpace_Offset), 0, null, boneSpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBoneRotationByName_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:SetBoneLocationByName
    static readonly IntPtr SetBoneLocationByName_NativeFunction;
    static readonly int SetBoneLocationByName_ParamsSize;
    static readonly int SetBoneLocationByName_BoneName_Offset;
    static readonly int SetBoneLocationByName_InLocation_Offset;
    static readonly int SetBoneLocationByName_BoneSpace_Offset;
    
    public void SetBoneLocationByName(Name boneName, System.DoubleNumerics.Vector3 inLocation, UnrealSharp.Engine.EBoneSpaces boneSpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBoneLocationByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneLocationByName_BoneName_Offset), 0, null, boneName);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneLocationByName_InLocation_Offset), 0, null, inLocation);
            BlittableMarshaller<UnrealSharp.Engine.EBoneSpaces>.ToNative(IntPtr.Add(ParamsBuffer, SetBoneLocationByName_BoneSpace_Offset), 0, null, boneSpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBoneLocationByName_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:ResetBoneTransformByName
    static readonly IntPtr ResetBoneTransformByName_NativeFunction;
    static readonly int ResetBoneTransformByName_ParamsSize;
    static readonly int ResetBoneTransformByName_BoneName_Offset;
    
    public void ResetBoneTransformByName(Name boneName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ResetBoneTransformByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, ResetBoneTransformByName_BoneName_Offset), 0, null, boneName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ResetBoneTransformByName_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:GetBoneTransformByName
    static readonly IntPtr GetBoneTransformByName_NativeFunction;
    static readonly int GetBoneTransformByName_ParamsSize;
    static readonly int GetBoneTransformByName_BoneName_Offset;
    static readonly int GetBoneTransformByName_BoneSpace_Offset;
    static readonly int GetBoneTransformByName_ReturnValue_Offset;
    
    public UnrealSharp.Transform GetBoneTransformByName(Name boneName, UnrealSharp.Engine.EBoneSpaces boneSpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetBoneTransformByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetBoneTransformByName_BoneName_Offset), 0, null, boneName);
            BlittableMarshaller<UnrealSharp.Engine.EBoneSpaces>.ToNative(IntPtr.Add(ParamsBuffer, GetBoneTransformByName_BoneSpace_Offset), 0, null, boneSpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetBoneTransformByName_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Transform returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(ParamsBuffer, GetBoneTransformByName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:GetBoneScaleByName
    static readonly IntPtr GetBoneScaleByName_NativeFunction;
    static readonly int GetBoneScaleByName_ParamsSize;
    static readonly int GetBoneScaleByName_BoneName_Offset;
    static readonly int GetBoneScaleByName_BoneSpace_Offset;
    static readonly int GetBoneScaleByName_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector3 GetBoneScaleByName(Name boneName, UnrealSharp.Engine.EBoneSpaces boneSpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetBoneScaleByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetBoneScaleByName_BoneName_Offset), 0, null, boneName);
            BlittableMarshaller<UnrealSharp.Engine.EBoneSpaces>.ToNative(IntPtr.Add(ParamsBuffer, GetBoneScaleByName_BoneSpace_Offset), 0, null, boneSpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetBoneScaleByName_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector3 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, GetBoneScaleByName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:GetBoneRotationByName
    static readonly IntPtr GetBoneRotationByName_NativeFunction;
    static readonly int GetBoneRotationByName_ParamsSize;
    static readonly int GetBoneRotationByName_BoneName_Offset;
    static readonly int GetBoneRotationByName_BoneSpace_Offset;
    static readonly int GetBoneRotationByName_ReturnValue_Offset;
    
    public UnrealSharp.Rotator GetBoneRotationByName(Name boneName, UnrealSharp.Engine.EBoneSpaces boneSpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetBoneRotationByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetBoneRotationByName_BoneName_Offset), 0, null, boneName);
            BlittableMarshaller<UnrealSharp.Engine.EBoneSpaces>.ToNative(IntPtr.Add(ParamsBuffer, GetBoneRotationByName_BoneSpace_Offset), 0, null, boneSpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetBoneRotationByName_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Rotator returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(ParamsBuffer, GetBoneRotationByName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:GetBoneLocationByName
    static readonly IntPtr GetBoneLocationByName_NativeFunction;
    static readonly int GetBoneLocationByName_ParamsSize;
    static readonly int GetBoneLocationByName_BoneName_Offset;
    static readonly int GetBoneLocationByName_BoneSpace_Offset;
    static readonly int GetBoneLocationByName_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector3 GetBoneLocationByName(Name boneName, UnrealSharp.Engine.EBoneSpaces boneSpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetBoneLocationByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetBoneLocationByName_BoneName_Offset), 0, null, boneName);
            BlittableMarshaller<UnrealSharp.Engine.EBoneSpaces>.ToNative(IntPtr.Add(ParamsBuffer, GetBoneLocationByName_BoneSpace_Offset), 0, null, boneSpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetBoneLocationByName_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector3 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, GetBoneLocationByName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PoseableMeshComponent:CopyPoseFromSkeletalComponent
    static readonly IntPtr CopyPoseFromSkeletalComponent_NativeFunction;
    static readonly int CopyPoseFromSkeletalComponent_ParamsSize;
    static readonly int CopyPoseFromSkeletalComponent_InComponentToCopy_Offset;
    
    public void CopyPoseFromSkeletalComponent(UnrealSharp.Engine.SkeletalMeshComponent inComponentToCopy)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CopyPoseFromSkeletalComponent_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.SkeletalMeshComponent>.ToNative(IntPtr.Add(ParamsBuffer, CopyPoseFromSkeletalComponent_InComponentToCopy_Offset), 0, null, inComponentToCopy);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, CopyPoseFromSkeletalComponent_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}