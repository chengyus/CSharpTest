// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class AtmosphericFogComponent : UnrealSharp.Engine.SkyAtmosphereComponent
{
    
    static AtmosphericFogComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AtmosphericFogComponent");
        
        
        SetSunMultiplier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSunMultiplier");
        SetSunMultiplier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSunMultiplier_NativeFunction);
        SetSunMultiplier_NewSunMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSunMultiplier_NativeFunction, "NewSunMultiplier");
        SetStartDistance_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetStartDistance");
        SetStartDistance_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetStartDistance_NativeFunction);
        SetStartDistance_NewStartDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetStartDistance_NativeFunction, "NewStartDistance");
        SetPrecomputeParams_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPrecomputeParams");
        SetPrecomputeParams_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPrecomputeParams_NativeFunction);
        SetPrecomputeParams_DensityHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPrecomputeParams_NativeFunction, "DensityHeight");
        SetPrecomputeParams_MaxScatteringOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPrecomputeParams_NativeFunction, "MaxScatteringOrder");
        SetPrecomputeParams_InscatterAltitudeSampleNum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPrecomputeParams_NativeFunction, "InscatterAltitudeSampleNum");
        SetFogMultiplier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFogMultiplier");
        SetFogMultiplier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFogMultiplier_NativeFunction);
        SetFogMultiplier_NewFogMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFogMultiplier_NativeFunction, "NewFogMultiplier");
        SetDistanceScale_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDistanceScale");
        SetDistanceScale_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDistanceScale_NativeFunction);
        SetDistanceScale_NewDistanceScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDistanceScale_NativeFunction, "NewDistanceScale");
        SetDistanceOffset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDistanceOffset");
        SetDistanceOffset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDistanceOffset_NativeFunction);
        SetDistanceOffset_NewDistanceOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDistanceOffset_NativeFunction, "NewDistanceOffset");
        SetDensityOffset_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDensityOffset");
        SetDensityOffset_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDensityOffset_NativeFunction);
        SetDensityOffset_NewDensityOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDensityOffset_NativeFunction, "NewDensityOffset");
        SetDensityMultiplier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDensityMultiplier");
        SetDensityMultiplier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDensityMultiplier_NativeFunction);
        SetDensityMultiplier_NewDensityMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDensityMultiplier_NativeFunction, "NewDensityMultiplier");
        SetDefaultLightColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDefaultLightColor");
        SetDefaultLightColor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDefaultLightColor_NativeFunction);
        SetDefaultLightColor_NewLightColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDefaultLightColor_NativeFunction, "NewLightColor");
        SetDefaultBrightness_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetDefaultBrightness");
        SetDefaultBrightness_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetDefaultBrightness_NativeFunction);
        SetDefaultBrightness_NewBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetDefaultBrightness_NativeFunction, "NewBrightness");
        SetAltitudeScale_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAltitudeScale");
        SetAltitudeScale_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAltitudeScale_NativeFunction);
        SetAltitudeScale_NewAltitudeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAltitudeScale_NativeFunction, "NewAltitudeScale");
        DisableSunDisk_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "DisableSunDisk");
        DisableSunDisk_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(DisableSunDisk_NativeFunction);
        DisableSunDisk_NewSunDisk_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(DisableSunDisk_NativeFunction, "NewSunDisk");
        DisableGroundScattering_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "DisableGroundScattering");
        DisableGroundScattering_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(DisableGroundScattering_NativeFunction);
        DisableGroundScattering_NewGroundScattering_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(DisableGroundScattering_NativeFunction, "NewGroundScattering");
        
        
    }
    
    protected AtmosphericFogComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.AtmosphericFogComponent:SetSunMultiplier
    static readonly IntPtr SetSunMultiplier_NativeFunction;
    static readonly int SetSunMultiplier_ParamsSize;
    static readonly int SetSunMultiplier_NewSunMultiplier_Offset;
    
    public void SetSunMultiplier(float newSunMultiplier)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSunMultiplier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetSunMultiplier_NewSunMultiplier_Offset), 0, null, newSunMultiplier);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSunMultiplier_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetStartDistance
    static readonly IntPtr SetStartDistance_NativeFunction;
    static readonly int SetStartDistance_ParamsSize;
    static readonly int SetStartDistance_NewStartDistance_Offset;
    
    public void SetStartDistance(float newStartDistance)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetStartDistance_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetStartDistance_NewStartDistance_Offset), 0, null, newStartDistance);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetStartDistance_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetPrecomputeParams
    static readonly IntPtr SetPrecomputeParams_NativeFunction;
    static readonly int SetPrecomputeParams_ParamsSize;
    static readonly int SetPrecomputeParams_DensityHeight_Offset;
    static readonly int SetPrecomputeParams_MaxScatteringOrder_Offset;
    static readonly int SetPrecomputeParams_InscatterAltitudeSampleNum_Offset;
    
    public void SetPrecomputeParams(float densityHeight, int maxScatteringOrder, int inscatterAltitudeSampleNum)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPrecomputeParams_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetPrecomputeParams_DensityHeight_Offset), 0, null, densityHeight);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetPrecomputeParams_MaxScatteringOrder_Offset), 0, null, maxScatteringOrder);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetPrecomputeParams_InscatterAltitudeSampleNum_Offset), 0, null, inscatterAltitudeSampleNum);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPrecomputeParams_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetFogMultiplier
    static readonly IntPtr SetFogMultiplier_NativeFunction;
    static readonly int SetFogMultiplier_ParamsSize;
    static readonly int SetFogMultiplier_NewFogMultiplier_Offset;
    
    public void SetFogMultiplier(float newFogMultiplier)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFogMultiplier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFogMultiplier_NewFogMultiplier_Offset), 0, null, newFogMultiplier);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFogMultiplier_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetDistanceScale
    static readonly IntPtr SetDistanceScale_NativeFunction;
    static readonly int SetDistanceScale_ParamsSize;
    static readonly int SetDistanceScale_NewDistanceScale_Offset;
    
    public void SetDistanceScale(float newDistanceScale)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDistanceScale_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetDistanceScale_NewDistanceScale_Offset), 0, null, newDistanceScale);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDistanceScale_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetDistanceOffset
    static readonly IntPtr SetDistanceOffset_NativeFunction;
    static readonly int SetDistanceOffset_ParamsSize;
    static readonly int SetDistanceOffset_NewDistanceOffset_Offset;
    
    public void SetDistanceOffset(float newDistanceOffset)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDistanceOffset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetDistanceOffset_NewDistanceOffset_Offset), 0, null, newDistanceOffset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDistanceOffset_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetDensityOffset
    static readonly IntPtr SetDensityOffset_NativeFunction;
    static readonly int SetDensityOffset_ParamsSize;
    static readonly int SetDensityOffset_NewDensityOffset_Offset;
    
    public void SetDensityOffset(float newDensityOffset)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDensityOffset_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetDensityOffset_NewDensityOffset_Offset), 0, null, newDensityOffset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDensityOffset_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetDensityMultiplier
    static readonly IntPtr SetDensityMultiplier_NativeFunction;
    static readonly int SetDensityMultiplier_ParamsSize;
    static readonly int SetDensityMultiplier_NewDensityMultiplier_Offset;
    
    public void SetDensityMultiplier(float newDensityMultiplier)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDensityMultiplier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetDensityMultiplier_NewDensityMultiplier_Offset), 0, null, newDensityMultiplier);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDensityMultiplier_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetDefaultLightColor
    static readonly IntPtr SetDefaultLightColor_NativeFunction;
    static readonly int SetDefaultLightColor_ParamsSize;
    static readonly int SetDefaultLightColor_NewLightColor_Offset;
    
    public void SetDefaultLightColor(UnrealSharp.CoreUObject.LinearColor newLightColor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDefaultLightColor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(ParamsBuffer, SetDefaultLightColor_NewLightColor_Offset), 0, null, newLightColor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDefaultLightColor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetDefaultBrightness
    static readonly IntPtr SetDefaultBrightness_NativeFunction;
    static readonly int SetDefaultBrightness_ParamsSize;
    static readonly int SetDefaultBrightness_NewBrightness_Offset;
    
    public void SetDefaultBrightness(float newBrightness)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetDefaultBrightness_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetDefaultBrightness_NewBrightness_Offset), 0, null, newBrightness);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetDefaultBrightness_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:SetAltitudeScale
    static readonly IntPtr SetAltitudeScale_NativeFunction;
    static readonly int SetAltitudeScale_ParamsSize;
    static readonly int SetAltitudeScale_NewAltitudeScale_Offset;
    
    public void SetAltitudeScale(float newAltitudeScale)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAltitudeScale_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetAltitudeScale_NewAltitudeScale_Offset), 0, null, newAltitudeScale);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAltitudeScale_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:DisableSunDisk
    static readonly IntPtr DisableSunDisk_NativeFunction;
    static readonly int DisableSunDisk_ParamsSize;
    static readonly int DisableSunDisk_NewSunDisk_Offset;
    
    public void DisableSunDisk(bool newSunDisk)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[DisableSunDisk_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, DisableSunDisk_NewSunDisk_Offset), 0, null, newSunDisk);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, DisableSunDisk_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.AtmosphericFogComponent:DisableGroundScattering
    static readonly IntPtr DisableGroundScattering_NativeFunction;
    static readonly int DisableGroundScattering_ParamsSize;
    static readonly int DisableGroundScattering_NewGroundScattering_Offset;
    
    public void DisableGroundScattering(bool newGroundScattering)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[DisableGroundScattering_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, DisableGroundScattering_NewGroundScattering_Offset), 0, null, newGroundScattering);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, DisableGroundScattering_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}