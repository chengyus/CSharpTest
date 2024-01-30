// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraph;

[UClass]
public partial class AnimGraphNode_PoseDriver : UnrealSharp.AnimGraph.AnimGraphNode_PoseHandler
{
    
    static AnimGraphNode_PoseDriver()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimGraphNode_PoseDriver");
        
        Node_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Node");
        
        SetSourceBones_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSourceBones");
        SetSourceBones_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSourceBones_NativeFunction);
        SetSourceBones_BoneNames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSourceBones_NativeFunction, "BoneNames");
        SetSourceBones_BoneNames_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SetSourceBones_NativeFunction, "BoneNames");
        SetRBFParameters_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRBFParameters");
        SetRBFParameters_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRBFParameters_NativeFunction);
        SetRBFParameters_Parameters_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRBFParameters_NativeFunction, "Parameters");
        SetPoseDriverSource_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPoseDriverSource");
        SetPoseDriverSource_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPoseDriverSource_NativeFunction);
        SetPoseDriverSource_DriverSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPoseDriverSource_NativeFunction, "DriverSource");
        SetPoseDriverOutput_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPoseDriverOutput");
        SetPoseDriverOutput_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPoseDriverOutput_NativeFunction);
        SetPoseDriverOutput_DriverOutput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPoseDriverOutput_NativeFunction, "DriverOutput");
        SetDrivingBones_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDrivingBones");
        SetDrivingBones_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDrivingBones_NativeFunction);
        SetDrivingBones_BoneNames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDrivingBones_NativeFunction, "BoneNames");
        SetDrivingBones_BoneNames_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SetDrivingBones_NativeFunction, "BoneNames");
        GetSourceBoneNames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSourceBoneNames");
        GetSourceBoneNames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSourceBoneNames_NativeFunction);
        GetSourceBoneNames_BoneNames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSourceBoneNames_NativeFunction, "BoneNames");
        GetSourceBoneNames_BoneNames_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetSourceBoneNames_NativeFunction, "BoneNames");
        GetRBFParameters_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRBFParameters");
        GetRBFParameters_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRBFParameters_NativeFunction);
        GetRBFParameters_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRBFParameters_NativeFunction, "ReturnValue");
        GetPoseDriverSource_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPoseDriverSource");
        GetPoseDriverSource_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPoseDriverSource_NativeFunction);
        GetPoseDriverSource_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPoseDriverSource_NativeFunction, "ReturnValue");
        GetPoseDriverOutput_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPoseDriverOutput");
        GetPoseDriverOutput_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPoseDriverOutput_NativeFunction);
        GetPoseDriverOutput_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPoseDriverOutput_NativeFunction, "ReturnValue");
        GetDrivingBoneNames_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDrivingBoneNames");
        GetDrivingBoneNames_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDrivingBoneNames_NativeFunction);
        GetDrivingBoneNames_BoneNames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDrivingBoneNames_NativeFunction, "BoneNames");
        GetDrivingBoneNames_BoneNames_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetDrivingBoneNames_NativeFunction, "BoneNames");
        CopyTargetsFromPoseAsset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CopyTargetsFromPoseAsset");
        
        
    }
    
    protected AnimGraphNode_PoseDriver(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/AnimGraph.AnimGraphNode_PoseDriver:Node
    static readonly int Node_Offset;
    
    public UnrealSharp.AnimGraphRuntime.AnimNode_PoseDriver Node
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.AnimGraphRuntime.AnimNode_PoseDriverMarshaler.FromNative(IntPtr.Add(NativeObject, Node_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.AnimGraphRuntime.AnimNode_PoseDriverMarshaler.ToNative(IntPtr.Add(NativeObject, Node_Offset), 0, this, value);
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:SetSourceBones
    static readonly IntPtr SetSourceBones_NativeFunction;
    static readonly int SetSourceBones_ParamsSize;
    static readonly int SetSourceBones_BoneNames_Offset;
    static readonly int SetSourceBones_BoneNames_ElementSize;
    
    public void SetSourceBones(System.Collections.Generic.IList<Name> boneNames)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSourceBones_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr BoneNames_NativeBuffer = IntPtr.Add(ParamsBuffer, SetSourceBones_BoneNames_Offset);
            UnrealArrayCopyMarshaler<Name> BoneNames_Marshaler = new UnrealArrayCopyMarshaler<Name>(1, BlittableMarshaller<Name>.ToNative, BlittableMarshaller<Name>.FromNative, SetSourceBones_BoneNames_ElementSize);
            BoneNames_Marshaler.ToNative(BoneNames_NativeBuffer, 0, null, boneNames);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSourceBones_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:SetRBFParameters
    static readonly IntPtr SetRBFParameters_NativeFunction;
    static readonly int SetRBFParameters_ParamsSize;
    static readonly int SetRBFParameters_Parameters_Offset;
    
    public void SetRBFParameters(UnrealSharp.AnimGraphRuntime.RBFParams parameters)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRBFParameters_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.AnimGraphRuntime.RBFParamsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetRBFParameters_Parameters_Offset), 0, null, parameters);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRBFParameters_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:SetPoseDriverSource
    static readonly IntPtr SetPoseDriverSource_NativeFunction;
    static readonly int SetPoseDriverSource_ParamsSize;
    static readonly int SetPoseDriverSource_DriverSource_Offset;
    
    public void SetPoseDriverSource(UnrealSharp.AnimGraphRuntime.EPoseDriverSource driverSource)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPoseDriverSource_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EPoseDriverSource>.ToNative(IntPtr.Add(ParamsBuffer, SetPoseDriverSource_DriverSource_Offset), 0, null, driverSource);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPoseDriverSource_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:SetPoseDriverOutput
    static readonly IntPtr SetPoseDriverOutput_NativeFunction;
    static readonly int SetPoseDriverOutput_ParamsSize;
    static readonly int SetPoseDriverOutput_DriverOutput_Offset;
    
    public void SetPoseDriverOutput(UnrealSharp.AnimGraphRuntime.EPoseDriverOutput driverOutput)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPoseDriverOutput_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EPoseDriverOutput>.ToNative(IntPtr.Add(ParamsBuffer, SetPoseDriverOutput_DriverOutput_Offset), 0, null, driverOutput);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPoseDriverOutput_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:SetDrivingBones
    static readonly IntPtr SetDrivingBones_NativeFunction;
    static readonly int SetDrivingBones_ParamsSize;
    static readonly int SetDrivingBones_BoneNames_Offset;
    static readonly int SetDrivingBones_BoneNames_ElementSize;
    
    public void SetDrivingBones(System.Collections.Generic.IList<Name> boneNames)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDrivingBones_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr BoneNames_NativeBuffer = IntPtr.Add(ParamsBuffer, SetDrivingBones_BoneNames_Offset);
            UnrealArrayCopyMarshaler<Name> BoneNames_Marshaler = new UnrealArrayCopyMarshaler<Name>(1, BlittableMarshaller<Name>.ToNative, BlittableMarshaller<Name>.FromNative, SetDrivingBones_BoneNames_ElementSize);
            BoneNames_Marshaler.ToNative(BoneNames_NativeBuffer, 0, null, boneNames);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDrivingBones_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:GetSourceBoneNames
    static readonly IntPtr GetSourceBoneNames_NativeFunction;
    static readonly int GetSourceBoneNames_ParamsSize;
    static readonly int GetSourceBoneNames_BoneNames_Offset;
    static readonly int GetSourceBoneNames_BoneNames_ElementSize;
    
    public void GetSourceBoneNames(out System.Collections.Generic.IList<Name> boneNames)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSourceBoneNames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSourceBoneNames_NativeFunction, ParamsBuffer);
            
            IntPtr BoneNames_NativeBuffer = IntPtr.Add(ParamsBuffer, GetSourceBoneNames_BoneNames_Offset);
            UnrealArrayCopyMarshaler<Name> BoneNames_Marshaler = new UnrealArrayCopyMarshaler<Name> (1, BlittableMarshaller<Name>.ToNative, BlittableMarshaller<Name>.FromNative, GetSourceBoneNames_BoneNames_ElementSize);
            boneNames = BoneNames_Marshaler.FromNative(BoneNames_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<Name>.DestructInstance(BoneNames_NativeBuffer, 0);
            
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:GetRBFParameters
    static readonly IntPtr GetRBFParameters_NativeFunction;
    static readonly int GetRBFParameters_ParamsSize;
    static readonly int GetRBFParameters_ReturnValue_Offset;
    
    public UnrealSharp.AnimGraphRuntime.RBFParams GetRBFParameters()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetRBFParameters_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRBFParameters_NativeFunction, ParamsBuffer);
            
            UnrealSharp.AnimGraphRuntime.RBFParams returnValue;
            returnValue = UnrealSharp.AnimGraphRuntime.RBFParamsMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetRBFParameters_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:GetPoseDriverSource
    static readonly IntPtr GetPoseDriverSource_NativeFunction;
    static readonly int GetPoseDriverSource_ParamsSize;
    static readonly int GetPoseDriverSource_ReturnValue_Offset;
    
    public UnrealSharp.AnimGraphRuntime.EPoseDriverSource GetPoseDriverSource()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPoseDriverSource_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPoseDriverSource_NativeFunction, ParamsBuffer);
            
            UnrealSharp.AnimGraphRuntime.EPoseDriverSource returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EPoseDriverSource>.FromNative(IntPtr.Add(ParamsBuffer, GetPoseDriverSource_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:GetPoseDriverOutput
    static readonly IntPtr GetPoseDriverOutput_NativeFunction;
    static readonly int GetPoseDriverOutput_ParamsSize;
    static readonly int GetPoseDriverOutput_ReturnValue_Offset;
    
    public UnrealSharp.AnimGraphRuntime.EPoseDriverOutput GetPoseDriverOutput()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPoseDriverOutput_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPoseDriverOutput_NativeFunction, ParamsBuffer);
            
            UnrealSharp.AnimGraphRuntime.EPoseDriverOutput returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.EPoseDriverOutput>.FromNative(IntPtr.Add(ParamsBuffer, GetPoseDriverOutput_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:GetDrivingBoneNames
    static readonly IntPtr GetDrivingBoneNames_NativeFunction;
    static readonly int GetDrivingBoneNames_ParamsSize;
    static readonly int GetDrivingBoneNames_BoneNames_Offset;
    static readonly int GetDrivingBoneNames_BoneNames_ElementSize;
    
    public void GetDrivingBoneNames(out System.Collections.Generic.IList<Name> boneNames)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDrivingBoneNames_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDrivingBoneNames_NativeFunction, ParamsBuffer);
            
            IntPtr BoneNames_NativeBuffer = IntPtr.Add(ParamsBuffer, GetDrivingBoneNames_BoneNames_Offset);
            UnrealArrayCopyMarshaler<Name> BoneNames_Marshaler = new UnrealArrayCopyMarshaler<Name> (1, BlittableMarshaller<Name>.ToNative, BlittableMarshaller<Name>.FromNative, GetDrivingBoneNames_BoneNames_ElementSize);
            boneNames = BoneNames_Marshaler.FromNative(BoneNames_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<Name>.DestructInstance(BoneNames_NativeBuffer, 0);
            
        }
    }
    
    // Function /Script/AnimGraph.AnimGraphNode_PoseDriver:CopyTargetsFromPoseAsset
    static readonly IntPtr CopyTargetsFromPoseAsset_NativeFunction;
    
    public void CopyTargetsFromPoseAsset()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, CopyTargetsFromPoseAsset_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}