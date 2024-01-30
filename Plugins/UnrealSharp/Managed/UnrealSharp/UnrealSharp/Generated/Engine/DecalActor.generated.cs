// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class DecalActor : UnrealSharp.Engine.Actor
{
    
    static DecalActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("DecalActor");
        
        Decal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Decal");
        
        SetDecalMaterial_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDecalMaterial");
        SetDecalMaterial_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDecalMaterial_NativeFunction);
        SetDecalMaterial_NewDecalMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDecalMaterial_NativeFunction, "NewDecalMaterial");
        GetDecalMaterial_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDecalMaterial");
        GetDecalMaterial_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDecalMaterial_NativeFunction);
        GetDecalMaterial_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDecalMaterial_NativeFunction, "ReturnValue");
        CreateDynamicMaterialInstance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CreateDynamicMaterialInstance");
        CreateDynamicMaterialInstance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CreateDynamicMaterialInstance_NativeFunction);
        CreateDynamicMaterialInstance_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateDynamicMaterialInstance_NativeFunction, "ReturnValue");
        
        
    }
    
    protected DecalActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.DecalActor:Decal
    static readonly int Decal_Offset;
    
    public UnrealSharp.Engine.DecalComponent Decal
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.DecalComponent>.FromNative(IntPtr.Add(NativeObject, Decal_Offset), 0, this);
        }
    }
    
    // Function /Script/Engine.DecalActor:SetDecalMaterial
    static readonly IntPtr SetDecalMaterial_NativeFunction;
    static readonly int SetDecalMaterial_ParamsSize;
    static readonly int SetDecalMaterial_NewDecalMaterial_Offset;
    
    [Obsolete("This function is obsolete")]
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
    
    // Function /Script/Engine.DecalActor:GetDecalMaterial
    static readonly IntPtr GetDecalMaterial_NativeFunction;
    static readonly int GetDecalMaterial_ParamsSize;
    static readonly int GetDecalMaterial_ReturnValue_Offset;
    
    [Obsolete("This function is obsolete")]
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
    
    // Function /Script/Engine.DecalActor:CreateDynamicMaterialInstance
    static readonly IntPtr CreateDynamicMaterialInstance_NativeFunction;
    static readonly int CreateDynamicMaterialInstance_ParamsSize;
    static readonly int CreateDynamicMaterialInstance_ReturnValue_Offset;
    
    [Obsolete("This function is obsolete")]
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