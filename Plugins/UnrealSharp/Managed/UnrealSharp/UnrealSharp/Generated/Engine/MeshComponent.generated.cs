// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
abstract public partial class MeshComponent : UnrealSharp.Engine.PrimitiveComponent
{
    
    static MeshComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MeshComponent");
        
        OverlayMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverlayMaterial");
        OverlayMaterialMaxDrawDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverlayMaterialMaxDrawDistance");
        bEnableMaterialParameterCaching_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableMaterialParameterCaching");
        bEnableMaterialParameterCaching_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnableMaterialParameterCaching");
        
        SetVectorParameterValueOnMaterials_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetVectorParameterValueOnMaterials");
        SetVectorParameterValueOnMaterials_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetVectorParameterValueOnMaterials_NativeFunction);
        SetVectorParameterValueOnMaterials_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVectorParameterValueOnMaterials_NativeFunction, "ParameterName");
        SetVectorParameterValueOnMaterials_ParameterValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVectorParameterValueOnMaterials_NativeFunction, "ParameterValue");
        SetScalarParameterValueOnMaterials_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetScalarParameterValueOnMaterials");
        SetScalarParameterValueOnMaterials_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetScalarParameterValueOnMaterials_NativeFunction);
        SetScalarParameterValueOnMaterials_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetScalarParameterValueOnMaterials_NativeFunction, "ParameterName");
        SetScalarParameterValueOnMaterials_ParameterValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetScalarParameterValueOnMaterials_NativeFunction, "ParameterValue");
        SetOverlayMaterialMaxDrawDistance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOverlayMaterialMaxDrawDistance");
        SetOverlayMaterialMaxDrawDistance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOverlayMaterialMaxDrawDistance_NativeFunction);
        SetOverlayMaterialMaxDrawDistance_InMaxDrawDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOverlayMaterialMaxDrawDistance_NativeFunction, "InMaxDrawDistance");
        SetOverlayMaterial_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOverlayMaterial");
        SetOverlayMaterial_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOverlayMaterial_NativeFunction);
        SetOverlayMaterial_NewOverlayMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOverlayMaterial_NativeFunction, "NewOverlayMaterial");
        PrestreamTextures_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "PrestreamTextures");
        PrestreamTextures_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(PrestreamTextures_NativeFunction);
        PrestreamTextures_Seconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PrestreamTextures_NativeFunction, "Seconds");
        PrestreamTextures_bPrioritizeCharacterTextures_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PrestreamTextures_NativeFunction, "bPrioritizeCharacterTextures");
        PrestreamTextures_CinematicTextureGroups_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PrestreamTextures_NativeFunction, "CinematicTextureGroups");
        IsMaterialSlotNameValid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsMaterialSlotNameValid");
        IsMaterialSlotNameValid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsMaterialSlotNameValid_NativeFunction);
        IsMaterialSlotNameValid_MaterialSlotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsMaterialSlotNameValid_NativeFunction, "MaterialSlotName");
        IsMaterialSlotNameValid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsMaterialSlotNameValid_NativeFunction, "ReturnValue");
        GetOverlayMaterialMaxDrawDistance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOverlayMaterialMaxDrawDistance");
        GetOverlayMaterialMaxDrawDistance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOverlayMaterialMaxDrawDistance_NativeFunction);
        GetOverlayMaterialMaxDrawDistance_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOverlayMaterialMaxDrawDistance_NativeFunction, "ReturnValue");
        GetOverlayMaterial_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOverlayMaterial");
        GetOverlayMaterial_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOverlayMaterial_NativeFunction);
        GetOverlayMaterial_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOverlayMaterial_NativeFunction, "ReturnValue");
        GetMaterialSlotNames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMaterialSlotNames");
        GetMaterialSlotNames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMaterialSlotNames_NativeFunction);
        GetMaterialSlotNames_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMaterialSlotNames_NativeFunction, "ReturnValue");
        GetMaterialSlotNames_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetMaterialSlotNames_NativeFunction, "ReturnValue");
        GetMaterials_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMaterials");
        GetMaterials_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMaterials_NativeFunction);
        GetMaterials_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMaterials_NativeFunction, "ReturnValue");
        GetMaterials_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetMaterials_NativeFunction, "ReturnValue");
        GetMaterialIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMaterialIndex");
        GetMaterialIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMaterialIndex_NativeFunction);
        GetMaterialIndex_MaterialSlotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMaterialIndex_NativeFunction, "MaterialSlotName");
        GetMaterialIndex_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMaterialIndex_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MeshComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.MeshComponent:OverlayMaterial
    static readonly int OverlayMaterial_Offset;
    
    public UnrealSharp.Engine.MaterialInterface OverlayMaterial
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(NativeObject, OverlayMaterial_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.MeshComponent:OverlayMaterialMaxDrawDistance
    static readonly int OverlayMaterialMaxDrawDistance_Offset;
    
    public float OverlayMaterialMaxDrawDistance
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, OverlayMaterialMaxDrawDistance_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.MeshComponent:bEnableMaterialParameterCaching
    static readonly int bEnableMaterialParameterCaching_Offset;
    static readonly IntPtr bEnableMaterialParameterCaching_NativeProperty;
    
    public bool bEnableMaterialParameterCaching
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bEnableMaterialParameterCaching_NativeProperty, bEnableMaterialParameterCaching_Offset);
        }
    }
    
    // Function /Script/Engine.MeshComponent:SetVectorParameterValueOnMaterials
    static readonly IntPtr SetVectorParameterValueOnMaterials_NativeFunction;
    static readonly int SetVectorParameterValueOnMaterials_ParamsSize;
    static readonly int SetVectorParameterValueOnMaterials_ParameterName_Offset;
    static readonly int SetVectorParameterValueOnMaterials_ParameterValue_Offset;
    
    public void SetVectorParameterValueOnMaterials(Name parameterName, System.DoubleNumerics.Vector3 parameterValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetVectorParameterValueOnMaterials_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetVectorParameterValueOnMaterials_ParameterName_Offset), 0, null, parameterName);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, SetVectorParameterValueOnMaterials_ParameterValue_Offset), 0, null, parameterValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetVectorParameterValueOnMaterials_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.MeshComponent:SetScalarParameterValueOnMaterials
    static readonly IntPtr SetScalarParameterValueOnMaterials_NativeFunction;
    static readonly int SetScalarParameterValueOnMaterials_ParamsSize;
    static readonly int SetScalarParameterValueOnMaterials_ParameterName_Offset;
    static readonly int SetScalarParameterValueOnMaterials_ParameterValue_Offset;
    
    public void SetScalarParameterValueOnMaterials(Name parameterName, float parameterValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetScalarParameterValueOnMaterials_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetScalarParameterValueOnMaterials_ParameterName_Offset), 0, null, parameterName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetScalarParameterValueOnMaterials_ParameterValue_Offset), 0, null, parameterValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetScalarParameterValueOnMaterials_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.MeshComponent:SetOverlayMaterialMaxDrawDistance
    static readonly IntPtr SetOverlayMaterialMaxDrawDistance_NativeFunction;
    static readonly int SetOverlayMaterialMaxDrawDistance_ParamsSize;
    static readonly int SetOverlayMaterialMaxDrawDistance_InMaxDrawDistance_Offset;
    
    public void SetOverlayMaterialMaxDrawDistance(float inMaxDrawDistance)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOverlayMaterialMaxDrawDistance_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetOverlayMaterialMaxDrawDistance_InMaxDrawDistance_Offset), 0, null, inMaxDrawDistance);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOverlayMaterialMaxDrawDistance_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.MeshComponent:SetOverlayMaterial
    static readonly IntPtr SetOverlayMaterial_NativeFunction;
    static readonly int SetOverlayMaterial_ParamsSize;
    static readonly int SetOverlayMaterial_NewOverlayMaterial_Offset;
    
    public void SetOverlayMaterial(UnrealSharp.Engine.MaterialInterface newOverlayMaterial)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOverlayMaterial_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative(IntPtr.Add(ParamsBuffer, SetOverlayMaterial_NewOverlayMaterial_Offset), 0, null, newOverlayMaterial);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOverlayMaterial_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.MeshComponent:PrestreamTextures
    static readonly IntPtr PrestreamTextures_NativeFunction;
    static readonly int PrestreamTextures_ParamsSize;
    static readonly int PrestreamTextures_Seconds_Offset;
    static readonly int PrestreamTextures_bPrioritizeCharacterTextures_Offset;
    static readonly int PrestreamTextures_CinematicTextureGroups_Offset;
    
    public void PrestreamTextures(float seconds, bool bPrioritizeCharacterTextures, int cinematicTextureGroups = 0)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[PrestreamTextures_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, PrestreamTextures_Seconds_Offset), 0, null, seconds);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, PrestreamTextures_bPrioritizeCharacterTextures_Offset), 0, null, bPrioritizeCharacterTextures);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, PrestreamTextures_CinematicTextureGroups_Offset), 0, null, cinematicTextureGroups);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, PrestreamTextures_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.MeshComponent:IsMaterialSlotNameValid
    static readonly IntPtr IsMaterialSlotNameValid_NativeFunction;
    static readonly int IsMaterialSlotNameValid_ParamsSize;
    static readonly int IsMaterialSlotNameValid_MaterialSlotName_Offset;
    static readonly int IsMaterialSlotNameValid_ReturnValue_Offset;
    
    public bool IsMaterialSlotNameValid(Name materialSlotName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsMaterialSlotNameValid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, IsMaterialSlotNameValid_MaterialSlotName_Offset), 0, null, materialSlotName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsMaterialSlotNameValid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsMaterialSlotNameValid_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.MeshComponent:GetOverlayMaterialMaxDrawDistance
    static readonly IntPtr GetOverlayMaterialMaxDrawDistance_NativeFunction;
    static readonly int GetOverlayMaterialMaxDrawDistance_ParamsSize;
    static readonly int GetOverlayMaterialMaxDrawDistance_ReturnValue_Offset;
    
    public float GetOverlayMaterialMaxDrawDistance()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetOverlayMaterialMaxDrawDistance_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOverlayMaterialMaxDrawDistance_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetOverlayMaterialMaxDrawDistance_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.MeshComponent:GetOverlayMaterial
    static readonly IntPtr GetOverlayMaterial_NativeFunction;
    static readonly int GetOverlayMaterial_ParamsSize;
    static readonly int GetOverlayMaterial_ReturnValue_Offset;
    
    public UnrealSharp.Engine.MaterialInterface GetOverlayMaterial()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetOverlayMaterial_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOverlayMaterial_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.MaterialInterface returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(ParamsBuffer, GetOverlayMaterial_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.MeshComponent:GetMaterialSlotNames
    static readonly IntPtr GetMaterialSlotNames_NativeFunction;
    static readonly int GetMaterialSlotNames_ParamsSize;
    static readonly int GetMaterialSlotNames_ReturnValue_Offset;
    static readonly int GetMaterialSlotNames_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<Name> GetMaterialSlotNames()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMaterialSlotNames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMaterialSlotNames_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<Name> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetMaterialSlotNames_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<Name> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<Name> (1, BlittableMarshaller<Name>.ToNative, BlittableMarshaller<Name>.FromNative, GetMaterialSlotNames_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<Name>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.MeshComponent:GetMaterials
    static readonly IntPtr GetMaterials_NativeFunction;
    static readonly int GetMaterials_ParamsSize;
    static readonly int GetMaterials_ReturnValue_Offset;
    static readonly int GetMaterials_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<UnrealSharp.Engine.MaterialInterface> GetMaterials()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMaterials_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMaterials_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.Engine.MaterialInterface> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetMaterials_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.MaterialInterface> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.Engine.MaterialInterface> (1, ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.ToNative, ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative, GetMaterials_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.Engine.MaterialInterface>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.MeshComponent:GetMaterialIndex
    static readonly IntPtr GetMaterialIndex_NativeFunction;
    static readonly int GetMaterialIndex_ParamsSize;
    static readonly int GetMaterialIndex_MaterialSlotName_Offset;
    static readonly int GetMaterialIndex_ReturnValue_Offset;
    
    public int GetMaterialIndex(Name materialSlotName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMaterialIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, GetMaterialIndex_MaterialSlotName_Offset), 0, null, materialSlotName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMaterialIndex_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetMaterialIndex_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}