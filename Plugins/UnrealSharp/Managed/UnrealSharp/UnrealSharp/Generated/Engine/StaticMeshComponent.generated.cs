// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class StaticMeshComponent : UnrealSharp.Engine.MeshComponent
{
    
    static StaticMeshComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("StaticMeshComponent");
        
        ForcedLodModel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ForcedLodModel");
        MinLOD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinLOD");
        StaticMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticMesh");
        WireframeColorOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WireframeColorOverride");
        bForceNaniteForMasked_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceNaniteForMasked");
        bForceNaniteForMasked_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bForceNaniteForMasked");
        bDisallowNanite_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDisallowNanite");
        bDisallowNanite_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDisallowNanite");
        bEvaluateWorldPositionOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEvaluateWorldPositionOffset");
        bEvaluateWorldPositionOffset_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEvaluateWorldPositionOffset");
        bWorldPositionOffsetWritesVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bWorldPositionOffsetWritesVelocity");
        bWorldPositionOffsetWritesVelocity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bWorldPositionOffsetWritesVelocity");
        bEvaluateWorldPositionOffsetInRayTracing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEvaluateWorldPositionOffsetInRayTracing");
        bEvaluateWorldPositionOffsetInRayTracing_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEvaluateWorldPositionOffsetInRayTracing");
        WorldPositionOffsetDisableDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldPositionOffsetDisableDistance");
        bOverrideWireframeColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideWireframeColor");
        bOverrideWireframeColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverrideWireframeColor");
        bOverrideMinLOD_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideMinLOD");
        bOverrideMinLOD_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverrideMinLOD");
        bDisallowMeshPaintPerInstance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDisallowMeshPaintPerInstance");
        bDisallowMeshPaintPerInstance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDisallowMeshPaintPerInstance");
        bIgnoreInstanceForTextureStreaming_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIgnoreInstanceForTextureStreaming");
        bIgnoreInstanceForTextureStreaming_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIgnoreInstanceForTextureStreaming");
        bOverrideLightMapRes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideLightMapRes");
        bOverrideLightMapRes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverrideLightMapRes");
        bCastDistanceFieldIndirectShadow_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCastDistanceFieldIndirectShadow");
        bCastDistanceFieldIndirectShadow_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCastDistanceFieldIndirectShadow");
        bOverrideDistanceFieldSelfShadowBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideDistanceFieldSelfShadowBias");
        bOverrideDistanceFieldSelfShadowBias_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverrideDistanceFieldSelfShadowBias");
        bSortTriangles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSortTriangles");
        bSortTriangles_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSortTriangles");
        bReverseCulling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReverseCulling");
        bReverseCulling_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bReverseCulling");
        OverriddenLightMapRes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverriddenLightMapRes");
        DistanceFieldIndirectShadowMinVisibility_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceFieldIndirectShadowMinVisibility");
        DistanceFieldSelfShadowBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceFieldSelfShadowBias");
        StreamingDistanceMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StreamingDistanceMultiplier");
        
        SetWorldPositionOffsetDisableDistance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetWorldPositionOffsetDisableDistance");
        SetWorldPositionOffsetDisableDistance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetWorldPositionOffsetDisableDistance_NativeFunction);
        SetWorldPositionOffsetDisableDistance_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetWorldPositionOffsetDisableDistance_NativeFunction, "NewValue");
        SetStaticMesh_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetStaticMesh");
        SetStaticMesh_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetStaticMesh_NativeFunction);
        SetStaticMesh_NewMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetStaticMesh_NativeFunction, "NewMesh");
        SetStaticMesh_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetStaticMesh_NativeFunction, "ReturnValue");
        SetReverseCulling_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetReverseCulling");
        SetReverseCulling_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetReverseCulling_NativeFunction);
        SetReverseCulling_ReverseCulling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetReverseCulling_NativeFunction, "ReverseCulling");
        SetForcedLodModel_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetForcedLodModel");
        SetForcedLodModel_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetForcedLodModel_NativeFunction);
        SetForcedLodModel_NewForcedLodModel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetForcedLodModel_NativeFunction, "NewForcedLodModel");
        SetForceDisableNanite_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetForceDisableNanite");
        SetForceDisableNanite_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetForceDisableNanite_NativeFunction);
        SetForceDisableNanite_bInForceDisableNanite_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetForceDisableNanite_NativeFunction, "bInForceDisableNanite");
        SetEvaluateWorldPositionOffsetInRayTracing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetEvaluateWorldPositionOffsetInRayTracing");
        SetEvaluateWorldPositionOffsetInRayTracing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetEvaluateWorldPositionOffsetInRayTracing_NativeFunction);
        SetEvaluateWorldPositionOffsetInRayTracing_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetEvaluateWorldPositionOffsetInRayTracing_NativeFunction, "NewValue");
        SetEvaluateWorldPositionOffset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetEvaluateWorldPositionOffset");
        SetEvaluateWorldPositionOffset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetEvaluateWorldPositionOffset_NativeFunction);
        SetEvaluateWorldPositionOffset_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetEvaluateWorldPositionOffset_NativeFunction, "NewValue");
        SetDistanceFieldSelfShadowBias_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDistanceFieldSelfShadowBias");
        SetDistanceFieldSelfShadowBias_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDistanceFieldSelfShadowBias_NativeFunction);
        SetDistanceFieldSelfShadowBias_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDistanceFieldSelfShadowBias_NativeFunction, "NewValue");
        GetLocalBounds_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLocalBounds");
        GetLocalBounds_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLocalBounds_NativeFunction);
        GetLocalBounds_Min_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLocalBounds_NativeFunction, "Min");
        GetLocalBounds_Max_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLocalBounds_NativeFunction, "Max");
        GetInitialEvaluateWorldPositionOffset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetInitialEvaluateWorldPositionOffset");
        GetInitialEvaluateWorldPositionOffset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetInitialEvaluateWorldPositionOffset_NativeFunction);
        GetInitialEvaluateWorldPositionOffset_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInitialEvaluateWorldPositionOffset_NativeFunction, "ReturnValue");
        
        
    }
    
    protected StaticMeshComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // IntProperty /Script/Engine.StaticMeshComponent:ForcedLodModel
    static readonly int ForcedLodModel_Offset;
    
    public int ForcedLodModel
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, ForcedLodModel_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/Engine.StaticMeshComponent:MinLOD
    static readonly int MinLOD_Offset;
    
    public int MinLOD
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, MinLOD_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Engine.StaticMeshComponent:StaticMesh
    static readonly int StaticMesh_Offset;
    
    public UnrealSharp.Engine.StaticMesh StaticMesh
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.FromNative(IntPtr.Add(NativeObject, StaticMesh_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.StaticMeshComponent:WireframeColorOverride
    static readonly int WireframeColorOverride_Offset;
    
    public UnrealSharp.CoreUObject.Color WireframeColorOverride
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(NativeObject, WireframeColorOverride_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bForceNaniteForMasked
    static readonly int bForceNaniteForMasked_Offset;
    static readonly IntPtr bForceNaniteForMasked_NativeProperty;
    
    public bool bForceNaniteForMasked
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bForceNaniteForMasked_NativeProperty, bForceNaniteForMasked_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bForceNaniteForMasked_NativeProperty, bForceNaniteForMasked_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bDisallowNanite
    static readonly int bDisallowNanite_Offset;
    static readonly IntPtr bDisallowNanite_NativeProperty;
    
    public bool bDisallowNanite
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bDisallowNanite_NativeProperty, bDisallowNanite_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bDisallowNanite_NativeProperty, bDisallowNanite_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bEvaluateWorldPositionOffset
    static readonly int bEvaluateWorldPositionOffset_Offset;
    static readonly IntPtr bEvaluateWorldPositionOffset_NativeProperty;
    
    public bool bEvaluateWorldPositionOffset
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bEvaluateWorldPositionOffset_NativeProperty, bEvaluateWorldPositionOffset_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bEvaluateWorldPositionOffset_NativeProperty, bEvaluateWorldPositionOffset_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bWorldPositionOffsetWritesVelocity
    static readonly int bWorldPositionOffsetWritesVelocity_Offset;
    static readonly IntPtr bWorldPositionOffsetWritesVelocity_NativeProperty;
    
    public bool bWorldPositionOffsetWritesVelocity
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bWorldPositionOffsetWritesVelocity_NativeProperty, bWorldPositionOffsetWritesVelocity_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bWorldPositionOffsetWritesVelocity_NativeProperty, bWorldPositionOffsetWritesVelocity_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bEvaluateWorldPositionOffsetInRayTracing
    static readonly int bEvaluateWorldPositionOffsetInRayTracing_Offset;
    static readonly IntPtr bEvaluateWorldPositionOffsetInRayTracing_NativeProperty;
    
    public bool bEvaluateWorldPositionOffsetInRayTracing
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bEvaluateWorldPositionOffsetInRayTracing_NativeProperty, bEvaluateWorldPositionOffsetInRayTracing_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bEvaluateWorldPositionOffsetInRayTracing_NativeProperty, bEvaluateWorldPositionOffsetInRayTracing_Offset, value);
        }
    }
    
    // IntProperty /Script/Engine.StaticMeshComponent:WorldPositionOffsetDisableDistance
    static readonly int WorldPositionOffsetDisableDistance_Offset;
    
    public int WorldPositionOffsetDisableDistance
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, WorldPositionOffsetDisableDistance_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bOverrideWireframeColor
    static readonly int bOverrideWireframeColor_Offset;
    static readonly IntPtr bOverrideWireframeColor_NativeProperty;
    
    public bool bOverrideWireframeColor
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bOverrideWireframeColor_NativeProperty, bOverrideWireframeColor_Offset);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bOverrideMinLOD
    static readonly int bOverrideMinLOD_Offset;
    static readonly IntPtr bOverrideMinLOD_NativeProperty;
    
    public bool bOverrideMinLOD
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bOverrideMinLOD_NativeProperty, bOverrideMinLOD_Offset);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bDisallowMeshPaintPerInstance
    static readonly int bDisallowMeshPaintPerInstance_Offset;
    static readonly IntPtr bDisallowMeshPaintPerInstance_NativeProperty;
    
    public bool bDisallowMeshPaintPerInstance
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bDisallowMeshPaintPerInstance_NativeProperty, bDisallowMeshPaintPerInstance_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bDisallowMeshPaintPerInstance_NativeProperty, bDisallowMeshPaintPerInstance_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bIgnoreInstanceForTextureStreaming
    static readonly int bIgnoreInstanceForTextureStreaming_Offset;
    static readonly IntPtr bIgnoreInstanceForTextureStreaming_NativeProperty;
    
    public bool bIgnoreInstanceForTextureStreaming
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bIgnoreInstanceForTextureStreaming_NativeProperty, bIgnoreInstanceForTextureStreaming_Offset);
        }
        set
        {
            CheckObjectForValidity();
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(NativeObject, bIgnoreInstanceForTextureStreaming_NativeProperty, bIgnoreInstanceForTextureStreaming_Offset, value);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bOverrideLightMapRes
    static readonly int bOverrideLightMapRes_Offset;
    static readonly IntPtr bOverrideLightMapRes_NativeProperty;
    
    public bool bOverrideLightMapRes
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bOverrideLightMapRes_NativeProperty, bOverrideLightMapRes_Offset);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bCastDistanceFieldIndirectShadow
    static readonly int bCastDistanceFieldIndirectShadow_Offset;
    static readonly IntPtr bCastDistanceFieldIndirectShadow_NativeProperty;
    
    public bool bCastDistanceFieldIndirectShadow
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bCastDistanceFieldIndirectShadow_NativeProperty, bCastDistanceFieldIndirectShadow_Offset);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bOverrideDistanceFieldSelfShadowBias
    static readonly int bOverrideDistanceFieldSelfShadowBias_Offset;
    static readonly IntPtr bOverrideDistanceFieldSelfShadowBias_NativeProperty;
    
    public bool bOverrideDistanceFieldSelfShadowBias
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bOverrideDistanceFieldSelfShadowBias_NativeProperty, bOverrideDistanceFieldSelfShadowBias_Offset);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bSortTriangles
    static readonly int bSortTriangles_Offset;
    static readonly IntPtr bSortTriangles_NativeProperty;
    
    public bool bSortTriangles
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bSortTriangles_NativeProperty, bSortTriangles_Offset);
        }
    }
    
    // BoolProperty /Script/Engine.StaticMeshComponent:bReverseCulling
    static readonly int bReverseCulling_Offset;
    static readonly IntPtr bReverseCulling_NativeProperty;
    
    public bool bReverseCulling
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bReverseCulling_NativeProperty, bReverseCulling_Offset);
        }
    }
    
    // IntProperty /Script/Engine.StaticMeshComponent:OverriddenLightMapRes
    static readonly int OverriddenLightMapRes_Offset;
    
    public int OverriddenLightMapRes
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, OverriddenLightMapRes_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.StaticMeshComponent:DistanceFieldIndirectShadowMinVisibility
    static readonly int DistanceFieldIndirectShadowMinVisibility_Offset;
    
    public float DistanceFieldIndirectShadowMinVisibility
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DistanceFieldIndirectShadowMinVisibility_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.StaticMeshComponent:DistanceFieldSelfShadowBias
    static readonly int DistanceFieldSelfShadowBias_Offset;
    
    public float DistanceFieldSelfShadowBias
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DistanceFieldSelfShadowBias_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.StaticMeshComponent:StreamingDistanceMultiplier
    static readonly int StreamingDistanceMultiplier_Offset;
    
    public float StreamingDistanceMultiplier
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, StreamingDistanceMultiplier_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, StreamingDistanceMultiplier_Offset), 0, this, value);
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:SetWorldPositionOffsetDisableDistance
    static readonly IntPtr SetWorldPositionOffsetDisableDistance_NativeFunction;
    static readonly int SetWorldPositionOffsetDisableDistance_ParamsSize;
    static readonly int SetWorldPositionOffsetDisableDistance_NewValue_Offset;
    
    public void SetWorldPositionOffsetDisableDistance(int newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetWorldPositionOffsetDisableDistance_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetWorldPositionOffsetDisableDistance_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetWorldPositionOffsetDisableDistance_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:SetStaticMesh
    static readonly IntPtr SetStaticMesh_NativeFunction;
    static readonly int SetStaticMesh_ParamsSize;
    static readonly int SetStaticMesh_NewMesh_Offset;
    static readonly int SetStaticMesh_ReturnValue_Offset;
    
    public bool SetStaticMesh(UnrealSharp.Engine.StaticMesh newMesh)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetStaticMesh_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.ToNative(IntPtr.Add(ParamsBuffer, SetStaticMesh_NewMesh_Offset), 0, null, newMesh);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetStaticMesh_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetStaticMesh_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:SetReverseCulling
    static readonly IntPtr SetReverseCulling_NativeFunction;
    static readonly int SetReverseCulling_ParamsSize;
    static readonly int SetReverseCulling_ReverseCulling_Offset;
    
    public void SetReverseCulling(bool reverseCulling)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetReverseCulling_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetReverseCulling_ReverseCulling_Offset), 0, null, reverseCulling);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetReverseCulling_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:SetForcedLodModel
    static readonly IntPtr SetForcedLodModel_NativeFunction;
    static readonly int SetForcedLodModel_ParamsSize;
    static readonly int SetForcedLodModel_NewForcedLodModel_Offset;
    
    public void SetForcedLodModel(int newForcedLodModel)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetForcedLodModel_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetForcedLodModel_NewForcedLodModel_Offset), 0, null, newForcedLodModel);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetForcedLodModel_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:SetForceDisableNanite
    static readonly IntPtr SetForceDisableNanite_NativeFunction;
    static readonly int SetForceDisableNanite_ParamsSize;
    static readonly int SetForceDisableNanite_bInForceDisableNanite_Offset;
    
    public void SetForceDisableNanite(bool bInForceDisableNanite)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetForceDisableNanite_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetForceDisableNanite_bInForceDisableNanite_Offset), 0, null, bInForceDisableNanite);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetForceDisableNanite_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:SetEvaluateWorldPositionOffsetInRayTracing
    static readonly IntPtr SetEvaluateWorldPositionOffsetInRayTracing_NativeFunction;
    static readonly int SetEvaluateWorldPositionOffsetInRayTracing_ParamsSize;
    static readonly int SetEvaluateWorldPositionOffsetInRayTracing_NewValue_Offset;
    
    public void SetEvaluateWorldPositionOffsetInRayTracing(bool newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetEvaluateWorldPositionOffsetInRayTracing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetEvaluateWorldPositionOffsetInRayTracing_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetEvaluateWorldPositionOffsetInRayTracing_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:SetEvaluateWorldPositionOffset
    static readonly IntPtr SetEvaluateWorldPositionOffset_NativeFunction;
    static readonly int SetEvaluateWorldPositionOffset_ParamsSize;
    static readonly int SetEvaluateWorldPositionOffset_NewValue_Offset;
    
    public void SetEvaluateWorldPositionOffset(bool newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetEvaluateWorldPositionOffset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetEvaluateWorldPositionOffset_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetEvaluateWorldPositionOffset_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:SetDistanceFieldSelfShadowBias
    static readonly IntPtr SetDistanceFieldSelfShadowBias_NativeFunction;
    static readonly int SetDistanceFieldSelfShadowBias_ParamsSize;
    static readonly int SetDistanceFieldSelfShadowBias_NewValue_Offset;
    
    public void SetDistanceFieldSelfShadowBias(float newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDistanceFieldSelfShadowBias_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetDistanceFieldSelfShadowBias_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDistanceFieldSelfShadowBias_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:GetLocalBounds
    static readonly IntPtr GetLocalBounds_NativeFunction;
    static readonly int GetLocalBounds_ParamsSize;
    static readonly int GetLocalBounds_Min_Offset;
    static readonly int GetLocalBounds_Max_Offset;
    
    public void GetLocalBounds(out System.DoubleNumerics.Vector3 min, out System.DoubleNumerics.Vector3 max)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLocalBounds_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLocalBounds_NativeFunction, ParamsBuffer);
            
            min = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, GetLocalBounds_Min_Offset), 0, null);
            max = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, GetLocalBounds_Max_Offset), 0, null);
            
        }
    }
    
    // Function /Script/Engine.StaticMeshComponent:GetInitialEvaluateWorldPositionOffset
    static readonly IntPtr GetInitialEvaluateWorldPositionOffset_NativeFunction;
    static readonly int GetInitialEvaluateWorldPositionOffset_ParamsSize;
    static readonly int GetInitialEvaluateWorldPositionOffset_ReturnValue_Offset;
    
    public bool GetInitialEvaluateWorldPositionOffset()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetInitialEvaluateWorldPositionOffset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetInitialEvaluateWorldPositionOffset_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetInitialEvaluateWorldPositionOffset_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}