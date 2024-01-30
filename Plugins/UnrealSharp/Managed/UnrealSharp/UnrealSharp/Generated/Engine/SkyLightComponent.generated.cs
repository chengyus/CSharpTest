// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class SkyLightComponent : UnrealSharp.Engine.LightComponentBase
{
    
    static SkyLightComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SkyLightComponent");
        
        bRealTimeCapture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRealTimeCapture");
        SourceType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceType");
        Cubemap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Cubemap");
        SourceCubemapAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceCubemapAngle");
        CubemapResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CubemapResolution");
        SkyDistanceThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SkyDistanceThreshold");
        bCaptureEmissiveOnly_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCaptureEmissiveOnly");
        bLowerHemisphereIsBlack_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLowerHemisphereIsBlack");
        LowerHemisphereColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowerHemisphereColor");
        OcclusionMaxDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionMaxDistance");
        Contrast_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Contrast");
        OcclusionExponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionExponent");
        MinOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinOcclusion");
        OcclusionTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionTint");
        bCloudAmbientOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCloudAmbientOcclusion");
        bCloudAmbientOcclusion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCloudAmbientOcclusion");
        CloudAmbientOcclusionStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CloudAmbientOcclusionStrength");
        CloudAmbientOcclusionExtent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CloudAmbientOcclusionExtent");
        CloudAmbientOcclusionMapResolutionScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CloudAmbientOcclusionMapResolutionScale");
        CloudAmbientOcclusionApertureScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CloudAmbientOcclusionApertureScale");
        OcclusionCombineMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OcclusionCombineMode");
        bShowIlluminanceMeter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowIlluminanceMeter");
        bShowIlluminanceMeter_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShowIlluminanceMeter");
        
        SetVolumetricScatteringIntensity_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetVolumetricScatteringIntensity");
        SetVolumetricScatteringIntensity_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetVolumetricScatteringIntensity_NativeFunction);
        SetVolumetricScatteringIntensity_NewIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVolumetricScatteringIntensity_NativeFunction, "NewIntensity");
        SetSourceCubemapAngle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSourceCubemapAngle");
        SetSourceCubemapAngle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSourceCubemapAngle_NativeFunction);
        SetSourceCubemapAngle_NewValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSourceCubemapAngle_NativeFunction, "NewValue");
        SetOcclusionTint_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOcclusionTint");
        SetOcclusionTint_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOcclusionTint_NativeFunction);
        SetOcclusionTint_InTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOcclusionTint_NativeFunction, "InTint");
        SetOcclusionExponent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOcclusionExponent");
        SetOcclusionExponent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOcclusionExponent_NativeFunction);
        SetOcclusionExponent_InOcclusionExponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOcclusionExponent_NativeFunction, "InOcclusionExponent");
        SetOcclusionContrast_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOcclusionContrast");
        SetOcclusionContrast_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOcclusionContrast_NativeFunction);
        SetOcclusionContrast_InOcclusionContrast_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOcclusionContrast_NativeFunction, "InOcclusionContrast");
        SetMinOcclusion_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMinOcclusion");
        SetMinOcclusion_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMinOcclusion_NativeFunction);
        SetMinOcclusion_InMinOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMinOcclusion_NativeFunction, "InMinOcclusion");
        SetLowerHemisphereColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLowerHemisphereColor");
        SetLowerHemisphereColor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLowerHemisphereColor_NativeFunction);
        SetLowerHemisphereColor_InLowerHemisphereColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLowerHemisphereColor_NativeFunction, "InLowerHemisphereColor");
        SetLightColor_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLightColor");
        SetLightColor_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLightColor_NativeFunction);
        SetLightColor_NewLightColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLightColor_NativeFunction, "NewLightColor");
        SetIntensity_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetIntensity");
        SetIntensity_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetIntensity_NativeFunction);
        SetIntensity_NewIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetIntensity_NativeFunction, "NewIntensity");
        SetIndirectLightingIntensity_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetIndirectLightingIntensity");
        SetIndirectLightingIntensity_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetIndirectLightingIntensity_NativeFunction);
        SetIndirectLightingIntensity_NewIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetIndirectLightingIntensity_NativeFunction, "NewIntensity");
        SetCubemapBlend_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCubemapBlend");
        SetCubemapBlend_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCubemapBlend_NativeFunction);
        SetCubemapBlend_SourceCubemap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCubemapBlend_NativeFunction, "SourceCubemap");
        SetCubemapBlend_DestinationCubemap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCubemapBlend_NativeFunction, "DestinationCubemap");
        SetCubemapBlend_InBlendFraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCubemapBlend_NativeFunction, "InBlendFraction");
        SetCubemap_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCubemap");
        SetCubemap_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCubemap_NativeFunction);
        SetCubemap_NewCubemap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCubemap_NativeFunction, "NewCubemap");
        RecaptureSky_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RecaptureSky");
        
        
    }
    
    protected SkyLightComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/Engine.SkyLightComponent:bRealTimeCapture
    static readonly int bRealTimeCapture_Offset;
    
    public bool bRealTimeCapture
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bRealTimeCapture_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/Engine.SkyLightComponent:SourceType
    static readonly int SourceType_Offset;
    
    public UnrealSharp.Engine.ESkyLightSourceType SourceType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.ESkyLightSourceType>.FromNative(IntPtr.Add(NativeObject, SourceType_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Engine.SkyLightComponent:Cubemap
    static readonly int Cubemap_Offset;
    
    public UnrealSharp.Engine.TextureCube Cubemap
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.TextureCube>.FromNative(IntPtr.Add(NativeObject, Cubemap_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:SourceCubemapAngle
    static readonly int SourceCubemapAngle_Offset;
    
    public float SourceCubemapAngle
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SourceCubemapAngle_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/Engine.SkyLightComponent:CubemapResolution
    static readonly int CubemapResolution_Offset;
    
    public int CubemapResolution
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, CubemapResolution_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:SkyDistanceThreshold
    static readonly int SkyDistanceThreshold_Offset;
    
    public float SkyDistanceThreshold
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SkyDistanceThreshold_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.SkyLightComponent:bCaptureEmissiveOnly
    static readonly int bCaptureEmissiveOnly_Offset;
    
    public bool bCaptureEmissiveOnly
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bCaptureEmissiveOnly_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.SkyLightComponent:bLowerHemisphereIsBlack
    static readonly int bLowerHemisphereIsBlack_Offset;
    
    public bool bLowerHemisphereIsBlack
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bLowerHemisphereIsBlack_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.SkyLightComponent:LowerHemisphereColor
    static readonly int LowerHemisphereColor_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor LowerHemisphereColor
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(NativeObject, LowerHemisphereColor_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:OcclusionMaxDistance
    static readonly int OcclusionMaxDistance_Offset;
    
    public float OcclusionMaxDistance
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, OcclusionMaxDistance_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:Contrast
    static readonly int Contrast_Offset;
    
    public float Contrast
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Contrast_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:OcclusionExponent
    static readonly int OcclusionExponent_Offset;
    
    public float OcclusionExponent
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, OcclusionExponent_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:MinOcclusion
    static readonly int MinOcclusion_Offset;
    
    public float MinOcclusion
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinOcclusion_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.SkyLightComponent:OcclusionTint
    static readonly int OcclusionTint_Offset;
    
    public UnrealSharp.CoreUObject.Color OcclusionTint
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(NativeObject, OcclusionTint_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.SkyLightComponent:bCloudAmbientOcclusion
    static readonly int bCloudAmbientOcclusion_Offset;
    static readonly IntPtr bCloudAmbientOcclusion_NativeProperty;
    
    public bool bCloudAmbientOcclusion
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bCloudAmbientOcclusion_NativeProperty, bCloudAmbientOcclusion_Offset);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:CloudAmbientOcclusionStrength
    static readonly int CloudAmbientOcclusionStrength_Offset;
    
    public float CloudAmbientOcclusionStrength
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CloudAmbientOcclusionStrength_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:CloudAmbientOcclusionExtent
    static readonly int CloudAmbientOcclusionExtent_Offset;
    
    public float CloudAmbientOcclusionExtent
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CloudAmbientOcclusionExtent_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:CloudAmbientOcclusionMapResolutionScale
    static readonly int CloudAmbientOcclusionMapResolutionScale_Offset;
    
    public float CloudAmbientOcclusionMapResolutionScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CloudAmbientOcclusionMapResolutionScale_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.SkyLightComponent:CloudAmbientOcclusionApertureScale
    static readonly int CloudAmbientOcclusionApertureScale_Offset;
    
    public float CloudAmbientOcclusionApertureScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CloudAmbientOcclusionApertureScale_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/Engine.SkyLightComponent:OcclusionCombineMode
    static readonly int OcclusionCombineMode_Offset;
    
    public UnrealSharp.Engine.EOcclusionCombineMode OcclusionCombineMode
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.EOcclusionCombineMode>.FromNative(IntPtr.Add(NativeObject, OcclusionCombineMode_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.SkyLightComponent:bShowIlluminanceMeter
    static readonly int bShowIlluminanceMeter_Offset;
    static readonly IntPtr bShowIlluminanceMeter_NativeProperty;
    
    public bool bShowIlluminanceMeter
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, bShowIlluminanceMeter_NativeProperty, bShowIlluminanceMeter_Offset);
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetVolumetricScatteringIntensity
    static readonly IntPtr SetVolumetricScatteringIntensity_NativeFunction;
    static readonly int SetVolumetricScatteringIntensity_ParamsSize;
    static readonly int SetVolumetricScatteringIntensity_NewIntensity_Offset;
    
    public void SetVolumetricScatteringIntensity(float newIntensity)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetVolumetricScatteringIntensity_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetVolumetricScatteringIntensity_NewIntensity_Offset), 0, null, newIntensity);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetVolumetricScatteringIntensity_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetSourceCubemapAngle
    static readonly IntPtr SetSourceCubemapAngle_NativeFunction;
    static readonly int SetSourceCubemapAngle_ParamsSize;
    static readonly int SetSourceCubemapAngle_NewValue_Offset;
    
    public void SetSourceCubemapAngle(float newValue)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSourceCubemapAngle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetSourceCubemapAngle_NewValue_Offset), 0, null, newValue);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSourceCubemapAngle_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetOcclusionTint
    static readonly IntPtr SetOcclusionTint_NativeFunction;
    static readonly int SetOcclusionTint_ParamsSize;
    static readonly int SetOcclusionTint_InTint_Offset;
    
    public void SetOcclusionTint(UnrealSharp.CoreUObject.Color inTint)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOcclusionTint_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(ParamsBuffer, SetOcclusionTint_InTint_Offset), 0, null, inTint);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOcclusionTint_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetOcclusionExponent
    static readonly IntPtr SetOcclusionExponent_NativeFunction;
    static readonly int SetOcclusionExponent_ParamsSize;
    static readonly int SetOcclusionExponent_InOcclusionExponent_Offset;
    
    public void SetOcclusionExponent(float inOcclusionExponent)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOcclusionExponent_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetOcclusionExponent_InOcclusionExponent_Offset), 0, null, inOcclusionExponent);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOcclusionExponent_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetOcclusionContrast
    static readonly IntPtr SetOcclusionContrast_NativeFunction;
    static readonly int SetOcclusionContrast_ParamsSize;
    static readonly int SetOcclusionContrast_InOcclusionContrast_Offset;
    
    public void SetOcclusionContrast(float inOcclusionContrast)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOcclusionContrast_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetOcclusionContrast_InOcclusionContrast_Offset), 0, null, inOcclusionContrast);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOcclusionContrast_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetMinOcclusion
    static readonly IntPtr SetMinOcclusion_NativeFunction;
    static readonly int SetMinOcclusion_ParamsSize;
    static readonly int SetMinOcclusion_InMinOcclusion_Offset;
    
    public void SetMinOcclusion(float inMinOcclusion)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMinOcclusion_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMinOcclusion_InMinOcclusion_Offset), 0, null, inMinOcclusion);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMinOcclusion_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetLowerHemisphereColor
    static readonly IntPtr SetLowerHemisphereColor_NativeFunction;
    static readonly int SetLowerHemisphereColor_ParamsSize;
    static readonly int SetLowerHemisphereColor_InLowerHemisphereColor_Offset;
    
    public void SetLowerHemisphereColor(UnrealSharp.CoreUObject.LinearColor inLowerHemisphereColor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLowerHemisphereColor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(ParamsBuffer, SetLowerHemisphereColor_InLowerHemisphereColor_Offset), 0, null, inLowerHemisphereColor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLowerHemisphereColor_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetLightColor
    static readonly IntPtr SetLightColor_NativeFunction;
    static readonly int SetLightColor_ParamsSize;
    static readonly int SetLightColor_NewLightColor_Offset;
    
    public void SetLightColor(UnrealSharp.CoreUObject.LinearColor newLightColor)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLightColor_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(ParamsBuffer, SetLightColor_NewLightColor_Offset), 0, null, newLightColor);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLightColor_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetIntensity
    static readonly IntPtr SetIntensity_NativeFunction;
    static readonly int SetIntensity_ParamsSize;
    static readonly int SetIntensity_NewIntensity_Offset;
    
    public void SetIntensity(float newIntensity)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetIntensity_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetIntensity_NewIntensity_Offset), 0, null, newIntensity);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetIntensity_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetIndirectLightingIntensity
    static readonly IntPtr SetIndirectLightingIntensity_NativeFunction;
    static readonly int SetIndirectLightingIntensity_ParamsSize;
    static readonly int SetIndirectLightingIntensity_NewIntensity_Offset;
    
    public void SetIndirectLightingIntensity(float newIntensity)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetIndirectLightingIntensity_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetIndirectLightingIntensity_NewIntensity_Offset), 0, null, newIntensity);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetIndirectLightingIntensity_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetCubemapBlend
    static readonly IntPtr SetCubemapBlend_NativeFunction;
    static readonly int SetCubemapBlend_ParamsSize;
    static readonly int SetCubemapBlend_SourceCubemap_Offset;
    static readonly int SetCubemapBlend_DestinationCubemap_Offset;
    static readonly int SetCubemapBlend_InBlendFraction_Offset;
    
    public void SetCubemapBlend(UnrealSharp.Engine.TextureCube sourceCubemap, UnrealSharp.Engine.TextureCube destinationCubemap, float inBlendFraction)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCubemapBlend_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.TextureCube>.ToNative(IntPtr.Add(ParamsBuffer, SetCubemapBlend_SourceCubemap_Offset), 0, null, sourceCubemap);
            ObjectMarshaller<UnrealSharp.Engine.TextureCube>.ToNative(IntPtr.Add(ParamsBuffer, SetCubemapBlend_DestinationCubemap_Offset), 0, null, destinationCubemap);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetCubemapBlend_InBlendFraction_Offset), 0, null, inBlendFraction);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCubemapBlend_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:SetCubemap
    static readonly IntPtr SetCubemap_NativeFunction;
    static readonly int SetCubemap_ParamsSize;
    static readonly int SetCubemap_NewCubemap_Offset;
    
    public void SetCubemap(UnrealSharp.Engine.TextureCube newCubemap)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCubemap_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.TextureCube>.ToNative(IntPtr.Add(ParamsBuffer, SetCubemap_NewCubemap_Offset), 0, null, newCubemap);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCubemap_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkyLightComponent:RecaptureSky
    static readonly IntPtr RecaptureSky_NativeFunction;
    
    public void RecaptureSky()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RecaptureSky_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}