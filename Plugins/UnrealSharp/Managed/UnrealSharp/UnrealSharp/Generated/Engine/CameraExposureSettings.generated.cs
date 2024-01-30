using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CameraExposureSettings
{
    // ByteProperty /Script/Engine.CameraExposureSettings:Method
    static readonly int Method_Offset;
    public UnrealSharp.Engine.EAutoExposureMethod Method;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:LowPercent
    static readonly int LowPercent_Offset;
    public float LowPercent;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:HighPercent
    static readonly int HighPercent_Offset;
    public float HighPercent;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:MinBrightness
    static readonly int MinBrightness_Offset;
    public float MinBrightness;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:MaxBrightness
    static readonly int MaxBrightness_Offset;
    public float MaxBrightness;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:SpeedUp
    static readonly int SpeedUp_Offset;
    public float SpeedUp;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:SpeedDown
    static readonly int SpeedDown_Offset;
    public float SpeedDown;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:Bias
    static readonly int Bias_Offset;
    public float Bias;
    
    // ObjectProperty /Script/Engine.CameraExposureSettings:BiasCurve
    static readonly int BiasCurve_Offset;
    public UnrealSharp.Engine.CurveFloat BiasCurve;
    
    // ObjectProperty /Script/Engine.CameraExposureSettings:MeterMask
    static readonly int MeterMask_Offset;
    public UnrealSharp.Engine.Texture MeterMask;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:HistogramLogMin
    static readonly int HistogramLogMin_Offset;
    public float HistogramLogMin;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:HistogramLogMax
    static readonly int HistogramLogMax_Offset;
    public float HistogramLogMax;
    
    // FloatProperty /Script/Engine.CameraExposureSettings:CalibrationConstant
    static readonly int CalibrationConstant_Offset;
    public float CalibrationConstant;
    
    // BoolProperty /Script/Engine.CameraExposureSettings:ApplyPhysicalCameraExposure
    static readonly int ApplyPhysicalCameraExposure_Offset;
    static readonly IntPtr ApplyPhysicalCameraExposure_NativeProperty;
    public bool ApplyPhysicalCameraExposure;
    
    
    public static readonly int NativeDataSize;
    static CameraExposureSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CameraExposureSettings");
        
        Method_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Method");
        LowPercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowPercent");
        HighPercent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HighPercent");
        MinBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinBrightness");
        MaxBrightness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxBrightness");
        SpeedUp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpeedUp");
        SpeedDown_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpeedDown");
        Bias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bias");
        BiasCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BiasCurve");
        MeterMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeterMask");
        HistogramLogMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HistogramLogMin");
        HistogramLogMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HistogramLogMax");
        CalibrationConstant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CalibrationConstant");
        ApplyPhysicalCameraExposure_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ApplyPhysicalCameraExposure");
        ApplyPhysicalCameraExposure_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ApplyPhysicalCameraExposure");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CameraExposureSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Method = BlittableMarshaller<UnrealSharp.Engine.EAutoExposureMethod>.FromNative(IntPtr.Add(InNativeStruct, Method_Offset), 0, null);
            LowPercent = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LowPercent_Offset), 0, null);
            HighPercent = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HighPercent_Offset), 0, null);
            MinBrightness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinBrightness_Offset), 0, null);
            MaxBrightness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxBrightness_Offset), 0, null);
            SpeedUp = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SpeedUp_Offset), 0, null);
            SpeedDown = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SpeedDown_Offset), 0, null);
            Bias = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bias_Offset), 0, null);
            BiasCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, BiasCurve_Offset), 0, null);
            MeterMask = ObjectMarshaller<UnrealSharp.Engine.Texture>.FromNative(IntPtr.Add(InNativeStruct, MeterMask_Offset), 0, null);
            HistogramLogMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HistogramLogMin_Offset), 0, null);
            HistogramLogMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HistogramLogMax_Offset), 0, null);
            CalibrationConstant = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CalibrationConstant_Offset), 0, null);
            ApplyPhysicalCameraExposure = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, ApplyPhysicalCameraExposure_NativeProperty, ApplyPhysicalCameraExposure_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EAutoExposureMethod>.ToNative(IntPtr.Add(Buffer, Method_Offset), 0, null, Method);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LowPercent_Offset), 0, null, LowPercent);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HighPercent_Offset), 0, null, HighPercent);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinBrightness_Offset), 0, null, MinBrightness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxBrightness_Offset), 0, null, MaxBrightness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SpeedUp_Offset), 0, null, SpeedUp);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SpeedDown_Offset), 0, null, SpeedDown);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bias_Offset), 0, null, Bias);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, BiasCurve_Offset), 0, null, BiasCurve);
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(Buffer, MeterMask_Offset), 0, null, MeterMask);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HistogramLogMin_Offset), 0, null, HistogramLogMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HistogramLogMax_Offset), 0, null, HistogramLogMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CalibrationConstant_Offset), 0, null, CalibrationConstant);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, ApplyPhysicalCameraExposure_NativeProperty, ApplyPhysicalCameraExposure_Offset, ApplyPhysicalCameraExposure);
        }
    }
}

public static class CameraExposureSettingsMarshaler
{
    public static CameraExposureSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CameraExposureSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CameraExposureSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CameraExposureSettings.NativeDataSize;
    }
}