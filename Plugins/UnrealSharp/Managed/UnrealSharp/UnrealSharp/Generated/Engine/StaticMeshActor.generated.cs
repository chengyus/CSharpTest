// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class StaticMeshActor : UnrealSharp.Engine.Actor
{
    
    static StaticMeshActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("StaticMeshActor");
        
        StaticMeshComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticMeshComponent");
        
        SetMobility_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMobility");
        SetMobility_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMobility_NativeFunction);
        SetMobility_InMobility_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMobility_NativeFunction, "InMobility");
        
        
    }
    
    protected StaticMeshActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.StaticMeshActor:StaticMeshComponent
    static readonly int StaticMeshComponent_Offset;
    
    public UnrealSharp.Engine.StaticMeshComponent StaticMeshComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.StaticMeshComponent>.FromNative(IntPtr.Add(NativeObject, StaticMeshComponent_Offset), 0, this);
        }
    }
    
    // Function /Script/Engine.StaticMeshActor:SetMobility
    static readonly IntPtr SetMobility_NativeFunction;
    static readonly int SetMobility_ParamsSize;
    static readonly int SetMobility_InMobility_Offset;
    
    public void SetMobility(UnrealSharp.Engine.EComponentMobility inMobility)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMobility_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Engine.EComponentMobility>.ToNative(IntPtr.Add(ParamsBuffer, SetMobility_InMobility_Offset), 0, null, inMobility);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMobility_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}