using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SubmixEffectMultibandCompressorSettings
{
    // EnumProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:DynamicsProcessorType
    static readonly int DynamicsProcessorType_Offset;
    public UnrealSharp.AudioMixer.ESubmixEffectDynamicsProcessorType DynamicsProcessorType;
    
    // EnumProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:PeakMode
    static readonly int PeakMode_Offset;
    public UnrealSharp.AudioMixer.ESubmixEffectDynamicsPeakMode PeakMode;
    
    // EnumProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:LinkMode
    static readonly int LinkMode_Offset;
    public UnrealSharp.AudioMixer.ESubmixEffectDynamicsChannelLinkMode LinkMode;
    
    // FloatProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:LookAheadMsec
    static readonly int LookAheadMsec_Offset;
    public float LookAheadMsec;
    
    // BoolProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:bAnalogMode
    static readonly int bAnalogMode_Offset;
    public bool AnalogMode;
    
    // BoolProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:bFourPole
    static readonly int bFourPole_Offset;
    public bool FourPole;
    
    // BoolProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:bBypass
    static readonly int bBypass_Offset;
    public bool Bypass;
    
    // EnumProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:KeySource
    static readonly int KeySource_Offset;
    public UnrealSharp.AudioMixer.ESubmixEffectDynamicsKeySource KeySource;
    
    // ObjectProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:ExternalAudioBus
    static readonly int ExternalAudioBus_Offset;
    public UnrealSharp.Engine.AudioBus ExternalAudioBus;
    
    // ObjectProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:ExternalSubmix
    static readonly int ExternalSubmix_Offset;
    public UnrealSharp.Engine.SoundSubmix ExternalSubmix;
    
    // FloatProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:KeyGainDb
    static readonly int KeyGainDb_Offset;
    public float KeyGainDb;
    
    // BoolProperty /Script/Synthesis.SubmixEffectMultibandCompressorSettings:bKeyAudition
    static readonly int bKeyAudition_Offset;
    public bool KeyAudition;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectMultibandCompressorSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectMultibandCompressorSettings");
        
        DynamicsProcessorType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DynamicsProcessorType");
        PeakMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PeakMode");
        LinkMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LinkMode");
        LookAheadMsec_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LookAheadMsec");
        bAnalogMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAnalogMode");
        bFourPole_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFourPole");
        bBypass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypass");
        KeySource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeySource");
        ExternalAudioBus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExternalAudioBus");
        ExternalSubmix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExternalSubmix");
        KeyGainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeyGainDb");
        bKeyAudition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bKeyAudition");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectMultibandCompressorSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DynamicsProcessorType = BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsProcessorType>.FromNative(IntPtr.Add(InNativeStruct, DynamicsProcessorType_Offset), 0, null);
            PeakMode = BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsPeakMode>.FromNative(IntPtr.Add(InNativeStruct, PeakMode_Offset), 0, null);
            LinkMode = BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsChannelLinkMode>.FromNative(IntPtr.Add(InNativeStruct, LinkMode_Offset), 0, null);
            LookAheadMsec = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LookAheadMsec_Offset), 0, null);
            AnalogMode = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAnalogMode_Offset), 0, null);
            FourPole = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFourPole_Offset), 0, null);
            Bypass = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bBypass_Offset), 0, null);
            KeySource = BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsKeySource>.FromNative(IntPtr.Add(InNativeStruct, KeySource_Offset), 0, null);
            ExternalAudioBus = ObjectMarshaller<UnrealSharp.Engine.AudioBus>.FromNative(IntPtr.Add(InNativeStruct, ExternalAudioBus_Offset), 0, null);
            ExternalSubmix = ObjectMarshaller<UnrealSharp.Engine.SoundSubmix>.FromNative(IntPtr.Add(InNativeStruct, ExternalSubmix_Offset), 0, null);
            KeyGainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, KeyGainDb_Offset), 0, null);
            KeyAudition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bKeyAudition_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsProcessorType>.ToNative(IntPtr.Add(Buffer, DynamicsProcessorType_Offset), 0, null, DynamicsProcessorType);
            BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsPeakMode>.ToNative(IntPtr.Add(Buffer, PeakMode_Offset), 0, null, PeakMode);
            BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsChannelLinkMode>.ToNative(IntPtr.Add(Buffer, LinkMode_Offset), 0, null, LinkMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LookAheadMsec_Offset), 0, null, LookAheadMsec);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAnalogMode_Offset), 0, null, AnalogMode);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFourPole_Offset), 0, null, FourPole);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bBypass_Offset), 0, null, Bypass);
            BlittableMarshaller<UnrealSharp.AudioMixer.ESubmixEffectDynamicsKeySource>.ToNative(IntPtr.Add(Buffer, KeySource_Offset), 0, null, KeySource);
            ObjectMarshaller<UnrealSharp.Engine.AudioBus>.ToNative(IntPtr.Add(Buffer, ExternalAudioBus_Offset), 0, null, ExternalAudioBus);
            ObjectMarshaller<UnrealSharp.Engine.SoundSubmix>.ToNative(IntPtr.Add(Buffer, ExternalSubmix_Offset), 0, null, ExternalSubmix);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, KeyGainDb_Offset), 0, null, KeyGainDb);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bKeyAudition_Offset), 0, null, KeyAudition);
        }
    }
}

public static class SubmixEffectMultibandCompressorSettingsMarshaler
{
    public static SubmixEffectMultibandCompressorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectMultibandCompressorSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectMultibandCompressorSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectMultibandCompressorSettings.NativeDataSize;
    }
}