// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PointLight : UnrealSharp.Engine.Light
{
    
    static PointLight()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PointLight");
        
        PointLightComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PointLightComponent");
        
        SetRadius_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRadius");
        SetRadius_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRadius_NativeFunction);
        SetRadius_NewRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRadius_NativeFunction, "NewRadius");
        SetLightFalloffExponent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLightFalloffExponent");
        SetLightFalloffExponent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLightFalloffExponent_NativeFunction);
        SetLightFalloffExponent_NewLightFalloffExponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLightFalloffExponent_NativeFunction, "NewLightFalloffExponent");
        
        
    }
    
    protected PointLight(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/Engine.PointLight:PointLightComponent
    static readonly int PointLightComponent_Offset;
    
    public UnrealSharp.Engine.PointLightComponent PointLightComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.PointLightComponent>.FromNative(IntPtr.Add(NativeObject, PointLightComponent_Offset), 0, this);
        }
    }
    
    // Function /Script/Engine.PointLight:SetRadius
    static readonly IntPtr SetRadius_NativeFunction;
    static readonly int SetRadius_ParamsSize;
    static readonly int SetRadius_NewRadius_Offset;
    
    [Obsolete("This function is obsolete")]
    public void SetRadius(float newRadius)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRadius_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetRadius_NewRadius_Offset), 0, null, newRadius);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRadius_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.PointLight:SetLightFalloffExponent
    static readonly IntPtr SetLightFalloffExponent_NativeFunction;
    static readonly int SetLightFalloffExponent_ParamsSize;
    static readonly int SetLightFalloffExponent_NewLightFalloffExponent_Offset;
    
    [Obsolete("This function is obsolete")]
    public void SetLightFalloffExponent(float newLightFalloffExponent)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLightFalloffExponent_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetLightFalloffExponent_NewLightFalloffExponent_Offset), 0, null, newLightFalloffExponent);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLightFalloffExponent_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}