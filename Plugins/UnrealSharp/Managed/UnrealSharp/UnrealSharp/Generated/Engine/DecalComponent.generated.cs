// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class DecalComponent : UnrealSharp.Engine.SceneComponent
{
    
    static DecalComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("DecalComponent");
        
        DecalMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DecalMaterial");
        SortOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SortOrder");
        FadeScreenSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FadeScreenSize");
        FadeStartDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FadeStartDelay");
        FadeDuration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FadeDuration");
        FadeInDuration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FadeInDuration");
        FadeInStartDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FadeInStartDelay");
        bDestroyOwnerAfterFade_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDestroyOwnerAfterFade");
        bDestroyOwnerAfterFade_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDestroyOwnerAfterFade");
        DecalSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DecalSize");
        DecalColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DecalColor");
        
        SetSortOrder_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSortOrder");
        SetSortOrder_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSortOrder_NativeFunction);
        SetSortOrder_Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSortOrder_NativeFunction, "Value");
        SetFadeScreenSize_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFadeScreenSize");
        SetFadeScreenSize_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFadeScreenSize_NativeFunction);
        SetFadeScreenSize_NewFadeScreenSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFadeScreenSize_NativeFunction, "NewFadeScreenSize");
        SetFadeOut_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFadeOut");
        SetFadeOut_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFadeOut_NativeFunction);
        SetFadeOut_StartDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFadeOut_NativeFunction, "StartDelay");
        SetFadeOut_Duration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFadeOut_NativeFunction, "Duration");
        SetFadeOut_DestroyOwnerAfterFade_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFadeOut_NativeFunction, "DestroyOwnerAfterFade");
        SetFadeIn_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFadeIn");
        SetFadeIn_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFadeIn_NativeFunction);
        SetFadeIn_StartDelay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFadeIn_NativeFunction, "StartDelay");
        SetFadeIn_Duration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFadeIn_NativeFunction, "Duration");
        SetDecalMaterial_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDecalMaterial");
        SetDecalMaterial_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDecalMaterial_NativeFunction);
        SetDecalMaterial_NewDecalMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDecalMaterial_NativeFunction, "NewDecalMaterial");
        SetDecalColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDecalColor");
        SetDecalColor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDecalColor_NativeFunction);
        SetDecalColor_Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDecalColor_NativeFunction, "Color");
        GetFadeStartDelay_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFadeStartDelay");
        GetFadeStartDelay_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFadeStartDelay_NativeFunction);
        GetFadeStartDelay_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFadeStartDelay_NativeFunction, "ReturnValue");
        GetFadeInStartDelay_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFadeInStartDelay");
        GetFadeInStartDelay_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFadeInStartDelay_NativeFunction);
        GetFadeInStartDelay_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFadeInStartDelay_NativeFunction, "ReturnValue");
        GetFadeInDuration_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFadeInDuration");
        GetFadeInDuration_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFadeInDuration_NativeFunction);
        GetFadeInDuration_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFadeInDuration_NativeFunction, "ReturnValue");
        GetFadeDuration_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFadeDuration");
        GetFadeDuration_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFadeDuration_NativeFunction);
        GetFadeDuration_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFadeDuration_NativeFunction, "ReturnValue");
        GetDecalMaterial_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDecalMaterial");
        GetDecalMaterial_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDecalMaterial_NativeFunction);
        GetDecalMaterial_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDecalMaterial_NativeFunction, "ReturnValue");
        CreateDynamicMaterialInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CreateDynamicMaterialInstance");
        CreateDynamicMaterialInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CreateDynamicMaterialInstance_NativeFunction);
        CreateDynamicMaterialInstance_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateDynamicMaterialInstance_NativeFunction, "ReturnValue");
        
        
    }
    
    protected DecalComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.DecalComponent:DecalMaterial
    static readonly int DecalMaterial_Offset;
    
    public UnrealSharp.Engine.MaterialInterface DecalMaterial
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(NativeObject, DecalMaterial_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/Engine.DecalComponent:SortOrder
    static readonly int SortOrder_Offset;
    
    public int SortOrder
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, SortOrder_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.DecalComponent:FadeScreenSize
    static readonly int FadeScreenSize_Offset;
    
    public float FadeScreenSize
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FadeScreenSize_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.DecalComponent:FadeStartDelay
    static readonly int FadeStartDelay_Offset;
    
    public float FadeStartDelay
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FadeStartDelay_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.DecalComponent:FadeDuration
    static readonly int FadeDuration_Offset;
    
    public float FadeDuration
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FadeDuration_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.DecalComponent:FadeInDuration
    static readonly int FadeInDuration_Offset;
    
    public float FadeInDuration
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FadeInDuration_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.DecalComponent:FadeInStartDelay
    static readonly int FadeInStartDelay_Offset;
    
    public float FadeInStartDelay
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FadeInStartDelay_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.DecalComponent:bDestroyOwnerAfterFade
    static readonly int bDestroyOwnerAfterFade_Offset;
    static readonly IntPtr bDestroyOwnerAfterFade_NativeProperty;
    
    public bool bDestroyOwnerAfterFade
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bDestroyOwnerAfterFade_NativeProperty, bDestroyOwnerAfterFade_Offset);
        }
    }
    
    // StructProperty /Script/Engine.DecalComponent:DecalSize
    static readonly int DecalSize_Offset;
    
    public System.DoubleNumerics.Vector3 DecalSize
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(NativeObject, DecalSize_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.DecalComponent:DecalColor
    static readonly int DecalColor_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor DecalColor
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(NativeObject, DecalColor_Offset), 0, this);
        }
    }
    
    // Function /Script/Engine.DecalComponent:SetSortOrder
    static readonly IntPtr SetSortOrder_NativeFunction;
    static readonly int SetSortOrder_ParamsSize;
    static readonly int SetSortOrder_Value_Offset;
    
    public void SetSortOrder(int value)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSortOrder_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetSortOrder_Value_Offset), 0, null, value);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSortOrder_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.DecalComponent:SetFadeScreenSize
    static readonly IntPtr SetFadeScreenSize_NativeFunction;
    static readonly int SetFadeScreenSize_ParamsSize;
    static readonly int SetFadeScreenSize_NewFadeScreenSize_Offset;
    
    public void SetFadeScreenSize(float newFadeScreenSize)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFadeScreenSize_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFadeScreenSize_NewFadeScreenSize_Offset), 0, null, newFadeScreenSize);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFadeScreenSize_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.DecalComponent:SetFadeOut
    static readonly IntPtr SetFadeOut_NativeFunction;
    static readonly int SetFadeOut_ParamsSize;
    static readonly int SetFadeOut_StartDelay_Offset;
    static readonly int SetFadeOut_Duration_Offset;
    static readonly int SetFadeOut_DestroyOwnerAfterFade_Offset;
    
    public void SetFadeOut(float startDelay, float duration, bool destroyOwnerAfterFade = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFadeOut_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFadeOut_StartDelay_Offset), 0, null, startDelay);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFadeOut_Duration_Offset), 0, null, duration);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetFadeOut_DestroyOwnerAfterFade_Offset), 0, null, destroyOwnerAfterFade);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFadeOut_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.DecalComponent:SetFadeIn
    static readonly IntPtr SetFadeIn_NativeFunction;
    static readonly int SetFadeIn_ParamsSize;
    static readonly int SetFadeIn_StartDelay_Offset;
    static readonly int SetFadeIn_Duration_Offset;
    
    public void SetFadeIn(float startDelay, float duration)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFadeIn_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFadeIn_StartDelay_Offset), 0, null, startDelay);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFadeIn_Duration_Offset), 0, null, duration);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFadeIn_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.DecalComponent:SetDecalMaterial
    static readonly IntPtr SetDecalMaterial_NativeFunction;
    static readonly int SetDecalMaterial_ParamsSize;
    static readonly int SetDecalMaterial_NewDecalMaterial_Offset;
    
    public void SetDecalMaterial(UnrealSharp.Engine.MaterialInterface newDecalMaterial)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDecalMaterial_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative(IntPtr.Add(ParamsBuffer, SetDecalMaterial_NewDecalMaterial_Offset), 0, null, newDecalMaterial);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDecalMaterial_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.DecalComponent:SetDecalColor
    static readonly IntPtr SetDecalColor_NativeFunction;
    static readonly int SetDecalColor_ParamsSize;
    static readonly int SetDecalColor_Color_Offset;
    
    public void SetDecalColor(UnrealSharp.CoreUObject.LinearColor color)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDecalColor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(ParamsBuffer, SetDecalColor_Color_Offset), 0, null, color);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDecalColor_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/Engine.DecalComponent:GetFadeStartDelay
    static readonly IntPtr GetFadeStartDelay_NativeFunction;
    static readonly int GetFadeStartDelay_ParamsSize;
    static readonly int GetFadeStartDelay_ReturnValue_Offset;
    
    public float GetFadeStartDelay()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFadeStartDelay_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFadeStartDelay_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetFadeStartDelay_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DecalComponent:GetFadeInStartDelay
    static readonly IntPtr GetFadeInStartDelay_NativeFunction;
    static readonly int GetFadeInStartDelay_ParamsSize;
    static readonly int GetFadeInStartDelay_ReturnValue_Offset;
    
    public float GetFadeInStartDelay()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFadeInStartDelay_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFadeInStartDelay_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetFadeInStartDelay_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DecalComponent:GetFadeInDuration
    static readonly IntPtr GetFadeInDuration_NativeFunction;
    static readonly int GetFadeInDuration_ParamsSize;
    static readonly int GetFadeInDuration_ReturnValue_Offset;
    
    public float GetFadeInDuration()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFadeInDuration_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFadeInDuration_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetFadeInDuration_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DecalComponent:GetFadeDuration
    static readonly IntPtr GetFadeDuration_NativeFunction;
    static readonly int GetFadeDuration_ParamsSize;
    static readonly int GetFadeDuration_ReturnValue_Offset;
    
    public float GetFadeDuration()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFadeDuration_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFadeDuration_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetFadeDuration_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DecalComponent:GetDecalMaterial
    static readonly IntPtr GetDecalMaterial_NativeFunction;
    static readonly int GetDecalMaterial_ParamsSize;
    static readonly int GetDecalMaterial_ReturnValue_Offset;
    
    public UnrealSharp.Engine.MaterialInterface GetDecalMaterial()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDecalMaterial_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDecalMaterial_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.MaterialInterface returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(ParamsBuffer, GetDecalMaterial_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.DecalComponent:CreateDynamicMaterialInstance
    static readonly IntPtr CreateDynamicMaterialInstance_NativeFunction;
    static readonly int CreateDynamicMaterialInstance_ParamsSize;
    static readonly int CreateDynamicMaterialInstance_ReturnValue_Offset;
    
    public UnrealSharp.Engine.MaterialInstanceDynamic CreateDynamicMaterialInstance()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CreateDynamicMaterialInstance_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, CreateDynamicMaterialInstance_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.MaterialInstanceDynamic returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.MaterialInstanceDynamic>.FromNative(IntPtr.Add(ParamsBuffer, CreateDynamicMaterialInstance_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}