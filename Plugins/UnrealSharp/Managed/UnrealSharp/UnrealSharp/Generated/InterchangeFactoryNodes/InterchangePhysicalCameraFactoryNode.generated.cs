// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeFactoryNodes;

[UClass]
public partial class InterchangePhysicalCameraFactoryNode : UnrealSharp.InterchangeFactoryNodes.InterchangeActorFactoryNode
{
    
    static InterchangePhysicalCameraFactoryNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangePhysicalCameraFactoryNode");
        
        
        SetCustomSensorWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomSensorWidth");
        SetCustomSensorWidth_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomSensorWidth_NativeFunction);
        SetCustomSensorWidth_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomSensorWidth_NativeFunction, "AttributeValue");
        SetCustomSensorWidth_bAddApplyDelegate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomSensorWidth_NativeFunction, "bAddApplyDelegate");
        SetCustomSensorWidth_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomSensorWidth_NativeFunction, "ReturnValue");
        SetCustomSensorHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomSensorHeight");
        SetCustomSensorHeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomSensorHeight_NativeFunction);
        SetCustomSensorHeight_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomSensorHeight_NativeFunction, "AttributeValue");
        SetCustomSensorHeight_bAddApplyDelegate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomSensorHeight_NativeFunction, "bAddApplyDelegate");
        SetCustomSensorHeight_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomSensorHeight_NativeFunction, "ReturnValue");
        SetCustomFocusMethod_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomFocusMethod");
        SetCustomFocusMethod_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomFocusMethod_NativeFunction);
        SetCustomFocusMethod_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomFocusMethod_NativeFunction, "AttributeValue");
        SetCustomFocusMethod_bAddApplyDelegate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomFocusMethod_NativeFunction, "bAddApplyDelegate");
        SetCustomFocusMethod_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomFocusMethod_NativeFunction, "ReturnValue");
        SetCustomFocalLength_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomFocalLength");
        SetCustomFocalLength_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomFocalLength_NativeFunction);
        SetCustomFocalLength_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomFocalLength_NativeFunction, "AttributeValue");
        SetCustomFocalLength_bAddApplyDelegate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomFocalLength_NativeFunction, "bAddApplyDelegate");
        SetCustomFocalLength_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomFocalLength_NativeFunction, "ReturnValue");
        GetCustomSensorWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomSensorWidth");
        GetCustomSensorWidth_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomSensorWidth_NativeFunction);
        GetCustomSensorWidth_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomSensorWidth_NativeFunction, "AttributeValue");
        GetCustomSensorWidth_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomSensorWidth_NativeFunction, "ReturnValue");
        GetCustomSensorHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomSensorHeight");
        GetCustomSensorHeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomSensorHeight_NativeFunction);
        GetCustomSensorHeight_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomSensorHeight_NativeFunction, "AttributeValue");
        GetCustomSensorHeight_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomSensorHeight_NativeFunction, "ReturnValue");
        GetCustomFocusMethod_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomFocusMethod");
        GetCustomFocusMethod_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomFocusMethod_NativeFunction);
        GetCustomFocusMethod_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomFocusMethod_NativeFunction, "AttributeValue");
        GetCustomFocusMethod_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomFocusMethod_NativeFunction, "ReturnValue");
        GetCustomFocalLength_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomFocalLength");
        GetCustomFocalLength_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomFocalLength_NativeFunction);
        GetCustomFocalLength_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomFocalLength_NativeFunction, "AttributeValue");
        GetCustomFocalLength_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomFocalLength_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangePhysicalCameraFactoryNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeFactoryNodes.InterchangePhysicalCameraFactoryNode:SetCustomSensorWidth
    static readonly IntPtr SetCustomSensorWidth_NativeFunction;
    static readonly int SetCustomSensorWidth_ParamsSize;
    static readonly int SetCustomSensorWidth_AttributeValue_Offset;
    static readonly int SetCustomSensorWidth_bAddApplyDelegate_Offset;
    static readonly int SetCustomSensorWidth_ReturnValue_Offset;
    
    public bool SetCustomSensorWidth(float attributeValue, bool bAddApplyDelegate = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomSensorWidth_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomSensorWidth_AttributeValue_Offset), 0, null, attributeValue);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetCustomSensorWidth_bAddApplyDelegate_Offset), 0, null, bAddApplyDelegate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomSensorWidth_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomSensorWidth_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangePhysicalCameraFactoryNode:SetCustomSensorHeight
    static readonly IntPtr SetCustomSensorHeight_NativeFunction;
    static readonly int SetCustomSensorHeight_ParamsSize;
    static readonly int SetCustomSensorHeight_AttributeValue_Offset;
    static readonly int SetCustomSensorHeight_bAddApplyDelegate_Offset;
    static readonly int SetCustomSensorHeight_ReturnValue_Offset;
    
    public bool SetCustomSensorHeight(float attributeValue, bool bAddApplyDelegate = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomSensorHeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomSensorHeight_AttributeValue_Offset), 0, null, attributeValue);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetCustomSensorHeight_bAddApplyDelegate_Offset), 0, null, bAddApplyDelegate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomSensorHeight_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomSensorHeight_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangePhysicalCameraFactoryNode:SetCustomFocusMethod
    static readonly IntPtr SetCustomFocusMethod_NativeFunction;
    static readonly int SetCustomFocusMethod_ParamsSize;
    static readonly int SetCustomFocusMethod_AttributeValue_Offset;
    static readonly int SetCustomFocusMethod_bAddApplyDelegate_Offset;
    static readonly int SetCustomFocusMethod_ReturnValue_Offset;
    
    public bool SetCustomFocusMethod(UnrealSharp.CinematicCamera.ECameraFocusMethod attributeValue, bool bAddApplyDelegate = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomFocusMethod_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CinematicCamera.ECameraFocusMethod>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomFocusMethod_AttributeValue_Offset), 0, null, attributeValue);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetCustomFocusMethod_bAddApplyDelegate_Offset), 0, null, bAddApplyDelegate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomFocusMethod_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomFocusMethod_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangePhysicalCameraFactoryNode:SetCustomFocalLength
    static readonly IntPtr SetCustomFocalLength_NativeFunction;
    static readonly int SetCustomFocalLength_ParamsSize;
    static readonly int SetCustomFocalLength_AttributeValue_Offset;
    static readonly int SetCustomFocalLength_bAddApplyDelegate_Offset;
    static readonly int SetCustomFocalLength_ReturnValue_Offset;
    
    public bool SetCustomFocalLength(float attributeValue, bool bAddApplyDelegate = true)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomFocalLength_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomFocalLength_AttributeValue_Offset), 0, null, attributeValue);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetCustomFocalLength_bAddApplyDelegate_Offset), 0, null, bAddApplyDelegate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomFocalLength_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomFocalLength_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangePhysicalCameraFactoryNode:GetCustomSensorWidth
    static readonly IntPtr GetCustomSensorWidth_NativeFunction;
    static readonly int GetCustomSensorWidth_ParamsSize;
    static readonly int GetCustomSensorWidth_AttributeValue_Offset;
    static readonly int GetCustomSensorWidth_ReturnValue_Offset;
    
    public bool GetCustomSensorWidth(out float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomSensorWidth_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomSensorWidth_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomSensorWidth_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomSensorWidth_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangePhysicalCameraFactoryNode:GetCustomSensorHeight
    static readonly IntPtr GetCustomSensorHeight_NativeFunction;
    static readonly int GetCustomSensorHeight_ParamsSize;
    static readonly int GetCustomSensorHeight_AttributeValue_Offset;
    static readonly int GetCustomSensorHeight_ReturnValue_Offset;
    
    public bool GetCustomSensorHeight(out float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomSensorHeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomSensorHeight_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomSensorHeight_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomSensorHeight_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangePhysicalCameraFactoryNode:GetCustomFocusMethod
    static readonly IntPtr GetCustomFocusMethod_NativeFunction;
    static readonly int GetCustomFocusMethod_ParamsSize;
    static readonly int GetCustomFocusMethod_AttributeValue_Offset;
    static readonly int GetCustomFocusMethod_ReturnValue_Offset;
    
    public bool GetCustomFocusMethod(out UnrealSharp.CinematicCamera.ECameraFocusMethod attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomFocusMethod_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomFocusMethod_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<UnrealSharp.CinematicCamera.ECameraFocusMethod>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomFocusMethod_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomFocusMethod_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeFactoryNodes.InterchangePhysicalCameraFactoryNode:GetCustomFocalLength
    static readonly IntPtr GetCustomFocalLength_NativeFunction;
    static readonly int GetCustomFocalLength_ParamsSize;
    static readonly int GetCustomFocalLength_AttributeValue_Offset;
    static readonly int GetCustomFocalLength_ReturnValue_Offset;
    
    public bool GetCustomFocalLength(out float attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomFocalLength_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomFocalLength_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomFocalLength_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomFocalLength_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}