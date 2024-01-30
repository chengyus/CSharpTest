// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryFramework;

[UClass]
public partial class DynamicMeshComponent : UnrealSharp.GeometryFramework.BaseDynamicMeshComponent
{
    
    static DynamicMeshComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("DynamicMeshComponent");
        
        TangentsType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TangentsType");
        CollisionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CollisionType");
        bUseAsyncCooking_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseAsyncCooking");
        bEnableComplexCollision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableComplexCollision");
        bDeferCollisionUpdates_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDeferCollisionUpdates");
        
        ValidateMaterialSlots_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ValidateMaterialSlots");
        ValidateMaterialSlots_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ValidateMaterialSlots_NativeFunction);
        ValidateMaterialSlots_bCreateIfMissing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ValidateMaterialSlots_NativeFunction, "bCreateIfMissing");
        ValidateMaterialSlots_bDeleteExtraSlots_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ValidateMaterialSlots_NativeFunction, "bDeleteExtraSlots");
        ValidateMaterialSlots_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ValidateMaterialSlots_NativeFunction, "ReturnValue");
        UpdateCollision_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "UpdateCollision");
        UpdateCollision_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(UpdateCollision_NativeFunction);
        UpdateCollision_bOnlyIfPending_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(UpdateCollision_NativeFunction, "bOnlyIfPending");
        SetTangentsType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetTangentsType");
        SetTangentsType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetTangentsType_NativeFunction);
        SetTangentsType_NewTangentsType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetTangentsType_NativeFunction, "NewTangentsType");
        SetDynamicMesh_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDynamicMesh");
        SetDynamicMesh_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDynamicMesh_NativeFunction);
        SetDynamicMesh_NewMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDynamicMesh_NativeFunction, "NewMesh");
        SetDeferredCollisionUpdatesEnabled_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDeferredCollisionUpdatesEnabled");
        SetDeferredCollisionUpdatesEnabled_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDeferredCollisionUpdatesEnabled_NativeFunction);
        SetDeferredCollisionUpdatesEnabled_bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDeferredCollisionUpdatesEnabled_NativeFunction, "bEnabled");
        SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDeferredCollisionUpdatesEnabled_NativeFunction, "bImmediateUpdate");
        SetComplexAsSimpleCollisionEnabled_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetComplexAsSimpleCollisionEnabled");
        SetComplexAsSimpleCollisionEnabled_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetComplexAsSimpleCollisionEnabled_NativeFunction);
        SetComplexAsSimpleCollisionEnabled_bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetComplexAsSimpleCollisionEnabled_NativeFunction, "bEnabled");
        SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetComplexAsSimpleCollisionEnabled_NativeFunction, "bImmediateUpdate");
        NotifyMeshVertexAttributesModified_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "NotifyMeshVertexAttributesModified");
        NotifyMeshVertexAttributesModified_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(NotifyMeshVertexAttributesModified_NativeFunction);
        NotifyMeshVertexAttributesModified_bPositions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyMeshVertexAttributesModified_NativeFunction, "bPositions");
        NotifyMeshVertexAttributesModified_bNormals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyMeshVertexAttributesModified_NativeFunction, "bNormals");
        NotifyMeshVertexAttributesModified_bUVs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyMeshVertexAttributesModified_NativeFunction, "bUVs");
        NotifyMeshVertexAttributesModified_bColors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NotifyMeshVertexAttributesModified_NativeFunction, "bColors");
        NotifyMeshModified_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "NotifyMeshModified");
        GetTangentsType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetTangentsType");
        GetTangentsType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetTangentsType_NativeFunction);
        GetTangentsType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTangentsType_NativeFunction, "ReturnValue");
        EnableComplexAsSimpleCollision_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "EnableComplexAsSimpleCollision");
        ConfigureMaterialSet_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ConfigureMaterialSet");
        ConfigureMaterialSet_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ConfigureMaterialSet_NativeFunction);
        ConfigureMaterialSet_NewMaterialSet_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ConfigureMaterialSet_NativeFunction, "NewMaterialSet");
        ConfigureMaterialSet_NewMaterialSet_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ConfigureMaterialSet_NativeFunction, "NewMaterialSet");
        
        
    }
    
    protected DynamicMeshComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // EnumProperty /Script/GeometryFramework.DynamicMeshComponent:TangentsType
    static readonly int TangentsType_Offset;
    
    public UnrealSharp.GeometryFramework.EDynamicMeshComponentTangentsMode TangentsType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.GeometryFramework.EDynamicMeshComponentTangentsMode>.FromNative(IntPtr.Add(NativeObject, TangentsType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.GeometryFramework.EDynamicMeshComponentTangentsMode>.ToNative(IntPtr.Add(NativeObject, TangentsType_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/GeometryFramework.DynamicMeshComponent:CollisionType
    static readonly int CollisionType_Offset;
    
    public UnrealSharp.PhysicsCore.ECollisionTraceFlag CollisionType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.PhysicsCore.ECollisionTraceFlag>.FromNative(IntPtr.Add(NativeObject, CollisionType_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.PhysicsCore.ECollisionTraceFlag>.ToNative(IntPtr.Add(NativeObject, CollisionType_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/GeometryFramework.DynamicMeshComponent:bUseAsyncCooking
    static readonly int bUseAsyncCooking_Offset;
    
    public bool bUseAsyncCooking
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseAsyncCooking_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/GeometryFramework.DynamicMeshComponent:bEnableComplexCollision
    static readonly int bEnableComplexCollision_Offset;
    
    public bool bEnableComplexCollision
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bEnableComplexCollision_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bEnableComplexCollision_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/GeometryFramework.DynamicMeshComponent:bDeferCollisionUpdates
    static readonly int bDeferCollisionUpdates_Offset;
    
    public bool bDeferCollisionUpdates
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bDeferCollisionUpdates_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bDeferCollisionUpdates_Offset), 0, this, value);
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:ValidateMaterialSlots
    static readonly IntPtr ValidateMaterialSlots_NativeFunction;
    static readonly int ValidateMaterialSlots_ParamsSize;
    static readonly int ValidateMaterialSlots_bCreateIfMissing_Offset;
    static readonly int ValidateMaterialSlots_bDeleteExtraSlots_Offset;
    static readonly int ValidateMaterialSlots_ReturnValue_Offset;
    
    public bool ValidateMaterialSlots(bool bCreateIfMissing = true, bool bDeleteExtraSlots = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ValidateMaterialSlots_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, ValidateMaterialSlots_bCreateIfMissing_Offset), 0, null, bCreateIfMissing);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, ValidateMaterialSlots_bDeleteExtraSlots_Offset), 0, null, bDeleteExtraSlots);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ValidateMaterialSlots_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ValidateMaterialSlots_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:UpdateCollision
    static readonly IntPtr UpdateCollision_NativeFunction;
    static readonly int UpdateCollision_ParamsSize;
    static readonly int UpdateCollision_bOnlyIfPending_Offset;
    
    public void UpdateCollision(bool bOnlyIfPending = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[UpdateCollision_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, UpdateCollision_bOnlyIfPending_Offset), 0, null, bOnlyIfPending);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, UpdateCollision_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:SetTangentsType
    static readonly IntPtr SetTangentsType_NativeFunction;
    static readonly int SetTangentsType_ParamsSize;
    static readonly int SetTangentsType_NewTangentsType_Offset;
    
    public void SetTangentsType(UnrealSharp.GeometryFramework.EDynamicMeshComponentTangentsMode newTangentsType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetTangentsType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.GeometryFramework.EDynamicMeshComponentTangentsMode>.ToNative(IntPtr.Add(ParamsBuffer, SetTangentsType_NewTangentsType_Offset), 0, null, newTangentsType);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetTangentsType_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:SetDynamicMesh
    static readonly IntPtr SetDynamicMesh_NativeFunction;
    static readonly int SetDynamicMesh_ParamsSize;
    static readonly int SetDynamicMesh_NewMesh_Offset;
    
    public void SetDynamicMesh(UnrealSharp.GeometryFramework.DynamicMesh newMesh)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDynamicMesh_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.GeometryFramework.DynamicMesh>.ToNative(IntPtr.Add(ParamsBuffer, SetDynamicMesh_NewMesh_Offset), 0, null, newMesh);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDynamicMesh_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:SetDeferredCollisionUpdatesEnabled
    static readonly IntPtr SetDeferredCollisionUpdatesEnabled_NativeFunction;
    static readonly int SetDeferredCollisionUpdatesEnabled_ParamsSize;
    static readonly int SetDeferredCollisionUpdatesEnabled_bEnabled_Offset;
    static readonly int SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_Offset;
    
    public void SetDeferredCollisionUpdatesEnabled(bool bEnabled, bool bImmediateUpdate = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDeferredCollisionUpdatesEnabled_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetDeferredCollisionUpdatesEnabled_bEnabled_Offset), 0, null, bEnabled);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetDeferredCollisionUpdatesEnabled_bImmediateUpdate_Offset), 0, null, bImmediateUpdate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDeferredCollisionUpdatesEnabled_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:SetComplexAsSimpleCollisionEnabled
    static readonly IntPtr SetComplexAsSimpleCollisionEnabled_NativeFunction;
    static readonly int SetComplexAsSimpleCollisionEnabled_ParamsSize;
    static readonly int SetComplexAsSimpleCollisionEnabled_bEnabled_Offset;
    static readonly int SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_Offset;
    
    public void SetComplexAsSimpleCollisionEnabled(bool bEnabled, bool bImmediateUpdate = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetComplexAsSimpleCollisionEnabled_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetComplexAsSimpleCollisionEnabled_bEnabled_Offset), 0, null, bEnabled);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetComplexAsSimpleCollisionEnabled_bImmediateUpdate_Offset), 0, null, bImmediateUpdate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetComplexAsSimpleCollisionEnabled_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:NotifyMeshVertexAttributesModified
    static readonly IntPtr NotifyMeshVertexAttributesModified_NativeFunction;
    static readonly int NotifyMeshVertexAttributesModified_ParamsSize;
    static readonly int NotifyMeshVertexAttributesModified_bPositions_Offset;
    static readonly int NotifyMeshVertexAttributesModified_bNormals_Offset;
    static readonly int NotifyMeshVertexAttributesModified_bUVs_Offset;
    static readonly int NotifyMeshVertexAttributesModified_bColors_Offset;
    
    public void NotifyMeshVertexAttributesModified(bool bPositions = true, bool bNormals = true, bool bUVs = true, bool bColors = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[NotifyMeshVertexAttributesModified_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, NotifyMeshVertexAttributesModified_bPositions_Offset), 0, null, bPositions);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, NotifyMeshVertexAttributesModified_bNormals_Offset), 0, null, bNormals);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, NotifyMeshVertexAttributesModified_bUVs_Offset), 0, null, bUVs);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, NotifyMeshVertexAttributesModified_bColors_Offset), 0, null, bColors);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, NotifyMeshVertexAttributesModified_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:NotifyMeshModified
    static readonly IntPtr NotifyMeshModified_NativeFunction;
    
    public void NotifyMeshModified()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, NotifyMeshModified_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:GetTangentsType
    static readonly IntPtr GetTangentsType_NativeFunction;
    static readonly int GetTangentsType_ParamsSize;
    static readonly int GetTangentsType_ReturnValue_Offset;
    
    public UnrealSharp.GeometryFramework.EDynamicMeshComponentTangentsMode GetTangentsType()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetTangentsType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetTangentsType_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GeometryFramework.EDynamicMeshComponentTangentsMode returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.GeometryFramework.EDynamicMeshComponentTangentsMode>.FromNative(IntPtr.Add(ParamsBuffer, GetTangentsType_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:EnableComplexAsSimpleCollision
    static readonly IntPtr EnableComplexAsSimpleCollision_NativeFunction;
    
    public void EnableComplexAsSimpleCollision()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, EnableComplexAsSimpleCollision_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/GeometryFramework.DynamicMeshComponent:ConfigureMaterialSet
    static readonly IntPtr ConfigureMaterialSet_NativeFunction;
    static readonly int ConfigureMaterialSet_ParamsSize;
    static readonly int ConfigureMaterialSet_NewMaterialSet_Offset;
    static readonly int ConfigureMaterialSet_NewMaterialSet_ElementSize;
    
    public void ConfigureMaterialSet(System.Collections.Generic.IList<UnrealSharp.Engine.MaterialInterface> newMaterialSet)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ConfigureMaterialSet_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr NewMaterialSet_NativeBuffer = IntPtr.Add(ParamsBuffer, ConfigureMaterialSet_NewMaterialSet_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.MaterialInterface> NewMaterialSet_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.MaterialInterface>(1, ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative, ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative, ConfigureMaterialSet_NewMaterialSet_ElementSize);
            NewMaterialSet_Marshaler.ToNative(NewMaterialSet_NativeBuffer, 0, null, newMaterialSet);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ConfigureMaterialSet_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    
}