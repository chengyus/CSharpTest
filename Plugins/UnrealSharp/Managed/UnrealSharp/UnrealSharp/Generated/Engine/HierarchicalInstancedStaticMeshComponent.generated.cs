// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class HierarchicalInstancedStaticMeshComponent : UnrealSharp.Engine.InstancedStaticMeshComponent
{
    
    static HierarchicalInstancedStaticMeshComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("HierarchicalInstancedStaticMeshComponent");
        
        InstanceLODDistanceScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InstanceLODDistanceScale");
        
        SetLODDistanceScale_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLODDistanceScale");
        SetLODDistanceScale_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLODDistanceScale_NativeFunction);
        SetLODDistanceScale_InLODDistanceScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLODDistanceScale_NativeFunction, "InLODDistanceScale");
        GetLODDistanceScale_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLODDistanceScale");
        GetLODDistanceScale_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLODDistanceScale_NativeFunction);
        GetLODDistanceScale_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLODDistanceScale_NativeFunction, "ReturnValue");
        
        
    }
    
    protected HierarchicalInstancedStaticMeshComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/Engine.HierarchicalInstancedStaticMeshComponent:InstanceLODDistanceScale
    static readonly int InstanceLODDistanceScale_Offset;
    
    public float InstanceLODDistanceScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, InstanceLODDistanceScale_Offset), 0, this);
        }
    }
    
    // Function /Script/Engine.HierarchicalInstancedStaticMeshComponent:SetLODDistanceScale
    static readonly IntPtr SetLODDistanceScale_NativeFunction;
    static readonly int SetLODDistanceScale_ParamsSize;
    static readonly int SetLODDistanceScale_InLODDistanceScale_Offset;
    
    public void SetLODDistanceScale(float inLODDistanceScale)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLODDistanceScale_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetLODDistanceScale_InLODDistanceScale_Offset), 0, null, inLODDistanceScale);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLODDistanceScale_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.HierarchicalInstancedStaticMeshComponent:GetLODDistanceScale
    static readonly IntPtr GetLODDistanceScale_NativeFunction;
    static readonly int GetLODDistanceScale_ParamsSize;
    static readonly int GetLODDistanceScale_ReturnValue_Offset;
    
    public float GetLODDistanceScale()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLODDistanceScale_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLODDistanceScale_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetLODDistanceScale_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}