// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeNodes;

[UClass]
public partial class InterchangeSkeletalAnimationTrackNode : UnrealSharp.InterchangeNodes.InterchangeAnimationTrackBaseNode
{
    
    static InterchangeSkeletalAnimationTrackNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangeSkeletalAnimationTrackNode");
        
        
        SetCustomSkeletonNodeUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomSkeletonNodeUid");
        SetCustomSkeletonNodeUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomSkeletonNodeUid_NativeFunction);
        SetCustomSkeletonNodeUid_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomSkeletonNodeUid_NativeFunction, "AttributeValue");
        SetCustomSkeletonNodeUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomSkeletonNodeUid_NativeFunction, "ReturnValue");
        SetCustomAnimationStopTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomAnimationStopTime");
        SetCustomAnimationStopTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomAnimationStopTime_NativeFunction);
        SetCustomAnimationStopTime_StopTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationStopTime_NativeFunction, "StopTime");
        SetCustomAnimationStopTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationStopTime_NativeFunction, "ReturnValue");
        SetCustomAnimationStartTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomAnimationStartTime");
        SetCustomAnimationStartTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomAnimationStartTime_NativeFunction);
        SetCustomAnimationStartTime_StartTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationStartTime_NativeFunction, "StartTime");
        SetCustomAnimationStartTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationStartTime_NativeFunction, "ReturnValue");
        SetCustomAnimationSampleRate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomAnimationSampleRate");
        SetCustomAnimationSampleRate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomAnimationSampleRate_NativeFunction);
        SetCustomAnimationSampleRate_SampleRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationSampleRate_NativeFunction, "SampleRate");
        SetCustomAnimationSampleRate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomAnimationSampleRate_NativeFunction, "ReturnValue");
        SetAnimationPayloadKeyForSceneNodeUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAnimationPayloadKeyForSceneNodeUid");
        SetAnimationPayloadKeyForSceneNodeUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAnimationPayloadKeyForSceneNodeUid_NativeFunction);
        SetAnimationPayloadKeyForSceneNodeUid_SceneNodeUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnimationPayloadKeyForSceneNodeUid_NativeFunction, "SceneNodeUid");
        SetAnimationPayloadKeyForSceneNodeUid_InUniqueId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnimationPayloadKeyForSceneNodeUid_NativeFunction, "InUniqueId");
        SetAnimationPayloadKeyForSceneNodeUid_InType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnimationPayloadKeyForSceneNodeUid_NativeFunction, "InType");
        SetAnimationPayloadKeyForSceneNodeUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnimationPayloadKeyForSceneNodeUid_NativeFunction, "ReturnValue");
        SetAnimationPayloadKeyForMorphTargetNodeUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAnimationPayloadKeyForMorphTargetNodeUid");
        SetAnimationPayloadKeyForMorphTargetNodeUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAnimationPayloadKeyForMorphTargetNodeUid_NativeFunction);
        SetAnimationPayloadKeyForMorphTargetNodeUid_MorphTargetNodeUid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnimationPayloadKeyForMorphTargetNodeUid_NativeFunction, "MorphTargetNodeUid");
        SetAnimationPayloadKeyForMorphTargetNodeUid_InUniqueId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnimationPayloadKeyForMorphTargetNodeUid_NativeFunction, "InUniqueId");
        SetAnimationPayloadKeyForMorphTargetNodeUid_InType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnimationPayloadKeyForMorphTargetNodeUid_NativeFunction, "InType");
        SetAnimationPayloadKeyForMorphTargetNodeUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnimationPayloadKeyForMorphTargetNodeUid_NativeFunction, "ReturnValue");
        GetCustomSkeletonNodeUid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomSkeletonNodeUid");
        GetCustomSkeletonNodeUid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomSkeletonNodeUid_NativeFunction);
        GetCustomSkeletonNodeUid_AttributeValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomSkeletonNodeUid_NativeFunction, "AttributeValue");
        GetCustomSkeletonNodeUid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomSkeletonNodeUid_NativeFunction, "ReturnValue");
        GetCustomAnimationStopTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomAnimationStopTime");
        GetCustomAnimationStopTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomAnimationStopTime_NativeFunction);
        GetCustomAnimationStopTime_StopTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAnimationStopTime_NativeFunction, "StopTime");
        GetCustomAnimationStopTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAnimationStopTime_NativeFunction, "ReturnValue");
        GetCustomAnimationStartTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomAnimationStartTime");
        GetCustomAnimationStartTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomAnimationStartTime_NativeFunction);
        GetCustomAnimationStartTime_StartTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAnimationStartTime_NativeFunction, "StartTime");
        GetCustomAnimationStartTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAnimationStartTime_NativeFunction, "ReturnValue");
        GetCustomAnimationSampleRate_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCustomAnimationSampleRate");
        GetCustomAnimationSampleRate_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCustomAnimationSampleRate_NativeFunction);
        GetCustomAnimationSampleRate_SampleRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAnimationSampleRate_NativeFunction, "SampleRate");
        GetCustomAnimationSampleRate_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCustomAnimationSampleRate_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangeSkeletalAnimationTrackNode(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:SetCustomSkeletonNodeUid
    static readonly IntPtr SetCustomSkeletonNodeUid_NativeFunction;
    static readonly int SetCustomSkeletonNodeUid_ParamsSize;
    static readonly int SetCustomSkeletonNodeUid_AttributeValue_Offset;
    static readonly int SetCustomSkeletonNodeUid_ReturnValue_Offset;
    
    public bool SetCustomSkeletonNodeUid(string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomSkeletonNodeUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,SetCustomSkeletonNodeUid_AttributeValue_Offset);
            StringMarshaller.ToNative(AttributeValue_NativePtr,0,null,attributeValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomSkeletonNodeUid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomSkeletonNodeUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:SetCustomAnimationStopTime
    static readonly IntPtr SetCustomAnimationStopTime_NativeFunction;
    static readonly int SetCustomAnimationStopTime_ParamsSize;
    static readonly int SetCustomAnimationStopTime_StopTime_Offset;
    static readonly int SetCustomAnimationStopTime_ReturnValue_Offset;
    
    public bool SetCustomAnimationStopTime(double stopTime)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomAnimationStopTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<double>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomAnimationStopTime_StopTime_Offset), 0, null, stopTime);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomAnimationStopTime_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomAnimationStopTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:SetCustomAnimationStartTime
    static readonly IntPtr SetCustomAnimationStartTime_NativeFunction;
    static readonly int SetCustomAnimationStartTime_ParamsSize;
    static readonly int SetCustomAnimationStartTime_StartTime_Offset;
    static readonly int SetCustomAnimationStartTime_ReturnValue_Offset;
    
    public bool SetCustomAnimationStartTime(double startTime)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomAnimationStartTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<double>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomAnimationStartTime_StartTime_Offset), 0, null, startTime);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomAnimationStartTime_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomAnimationStartTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:SetCustomAnimationSampleRate
    static readonly IntPtr SetCustomAnimationSampleRate_NativeFunction;
    static readonly int SetCustomAnimationSampleRate_ParamsSize;
    static readonly int SetCustomAnimationSampleRate_SampleRate_Offset;
    static readonly int SetCustomAnimationSampleRate_ReturnValue_Offset;
    
    public bool SetCustomAnimationSampleRate(double sampleRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomAnimationSampleRate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<double>.ToNative(IntPtr.Add(ParamsBuffer, SetCustomAnimationSampleRate_SampleRate_Offset), 0, null, sampleRate);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomAnimationSampleRate_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetCustomAnimationSampleRate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:SetAnimationPayloadKeyForSceneNodeUid
    static readonly IntPtr SetAnimationPayloadKeyForSceneNodeUid_NativeFunction;
    static readonly int SetAnimationPayloadKeyForSceneNodeUid_ParamsSize;
    static readonly int SetAnimationPayloadKeyForSceneNodeUid_SceneNodeUid_Offset;
    static readonly int SetAnimationPayloadKeyForSceneNodeUid_InUniqueId_Offset;
    static readonly int SetAnimationPayloadKeyForSceneNodeUid_InType_Offset;
    static readonly int SetAnimationPayloadKeyForSceneNodeUid_ReturnValue_Offset;
    
    public bool SetAnimationPayloadKeyForSceneNodeUid(string sceneNodeUid, string inUniqueId, UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType inType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAnimationPayloadKeyForSceneNodeUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr SceneNodeUid_NativePtr = IntPtr.Add(ParamsBuffer,SetAnimationPayloadKeyForSceneNodeUid_SceneNodeUid_Offset);
            StringMarshaller.ToNative(SceneNodeUid_NativePtr,0,null,sceneNodeUid);
            IntPtr InUniqueId_NativePtr = IntPtr.Add(ParamsBuffer,SetAnimationPayloadKeyForSceneNodeUid_InUniqueId_Offset);
            StringMarshaller.ToNative(InUniqueId_NativePtr,0,null,inUniqueId);
            BlittableMarshaller<UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType>.ToNative(IntPtr.Add(ParamsBuffer, SetAnimationPayloadKeyForSceneNodeUid_InType_Offset), 0, null, inType);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAnimationPayloadKeyForSceneNodeUid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetAnimationPayloadKeyForSceneNodeUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(SceneNodeUid_NativePtr, 0);
            StringMarshaller.DestructInstance(InUniqueId_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:SetAnimationPayloadKeyForMorphTargetNodeUid
    static readonly IntPtr SetAnimationPayloadKeyForMorphTargetNodeUid_NativeFunction;
    static readonly int SetAnimationPayloadKeyForMorphTargetNodeUid_ParamsSize;
    static readonly int SetAnimationPayloadKeyForMorphTargetNodeUid_MorphTargetNodeUid_Offset;
    static readonly int SetAnimationPayloadKeyForMorphTargetNodeUid_InUniqueId_Offset;
    static readonly int SetAnimationPayloadKeyForMorphTargetNodeUid_InType_Offset;
    static readonly int SetAnimationPayloadKeyForMorphTargetNodeUid_ReturnValue_Offset;
    
    public bool SetAnimationPayloadKeyForMorphTargetNodeUid(string morphTargetNodeUid, string inUniqueId, UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType inType)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAnimationPayloadKeyForMorphTargetNodeUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr MorphTargetNodeUid_NativePtr = IntPtr.Add(ParamsBuffer,SetAnimationPayloadKeyForMorphTargetNodeUid_MorphTargetNodeUid_Offset);
            StringMarshaller.ToNative(MorphTargetNodeUid_NativePtr,0,null,morphTargetNodeUid);
            IntPtr InUniqueId_NativePtr = IntPtr.Add(ParamsBuffer,SetAnimationPayloadKeyForMorphTargetNodeUid_InUniqueId_Offset);
            StringMarshaller.ToNative(InUniqueId_NativePtr,0,null,inUniqueId);
            BlittableMarshaller<UnrealSharp.InterchangeNodes.EInterchangeAnimationPayLoadType>.ToNative(IntPtr.Add(ParamsBuffer, SetAnimationPayloadKeyForMorphTargetNodeUid_InType_Offset), 0, null, inType);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAnimationPayloadKeyForMorphTargetNodeUid_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SetAnimationPayloadKeyForMorphTargetNodeUid_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(MorphTargetNodeUid_NativePtr, 0);
            StringMarshaller.DestructInstance(InUniqueId_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:GetCustomSkeletonNodeUid
    static readonly IntPtr GetCustomSkeletonNodeUid_NativeFunction;
    static readonly int GetCustomSkeletonNodeUid_ParamsSize;
    static readonly int GetCustomSkeletonNodeUid_AttributeValue_Offset;
    static readonly int GetCustomSkeletonNodeUid_ReturnValue_Offset;
    
    public bool GetCustomSkeletonNodeUid(out string attributeValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomSkeletonNodeUid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomSkeletonNodeUid_NativeFunction, ParamsBuffer);
            
            IntPtr AttributeValue_NativePtr = IntPtr.Add(ParamsBuffer,GetCustomSkeletonNodeUid_AttributeValue_Offset);
            attributeValue = StringMarshaller.FromNative(AttributeValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(AttributeValue_NativePtr, 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomSkeletonNodeUid_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:GetCustomAnimationStopTime
    static readonly IntPtr GetCustomAnimationStopTime_NativeFunction;
    static readonly int GetCustomAnimationStopTime_ParamsSize;
    static readonly int GetCustomAnimationStopTime_StopTime_Offset;
    static readonly int GetCustomAnimationStopTime_ReturnValue_Offset;
    
    public bool GetCustomAnimationStopTime(out double stopTime)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomAnimationStopTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomAnimationStopTime_NativeFunction, ParamsBuffer);
            
            stopTime = BlittableMarshaller<double>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAnimationStopTime_StopTime_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAnimationStopTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:GetCustomAnimationStartTime
    static readonly IntPtr GetCustomAnimationStartTime_NativeFunction;
    static readonly int GetCustomAnimationStartTime_ParamsSize;
    static readonly int GetCustomAnimationStartTime_StartTime_Offset;
    static readonly int GetCustomAnimationStartTime_ReturnValue_Offset;
    
    public bool GetCustomAnimationStartTime(out double startTime)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomAnimationStartTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomAnimationStartTime_NativeFunction, ParamsBuffer);
            
            startTime = BlittableMarshaller<double>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAnimationStartTime_StartTime_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAnimationStartTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode:GetCustomAnimationSampleRate
    static readonly IntPtr GetCustomAnimationSampleRate_NativeFunction;
    static readonly int GetCustomAnimationSampleRate_ParamsSize;
    static readonly int GetCustomAnimationSampleRate_SampleRate_Offset;
    static readonly int GetCustomAnimationSampleRate_ReturnValue_Offset;
    
    public bool GetCustomAnimationSampleRate(out double sampleRate)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCustomAnimationSampleRate_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCustomAnimationSampleRate_NativeFunction, ParamsBuffer);
            
            sampleRate = BlittableMarshaller<double>.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAnimationSampleRate_SampleRate_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCustomAnimationSampleRate_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}