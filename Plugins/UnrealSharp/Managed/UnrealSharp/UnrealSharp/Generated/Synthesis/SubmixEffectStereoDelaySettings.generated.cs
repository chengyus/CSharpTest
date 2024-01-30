using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SubmixEffectStereoDelaySettings
{
    // EnumProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:DelayMode
    static readonly int DelayMode_Offset;
    public UnrealSharp.Synthesis.EStereoDelaySourceEffect DelayMode;
    
    // FloatProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:DelayTimeMsec
    static readonly int DelayTimeMsec_Offset;
    public float DelayTimeMsec;
    
    // FloatProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:Feedback
    static readonly int Feedback_Offset;
    public float Feedback;
    
    // FloatProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:DelayRatio
    static readonly int DelayRatio_Offset;
    public float DelayRatio;
    
    // FloatProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:WetLevel
    static readonly int WetLevel_Offset;
    public float WetLevel;
    
    // FloatProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:DryLevel
    static readonly int DryLevel_Offset;
    public float DryLevel;
    
    // BoolProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:bFilterEnabled
    static readonly int bFilterEnabled_Offset;
    public bool FilterEnabled;
    
    // EnumProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:FilterType
    static readonly int FilterType_Offset;
    public UnrealSharp.Synthesis.EStereoDelayFiltertype FilterType;
    
    // FloatProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:FilterFrequency
    static readonly int FilterFrequency_Offset;
    public float FilterFrequency;
    
    // FloatProperty /Script/Synthesis.SubmixEffectStereoDelaySettings:FilterQ
    static readonly int FilterQ_Offset;
    public float FilterQ;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectStereoDelaySettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectStereoDelaySettings");
        
        DelayMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DelayMode");
        DelayTimeMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DelayTimeMsec");
        Feedback_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Feedback");
        DelayRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DelayRatio");
        WetLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetLevel");
        DryLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryLevel");
        bFilterEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFilterEnabled");
        FilterType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterType");
        FilterFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterFrequency");
        FilterQ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilterQ");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectStereoDelaySettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DelayMode = BlittableMarshaller<UnrealSharp.Synthesis.EStereoDelaySourceEffect>.FromNative(IntPtr.Add(InNativeStruct, DelayMode_Offset), 0, null);
            DelayTimeMsec = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DelayTimeMsec_Offset), 0, null);
            Feedback = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Feedback_Offset), 0, null);
            DelayRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DelayRatio_Offset), 0, null);
            WetLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WetLevel_Offset), 0, null);
            DryLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DryLevel_Offset), 0, null);
            FilterEnabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFilterEnabled_Offset), 0, null);
            FilterType = BlittableMarshaller<UnrealSharp.Synthesis.EStereoDelayFiltertype>.FromNative(IntPtr.Add(InNativeStruct, FilterType_Offset), 0, null);
            FilterFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilterFrequency_Offset), 0, null);
            FilterQ = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FilterQ_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.EStereoDelaySourceEffect>.ToNative(IntPtr.Add(Buffer, DelayMode_Offset), 0, null, DelayMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DelayTimeMsec_Offset), 0, null, DelayTimeMsec);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Feedback_Offset), 0, null, Feedback);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DelayRatio_Offset), 0, null, DelayRatio);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WetLevel_Offset), 0, null, WetLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DryLevel_Offset), 0, null, DryLevel);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFilterEnabled_Offset), 0, null, FilterEnabled);
            BlittableMarshaller<UnrealSharp.Synthesis.EStereoDelayFiltertype>.ToNative(IntPtr.Add(Buffer, FilterType_Offset), 0, null, FilterType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilterFrequency_Offset), 0, null, FilterFrequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FilterQ_Offset), 0, null, FilterQ);
        }
    }
}

public static class SubmixEffectStereoDelaySettingsMarshaler
{
    public static SubmixEffectStereoDelaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectStereoDelaySettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectStereoDelaySettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectStereoDelaySettings.NativeDataSize;
    }
}