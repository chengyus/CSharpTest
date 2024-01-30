// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UClass]
public partial class InterchangeSpotLightNode : UnrealSharp.InterchangeNodes.InterchangePointLightNode
{
    
    static InterchangeSpotLightNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeSpotLightNode");
        
        
        SetCustomOuterConeAngle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomOuterConeAngle");
        SetCustomOuterConeAngle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomOuterConeAngle_NativeFunction);
        SetCustomOuterConeAngle_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomOuterConeAngle_NativeFunction, "AttributeValue");
        SetCustomOuterConeAngle_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomOuterConeAngle_NativeFunction, "ReturnValue");
        SetCustomInnerConeAngle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomInnerConeAngle");
        SetCustomInnerConeAngle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomInnerConeAngle_NativeFunction);
        SetCustomInnerConeAngle_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomInnerConeAngle_NativeFunction, "AttributeValue");
        SetCustomInnerConeAngle_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomInnerConeAngle_NativeFunction, "ReturnValue");
        GetCustomOuterConeAngle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomOuterConeAngle");
        GetCustomOuterConeAngle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomOuterConeAngle_NativeFunction);
        GetCustomOuterConeAngle_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomOuterConeAngle_NativeFunction, "AttributeValue");
        GetCustomOuterConeAngle_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomOuterConeAngle_NativeFunction, "ReturnValue");
        GetCustomInnerConeAngle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomInnerConeAngle");
        GetCustomInnerConeAngle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomInnerConeAngle_NativeFunction);
        GetCustomInnerConeAngle_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomInnerConeAngle_NativeFunction, "AttributeValue");
        GetCustomInnerConeAngle_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomInnerConeAngle_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeSpotLightNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeNodes.InterchangeSpotLightNode:SetCustomOuterConeAngle
    static readonly IntPtr SetCustomOuterConeAngle_NativeFunction;
    static readonly int SetCustomOuterConeAngle_ParamsSize;
    static readonly int SetCustomOuterConeAngle_AttributeValue_Offset;
    static readonly int SetCustomOuterConeAngle_ReturnValue_Offset;
    
    public bool SetCustomOuterConeAngle(float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomOuterConeAngle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomOuterConeAngle_AttributeValue_Offset), 0, null, attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomOuterConeAngle_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomOuterConeAngle_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSpotLightNode:SetCustomInnerConeAngle
    static readonly IntPtr SetCustomInnerConeAngle_NativeFunction;
    static readonly int SetCustomInnerConeAngle_ParamsSize;
    static readonly int SetCustomInnerConeAngle_AttributeValue_Offset;
    static readonly int SetCustomInnerConeAngle_ReturnValue_Offset;
    
    public bool SetCustomInnerConeAngle(float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomInnerConeAngle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomInnerConeAngle_AttributeValue_Offset), 0, null, attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomInnerConeAngle_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomInnerConeAngle_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSpotLightNode:GetCustomOuterConeAngle
    static readonly IntPtr GetCustomOuterConeAngle_NativeFunction;
    static readonly int GetCustomOuterConeAngle_ParamsSize;
    static readonly int GetCustomOuterConeAngle_AttributeValue_Offset;
    static readonly int GetCustomOuterConeAngle_ReturnValue_Offset;
    
    public bool GetCustomOuterConeAngle(out float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomOuterConeAngle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomOuterConeAngle_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomOuterConeAngle_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomOuterConeAngle_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSpotLightNode:GetCustomInnerConeAngle
    static readonly IntPtr GetCustomInnerConeAngle_NativeFunction;
    static readonly int GetCustomInnerConeAngle_ParamsSize;
    static readonly int GetCustomInnerConeAngle_AttributeValue_Offset;
    static readonly int GetCustomInnerConeAngle_ReturnValue_Offset;
    
    public bool GetCustomInnerConeAngle(out float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomInnerConeAngle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomInnerConeAngle_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomInnerConeAngle_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomInnerConeAngle_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}