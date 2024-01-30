// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UClass]
public partial class InterchangeAnimationTrackNode : UnrealSharp.InterchangeNodes.InterchangeAnimationTrackBaseNode
{
    
    static InterchangeAnimationTrackNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeAnimationTrackNode");
        
        
        SetCustomTargetedProperty_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomTargetedProperty");
        SetCustomTargetedProperty_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomTargetedProperty_NativeFunction);
        SetCustomTargetedProperty_TargetedProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomTargetedProperty_NativeFunction, "TargetedProperty");
        SetCustomTargetedProperty_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomTargetedProperty_NativeFunction, "ReturnValue");
        SetCustomFrameCount_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomFrameCount");
        SetCustomFrameCount_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomFrameCount_NativeFunction);
        SetCustomFrameCount_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomFrameCount_NativeFunction, "AttributeValue");
        SetCustomFrameCount_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomFrameCount_NativeFunction, "ReturnValue");
        SetCustomAnimationPayloadKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomAnimationPayloadKey");
        SetCustomAnimationPayloadKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomAnimationPayloadKey_NativeFunction);
        SetCustomAnimationPayloadKey_InUniqueId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationPayloadKey_NativeFunction, "InUniqueId");
        SetCustomAnimationPayloadKey_InType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationPayloadKey_NativeFunction, "InType");
        SetCustomAnimationPayloadKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationPayloadKey_NativeFunction, "ReturnValue");
        SetCustomActorDependencyUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomActorDependencyUid");
        SetCustomActorDependencyUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomActorDependencyUid_NativeFunction);
        SetCustomActorDependencyUid_DependencyUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomActorDependencyUid_NativeFunction, "DependencyUid");
        SetCustomActorDependencyUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomActorDependencyUid_NativeFunction, "ReturnValue");
        GetCustomTargetedProperty_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomTargetedProperty");
        GetCustomTargetedProperty_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomTargetedProperty_NativeFunction);
        GetCustomTargetedProperty_TargetedProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomTargetedProperty_NativeFunction, "TargetedProperty");
        GetCustomTargetedProperty_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomTargetedProperty_NativeFunction, "ReturnValue");
        GetCustomFrameCount_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomFrameCount");
        GetCustomFrameCount_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomFrameCount_NativeFunction);
        GetCustomFrameCount_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomFrameCount_NativeFunction, "AttributeValue");
        GetCustomFrameCount_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomFrameCount_NativeFunction, "ReturnValue");
        GetCustomAnimationPayloadKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomAnimationPayloadKey");
        GetCustomAnimationPayloadKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomAnimationPayloadKey_NativeFunction);
        GetCustomAnimationPayloadKey_AnimationPayLoadKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAnimationPayloadKey_NativeFunction, "AnimationPayLoadKey");
        GetCustomAnimationPayloadKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAnimationPayloadKey_NativeFunction, "ReturnValue");
        GetCustomActorDependencyUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomActorDependencyUid");
        GetCustomActorDependencyUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomActorDependencyUid_NativeFunction);
        GetCustomActorDependencyUid_DependencyUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomActorDependencyUid_NativeFunction, "DependencyUid");
        GetCustomActorDependencyUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomActorDependencyUid_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeAnimationTrackNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeNodes.InterchangeAnimationTrackNode:SetCustomTargetedProperty
    static readonly IntPtr SetCustomTargetedProperty_NativeFunction;
    static readonly int SetCustomTargetedProperty_ParamsSize;
    static readonly int SetCustomTargetedProperty_TargetedProperty_Offset;
    static readonly int SetCustomTargetedProperty_ReturnValue_Offset;
    
    public bool SetCustomTargetedProperty(int targetedProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomTargetedProperty_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomTargetedProperty_TargetedProperty_Offset), 0, null, targetedProperty);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomTargetedProperty_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomTargetedProperty_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeAnimationTrackNode:SetCustomFrameCount
    static readonly IntPtr SetCustomFrameCount_NativeFunction;
    static readonly int SetCustomFrameCount_ParamsSize;
    static readonly int SetCustomFrameCount_AttributeValue_Offset;
    static readonly int SetCustomFrameCount_ReturnValue_Offset;
    
    public bool SetCustomFrameCount(int attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomFrameCount_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomFrameCount_AttributeValue_Offset), 0, null, attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomFrameCount_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomFrameCount_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeAnimationTrackNode:SetCustomAnimationPayloadKey
    static readonly IntPtr SetCustomAnimationPayloadKey_NativeFunction;
    static readonly int SetCustomAnimationPayloadKey_ParamsSize;
    static readonly int SetCustomAnimationPayloadKey_InUniqueId_Offset;
    static readonly int SetCustomAnimationPayloadKey_InType_Offset;
    static readonly int SetCustomAnimationPayloadKey_ReturnValue_Offset;
    
    public bool SetCustomAnimationPayloadKey(string inUniqueId, UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType inType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomAnimationPayloadKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr InUniqueId_NativePtr = IntPtr.Add(ParamsBuffer,SetCustomAnimationPayloadKey_InUniqueId_Offset);
            StringMarshaller.ToNative(InUniqueId_NativePtr,0,null,inUniqueId);
            BlittableMarshaller<UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomAnimationPayloadKey_InType_Offset), 0, null, inType);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomAnimationPayloadKey_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomAnimationPayloadKey_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(InUniqueId_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeAnimationTrackNode:SetCustomActorDependencyUid
    static readonly IntPtr SetCustomActorDependencyUid_NativeFunction;
    static readonly int SetCustomActorDependencyUid_ParamsSize;
    static readonly int SetCustomActorDependencyUid_DependencyUid_Offset;
    static readonly int SetCustomActorDependencyUid_ReturnValue_Offset;
    
    public bool SetCustomActorDependencyUid(string dependencyUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomActorDependencyUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr DependencyUid_NativePtr = IntPtr.Add(ParamsBuffer,SetCustomActorDependencyUid_DependencyUid_Offset);
            StringMarshaller.ToNative(DependencyUid_NativePtr,0,null,dependencyUid);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomActorDependencyUid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomActorDependencyUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(DependencyUid_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeAnimationTrackNode:GetCustomTargetedProperty
    static readonly IntPtr GetCustomTargetedProperty_NativeFunction;
    static readonly int GetCustomTargetedProperty_ParamsSize;
    static readonly int GetCustomTargetedProperty_TargetedProperty_Offset;
    static readonly int GetCustomTargetedProperty_ReturnValue_Offset;
    
    public bool GetCustomTargetedProperty(out int targetedProperty)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomTargetedProperty_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomTargetedProperty_NativeFunction, ParamsBuffer);
            
            targetedProperty = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomTargetedProperty_TargetedProperty_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomTargetedProperty_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeAnimationTrackNode:GetCustomFrameCount
    static readonly IntPtr GetCustomFrameCount_NativeFunction;
    static readonly int GetCustomFrameCount_ParamsSize;
    static readonly int GetCustomFrameCount_AttributeValue_Offset;
    static readonly int GetCustomFrameCount_ReturnValue_Offset;
    
    public bool GetCustomFrameCount(out int attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomFrameCount_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomFrameCount_NativeFunction, ParamsBuffer);
            
            attributeValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomFrameCount_AttributeValue_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomFrameCount_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeAnimationTrackNode:GetCustomAnimationPayloadKey
    static readonly IntPtr GetCustomAnimationPayloadKey_NativeFunction;
    static readonly int GetCustomAnimationPayloadKey_ParamsSize;
    static readonly int GetCustomAnimationPayloadKey_AnimationPayLoadKey_Offset;
    static readonly int GetCustomAnimationPayloadKey_ReturnValue_Offset;
    
    public bool GetCustomAnimationPayloadKey(out UnrealSharp.InterchangeNodes.InterchangeAnimationPayLoadKey animationPayLoadKey)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomAnimationPayloadKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomAnimationPayloadKey_NativeFunction, ParamsBuffer);
            
            animationPayLoadKey = UnrealSharp.InterchangeNodes.InterchangeAnimationPayLoadKeyMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAnimationPayloadKey_AnimationPayLoadKey_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAnimationPayloadKey_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeAnimationTrackNode:GetCustomActorDependencyUid
    static readonly IntPtr GetCustomActorDependencyUid_NativeFunction;
    static readonly int GetCustomActorDependencyUid_ParamsSize;
    static readonly int GetCustomActorDependencyUid_DependencyUid_Offset;
    static readonly int GetCustomActorDependencyUid_ReturnValue_Offset;
    
    public bool GetCustomActorDependencyUid(out string dependencyUid)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomActorDependencyUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomActorDependencyUid_NativeFunction, ParamsBuffer);
            
            IntPtr DependencyUid_NativePtr = IntPtr.Add(ParamsBuffer,GetCustomActorDependencyUid_DependencyUid_Offset);
            dependencyUid = StringMarshaller.FromNative(DependencyUid_NativePtr,0,null);
            StringMarshaller.DestructInstance(DependencyUid_NativePtr, 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomActorDependencyUid_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}