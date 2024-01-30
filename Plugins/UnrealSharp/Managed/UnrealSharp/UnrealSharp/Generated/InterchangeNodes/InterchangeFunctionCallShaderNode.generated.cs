// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UClass]
public partial class InterchangeFunctionCallShaderNode : UnrealSharp.InterchangeNodes.InterchangeShaderNode
{
    
    static InterchangeFunctionCallShaderNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeFunctionCallShaderNode");
        
        
        SetCustomMaterialFunction_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomMaterialFunction");
        SetCustomMaterialFunction_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomMaterialFunction_NativeFunction);
        SetCustomMaterialFunction_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomMaterialFunction_NativeFunction, "AttributeValue");
        SetCustomMaterialFunction_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomMaterialFunction_NativeFunction, "ReturnValue");
        GetCustomMaterialFunction_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomMaterialFunction");
        GetCustomMaterialFunction_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomMaterialFunction_NativeFunction);
        GetCustomMaterialFunction_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomMaterialFunction_NativeFunction, "AttributeValue");
        GetCustomMaterialFunction_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomMaterialFunction_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeFunctionCallShaderNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeNodes.InterchangeFunctionCallShaderNode:SetCustomMaterialFunction
    static readonly IntPtr SetCustomMaterialFunction_NativeFunction;
    static readonly int SetCustomMaterialFunction_ParamsSize;
    static readonly int SetCustomMaterialFunction_AttributeValue_Offset;
    static readonly int SetCustomMaterialFunction_ReturnValue_Offset;
    
    public bool SetCustomMaterialFunction(string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomMaterialFunction_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,SetCustomMaterialFunction_AttributeValue_Offset);
            StringMarshaller.ToNative(AttributeValue_NativePtr,0,null,attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomMaterialFunction_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomMaterialFunction_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeFunctionCallShaderNode:GetCustomMaterialFunction
    static readonly IntPtr GetCustomMaterialFunction_NativeFunction;
    static readonly int GetCustomMaterialFunction_ParamsSize;
    static readonly int GetCustomMaterialFunction_AttributeValue_Offset;
    static readonly int GetCustomMaterialFunction_ReturnValue_Offset;
    
    public bool GetCustomMaterialFunction(out string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomMaterialFunction_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomMaterialFunction_NativeFunction, ParamsBuffer);
            
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,GetCustomMaterialFunction_AttributeValue_Offset);
            attributeValue = StringMarshaller.FromNative(AttributeValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomMaterialFunction_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}