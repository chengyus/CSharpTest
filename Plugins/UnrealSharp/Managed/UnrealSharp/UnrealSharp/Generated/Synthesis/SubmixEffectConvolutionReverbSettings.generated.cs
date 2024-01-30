using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SubmixEffectConvolutionReverbSettings
{
    // FloatProperty /Script/Synthesis.SubmixEffectConvolutionReverbSettings:WetVolumeDb
    static readonly int WetVolumeDb_Offset;
    public float WetVolumeDb;
    
    // FloatProperty /Script/Synthesis.SubmixEffectConvolutionReverbSettings:DryVolumeDb
    static readonly int DryVolumeDb_Offset;
    public float DryVolumeDb;
    
    // BoolProperty /Script/Synthesis.SubmixEffectConvolutionReverbSettings:bBypass
    static readonly int bBypass_Offset;
    public bool Bypass;
    
    // BoolProperty /Script/Synthesis.SubmixEffectConvolutionReverbSettings:bMixInputChannelFormatToImpulseResponseFormat
    static readonly int bMixInputChannelFormatToImpulseResponseFormat_Offset;
    public bool MixInputChannelFormatToImpulseResponseFormat;
    
    // BoolProperty /Script/Synthesis.SubmixEffectConvolutionReverbSettings:bMixReverbOutputToOutputChannelFormat
    static readonly int bMixReverbOutputToOutputChannelFormat_Offset;
    public bool MixReverbOutputToOutputChannelFormat;
    
    // FloatProperty /Script/Synthesis.SubmixEffectConvolutionReverbSettings:SurroundRearChannelBleedDb
    static readonly int SurroundRearChannelBleedDb_Offset;
    public float SurroundRearChannelBleedDb;
    
    // BoolProperty /Script/Synthesis.SubmixEffectConvolutionReverbSettings:bInvertRearChannelBleedPhase
    static readonly int bInvertRearChannelBleedPhase_Offset;
    public bool InvertRearChannelBleedPhase;
    
    // BoolProperty /Script/Synthesis.SubmixEffectConvolutionReverbSettings:bSurroundRearChannelFlip
    static readonly int bSurroundRearChannelFlip_Offset;
    public bool SurroundRearChannelFlip;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectConvolutionReverbSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectConvolutionReverbSettings");
        
        WetVolumeDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetVolumeDb");
        DryVolumeDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryVolumeDb");
        bBypass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBypass");
        bMixInputChannelFormatToImpulseResponseFormat_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMixInputChannelFormatToImpulseResponseFormat");
        bMixReverbOutputToOutputChannelFormat_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMixReverbOutputToOutputChannelFormat");
        SurroundRearChannelBleedDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SurroundRearChannelBleedDb");
        bInvertRearChannelBleedPhase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInvertRearChannelBleedPhase");
        bSurroundRearChannelFlip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSurroundRearChannelFlip");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectConvolutionReverbSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            WetVolumeDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WetVolumeDb_Offset), 0, null);
            DryVolumeDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DryVolumeDb_Offset), 0, null);
            Bypass = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bBypass_Offset), 0, null);
            MixInputChannelFormatToImpulseResponseFormat = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMixInputChannelFormatToImpulseResponseFormat_Offset), 0, null);
            MixReverbOutputToOutputChannelFormat = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMixReverbOutputToOutputChannelFormat_Offset), 0, null);
            SurroundRearChannelBleedDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SurroundRearChannelBleedDb_Offset), 0, null);
            InvertRearChannelBleedPhase = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bInvertRearChannelBleedPhase_Offset), 0, null);
            SurroundRearChannelFlip = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSurroundRearChannelFlip_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WetVolumeDb_Offset), 0, null, WetVolumeDb);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DryVolumeDb_Offset), 0, null, DryVolumeDb);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bBypass_Offset), 0, null, Bypass);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMixInputChannelFormatToImpulseResponseFormat_Offset), 0, null, MixInputChannelFormatToImpulseResponseFormat);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMixReverbOutputToOutputChannelFormat_Offset), 0, null, MixReverbOutputToOutputChannelFormat);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SurroundRearChannelBleedDb_Offset), 0, null, SurroundRearChannelBleedDb);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bInvertRearChannelBleedPhase_Offset), 0, null, InvertRearChannelBleedPhase);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSurroundRearChannelFlip_Offset), 0, null, SurroundRearChannelFlip);
        }
    }
}

public static class SubmixEffectConvolutionReverbSettingsMarshaler
{
    public static SubmixEffectConvolutionReverbSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectConvolutionReverbSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectConvolutionReverbSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectConvolutionReverbSettings.NativeDataSize;
    }
}