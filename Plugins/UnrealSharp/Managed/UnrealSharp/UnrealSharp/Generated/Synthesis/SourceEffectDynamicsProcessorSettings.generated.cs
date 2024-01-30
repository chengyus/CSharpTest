using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectDynamicsProcessorSettings
{
    // EnumProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:DynamicsProcessorType
    static readonly int DynamicsProcessorType_Offset;
    public UnrealSharp.Synthesis.ESourceEffectDynamicsProcessorType DynamicsProcessorType;
    
    // EnumProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:PeakMode
    static readonly int PeakMode_Offset;
    public UnrealSharp.Synthesis.ESourceEffectDynamicsPeakMode PeakMode;
    
    // FloatProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:LookAheadMsec
    static readonly int LookAheadMsec_Offset;
    public float LookAheadMsec;
    
    // FloatProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:AttackTimeMsec
    static readonly int AttackTimeMsec_Offset;
    public float AttackTimeMsec;
    
    // FloatProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:ReleaseTimeMsec
    static readonly int ReleaseTimeMsec_Offset;
    public float ReleaseTimeMsec;
    
    // FloatProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:ThresholdDb
    static readonly int ThresholdDb_Offset;
    public float ThresholdDb;
    
    // FloatProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:Ratio
    static readonly int Ratio_Offset;
    public float Ratio;
    
    // FloatProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:KneeBandwidthDb
    static readonly int KneeBandwidthDb_Offset;
    public float KneeBandwidthDb;
    
    // FloatProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:InputGainDb
    static readonly int InputGainDb_Offset;
    public float InputGainDb;
    
    // FloatProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:OutputGainDb
    static readonly int OutputGainDb_Offset;
    public float OutputGainDb;
    
    // BoolProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:bStereoLinked
    static readonly int bStereoLinked_Offset;
    static readonly IntPtr bStereoLinked_NativeProperty;
    public bool StereoLinked;
    
    // BoolProperty /Script/Synthesis.SourceEffectDynamicsProcessorSettings:bAnalogMode
    static readonly int bAnalogMode_Offset;
    static readonly IntPtr bAnalogMode_NativeProperty;
    public bool AnalogMode;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectDynamicsProcessorSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectDynamicsProcessorSettings");
        
        DynamicsProcessorType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DynamicsProcessorType");
        PeakMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PeakMode");
        LookAheadMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LookAheadMsec");
        AttackTimeMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttackTimeMsec");
        ReleaseTimeMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReleaseTimeMsec");
        ThresholdDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ThresholdDb");
        Ratio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Ratio");
        KneeBandwidthDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KneeBandwidthDb");
        InputGainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InputGainDb");
        OutputGainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutputGainDb");
        bStereoLinked_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bStereoLinked");
        bStereoLinked_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bStereoLinked");
        bAnalogMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAnalogMode");
        bAnalogMode_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAnalogMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectDynamicsProcessorSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DynamicsProcessorType = BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectDynamicsProcessorType>.FromNative(IntPtr.Add(InNativeStruct, DynamicsProcessorType_Offset), 0, null);
            PeakMode = BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectDynamicsPeakMode>.FromNative(IntPtr.Add(InNativeStruct, PeakMode_Offset), 0, null);
            LookAheadMsec = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LookAheadMsec_Offset), 0, null);
            AttackTimeMsec = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AttackTimeMsec_Offset), 0, null);
            ReleaseTimeMsec = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReleaseTimeMsec_Offset), 0, null);
            ThresholdDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ThresholdDb_Offset), 0, null);
            Ratio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Ratio_Offset), 0, null);
            KneeBandwidthDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, KneeBandwidthDb_Offset), 0, null);
            InputGainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InputGainDb_Offset), 0, null);
            OutputGainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, OutputGainDb_Offset), 0, null);
            StereoLinked = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bStereoLinked_NativeProperty, bStereoLinked_Offset);
            AnalogMode = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAnalogMode_NativeProperty, bAnalogMode_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectDynamicsProcessorType>.ToNative(IntPtr.Add(Buffer, DynamicsProcessorType_Offset), 0, null, DynamicsProcessorType);
            BlittableMarshaller<UnrealSharp.Synthesis.ESourceEffectDynamicsPeakMode>.ToNative(IntPtr.Add(Buffer, PeakMode_Offset), 0, null, PeakMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LookAheadMsec_Offset), 0, null, LookAheadMsec);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AttackTimeMsec_Offset), 0, null, AttackTimeMsec);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReleaseTimeMsec_Offset), 0, null, ReleaseTimeMsec);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ThresholdDb_Offset), 0, null, ThresholdDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Ratio_Offset), 0, null, Ratio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, KneeBandwidthDb_Offset), 0, null, KneeBandwidthDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InputGainDb_Offset), 0, null, InputGainDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, OutputGainDb_Offset), 0, null, OutputGainDb);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bStereoLinked_NativeProperty, bStereoLinked_Offset, StereoLinked);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAnalogMode_NativeProperty, bAnalogMode_Offset, AnalogMode);
        }
    }
}

public static class SourceEffectDynamicsProcessorSettingsMarshaler
{
    public static SourceEffectDynamicsProcessorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectDynamicsProcessorSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectDynamicsProcessorSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectDynamicsProcessorSettings.NativeDataSize;
    }
}