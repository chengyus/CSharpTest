using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct PostProcessSettings
{
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_TemperatureType
    static readonly int bOverride_TemperatureType_Offset;
    static readonly IntPtr bOverride_TemperatureType_NativeProperty;
    public bool Override_TemperatureType;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_WhiteTemp
    static readonly int bOverride_WhiteTemp_Offset;
    static readonly IntPtr bOverride_WhiteTemp_NativeProperty;
    public bool Override_WhiteTemp;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_WhiteTint
    static readonly int bOverride_WhiteTint_Offset;
    static readonly IntPtr bOverride_WhiteTint_NativeProperty;
    public bool Override_WhiteTint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorSaturation
    static readonly int bOverride_ColorSaturation_Offset;
    static readonly IntPtr bOverride_ColorSaturation_NativeProperty;
    public bool Override_ColorSaturation;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorContrast
    static readonly int bOverride_ColorContrast_Offset;
    static readonly IntPtr bOverride_ColorContrast_NativeProperty;
    public bool Override_ColorContrast;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGamma
    static readonly int bOverride_ColorGamma_Offset;
    static readonly IntPtr bOverride_ColorGamma_NativeProperty;
    public bool Override_ColorGamma;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGain
    static readonly int bOverride_ColorGain_Offset;
    static readonly IntPtr bOverride_ColorGain_NativeProperty;
    public bool Override_ColorGain;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorOffset
    static readonly int bOverride_ColorOffset_Offset;
    static readonly IntPtr bOverride_ColorOffset_NativeProperty;
    public bool Override_ColorOffset;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorSaturationShadows
    static readonly int bOverride_ColorSaturationShadows_Offset;
    static readonly IntPtr bOverride_ColorSaturationShadows_NativeProperty;
    public bool Override_ColorSaturationShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorContrastShadows
    static readonly int bOverride_ColorContrastShadows_Offset;
    static readonly IntPtr bOverride_ColorContrastShadows_NativeProperty;
    public bool Override_ColorContrastShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGammaShadows
    static readonly int bOverride_ColorGammaShadows_Offset;
    static readonly IntPtr bOverride_ColorGammaShadows_NativeProperty;
    public bool Override_ColorGammaShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGainShadows
    static readonly int bOverride_ColorGainShadows_Offset;
    static readonly IntPtr bOverride_ColorGainShadows_NativeProperty;
    public bool Override_ColorGainShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorOffsetShadows
    static readonly int bOverride_ColorOffsetShadows_Offset;
    static readonly IntPtr bOverride_ColorOffsetShadows_NativeProperty;
    public bool Override_ColorOffsetShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorSaturationMidtones
    static readonly int bOverride_ColorSaturationMidtones_Offset;
    static readonly IntPtr bOverride_ColorSaturationMidtones_NativeProperty;
    public bool Override_ColorSaturationMidtones;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorContrastMidtones
    static readonly int bOverride_ColorContrastMidtones_Offset;
    static readonly IntPtr bOverride_ColorContrastMidtones_NativeProperty;
    public bool Override_ColorContrastMidtones;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGammaMidtones
    static readonly int bOverride_ColorGammaMidtones_Offset;
    static readonly IntPtr bOverride_ColorGammaMidtones_NativeProperty;
    public bool Override_ColorGammaMidtones;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGainMidtones
    static readonly int bOverride_ColorGainMidtones_Offset;
    static readonly IntPtr bOverride_ColorGainMidtones_NativeProperty;
    public bool Override_ColorGainMidtones;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorOffsetMidtones
    static readonly int bOverride_ColorOffsetMidtones_Offset;
    static readonly IntPtr bOverride_ColorOffsetMidtones_NativeProperty;
    public bool Override_ColorOffsetMidtones;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorSaturationHighlights
    static readonly int bOverride_ColorSaturationHighlights_Offset;
    static readonly IntPtr bOverride_ColorSaturationHighlights_NativeProperty;
    public bool Override_ColorSaturationHighlights;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorContrastHighlights
    static readonly int bOverride_ColorContrastHighlights_Offset;
    static readonly IntPtr bOverride_ColorContrastHighlights_NativeProperty;
    public bool Override_ColorContrastHighlights;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGammaHighlights
    static readonly int bOverride_ColorGammaHighlights_Offset;
    static readonly IntPtr bOverride_ColorGammaHighlights_NativeProperty;
    public bool Override_ColorGammaHighlights;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGainHighlights
    static readonly int bOverride_ColorGainHighlights_Offset;
    static readonly IntPtr bOverride_ColorGainHighlights_NativeProperty;
    public bool Override_ColorGainHighlights;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorOffsetHighlights
    static readonly int bOverride_ColorOffsetHighlights_Offset;
    static readonly IntPtr bOverride_ColorOffsetHighlights_NativeProperty;
    public bool Override_ColorOffsetHighlights;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorCorrectionShadowsMax
    static readonly int bOverride_ColorCorrectionShadowsMax_Offset;
    static readonly IntPtr bOverride_ColorCorrectionShadowsMax_NativeProperty;
    public bool Override_ColorCorrectionShadowsMax;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorCorrectionHighlightsMin
    static readonly int bOverride_ColorCorrectionHighlightsMin_Offset;
    static readonly IntPtr bOverride_ColorCorrectionHighlightsMin_NativeProperty;
    public bool Override_ColorCorrectionHighlightsMin;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorCorrectionHighlightsMax
    static readonly int bOverride_ColorCorrectionHighlightsMax_Offset;
    static readonly IntPtr bOverride_ColorCorrectionHighlightsMax_NativeProperty;
    public bool Override_ColorCorrectionHighlightsMax;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BlueCorrection
    static readonly int bOverride_BlueCorrection_Offset;
    static readonly IntPtr bOverride_BlueCorrection_NativeProperty;
    public bool Override_BlueCorrection;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ExpandGamut
    static readonly int bOverride_ExpandGamut_Offset;
    static readonly IntPtr bOverride_ExpandGamut_NativeProperty;
    public bool Override_ExpandGamut;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ToneCurveAmount
    static readonly int bOverride_ToneCurveAmount_Offset;
    static readonly IntPtr bOverride_ToneCurveAmount_NativeProperty;
    public bool Override_ToneCurveAmount;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmSlope
    static readonly int bOverride_FilmSlope_Offset;
    static readonly IntPtr bOverride_FilmSlope_NativeProperty;
    public bool Override_FilmSlope;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmToe
    static readonly int bOverride_FilmToe_Offset;
    static readonly IntPtr bOverride_FilmToe_NativeProperty;
    public bool Override_FilmToe;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmShoulder
    static readonly int bOverride_FilmShoulder_Offset;
    static readonly IntPtr bOverride_FilmShoulder_NativeProperty;
    public bool Override_FilmShoulder;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmBlackClip
    static readonly int bOverride_FilmBlackClip_Offset;
    static readonly IntPtr bOverride_FilmBlackClip_NativeProperty;
    public bool Override_FilmBlackClip;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmWhiteClip
    static readonly int bOverride_FilmWhiteClip_Offset;
    static readonly IntPtr bOverride_FilmWhiteClip_NativeProperty;
    public bool Override_FilmWhiteClip;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_SceneColorTint
    static readonly int bOverride_SceneColorTint_Offset;
    static readonly IntPtr bOverride_SceneColorTint_NativeProperty;
    public bool Override_SceneColorTint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_SceneFringeIntensity
    static readonly int bOverride_SceneFringeIntensity_Offset;
    static readonly IntPtr bOverride_SceneFringeIntensity_NativeProperty;
    public bool Override_SceneFringeIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ChromaticAberrationStartOffset
    static readonly int bOverride_ChromaticAberrationStartOffset_Offset;
    static readonly IntPtr bOverride_ChromaticAberrationStartOffset_NativeProperty;
    public bool Override_ChromaticAberrationStartOffset;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientCubemapTint
    static readonly int bOverride_AmbientCubemapTint_Offset;
    static readonly IntPtr bOverride_AmbientCubemapTint_NativeProperty;
    public bool Override_AmbientCubemapTint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientCubemapIntensity
    static readonly int bOverride_AmbientCubemapIntensity_Offset;
    static readonly IntPtr bOverride_AmbientCubemapIntensity_NativeProperty;
    public bool Override_AmbientCubemapIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomMethod
    static readonly int bOverride_BloomMethod_Offset;
    static readonly IntPtr bOverride_BloomMethod_NativeProperty;
    public bool Override_BloomMethod;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomIntensity
    static readonly int bOverride_BloomIntensity_Offset;
    static readonly IntPtr bOverride_BloomIntensity_NativeProperty;
    public bool Override_BloomIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomThreshold
    static readonly int bOverride_BloomThreshold_Offset;
    static readonly IntPtr bOverride_BloomThreshold_NativeProperty;
    public bool Override_BloomThreshold;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom1Tint
    static readonly int bOverride_Bloom1Tint_Offset;
    static readonly IntPtr bOverride_Bloom1Tint_NativeProperty;
    public bool Override_Bloom1Tint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom1Size
    static readonly int bOverride_Bloom1Size_Offset;
    static readonly IntPtr bOverride_Bloom1Size_NativeProperty;
    public bool Override_Bloom1Size;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom2Size
    static readonly int bOverride_Bloom2Size_Offset;
    static readonly IntPtr bOverride_Bloom2Size_NativeProperty;
    public bool Override_Bloom2Size;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom2Tint
    static readonly int bOverride_Bloom2Tint_Offset;
    static readonly IntPtr bOverride_Bloom2Tint_NativeProperty;
    public bool Override_Bloom2Tint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom3Tint
    static readonly int bOverride_Bloom3Tint_Offset;
    static readonly IntPtr bOverride_Bloom3Tint_NativeProperty;
    public bool Override_Bloom3Tint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom3Size
    static readonly int bOverride_Bloom3Size_Offset;
    static readonly IntPtr bOverride_Bloom3Size_NativeProperty;
    public bool Override_Bloom3Size;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom4Tint
    static readonly int bOverride_Bloom4Tint_Offset;
    static readonly IntPtr bOverride_Bloom4Tint_NativeProperty;
    public bool Override_Bloom4Tint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom4Size
    static readonly int bOverride_Bloom4Size_Offset;
    static readonly IntPtr bOverride_Bloom4Size_NativeProperty;
    public bool Override_Bloom4Size;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom5Tint
    static readonly int bOverride_Bloom5Tint_Offset;
    static readonly IntPtr bOverride_Bloom5Tint_NativeProperty;
    public bool Override_Bloom5Tint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom5Size
    static readonly int bOverride_Bloom5Size_Offset;
    static readonly IntPtr bOverride_Bloom5Size_NativeProperty;
    public bool Override_Bloom5Size;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom6Tint
    static readonly int bOverride_Bloom6Tint_Offset;
    static readonly IntPtr bOverride_Bloom6Tint_NativeProperty;
    public bool Override_Bloom6Tint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Bloom6Size
    static readonly int bOverride_Bloom6Size_Offset;
    static readonly IntPtr bOverride_Bloom6Size_NativeProperty;
    public bool Override_Bloom6Size;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomSizeScale
    static readonly int bOverride_BloomSizeScale_Offset;
    static readonly IntPtr bOverride_BloomSizeScale_NativeProperty;
    public bool Override_BloomSizeScale;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomConvolutionTexture
    static readonly int bOverride_BloomConvolutionTexture_Offset;
    static readonly IntPtr bOverride_BloomConvolutionTexture_NativeProperty;
    public bool Override_BloomConvolutionTexture;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomConvolutionScatterDispersion
    static readonly int bOverride_BloomConvolutionScatterDispersion_Offset;
    static readonly IntPtr bOverride_BloomConvolutionScatterDispersion_NativeProperty;
    public bool Override_BloomConvolutionScatterDispersion;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomConvolutionSize
    static readonly int bOverride_BloomConvolutionSize_Offset;
    static readonly IntPtr bOverride_BloomConvolutionSize_NativeProperty;
    public bool Override_BloomConvolutionSize;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomConvolutionCenterUV
    static readonly int bOverride_BloomConvolutionCenterUV_Offset;
    static readonly IntPtr bOverride_BloomConvolutionCenterUV_NativeProperty;
    public bool Override_BloomConvolutionCenterUV;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomConvolutionPreFilterMin
    static readonly int bOverride_BloomConvolutionPreFilterMin_Offset;
    static readonly IntPtr bOverride_BloomConvolutionPreFilterMin_NativeProperty;
    public bool Override_BloomConvolutionPreFilterMin;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomConvolutionPreFilterMax
    static readonly int bOverride_BloomConvolutionPreFilterMax_Offset;
    static readonly IntPtr bOverride_BloomConvolutionPreFilterMax_NativeProperty;
    public bool Override_BloomConvolutionPreFilterMax;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomConvolutionPreFilterMult
    static readonly int bOverride_BloomConvolutionPreFilterMult_Offset;
    static readonly IntPtr bOverride_BloomConvolutionPreFilterMult_NativeProperty;
    public bool Override_BloomConvolutionPreFilterMult;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomConvolutionBufferScale
    static readonly int bOverride_BloomConvolutionBufferScale_Offset;
    static readonly IntPtr bOverride_BloomConvolutionBufferScale_NativeProperty;
    public bool Override_BloomConvolutionBufferScale;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomDirtMaskIntensity
    static readonly int bOverride_BloomDirtMaskIntensity_Offset;
    static readonly IntPtr bOverride_BloomDirtMaskIntensity_NativeProperty;
    public bool Override_BloomDirtMaskIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomDirtMaskTint
    static readonly int bOverride_BloomDirtMaskTint_Offset;
    static readonly IntPtr bOverride_BloomDirtMaskTint_NativeProperty;
    public bool Override_BloomDirtMaskTint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_BloomDirtMask
    static readonly int bOverride_BloomDirtMask_Offset;
    static readonly IntPtr bOverride_BloomDirtMask_NativeProperty;
    public bool Override_BloomDirtMask;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_CameraShutterSpeed
    static readonly int bOverride_CameraShutterSpeed_Offset;
    static readonly IntPtr bOverride_CameraShutterSpeed_NativeProperty;
    public bool Override_CameraShutterSpeed;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_CameraISO
    static readonly int bOverride_CameraISO_Offset;
    static readonly IntPtr bOverride_CameraISO_NativeProperty;
    public bool Override_CameraISO;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureMethod
    static readonly int bOverride_AutoExposureMethod_Offset;
    static readonly IntPtr bOverride_AutoExposureMethod_NativeProperty;
    public bool Override_AutoExposureMethod;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureLowPercent
    static readonly int bOverride_AutoExposureLowPercent_Offset;
    static readonly IntPtr bOverride_AutoExposureLowPercent_NativeProperty;
    public bool Override_AutoExposureLowPercent;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureHighPercent
    static readonly int bOverride_AutoExposureHighPercent_Offset;
    static readonly IntPtr bOverride_AutoExposureHighPercent_NativeProperty;
    public bool Override_AutoExposureHighPercent;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureMinBrightness
    static readonly int bOverride_AutoExposureMinBrightness_Offset;
    static readonly IntPtr bOverride_AutoExposureMinBrightness_NativeProperty;
    public bool Override_AutoExposureMinBrightness;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureMaxBrightness
    static readonly int bOverride_AutoExposureMaxBrightness_Offset;
    static readonly IntPtr bOverride_AutoExposureMaxBrightness_NativeProperty;
    public bool Override_AutoExposureMaxBrightness;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureSpeedUp
    static readonly int bOverride_AutoExposureSpeedUp_Offset;
    static readonly IntPtr bOverride_AutoExposureSpeedUp_NativeProperty;
    public bool Override_AutoExposureSpeedUp;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureSpeedDown
    static readonly int bOverride_AutoExposureSpeedDown_Offset;
    static readonly IntPtr bOverride_AutoExposureSpeedDown_NativeProperty;
    public bool Override_AutoExposureSpeedDown;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureBias
    static readonly int bOverride_AutoExposureBias_Offset;
    static readonly IntPtr bOverride_AutoExposureBias_NativeProperty;
    public bool Override_AutoExposureBias;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureBiasCurve
    static readonly int bOverride_AutoExposureBiasCurve_Offset;
    static readonly IntPtr bOverride_AutoExposureBiasCurve_NativeProperty;
    public bool Override_AutoExposureBiasCurve;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureMeterMask
    static readonly int bOverride_AutoExposureMeterMask_Offset;
    static readonly IntPtr bOverride_AutoExposureMeterMask_NativeProperty;
    public bool Override_AutoExposureMeterMask;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AutoExposureApplyPhysicalCameraExposure
    static readonly int bOverride_AutoExposureApplyPhysicalCameraExposure_Offset;
    static readonly IntPtr bOverride_AutoExposureApplyPhysicalCameraExposure_NativeProperty;
    public bool Override_AutoExposureApplyPhysicalCameraExposure;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_HistogramLogMin
    static readonly int bOverride_HistogramLogMin_Offset;
    static readonly IntPtr bOverride_HistogramLogMin_NativeProperty;
    public bool Override_HistogramLogMin;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_HistogramLogMax
    static readonly int bOverride_HistogramLogMax_Offset;
    static readonly IntPtr bOverride_HistogramLogMax_NativeProperty;
    public bool Override_HistogramLogMax;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LocalExposureHighlightContrastScale
    static readonly int bOverride_LocalExposureHighlightContrastScale_Offset;
    static readonly IntPtr bOverride_LocalExposureHighlightContrastScale_NativeProperty;
    public bool Override_LocalExposureHighlightContrastScale;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LocalExposureShadowContrastScale
    static readonly int bOverride_LocalExposureShadowContrastScale_Offset;
    static readonly IntPtr bOverride_LocalExposureShadowContrastScale_NativeProperty;
    public bool Override_LocalExposureShadowContrastScale;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LocalExposureDetailStrength
    static readonly int bOverride_LocalExposureDetailStrength_Offset;
    static readonly IntPtr bOverride_LocalExposureDetailStrength_NativeProperty;
    public bool Override_LocalExposureDetailStrength;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LocalExposureBlurredLuminanceBlend
    static readonly int bOverride_LocalExposureBlurredLuminanceBlend_Offset;
    static readonly IntPtr bOverride_LocalExposureBlurredLuminanceBlend_NativeProperty;
    public bool Override_LocalExposureBlurredLuminanceBlend;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LocalExposureBlurredLuminanceKernelSizePercent
    static readonly int bOverride_LocalExposureBlurredLuminanceKernelSizePercent_Offset;
    static readonly IntPtr bOverride_LocalExposureBlurredLuminanceKernelSizePercent_NativeProperty;
    public bool Override_LocalExposureBlurredLuminanceKernelSizePercent;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LocalExposureMiddleGreyBias
    static readonly int bOverride_LocalExposureMiddleGreyBias_Offset;
    static readonly IntPtr bOverride_LocalExposureMiddleGreyBias_NativeProperty;
    public bool Override_LocalExposureMiddleGreyBias;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LensFlareIntensity
    static readonly int bOverride_LensFlareIntensity_Offset;
    static readonly IntPtr bOverride_LensFlareIntensity_NativeProperty;
    public bool Override_LensFlareIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LensFlareTint
    static readonly int bOverride_LensFlareTint_Offset;
    static readonly IntPtr bOverride_LensFlareTint_NativeProperty;
    public bool Override_LensFlareTint;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LensFlareTints
    static readonly int bOverride_LensFlareTints_Offset;
    static readonly IntPtr bOverride_LensFlareTints_NativeProperty;
    public bool Override_LensFlareTints;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LensFlareBokehSize
    static readonly int bOverride_LensFlareBokehSize_Offset;
    static readonly IntPtr bOverride_LensFlareBokehSize_NativeProperty;
    public bool Override_LensFlareBokehSize;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LensFlareBokehShape
    static readonly int bOverride_LensFlareBokehShape_Offset;
    static readonly IntPtr bOverride_LensFlareBokehShape_NativeProperty;
    public bool Override_LensFlareBokehShape;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LensFlareThreshold
    static readonly int bOverride_LensFlareThreshold_Offset;
    static readonly IntPtr bOverride_LensFlareThreshold_NativeProperty;
    public bool Override_LensFlareThreshold;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_VignetteIntensity
    static readonly int bOverride_VignetteIntensity_Offset;
    static readonly IntPtr bOverride_VignetteIntensity_NativeProperty;
    public bool Override_VignetteIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_Sharpen
    static readonly int bOverride_Sharpen_Offset;
    static readonly IntPtr bOverride_Sharpen_NativeProperty;
    public bool Override_Sharpen;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainIntensity
    static readonly int bOverride_FilmGrainIntensity_Offset;
    static readonly IntPtr bOverride_FilmGrainIntensity_NativeProperty;
    public bool Override_FilmGrainIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainIntensityShadows
    static readonly int bOverride_FilmGrainIntensityShadows_Offset;
    static readonly IntPtr bOverride_FilmGrainIntensityShadows_NativeProperty;
    public bool Override_FilmGrainIntensityShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainIntensityMidtones
    static readonly int bOverride_FilmGrainIntensityMidtones_Offset;
    static readonly IntPtr bOverride_FilmGrainIntensityMidtones_NativeProperty;
    public bool Override_FilmGrainIntensityMidtones;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainIntensityHighlights
    static readonly int bOverride_FilmGrainIntensityHighlights_Offset;
    static readonly IntPtr bOverride_FilmGrainIntensityHighlights_NativeProperty;
    public bool Override_FilmGrainIntensityHighlights;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainShadowsMax
    static readonly int bOverride_FilmGrainShadowsMax_Offset;
    static readonly IntPtr bOverride_FilmGrainShadowsMax_NativeProperty;
    public bool Override_FilmGrainShadowsMax;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainHighlightsMin
    static readonly int bOverride_FilmGrainHighlightsMin_Offset;
    static readonly IntPtr bOverride_FilmGrainHighlightsMin_NativeProperty;
    public bool Override_FilmGrainHighlightsMin;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainHighlightsMax
    static readonly int bOverride_FilmGrainHighlightsMax_Offset;
    static readonly IntPtr bOverride_FilmGrainHighlightsMax_NativeProperty;
    public bool Override_FilmGrainHighlightsMax;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainTexelSize
    static readonly int bOverride_FilmGrainTexelSize_Offset;
    static readonly IntPtr bOverride_FilmGrainTexelSize_NativeProperty;
    public bool Override_FilmGrainTexelSize;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_FilmGrainTexture
    static readonly int bOverride_FilmGrainTexture_Offset;
    static readonly IntPtr bOverride_FilmGrainTexture_NativeProperty;
    public bool Override_FilmGrainTexture;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionIntensity
    static readonly int bOverride_AmbientOcclusionIntensity_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionIntensity_NativeProperty;
    public bool Override_AmbientOcclusionIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionStaticFraction
    static readonly int bOverride_AmbientOcclusionStaticFraction_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionStaticFraction_NativeProperty;
    public bool Override_AmbientOcclusionStaticFraction;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionRadius
    static readonly int bOverride_AmbientOcclusionRadius_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionRadius_NativeProperty;
    public bool Override_AmbientOcclusionRadius;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionFadeDistance
    static readonly int bOverride_AmbientOcclusionFadeDistance_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionFadeDistance_NativeProperty;
    public bool Override_AmbientOcclusionFadeDistance;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionFadeRadius
    static readonly int bOverride_AmbientOcclusionFadeRadius_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionFadeRadius_NativeProperty;
    public bool Override_AmbientOcclusionFadeRadius;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionRadiusInWS
    static readonly int bOverride_AmbientOcclusionRadiusInWS_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionRadiusInWS_NativeProperty;
    public bool Override_AmbientOcclusionRadiusInWS;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionPower
    static readonly int bOverride_AmbientOcclusionPower_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionPower_NativeProperty;
    public bool Override_AmbientOcclusionPower;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionBias
    static readonly int bOverride_AmbientOcclusionBias_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionBias_NativeProperty;
    public bool Override_AmbientOcclusionBias;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionQuality
    static readonly int bOverride_AmbientOcclusionQuality_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionQuality_NativeProperty;
    public bool Override_AmbientOcclusionQuality;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionMipBlend
    static readonly int bOverride_AmbientOcclusionMipBlend_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionMipBlend_NativeProperty;
    public bool Override_AmbientOcclusionMipBlend;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionMipScale
    static readonly int bOverride_AmbientOcclusionMipScale_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionMipScale_NativeProperty;
    public bool Override_AmbientOcclusionMipScale;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionMipThreshold
    static readonly int bOverride_AmbientOcclusionMipThreshold_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionMipThreshold_NativeProperty;
    public bool Override_AmbientOcclusionMipThreshold;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_AmbientOcclusionTemporalBlendWeight
    static readonly int bOverride_AmbientOcclusionTemporalBlendWeight_Offset;
    static readonly IntPtr bOverride_AmbientOcclusionTemporalBlendWeight_NativeProperty;
    public bool Override_AmbientOcclusionTemporalBlendWeight;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingAO
    static readonly int bOverride_RayTracingAO_Offset;
    static readonly IntPtr bOverride_RayTracingAO_NativeProperty;
    public bool Override_RayTracingAO;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingAOSamplesPerPixel
    static readonly int bOverride_RayTracingAOSamplesPerPixel_Offset;
    static readonly IntPtr bOverride_RayTracingAOSamplesPerPixel_NativeProperty;
    public bool Override_RayTracingAOSamplesPerPixel;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingAOIntensity
    static readonly int bOverride_RayTracingAOIntensity_Offset;
    static readonly IntPtr bOverride_RayTracingAOIntensity_NativeProperty;
    public bool Override_RayTracingAOIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingAORadius
    static readonly int bOverride_RayTracingAORadius_Offset;
    static readonly IntPtr bOverride_RayTracingAORadius_NativeProperty;
    public bool Override_RayTracingAORadius;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_IndirectLightingColor
    static readonly int bOverride_IndirectLightingColor_Offset;
    static readonly IntPtr bOverride_IndirectLightingColor_NativeProperty;
    public bool Override_IndirectLightingColor;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_IndirectLightingIntensity
    static readonly int bOverride_IndirectLightingIntensity_Offset;
    static readonly IntPtr bOverride_IndirectLightingIntensity_NativeProperty;
    public bool Override_IndirectLightingIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGradingIntensity
    static readonly int bOverride_ColorGradingIntensity_Offset;
    static readonly IntPtr bOverride_ColorGradingIntensity_NativeProperty;
    public bool Override_ColorGradingIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ColorGradingLUT
    static readonly int bOverride_ColorGradingLUT_Offset;
    static readonly IntPtr bOverride_ColorGradingLUT_NativeProperty;
    public bool Override_ColorGradingLUT;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldFocalDistance
    static readonly int bOverride_DepthOfFieldFocalDistance_Offset;
    static readonly IntPtr bOverride_DepthOfFieldFocalDistance_NativeProperty;
    public bool Override_DepthOfFieldFocalDistance;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldFstop
    static readonly int bOverride_DepthOfFieldFstop_Offset;
    static readonly IntPtr bOverride_DepthOfFieldFstop_NativeProperty;
    public bool Override_DepthOfFieldFstop;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldMinFstop
    static readonly int bOverride_DepthOfFieldMinFstop_Offset;
    static readonly IntPtr bOverride_DepthOfFieldMinFstop_NativeProperty;
    public bool Override_DepthOfFieldMinFstop;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldBladeCount
    static readonly int bOverride_DepthOfFieldBladeCount_Offset;
    static readonly IntPtr bOverride_DepthOfFieldBladeCount_NativeProperty;
    public bool Override_DepthOfFieldBladeCount;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldSensorWidth
    static readonly int bOverride_DepthOfFieldSensorWidth_Offset;
    static readonly IntPtr bOverride_DepthOfFieldSensorWidth_NativeProperty;
    public bool Override_DepthOfFieldSensorWidth;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldSqueezeFactor
    static readonly int bOverride_DepthOfFieldSqueezeFactor_Offset;
    static readonly IntPtr bOverride_DepthOfFieldSqueezeFactor_NativeProperty;
    public bool Override_DepthOfFieldSqueezeFactor;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldDepthBlurRadius
    static readonly int bOverride_DepthOfFieldDepthBlurRadius_Offset;
    static readonly IntPtr bOverride_DepthOfFieldDepthBlurRadius_NativeProperty;
    public bool Override_DepthOfFieldDepthBlurRadius;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldDepthBlurAmount
    static readonly int bOverride_DepthOfFieldDepthBlurAmount_Offset;
    static readonly IntPtr bOverride_DepthOfFieldDepthBlurAmount_NativeProperty;
    public bool Override_DepthOfFieldDepthBlurAmount;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldFocalRegion
    static readonly int bOverride_DepthOfFieldFocalRegion_Offset;
    static readonly IntPtr bOverride_DepthOfFieldFocalRegion_NativeProperty;
    public bool Override_DepthOfFieldFocalRegion;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldNearTransitionRegion
    static readonly int bOverride_DepthOfFieldNearTransitionRegion_Offset;
    static readonly IntPtr bOverride_DepthOfFieldNearTransitionRegion_NativeProperty;
    public bool Override_DepthOfFieldNearTransitionRegion;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldFarTransitionRegion
    static readonly int bOverride_DepthOfFieldFarTransitionRegion_Offset;
    static readonly IntPtr bOverride_DepthOfFieldFarTransitionRegion_NativeProperty;
    public bool Override_DepthOfFieldFarTransitionRegion;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldScale
    static readonly int bOverride_DepthOfFieldScale_Offset;
    static readonly IntPtr bOverride_DepthOfFieldScale_NativeProperty;
    public bool Override_DepthOfFieldScale;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldNearBlurSize
    static readonly int bOverride_DepthOfFieldNearBlurSize_Offset;
    static readonly IntPtr bOverride_DepthOfFieldNearBlurSize_NativeProperty;
    public bool Override_DepthOfFieldNearBlurSize;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldFarBlurSize
    static readonly int bOverride_DepthOfFieldFarBlurSize_Offset;
    static readonly IntPtr bOverride_DepthOfFieldFarBlurSize_NativeProperty;
    public bool Override_DepthOfFieldFarBlurSize;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_MobileHQGaussian
    static readonly int bOverride_MobileHQGaussian_Offset;
    static readonly IntPtr bOverride_MobileHQGaussian_NativeProperty;
    public bool Override_MobileHQGaussian;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldOcclusion
    static readonly int bOverride_DepthOfFieldOcclusion_Offset;
    static readonly IntPtr bOverride_DepthOfFieldOcclusion_NativeProperty;
    public bool Override_DepthOfFieldOcclusion;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldSkyFocusDistance
    static readonly int bOverride_DepthOfFieldSkyFocusDistance_Offset;
    static readonly IntPtr bOverride_DepthOfFieldSkyFocusDistance_NativeProperty;
    public bool Override_DepthOfFieldSkyFocusDistance;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DepthOfFieldVignetteSize
    static readonly int bOverride_DepthOfFieldVignetteSize_Offset;
    static readonly IntPtr bOverride_DepthOfFieldVignetteSize_NativeProperty;
    public bool Override_DepthOfFieldVignetteSize;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_MotionBlurAmount
    static readonly int bOverride_MotionBlurAmount_Offset;
    static readonly IntPtr bOverride_MotionBlurAmount_NativeProperty;
    public bool Override_MotionBlurAmount;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_MotionBlurMax
    static readonly int bOverride_MotionBlurMax_Offset;
    static readonly IntPtr bOverride_MotionBlurMax_NativeProperty;
    public bool Override_MotionBlurMax;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_MotionBlurTargetFPS
    static readonly int bOverride_MotionBlurTargetFPS_Offset;
    static readonly IntPtr bOverride_MotionBlurTargetFPS_NativeProperty;
    public bool Override_MotionBlurTargetFPS;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_MotionBlurPerObjectSize
    static readonly int bOverride_MotionBlurPerObjectSize_Offset;
    static readonly IntPtr bOverride_MotionBlurPerObjectSize_NativeProperty;
    public bool Override_MotionBlurPerObjectSize;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ReflectionMethod
    static readonly int bOverride_ReflectionMethod_Offset;
    static readonly IntPtr bOverride_ReflectionMethod_NativeProperty;
    public bool Override_ReflectionMethod;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenReflectionQuality
    static readonly int bOverride_LumenReflectionQuality_Offset;
    static readonly IntPtr bOverride_LumenReflectionQuality_NativeProperty;
    public bool Override_LumenReflectionQuality;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ScreenSpaceReflectionIntensity
    static readonly int bOverride_ScreenSpaceReflectionIntensity_Offset;
    static readonly IntPtr bOverride_ScreenSpaceReflectionIntensity_NativeProperty;
    public bool Override_ScreenSpaceReflectionIntensity;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ScreenSpaceReflectionQuality
    static readonly int bOverride_ScreenSpaceReflectionQuality_Offset;
    static readonly IntPtr bOverride_ScreenSpaceReflectionQuality_NativeProperty;
    public bool Override_ScreenSpaceReflectionQuality;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ScreenSpaceReflectionMaxRoughness
    static readonly int bOverride_ScreenSpaceReflectionMaxRoughness_Offset;
    static readonly IntPtr bOverride_ScreenSpaceReflectionMaxRoughness_NativeProperty;
    public bool Override_ScreenSpaceReflectionMaxRoughness;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_ScreenSpaceReflectionRoughnessScale
    static readonly int bOverride_ScreenSpaceReflectionRoughnessScale_Offset;
    static readonly IntPtr bOverride_ScreenSpaceReflectionRoughnessScale_NativeProperty;
    public bool Override_ScreenSpaceReflectionRoughnessScale;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingReflectionsMaxRoughness
    static readonly int bOverride_RayTracingReflectionsMaxRoughness_Offset;
    static readonly IntPtr bOverride_RayTracingReflectionsMaxRoughness_NativeProperty;
    public bool Override_RayTracingReflectionsMaxRoughness;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingReflectionsMaxBounces
    static readonly int bOverride_RayTracingReflectionsMaxBounces_Offset;
    static readonly IntPtr bOverride_RayTracingReflectionsMaxBounces_NativeProperty;
    public bool Override_RayTracingReflectionsMaxBounces;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingReflectionsSamplesPerPixel
    static readonly int bOverride_RayTracingReflectionsSamplesPerPixel_Offset;
    static readonly IntPtr bOverride_RayTracingReflectionsSamplesPerPixel_NativeProperty;
    public bool Override_RayTracingReflectionsSamplesPerPixel;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingReflectionsShadows
    static readonly int bOverride_RayTracingReflectionsShadows_Offset;
    static readonly IntPtr bOverride_RayTracingReflectionsShadows_NativeProperty;
    public bool Override_RayTracingReflectionsShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingReflectionsTranslucency
    static readonly int bOverride_RayTracingReflectionsTranslucency_Offset;
    static readonly IntPtr bOverride_RayTracingReflectionsTranslucency_NativeProperty;
    public bool Override_RayTracingReflectionsTranslucency;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_TranslucencyType
    static readonly int bOverride_TranslucencyType_Offset;
    static readonly IntPtr bOverride_TranslucencyType_NativeProperty;
    public bool Override_TranslucencyType;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingTranslucencyMaxRoughness
    static readonly int bOverride_RayTracingTranslucencyMaxRoughness_Offset;
    static readonly IntPtr bOverride_RayTracingTranslucencyMaxRoughness_NativeProperty;
    public bool Override_RayTracingTranslucencyMaxRoughness;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingTranslucencyRefractionRays
    static readonly int bOverride_RayTracingTranslucencyRefractionRays_Offset;
    static readonly IntPtr bOverride_RayTracingTranslucencyRefractionRays_NativeProperty;
    public bool Override_RayTracingTranslucencyRefractionRays;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingTranslucencySamplesPerPixel
    static readonly int bOverride_RayTracingTranslucencySamplesPerPixel_Offset;
    static readonly IntPtr bOverride_RayTracingTranslucencySamplesPerPixel_NativeProperty;
    public bool Override_RayTracingTranslucencySamplesPerPixel;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingTranslucencyShadows
    static readonly int bOverride_RayTracingTranslucencyShadows_Offset;
    static readonly IntPtr bOverride_RayTracingTranslucencyShadows_NativeProperty;
    public bool Override_RayTracingTranslucencyShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingTranslucencyRefraction
    static readonly int bOverride_RayTracingTranslucencyRefraction_Offset;
    static readonly IntPtr bOverride_RayTracingTranslucencyRefraction_NativeProperty;
    public bool Override_RayTracingTranslucencyRefraction;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_DynamicGlobalIlluminationMethod
    static readonly int bOverride_DynamicGlobalIlluminationMethod_Offset;
    static readonly IntPtr bOverride_DynamicGlobalIlluminationMethod_NativeProperty;
    public bool Override_DynamicGlobalIlluminationMethod;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenSceneLightingQuality
    static readonly int bOverride_LumenSceneLightingQuality_Offset;
    static readonly IntPtr bOverride_LumenSceneLightingQuality_NativeProperty;
    public bool Override_LumenSceneLightingQuality;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenSceneDetail
    static readonly int bOverride_LumenSceneDetail_Offset;
    static readonly IntPtr bOverride_LumenSceneDetail_NativeProperty;
    public bool Override_LumenSceneDetail;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenSceneViewDistance
    static readonly int bOverride_LumenSceneViewDistance_Offset;
    static readonly IntPtr bOverride_LumenSceneViewDistance_NativeProperty;
    public bool Override_LumenSceneViewDistance;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenSceneLightingUpdateSpeed
    static readonly int bOverride_LumenSceneLightingUpdateSpeed_Offset;
    static readonly IntPtr bOverride_LumenSceneLightingUpdateSpeed_NativeProperty;
    public bool Override_LumenSceneLightingUpdateSpeed;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenFinalGatherQuality
    static readonly int bOverride_LumenFinalGatherQuality_Offset;
    static readonly IntPtr bOverride_LumenFinalGatherQuality_NativeProperty;
    public bool Override_LumenFinalGatherQuality;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenFinalGatherLightingUpdateSpeed
    static readonly int bOverride_LumenFinalGatherLightingUpdateSpeed_Offset;
    static readonly IntPtr bOverride_LumenFinalGatherLightingUpdateSpeed_NativeProperty;
    public bool Override_LumenFinalGatherLightingUpdateSpeed;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenMaxTraceDistance
    static readonly int bOverride_LumenMaxTraceDistance_Offset;
    static readonly IntPtr bOverride_LumenMaxTraceDistance_NativeProperty;
    public bool Override_LumenMaxTraceDistance;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenDiffuseColorBoost
    static readonly int bOverride_LumenDiffuseColorBoost_Offset;
    static readonly IntPtr bOverride_LumenDiffuseColorBoost_NativeProperty;
    public bool Override_LumenDiffuseColorBoost;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenSkylightLeaking
    static readonly int bOverride_LumenSkylightLeaking_Offset;
    static readonly IntPtr bOverride_LumenSkylightLeaking_NativeProperty;
    public bool Override_LumenSkylightLeaking;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenFullSkylightLeakingDistance
    static readonly int bOverride_LumenFullSkylightLeakingDistance_Offset;
    static readonly IntPtr bOverride_LumenFullSkylightLeakingDistance_NativeProperty;
    public bool Override_LumenFullSkylightLeakingDistance;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenRayLightingMode
    static readonly int bOverride_LumenRayLightingMode_Offset;
    static readonly IntPtr bOverride_LumenRayLightingMode_NativeProperty;
    public bool Override_LumenRayLightingMode;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenFrontLayerTranslucencyReflections
    static readonly int bOverride_LumenFrontLayerTranslucencyReflections_Offset;
    static readonly IntPtr bOverride_LumenFrontLayerTranslucencyReflections_NativeProperty;
    public bool Override_LumenFrontLayerTranslucencyReflections;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenMaxReflectionBounces
    static readonly int bOverride_LumenMaxReflectionBounces_Offset;
    static readonly IntPtr bOverride_LumenMaxReflectionBounces_NativeProperty;
    public bool Override_LumenMaxReflectionBounces;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_LumenSurfaceCacheResolution
    static readonly int bOverride_LumenSurfaceCacheResolution_Offset;
    static readonly IntPtr bOverride_LumenSurfaceCacheResolution_NativeProperty;
    public bool Override_LumenSurfaceCacheResolution;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingGI
    static readonly int bOverride_RayTracingGI_Offset;
    static readonly IntPtr bOverride_RayTracingGI_NativeProperty;
    public bool Override_RayTracingGI;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingGIMaxBounces
    static readonly int bOverride_RayTracingGIMaxBounces_Offset;
    static readonly IntPtr bOverride_RayTracingGIMaxBounces_NativeProperty;
    public bool Override_RayTracingGIMaxBounces;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_RayTracingGISamplesPerPixel
    static readonly int bOverride_RayTracingGISamplesPerPixel_Offset;
    static readonly IntPtr bOverride_RayTracingGISamplesPerPixel_NativeProperty;
    public bool Override_RayTracingGISamplesPerPixel;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingMaxBounces
    static readonly int bOverride_PathTracingMaxBounces_Offset;
    static readonly IntPtr bOverride_PathTracingMaxBounces_NativeProperty;
    public bool Override_PathTracingMaxBounces;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingSamplesPerPixel
    static readonly int bOverride_PathTracingSamplesPerPixel_Offset;
    static readonly IntPtr bOverride_PathTracingSamplesPerPixel_NativeProperty;
    public bool Override_PathTracingSamplesPerPixel;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingMaxPathExposure
    static readonly int bOverride_PathTracingMaxPathExposure_Offset;
    static readonly IntPtr bOverride_PathTracingMaxPathExposure_NativeProperty;
    public bool Override_PathTracingMaxPathExposure;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingEnableReferenceDOF
    static readonly int bOverride_PathTracingEnableReferenceDOF_Offset;
    static readonly IntPtr bOverride_PathTracingEnableReferenceDOF_NativeProperty;
    public bool Override_PathTracingEnableReferenceDOF;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingEnableReferenceAtmosphere
    static readonly int bOverride_PathTracingEnableReferenceAtmosphere_Offset;
    static readonly IntPtr bOverride_PathTracingEnableReferenceAtmosphere_NativeProperty;
    public bool Override_PathTracingEnableReferenceAtmosphere;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingEnableDenoiser
    static readonly int bOverride_PathTracingEnableDenoiser_Offset;
    static readonly IntPtr bOverride_PathTracingEnableDenoiser_NativeProperty;
    public bool Override_PathTracingEnableDenoiser;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingIncludeEmissive
    static readonly int bOverride_PathTracingIncludeEmissive_Offset;
    static readonly IntPtr bOverride_PathTracingIncludeEmissive_NativeProperty;
    public bool Override_PathTracingIncludeEmissive;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingIncludeIndirectEmissive
    static readonly int bOverride_PathTracingIncludeIndirectEmissive_Offset;
    static readonly IntPtr bOverride_PathTracingIncludeIndirectEmissive_NativeProperty;
    public bool Override_PathTracingIncludeIndirectEmissive;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingIncludeDiffuse
    static readonly int bOverride_PathTracingIncludeDiffuse_Offset;
    static readonly IntPtr bOverride_PathTracingIncludeDiffuse_NativeProperty;
    public bool Override_PathTracingIncludeDiffuse;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingIncludeIndirectDiffuse
    static readonly int bOverride_PathTracingIncludeIndirectDiffuse_Offset;
    static readonly IntPtr bOverride_PathTracingIncludeIndirectDiffuse_NativeProperty;
    public bool Override_PathTracingIncludeIndirectDiffuse;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingIncludeSpecular
    static readonly int bOverride_PathTracingIncludeSpecular_Offset;
    static readonly IntPtr bOverride_PathTracingIncludeSpecular_NativeProperty;
    public bool Override_PathTracingIncludeSpecular;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingIncludeIndirectSpecular
    static readonly int bOverride_PathTracingIncludeIndirectSpecular_Offset;
    static readonly IntPtr bOverride_PathTracingIncludeIndirectSpecular_NativeProperty;
    public bool Override_PathTracingIncludeIndirectSpecular;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingIncludeVolume
    static readonly int bOverride_PathTracingIncludeVolume_Offset;
    static readonly IntPtr bOverride_PathTracingIncludeVolume_NativeProperty;
    public bool Override_PathTracingIncludeVolume;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bOverride_PathTracingIncludeIndirectVolume
    static readonly int bOverride_PathTracingIncludeIndirectVolume_Offset;
    static readonly IntPtr bOverride_PathTracingIncludeIndirectVolume_NativeProperty;
    public bool Override_PathTracingIncludeIndirectVolume;
    
    // BoolProperty /Script/Engine.PostProcessSettings:bMobileHQGaussian
    static readonly int bMobileHQGaussian_Offset;
    static readonly IntPtr bMobileHQGaussian_NativeProperty;
    public bool MobileHQGaussian;
    
    // ByteProperty /Script/Engine.PostProcessSettings:BloomMethod
    static readonly int BloomMethod_Offset;
    public UnrealSharp.Engine.EBloomMethod BloomMethod;
    
    // ByteProperty /Script/Engine.PostProcessSettings:AutoExposureMethod
    static readonly int AutoExposureMethod_Offset;
    public UnrealSharp.Engine.EAutoExposureMethod AutoExposureMethod;
    
    // ByteProperty /Script/Engine.PostProcessSettings:TemperatureType
    static readonly int TemperatureType_Offset;
    public UnrealSharp.Engine.ETemperatureMethod TemperatureType;
    
    // FloatProperty /Script/Engine.PostProcessSettings:WhiteTemp
    static readonly int WhiteTemp_Offset;
    public float WhiteTemp;
    
    // FloatProperty /Script/Engine.PostProcessSettings:WhiteTint
    static readonly int WhiteTint_Offset;
    public float WhiteTint;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorSaturation
    static readonly int ColorSaturation_Offset;
    public System.DoubleNumerics.Vector4 ColorSaturation;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorContrast
    static readonly int ColorContrast_Offset;
    public System.DoubleNumerics.Vector4 ColorContrast;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorGamma
    static readonly int ColorGamma_Offset;
    public System.DoubleNumerics.Vector4 ColorGamma;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorGain
    static readonly int ColorGain_Offset;
    public System.DoubleNumerics.Vector4 ColorGain;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorOffset
    static readonly int ColorOffset_Offset;
    public System.DoubleNumerics.Vector4 ColorOffset;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorSaturationShadows
    static readonly int ColorSaturationShadows_Offset;
    public System.DoubleNumerics.Vector4 ColorSaturationShadows;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorContrastShadows
    static readonly int ColorContrastShadows_Offset;
    public System.DoubleNumerics.Vector4 ColorContrastShadows;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorGammaShadows
    static readonly int ColorGammaShadows_Offset;
    public System.DoubleNumerics.Vector4 ColorGammaShadows;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorGainShadows
    static readonly int ColorGainShadows_Offset;
    public System.DoubleNumerics.Vector4 ColorGainShadows;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorOffsetShadows
    static readonly int ColorOffsetShadows_Offset;
    public System.DoubleNumerics.Vector4 ColorOffsetShadows;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorSaturationMidtones
    static readonly int ColorSaturationMidtones_Offset;
    public System.DoubleNumerics.Vector4 ColorSaturationMidtones;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorContrastMidtones
    static readonly int ColorContrastMidtones_Offset;
    public System.DoubleNumerics.Vector4 ColorContrastMidtones;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorGammaMidtones
    static readonly int ColorGammaMidtones_Offset;
    public System.DoubleNumerics.Vector4 ColorGammaMidtones;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorGainMidtones
    static readonly int ColorGainMidtones_Offset;
    public System.DoubleNumerics.Vector4 ColorGainMidtones;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorOffsetMidtones
    static readonly int ColorOffsetMidtones_Offset;
    public System.DoubleNumerics.Vector4 ColorOffsetMidtones;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorSaturationHighlights
    static readonly int ColorSaturationHighlights_Offset;
    public System.DoubleNumerics.Vector4 ColorSaturationHighlights;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorContrastHighlights
    static readonly int ColorContrastHighlights_Offset;
    public System.DoubleNumerics.Vector4 ColorContrastHighlights;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorGammaHighlights
    static readonly int ColorGammaHighlights_Offset;
    public System.DoubleNumerics.Vector4 ColorGammaHighlights;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorGainHighlights
    static readonly int ColorGainHighlights_Offset;
    public System.DoubleNumerics.Vector4 ColorGainHighlights;
    
    // StructProperty /Script/Engine.PostProcessSettings:ColorOffsetHighlights
    static readonly int ColorOffsetHighlights_Offset;
    public System.DoubleNumerics.Vector4 ColorOffsetHighlights;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ColorCorrectionHighlightsMin
    static readonly int ColorCorrectionHighlightsMin_Offset;
    public float ColorCorrectionHighlightsMin;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ColorCorrectionHighlightsMax
    static readonly int ColorCorrectionHighlightsMax_Offset;
    public float ColorCorrectionHighlightsMax;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ColorCorrectionShadowsMax
    static readonly int ColorCorrectionShadowsMax_Offset;
    public float ColorCorrectionShadowsMax;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BlueCorrection
    static readonly int BlueCorrection_Offset;
    public float BlueCorrection;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ExpandGamut
    static readonly int ExpandGamut_Offset;
    public float ExpandGamut;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ToneCurveAmount
    static readonly int ToneCurveAmount_Offset;
    public float ToneCurveAmount;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmSlope
    static readonly int FilmSlope_Offset;
    public float FilmSlope;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmToe
    static readonly int FilmToe_Offset;
    public float FilmToe;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmShoulder
    static readonly int FilmShoulder_Offset;
    public float FilmShoulder;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmBlackClip
    static readonly int FilmBlackClip_Offset;
    public float FilmBlackClip;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmWhiteClip
    static readonly int FilmWhiteClip_Offset;
    public float FilmWhiteClip;
    
    // StructProperty /Script/Engine.PostProcessSettings:SceneColorTint
    static readonly int SceneColorTint_Offset;
    public UnrealSharp.CoreUObject.LinearColor SceneColorTint;
    
    // FloatProperty /Script/Engine.PostProcessSettings:SceneFringeIntensity
    static readonly int SceneFringeIntensity_Offset;
    public float SceneFringeIntensity;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ChromaticAberrationStartOffset
    static readonly int ChromaticAberrationStartOffset_Offset;
    public float ChromaticAberrationStartOffset;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomIntensity
    static readonly int BloomIntensity_Offset;
    public float BloomIntensity;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomThreshold
    static readonly int BloomThreshold_Offset;
    public float BloomThreshold;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomSizeScale
    static readonly int BloomSizeScale_Offset;
    public float BloomSizeScale;
    
    // FloatProperty /Script/Engine.PostProcessSettings:Bloom1Size
    static readonly int Bloom1Size_Offset;
    public float Bloom1Size;
    
    // FloatProperty /Script/Engine.PostProcessSettings:Bloom2Size
    static readonly int Bloom2Size_Offset;
    public float Bloom2Size;
    
    // FloatProperty /Script/Engine.PostProcessSettings:Bloom3Size
    static readonly int Bloom3Size_Offset;
    public float Bloom3Size;
    
    // FloatProperty /Script/Engine.PostProcessSettings:Bloom4Size
    static readonly int Bloom4Size_Offset;
    public float Bloom4Size;
    
    // FloatProperty /Script/Engine.PostProcessSettings:Bloom5Size
    static readonly int Bloom5Size_Offset;
    public float Bloom5Size;
    
    // FloatProperty /Script/Engine.PostProcessSettings:Bloom6Size
    static readonly int Bloom6Size_Offset;
    public float Bloom6Size;
    
    // StructProperty /Script/Engine.PostProcessSettings:Bloom1Tint
    static readonly int Bloom1Tint_Offset;
    public UnrealSharp.CoreUObject.LinearColor Bloom1Tint;
    
    // StructProperty /Script/Engine.PostProcessSettings:Bloom2Tint
    static readonly int Bloom2Tint_Offset;
    public UnrealSharp.CoreUObject.LinearColor Bloom2Tint;
    
    // StructProperty /Script/Engine.PostProcessSettings:Bloom3Tint
    static readonly int Bloom3Tint_Offset;
    public UnrealSharp.CoreUObject.LinearColor Bloom3Tint;
    
    // StructProperty /Script/Engine.PostProcessSettings:Bloom4Tint
    static readonly int Bloom4Tint_Offset;
    public UnrealSharp.CoreUObject.LinearColor Bloom4Tint;
    
    // StructProperty /Script/Engine.PostProcessSettings:Bloom5Tint
    static readonly int Bloom5Tint_Offset;
    public UnrealSharp.CoreUObject.LinearColor Bloom5Tint;
    
    // StructProperty /Script/Engine.PostProcessSettings:Bloom6Tint
    static readonly int Bloom6Tint_Offset;
    public UnrealSharp.CoreUObject.LinearColor Bloom6Tint;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomConvolutionScatterDispersion
    static readonly int BloomConvolutionScatterDispersion_Offset;
    public float BloomConvolutionScatterDispersion;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomConvolutionSize
    static readonly int BloomConvolutionSize_Offset;
    public float BloomConvolutionSize;
    
    // ObjectProperty /Script/Engine.PostProcessSettings:BloomConvolutionTexture
    static readonly int BloomConvolutionTexture_Offset;
    public UnrealSharp.Engine.Texture2D BloomConvolutionTexture;
    
    // StructProperty /Script/Engine.PostProcessSettings:BloomConvolutionCenterUV
    static readonly int BloomConvolutionCenterUV_Offset;
    public System.DoubleNumerics.Vector2 BloomConvolutionCenterUV;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomConvolutionPreFilterMin
    static readonly int BloomConvolutionPreFilterMin_Offset;
    public float BloomConvolutionPreFilterMin;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomConvolutionPreFilterMax
    static readonly int BloomConvolutionPreFilterMax_Offset;
    public float BloomConvolutionPreFilterMax;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomConvolutionPreFilterMult
    static readonly int BloomConvolutionPreFilterMult_Offset;
    public float BloomConvolutionPreFilterMult;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomConvolutionBufferScale
    static readonly int BloomConvolutionBufferScale_Offset;
    public float BloomConvolutionBufferScale;
    
    // ObjectProperty /Script/Engine.PostProcessSettings:BloomDirtMask
    static readonly int BloomDirtMask_Offset;
    public UnrealSharp.Engine.Texture BloomDirtMask;
    
    // FloatProperty /Script/Engine.PostProcessSettings:BloomDirtMaskIntensity
    static readonly int BloomDirtMaskIntensity_Offset;
    public float BloomDirtMaskIntensity;
    
    // StructProperty /Script/Engine.PostProcessSettings:BloomDirtMaskTint
    static readonly int BloomDirtMaskTint_Offset;
    public UnrealSharp.CoreUObject.LinearColor BloomDirtMaskTint;
    
    // ByteProperty /Script/Engine.PostProcessSettings:DynamicGlobalIlluminationMethod
    static readonly int DynamicGlobalIlluminationMethod_Offset;
    public UnrealSharp.Engine.EDynamicGlobalIlluminationMethod DynamicGlobalIlluminationMethod;
    
    // StructProperty /Script/Engine.PostProcessSettings:IndirectLightingColor
    static readonly int IndirectLightingColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor IndirectLightingColor;
    
    // FloatProperty /Script/Engine.PostProcessSettings:IndirectLightingIntensity
    static readonly int IndirectLightingIntensity_Offset;
    public float IndirectLightingIntensity;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenSceneLightingQuality
    static readonly int LumenSceneLightingQuality_Offset;
    public float LumenSceneLightingQuality;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenSceneDetail
    static readonly int LumenSceneDetail_Offset;
    public float LumenSceneDetail;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenSceneViewDistance
    static readonly int LumenSceneViewDistance_Offset;
    public float LumenSceneViewDistance;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenSceneLightingUpdateSpeed
    static readonly int LumenSceneLightingUpdateSpeed_Offset;
    public float LumenSceneLightingUpdateSpeed;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenFinalGatherQuality
    static readonly int LumenFinalGatherQuality_Offset;
    public float LumenFinalGatherQuality;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenFinalGatherLightingUpdateSpeed
    static readonly int LumenFinalGatherLightingUpdateSpeed_Offset;
    public float LumenFinalGatherLightingUpdateSpeed;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenMaxTraceDistance
    static readonly int LumenMaxTraceDistance_Offset;
    public float LumenMaxTraceDistance;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenDiffuseColorBoost
    static readonly int LumenDiffuseColorBoost_Offset;
    public float LumenDiffuseColorBoost;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenSkylightLeaking
    static readonly int LumenSkylightLeaking_Offset;
    public float LumenSkylightLeaking;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenFullSkylightLeakingDistance
    static readonly int LumenFullSkylightLeakingDistance_Offset;
    public float LumenFullSkylightLeakingDistance;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenSurfaceCacheResolution
    static readonly int LumenSurfaceCacheResolution_Offset;
    public float LumenSurfaceCacheResolution;
    
    // EnumProperty /Script/Engine.PostProcessSettings:RayTracingGIType
    static readonly int RayTracingGIType_Offset;
    public UnrealSharp.Engine.ERayTracingGlobalIlluminationType RayTracingGIType;
    
    // IntProperty /Script/Engine.PostProcessSettings:RayTracingGIMaxBounces
    static readonly int RayTracingGIMaxBounces_Offset;
    public int RayTracingGIMaxBounces;
    
    // IntProperty /Script/Engine.PostProcessSettings:RayTracingGISamplesPerPixel
    static readonly int RayTracingGISamplesPerPixel_Offset;
    public int RayTracingGISamplesPerPixel;
    
    // ByteProperty /Script/Engine.PostProcessSettings:ReflectionMethod
    static readonly int ReflectionMethod_Offset;
    public UnrealSharp.Engine.EReflectionMethod ReflectionMethod;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LumenReflectionQuality
    static readonly int LumenReflectionQuality_Offset;
    public float LumenReflectionQuality;
    
    // EnumProperty /Script/Engine.PostProcessSettings:LumenRayLightingMode
    static readonly int LumenRayLightingMode_Offset;
    public UnrealSharp.Engine.ELumenRayLightingModeOverride LumenRayLightingMode;
    
    // BoolProperty /Script/Engine.PostProcessSettings:LumenFrontLayerTranslucencyReflections
    static readonly int LumenFrontLayerTranslucencyReflections_Offset;
    static readonly IntPtr LumenFrontLayerTranslucencyReflections_NativeProperty;
    public bool LumenFrontLayerTranslucencyReflections;
    
    // IntProperty /Script/Engine.PostProcessSettings:LumenMaxReflectionBounces
    static readonly int LumenMaxReflectionBounces_Offset;
    public int LumenMaxReflectionBounces;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ScreenSpaceReflectionIntensity
    static readonly int ScreenSpaceReflectionIntensity_Offset;
    public float ScreenSpaceReflectionIntensity;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ScreenSpaceReflectionQuality
    static readonly int ScreenSpaceReflectionQuality_Offset;
    public float ScreenSpaceReflectionQuality;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ScreenSpaceReflectionMaxRoughness
    static readonly int ScreenSpaceReflectionMaxRoughness_Offset;
    public float ScreenSpaceReflectionMaxRoughness;
    
    // FloatProperty /Script/Engine.PostProcessSettings:RayTracingReflectionsMaxRoughness
    static readonly int RayTracingReflectionsMaxRoughness_Offset;
    public float RayTracingReflectionsMaxRoughness;
    
    // IntProperty /Script/Engine.PostProcessSettings:RayTracingReflectionsMaxBounces
    static readonly int RayTracingReflectionsMaxBounces_Offset;
    public int RayTracingReflectionsMaxBounces;
    
    // IntProperty /Script/Engine.PostProcessSettings:RayTracingReflectionsSamplesPerPixel
    static readonly int RayTracingReflectionsSamplesPerPixel_Offset;
    public int RayTracingReflectionsSamplesPerPixel;
    
    // EnumProperty /Script/Engine.PostProcessSettings:RayTracingReflectionsShadows
    static readonly int RayTracingReflectionsShadows_Offset;
    public UnrealSharp.Engine.EReflectedAndRefractedRayTracedShadows RayTracingReflectionsShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:RayTracingReflectionsTranslucency
    static readonly int RayTracingReflectionsTranslucency_Offset;
    static readonly IntPtr RayTracingReflectionsTranslucency_NativeProperty;
    public bool RayTracingReflectionsTranslucency;
    
    // StructProperty /Script/Engine.PostProcessSettings:AmbientCubemapTint
    static readonly int AmbientCubemapTint_Offset;
    public UnrealSharp.CoreUObject.LinearColor AmbientCubemapTint;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientCubemapIntensity
    static readonly int AmbientCubemapIntensity_Offset;
    public float AmbientCubemapIntensity;
    
    // ObjectProperty /Script/Engine.PostProcessSettings:AmbientCubemap
    static readonly int AmbientCubemap_Offset;
    public UnrealSharp.Engine.TextureCube AmbientCubemap;
    
    // FloatProperty /Script/Engine.PostProcessSettings:CameraShutterSpeed
    static readonly int CameraShutterSpeed_Offset;
    public float CameraShutterSpeed;
    
    // FloatProperty /Script/Engine.PostProcessSettings:CameraISO
    static readonly int CameraISO_Offset;
    public float CameraISO;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldFstop
    static readonly int DepthOfFieldFstop_Offset;
    public float DepthOfFieldFstop;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldMinFstop
    static readonly int DepthOfFieldMinFstop_Offset;
    public float DepthOfFieldMinFstop;
    
    // IntProperty /Script/Engine.PostProcessSettings:DepthOfFieldBladeCount
    static readonly int DepthOfFieldBladeCount_Offset;
    public int DepthOfFieldBladeCount;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AutoExposureBias
    static readonly int AutoExposureBias_Offset;
    public float AutoExposureBias;
    
    // BoolProperty /Script/Engine.PostProcessSettings:AutoExposureApplyPhysicalCameraExposure
    static readonly int AutoExposureApplyPhysicalCameraExposure_Offset;
    static readonly IntPtr AutoExposureApplyPhysicalCameraExposure_NativeProperty;
    public bool AutoExposureApplyPhysicalCameraExposure;
    
    // ObjectProperty /Script/Engine.PostProcessSettings:AutoExposureBiasCurve
    static readonly int AutoExposureBiasCurve_Offset;
    public UnrealSharp.Engine.CurveFloat AutoExposureBiasCurve;
    
    // ObjectProperty /Script/Engine.PostProcessSettings:AutoExposureMeterMask
    static readonly int AutoExposureMeterMask_Offset;
    public UnrealSharp.Engine.Texture AutoExposureMeterMask;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AutoExposureLowPercent
    static readonly int AutoExposureLowPercent_Offset;
    public float AutoExposureLowPercent;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AutoExposureHighPercent
    static readonly int AutoExposureHighPercent_Offset;
    public float AutoExposureHighPercent;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AutoExposureMinBrightness
    static readonly int AutoExposureMinBrightness_Offset;
    public float AutoExposureMinBrightness;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AutoExposureMaxBrightness
    static readonly int AutoExposureMaxBrightness_Offset;
    public float AutoExposureMaxBrightness;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AutoExposureSpeedUp
    static readonly int AutoExposureSpeedUp_Offset;
    public float AutoExposureSpeedUp;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AutoExposureSpeedDown
    static readonly int AutoExposureSpeedDown_Offset;
    public float AutoExposureSpeedDown;
    
    // FloatProperty /Script/Engine.PostProcessSettings:HistogramLogMin
    static readonly int HistogramLogMin_Offset;
    public float HistogramLogMin;
    
    // FloatProperty /Script/Engine.PostProcessSettings:HistogramLogMax
    static readonly int HistogramLogMax_Offset;
    public float HistogramLogMax;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LocalExposureHighlightContrastScale
    static readonly int LocalExposureHighlightContrastScale_Offset;
    public float LocalExposureHighlightContrastScale;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LocalExposureShadowContrastScale
    static readonly int LocalExposureShadowContrastScale_Offset;
    public float LocalExposureShadowContrastScale;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LocalExposureDetailStrength
    static readonly int LocalExposureDetailStrength_Offset;
    public float LocalExposureDetailStrength;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LocalExposureBlurredLuminanceBlend
    static readonly int LocalExposureBlurredLuminanceBlend_Offset;
    public float LocalExposureBlurredLuminanceBlend;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LocalExposureBlurredLuminanceKernelSizePercent
    static readonly int LocalExposureBlurredLuminanceKernelSizePercent_Offset;
    public float LocalExposureBlurredLuminanceKernelSizePercent;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LocalExposureMiddleGreyBias
    static readonly int LocalExposureMiddleGreyBias_Offset;
    public float LocalExposureMiddleGreyBias;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LensFlareIntensity
    static readonly int LensFlareIntensity_Offset;
    public float LensFlareIntensity;
    
    // StructProperty /Script/Engine.PostProcessSettings:LensFlareTint
    static readonly int LensFlareTint_Offset;
    public UnrealSharp.CoreUObject.LinearColor LensFlareTint;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LensFlareBokehSize
    static readonly int LensFlareBokehSize_Offset;
    public float LensFlareBokehSize;
    
    // FloatProperty /Script/Engine.PostProcessSettings:LensFlareThreshold
    static readonly int LensFlareThreshold_Offset;
    public float LensFlareThreshold;
    
    // ObjectProperty /Script/Engine.PostProcessSettings:LensFlareBokehShape
    static readonly int LensFlareBokehShape_Offset;
    public UnrealSharp.Engine.Texture LensFlareBokehShape;
    
    // FloatProperty /Script/Engine.PostProcessSettings:VignetteIntensity
    static readonly int VignetteIntensity_Offset;
    public float VignetteIntensity;
    
    // FloatProperty /Script/Engine.PostProcessSettings:Sharpen
    static readonly int Sharpen_Offset;
    public float Sharpen;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmGrainIntensity
    static readonly int FilmGrainIntensity_Offset;
    public float FilmGrainIntensity;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmGrainIntensityShadows
    static readonly int FilmGrainIntensityShadows_Offset;
    public float FilmGrainIntensityShadows;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmGrainIntensityMidtones
    static readonly int FilmGrainIntensityMidtones_Offset;
    public float FilmGrainIntensityMidtones;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmGrainIntensityHighlights
    static readonly int FilmGrainIntensityHighlights_Offset;
    public float FilmGrainIntensityHighlights;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmGrainShadowsMax
    static readonly int FilmGrainShadowsMax_Offset;
    public float FilmGrainShadowsMax;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmGrainHighlightsMin
    static readonly int FilmGrainHighlightsMin_Offset;
    public float FilmGrainHighlightsMin;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmGrainHighlightsMax
    static readonly int FilmGrainHighlightsMax_Offset;
    public float FilmGrainHighlightsMax;
    
    // FloatProperty /Script/Engine.PostProcessSettings:FilmGrainTexelSize
    static readonly int FilmGrainTexelSize_Offset;
    public float FilmGrainTexelSize;
    
    // ObjectProperty /Script/Engine.PostProcessSettings:FilmGrainTexture
    static readonly int FilmGrainTexture_Offset;
    public UnrealSharp.Engine.Texture2D FilmGrainTexture;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionIntensity
    static readonly int AmbientOcclusionIntensity_Offset;
    public float AmbientOcclusionIntensity;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionStaticFraction
    static readonly int AmbientOcclusionStaticFraction_Offset;
    public float AmbientOcclusionStaticFraction;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionRadius
    static readonly int AmbientOcclusionRadius_Offset;
    public float AmbientOcclusionRadius;
    
    // BoolProperty /Script/Engine.PostProcessSettings:AmbientOcclusionRadiusInWS
    static readonly int AmbientOcclusionRadiusInWS_Offset;
    static readonly IntPtr AmbientOcclusionRadiusInWS_NativeProperty;
    public bool AmbientOcclusionRadiusInWS;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionFadeDistance
    static readonly int AmbientOcclusionFadeDistance_Offset;
    public float AmbientOcclusionFadeDistance;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionFadeRadius
    static readonly int AmbientOcclusionFadeRadius_Offset;
    public float AmbientOcclusionFadeRadius;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionPower
    static readonly int AmbientOcclusionPower_Offset;
    public float AmbientOcclusionPower;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionBias
    static readonly int AmbientOcclusionBias_Offset;
    public float AmbientOcclusionBias;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionQuality
    static readonly int AmbientOcclusionQuality_Offset;
    public float AmbientOcclusionQuality;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionMipBlend
    static readonly int AmbientOcclusionMipBlend_Offset;
    public float AmbientOcclusionMipBlend;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionMipScale
    static readonly int AmbientOcclusionMipScale_Offset;
    public float AmbientOcclusionMipScale;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionMipThreshold
    static readonly int AmbientOcclusionMipThreshold_Offset;
    public float AmbientOcclusionMipThreshold;
    
    // FloatProperty /Script/Engine.PostProcessSettings:AmbientOcclusionTemporalBlendWeight
    static readonly int AmbientOcclusionTemporalBlendWeight_Offset;
    public float AmbientOcclusionTemporalBlendWeight;
    
    // BoolProperty /Script/Engine.PostProcessSettings:RayTracingAO
    static readonly int RayTracingAO_Offset;
    static readonly IntPtr RayTracingAO_NativeProperty;
    public bool RayTracingAO;
    
    // IntProperty /Script/Engine.PostProcessSettings:RayTracingAOSamplesPerPixel
    static readonly int RayTracingAOSamplesPerPixel_Offset;
    public int RayTracingAOSamplesPerPixel;
    
    // FloatProperty /Script/Engine.PostProcessSettings:RayTracingAOIntensity
    static readonly int RayTracingAOIntensity_Offset;
    public float RayTracingAOIntensity;
    
    // FloatProperty /Script/Engine.PostProcessSettings:RayTracingAORadius
    static readonly int RayTracingAORadius_Offset;
    public float RayTracingAORadius;
    
    // FloatProperty /Script/Engine.PostProcessSettings:ColorGradingIntensity
    static readonly int ColorGradingIntensity_Offset;
    public float ColorGradingIntensity;
    
    // ObjectProperty /Script/Engine.PostProcessSettings:ColorGradingLUT
    static readonly int ColorGradingLUT_Offset;
    public UnrealSharp.Engine.Texture ColorGradingLUT;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldSensorWidth
    static readonly int DepthOfFieldSensorWidth_Offset;
    public float DepthOfFieldSensorWidth;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldSqueezeFactor
    static readonly int DepthOfFieldSqueezeFactor_Offset;
    public float DepthOfFieldSqueezeFactor;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldFocalDistance
    static readonly int DepthOfFieldFocalDistance_Offset;
    public float DepthOfFieldFocalDistance;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldDepthBlurAmount
    static readonly int DepthOfFieldDepthBlurAmount_Offset;
    public float DepthOfFieldDepthBlurAmount;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldDepthBlurRadius
    static readonly int DepthOfFieldDepthBlurRadius_Offset;
    public float DepthOfFieldDepthBlurRadius;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldFocalRegion
    static readonly int DepthOfFieldFocalRegion_Offset;
    public float DepthOfFieldFocalRegion;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldNearTransitionRegion
    static readonly int DepthOfFieldNearTransitionRegion_Offset;
    public float DepthOfFieldNearTransitionRegion;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldFarTransitionRegion
    static readonly int DepthOfFieldFarTransitionRegion_Offset;
    public float DepthOfFieldFarTransitionRegion;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldScale
    static readonly int DepthOfFieldScale_Offset;
    public float DepthOfFieldScale;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldNearBlurSize
    static readonly int DepthOfFieldNearBlurSize_Offset;
    public float DepthOfFieldNearBlurSize;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldFarBlurSize
    static readonly int DepthOfFieldFarBlurSize_Offset;
    public float DepthOfFieldFarBlurSize;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldOcclusion
    static readonly int DepthOfFieldOcclusion_Offset;
    public float DepthOfFieldOcclusion;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldSkyFocusDistance
    static readonly int DepthOfFieldSkyFocusDistance_Offset;
    public float DepthOfFieldSkyFocusDistance;
    
    // FloatProperty /Script/Engine.PostProcessSettings:DepthOfFieldVignetteSize
    static readonly int DepthOfFieldVignetteSize_Offset;
    public float DepthOfFieldVignetteSize;
    
    // FloatProperty /Script/Engine.PostProcessSettings:MotionBlurAmount
    static readonly int MotionBlurAmount_Offset;
    public float MotionBlurAmount;
    
    // FloatProperty /Script/Engine.PostProcessSettings:MotionBlurMax
    static readonly int MotionBlurMax_Offset;
    public float MotionBlurMax;
    
    // IntProperty /Script/Engine.PostProcessSettings:MotionBlurTargetFPS
    static readonly int MotionBlurTargetFPS_Offset;
    public int MotionBlurTargetFPS;
    
    // FloatProperty /Script/Engine.PostProcessSettings:MotionBlurPerObjectSize
    static readonly int MotionBlurPerObjectSize_Offset;
    public float MotionBlurPerObjectSize;
    
    // EnumProperty /Script/Engine.PostProcessSettings:TranslucencyType
    static readonly int TranslucencyType_Offset;
    public UnrealSharp.Engine.ETranslucencyType TranslucencyType;
    
    // FloatProperty /Script/Engine.PostProcessSettings:RayTracingTranslucencyMaxRoughness
    static readonly int RayTracingTranslucencyMaxRoughness_Offset;
    public float RayTracingTranslucencyMaxRoughness;
    
    // IntProperty /Script/Engine.PostProcessSettings:RayTracingTranslucencyRefractionRays
    static readonly int RayTracingTranslucencyRefractionRays_Offset;
    public int RayTracingTranslucencyRefractionRays;
    
    // IntProperty /Script/Engine.PostProcessSettings:RayTracingTranslucencySamplesPerPixel
    static readonly int RayTracingTranslucencySamplesPerPixel_Offset;
    public int RayTracingTranslucencySamplesPerPixel;
    
    // EnumProperty /Script/Engine.PostProcessSettings:RayTracingTranslucencyShadows
    static readonly int RayTracingTranslucencyShadows_Offset;
    public UnrealSharp.Engine.EReflectedAndRefractedRayTracedShadows RayTracingTranslucencyShadows;
    
    // BoolProperty /Script/Engine.PostProcessSettings:RayTracingTranslucencyRefraction
    static readonly int RayTracingTranslucencyRefraction_Offset;
    static readonly IntPtr RayTracingTranslucencyRefraction_NativeProperty;
    public bool RayTracingTranslucencyRefraction;
    
    // IntProperty /Script/Engine.PostProcessSettings:PathTracingMaxBounces
    static readonly int PathTracingMaxBounces_Offset;
    public int PathTracingMaxBounces;
    
    // IntProperty /Script/Engine.PostProcessSettings:PathTracingSamplesPerPixel
    static readonly int PathTracingSamplesPerPixel_Offset;
    public int PathTracingSamplesPerPixel;
    
    // FloatProperty /Script/Engine.PostProcessSettings:PathTracingMaxPathExposure
    static readonly int PathTracingMaxPathExposure_Offset;
    public float PathTracingMaxPathExposure;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingEnableReferenceDOF
    static readonly int PathTracingEnableReferenceDOF_Offset;
    static readonly IntPtr PathTracingEnableReferenceDOF_NativeProperty;
    public bool PathTracingEnableReferenceDOF;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingEnableReferenceAtmosphere
    static readonly int PathTracingEnableReferenceAtmosphere_Offset;
    static readonly IntPtr PathTracingEnableReferenceAtmosphere_NativeProperty;
    public bool PathTracingEnableReferenceAtmosphere;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingEnableDenoiser
    static readonly int PathTracingEnableDenoiser_Offset;
    static readonly IntPtr PathTracingEnableDenoiser_NativeProperty;
    public bool PathTracingEnableDenoiser;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingIncludeEmissive
    static readonly int PathTracingIncludeEmissive_Offset;
    static readonly IntPtr PathTracingIncludeEmissive_NativeProperty;
    public bool PathTracingIncludeEmissive;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingIncludeIndirectEmissive
    static readonly int PathTracingIncludeIndirectEmissive_Offset;
    static readonly IntPtr PathTracingIncludeIndirectEmissive_NativeProperty;
    public bool PathTracingIncludeIndirectEmissive;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingIncludeDiffuse
    static readonly int PathTracingIncludeDiffuse_Offset;
    static readonly IntPtr PathTracingIncludeDiffuse_NativeProperty;
    public bool PathTracingIncludeDiffuse;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingIncludeIndirectDiffuse
    static readonly int PathTracingIncludeIndirectDiffuse_Offset;
    static readonly IntPtr PathTracingIncludeIndirectDiffuse_NativeProperty;
    public bool PathTracingIncludeIndirectDiffuse;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingIncludeSpecular
    static readonly int PathTracingIncludeSpecular_Offset;
    static readonly IntPtr PathTracingIncludeSpecular_NativeProperty;
    public bool PathTracingIncludeSpecular;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingIncludeIndirectSpecular
    static readonly int PathTracingIncludeIndirectSpecular_Offset;
    static readonly IntPtr PathTracingIncludeIndirectSpecular_NativeProperty;
    public bool PathTracingIncludeIndirectSpecular;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingIncludeVolume
    static readonly int PathTracingIncludeVolume_Offset;
    static readonly IntPtr PathTracingIncludeVolume_NativeProperty;
    public bool PathTracingIncludeVolume;
    
    // BoolProperty /Script/Engine.PostProcessSettings:PathTracingIncludeIndirectVolume
    static readonly int PathTracingIncludeIndirectVolume_Offset;
    static readonly IntPtr PathTracingIncludeIndirectVolume_NativeProperty;
    public bool PathTracingIncludeIndirectVolume;
    
    // StructProperty /Script/Engine.PostProcessSettings:WeightedBlendables
    static readonly int WeightedBlendables_Offset;
    public UnrealSharp.Engine.WeightedBlendables WeightedBlendables;
    
    
    public static readonly int NativeDataSize;
    static PostProcessSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PostProcessSettings");
        
        bOverride_TemperatureType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_TemperatureType");
        bOverride_TemperatureType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_TemperatureType");
        bOverride_WhiteTemp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_WhiteTemp");
        bOverride_WhiteTemp_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_WhiteTemp");
        bOverride_WhiteTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_WhiteTint");
        bOverride_WhiteTint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_WhiteTint");
        bOverride_ColorSaturation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorSaturation");
        bOverride_ColorSaturation_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorSaturation");
        bOverride_ColorContrast_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorContrast");
        bOverride_ColorContrast_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorContrast");
        bOverride_ColorGamma_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGamma");
        bOverride_ColorGamma_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGamma");
        bOverride_ColorGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGain");
        bOverride_ColorGain_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGain");
        bOverride_ColorOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorOffset");
        bOverride_ColorOffset_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorOffset");
        bOverride_ColorSaturationShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorSaturationShadows");
        bOverride_ColorSaturationShadows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorSaturationShadows");
        bOverride_ColorContrastShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorContrastShadows");
        bOverride_ColorContrastShadows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorContrastShadows");
        bOverride_ColorGammaShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGammaShadows");
        bOverride_ColorGammaShadows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGammaShadows");
        bOverride_ColorGainShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGainShadows");
        bOverride_ColorGainShadows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGainShadows");
        bOverride_ColorOffsetShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorOffsetShadows");
        bOverride_ColorOffsetShadows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorOffsetShadows");
        bOverride_ColorSaturationMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorSaturationMidtones");
        bOverride_ColorSaturationMidtones_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorSaturationMidtones");
        bOverride_ColorContrastMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorContrastMidtones");
        bOverride_ColorContrastMidtones_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorContrastMidtones");
        bOverride_ColorGammaMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGammaMidtones");
        bOverride_ColorGammaMidtones_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGammaMidtones");
        bOverride_ColorGainMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGainMidtones");
        bOverride_ColorGainMidtones_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGainMidtones");
        bOverride_ColorOffsetMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorOffsetMidtones");
        bOverride_ColorOffsetMidtones_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorOffsetMidtones");
        bOverride_ColorSaturationHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorSaturationHighlights");
        bOverride_ColorSaturationHighlights_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorSaturationHighlights");
        bOverride_ColorContrastHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorContrastHighlights");
        bOverride_ColorContrastHighlights_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorContrastHighlights");
        bOverride_ColorGammaHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGammaHighlights");
        bOverride_ColorGammaHighlights_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGammaHighlights");
        bOverride_ColorGainHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGainHighlights");
        bOverride_ColorGainHighlights_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGainHighlights");
        bOverride_ColorOffsetHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorOffsetHighlights");
        bOverride_ColorOffsetHighlights_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorOffsetHighlights");
        bOverride_ColorCorrectionShadowsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorCorrectionShadowsMax");
        bOverride_ColorCorrectionShadowsMax_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorCorrectionShadowsMax");
        bOverride_ColorCorrectionHighlightsMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorCorrectionHighlightsMin");
        bOverride_ColorCorrectionHighlightsMin_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorCorrectionHighlightsMin");
        bOverride_ColorCorrectionHighlightsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorCorrectionHighlightsMax");
        bOverride_ColorCorrectionHighlightsMax_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorCorrectionHighlightsMax");
        bOverride_BlueCorrection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BlueCorrection");
        bOverride_BlueCorrection_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BlueCorrection");
        bOverride_ExpandGamut_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ExpandGamut");
        bOverride_ExpandGamut_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ExpandGamut");
        bOverride_ToneCurveAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ToneCurveAmount");
        bOverride_ToneCurveAmount_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ToneCurveAmount");
        bOverride_FilmSlope_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmSlope");
        bOverride_FilmSlope_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmSlope");
        bOverride_FilmToe_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmToe");
        bOverride_FilmToe_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmToe");
        bOverride_FilmShoulder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmShoulder");
        bOverride_FilmShoulder_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmShoulder");
        bOverride_FilmBlackClip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmBlackClip");
        bOverride_FilmBlackClip_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmBlackClip");
        bOverride_FilmWhiteClip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmWhiteClip");
        bOverride_FilmWhiteClip_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmWhiteClip");
        bOverride_SceneColorTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_SceneColorTint");
        bOverride_SceneColorTint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_SceneColorTint");
        bOverride_SceneFringeIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_SceneFringeIntensity");
        bOverride_SceneFringeIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_SceneFringeIntensity");
        bOverride_ChromaticAberrationStartOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ChromaticAberrationStartOffset");
        bOverride_ChromaticAberrationStartOffset_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ChromaticAberrationStartOffset");
        bOverride_AmbientCubemapTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientCubemapTint");
        bOverride_AmbientCubemapTint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientCubemapTint");
        bOverride_AmbientCubemapIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientCubemapIntensity");
        bOverride_AmbientCubemapIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientCubemapIntensity");
        bOverride_BloomMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomMethod");
        bOverride_BloomMethod_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomMethod");
        bOverride_BloomIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomIntensity");
        bOverride_BloomIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomIntensity");
        bOverride_BloomThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomThreshold");
        bOverride_BloomThreshold_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomThreshold");
        bOverride_Bloom1Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom1Tint");
        bOverride_Bloom1Tint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom1Tint");
        bOverride_Bloom1Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom1Size");
        bOverride_Bloom1Size_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom1Size");
        bOverride_Bloom2Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom2Size");
        bOverride_Bloom2Size_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom2Size");
        bOverride_Bloom2Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom2Tint");
        bOverride_Bloom2Tint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom2Tint");
        bOverride_Bloom3Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom3Tint");
        bOverride_Bloom3Tint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom3Tint");
        bOverride_Bloom3Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom3Size");
        bOverride_Bloom3Size_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom3Size");
        bOverride_Bloom4Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom4Tint");
        bOverride_Bloom4Tint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom4Tint");
        bOverride_Bloom4Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom4Size");
        bOverride_Bloom4Size_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom4Size");
        bOverride_Bloom5Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom5Tint");
        bOverride_Bloom5Tint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom5Tint");
        bOverride_Bloom5Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom5Size");
        bOverride_Bloom5Size_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom5Size");
        bOverride_Bloom6Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom6Tint");
        bOverride_Bloom6Tint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom6Tint");
        bOverride_Bloom6Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Bloom6Size");
        bOverride_Bloom6Size_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Bloom6Size");
        bOverride_BloomSizeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomSizeScale");
        bOverride_BloomSizeScale_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomSizeScale");
        bOverride_BloomConvolutionTexture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomConvolutionTexture");
        bOverride_BloomConvolutionTexture_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomConvolutionTexture");
        bOverride_BloomConvolutionScatterDispersion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomConvolutionScatterDispersion");
        bOverride_BloomConvolutionScatterDispersion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomConvolutionScatterDispersion");
        bOverride_BloomConvolutionSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomConvolutionSize");
        bOverride_BloomConvolutionSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomConvolutionSize");
        bOverride_BloomConvolutionCenterUV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomConvolutionCenterUV");
        bOverride_BloomConvolutionCenterUV_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomConvolutionCenterUV");
        bOverride_BloomConvolutionPreFilterMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomConvolutionPreFilterMin");
        bOverride_BloomConvolutionPreFilterMin_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomConvolutionPreFilterMin");
        bOverride_BloomConvolutionPreFilterMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomConvolutionPreFilterMax");
        bOverride_BloomConvolutionPreFilterMax_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomConvolutionPreFilterMax");
        bOverride_BloomConvolutionPreFilterMult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomConvolutionPreFilterMult");
        bOverride_BloomConvolutionPreFilterMult_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomConvolutionPreFilterMult");
        bOverride_BloomConvolutionBufferScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomConvolutionBufferScale");
        bOverride_BloomConvolutionBufferScale_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomConvolutionBufferScale");
        bOverride_BloomDirtMaskIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomDirtMaskIntensity");
        bOverride_BloomDirtMaskIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomDirtMaskIntensity");
        bOverride_BloomDirtMaskTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomDirtMaskTint");
        bOverride_BloomDirtMaskTint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomDirtMaskTint");
        bOverride_BloomDirtMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_BloomDirtMask");
        bOverride_BloomDirtMask_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_BloomDirtMask");
        bOverride_CameraShutterSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_CameraShutterSpeed");
        bOverride_CameraShutterSpeed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_CameraShutterSpeed");
        bOverride_CameraISO_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_CameraISO");
        bOverride_CameraISO_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_CameraISO");
        bOverride_AutoExposureMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureMethod");
        bOverride_AutoExposureMethod_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureMethod");
        bOverride_AutoExposureLowPercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureLowPercent");
        bOverride_AutoExposureLowPercent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureLowPercent");
        bOverride_AutoExposureHighPercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureHighPercent");
        bOverride_AutoExposureHighPercent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureHighPercent");
        bOverride_AutoExposureMinBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureMinBrightness");
        bOverride_AutoExposureMinBrightness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureMinBrightness");
        bOverride_AutoExposureMaxBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureMaxBrightness");
        bOverride_AutoExposureMaxBrightness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureMaxBrightness");
        bOverride_AutoExposureSpeedUp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureSpeedUp");
        bOverride_AutoExposureSpeedUp_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureSpeedUp");
        bOverride_AutoExposureSpeedDown_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureSpeedDown");
        bOverride_AutoExposureSpeedDown_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureSpeedDown");
        bOverride_AutoExposureBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureBias");
        bOverride_AutoExposureBias_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureBias");
        bOverride_AutoExposureBiasCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureBiasCurve");
        bOverride_AutoExposureBiasCurve_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureBiasCurve");
        bOverride_AutoExposureMeterMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureMeterMask");
        bOverride_AutoExposureMeterMask_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureMeterMask");
        bOverride_AutoExposureApplyPhysicalCameraExposure_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AutoExposureApplyPhysicalCameraExposure");
        bOverride_AutoExposureApplyPhysicalCameraExposure_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AutoExposureApplyPhysicalCameraExposure");
        bOverride_HistogramLogMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_HistogramLogMin");
        bOverride_HistogramLogMin_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_HistogramLogMin");
        bOverride_HistogramLogMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_HistogramLogMax");
        bOverride_HistogramLogMax_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_HistogramLogMax");
        bOverride_LocalExposureHighlightContrastScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LocalExposureHighlightContrastScale");
        bOverride_LocalExposureHighlightContrastScale_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LocalExposureHighlightContrastScale");
        bOverride_LocalExposureShadowContrastScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LocalExposureShadowContrastScale");
        bOverride_LocalExposureShadowContrastScale_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LocalExposureShadowContrastScale");
        bOverride_LocalExposureDetailStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LocalExposureDetailStrength");
        bOverride_LocalExposureDetailStrength_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LocalExposureDetailStrength");
        bOverride_LocalExposureBlurredLuminanceBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LocalExposureBlurredLuminanceBlend");
        bOverride_LocalExposureBlurredLuminanceBlend_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LocalExposureBlurredLuminanceBlend");
        bOverride_LocalExposureBlurredLuminanceKernelSizePercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LocalExposureBlurredLuminanceKernelSizePercent");
        bOverride_LocalExposureBlurredLuminanceKernelSizePercent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LocalExposureBlurredLuminanceKernelSizePercent");
        bOverride_LocalExposureMiddleGreyBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LocalExposureMiddleGreyBias");
        bOverride_LocalExposureMiddleGreyBias_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LocalExposureMiddleGreyBias");
        bOverride_LensFlareIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LensFlareIntensity");
        bOverride_LensFlareIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LensFlareIntensity");
        bOverride_LensFlareTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LensFlareTint");
        bOverride_LensFlareTint_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LensFlareTint");
        bOverride_LensFlareTints_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LensFlareTints");
        bOverride_LensFlareTints_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LensFlareTints");
        bOverride_LensFlareBokehSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LensFlareBokehSize");
        bOverride_LensFlareBokehSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LensFlareBokehSize");
        bOverride_LensFlareBokehShape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LensFlareBokehShape");
        bOverride_LensFlareBokehShape_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LensFlareBokehShape");
        bOverride_LensFlareThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LensFlareThreshold");
        bOverride_LensFlareThreshold_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LensFlareThreshold");
        bOverride_VignetteIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_VignetteIntensity");
        bOverride_VignetteIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_VignetteIntensity");
        bOverride_Sharpen_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_Sharpen");
        bOverride_Sharpen_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_Sharpen");
        bOverride_FilmGrainIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainIntensity");
        bOverride_FilmGrainIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainIntensity");
        bOverride_FilmGrainIntensityShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainIntensityShadows");
        bOverride_FilmGrainIntensityShadows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainIntensityShadows");
        bOverride_FilmGrainIntensityMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainIntensityMidtones");
        bOverride_FilmGrainIntensityMidtones_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainIntensityMidtones");
        bOverride_FilmGrainIntensityHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainIntensityHighlights");
        bOverride_FilmGrainIntensityHighlights_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainIntensityHighlights");
        bOverride_FilmGrainShadowsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainShadowsMax");
        bOverride_FilmGrainShadowsMax_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainShadowsMax");
        bOverride_FilmGrainHighlightsMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainHighlightsMin");
        bOverride_FilmGrainHighlightsMin_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainHighlightsMin");
        bOverride_FilmGrainHighlightsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainHighlightsMax");
        bOverride_FilmGrainHighlightsMax_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainHighlightsMax");
        bOverride_FilmGrainTexelSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainTexelSize");
        bOverride_FilmGrainTexelSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainTexelSize");
        bOverride_FilmGrainTexture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_FilmGrainTexture");
        bOverride_FilmGrainTexture_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_FilmGrainTexture");
        bOverride_AmbientOcclusionIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionIntensity");
        bOverride_AmbientOcclusionIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionIntensity");
        bOverride_AmbientOcclusionStaticFraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionStaticFraction");
        bOverride_AmbientOcclusionStaticFraction_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionStaticFraction");
        bOverride_AmbientOcclusionRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionRadius");
        bOverride_AmbientOcclusionRadius_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionRadius");
        bOverride_AmbientOcclusionFadeDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionFadeDistance");
        bOverride_AmbientOcclusionFadeDistance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionFadeDistance");
        bOverride_AmbientOcclusionFadeRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionFadeRadius");
        bOverride_AmbientOcclusionFadeRadius_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionFadeRadius");
        bOverride_AmbientOcclusionRadiusInWS_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionRadiusInWS");
        bOverride_AmbientOcclusionRadiusInWS_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionRadiusInWS");
        bOverride_AmbientOcclusionPower_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionPower");
        bOverride_AmbientOcclusionPower_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionPower");
        bOverride_AmbientOcclusionBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionBias");
        bOverride_AmbientOcclusionBias_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionBias");
        bOverride_AmbientOcclusionQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionQuality");
        bOverride_AmbientOcclusionQuality_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionQuality");
        bOverride_AmbientOcclusionMipBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionMipBlend");
        bOverride_AmbientOcclusionMipBlend_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionMipBlend");
        bOverride_AmbientOcclusionMipScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionMipScale");
        bOverride_AmbientOcclusionMipScale_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionMipScale");
        bOverride_AmbientOcclusionMipThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionMipThreshold");
        bOverride_AmbientOcclusionMipThreshold_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionMipThreshold");
        bOverride_AmbientOcclusionTemporalBlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_AmbientOcclusionTemporalBlendWeight");
        bOverride_AmbientOcclusionTemporalBlendWeight_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_AmbientOcclusionTemporalBlendWeight");
        bOverride_RayTracingAO_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingAO");
        bOverride_RayTracingAO_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingAO");
        bOverride_RayTracingAOSamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingAOSamplesPerPixel");
        bOverride_RayTracingAOSamplesPerPixel_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingAOSamplesPerPixel");
        bOverride_RayTracingAOIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingAOIntensity");
        bOverride_RayTracingAOIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingAOIntensity");
        bOverride_RayTracingAORadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingAORadius");
        bOverride_RayTracingAORadius_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingAORadius");
        bOverride_IndirectLightingColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_IndirectLightingColor");
        bOverride_IndirectLightingColor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_IndirectLightingColor");
        bOverride_IndirectLightingIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_IndirectLightingIntensity");
        bOverride_IndirectLightingIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_IndirectLightingIntensity");
        bOverride_ColorGradingIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGradingIntensity");
        bOverride_ColorGradingIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGradingIntensity");
        bOverride_ColorGradingLUT_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ColorGradingLUT");
        bOverride_ColorGradingLUT_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ColorGradingLUT");
        bOverride_DepthOfFieldFocalDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldFocalDistance");
        bOverride_DepthOfFieldFocalDistance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldFocalDistance");
        bOverride_DepthOfFieldFstop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldFstop");
        bOverride_DepthOfFieldFstop_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldFstop");
        bOverride_DepthOfFieldMinFstop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldMinFstop");
        bOverride_DepthOfFieldMinFstop_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldMinFstop");
        bOverride_DepthOfFieldBladeCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldBladeCount");
        bOverride_DepthOfFieldBladeCount_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldBladeCount");
        bOverride_DepthOfFieldSensorWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldSensorWidth");
        bOverride_DepthOfFieldSensorWidth_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldSensorWidth");
        bOverride_DepthOfFieldSqueezeFactor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldSqueezeFactor");
        bOverride_DepthOfFieldSqueezeFactor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldSqueezeFactor");
        bOverride_DepthOfFieldDepthBlurRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldDepthBlurRadius");
        bOverride_DepthOfFieldDepthBlurRadius_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldDepthBlurRadius");
        bOverride_DepthOfFieldDepthBlurAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldDepthBlurAmount");
        bOverride_DepthOfFieldDepthBlurAmount_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldDepthBlurAmount");
        bOverride_DepthOfFieldFocalRegion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldFocalRegion");
        bOverride_DepthOfFieldFocalRegion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldFocalRegion");
        bOverride_DepthOfFieldNearTransitionRegion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldNearTransitionRegion");
        bOverride_DepthOfFieldNearTransitionRegion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldNearTransitionRegion");
        bOverride_DepthOfFieldFarTransitionRegion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldFarTransitionRegion");
        bOverride_DepthOfFieldFarTransitionRegion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldFarTransitionRegion");
        bOverride_DepthOfFieldScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldScale");
        bOverride_DepthOfFieldScale_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldScale");
        bOverride_DepthOfFieldNearBlurSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldNearBlurSize");
        bOverride_DepthOfFieldNearBlurSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldNearBlurSize");
        bOverride_DepthOfFieldFarBlurSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldFarBlurSize");
        bOverride_DepthOfFieldFarBlurSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldFarBlurSize");
        bOverride_MobileHQGaussian_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_MobileHQGaussian");
        bOverride_MobileHQGaussian_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_MobileHQGaussian");
        bOverride_DepthOfFieldOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldOcclusion");
        bOverride_DepthOfFieldOcclusion_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldOcclusion");
        bOverride_DepthOfFieldSkyFocusDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldSkyFocusDistance");
        bOverride_DepthOfFieldSkyFocusDistance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldSkyFocusDistance");
        bOverride_DepthOfFieldVignetteSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DepthOfFieldVignetteSize");
        bOverride_DepthOfFieldVignetteSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DepthOfFieldVignetteSize");
        bOverride_MotionBlurAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_MotionBlurAmount");
        bOverride_MotionBlurAmount_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_MotionBlurAmount");
        bOverride_MotionBlurMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_MotionBlurMax");
        bOverride_MotionBlurMax_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_MotionBlurMax");
        bOverride_MotionBlurTargetFPS_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_MotionBlurTargetFPS");
        bOverride_MotionBlurTargetFPS_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_MotionBlurTargetFPS");
        bOverride_MotionBlurPerObjectSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_MotionBlurPerObjectSize");
        bOverride_MotionBlurPerObjectSize_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_MotionBlurPerObjectSize");
        bOverride_ReflectionMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ReflectionMethod");
        bOverride_ReflectionMethod_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ReflectionMethod");
        bOverride_LumenReflectionQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenReflectionQuality");
        bOverride_LumenReflectionQuality_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenReflectionQuality");
        bOverride_ScreenSpaceReflectionIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ScreenSpaceReflectionIntensity");
        bOverride_ScreenSpaceReflectionIntensity_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ScreenSpaceReflectionIntensity");
        bOverride_ScreenSpaceReflectionQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ScreenSpaceReflectionQuality");
        bOverride_ScreenSpaceReflectionQuality_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ScreenSpaceReflectionQuality");
        bOverride_ScreenSpaceReflectionMaxRoughness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ScreenSpaceReflectionMaxRoughness");
        bOverride_ScreenSpaceReflectionMaxRoughness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ScreenSpaceReflectionMaxRoughness");
        bOverride_ScreenSpaceReflectionRoughnessScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_ScreenSpaceReflectionRoughnessScale");
        bOverride_ScreenSpaceReflectionRoughnessScale_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_ScreenSpaceReflectionRoughnessScale");
        bOverride_RayTracingReflectionsMaxRoughness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingReflectionsMaxRoughness");
        bOverride_RayTracingReflectionsMaxRoughness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingReflectionsMaxRoughness");
        bOverride_RayTracingReflectionsMaxBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingReflectionsMaxBounces");
        bOverride_RayTracingReflectionsMaxBounces_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingReflectionsMaxBounces");
        bOverride_RayTracingReflectionsSamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingReflectionsSamplesPerPixel");
        bOverride_RayTracingReflectionsSamplesPerPixel_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingReflectionsSamplesPerPixel");
        bOverride_RayTracingReflectionsShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingReflectionsShadows");
        bOverride_RayTracingReflectionsShadows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingReflectionsShadows");
        bOverride_RayTracingReflectionsTranslucency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingReflectionsTranslucency");
        bOverride_RayTracingReflectionsTranslucency_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingReflectionsTranslucency");
        bOverride_TranslucencyType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_TranslucencyType");
        bOverride_TranslucencyType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_TranslucencyType");
        bOverride_RayTracingTranslucencyMaxRoughness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingTranslucencyMaxRoughness");
        bOverride_RayTracingTranslucencyMaxRoughness_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingTranslucencyMaxRoughness");
        bOverride_RayTracingTranslucencyRefractionRays_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingTranslucencyRefractionRays");
        bOverride_RayTracingTranslucencyRefractionRays_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingTranslucencyRefractionRays");
        bOverride_RayTracingTranslucencySamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingTranslucencySamplesPerPixel");
        bOverride_RayTracingTranslucencySamplesPerPixel_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingTranslucencySamplesPerPixel");
        bOverride_RayTracingTranslucencyShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingTranslucencyShadows");
        bOverride_RayTracingTranslucencyShadows_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingTranslucencyShadows");
        bOverride_RayTracingTranslucencyRefraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingTranslucencyRefraction");
        bOverride_RayTracingTranslucencyRefraction_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingTranslucencyRefraction");
        bOverride_DynamicGlobalIlluminationMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_DynamicGlobalIlluminationMethod");
        bOverride_DynamicGlobalIlluminationMethod_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_DynamicGlobalIlluminationMethod");
        bOverride_LumenSceneLightingQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenSceneLightingQuality");
        bOverride_LumenSceneLightingQuality_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenSceneLightingQuality");
        bOverride_LumenSceneDetail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenSceneDetail");
        bOverride_LumenSceneDetail_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenSceneDetail");
        bOverride_LumenSceneViewDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenSceneViewDistance");
        bOverride_LumenSceneViewDistance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenSceneViewDistance");
        bOverride_LumenSceneLightingUpdateSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenSceneLightingUpdateSpeed");
        bOverride_LumenSceneLightingUpdateSpeed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenSceneLightingUpdateSpeed");
        bOverride_LumenFinalGatherQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenFinalGatherQuality");
        bOverride_LumenFinalGatherQuality_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenFinalGatherQuality");
        bOverride_LumenFinalGatherLightingUpdateSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenFinalGatherLightingUpdateSpeed");
        bOverride_LumenFinalGatherLightingUpdateSpeed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenFinalGatherLightingUpdateSpeed");
        bOverride_LumenMaxTraceDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenMaxTraceDistance");
        bOverride_LumenMaxTraceDistance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenMaxTraceDistance");
        bOverride_LumenDiffuseColorBoost_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenDiffuseColorBoost");
        bOverride_LumenDiffuseColorBoost_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenDiffuseColorBoost");
        bOverride_LumenSkylightLeaking_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenSkylightLeaking");
        bOverride_LumenSkylightLeaking_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenSkylightLeaking");
        bOverride_LumenFullSkylightLeakingDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenFullSkylightLeakingDistance");
        bOverride_LumenFullSkylightLeakingDistance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenFullSkylightLeakingDistance");
        bOverride_LumenRayLightingMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenRayLightingMode");
        bOverride_LumenRayLightingMode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenRayLightingMode");
        bOverride_LumenFrontLayerTranslucencyReflections_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenFrontLayerTranslucencyReflections");
        bOverride_LumenFrontLayerTranslucencyReflections_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenFrontLayerTranslucencyReflections");
        bOverride_LumenMaxReflectionBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenMaxReflectionBounces");
        bOverride_LumenMaxReflectionBounces_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenMaxReflectionBounces");
        bOverride_LumenSurfaceCacheResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_LumenSurfaceCacheResolution");
        bOverride_LumenSurfaceCacheResolution_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_LumenSurfaceCacheResolution");
        bOverride_RayTracingGI_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingGI");
        bOverride_RayTracingGI_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingGI");
        bOverride_RayTracingGIMaxBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingGIMaxBounces");
        bOverride_RayTracingGIMaxBounces_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingGIMaxBounces");
        bOverride_RayTracingGISamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_RayTracingGISamplesPerPixel");
        bOverride_RayTracingGISamplesPerPixel_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_RayTracingGISamplesPerPixel");
        bOverride_PathTracingMaxBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingMaxBounces");
        bOverride_PathTracingMaxBounces_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingMaxBounces");
        bOverride_PathTracingSamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingSamplesPerPixel");
        bOverride_PathTracingSamplesPerPixel_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingSamplesPerPixel");
        bOverride_PathTracingMaxPathExposure_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingMaxPathExposure");
        bOverride_PathTracingMaxPathExposure_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingMaxPathExposure");
        bOverride_PathTracingEnableReferenceDOF_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingEnableReferenceDOF");
        bOverride_PathTracingEnableReferenceDOF_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingEnableReferenceDOF");
        bOverride_PathTracingEnableReferenceAtmosphere_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingEnableReferenceAtmosphere");
        bOverride_PathTracingEnableReferenceAtmosphere_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingEnableReferenceAtmosphere");
        bOverride_PathTracingEnableDenoiser_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingEnableDenoiser");
        bOverride_PathTracingEnableDenoiser_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingEnableDenoiser");
        bOverride_PathTracingIncludeEmissive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingIncludeEmissive");
        bOverride_PathTracingIncludeEmissive_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingIncludeEmissive");
        bOverride_PathTracingIncludeIndirectEmissive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingIncludeIndirectEmissive");
        bOverride_PathTracingIncludeIndirectEmissive_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingIncludeIndirectEmissive");
        bOverride_PathTracingIncludeDiffuse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingIncludeDiffuse");
        bOverride_PathTracingIncludeDiffuse_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingIncludeDiffuse");
        bOverride_PathTracingIncludeIndirectDiffuse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingIncludeIndirectDiffuse");
        bOverride_PathTracingIncludeIndirectDiffuse_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingIncludeIndirectDiffuse");
        bOverride_PathTracingIncludeSpecular_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingIncludeSpecular");
        bOverride_PathTracingIncludeSpecular_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingIncludeSpecular");
        bOverride_PathTracingIncludeIndirectSpecular_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingIncludeIndirectSpecular");
        bOverride_PathTracingIncludeIndirectSpecular_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingIncludeIndirectSpecular");
        bOverride_PathTracingIncludeVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingIncludeVolume");
        bOverride_PathTracingIncludeVolume_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingIncludeVolume");
        bOverride_PathTracingIncludeIndirectVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverride_PathTracingIncludeIndirectVolume");
        bOverride_PathTracingIncludeIndirectVolume_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bOverride_PathTracingIncludeIndirectVolume");
        bMobileHQGaussian_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMobileHQGaussian");
        bMobileHQGaussian_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bMobileHQGaussian");
        BloomMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomMethod");
        AutoExposureMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureMethod");
        TemperatureType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TemperatureType");
        WhiteTemp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WhiteTemp");
        WhiteTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WhiteTint");
        ColorSaturation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorSaturation");
        ColorContrast_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorContrast");
        ColorGamma_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGamma");
        ColorGain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGain");
        ColorOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorOffset");
        ColorSaturationShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorSaturationShadows");
        ColorContrastShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorContrastShadows");
        ColorGammaShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGammaShadows");
        ColorGainShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGainShadows");
        ColorOffsetShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorOffsetShadows");
        ColorSaturationMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorSaturationMidtones");
        ColorContrastMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorContrastMidtones");
        ColorGammaMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGammaMidtones");
        ColorGainMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGainMidtones");
        ColorOffsetMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorOffsetMidtones");
        ColorSaturationHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorSaturationHighlights");
        ColorContrastHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorContrastHighlights");
        ColorGammaHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGammaHighlights");
        ColorGainHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGainHighlights");
        ColorOffsetHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorOffsetHighlights");
        ColorCorrectionHighlightsMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorCorrectionHighlightsMin");
        ColorCorrectionHighlightsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorCorrectionHighlightsMax");
        ColorCorrectionShadowsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorCorrectionShadowsMax");
        BlueCorrection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlueCorrection");
        ExpandGamut_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExpandGamut");
        ToneCurveAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ToneCurveAmount");
        FilmSlope_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmSlope");
        FilmToe_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmToe");
        FilmShoulder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmShoulder");
        FilmBlackClip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmBlackClip");
        FilmWhiteClip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmWhiteClip");
        SceneColorTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SceneColorTint");
        SceneFringeIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SceneFringeIntensity");
        ChromaticAberrationStartOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChromaticAberrationStartOffset");
        BloomIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomIntensity");
        BloomThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomThreshold");
        BloomSizeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomSizeScale");
        Bloom1Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom1Size");
        Bloom2Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom2Size");
        Bloom3Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom3Size");
        Bloom4Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom4Size");
        Bloom5Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom5Size");
        Bloom6Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom6Size");
        Bloom1Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom1Tint");
        Bloom2Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom2Tint");
        Bloom3Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom3Tint");
        Bloom4Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom4Tint");
        Bloom5Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom5Tint");
        Bloom6Tint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bloom6Tint");
        BloomConvolutionScatterDispersion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomConvolutionScatterDispersion");
        BloomConvolutionSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomConvolutionSize");
        BloomConvolutionTexture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomConvolutionTexture");
        BloomConvolutionCenterUV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomConvolutionCenterUV");
        BloomConvolutionPreFilterMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomConvolutionPreFilterMin");
        BloomConvolutionPreFilterMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomConvolutionPreFilterMax");
        BloomConvolutionPreFilterMult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomConvolutionPreFilterMult");
        BloomConvolutionBufferScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomConvolutionBufferScale");
        BloomDirtMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomDirtMask");
        BloomDirtMaskIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomDirtMaskIntensity");
        BloomDirtMaskTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BloomDirtMaskTint");
        DynamicGlobalIlluminationMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DynamicGlobalIlluminationMethod");
        IndirectLightingColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IndirectLightingColor");
        IndirectLightingIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IndirectLightingIntensity");
        LumenSceneLightingQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenSceneLightingQuality");
        LumenSceneDetail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenSceneDetail");
        LumenSceneViewDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenSceneViewDistance");
        LumenSceneLightingUpdateSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenSceneLightingUpdateSpeed");
        LumenFinalGatherQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenFinalGatherQuality");
        LumenFinalGatherLightingUpdateSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenFinalGatherLightingUpdateSpeed");
        LumenMaxTraceDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenMaxTraceDistance");
        LumenDiffuseColorBoost_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenDiffuseColorBoost");
        LumenSkylightLeaking_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenSkylightLeaking");
        LumenFullSkylightLeakingDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenFullSkylightLeakingDistance");
        LumenSurfaceCacheResolution_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenSurfaceCacheResolution");
        RayTracingGIType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingGIType");
        RayTracingGIMaxBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingGIMaxBounces");
        RayTracingGISamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingGISamplesPerPixel");
        ReflectionMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReflectionMethod");
        LumenReflectionQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenReflectionQuality");
        LumenRayLightingMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenRayLightingMode");
        LumenFrontLayerTranslucencyReflections_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenFrontLayerTranslucencyReflections");
        LumenFrontLayerTranslucencyReflections_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LumenFrontLayerTranslucencyReflections");
        LumenMaxReflectionBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LumenMaxReflectionBounces");
        ScreenSpaceReflectionIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScreenSpaceReflectionIntensity");
        ScreenSpaceReflectionQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScreenSpaceReflectionQuality");
        ScreenSpaceReflectionMaxRoughness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScreenSpaceReflectionMaxRoughness");
        RayTracingReflectionsMaxRoughness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingReflectionsMaxRoughness");
        RayTracingReflectionsMaxBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingReflectionsMaxBounces");
        RayTracingReflectionsSamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingReflectionsSamplesPerPixel");
        RayTracingReflectionsShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingReflectionsShadows");
        RayTracingReflectionsTranslucency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingReflectionsTranslucency");
        RayTracingReflectionsTranslucency_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RayTracingReflectionsTranslucency");
        AmbientCubemapTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientCubemapTint");
        AmbientCubemapIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientCubemapIntensity");
        AmbientCubemap_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientCubemap");
        CameraShutterSpeed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CameraShutterSpeed");
        CameraISO_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CameraISO");
        DepthOfFieldFstop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldFstop");
        DepthOfFieldMinFstop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldMinFstop");
        DepthOfFieldBladeCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldBladeCount");
        AutoExposureBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureBias");
        AutoExposureApplyPhysicalCameraExposure_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureApplyPhysicalCameraExposure");
        AutoExposureApplyPhysicalCameraExposure_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AutoExposureApplyPhysicalCameraExposure");
        AutoExposureBiasCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureBiasCurve");
        AutoExposureMeterMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureMeterMask");
        AutoExposureLowPercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureLowPercent");
        AutoExposureHighPercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureHighPercent");
        AutoExposureMinBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureMinBrightness");
        AutoExposureMaxBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureMaxBrightness");
        AutoExposureSpeedUp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureSpeedUp");
        AutoExposureSpeedDown_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoExposureSpeedDown");
        HistogramLogMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HistogramLogMin");
        HistogramLogMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HistogramLogMax");
        LocalExposureHighlightContrastScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalExposureHighlightContrastScale");
        LocalExposureShadowContrastScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalExposureShadowContrastScale");
        LocalExposureDetailStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalExposureDetailStrength");
        LocalExposureBlurredLuminanceBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalExposureBlurredLuminanceBlend");
        LocalExposureBlurredLuminanceKernelSizePercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalExposureBlurredLuminanceKernelSizePercent");
        LocalExposureMiddleGreyBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalExposureMiddleGreyBias");
        LensFlareIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LensFlareIntensity");
        LensFlareTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LensFlareTint");
        LensFlareBokehSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LensFlareBokehSize");
        LensFlareThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LensFlareThreshold");
        LensFlareBokehShape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LensFlareBokehShape");
        VignetteIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VignetteIntensity");
        Sharpen_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sharpen");
        FilmGrainIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainIntensity");
        FilmGrainIntensityShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainIntensityShadows");
        FilmGrainIntensityMidtones_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainIntensityMidtones");
        FilmGrainIntensityHighlights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainIntensityHighlights");
        FilmGrainShadowsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainShadowsMax");
        FilmGrainHighlightsMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainHighlightsMin");
        FilmGrainHighlightsMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainHighlightsMax");
        FilmGrainTexelSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainTexelSize");
        FilmGrainTexture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmGrainTexture");
        AmbientOcclusionIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionIntensity");
        AmbientOcclusionStaticFraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionStaticFraction");
        AmbientOcclusionRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionRadius");
        AmbientOcclusionRadiusInWS_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionRadiusInWS");
        AmbientOcclusionRadiusInWS_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AmbientOcclusionRadiusInWS");
        AmbientOcclusionFadeDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionFadeDistance");
        AmbientOcclusionFadeRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionFadeRadius");
        AmbientOcclusionPower_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionPower");
        AmbientOcclusionBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionBias");
        AmbientOcclusionQuality_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionQuality");
        AmbientOcclusionMipBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionMipBlend");
        AmbientOcclusionMipScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionMipScale");
        AmbientOcclusionMipThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionMipThreshold");
        AmbientOcclusionTemporalBlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AmbientOcclusionTemporalBlendWeight");
        RayTracingAO_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingAO");
        RayTracingAO_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RayTracingAO");
        RayTracingAOSamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingAOSamplesPerPixel");
        RayTracingAOIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingAOIntensity");
        RayTracingAORadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingAORadius");
        ColorGradingIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGradingIntensity");
        ColorGradingLUT_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorGradingLUT");
        DepthOfFieldSensorWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldSensorWidth");
        DepthOfFieldSqueezeFactor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldSqueezeFactor");
        DepthOfFieldFocalDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldFocalDistance");
        DepthOfFieldDepthBlurAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldDepthBlurAmount");
        DepthOfFieldDepthBlurRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldDepthBlurRadius");
        DepthOfFieldFocalRegion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldFocalRegion");
        DepthOfFieldNearTransitionRegion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldNearTransitionRegion");
        DepthOfFieldFarTransitionRegion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldFarTransitionRegion");
        DepthOfFieldScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldScale");
        DepthOfFieldNearBlurSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldNearBlurSize");
        DepthOfFieldFarBlurSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldFarBlurSize");
        DepthOfFieldOcclusion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldOcclusion");
        DepthOfFieldSkyFocusDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldSkyFocusDistance");
        DepthOfFieldVignetteSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthOfFieldVignetteSize");
        MotionBlurAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MotionBlurAmount");
        MotionBlurMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MotionBlurMax");
        MotionBlurTargetFPS_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MotionBlurTargetFPS");
        MotionBlurPerObjectSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MotionBlurPerObjectSize");
        TranslucencyType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TranslucencyType");
        RayTracingTranslucencyMaxRoughness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingTranslucencyMaxRoughness");
        RayTracingTranslucencyRefractionRays_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingTranslucencyRefractionRays");
        RayTracingTranslucencySamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingTranslucencySamplesPerPixel");
        RayTracingTranslucencyShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingTranslucencyShadows");
        RayTracingTranslucencyRefraction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RayTracingTranslucencyRefraction");
        RayTracingTranslucencyRefraction_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "RayTracingTranslucencyRefraction");
        PathTracingMaxBounces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingMaxBounces");
        PathTracingSamplesPerPixel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingSamplesPerPixel");
        PathTracingMaxPathExposure_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingMaxPathExposure");
        PathTracingEnableReferenceDOF_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingEnableReferenceDOF");
        PathTracingEnableReferenceDOF_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingEnableReferenceDOF");
        PathTracingEnableReferenceAtmosphere_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingEnableReferenceAtmosphere");
        PathTracingEnableReferenceAtmosphere_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingEnableReferenceAtmosphere");
        PathTracingEnableDenoiser_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingEnableDenoiser");
        PathTracingEnableDenoiser_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingEnableDenoiser");
        PathTracingIncludeEmissive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingIncludeEmissive");
        PathTracingIncludeEmissive_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingIncludeEmissive");
        PathTracingIncludeIndirectEmissive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingIncludeIndirectEmissive");
        PathTracingIncludeIndirectEmissive_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingIncludeIndirectEmissive");
        PathTracingIncludeDiffuse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingIncludeDiffuse");
        PathTracingIncludeDiffuse_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingIncludeDiffuse");
        PathTracingIncludeIndirectDiffuse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingIncludeIndirectDiffuse");
        PathTracingIncludeIndirectDiffuse_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingIncludeIndirectDiffuse");
        PathTracingIncludeSpecular_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingIncludeSpecular");
        PathTracingIncludeSpecular_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingIncludeSpecular");
        PathTracingIncludeIndirectSpecular_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingIncludeIndirectSpecular");
        PathTracingIncludeIndirectSpecular_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingIncludeIndirectSpecular");
        PathTracingIncludeVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingIncludeVolume");
        PathTracingIncludeVolume_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingIncludeVolume");
        PathTracingIncludeIndirectVolume_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PathTracingIncludeIndirectVolume");
        PathTracingIncludeIndirectVolume_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PathTracingIncludeIndirectVolume");
        WeightedBlendables_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WeightedBlendables");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PostProcessSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Override_TemperatureType = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_TemperatureType_NativeProperty, bOverride_TemperatureType_Offset);
            Override_WhiteTemp = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_WhiteTemp_NativeProperty, bOverride_WhiteTemp_Offset);
            Override_WhiteTint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_WhiteTint_NativeProperty, bOverride_WhiteTint_Offset);
            Override_ColorSaturation = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorSaturation_NativeProperty, bOverride_ColorSaturation_Offset);
            Override_ColorContrast = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorContrast_NativeProperty, bOverride_ColorContrast_Offset);
            Override_ColorGamma = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGamma_NativeProperty, bOverride_ColorGamma_Offset);
            Override_ColorGain = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGain_NativeProperty, bOverride_ColorGain_Offset);
            Override_ColorOffset = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorOffset_NativeProperty, bOverride_ColorOffset_Offset);
            Override_ColorSaturationShadows = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorSaturationShadows_NativeProperty, bOverride_ColorSaturationShadows_Offset);
            Override_ColorContrastShadows = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorContrastShadows_NativeProperty, bOverride_ColorContrastShadows_Offset);
            Override_ColorGammaShadows = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGammaShadows_NativeProperty, bOverride_ColorGammaShadows_Offset);
            Override_ColorGainShadows = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGainShadows_NativeProperty, bOverride_ColorGainShadows_Offset);
            Override_ColorOffsetShadows = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorOffsetShadows_NativeProperty, bOverride_ColorOffsetShadows_Offset);
            Override_ColorSaturationMidtones = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorSaturationMidtones_NativeProperty, bOverride_ColorSaturationMidtones_Offset);
            Override_ColorContrastMidtones = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorContrastMidtones_NativeProperty, bOverride_ColorContrastMidtones_Offset);
            Override_ColorGammaMidtones = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGammaMidtones_NativeProperty, bOverride_ColorGammaMidtones_Offset);
            Override_ColorGainMidtones = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGainMidtones_NativeProperty, bOverride_ColorGainMidtones_Offset);
            Override_ColorOffsetMidtones = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorOffsetMidtones_NativeProperty, bOverride_ColorOffsetMidtones_Offset);
            Override_ColorSaturationHighlights = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorSaturationHighlights_NativeProperty, bOverride_ColorSaturationHighlights_Offset);
            Override_ColorContrastHighlights = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorContrastHighlights_NativeProperty, bOverride_ColorContrastHighlights_Offset);
            Override_ColorGammaHighlights = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGammaHighlights_NativeProperty, bOverride_ColorGammaHighlights_Offset);
            Override_ColorGainHighlights = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGainHighlights_NativeProperty, bOverride_ColorGainHighlights_Offset);
            Override_ColorOffsetHighlights = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorOffsetHighlights_NativeProperty, bOverride_ColorOffsetHighlights_Offset);
            Override_ColorCorrectionShadowsMax = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorCorrectionShadowsMax_NativeProperty, bOverride_ColorCorrectionShadowsMax_Offset);
            Override_ColorCorrectionHighlightsMin = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorCorrectionHighlightsMin_NativeProperty, bOverride_ColorCorrectionHighlightsMin_Offset);
            Override_ColorCorrectionHighlightsMax = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorCorrectionHighlightsMax_NativeProperty, bOverride_ColorCorrectionHighlightsMax_Offset);
            Override_BlueCorrection = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BlueCorrection_NativeProperty, bOverride_BlueCorrection_Offset);
            Override_ExpandGamut = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ExpandGamut_NativeProperty, bOverride_ExpandGamut_Offset);
            Override_ToneCurveAmount = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ToneCurveAmount_NativeProperty, bOverride_ToneCurveAmount_Offset);
            Override_FilmSlope = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmSlope_NativeProperty, bOverride_FilmSlope_Offset);
            Override_FilmToe = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmToe_NativeProperty, bOverride_FilmToe_Offset);
            Override_FilmShoulder = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmShoulder_NativeProperty, bOverride_FilmShoulder_Offset);
            Override_FilmBlackClip = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmBlackClip_NativeProperty, bOverride_FilmBlackClip_Offset);
            Override_FilmWhiteClip = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmWhiteClip_NativeProperty, bOverride_FilmWhiteClip_Offset);
            Override_SceneColorTint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_SceneColorTint_NativeProperty, bOverride_SceneColorTint_Offset);
            Override_SceneFringeIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_SceneFringeIntensity_NativeProperty, bOverride_SceneFringeIntensity_Offset);
            Override_ChromaticAberrationStartOffset = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ChromaticAberrationStartOffset_NativeProperty, bOverride_ChromaticAberrationStartOffset_Offset);
            Override_AmbientCubemapTint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientCubemapTint_NativeProperty, bOverride_AmbientCubemapTint_Offset);
            Override_AmbientCubemapIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientCubemapIntensity_NativeProperty, bOverride_AmbientCubemapIntensity_Offset);
            Override_BloomMethod = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomMethod_NativeProperty, bOverride_BloomMethod_Offset);
            Override_BloomIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomIntensity_NativeProperty, bOverride_BloomIntensity_Offset);
            Override_BloomThreshold = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomThreshold_NativeProperty, bOverride_BloomThreshold_Offset);
            Override_Bloom1Tint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom1Tint_NativeProperty, bOverride_Bloom1Tint_Offset);
            Override_Bloom1Size = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom1Size_NativeProperty, bOverride_Bloom1Size_Offset);
            Override_Bloom2Size = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom2Size_NativeProperty, bOverride_Bloom2Size_Offset);
            Override_Bloom2Tint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom2Tint_NativeProperty, bOverride_Bloom2Tint_Offset);
            Override_Bloom3Tint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom3Tint_NativeProperty, bOverride_Bloom3Tint_Offset);
            Override_Bloom3Size = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom3Size_NativeProperty, bOverride_Bloom3Size_Offset);
            Override_Bloom4Tint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom4Tint_NativeProperty, bOverride_Bloom4Tint_Offset);
            Override_Bloom4Size = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom4Size_NativeProperty, bOverride_Bloom4Size_Offset);
            Override_Bloom5Tint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom5Tint_NativeProperty, bOverride_Bloom5Tint_Offset);
            Override_Bloom5Size = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom5Size_NativeProperty, bOverride_Bloom5Size_Offset);
            Override_Bloom6Tint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom6Tint_NativeProperty, bOverride_Bloom6Tint_Offset);
            Override_Bloom6Size = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Bloom6Size_NativeProperty, bOverride_Bloom6Size_Offset);
            Override_BloomSizeScale = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomSizeScale_NativeProperty, bOverride_BloomSizeScale_Offset);
            Override_BloomConvolutionTexture = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomConvolutionTexture_NativeProperty, bOverride_BloomConvolutionTexture_Offset);
            Override_BloomConvolutionScatterDispersion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomConvolutionScatterDispersion_NativeProperty, bOverride_BloomConvolutionScatterDispersion_Offset);
            Override_BloomConvolutionSize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomConvolutionSize_NativeProperty, bOverride_BloomConvolutionSize_Offset);
            Override_BloomConvolutionCenterUV = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomConvolutionCenterUV_NativeProperty, bOverride_BloomConvolutionCenterUV_Offset);
            Override_BloomConvolutionPreFilterMin = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomConvolutionPreFilterMin_NativeProperty, bOverride_BloomConvolutionPreFilterMin_Offset);
            Override_BloomConvolutionPreFilterMax = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomConvolutionPreFilterMax_NativeProperty, bOverride_BloomConvolutionPreFilterMax_Offset);
            Override_BloomConvolutionPreFilterMult = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomConvolutionPreFilterMult_NativeProperty, bOverride_BloomConvolutionPreFilterMult_Offset);
            Override_BloomConvolutionBufferScale = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomConvolutionBufferScale_NativeProperty, bOverride_BloomConvolutionBufferScale_Offset);
            Override_BloomDirtMaskIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomDirtMaskIntensity_NativeProperty, bOverride_BloomDirtMaskIntensity_Offset);
            Override_BloomDirtMaskTint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomDirtMaskTint_NativeProperty, bOverride_BloomDirtMaskTint_Offset);
            Override_BloomDirtMask = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_BloomDirtMask_NativeProperty, bOverride_BloomDirtMask_Offset);
            Override_CameraShutterSpeed = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_CameraShutterSpeed_NativeProperty, bOverride_CameraShutterSpeed_Offset);
            Override_CameraISO = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_CameraISO_NativeProperty, bOverride_CameraISO_Offset);
            Override_AutoExposureMethod = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureMethod_NativeProperty, bOverride_AutoExposureMethod_Offset);
            Override_AutoExposureLowPercent = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureLowPercent_NativeProperty, bOverride_AutoExposureLowPercent_Offset);
            Override_AutoExposureHighPercent = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureHighPercent_NativeProperty, bOverride_AutoExposureHighPercent_Offset);
            Override_AutoExposureMinBrightness = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureMinBrightness_NativeProperty, bOverride_AutoExposureMinBrightness_Offset);
            Override_AutoExposureMaxBrightness = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureMaxBrightness_NativeProperty, bOverride_AutoExposureMaxBrightness_Offset);
            Override_AutoExposureSpeedUp = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureSpeedUp_NativeProperty, bOverride_AutoExposureSpeedUp_Offset);
            Override_AutoExposureSpeedDown = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureSpeedDown_NativeProperty, bOverride_AutoExposureSpeedDown_Offset);
            Override_AutoExposureBias = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureBias_NativeProperty, bOverride_AutoExposureBias_Offset);
            Override_AutoExposureBiasCurve = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureBiasCurve_NativeProperty, bOverride_AutoExposureBiasCurve_Offset);
            Override_AutoExposureMeterMask = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureMeterMask_NativeProperty, bOverride_AutoExposureMeterMask_Offset);
            Override_AutoExposureApplyPhysicalCameraExposure = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AutoExposureApplyPhysicalCameraExposure_NativeProperty, bOverride_AutoExposureApplyPhysicalCameraExposure_Offset);
            Override_HistogramLogMin = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_HistogramLogMin_NativeProperty, bOverride_HistogramLogMin_Offset);
            Override_HistogramLogMax = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_HistogramLogMax_NativeProperty, bOverride_HistogramLogMax_Offset);
            Override_LocalExposureHighlightContrastScale = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LocalExposureHighlightContrastScale_NativeProperty, bOverride_LocalExposureHighlightContrastScale_Offset);
            Override_LocalExposureShadowContrastScale = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LocalExposureShadowContrastScale_NativeProperty, bOverride_LocalExposureShadowContrastScale_Offset);
            Override_LocalExposureDetailStrength = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LocalExposureDetailStrength_NativeProperty, bOverride_LocalExposureDetailStrength_Offset);
            Override_LocalExposureBlurredLuminanceBlend = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LocalExposureBlurredLuminanceBlend_NativeProperty, bOverride_LocalExposureBlurredLuminanceBlend_Offset);
            Override_LocalExposureBlurredLuminanceKernelSizePercent = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LocalExposureBlurredLuminanceKernelSizePercent_NativeProperty, bOverride_LocalExposureBlurredLuminanceKernelSizePercent_Offset);
            Override_LocalExposureMiddleGreyBias = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LocalExposureMiddleGreyBias_NativeProperty, bOverride_LocalExposureMiddleGreyBias_Offset);
            Override_LensFlareIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LensFlareIntensity_NativeProperty, bOverride_LensFlareIntensity_Offset);
            Override_LensFlareTint = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LensFlareTint_NativeProperty, bOverride_LensFlareTint_Offset);
            Override_LensFlareTints = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LensFlareTints_NativeProperty, bOverride_LensFlareTints_Offset);
            Override_LensFlareBokehSize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LensFlareBokehSize_NativeProperty, bOverride_LensFlareBokehSize_Offset);
            Override_LensFlareBokehShape = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LensFlareBokehShape_NativeProperty, bOverride_LensFlareBokehShape_Offset);
            Override_LensFlareThreshold = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LensFlareThreshold_NativeProperty, bOverride_LensFlareThreshold_Offset);
            Override_VignetteIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_VignetteIntensity_NativeProperty, bOverride_VignetteIntensity_Offset);
            Override_Sharpen = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_Sharpen_NativeProperty, bOverride_Sharpen_Offset);
            Override_FilmGrainIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainIntensity_NativeProperty, bOverride_FilmGrainIntensity_Offset);
            Override_FilmGrainIntensityShadows = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainIntensityShadows_NativeProperty, bOverride_FilmGrainIntensityShadows_Offset);
            Override_FilmGrainIntensityMidtones = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainIntensityMidtones_NativeProperty, bOverride_FilmGrainIntensityMidtones_Offset);
            Override_FilmGrainIntensityHighlights = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainIntensityHighlights_NativeProperty, bOverride_FilmGrainIntensityHighlights_Offset);
            Override_FilmGrainShadowsMax = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainShadowsMax_NativeProperty, bOverride_FilmGrainShadowsMax_Offset);
            Override_FilmGrainHighlightsMin = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainHighlightsMin_NativeProperty, bOverride_FilmGrainHighlightsMin_Offset);
            Override_FilmGrainHighlightsMax = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainHighlightsMax_NativeProperty, bOverride_FilmGrainHighlightsMax_Offset);
            Override_FilmGrainTexelSize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainTexelSize_NativeProperty, bOverride_FilmGrainTexelSize_Offset);
            Override_FilmGrainTexture = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_FilmGrainTexture_NativeProperty, bOverride_FilmGrainTexture_Offset);
            Override_AmbientOcclusionIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionIntensity_NativeProperty, bOverride_AmbientOcclusionIntensity_Offset);
            Override_AmbientOcclusionStaticFraction = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionStaticFraction_NativeProperty, bOverride_AmbientOcclusionStaticFraction_Offset);
            Override_AmbientOcclusionRadius = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionRadius_NativeProperty, bOverride_AmbientOcclusionRadius_Offset);
            Override_AmbientOcclusionFadeDistance = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionFadeDistance_NativeProperty, bOverride_AmbientOcclusionFadeDistance_Offset);
            Override_AmbientOcclusionFadeRadius = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionFadeRadius_NativeProperty, bOverride_AmbientOcclusionFadeRadius_Offset);
            Override_AmbientOcclusionRadiusInWS = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionRadiusInWS_NativeProperty, bOverride_AmbientOcclusionRadiusInWS_Offset);
            Override_AmbientOcclusionPower = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionPower_NativeProperty, bOverride_AmbientOcclusionPower_Offset);
            Override_AmbientOcclusionBias = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionBias_NativeProperty, bOverride_AmbientOcclusionBias_Offset);
            Override_AmbientOcclusionQuality = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionQuality_NativeProperty, bOverride_AmbientOcclusionQuality_Offset);
            Override_AmbientOcclusionMipBlend = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionMipBlend_NativeProperty, bOverride_AmbientOcclusionMipBlend_Offset);
            Override_AmbientOcclusionMipScale = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionMipScale_NativeProperty, bOverride_AmbientOcclusionMipScale_Offset);
            Override_AmbientOcclusionMipThreshold = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionMipThreshold_NativeProperty, bOverride_AmbientOcclusionMipThreshold_Offset);
            Override_AmbientOcclusionTemporalBlendWeight = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_AmbientOcclusionTemporalBlendWeight_NativeProperty, bOverride_AmbientOcclusionTemporalBlendWeight_Offset);
            Override_RayTracingAO = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingAO_NativeProperty, bOverride_RayTracingAO_Offset);
            Override_RayTracingAOSamplesPerPixel = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingAOSamplesPerPixel_NativeProperty, bOverride_RayTracingAOSamplesPerPixel_Offset);
            Override_RayTracingAOIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingAOIntensity_NativeProperty, bOverride_RayTracingAOIntensity_Offset);
            Override_RayTracingAORadius = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingAORadius_NativeProperty, bOverride_RayTracingAORadius_Offset);
            Override_IndirectLightingColor = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_IndirectLightingColor_NativeProperty, bOverride_IndirectLightingColor_Offset);
            Override_IndirectLightingIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_IndirectLightingIntensity_NativeProperty, bOverride_IndirectLightingIntensity_Offset);
            Override_ColorGradingIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGradingIntensity_NativeProperty, bOverride_ColorGradingIntensity_Offset);
            Override_ColorGradingLUT = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ColorGradingLUT_NativeProperty, bOverride_ColorGradingLUT_Offset);
            Override_DepthOfFieldFocalDistance = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldFocalDistance_NativeProperty, bOverride_DepthOfFieldFocalDistance_Offset);
            Override_DepthOfFieldFstop = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldFstop_NativeProperty, bOverride_DepthOfFieldFstop_Offset);
            Override_DepthOfFieldMinFstop = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldMinFstop_NativeProperty, bOverride_DepthOfFieldMinFstop_Offset);
            Override_DepthOfFieldBladeCount = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldBladeCount_NativeProperty, bOverride_DepthOfFieldBladeCount_Offset);
            Override_DepthOfFieldSensorWidth = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldSensorWidth_NativeProperty, bOverride_DepthOfFieldSensorWidth_Offset);
            Override_DepthOfFieldSqueezeFactor = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldSqueezeFactor_NativeProperty, bOverride_DepthOfFieldSqueezeFactor_Offset);
            Override_DepthOfFieldDepthBlurRadius = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldDepthBlurRadius_NativeProperty, bOverride_DepthOfFieldDepthBlurRadius_Offset);
            Override_DepthOfFieldDepthBlurAmount = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldDepthBlurAmount_NativeProperty, bOverride_DepthOfFieldDepthBlurAmount_Offset);
            Override_DepthOfFieldFocalRegion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldFocalRegion_NativeProperty, bOverride_DepthOfFieldFocalRegion_Offset);
            Override_DepthOfFieldNearTransitionRegion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldNearTransitionRegion_NativeProperty, bOverride_DepthOfFieldNearTransitionRegion_Offset);
            Override_DepthOfFieldFarTransitionRegion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldFarTransitionRegion_NativeProperty, bOverride_DepthOfFieldFarTransitionRegion_Offset);
            Override_DepthOfFieldScale = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldScale_NativeProperty, bOverride_DepthOfFieldScale_Offset);
            Override_DepthOfFieldNearBlurSize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldNearBlurSize_NativeProperty, bOverride_DepthOfFieldNearBlurSize_Offset);
            Override_DepthOfFieldFarBlurSize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldFarBlurSize_NativeProperty, bOverride_DepthOfFieldFarBlurSize_Offset);
            Override_MobileHQGaussian = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_MobileHQGaussian_NativeProperty, bOverride_MobileHQGaussian_Offset);
            Override_DepthOfFieldOcclusion = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldOcclusion_NativeProperty, bOverride_DepthOfFieldOcclusion_Offset);
            Override_DepthOfFieldSkyFocusDistance = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldSkyFocusDistance_NativeProperty, bOverride_DepthOfFieldSkyFocusDistance_Offset);
            Override_DepthOfFieldVignetteSize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DepthOfFieldVignetteSize_NativeProperty, bOverride_DepthOfFieldVignetteSize_Offset);
            Override_MotionBlurAmount = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_MotionBlurAmount_NativeProperty, bOverride_MotionBlurAmount_Offset);
            Override_MotionBlurMax = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_MotionBlurMax_NativeProperty, bOverride_MotionBlurMax_Offset);
            Override_MotionBlurTargetFPS = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_MotionBlurTargetFPS_NativeProperty, bOverride_MotionBlurTargetFPS_Offset);
            Override_MotionBlurPerObjectSize = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_MotionBlurPerObjectSize_NativeProperty, bOverride_MotionBlurPerObjectSize_Offset);
            Override_ReflectionMethod = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ReflectionMethod_NativeProperty, bOverride_ReflectionMethod_Offset);
            Override_LumenReflectionQuality = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenReflectionQuality_NativeProperty, bOverride_LumenReflectionQuality_Offset);
            Override_ScreenSpaceReflectionIntensity = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ScreenSpaceReflectionIntensity_NativeProperty, bOverride_ScreenSpaceReflectionIntensity_Offset);
            Override_ScreenSpaceReflectionQuality = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ScreenSpaceReflectionQuality_NativeProperty, bOverride_ScreenSpaceReflectionQuality_Offset);
            Override_ScreenSpaceReflectionMaxRoughness = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ScreenSpaceReflectionMaxRoughness_NativeProperty, bOverride_ScreenSpaceReflectionMaxRoughness_Offset);
            Override_ScreenSpaceReflectionRoughnessScale = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_ScreenSpaceReflectionRoughnessScale_NativeProperty, bOverride_ScreenSpaceReflectionRoughnessScale_Offset);
            Override_RayTracingReflectionsMaxRoughness = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingReflectionsMaxRoughness_NativeProperty, bOverride_RayTracingReflectionsMaxRoughness_Offset);
            Override_RayTracingReflectionsMaxBounces = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingReflectionsMaxBounces_NativeProperty, bOverride_RayTracingReflectionsMaxBounces_Offset);
            Override_RayTracingReflectionsSamplesPerPixel = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingReflectionsSamplesPerPixel_NativeProperty, bOverride_RayTracingReflectionsSamplesPerPixel_Offset);
            Override_RayTracingReflectionsShadows = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingReflectionsShadows_NativeProperty, bOverride_RayTracingReflectionsShadows_Offset);
            Override_RayTracingReflectionsTranslucency = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingReflectionsTranslucency_NativeProperty, bOverride_RayTracingReflectionsTranslucency_Offset);
            Override_TranslucencyType = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_TranslucencyType_NativeProperty, bOverride_TranslucencyType_Offset);
            Override_RayTracingTranslucencyMaxRoughness = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingTranslucencyMaxRoughness_NativeProperty, bOverride_RayTracingTranslucencyMaxRoughness_Offset);
            Override_RayTracingTranslucencyRefractionRays = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingTranslucencyRefractionRays_NativeProperty, bOverride_RayTracingTranslucencyRefractionRays_Offset);
            Override_RayTracingTranslucencySamplesPerPixel = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingTranslucencySamplesPerPixel_NativeProperty, bOverride_RayTracingTranslucencySamplesPerPixel_Offset);
            Override_RayTracingTranslucencyShadows = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingTranslucencyShadows_NativeProperty, bOverride_RayTracingTranslucencyShadows_Offset);
            Override_RayTracingTranslucencyRefraction = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingTranslucencyRefraction_NativeProperty, bOverride_RayTracingTranslucencyRefraction_Offset);
            Override_DynamicGlobalIlluminationMethod = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_DynamicGlobalIlluminationMethod_NativeProperty, bOverride_DynamicGlobalIlluminationMethod_Offset);
            Override_LumenSceneLightingQuality = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenSceneLightingQuality_NativeProperty, bOverride_LumenSceneLightingQuality_Offset);
            Override_LumenSceneDetail = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenSceneDetail_NativeProperty, bOverride_LumenSceneDetail_Offset);
            Override_LumenSceneViewDistance = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenSceneViewDistance_NativeProperty, bOverride_LumenSceneViewDistance_Offset);
            Override_LumenSceneLightingUpdateSpeed = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenSceneLightingUpdateSpeed_NativeProperty, bOverride_LumenSceneLightingUpdateSpeed_Offset);
            Override_LumenFinalGatherQuality = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenFinalGatherQuality_NativeProperty, bOverride_LumenFinalGatherQuality_Offset);
            Override_LumenFinalGatherLightingUpdateSpeed = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenFinalGatherLightingUpdateSpeed_NativeProperty, bOverride_LumenFinalGatherLightingUpdateSpeed_Offset);
            Override_LumenMaxTraceDistance = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenMaxTraceDistance_NativeProperty, bOverride_LumenMaxTraceDistance_Offset);
            Override_LumenDiffuseColorBoost = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenDiffuseColorBoost_NativeProperty, bOverride_LumenDiffuseColorBoost_Offset);
            Override_LumenSkylightLeaking = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenSkylightLeaking_NativeProperty, bOverride_LumenSkylightLeaking_Offset);
            Override_LumenFullSkylightLeakingDistance = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenFullSkylightLeakingDistance_NativeProperty, bOverride_LumenFullSkylightLeakingDistance_Offset);
            Override_LumenRayLightingMode = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenRayLightingMode_NativeProperty, bOverride_LumenRayLightingMode_Offset);
            Override_LumenFrontLayerTranslucencyReflections = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenFrontLayerTranslucencyReflections_NativeProperty, bOverride_LumenFrontLayerTranslucencyReflections_Offset);
            Override_LumenMaxReflectionBounces = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenMaxReflectionBounces_NativeProperty, bOverride_LumenMaxReflectionBounces_Offset);
            Override_LumenSurfaceCacheResolution = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_LumenSurfaceCacheResolution_NativeProperty, bOverride_LumenSurfaceCacheResolution_Offset);
            Override_RayTracingGI = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingGI_NativeProperty, bOverride_RayTracingGI_Offset);
            Override_RayTracingGIMaxBounces = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingGIMaxBounces_NativeProperty, bOverride_RayTracingGIMaxBounces_Offset);
            Override_RayTracingGISamplesPerPixel = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_RayTracingGISamplesPerPixel_NativeProperty, bOverride_RayTracingGISamplesPerPixel_Offset);
            Override_PathTracingMaxBounces = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingMaxBounces_NativeProperty, bOverride_PathTracingMaxBounces_Offset);
            Override_PathTracingSamplesPerPixel = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingSamplesPerPixel_NativeProperty, bOverride_PathTracingSamplesPerPixel_Offset);
            Override_PathTracingMaxPathExposure = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingMaxPathExposure_NativeProperty, bOverride_PathTracingMaxPathExposure_Offset);
            Override_PathTracingEnableReferenceDOF = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingEnableReferenceDOF_NativeProperty, bOverride_PathTracingEnableReferenceDOF_Offset);
            Override_PathTracingEnableReferenceAtmosphere = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingEnableReferenceAtmosphere_NativeProperty, bOverride_PathTracingEnableReferenceAtmosphere_Offset);
            Override_PathTracingEnableDenoiser = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingEnableDenoiser_NativeProperty, bOverride_PathTracingEnableDenoiser_Offset);
            Override_PathTracingIncludeEmissive = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingIncludeEmissive_NativeProperty, bOverride_PathTracingIncludeEmissive_Offset);
            Override_PathTracingIncludeIndirectEmissive = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingIncludeIndirectEmissive_NativeProperty, bOverride_PathTracingIncludeIndirectEmissive_Offset);
            Override_PathTracingIncludeDiffuse = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingIncludeDiffuse_NativeProperty, bOverride_PathTracingIncludeDiffuse_Offset);
            Override_PathTracingIncludeIndirectDiffuse = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingIncludeIndirectDiffuse_NativeProperty, bOverride_PathTracingIncludeIndirectDiffuse_Offset);
            Override_PathTracingIncludeSpecular = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingIncludeSpecular_NativeProperty, bOverride_PathTracingIncludeSpecular_Offset);
            Override_PathTracingIncludeIndirectSpecular = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingIncludeIndirectSpecular_NativeProperty, bOverride_PathTracingIncludeIndirectSpecular_Offset);
            Override_PathTracingIncludeVolume = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingIncludeVolume_NativeProperty, bOverride_PathTracingIncludeVolume_Offset);
            Override_PathTracingIncludeIndirectVolume = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bOverride_PathTracingIncludeIndirectVolume_NativeProperty, bOverride_PathTracingIncludeIndirectVolume_Offset);
            MobileHQGaussian = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bMobileHQGaussian_NativeProperty, bMobileHQGaussian_Offset);
            BloomMethod = BlittableMarshaller<UnrealSharp.Engine.EBloomMethod>.FromNative(IntPtr.Add(InNativeStruct, BloomMethod_Offset), 0, null);
            AutoExposureMethod = BlittableMarshaller<UnrealSharp.Engine.EAutoExposureMethod>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureMethod_Offset), 0, null);
            TemperatureType = BlittableMarshaller<UnrealSharp.Engine.ETemperatureMethod>.FromNative(IntPtr.Add(InNativeStruct, TemperatureType_Offset), 0, null);
            WhiteTemp = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WhiteTemp_Offset), 0, null);
            WhiteTint = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WhiteTint_Offset), 0, null);
            ColorSaturation = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorSaturation_Offset), 0, null);
            ColorContrast = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorContrast_Offset), 0, null);
            ColorGamma = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorGamma_Offset), 0, null);
            ColorGain = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorGain_Offset), 0, null);
            ColorOffset = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorOffset_Offset), 0, null);
            ColorSaturationShadows = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorSaturationShadows_Offset), 0, null);
            ColorContrastShadows = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorContrastShadows_Offset), 0, null);
            ColorGammaShadows = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorGammaShadows_Offset), 0, null);
            ColorGainShadows = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorGainShadows_Offset), 0, null);
            ColorOffsetShadows = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorOffsetShadows_Offset), 0, null);
            ColorSaturationMidtones = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorSaturationMidtones_Offset), 0, null);
            ColorContrastMidtones = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorContrastMidtones_Offset), 0, null);
            ColorGammaMidtones = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorGammaMidtones_Offset), 0, null);
            ColorGainMidtones = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorGainMidtones_Offset), 0, null);
            ColorOffsetMidtones = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorOffsetMidtones_Offset), 0, null);
            ColorSaturationHighlights = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorSaturationHighlights_Offset), 0, null);
            ColorContrastHighlights = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorContrastHighlights_Offset), 0, null);
            ColorGammaHighlights = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorGammaHighlights_Offset), 0, null);
            ColorGainHighlights = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorGainHighlights_Offset), 0, null);
            ColorOffsetHighlights = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, ColorOffsetHighlights_Offset), 0, null);
            ColorCorrectionHighlightsMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ColorCorrectionHighlightsMin_Offset), 0, null);
            ColorCorrectionHighlightsMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ColorCorrectionHighlightsMax_Offset), 0, null);
            ColorCorrectionShadowsMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ColorCorrectionShadowsMax_Offset), 0, null);
            BlueCorrection = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlueCorrection_Offset), 0, null);
            ExpandGamut = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ExpandGamut_Offset), 0, null);
            ToneCurveAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ToneCurveAmount_Offset), 0, null);
            FilmSlope = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmSlope_Offset), 0, null);
            FilmToe = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmToe_Offset), 0, null);
            FilmShoulder = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmShoulder_Offset), 0, null);
            FilmBlackClip = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmBlackClip_Offset), 0, null);
            FilmWhiteClip = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmWhiteClip_Offset), 0, null);
            SceneColorTint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, SceneColorTint_Offset), 0, null);
            SceneFringeIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SceneFringeIntensity_Offset), 0, null);
            ChromaticAberrationStartOffset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ChromaticAberrationStartOffset_Offset), 0, null);
            BloomIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomIntensity_Offset), 0, null);
            BloomThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomThreshold_Offset), 0, null);
            BloomSizeScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomSizeScale_Offset), 0, null);
            Bloom1Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bloom1Size_Offset), 0, null);
            Bloom2Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bloom2Size_Offset), 0, null);
            Bloom3Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bloom3Size_Offset), 0, null);
            Bloom4Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bloom4Size_Offset), 0, null);
            Bloom5Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bloom5Size_Offset), 0, null);
            Bloom6Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bloom6Size_Offset), 0, null);
            Bloom1Tint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Bloom1Tint_Offset), 0, null);
            Bloom2Tint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Bloom2Tint_Offset), 0, null);
            Bloom3Tint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Bloom3Tint_Offset), 0, null);
            Bloom4Tint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Bloom4Tint_Offset), 0, null);
            Bloom5Tint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Bloom5Tint_Offset), 0, null);
            Bloom6Tint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Bloom6Tint_Offset), 0, null);
            BloomConvolutionScatterDispersion = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomConvolutionScatterDispersion_Offset), 0, null);
            BloomConvolutionSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomConvolutionSize_Offset), 0, null);
            BloomConvolutionTexture = ObjectMarshaller<UnrealSharp.Engine.Texture2D>.FromNative(IntPtr.Add(InNativeStruct, BloomConvolutionTexture_Offset), 0, null);
            BloomConvolutionCenterUV = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, BloomConvolutionCenterUV_Offset), 0, null);
            BloomConvolutionPreFilterMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomConvolutionPreFilterMin_Offset), 0, null);
            BloomConvolutionPreFilterMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomConvolutionPreFilterMax_Offset), 0, null);
            BloomConvolutionPreFilterMult = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomConvolutionPreFilterMult_Offset), 0, null);
            BloomConvolutionBufferScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomConvolutionBufferScale_Offset), 0, null);
            BloomDirtMask = ObjectMarshaller<UnrealSharp.Engine.Texture>.FromNative(IntPtr.Add(InNativeStruct, BloomDirtMask_Offset), 0, null);
            BloomDirtMaskIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BloomDirtMaskIntensity_Offset), 0, null);
            BloomDirtMaskTint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, BloomDirtMaskTint_Offset), 0, null);
            DynamicGlobalIlluminationMethod = BlittableMarshaller<UnrealSharp.Engine.EDynamicGlobalIlluminationMethod>.FromNative(IntPtr.Add(InNativeStruct, DynamicGlobalIlluminationMethod_Offset), 0, null);
            IndirectLightingColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, IndirectLightingColor_Offset), 0, null);
            IndirectLightingIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, IndirectLightingIntensity_Offset), 0, null);
            LumenSceneLightingQuality = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenSceneLightingQuality_Offset), 0, null);
            LumenSceneDetail = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenSceneDetail_Offset), 0, null);
            LumenSceneViewDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenSceneViewDistance_Offset), 0, null);
            LumenSceneLightingUpdateSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenSceneLightingUpdateSpeed_Offset), 0, null);
            LumenFinalGatherQuality = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenFinalGatherQuality_Offset), 0, null);
            LumenFinalGatherLightingUpdateSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenFinalGatherLightingUpdateSpeed_Offset), 0, null);
            LumenMaxTraceDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenMaxTraceDistance_Offset), 0, null);
            LumenDiffuseColorBoost = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenDiffuseColorBoost_Offset), 0, null);
            LumenSkylightLeaking = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenSkylightLeaking_Offset), 0, null);
            LumenFullSkylightLeakingDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenFullSkylightLeakingDistance_Offset), 0, null);
            LumenSurfaceCacheResolution = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenSurfaceCacheResolution_Offset), 0, null);
            RayTracingGIType = BlittableMarshaller<UnrealSharp.Engine.ERayTracingGlobalIlluminationType>.FromNative(IntPtr.Add(InNativeStruct, RayTracingGIType_Offset), 0, null);
            RayTracingGIMaxBounces = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RayTracingGIMaxBounces_Offset), 0, null);
            RayTracingGISamplesPerPixel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RayTracingGISamplesPerPixel_Offset), 0, null);
            ReflectionMethod = BlittableMarshaller<UnrealSharp.Engine.EReflectionMethod>.FromNative(IntPtr.Add(InNativeStruct, ReflectionMethod_Offset), 0, null);
            LumenReflectionQuality = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LumenReflectionQuality_Offset), 0, null);
            LumenRayLightingMode = BlittableMarshaller<UnrealSharp.Engine.ELumenRayLightingModeOverride>.FromNative(IntPtr.Add(InNativeStruct, LumenRayLightingMode_Offset), 0, null);
            LumenFrontLayerTranslucencyReflections = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, LumenFrontLayerTranslucencyReflections_NativeProperty, LumenFrontLayerTranslucencyReflections_Offset);
            LumenMaxReflectionBounces = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, LumenMaxReflectionBounces_Offset), 0, null);
            ScreenSpaceReflectionIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScreenSpaceReflectionIntensity_Offset), 0, null);
            ScreenSpaceReflectionQuality = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScreenSpaceReflectionQuality_Offset), 0, null);
            ScreenSpaceReflectionMaxRoughness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScreenSpaceReflectionMaxRoughness_Offset), 0, null);
            RayTracingReflectionsMaxRoughness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RayTracingReflectionsMaxRoughness_Offset), 0, null);
            RayTracingReflectionsMaxBounces = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RayTracingReflectionsMaxBounces_Offset), 0, null);
            RayTracingReflectionsSamplesPerPixel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RayTracingReflectionsSamplesPerPixel_Offset), 0, null);
            RayTracingReflectionsShadows = BlittableMarshaller<UnrealSharp.Engine.EReflectedAndRefractedRayTracedShadows>.FromNative(IntPtr.Add(InNativeStruct, RayTracingReflectionsShadows_Offset), 0, null);
            RayTracingReflectionsTranslucency = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, RayTracingReflectionsTranslucency_NativeProperty, RayTracingReflectionsTranslucency_Offset);
            AmbientCubemapTint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, AmbientCubemapTint_Offset), 0, null);
            AmbientCubemapIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientCubemapIntensity_Offset), 0, null);
            AmbientCubemap = ObjectMarshaller<UnrealSharp.Engine.TextureCube>.FromNative(IntPtr.Add(InNativeStruct, AmbientCubemap_Offset), 0, null);
            CameraShutterSpeed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CameraShutterSpeed_Offset), 0, null);
            CameraISO = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CameraISO_Offset), 0, null);
            DepthOfFieldFstop = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldFstop_Offset), 0, null);
            DepthOfFieldMinFstop = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldMinFstop_Offset), 0, null);
            DepthOfFieldBladeCount = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldBladeCount_Offset), 0, null);
            AutoExposureBias = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureBias_Offset), 0, null);
            AutoExposureApplyPhysicalCameraExposure = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, AutoExposureApplyPhysicalCameraExposure_NativeProperty, AutoExposureApplyPhysicalCameraExposure_Offset);
            AutoExposureBiasCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureBiasCurve_Offset), 0, null);
            AutoExposureMeterMask = ObjectMarshaller<UnrealSharp.Engine.Texture>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureMeterMask_Offset), 0, null);
            AutoExposureLowPercent = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureLowPercent_Offset), 0, null);
            AutoExposureHighPercent = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureHighPercent_Offset), 0, null);
            AutoExposureMinBrightness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureMinBrightness_Offset), 0, null);
            AutoExposureMaxBrightness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureMaxBrightness_Offset), 0, null);
            AutoExposureSpeedUp = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureSpeedUp_Offset), 0, null);
            AutoExposureSpeedDown = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AutoExposureSpeedDown_Offset), 0, null);
            HistogramLogMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HistogramLogMin_Offset), 0, null);
            HistogramLogMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HistogramLogMax_Offset), 0, null);
            LocalExposureHighlightContrastScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LocalExposureHighlightContrastScale_Offset), 0, null);
            LocalExposureShadowContrastScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LocalExposureShadowContrastScale_Offset), 0, null);
            LocalExposureDetailStrength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LocalExposureDetailStrength_Offset), 0, null);
            LocalExposureBlurredLuminanceBlend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LocalExposureBlurredLuminanceBlend_Offset), 0, null);
            LocalExposureBlurredLuminanceKernelSizePercent = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LocalExposureBlurredLuminanceKernelSizePercent_Offset), 0, null);
            LocalExposureMiddleGreyBias = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LocalExposureMiddleGreyBias_Offset), 0, null);
            LensFlareIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LensFlareIntensity_Offset), 0, null);
            LensFlareTint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, LensFlareTint_Offset), 0, null);
            LensFlareBokehSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LensFlareBokehSize_Offset), 0, null);
            LensFlareThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LensFlareThreshold_Offset), 0, null);
            LensFlareBokehShape = ObjectMarshaller<UnrealSharp.Engine.Texture>.FromNative(IntPtr.Add(InNativeStruct, LensFlareBokehShape_Offset), 0, null);
            VignetteIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VignetteIntensity_Offset), 0, null);
            Sharpen = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Sharpen_Offset), 0, null);
            FilmGrainIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainIntensity_Offset), 0, null);
            FilmGrainIntensityShadows = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainIntensityShadows_Offset), 0, null);
            FilmGrainIntensityMidtones = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainIntensityMidtones_Offset), 0, null);
            FilmGrainIntensityHighlights = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainIntensityHighlights_Offset), 0, null);
            FilmGrainShadowsMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainShadowsMax_Offset), 0, null);
            FilmGrainHighlightsMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainHighlightsMin_Offset), 0, null);
            FilmGrainHighlightsMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainHighlightsMax_Offset), 0, null);
            FilmGrainTexelSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainTexelSize_Offset), 0, null);
            FilmGrainTexture = ObjectMarshaller<UnrealSharp.Engine.Texture2D>.FromNative(IntPtr.Add(InNativeStruct, FilmGrainTexture_Offset), 0, null);
            AmbientOcclusionIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionIntensity_Offset), 0, null);
            AmbientOcclusionStaticFraction = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionStaticFraction_Offset), 0, null);
            AmbientOcclusionRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionRadius_Offset), 0, null);
            AmbientOcclusionRadiusInWS = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, AmbientOcclusionRadiusInWS_NativeProperty, AmbientOcclusionRadiusInWS_Offset);
            AmbientOcclusionFadeDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionFadeDistance_Offset), 0, null);
            AmbientOcclusionFadeRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionFadeRadius_Offset), 0, null);
            AmbientOcclusionPower = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionPower_Offset), 0, null);
            AmbientOcclusionBias = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionBias_Offset), 0, null);
            AmbientOcclusionQuality = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionQuality_Offset), 0, null);
            AmbientOcclusionMipBlend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionMipBlend_Offset), 0, null);
            AmbientOcclusionMipScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionMipScale_Offset), 0, null);
            AmbientOcclusionMipThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionMipThreshold_Offset), 0, null);
            AmbientOcclusionTemporalBlendWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AmbientOcclusionTemporalBlendWeight_Offset), 0, null);
            RayTracingAO = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, RayTracingAO_NativeProperty, RayTracingAO_Offset);
            RayTracingAOSamplesPerPixel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RayTracingAOSamplesPerPixel_Offset), 0, null);
            RayTracingAOIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RayTracingAOIntensity_Offset), 0, null);
            RayTracingAORadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RayTracingAORadius_Offset), 0, null);
            ColorGradingIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ColorGradingIntensity_Offset), 0, null);
            ColorGradingLUT = ObjectMarshaller<UnrealSharp.Engine.Texture>.FromNative(IntPtr.Add(InNativeStruct, ColorGradingLUT_Offset), 0, null);
            DepthOfFieldSensorWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldSensorWidth_Offset), 0, null);
            DepthOfFieldSqueezeFactor = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldSqueezeFactor_Offset), 0, null);
            DepthOfFieldFocalDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldFocalDistance_Offset), 0, null);
            DepthOfFieldDepthBlurAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldDepthBlurAmount_Offset), 0, null);
            DepthOfFieldDepthBlurRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldDepthBlurRadius_Offset), 0, null);
            DepthOfFieldFocalRegion = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldFocalRegion_Offset), 0, null);
            DepthOfFieldNearTransitionRegion = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldNearTransitionRegion_Offset), 0, null);
            DepthOfFieldFarTransitionRegion = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldFarTransitionRegion_Offset), 0, null);
            DepthOfFieldScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldScale_Offset), 0, null);
            DepthOfFieldNearBlurSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldNearBlurSize_Offset), 0, null);
            DepthOfFieldFarBlurSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldFarBlurSize_Offset), 0, null);
            DepthOfFieldOcclusion = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldOcclusion_Offset), 0, null);
            DepthOfFieldSkyFocusDistance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldSkyFocusDistance_Offset), 0, null);
            DepthOfFieldVignetteSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DepthOfFieldVignetteSize_Offset), 0, null);
            MotionBlurAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MotionBlurAmount_Offset), 0, null);
            MotionBlurMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MotionBlurMax_Offset), 0, null);
            MotionBlurTargetFPS = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MotionBlurTargetFPS_Offset), 0, null);
            MotionBlurPerObjectSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MotionBlurPerObjectSize_Offset), 0, null);
            TranslucencyType = BlittableMarshaller<UnrealSharp.Engine.ETranslucencyType>.FromNative(IntPtr.Add(InNativeStruct, TranslucencyType_Offset), 0, null);
            RayTracingTranslucencyMaxRoughness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RayTracingTranslucencyMaxRoughness_Offset), 0, null);
            RayTracingTranslucencyRefractionRays = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RayTracingTranslucencyRefractionRays_Offset), 0, null);
            RayTracingTranslucencySamplesPerPixel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, RayTracingTranslucencySamplesPerPixel_Offset), 0, null);
            RayTracingTranslucencyShadows = BlittableMarshaller<UnrealSharp.Engine.EReflectedAndRefractedRayTracedShadows>.FromNative(IntPtr.Add(InNativeStruct, RayTracingTranslucencyShadows_Offset), 0, null);
            RayTracingTranslucencyRefraction = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, RayTracingTranslucencyRefraction_NativeProperty, RayTracingTranslucencyRefraction_Offset);
            PathTracingMaxBounces = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PathTracingMaxBounces_Offset), 0, null);
            PathTracingSamplesPerPixel = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PathTracingSamplesPerPixel_Offset), 0, null);
            PathTracingMaxPathExposure = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PathTracingMaxPathExposure_Offset), 0, null);
            PathTracingEnableReferenceDOF = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingEnableReferenceDOF_NativeProperty, PathTracingEnableReferenceDOF_Offset);
            PathTracingEnableReferenceAtmosphere = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingEnableReferenceAtmosphere_NativeProperty, PathTracingEnableReferenceAtmosphere_Offset);
            PathTracingEnableDenoiser = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingEnableDenoiser_NativeProperty, PathTracingEnableDenoiser_Offset);
            PathTracingIncludeEmissive = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingIncludeEmissive_NativeProperty, PathTracingIncludeEmissive_Offset);
            PathTracingIncludeIndirectEmissive = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingIncludeIndirectEmissive_NativeProperty, PathTracingIncludeIndirectEmissive_Offset);
            PathTracingIncludeDiffuse = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingIncludeDiffuse_NativeProperty, PathTracingIncludeDiffuse_Offset);
            PathTracingIncludeIndirectDiffuse = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingIncludeIndirectDiffuse_NativeProperty, PathTracingIncludeIndirectDiffuse_Offset);
            PathTracingIncludeSpecular = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingIncludeSpecular_NativeProperty, PathTracingIncludeSpecular_Offset);
            PathTracingIncludeIndirectSpecular = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingIncludeIndirectSpecular_NativeProperty, PathTracingIncludeIndirectSpecular_Offset);
            PathTracingIncludeVolume = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingIncludeVolume_NativeProperty, PathTracingIncludeVolume_Offset);
            PathTracingIncludeIndirectVolume = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, PathTracingIncludeIndirectVolume_NativeProperty, PathTracingIncludeIndirectVolume_Offset);
            WeightedBlendables = UnrealSharp.Engine.WeightedBlendablesMarshaler.FromNative(IntPtr.Add(InNativeStruct, WeightedBlendables_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_TemperatureType_NativeProperty, bOverride_TemperatureType_Offset, Override_TemperatureType);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_WhiteTemp_NativeProperty, bOverride_WhiteTemp_Offset, Override_WhiteTemp);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_WhiteTint_NativeProperty, bOverride_WhiteTint_Offset, Override_WhiteTint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorSaturation_NativeProperty, bOverride_ColorSaturation_Offset, Override_ColorSaturation);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorContrast_NativeProperty, bOverride_ColorContrast_Offset, Override_ColorContrast);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGamma_NativeProperty, bOverride_ColorGamma_Offset, Override_ColorGamma);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGain_NativeProperty, bOverride_ColorGain_Offset, Override_ColorGain);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorOffset_NativeProperty, bOverride_ColorOffset_Offset, Override_ColorOffset);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorSaturationShadows_NativeProperty, bOverride_ColorSaturationShadows_Offset, Override_ColorSaturationShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorContrastShadows_NativeProperty, bOverride_ColorContrastShadows_Offset, Override_ColorContrastShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGammaShadows_NativeProperty, bOverride_ColorGammaShadows_Offset, Override_ColorGammaShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGainShadows_NativeProperty, bOverride_ColorGainShadows_Offset, Override_ColorGainShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorOffsetShadows_NativeProperty, bOverride_ColorOffsetShadows_Offset, Override_ColorOffsetShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorSaturationMidtones_NativeProperty, bOverride_ColorSaturationMidtones_Offset, Override_ColorSaturationMidtones);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorContrastMidtones_NativeProperty, bOverride_ColorContrastMidtones_Offset, Override_ColorContrastMidtones);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGammaMidtones_NativeProperty, bOverride_ColorGammaMidtones_Offset, Override_ColorGammaMidtones);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGainMidtones_NativeProperty, bOverride_ColorGainMidtones_Offset, Override_ColorGainMidtones);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorOffsetMidtones_NativeProperty, bOverride_ColorOffsetMidtones_Offset, Override_ColorOffsetMidtones);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorSaturationHighlights_NativeProperty, bOverride_ColorSaturationHighlights_Offset, Override_ColorSaturationHighlights);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorContrastHighlights_NativeProperty, bOverride_ColorContrastHighlights_Offset, Override_ColorContrastHighlights);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGammaHighlights_NativeProperty, bOverride_ColorGammaHighlights_Offset, Override_ColorGammaHighlights);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGainHighlights_NativeProperty, bOverride_ColorGainHighlights_Offset, Override_ColorGainHighlights);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorOffsetHighlights_NativeProperty, bOverride_ColorOffsetHighlights_Offset, Override_ColorOffsetHighlights);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorCorrectionShadowsMax_NativeProperty, bOverride_ColorCorrectionShadowsMax_Offset, Override_ColorCorrectionShadowsMax);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorCorrectionHighlightsMin_NativeProperty, bOverride_ColorCorrectionHighlightsMin_Offset, Override_ColorCorrectionHighlightsMin);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorCorrectionHighlightsMax_NativeProperty, bOverride_ColorCorrectionHighlightsMax_Offset, Override_ColorCorrectionHighlightsMax);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BlueCorrection_NativeProperty, bOverride_BlueCorrection_Offset, Override_BlueCorrection);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ExpandGamut_NativeProperty, bOverride_ExpandGamut_Offset, Override_ExpandGamut);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ToneCurveAmount_NativeProperty, bOverride_ToneCurveAmount_Offset, Override_ToneCurveAmount);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmSlope_NativeProperty, bOverride_FilmSlope_Offset, Override_FilmSlope);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmToe_NativeProperty, bOverride_FilmToe_Offset, Override_FilmToe);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmShoulder_NativeProperty, bOverride_FilmShoulder_Offset, Override_FilmShoulder);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmBlackClip_NativeProperty, bOverride_FilmBlackClip_Offset, Override_FilmBlackClip);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmWhiteClip_NativeProperty, bOverride_FilmWhiteClip_Offset, Override_FilmWhiteClip);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_SceneColorTint_NativeProperty, bOverride_SceneColorTint_Offset, Override_SceneColorTint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_SceneFringeIntensity_NativeProperty, bOverride_SceneFringeIntensity_Offset, Override_SceneFringeIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ChromaticAberrationStartOffset_NativeProperty, bOverride_ChromaticAberrationStartOffset_Offset, Override_ChromaticAberrationStartOffset);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientCubemapTint_NativeProperty, bOverride_AmbientCubemapTint_Offset, Override_AmbientCubemapTint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientCubemapIntensity_NativeProperty, bOverride_AmbientCubemapIntensity_Offset, Override_AmbientCubemapIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomMethod_NativeProperty, bOverride_BloomMethod_Offset, Override_BloomMethod);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomIntensity_NativeProperty, bOverride_BloomIntensity_Offset, Override_BloomIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomThreshold_NativeProperty, bOverride_BloomThreshold_Offset, Override_BloomThreshold);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom1Tint_NativeProperty, bOverride_Bloom1Tint_Offset, Override_Bloom1Tint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom1Size_NativeProperty, bOverride_Bloom1Size_Offset, Override_Bloom1Size);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom2Size_NativeProperty, bOverride_Bloom2Size_Offset, Override_Bloom2Size);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom2Tint_NativeProperty, bOverride_Bloom2Tint_Offset, Override_Bloom2Tint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom3Tint_NativeProperty, bOverride_Bloom3Tint_Offset, Override_Bloom3Tint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom3Size_NativeProperty, bOverride_Bloom3Size_Offset, Override_Bloom3Size);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom4Tint_NativeProperty, bOverride_Bloom4Tint_Offset, Override_Bloom4Tint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom4Size_NativeProperty, bOverride_Bloom4Size_Offset, Override_Bloom4Size);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom5Tint_NativeProperty, bOverride_Bloom5Tint_Offset, Override_Bloom5Tint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom5Size_NativeProperty, bOverride_Bloom5Size_Offset, Override_Bloom5Size);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom6Tint_NativeProperty, bOverride_Bloom6Tint_Offset, Override_Bloom6Tint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Bloom6Size_NativeProperty, bOverride_Bloom6Size_Offset, Override_Bloom6Size);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomSizeScale_NativeProperty, bOverride_BloomSizeScale_Offset, Override_BloomSizeScale);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomConvolutionTexture_NativeProperty, bOverride_BloomConvolutionTexture_Offset, Override_BloomConvolutionTexture);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomConvolutionScatterDispersion_NativeProperty, bOverride_BloomConvolutionScatterDispersion_Offset, Override_BloomConvolutionScatterDispersion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomConvolutionSize_NativeProperty, bOverride_BloomConvolutionSize_Offset, Override_BloomConvolutionSize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomConvolutionCenterUV_NativeProperty, bOverride_BloomConvolutionCenterUV_Offset, Override_BloomConvolutionCenterUV);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomConvolutionPreFilterMin_NativeProperty, bOverride_BloomConvolutionPreFilterMin_Offset, Override_BloomConvolutionPreFilterMin);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomConvolutionPreFilterMax_NativeProperty, bOverride_BloomConvolutionPreFilterMax_Offset, Override_BloomConvolutionPreFilterMax);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomConvolutionPreFilterMult_NativeProperty, bOverride_BloomConvolutionPreFilterMult_Offset, Override_BloomConvolutionPreFilterMult);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomConvolutionBufferScale_NativeProperty, bOverride_BloomConvolutionBufferScale_Offset, Override_BloomConvolutionBufferScale);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomDirtMaskIntensity_NativeProperty, bOverride_BloomDirtMaskIntensity_Offset, Override_BloomDirtMaskIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomDirtMaskTint_NativeProperty, bOverride_BloomDirtMaskTint_Offset, Override_BloomDirtMaskTint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_BloomDirtMask_NativeProperty, bOverride_BloomDirtMask_Offset, Override_BloomDirtMask);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_CameraShutterSpeed_NativeProperty, bOverride_CameraShutterSpeed_Offset, Override_CameraShutterSpeed);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_CameraISO_NativeProperty, bOverride_CameraISO_Offset, Override_CameraISO);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureMethod_NativeProperty, bOverride_AutoExposureMethod_Offset, Override_AutoExposureMethod);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureLowPercent_NativeProperty, bOverride_AutoExposureLowPercent_Offset, Override_AutoExposureLowPercent);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureHighPercent_NativeProperty, bOverride_AutoExposureHighPercent_Offset, Override_AutoExposureHighPercent);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureMinBrightness_NativeProperty, bOverride_AutoExposureMinBrightness_Offset, Override_AutoExposureMinBrightness);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureMaxBrightness_NativeProperty, bOverride_AutoExposureMaxBrightness_Offset, Override_AutoExposureMaxBrightness);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureSpeedUp_NativeProperty, bOverride_AutoExposureSpeedUp_Offset, Override_AutoExposureSpeedUp);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureSpeedDown_NativeProperty, bOverride_AutoExposureSpeedDown_Offset, Override_AutoExposureSpeedDown);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureBias_NativeProperty, bOverride_AutoExposureBias_Offset, Override_AutoExposureBias);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureBiasCurve_NativeProperty, bOverride_AutoExposureBiasCurve_Offset, Override_AutoExposureBiasCurve);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureMeterMask_NativeProperty, bOverride_AutoExposureMeterMask_Offset, Override_AutoExposureMeterMask);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AutoExposureApplyPhysicalCameraExposure_NativeProperty, bOverride_AutoExposureApplyPhysicalCameraExposure_Offset, Override_AutoExposureApplyPhysicalCameraExposure);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_HistogramLogMin_NativeProperty, bOverride_HistogramLogMin_Offset, Override_HistogramLogMin);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_HistogramLogMax_NativeProperty, bOverride_HistogramLogMax_Offset, Override_HistogramLogMax);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LocalExposureHighlightContrastScale_NativeProperty, bOverride_LocalExposureHighlightContrastScale_Offset, Override_LocalExposureHighlightContrastScale);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LocalExposureShadowContrastScale_NativeProperty, bOverride_LocalExposureShadowContrastScale_Offset, Override_LocalExposureShadowContrastScale);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LocalExposureDetailStrength_NativeProperty, bOverride_LocalExposureDetailStrength_Offset, Override_LocalExposureDetailStrength);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LocalExposureBlurredLuminanceBlend_NativeProperty, bOverride_LocalExposureBlurredLuminanceBlend_Offset, Override_LocalExposureBlurredLuminanceBlend);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LocalExposureBlurredLuminanceKernelSizePercent_NativeProperty, bOverride_LocalExposureBlurredLuminanceKernelSizePercent_Offset, Override_LocalExposureBlurredLuminanceKernelSizePercent);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LocalExposureMiddleGreyBias_NativeProperty, bOverride_LocalExposureMiddleGreyBias_Offset, Override_LocalExposureMiddleGreyBias);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LensFlareIntensity_NativeProperty, bOverride_LensFlareIntensity_Offset, Override_LensFlareIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LensFlareTint_NativeProperty, bOverride_LensFlareTint_Offset, Override_LensFlareTint);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LensFlareTints_NativeProperty, bOverride_LensFlareTints_Offset, Override_LensFlareTints);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LensFlareBokehSize_NativeProperty, bOverride_LensFlareBokehSize_Offset, Override_LensFlareBokehSize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LensFlareBokehShape_NativeProperty, bOverride_LensFlareBokehShape_Offset, Override_LensFlareBokehShape);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LensFlareThreshold_NativeProperty, bOverride_LensFlareThreshold_Offset, Override_LensFlareThreshold);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_VignetteIntensity_NativeProperty, bOverride_VignetteIntensity_Offset, Override_VignetteIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_Sharpen_NativeProperty, bOverride_Sharpen_Offset, Override_Sharpen);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainIntensity_NativeProperty, bOverride_FilmGrainIntensity_Offset, Override_FilmGrainIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainIntensityShadows_NativeProperty, bOverride_FilmGrainIntensityShadows_Offset, Override_FilmGrainIntensityShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainIntensityMidtones_NativeProperty, bOverride_FilmGrainIntensityMidtones_Offset, Override_FilmGrainIntensityMidtones);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainIntensityHighlights_NativeProperty, bOverride_FilmGrainIntensityHighlights_Offset, Override_FilmGrainIntensityHighlights);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainShadowsMax_NativeProperty, bOverride_FilmGrainShadowsMax_Offset, Override_FilmGrainShadowsMax);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainHighlightsMin_NativeProperty, bOverride_FilmGrainHighlightsMin_Offset, Override_FilmGrainHighlightsMin);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainHighlightsMax_NativeProperty, bOverride_FilmGrainHighlightsMax_Offset, Override_FilmGrainHighlightsMax);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainTexelSize_NativeProperty, bOverride_FilmGrainTexelSize_Offset, Override_FilmGrainTexelSize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_FilmGrainTexture_NativeProperty, bOverride_FilmGrainTexture_Offset, Override_FilmGrainTexture);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionIntensity_NativeProperty, bOverride_AmbientOcclusionIntensity_Offset, Override_AmbientOcclusionIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionStaticFraction_NativeProperty, bOverride_AmbientOcclusionStaticFraction_Offset, Override_AmbientOcclusionStaticFraction);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionRadius_NativeProperty, bOverride_AmbientOcclusionRadius_Offset, Override_AmbientOcclusionRadius);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionFadeDistance_NativeProperty, bOverride_AmbientOcclusionFadeDistance_Offset, Override_AmbientOcclusionFadeDistance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionFadeRadius_NativeProperty, bOverride_AmbientOcclusionFadeRadius_Offset, Override_AmbientOcclusionFadeRadius);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionRadiusInWS_NativeProperty, bOverride_AmbientOcclusionRadiusInWS_Offset, Override_AmbientOcclusionRadiusInWS);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionPower_NativeProperty, bOverride_AmbientOcclusionPower_Offset, Override_AmbientOcclusionPower);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionBias_NativeProperty, bOverride_AmbientOcclusionBias_Offset, Override_AmbientOcclusionBias);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionQuality_NativeProperty, bOverride_AmbientOcclusionQuality_Offset, Override_AmbientOcclusionQuality);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionMipBlend_NativeProperty, bOverride_AmbientOcclusionMipBlend_Offset, Override_AmbientOcclusionMipBlend);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionMipScale_NativeProperty, bOverride_AmbientOcclusionMipScale_Offset, Override_AmbientOcclusionMipScale);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionMipThreshold_NativeProperty, bOverride_AmbientOcclusionMipThreshold_Offset, Override_AmbientOcclusionMipThreshold);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_AmbientOcclusionTemporalBlendWeight_NativeProperty, bOverride_AmbientOcclusionTemporalBlendWeight_Offset, Override_AmbientOcclusionTemporalBlendWeight);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingAO_NativeProperty, bOverride_RayTracingAO_Offset, Override_RayTracingAO);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingAOSamplesPerPixel_NativeProperty, bOverride_RayTracingAOSamplesPerPixel_Offset, Override_RayTracingAOSamplesPerPixel);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingAOIntensity_NativeProperty, bOverride_RayTracingAOIntensity_Offset, Override_RayTracingAOIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingAORadius_NativeProperty, bOverride_RayTracingAORadius_Offset, Override_RayTracingAORadius);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_IndirectLightingColor_NativeProperty, bOverride_IndirectLightingColor_Offset, Override_IndirectLightingColor);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_IndirectLightingIntensity_NativeProperty, bOverride_IndirectLightingIntensity_Offset, Override_IndirectLightingIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGradingIntensity_NativeProperty, bOverride_ColorGradingIntensity_Offset, Override_ColorGradingIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ColorGradingLUT_NativeProperty, bOverride_ColorGradingLUT_Offset, Override_ColorGradingLUT);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldFocalDistance_NativeProperty, bOverride_DepthOfFieldFocalDistance_Offset, Override_DepthOfFieldFocalDistance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldFstop_NativeProperty, bOverride_DepthOfFieldFstop_Offset, Override_DepthOfFieldFstop);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldMinFstop_NativeProperty, bOverride_DepthOfFieldMinFstop_Offset, Override_DepthOfFieldMinFstop);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldBladeCount_NativeProperty, bOverride_DepthOfFieldBladeCount_Offset, Override_DepthOfFieldBladeCount);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldSensorWidth_NativeProperty, bOverride_DepthOfFieldSensorWidth_Offset, Override_DepthOfFieldSensorWidth);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldSqueezeFactor_NativeProperty, bOverride_DepthOfFieldSqueezeFactor_Offset, Override_DepthOfFieldSqueezeFactor);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldDepthBlurRadius_NativeProperty, bOverride_DepthOfFieldDepthBlurRadius_Offset, Override_DepthOfFieldDepthBlurRadius);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldDepthBlurAmount_NativeProperty, bOverride_DepthOfFieldDepthBlurAmount_Offset, Override_DepthOfFieldDepthBlurAmount);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldFocalRegion_NativeProperty, bOverride_DepthOfFieldFocalRegion_Offset, Override_DepthOfFieldFocalRegion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldNearTransitionRegion_NativeProperty, bOverride_DepthOfFieldNearTransitionRegion_Offset, Override_DepthOfFieldNearTransitionRegion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldFarTransitionRegion_NativeProperty, bOverride_DepthOfFieldFarTransitionRegion_Offset, Override_DepthOfFieldFarTransitionRegion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldScale_NativeProperty, bOverride_DepthOfFieldScale_Offset, Override_DepthOfFieldScale);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldNearBlurSize_NativeProperty, bOverride_DepthOfFieldNearBlurSize_Offset, Override_DepthOfFieldNearBlurSize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldFarBlurSize_NativeProperty, bOverride_DepthOfFieldFarBlurSize_Offset, Override_DepthOfFieldFarBlurSize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_MobileHQGaussian_NativeProperty, bOverride_MobileHQGaussian_Offset, Override_MobileHQGaussian);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldOcclusion_NativeProperty, bOverride_DepthOfFieldOcclusion_Offset, Override_DepthOfFieldOcclusion);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldSkyFocusDistance_NativeProperty, bOverride_DepthOfFieldSkyFocusDistance_Offset, Override_DepthOfFieldSkyFocusDistance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DepthOfFieldVignetteSize_NativeProperty, bOverride_DepthOfFieldVignetteSize_Offset, Override_DepthOfFieldVignetteSize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_MotionBlurAmount_NativeProperty, bOverride_MotionBlurAmount_Offset, Override_MotionBlurAmount);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_MotionBlurMax_NativeProperty, bOverride_MotionBlurMax_Offset, Override_MotionBlurMax);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_MotionBlurTargetFPS_NativeProperty, bOverride_MotionBlurTargetFPS_Offset, Override_MotionBlurTargetFPS);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_MotionBlurPerObjectSize_NativeProperty, bOverride_MotionBlurPerObjectSize_Offset, Override_MotionBlurPerObjectSize);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ReflectionMethod_NativeProperty, bOverride_ReflectionMethod_Offset, Override_ReflectionMethod);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenReflectionQuality_NativeProperty, bOverride_LumenReflectionQuality_Offset, Override_LumenReflectionQuality);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ScreenSpaceReflectionIntensity_NativeProperty, bOverride_ScreenSpaceReflectionIntensity_Offset, Override_ScreenSpaceReflectionIntensity);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ScreenSpaceReflectionQuality_NativeProperty, bOverride_ScreenSpaceReflectionQuality_Offset, Override_ScreenSpaceReflectionQuality);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ScreenSpaceReflectionMaxRoughness_NativeProperty, bOverride_ScreenSpaceReflectionMaxRoughness_Offset, Override_ScreenSpaceReflectionMaxRoughness);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_ScreenSpaceReflectionRoughnessScale_NativeProperty, bOverride_ScreenSpaceReflectionRoughnessScale_Offset, Override_ScreenSpaceReflectionRoughnessScale);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingReflectionsMaxRoughness_NativeProperty, bOverride_RayTracingReflectionsMaxRoughness_Offset, Override_RayTracingReflectionsMaxRoughness);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingReflectionsMaxBounces_NativeProperty, bOverride_RayTracingReflectionsMaxBounces_Offset, Override_RayTracingReflectionsMaxBounces);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingReflectionsSamplesPerPixel_NativeProperty, bOverride_RayTracingReflectionsSamplesPerPixel_Offset, Override_RayTracingReflectionsSamplesPerPixel);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingReflectionsShadows_NativeProperty, bOverride_RayTracingReflectionsShadows_Offset, Override_RayTracingReflectionsShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingReflectionsTranslucency_NativeProperty, bOverride_RayTracingReflectionsTranslucency_Offset, Override_RayTracingReflectionsTranslucency);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_TranslucencyType_NativeProperty, bOverride_TranslucencyType_Offset, Override_TranslucencyType);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingTranslucencyMaxRoughness_NativeProperty, bOverride_RayTracingTranslucencyMaxRoughness_Offset, Override_RayTracingTranslucencyMaxRoughness);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingTranslucencyRefractionRays_NativeProperty, bOverride_RayTracingTranslucencyRefractionRays_Offset, Override_RayTracingTranslucencyRefractionRays);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingTranslucencySamplesPerPixel_NativeProperty, bOverride_RayTracingTranslucencySamplesPerPixel_Offset, Override_RayTracingTranslucencySamplesPerPixel);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingTranslucencyShadows_NativeProperty, bOverride_RayTracingTranslucencyShadows_Offset, Override_RayTracingTranslucencyShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingTranslucencyRefraction_NativeProperty, bOverride_RayTracingTranslucencyRefraction_Offset, Override_RayTracingTranslucencyRefraction);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_DynamicGlobalIlluminationMethod_NativeProperty, bOverride_DynamicGlobalIlluminationMethod_Offset, Override_DynamicGlobalIlluminationMethod);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenSceneLightingQuality_NativeProperty, bOverride_LumenSceneLightingQuality_Offset, Override_LumenSceneLightingQuality);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenSceneDetail_NativeProperty, bOverride_LumenSceneDetail_Offset, Override_LumenSceneDetail);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenSceneViewDistance_NativeProperty, bOverride_LumenSceneViewDistance_Offset, Override_LumenSceneViewDistance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenSceneLightingUpdateSpeed_NativeProperty, bOverride_LumenSceneLightingUpdateSpeed_Offset, Override_LumenSceneLightingUpdateSpeed);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenFinalGatherQuality_NativeProperty, bOverride_LumenFinalGatherQuality_Offset, Override_LumenFinalGatherQuality);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenFinalGatherLightingUpdateSpeed_NativeProperty, bOverride_LumenFinalGatherLightingUpdateSpeed_Offset, Override_LumenFinalGatherLightingUpdateSpeed);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenMaxTraceDistance_NativeProperty, bOverride_LumenMaxTraceDistance_Offset, Override_LumenMaxTraceDistance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenDiffuseColorBoost_NativeProperty, bOverride_LumenDiffuseColorBoost_Offset, Override_LumenDiffuseColorBoost);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenSkylightLeaking_NativeProperty, bOverride_LumenSkylightLeaking_Offset, Override_LumenSkylightLeaking);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenFullSkylightLeakingDistance_NativeProperty, bOverride_LumenFullSkylightLeakingDistance_Offset, Override_LumenFullSkylightLeakingDistance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenRayLightingMode_NativeProperty, bOverride_LumenRayLightingMode_Offset, Override_LumenRayLightingMode);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenFrontLayerTranslucencyReflections_NativeProperty, bOverride_LumenFrontLayerTranslucencyReflections_Offset, Override_LumenFrontLayerTranslucencyReflections);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenMaxReflectionBounces_NativeProperty, bOverride_LumenMaxReflectionBounces_Offset, Override_LumenMaxReflectionBounces);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_LumenSurfaceCacheResolution_NativeProperty, bOverride_LumenSurfaceCacheResolution_Offset, Override_LumenSurfaceCacheResolution);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingGI_NativeProperty, bOverride_RayTracingGI_Offset, Override_RayTracingGI);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingGIMaxBounces_NativeProperty, bOverride_RayTracingGIMaxBounces_Offset, Override_RayTracingGIMaxBounces);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_RayTracingGISamplesPerPixel_NativeProperty, bOverride_RayTracingGISamplesPerPixel_Offset, Override_RayTracingGISamplesPerPixel);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingMaxBounces_NativeProperty, bOverride_PathTracingMaxBounces_Offset, Override_PathTracingMaxBounces);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingSamplesPerPixel_NativeProperty, bOverride_PathTracingSamplesPerPixel_Offset, Override_PathTracingSamplesPerPixel);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingMaxPathExposure_NativeProperty, bOverride_PathTracingMaxPathExposure_Offset, Override_PathTracingMaxPathExposure);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingEnableReferenceDOF_NativeProperty, bOverride_PathTracingEnableReferenceDOF_Offset, Override_PathTracingEnableReferenceDOF);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingEnableReferenceAtmosphere_NativeProperty, bOverride_PathTracingEnableReferenceAtmosphere_Offset, Override_PathTracingEnableReferenceAtmosphere);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingEnableDenoiser_NativeProperty, bOverride_PathTracingEnableDenoiser_Offset, Override_PathTracingEnableDenoiser);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingIncludeEmissive_NativeProperty, bOverride_PathTracingIncludeEmissive_Offset, Override_PathTracingIncludeEmissive);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingIncludeIndirectEmissive_NativeProperty, bOverride_PathTracingIncludeIndirectEmissive_Offset, Override_PathTracingIncludeIndirectEmissive);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingIncludeDiffuse_NativeProperty, bOverride_PathTracingIncludeDiffuse_Offset, Override_PathTracingIncludeDiffuse);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingIncludeIndirectDiffuse_NativeProperty, bOverride_PathTracingIncludeIndirectDiffuse_Offset, Override_PathTracingIncludeIndirectDiffuse);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingIncludeSpecular_NativeProperty, bOverride_PathTracingIncludeSpecular_Offset, Override_PathTracingIncludeSpecular);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingIncludeIndirectSpecular_NativeProperty, bOverride_PathTracingIncludeIndirectSpecular_Offset, Override_PathTracingIncludeIndirectSpecular);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingIncludeVolume_NativeProperty, bOverride_PathTracingIncludeVolume_Offset, Override_PathTracingIncludeVolume);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bOverride_PathTracingIncludeIndirectVolume_NativeProperty, bOverride_PathTracingIncludeIndirectVolume_Offset, Override_PathTracingIncludeIndirectVolume);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bMobileHQGaussian_NativeProperty, bMobileHQGaussian_Offset, MobileHQGaussian);
            BlittableMarshaller<UnrealSharp.Engine.EBloomMethod>.ToNative(IntPtr.Add(Buffer, BloomMethod_Offset), 0, null, BloomMethod);
            BlittableMarshaller<UnrealSharp.Engine.EAutoExposureMethod>.ToNative(IntPtr.Add(Buffer, AutoExposureMethod_Offset), 0, null, AutoExposureMethod);
            BlittableMarshaller<UnrealSharp.Engine.ETemperatureMethod>.ToNative(IntPtr.Add(Buffer, TemperatureType_Offset), 0, null, TemperatureType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WhiteTemp_Offset), 0, null, WhiteTemp);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WhiteTint_Offset), 0, null, WhiteTint);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorSaturation_Offset), 0, null, ColorSaturation);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorContrast_Offset), 0, null, ColorContrast);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorGamma_Offset), 0, null, ColorGamma);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorGain_Offset), 0, null, ColorGain);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorOffset_Offset), 0, null, ColorOffset);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorSaturationShadows_Offset), 0, null, ColorSaturationShadows);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorContrastShadows_Offset), 0, null, ColorContrastShadows);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorGammaShadows_Offset), 0, null, ColorGammaShadows);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorGainShadows_Offset), 0, null, ColorGainShadows);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorOffsetShadows_Offset), 0, null, ColorOffsetShadows);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorSaturationMidtones_Offset), 0, null, ColorSaturationMidtones);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorContrastMidtones_Offset), 0, null, ColorContrastMidtones);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorGammaMidtones_Offset), 0, null, ColorGammaMidtones);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorGainMidtones_Offset), 0, null, ColorGainMidtones);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorOffsetMidtones_Offset), 0, null, ColorOffsetMidtones);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorSaturationHighlights_Offset), 0, null, ColorSaturationHighlights);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorContrastHighlights_Offset), 0, null, ColorContrastHighlights);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorGammaHighlights_Offset), 0, null, ColorGammaHighlights);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorGainHighlights_Offset), 0, null, ColorGainHighlights);
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, ColorOffsetHighlights_Offset), 0, null, ColorOffsetHighlights);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ColorCorrectionHighlightsMin_Offset), 0, null, ColorCorrectionHighlightsMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ColorCorrectionHighlightsMax_Offset), 0, null, ColorCorrectionHighlightsMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ColorCorrectionShadowsMax_Offset), 0, null, ColorCorrectionShadowsMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlueCorrection_Offset), 0, null, BlueCorrection);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ExpandGamut_Offset), 0, null, ExpandGamut);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ToneCurveAmount_Offset), 0, null, ToneCurveAmount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmSlope_Offset), 0, null, FilmSlope);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmToe_Offset), 0, null, FilmToe);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmShoulder_Offset), 0, null, FilmShoulder);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmBlackClip_Offset), 0, null, FilmBlackClip);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmWhiteClip_Offset), 0, null, FilmWhiteClip);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, SceneColorTint_Offset), 0, null, SceneColorTint);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SceneFringeIntensity_Offset), 0, null, SceneFringeIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ChromaticAberrationStartOffset_Offset), 0, null, ChromaticAberrationStartOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomIntensity_Offset), 0, null, BloomIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomThreshold_Offset), 0, null, BloomThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomSizeScale_Offset), 0, null, BloomSizeScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bloom1Size_Offset), 0, null, Bloom1Size);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bloom2Size_Offset), 0, null, Bloom2Size);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bloom3Size_Offset), 0, null, Bloom3Size);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bloom4Size_Offset), 0, null, Bloom4Size);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bloom5Size_Offset), 0, null, Bloom5Size);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bloom6Size_Offset), 0, null, Bloom6Size);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Bloom1Tint_Offset), 0, null, Bloom1Tint);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Bloom2Tint_Offset), 0, null, Bloom2Tint);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Bloom3Tint_Offset), 0, null, Bloom3Tint);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Bloom4Tint_Offset), 0, null, Bloom4Tint);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Bloom5Tint_Offset), 0, null, Bloom5Tint);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Bloom6Tint_Offset), 0, null, Bloom6Tint);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomConvolutionScatterDispersion_Offset), 0, null, BloomConvolutionScatterDispersion);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomConvolutionSize_Offset), 0, null, BloomConvolutionSize);
            ObjectMarshaller<UnrealSharp.Engine.Texture2D>.ToNative(IntPtr.Add(Buffer, BloomConvolutionTexture_Offset), 0, null, BloomConvolutionTexture);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, BloomConvolutionCenterUV_Offset), 0, null, BloomConvolutionCenterUV);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomConvolutionPreFilterMin_Offset), 0, null, BloomConvolutionPreFilterMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomConvolutionPreFilterMax_Offset), 0, null, BloomConvolutionPreFilterMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomConvolutionPreFilterMult_Offset), 0, null, BloomConvolutionPreFilterMult);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomConvolutionBufferScale_Offset), 0, null, BloomConvolutionBufferScale);
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(Buffer, BloomDirtMask_Offset), 0, null, BloomDirtMask);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BloomDirtMaskIntensity_Offset), 0, null, BloomDirtMaskIntensity);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, BloomDirtMaskTint_Offset), 0, null, BloomDirtMaskTint);
            BlittableMarshaller<UnrealSharp.Engine.EDynamicGlobalIlluminationMethod>.ToNative(IntPtr.Add(Buffer, DynamicGlobalIlluminationMethod_Offset), 0, null, DynamicGlobalIlluminationMethod);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, IndirectLightingColor_Offset), 0, null, IndirectLightingColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, IndirectLightingIntensity_Offset), 0, null, IndirectLightingIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenSceneLightingQuality_Offset), 0, null, LumenSceneLightingQuality);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenSceneDetail_Offset), 0, null, LumenSceneDetail);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenSceneViewDistance_Offset), 0, null, LumenSceneViewDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenSceneLightingUpdateSpeed_Offset), 0, null, LumenSceneLightingUpdateSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenFinalGatherQuality_Offset), 0, null, LumenFinalGatherQuality);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenFinalGatherLightingUpdateSpeed_Offset), 0, null, LumenFinalGatherLightingUpdateSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenMaxTraceDistance_Offset), 0, null, LumenMaxTraceDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenDiffuseColorBoost_Offset), 0, null, LumenDiffuseColorBoost);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenSkylightLeaking_Offset), 0, null, LumenSkylightLeaking);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenFullSkylightLeakingDistance_Offset), 0, null, LumenFullSkylightLeakingDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenSurfaceCacheResolution_Offset), 0, null, LumenSurfaceCacheResolution);
            BlittableMarshaller<UnrealSharp.Engine.ERayTracingGlobalIlluminationType>.ToNative(IntPtr.Add(Buffer, RayTracingGIType_Offset), 0, null, RayTracingGIType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RayTracingGIMaxBounces_Offset), 0, null, RayTracingGIMaxBounces);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RayTracingGISamplesPerPixel_Offset), 0, null, RayTracingGISamplesPerPixel);
            BlittableMarshaller<UnrealSharp.Engine.EReflectionMethod>.ToNative(IntPtr.Add(Buffer, ReflectionMethod_Offset), 0, null, ReflectionMethod);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LumenReflectionQuality_Offset), 0, null, LumenReflectionQuality);
            BlittableMarshaller<UnrealSharp.Engine.ELumenRayLightingModeOverride>.ToNative(IntPtr.Add(Buffer, LumenRayLightingMode_Offset), 0, null, LumenRayLightingMode);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, LumenFrontLayerTranslucencyReflections_NativeProperty, LumenFrontLayerTranslucencyReflections_Offset, LumenFrontLayerTranslucencyReflections);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, LumenMaxReflectionBounces_Offset), 0, null, LumenMaxReflectionBounces);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScreenSpaceReflectionIntensity_Offset), 0, null, ScreenSpaceReflectionIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScreenSpaceReflectionQuality_Offset), 0, null, ScreenSpaceReflectionQuality);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScreenSpaceReflectionMaxRoughness_Offset), 0, null, ScreenSpaceReflectionMaxRoughness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RayTracingReflectionsMaxRoughness_Offset), 0, null, RayTracingReflectionsMaxRoughness);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RayTracingReflectionsMaxBounces_Offset), 0, null, RayTracingReflectionsMaxBounces);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RayTracingReflectionsSamplesPerPixel_Offset), 0, null, RayTracingReflectionsSamplesPerPixel);
            BlittableMarshaller<UnrealSharp.Engine.EReflectedAndRefractedRayTracedShadows>.ToNative(IntPtr.Add(Buffer, RayTracingReflectionsShadows_Offset), 0, null, RayTracingReflectionsShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, RayTracingReflectionsTranslucency_NativeProperty, RayTracingReflectionsTranslucency_Offset, RayTracingReflectionsTranslucency);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, AmbientCubemapTint_Offset), 0, null, AmbientCubemapTint);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientCubemapIntensity_Offset), 0, null, AmbientCubemapIntensity);
            ObjectMarshaller<UnrealSharp.Engine.TextureCube>.ToNative(IntPtr.Add(Buffer, AmbientCubemap_Offset), 0, null, AmbientCubemap);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CameraShutterSpeed_Offset), 0, null, CameraShutterSpeed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CameraISO_Offset), 0, null, CameraISO);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldFstop_Offset), 0, null, DepthOfFieldFstop);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldMinFstop_Offset), 0, null, DepthOfFieldMinFstop);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, DepthOfFieldBladeCount_Offset), 0, null, DepthOfFieldBladeCount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AutoExposureBias_Offset), 0, null, AutoExposureBias);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, AutoExposureApplyPhysicalCameraExposure_NativeProperty, AutoExposureApplyPhysicalCameraExposure_Offset, AutoExposureApplyPhysicalCameraExposure);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, AutoExposureBiasCurve_Offset), 0, null, AutoExposureBiasCurve);
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(Buffer, AutoExposureMeterMask_Offset), 0, null, AutoExposureMeterMask);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AutoExposureLowPercent_Offset), 0, null, AutoExposureLowPercent);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AutoExposureHighPercent_Offset), 0, null, AutoExposureHighPercent);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AutoExposureMinBrightness_Offset), 0, null, AutoExposureMinBrightness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AutoExposureMaxBrightness_Offset), 0, null, AutoExposureMaxBrightness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AutoExposureSpeedUp_Offset), 0, null, AutoExposureSpeedUp);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AutoExposureSpeedDown_Offset), 0, null, AutoExposureSpeedDown);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HistogramLogMin_Offset), 0, null, HistogramLogMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HistogramLogMax_Offset), 0, null, HistogramLogMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LocalExposureHighlightContrastScale_Offset), 0, null, LocalExposureHighlightContrastScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LocalExposureShadowContrastScale_Offset), 0, null, LocalExposureShadowContrastScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LocalExposureDetailStrength_Offset), 0, null, LocalExposureDetailStrength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LocalExposureBlurredLuminanceBlend_Offset), 0, null, LocalExposureBlurredLuminanceBlend);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LocalExposureBlurredLuminanceKernelSizePercent_Offset), 0, null, LocalExposureBlurredLuminanceKernelSizePercent);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LocalExposureMiddleGreyBias_Offset), 0, null, LocalExposureMiddleGreyBias);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LensFlareIntensity_Offset), 0, null, LensFlareIntensity);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, LensFlareTint_Offset), 0, null, LensFlareTint);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LensFlareBokehSize_Offset), 0, null, LensFlareBokehSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LensFlareThreshold_Offset), 0, null, LensFlareThreshold);
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(Buffer, LensFlareBokehShape_Offset), 0, null, LensFlareBokehShape);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VignetteIntensity_Offset), 0, null, VignetteIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Sharpen_Offset), 0, null, Sharpen);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmGrainIntensity_Offset), 0, null, FilmGrainIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmGrainIntensityShadows_Offset), 0, null, FilmGrainIntensityShadows);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmGrainIntensityMidtones_Offset), 0, null, FilmGrainIntensityMidtones);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmGrainIntensityHighlights_Offset), 0, null, FilmGrainIntensityHighlights);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmGrainShadowsMax_Offset), 0, null, FilmGrainShadowsMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmGrainHighlightsMin_Offset), 0, null, FilmGrainHighlightsMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmGrainHighlightsMax_Offset), 0, null, FilmGrainHighlightsMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilmGrainTexelSize_Offset), 0, null, FilmGrainTexelSize);
            ObjectMarshaller<UnrealSharp.Engine.Texture2D>.ToNative(IntPtr.Add(Buffer, FilmGrainTexture_Offset), 0, null, FilmGrainTexture);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionIntensity_Offset), 0, null, AmbientOcclusionIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionStaticFraction_Offset), 0, null, AmbientOcclusionStaticFraction);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionRadius_Offset), 0, null, AmbientOcclusionRadius);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, AmbientOcclusionRadiusInWS_NativeProperty, AmbientOcclusionRadiusInWS_Offset, AmbientOcclusionRadiusInWS);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionFadeDistance_Offset), 0, null, AmbientOcclusionFadeDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionFadeRadius_Offset), 0, null, AmbientOcclusionFadeRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionPower_Offset), 0, null, AmbientOcclusionPower);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionBias_Offset), 0, null, AmbientOcclusionBias);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionQuality_Offset), 0, null, AmbientOcclusionQuality);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionMipBlend_Offset), 0, null, AmbientOcclusionMipBlend);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionMipScale_Offset), 0, null, AmbientOcclusionMipScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionMipThreshold_Offset), 0, null, AmbientOcclusionMipThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AmbientOcclusionTemporalBlendWeight_Offset), 0, null, AmbientOcclusionTemporalBlendWeight);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, RayTracingAO_NativeProperty, RayTracingAO_Offset, RayTracingAO);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RayTracingAOSamplesPerPixel_Offset), 0, null, RayTracingAOSamplesPerPixel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RayTracingAOIntensity_Offset), 0, null, RayTracingAOIntensity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RayTracingAORadius_Offset), 0, null, RayTracingAORadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ColorGradingIntensity_Offset), 0, null, ColorGradingIntensity);
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(Buffer, ColorGradingLUT_Offset), 0, null, ColorGradingLUT);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldSensorWidth_Offset), 0, null, DepthOfFieldSensorWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldSqueezeFactor_Offset), 0, null, DepthOfFieldSqueezeFactor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldFocalDistance_Offset), 0, null, DepthOfFieldFocalDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldDepthBlurAmount_Offset), 0, null, DepthOfFieldDepthBlurAmount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldDepthBlurRadius_Offset), 0, null, DepthOfFieldDepthBlurRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldFocalRegion_Offset), 0, null, DepthOfFieldFocalRegion);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldNearTransitionRegion_Offset), 0, null, DepthOfFieldNearTransitionRegion);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldFarTransitionRegion_Offset), 0, null, DepthOfFieldFarTransitionRegion);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldScale_Offset), 0, null, DepthOfFieldScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldNearBlurSize_Offset), 0, null, DepthOfFieldNearBlurSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldFarBlurSize_Offset), 0, null, DepthOfFieldFarBlurSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldOcclusion_Offset), 0, null, DepthOfFieldOcclusion);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldSkyFocusDistance_Offset), 0, null, DepthOfFieldSkyFocusDistance);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DepthOfFieldVignetteSize_Offset), 0, null, DepthOfFieldVignetteSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MotionBlurAmount_Offset), 0, null, MotionBlurAmount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MotionBlurMax_Offset), 0, null, MotionBlurMax);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MotionBlurTargetFPS_Offset), 0, null, MotionBlurTargetFPS);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MotionBlurPerObjectSize_Offset), 0, null, MotionBlurPerObjectSize);
            BlittableMarshaller<UnrealSharp.Engine.ETranslucencyType>.ToNative(IntPtr.Add(Buffer, TranslucencyType_Offset), 0, null, TranslucencyType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RayTracingTranslucencyMaxRoughness_Offset), 0, null, RayTracingTranslucencyMaxRoughness);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RayTracingTranslucencyRefractionRays_Offset), 0, null, RayTracingTranslucencyRefractionRays);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, RayTracingTranslucencySamplesPerPixel_Offset), 0, null, RayTracingTranslucencySamplesPerPixel);
            BlittableMarshaller<UnrealSharp.Engine.EReflectedAndRefractedRayTracedShadows>.ToNative(IntPtr.Add(Buffer, RayTracingTranslucencyShadows_Offset), 0, null, RayTracingTranslucencyShadows);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, RayTracingTranslucencyRefraction_NativeProperty, RayTracingTranslucencyRefraction_Offset, RayTracingTranslucencyRefraction);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PathTracingMaxBounces_Offset), 0, null, PathTracingMaxBounces);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PathTracingSamplesPerPixel_Offset), 0, null, PathTracingSamplesPerPixel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PathTracingMaxPathExposure_Offset), 0, null, PathTracingMaxPathExposure);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingEnableReferenceDOF_NativeProperty, PathTracingEnableReferenceDOF_Offset, PathTracingEnableReferenceDOF);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingEnableReferenceAtmosphere_NativeProperty, PathTracingEnableReferenceAtmosphere_Offset, PathTracingEnableReferenceAtmosphere);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingEnableDenoiser_NativeProperty, PathTracingEnableDenoiser_Offset, PathTracingEnableDenoiser);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingIncludeEmissive_NativeProperty, PathTracingIncludeEmissive_Offset, PathTracingIncludeEmissive);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingIncludeIndirectEmissive_NativeProperty, PathTracingIncludeIndirectEmissive_Offset, PathTracingIncludeIndirectEmissive);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingIncludeDiffuse_NativeProperty, PathTracingIncludeDiffuse_Offset, PathTracingIncludeDiffuse);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingIncludeIndirectDiffuse_NativeProperty, PathTracingIncludeIndirectDiffuse_Offset, PathTracingIncludeIndirectDiffuse);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingIncludeSpecular_NativeProperty, PathTracingIncludeSpecular_Offset, PathTracingIncludeSpecular);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingIncludeIndirectSpecular_NativeProperty, PathTracingIncludeIndirectSpecular_Offset, PathTracingIncludeIndirectSpecular);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingIncludeVolume_NativeProperty, PathTracingIncludeVolume_Offset, PathTracingIncludeVolume);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, PathTracingIncludeIndirectVolume_NativeProperty, PathTracingIncludeIndirectVolume_Offset, PathTracingIncludeIndirectVolume);
            UnrealSharp.Engine.WeightedBlendablesMarshaler.ToNative(IntPtr.Add(Buffer, WeightedBlendables_Offset), 0, null, WeightedBlendables);
        }
    }
}

public static class PostProcessSettingsMarshaler
{
    public static PostProcessSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PostProcessSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PostProcessSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PostProcessSettings.NativeDataSize;
    }
}