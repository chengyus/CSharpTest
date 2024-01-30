// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UClass]
public partial class InterchangeMaterialInstanceNode : UnrealSharp.InterchangeCore.InterchangeBaseNode
{
    
    static InterchangeMaterialInstanceNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeMaterialInstanceNode");
        
        
        SetCustomParent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomParent");
        SetCustomParent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomParent_NativeFunction);
        SetCustomParent_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomParent_NativeFunction, "AttributeValue");
        SetCustomParent_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomParent_NativeFunction, "ReturnValue");
        GetVectorParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetVectorParameterValue");
        GetVectorParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetVectorParameterValue_NativeFunction);
        GetVectorParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVectorParameterValue_NativeFunction, "ParameterName");
        GetVectorParameterValue_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVectorParameterValue_NativeFunction, "AttributeValue");
        GetVectorParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVectorParameterValue_NativeFunction, "ReturnValue");
        GetTextureParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetTextureParameterValue");
        GetTextureParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetTextureParameterValue_NativeFunction);
        GetTextureParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTextureParameterValue_NativeFunction, "ParameterName");
        GetTextureParameterValue_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTextureParameterValue_NativeFunction, "AttributeValue");
        GetTextureParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTextureParameterValue_NativeFunction, "ReturnValue");
        GetStaticSwitchParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetStaticSwitchParameterValue");
        GetStaticSwitchParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetStaticSwitchParameterValue_NativeFunction);
        GetStaticSwitchParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStaticSwitchParameterValue_NativeFunction, "ParameterName");
        GetStaticSwitchParameterValue_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStaticSwitchParameterValue_NativeFunction, "AttributeValue");
        GetStaticSwitchParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStaticSwitchParameterValue_NativeFunction, "ReturnValue");
        GetScalarParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetScalarParameterValue");
        GetScalarParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetScalarParameterValue_NativeFunction);
        GetScalarParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetScalarParameterValue_NativeFunction, "ParameterName");
        GetScalarParameterValue_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetScalarParameterValue_NativeFunction, "AttributeValue");
        GetScalarParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetScalarParameterValue_NativeFunction, "ReturnValue");
        GetCustomParent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomParent");
        GetCustomParent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomParent_NativeFunction);
        GetCustomParent_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomParent_NativeFunction, "AttributeValue");
        GetCustomParent_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomParent_NativeFunction, "ReturnValue");
        AddVectorParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddVectorParameterValue");
        AddVectorParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddVectorParameterValue_NativeFunction);
        AddVectorParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddVectorParameterValue_NativeFunction, "ParameterName");
        AddVectorParameterValue_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddVectorParameterValue_NativeFunction, "AttributeValue");
        AddVectorParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddVectorParameterValue_NativeFunction, "ReturnValue");
        AddTextureParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddTextureParameterValue");
        AddTextureParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddTextureParameterValue_NativeFunction);
        AddTextureParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddTextureParameterValue_NativeFunction, "ParameterName");
        AddTextureParameterValue_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddTextureParameterValue_NativeFunction, "AttributeValue");
        AddTextureParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddTextureParameterValue_NativeFunction, "ReturnValue");
        AddStaticSwitchParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddStaticSwitchParameterValue");
        AddStaticSwitchParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddStaticSwitchParameterValue_NativeFunction);
        AddStaticSwitchParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddStaticSwitchParameterValue_NativeFunction, "ParameterName");
        AddStaticSwitchParameterValue_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddStaticSwitchParameterValue_NativeFunction, "AttributeValue");
        AddStaticSwitchParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddStaticSwitchParameterValue_NativeFunction, "ReturnValue");
        AddScalarParameterValue_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddScalarParameterValue");
        AddScalarParameterValue_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddScalarParameterValue_NativeFunction);
        AddScalarParameterValue_ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddScalarParameterValue_NativeFunction, "ParameterName");
        AddScalarParameterValue_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddScalarParameterValue_NativeFunction, "AttributeValue");
        AddScalarParameterValue_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddScalarParameterValue_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeMaterialInstanceNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:SetCustomParent
    static readonly IntPtr SetCustomParent_NativeFunction;
    static readonly int SetCustomParent_ParamsSize;
    static readonly int SetCustomParent_AttributeValue_Offset;
    static readonly int SetCustomParent_ReturnValue_Offset;
    
    public bool SetCustomParent(string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomParent_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,SetCustomParent_AttributeValue_Offset);
            StringMarshaller.ToNative(AttributeValue_NativePtr,0,null,attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomParent_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomParent_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:GetVectorParameterValue
    static readonly IntPtr GetVectorParameterValue_NativeFunction;
    static readonly int GetVectorParameterValue_ParamsSize;
    static readonly int GetVectorParameterValue_ParameterName_Offset;
    static readonly int GetVectorParameterValue_AttributeValue_Offset;
    static readonly int GetVectorParameterValue_ReturnValue_Offset;
    
    public bool GetVectorParameterValue(string parameterName, out UnrealSharp.CoreUObject.LinearColor attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetVectorParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ParameterName_NativePtr = IntPtr.Add(ParamsBuffer,GetVectorParameterValue_ParameterName_Offset);
            StringMarshaller.ToNative(ParameterName_NativePtr,0,null,parameterName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetVectorParameterValue_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(ParamsBuffer, GetVectorParameterValue_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetVectorParameterValue_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ParameterName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:GetTextureParameterValue
    static readonly IntPtr GetTextureParameterValue_NativeFunction;
    static readonly int GetTextureParameterValue_ParamsSize;
    static readonly int GetTextureParameterValue_ParameterName_Offset;
    static readonly int GetTextureParameterValue_AttributeValue_Offset;
    static readonly int GetTextureParameterValue_ReturnValue_Offset;
    
    public bool GetTextureParameterValue(string parameterName, out string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetTextureParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ParameterName_NativePtr = IntPtr.Add(ParamsBuffer,GetTextureParameterValue_ParameterName_Offset);
            StringMarshaller.ToNative(ParameterName_NativePtr,0,null,parameterName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetTextureParameterValue_NativeFunction, ParamsBuffer);
            
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,GetTextureParameterValue_AttributeValue_Offset);
            attributeValue = StringMarshaller.FromNative(AttributeValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetTextureParameterValue_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ParameterName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:GetStaticSwitchParameterValue
    static readonly IntPtr GetStaticSwitchParameterValue_NativeFunction;
    static readonly int GetStaticSwitchParameterValue_ParamsSize;
    static readonly int GetStaticSwitchParameterValue_ParameterName_Offset;
    static readonly int GetStaticSwitchParameterValue_AttributeValue_Offset;
    static readonly int GetStaticSwitchParameterValue_ReturnValue_Offset;
    
    public bool GetStaticSwitchParameterValue(string parameterName, out bool attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetStaticSwitchParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ParameterName_NativePtr = IntPtr.Add(ParamsBuffer,GetStaticSwitchParameterValue_ParameterName_Offset);
            StringMarshaller.ToNative(ParameterName_NativePtr,0,null,parameterName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetStaticSwitchParameterValue_NativeFunction, ParamsBuffer);
            
            attributeValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetStaticSwitchParameterValue_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetStaticSwitchParameterValue_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ParameterName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:GetScalarParameterValue
    static readonly IntPtr GetScalarParameterValue_NativeFunction;
    static readonly int GetScalarParameterValue_ParamsSize;
    static readonly int GetScalarParameterValue_ParameterName_Offset;
    static readonly int GetScalarParameterValue_AttributeValue_Offset;
    static readonly int GetScalarParameterValue_ReturnValue_Offset;
    
    public bool GetScalarParameterValue(string parameterName, out float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetScalarParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ParameterName_NativePtr = IntPtr.Add(ParamsBuffer,GetScalarParameterValue_ParameterName_Offset);
            StringMarshaller.ToNative(ParameterName_NativePtr,0,null,parameterName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetScalarParameterValue_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetScalarParameterValue_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetScalarParameterValue_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ParameterName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:GetCustomParent
    static readonly IntPtr GetCustomParent_NativeFunction;
    static readonly int GetCustomParent_ParamsSize;
    static readonly int GetCustomParent_AttributeValue_Offset;
    static readonly int GetCustomParent_ReturnValue_Offset;
    
    public bool GetCustomParent(out string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomParent_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomParent_NativeFunction, ParamsBuffer);
            
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,GetCustomParent_AttributeValue_Offset);
            attributeValue = StringMarshaller.FromNative(AttributeValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomParent_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:AddVectorParameterValue
    static readonly IntPtr AddVectorParameterValue_NativeFunction;
    static readonly int AddVectorParameterValue_ParamsSize;
    static readonly int AddVectorParameterValue_ParameterName_Offset;
    static readonly int AddVectorParameterValue_AttributeValue_Offset;
    static readonly int AddVectorParameterValue_ReturnValue_Offset;
    
    public bool AddVectorParameterValue(string parameterName, UnrealSharp.CoreUObject.LinearColor attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddVectorParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ParameterName_NativePtr = IntPtr.Add(ParamsBuffer,AddVectorParameterValue_ParameterName_Offset);
            StringMarshaller.ToNative(ParameterName_NativePtr,0,null,parameterName);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(ParamsBuffer, AddVectorParameterValue_AttributeValue_Offset), 0, null, attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddVectorParameterValue_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AddVectorParameterValue_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ParameterName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:AddTextureParameterValue
    static readonly IntPtr AddTextureParameterValue_NativeFunction;
    static readonly int AddTextureParameterValue_ParamsSize;
    static readonly int AddTextureParameterValue_ParameterName_Offset;
    static readonly int AddTextureParameterValue_AttributeValue_Offset;
    static readonly int AddTextureParameterValue_ReturnValue_Offset;
    
    public bool AddTextureParameterValue(string parameterName, string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddTextureParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ParameterName_NativePtr = IntPtr.Add(ParamsBuffer,AddTextureParameterValue_ParameterName_Offset);
            StringMarshaller.ToNative(ParameterName_NativePtr,0,null,parameterName);
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,AddTextureParameterValue_AttributeValue_Offset);
            StringMarshaller.ToNative(AttributeValue_NativePtr,0,null,attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddTextureParameterValue_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AddTextureParameterValue_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ParameterName_NativePtr, 0);
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:AddStaticSwitchParameterValue
    static readonly IntPtr AddStaticSwitchParameterValue_NativeFunction;
    static readonly int AddStaticSwitchParameterValue_ParamsSize;
    static readonly int AddStaticSwitchParameterValue_ParameterName_Offset;
    static readonly int AddStaticSwitchParameterValue_AttributeValue_Offset;
    static readonly int AddStaticSwitchParameterValue_ReturnValue_Offset;
    
    public bool AddStaticSwitchParameterValue(string parameterName, bool attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddStaticSwitchParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ParameterName_NativePtr = IntPtr.Add(ParamsBuffer,AddStaticSwitchParameterValue_ParameterName_Offset);
            StringMarshaller.ToNative(ParameterName_NativePtr,0,null,parameterName);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddStaticSwitchParameterValue_AttributeValue_Offset), 0, null, attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddStaticSwitchParameterValue_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AddStaticSwitchParameterValue_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ParameterName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeMaterialInstanceNode:AddScalarParameterValue
    static readonly IntPtr AddScalarParameterValue_NativeFunction;
    static readonly int AddScalarParameterValue_ParamsSize;
    static readonly int AddScalarParameterValue_ParameterName_Offset;
    static readonly int AddScalarParameterValue_AttributeValue_Offset;
    static readonly int AddScalarParameterValue_ReturnValue_Offset;
    
    public bool AddScalarParameterValue(string parameterName, float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddScalarParameterValue_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ParameterName_NativePtr = IntPtr.Add(ParamsBuffer,AddScalarParameterValue_ParameterName_Offset);
            StringMarshaller.ToNative(ParameterName_NativePtr,0,null,parameterName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, AddScalarParameterValue_AttributeValue_Offset), 0, null, attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddScalarParameterValue_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AddScalarParameterValue_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(ParameterName_NativePtr, 0);
            return returnValue;
        }
    }
    
    
}