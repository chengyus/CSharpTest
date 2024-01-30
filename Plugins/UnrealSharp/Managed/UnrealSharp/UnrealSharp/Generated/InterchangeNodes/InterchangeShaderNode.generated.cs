// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UClass]
public partial class InterchangeShaderNode : UnrealSharp.InterchangeCore.InterchangeBaseNode
{
    
    static InterchangeShaderNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeShaderNode");
        
        
        SetCustomShaderType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomShaderType");
        SetCustomShaderType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomShaderType_NativeFunction);
        SetCustomShaderType_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomShaderType_NativeFunction, "AttributeValue");
        SetCustomShaderType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomShaderType_NativeFunction, "ReturnValue");
        GetCustomShaderType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomShaderType");
        GetCustomShaderType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomShaderType_NativeFunction);
        GetCustomShaderType_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomShaderType_NativeFunction, "AttributeValue");
        GetCustomShaderType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomShaderType_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeShaderNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeNodes.InterchangeShaderNode:SetCustomShaderType
    static readonly IntPtr SetCustomShaderType_NativeFunction;
    static readonly int SetCustomShaderType_ParamsSize;
    static readonly int SetCustomShaderType_AttributeValue_Offset;
    static readonly int SetCustomShaderType_ReturnValue_Offset;
    
    public bool SetCustomShaderType(string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomShaderType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,SetCustomShaderType_AttributeValue_Offset);
            StringMarshaller.ToNative(AttributeValue_NativePtr,0,null,attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomShaderType_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomShaderType_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeShaderNode:GetCustomShaderType
    static readonly IntPtr GetCustomShaderType_NativeFunction;
    static readonly int GetCustomShaderType_ParamsSize;
    static readonly int GetCustomShaderType_AttributeValue_Offset;
    static readonly int GetCustomShaderType_ReturnValue_Offset;
    
    public bool GetCustomShaderType(out string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomShaderType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomShaderType_NativeFunction, ParamsBuffer);
            
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,GetCustomShaderType_AttributeValue_Offset);
            attributeValue = StringMarshaller.FromNative(AttributeValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomShaderType_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}