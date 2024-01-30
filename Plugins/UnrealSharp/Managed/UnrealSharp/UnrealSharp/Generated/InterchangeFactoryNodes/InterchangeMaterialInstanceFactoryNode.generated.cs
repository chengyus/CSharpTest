// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeFactoryNodes;

[UClass]
public partial class InterchangeMaterialInstanceFactoryNode : UnrealSharp.InterchangeFactoryNodes.InterchangeBaseMaterialFactoryNode
{
    
    static InterchangeMaterialInstanceFactoryNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeMaterialInstanceFactoryNode");
        
        
        SetCustomParent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomParent");
        SetCustomParent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomParent_NativeFunction);
        SetCustomParent_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomParent_NativeFunction, "AttributeValue");
        SetCustomParent_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomParent_NativeFunction, "ReturnValue");
        SetCustomInstanceClassName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomInstanceClassName");
        SetCustomInstanceClassName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomInstanceClassName_NativeFunction);
        SetCustomInstanceClassName_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomInstanceClassName_NativeFunction, "AttributeValue");
        SetCustomInstanceClassName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomInstanceClassName_NativeFunction, "ReturnValue");
        GetCustomParent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomParent");
        GetCustomParent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomParent_NativeFunction);
        GetCustomParent_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomParent_NativeFunction, "AttributeValue");
        GetCustomParent_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomParent_NativeFunction, "ReturnValue");
        GetCustomInstanceClassName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomInstanceClassName");
        GetCustomInstanceClassName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomInstanceClassName_NativeFunction);
        GetCustomInstanceClassName_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomInstanceClassName_NativeFunction, "AttributeValue");
        GetCustomInstanceClassName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomInstanceClassName_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeMaterialInstanceFactoryNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeFactoryNodes.InterchangeMaterialInstanceFactoryNode:SetCustomParent
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
    
    // Function /Script/InterchangeFactoryNodes.InterchangeMaterialInstanceFactoryNode:SetCustomInstanceClassName
    static readonly IntPtr SetCustomInstanceClassName_NativeFunction;
    static readonly int SetCustomInstanceClassName_ParamsSize;
    static readonly int SetCustomInstanceClassName_AttributeValue_Offset;
    static readonly int SetCustomInstanceClassName_ReturnValue_Offset;
    
    public bool SetCustomInstanceClassName(string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomInstanceClassName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,SetCustomInstanceClassName_AttributeValue_Offset);
            StringMarshaller.ToNative(AttributeValue_NativePtr,0,null,attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomInstanceClassName_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomInstanceClassName_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangeMaterialInstanceFactoryNode:GetCustomParent
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
    
    // Function /Script/InterchangeFactoryNodes.InterchangeMaterialInstanceFactoryNode:GetCustomInstanceClassName
    static readonly IntPtr GetCustomInstanceClassName_NativeFunction;
    static readonly int GetCustomInstanceClassName_ParamsSize;
    static readonly int GetCustomInstanceClassName_AttributeValue_Offset;
    static readonly int GetCustomInstanceClassName_ReturnValue_Offset;
    
    public bool GetCustomInstanceClassName(out string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomInstanceClassName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomInstanceClassName_NativeFunction, ParamsBuffer);
            
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,GetCustomInstanceClassName_AttributeValue_Offset);
            attributeValue = StringMarshaller.FromNative(AttributeValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomInstanceClassName_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}