// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class CameraComponent : UnrealSharp.Engine.SceneComponent
{
    
    static CameraComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CameraComponent");
        
        FieldOfView_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FieldOfView");
        OrthoWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OrthoWidth");
        OrthoNearClipPlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OrthoNearClipPlane");
        OrthoFarClipPlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OrthoFarClipPlane");
        AspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AspectRatio");
        AspectRatioAxisConstraint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AspectRatioAxisConstraint");
        bConstrainAspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bConstrainAspectRatio");
        bConstrainAspectRatio_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bConstrainAspectRatio");
        bOverrideAspectRatioAxisConstraint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideAspectRatioAxisConstraint");
        bOverrideAspectRatioAxisConstraint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverrideAspectRatioAxisConstraint");
        bUseFieldOfViewForLOD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseFieldOfViewForLOD");
        bUseFieldOfViewForLOD_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseFieldOfViewForLOD");
        bDrawFrustumAllowed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawFrustumAllowed");
        bCameraMeshHiddenInGame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCameraMeshHiddenInGame");
        bCameraMeshHiddenInGame_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCameraMeshHiddenInGame");
        bLockToHmd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLockToHmd");
        bLockToHmd_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLockToHmd");
        bUsePawnControlRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUsePawnControlRotation");
        bUsePawnControlRotation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUsePawnControlRotation");
        ProjectionMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProjectionMode");
        CameraMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CameraMesh");
        PostProcessBlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PostProcessBlendWeight");
        PostProcessSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PostProcessSettings");
        
        SetUseFieldOfViewForLOD_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetUseFieldOfViewForLOD");
        SetUseFieldOfViewForLOD_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetUseFieldOfViewForLOD_NativeFunction);
        SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetUseFieldOfViewForLOD_NativeFunction, "bInUseFieldOfViewForLOD");
        SetProjectionMode_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetProjectionMode");
        SetProjectionMode_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetProjectionMode_NativeFunction);
        SetProjectionMode_InProjectionMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetProjectionMode_NativeFunction, "InProjectionMode");
        SetPostProcessBlendWeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPostProcessBlendWeight");
        SetPostProcessBlendWeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPostProcessBlendWeight_NativeFunction);
        SetPostProcessBlendWeight_InPostProcessBlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPostProcessBlendWeight_NativeFunction, "InPostProcessBlendWeight");
        SetOrthoWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOrthoWidth");
        SetOrthoWidth_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOrthoWidth_NativeFunction);
        SetOrthoWidth_InOrthoWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOrthoWidth_NativeFunction, "InOrthoWidth");
        SetOrthoNearClipPlane_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOrthoNearClipPlane");
        SetOrthoNearClipPlane_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOrthoNearClipPlane_NativeFunction);
        SetOrthoNearClipPlane_InOrthoNearClipPlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOrthoNearClipPlane_NativeFunction, "InOrthoNearClipPlane");
        SetOrthoFarClipPlane_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOrthoFarClipPlane");
        SetOrthoFarClipPlane_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOrthoFarClipPlane_NativeFunction);
        SetOrthoFarClipPlane_InOrthoFarClipPlane_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOrthoFarClipPlane_NativeFunction, "InOrthoFarClipPlane");
        SetFieldOfView_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFieldOfView");
        SetFieldOfView_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFieldOfView_NativeFunction);
        SetFieldOfView_InFieldOfView_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFieldOfView_NativeFunction, "InFieldOfView");
        SetConstraintAspectRatio_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetConstraintAspectRatio");
        SetConstraintAspectRatio_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetConstraintAspectRatio_NativeFunction);
        SetConstraintAspectRatio_bInConstrainAspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetConstraintAspectRatio_NativeFunction, "bInConstrainAspectRatio");
        SetAspectRatioAxisConstraint_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAspectRatioAxisConstraint");
        SetAspectRatioAxisConstraint_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAspectRatioAxisConstraint_NativeFunction);
        SetAspectRatioAxisConstraint_InAspectRatioAxisConstraint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAspectRatioAxisConstraint_NativeFunction, "InAspectRatioAxisConstraint");
        SetAspectRatio_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAspectRatio");
        SetAspectRatio_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAspectRatio_NativeFunction);
        SetAspectRatio_InAspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAspectRatio_NativeFunction, "InAspectRatio");
        GetCameraView_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCameraView");
        GetCameraView_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCameraView_NativeFunction);
        GetCameraView_DeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCameraView_NativeFunction, "DeltaTime");
        GetCameraView_DesiredView_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCameraView_NativeFunction, "DesiredView");
        
        
    }
    
    protected CameraComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/Engine.CameraComponent:FieldOfView
    static readonly int FieldOfView_Offset;
    
    public float FieldOfView
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FieldOfView_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, FieldOfView_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.CameraComponent:OrthoWidth
    static readonly int OrthoWidth_Offset;
    
    public float OrthoWidth
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, OrthoWidth_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, OrthoWidth_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.CameraComponent:OrthoNearClipPlane
    static readonly int OrthoNearClipPlane_Offset;
    
    public float OrthoNearClipPlane
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, OrthoNearClipPlane_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, OrthoNearClipPlane_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.CameraComponent:OrthoFarClipPlane
    static readonly int OrthoFarClipPlane_Offset;
    
    public float OrthoFarClipPlane
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, OrthoFarClipPlane_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, OrthoFarClipPlane_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.CameraComponent:AspectRatio
    static readonly int AspectRatio_Offset;
    
    public float AspectRatio
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, AspectRatio_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, AspectRatio_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/Engine.CameraComponent:AspectRatioAxisConstraint
    static readonly int AspectRatioAxisConstraint_Offset;
    
    public UnrealSharp.Engine.EAspectRatioAxisConstraint AspectRatioAxisConstraint
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.EAspectRatioAxisConstraint>.FromNative(IntPtr.Add(NativeObject, AspectRatioAxisConstraint_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.EAspectRatioAxisConstraint>.ToNative(IntPtr.Add(NativeObject, AspectRatioAxisConstraint_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.CameraComponent:bConstrainAspectRatio
    static readonly int bConstrainAspectRatio_Offset;
    static readonly IntPtr bConstrainAspectRatio_NativeProperty;
    
    public bool bConstrainAspectRatio
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bConstrainAspectRatio_NativeProperty, bConstrainAspectRatio_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bConstrainAspectRatio_NativeProperty, bConstrainAspectRatio_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.CameraComponent:bOverrideAspectRatioAxisConstraint
    static readonly int bOverrideAspectRatioAxisConstraint_Offset;
    static readonly IntPtr bOverrideAspectRatioAxisConstraint_NativeProperty;
    
    public bool bOverrideAspectRatioAxisConstraint
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bOverrideAspectRatioAxisConstraint_NativeProperty, bOverrideAspectRatioAxisConstraint_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bOverrideAspectRatioAxisConstraint_NativeProperty, bOverrideAspectRatioAxisConstraint_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.CameraComponent:bUseFieldOfViewForLOD
    static readonly int bUseFieldOfViewForLOD_Offset;
    static readonly IntPtr bUseFieldOfViewForLOD_NativeProperty;
    
    public bool bUseFieldOfViewForLOD
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bUseFieldOfViewForLOD_NativeProperty, bUseFieldOfViewForLOD_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bUseFieldOfViewForLOD_NativeProperty, bUseFieldOfViewForLOD_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.CameraComponent:bDrawFrustumAllowed
    static readonly int bDrawFrustumAllowed_Offset;
    
    public bool bDrawFrustumAllowed
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bDrawFrustumAllowed_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bDrawFrustumAllowed_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/Engine.CameraComponent:bCameraMeshHiddenInGame
    static readonly int bCameraMeshHiddenInGame_Offset;
    static readonly IntPtr bCameraMeshHiddenInGame_NativeProperty;
    
    public bool bCameraMeshHiddenInGame
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bCameraMeshHiddenInGame_NativeProperty, bCameraMeshHiddenInGame_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bCameraMeshHiddenInGame_NativeProperty, bCameraMeshHiddenInGame_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.CameraComponent:bLockToHmd
    static readonly int bLockToHmd_Offset;
    static readonly IntPtr bLockToHmd_NativeProperty;
    
    public bool bLockToHmd
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bLockToHmd_NativeProperty, bLockToHmd_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bLockToHmd_NativeProperty, bLockToHmd_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.CameraComponent:bUsePawnControlRotation
    static readonly int bUsePawnControlRotation_Offset;
    static readonly IntPtr bUsePawnControlRotation_NativeProperty;
    
    public bool bUsePawnControlRotation
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bUsePawnControlRotation_NativeProperty, bUsePawnControlRotation_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bUsePawnControlRotation_NativeProperty, bUsePawnControlRotation_Offset, value);
        }
    }
    
    // ByteProperty /Script/Engine.CameraComponent:ProjectionMode
    static readonly int ProjectionMode_Offset;
    
    public UnrealSharp.Engine.ECameraProjectionMode ProjectionMode
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.ECameraProjectionMode>.FromNative(IntPtr.Add(NativeObject, ProjectionMode_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.ECameraProjectionMode>.ToNative(IntPtr.Add(NativeObject, ProjectionMode_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/Engine.CameraComponent:CameraMesh
    static readonly int CameraMesh_Offset;
    
    public UnrealSharp.Engine.StaticMesh CameraMesh
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.FromNative(IntPtr.Add(NativeObject, CameraMesh_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.ToNative(IntPtr.Add(NativeObject, CameraMesh_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/Engine.CameraComponent:PostProcessBlendWeight
    static readonly int PostProcessBlendWeight_Offset;
    
    public float PostProcessBlendWeight
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, PostProcessBlendWeight_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, PostProcessBlendWeight_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/Engine.CameraComponent:PostProcessSettings
    static readonly int PostProcessSettings_Offset;
    
    public UnrealSharp.Engine.PostProcessSettings PostProcessSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.Engine.PostProcessSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, PostProcessSettings_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.Engine.PostProcessSettingsMarshaler.ToNative(IntPtr.Add(NativeObject, PostProcessSettings_Offset), 0, this, value);
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetUseFieldOfViewForLOD
    static readonly IntPtr SetUseFieldOfViewForLOD_NativeFunction;
    static readonly int SetUseFieldOfViewForLOD_ParamsSize;
    static readonly int SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_Offset;
    
    public void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetUseFieldOfViewForLOD_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_Offset), 0, null, bInUseFieldOfViewForLOD);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetUseFieldOfViewForLOD_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetProjectionMode
    static readonly IntPtr SetProjectionMode_NativeFunction;
    static readonly int SetProjectionMode_ParamsSize;
    static readonly int SetProjectionMode_InProjectionMode_Offset;
    
    public void SetProjectionMode(UnrealSharp.Engine.ECameraProjectionMode inProjectionMode)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetProjectionMode_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Engine.ECameraProjectionMode>.ToNative(IntPtr.Add(ParamsBuffer, SetProjectionMode_InProjectionMode_Offset), 0, null, inProjectionMode);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetProjectionMode_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetPostProcessBlendWeight
    static readonly IntPtr SetPostProcessBlendWeight_NativeFunction;
    static readonly int SetPostProcessBlendWeight_ParamsSize;
    static readonly int SetPostProcessBlendWeight_InPostProcessBlendWeight_Offset;
    
    public void SetPostProcessBlendWeight(float inPostProcessBlendWeight)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPostProcessBlendWeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetPostProcessBlendWeight_InPostProcessBlendWeight_Offset), 0, null, inPostProcessBlendWeight);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPostProcessBlendWeight_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetOrthoWidth
    static readonly IntPtr SetOrthoWidth_NativeFunction;
    static readonly int SetOrthoWidth_ParamsSize;
    static readonly int SetOrthoWidth_InOrthoWidth_Offset;
    
    public void SetOrthoWidth(float inOrthoWidth)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOrthoWidth_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetOrthoWidth_InOrthoWidth_Offset), 0, null, inOrthoWidth);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOrthoWidth_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetOrthoNearClipPlane
    static readonly IntPtr SetOrthoNearClipPlane_NativeFunction;
    static readonly int SetOrthoNearClipPlane_ParamsSize;
    static readonly int SetOrthoNearClipPlane_InOrthoNearClipPlane_Offset;
    
    public void SetOrthoNearClipPlane(float inOrthoNearClipPlane)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOrthoNearClipPlane_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetOrthoNearClipPlane_InOrthoNearClipPlane_Offset), 0, null, inOrthoNearClipPlane);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOrthoNearClipPlane_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetOrthoFarClipPlane
    static readonly IntPtr SetOrthoFarClipPlane_NativeFunction;
    static readonly int SetOrthoFarClipPlane_ParamsSize;
    static readonly int SetOrthoFarClipPlane_InOrthoFarClipPlane_Offset;
    
    public void SetOrthoFarClipPlane(float inOrthoFarClipPlane)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOrthoFarClipPlane_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetOrthoFarClipPlane_InOrthoFarClipPlane_Offset), 0, null, inOrthoFarClipPlane);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOrthoFarClipPlane_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetFieldOfView
    static readonly IntPtr SetFieldOfView_NativeFunction;
    static readonly int SetFieldOfView_ParamsSize;
    static readonly int SetFieldOfView_InFieldOfView_Offset;
    
    public void SetFieldOfView(float inFieldOfView)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFieldOfView_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFieldOfView_InFieldOfView_Offset), 0, null, inFieldOfView);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFieldOfView_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetConstraintAspectRatio
    static readonly IntPtr SetConstraintAspectRatio_NativeFunction;
    static readonly int SetConstraintAspectRatio_ParamsSize;
    static readonly int SetConstraintAspectRatio_bInConstrainAspectRatio_Offset;
    
    public void SetConstraintAspectRatio(bool bInConstrainAspectRatio)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetConstraintAspectRatio_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetConstraintAspectRatio_bInConstrainAspectRatio_Offset), 0, null, bInConstrainAspectRatio);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetConstraintAspectRatio_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetAspectRatioAxisConstraint
    static readonly IntPtr SetAspectRatioAxisConstraint_NativeFunction;
    static readonly int SetAspectRatioAxisConstraint_ParamsSize;
    static readonly int SetAspectRatioAxisConstraint_InAspectRatioAxisConstraint_Offset;
    
    public void SetAspectRatioAxisConstraint(UnrealSharp.Engine.EAspectRatioAxisConstraint inAspectRatioAxisConstraint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAspectRatioAxisConstraint_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Engine.EAspectRatioAxisConstraint>.ToNative(IntPtr.Add(ParamsBuffer, SetAspectRatioAxisConstraint_InAspectRatioAxisConstraint_Offset), 0, null, inAspectRatioAxisConstraint);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAspectRatioAxisConstraint_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:SetAspectRatio
    static readonly IntPtr SetAspectRatio_NativeFunction;
    static readonly int SetAspectRatio_ParamsSize;
    static readonly int SetAspectRatio_InAspectRatio_Offset;
    
    public void SetAspectRatio(float inAspectRatio)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAspectRatio_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetAspectRatio_InAspectRatio_Offset), 0, null, inAspectRatio);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAspectRatio_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraComponent:GetCameraView
    static readonly IntPtr GetCameraView_NativeFunction;
    static readonly int GetCameraView_ParamsSize;
    static readonly int GetCameraView_DeltaTime_Offset;
    static readonly int GetCameraView_DesiredView_Offset;
    
    public void GetCameraView(float deltaTime, out UnrealSharp.Engine.MinimalViewInfo desiredView)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCameraView_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, GetCameraView_DeltaTime_Offset), 0, null, deltaTime);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCameraView_NativeFunction, ParamsBuffer);
            
            desiredView = UnrealSharp.Engine.MinimalViewInfoMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetCameraView_DesiredView_Offset), 0, null);
            
        }
    }
    
    
}