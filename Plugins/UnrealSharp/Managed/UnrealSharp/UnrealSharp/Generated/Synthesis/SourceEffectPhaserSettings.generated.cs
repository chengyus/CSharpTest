using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectPhaserSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectPhaserSettings:WetLevel
    static readonly int WetLevel_Offset;
    public float WetLevel;
    
    // FloatProperty /Script/Synthesis.SourceEffectPhaserSettings:Frequency
    static readonly int Frequency_Offset;
    public float Frequency;
    
    // FloatProperty /Script/Synthesis.SourceEffectPhaserSettings:Feedback
    static readonly int Feedback_Offset;
    public float Feedback;
    
    // EnumProperty /Script/Synthesis.SourceEffectPhaserSettings:LFOType
    static readonly int LFOType_Offset;
    public UnrealSharp.Synthesis.EPhaserLFOType LFOType;
    
    // BoolProperty /Script/Synthesis.SourceEffectPhaserSettings:UseQuadraturePhase
    static readonly int UseQuadraturePhase_Offset;
    public bool UseQuadraturePhase;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectPhaserSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectPhaserSettings");
        
        WetLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetLevel");
        Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frequency");
        Feedback_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Feedback");
        LFOType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LFOType");
        UseQuadraturePhase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UseQuadraturePhase");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectPhaserSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            WetLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WetLevel_Offset), 0, null);
            Frequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Frequency_Offset), 0, null);
            Feedback = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Feedback_Offset), 0, null);
            LFOType = BlittableMarshaller<UnrealSharp.Synthesis.EPhaserLFOType>.FromNative(IntPtr.Add(InNativeStruct, LFOType_Offset), 0, null);
            UseQuadraturePhase = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, UseQuadraturePhase_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WetLevel_Offset), 0, null, WetLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Frequency_Offset), 0, null, Frequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Feedback_Offset), 0, null, Feedback);
            BlittableMarshaller<UnrealSharp.Synthesis.EPhaserLFOType>.ToNative(IntPtr.Add(Buffer, LFOType_Offset), 0, null, LFOType);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, UseQuadraturePhase_Offset), 0, null, UseQuadraturePhase);
        }
    }
}

public static class SourceEffectPhaserSettingsMarshaler
{
    public static SourceEffectPhaserSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectPhaserSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectPhaserSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectPhaserSettings.NativeDataSize;
    }
}