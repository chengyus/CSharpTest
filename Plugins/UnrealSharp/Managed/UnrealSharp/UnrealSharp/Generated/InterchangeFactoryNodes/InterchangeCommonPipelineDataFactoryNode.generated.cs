// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeFactoryNodes;

[UClass]
public partial class InterchangeCommonPipelineDataFactoryNode : UnrealSharp.InterchangeCore.InterchangeFactoryBaseNode
{
    
    static InterchangeCommonPipelineDataFactoryNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeCommonPipelineDataFactoryNode");
        
        
        SetCustomGlobalOffsetTransform_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomGlobalOffsetTransform");
        SetCustomGlobalOffsetTransform_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomGlobalOffsetTransform_NativeFunction);
        SetCustomGlobalOffsetTransform_NodeContainer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomGlobalOffsetTransform_NativeFunction, "NodeContainer");
        SetCustomGlobalOffsetTransform_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomGlobalOffsetTransform_NativeFunction, "AttributeValue");
        SetCustomGlobalOffsetTransform_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomGlobalOffsetTransform_NativeFunction, "ReturnValue");
        SetBakeMeshes_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBakeMeshes");
        SetBakeMeshes_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBakeMeshes_NativeFunction);
        SetBakeMeshes_NodeContainer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBakeMeshes_NativeFunction, "NodeContainer");
        SetBakeMeshes_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBakeMeshes_NativeFunction, "AttributeValue");
        SetBakeMeshes_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBakeMeshes_NativeFunction, "ReturnValue");
        GetCustomGlobalOffsetTransform_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomGlobalOffsetTransform");
        GetCustomGlobalOffsetTransform_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomGlobalOffsetTransform_NativeFunction);
        GetCustomGlobalOffsetTransform_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomGlobalOffsetTransform_NativeFunction, "AttributeValue");
        GetCustomGlobalOffsetTransform_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomGlobalOffsetTransform_NativeFunction, "ReturnValue");
        GetBakeMeshes_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetBakeMeshes");
        GetBakeMeshes_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetBakeMeshes_NativeFunction);
        GetBakeMeshes_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBakeMeshes_NativeFunction, "AttributeValue");
        GetBakeMeshes_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBakeMeshes_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeCommonPipelineDataFactoryNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeFactoryNodes.InterchangeCommonPipelineDataFactoryNode:SetCustomGlobalOffsetTransform
    static readonly IntPtr SetCustomGlobalOffsetTransform_NativeFunction;
    static readonly int SetCustomGlobalOffsetTransform_ParamsSize;
    static readonly int SetCustomGlobalOffsetTransform_NodeContainer_Offset;
    static readonly int SetCustomGlobalOffsetTransform_AttributeValue_Offset;
    static readonly int SetCustomGlobalOffsetTransform_ReturnValue_Offset;
    
    public bool SetCustomGlobalOffsetTransform(UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer nodeContainer, UnrealSharp.Transform attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomGlobalOffsetTransform_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomGlobalOffsetTransform_NodeContainer_Offset), 0, null, nodeContainer);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomGlobalOffsetTransform_AttributeValue_Offset), 0, null, attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomGlobalOffsetTransform_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomGlobalOffsetTransform_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangeCommonPipelineDataFactoryNode:SetBakeMeshes
    static readonly IntPtr SetBakeMeshes_NativeFunction;
    static readonly int SetBakeMeshes_ParamsSize;
    static readonly int SetBakeMeshes_NodeContainer_Offset;
    static readonly int SetBakeMeshes_AttributeValue_Offset;
    static readonly int SetBakeMeshes_ReturnValue_Offset;
    
    public bool SetBakeMeshes(UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer nodeContainer, bool attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBakeMeshes_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeBaseNodeContainer>.ToNative(IntPtr.Add(ParamsBuffer, SetBakeMeshes_NodeContainer_Offset), 0, null, nodeContainer);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetBakeMeshes_AttributeValue_Offset), 0, null, attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBakeMeshes_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetBakeMeshes_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangeCommonPipelineDataFactoryNode:GetCustomGlobalOffsetTransform
    static readonly IntPtr GetCustomGlobalOffsetTransform_NativeFunction;
    static readonly int GetCustomGlobalOffsetTransform_ParamsSize;
    static readonly int GetCustomGlobalOffsetTransform_AttributeValue_Offset;
    static readonly int GetCustomGlobalOffsetTransform_ReturnValue_Offset;
    
    public bool GetCustomGlobalOffsetTransform(out UnrealSharp.Transform attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomGlobalOffsetTransform_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomGlobalOffsetTransform_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomGlobalOffsetTransform_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomGlobalOffsetTransform_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangeCommonPipelineDataFactoryNode:GetBakeMeshes
    static readonly IntPtr GetBakeMeshes_NativeFunction;
    static readonly int GetBakeMeshes_ParamsSize;
    static readonly int GetBakeMeshes_AttributeValue_Offset;
    static readonly int GetBakeMeshes_ReturnValue_Offset;
    
    public bool GetBakeMeshes(out bool attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetBakeMeshes_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetBakeMeshes_NativeFunction, ParamsBuffer);
            
            attributeValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetBakeMeshes_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetBakeMeshes_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}