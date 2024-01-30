using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectChorusSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectChorusSettings:Depth
    static readonly int Depth_Offset;
    public float Depth;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusSettings:Frequency
    static readonly int Frequency_Offset;
    public float Frequency;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusSettings:Feedback
    static readonly int Feedback_Offset;
    public float Feedback;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusSettings:WetLevel
    static readonly int WetLevel_Offset;
    public float WetLevel;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusSettings:DryLevel
    static readonly int DryLevel_Offset;
    public float DryLevel;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusSettings:Spread
    static readonly int Spread_Offset;
    public float Spread;
    
    // StructProperty /Script/Synthesis.SourceEffectChorusSettings:DepthModulation
    static readonly int DepthModulation_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings DepthModulation;
    
    // StructProperty /Script/Synthesis.SourceEffectChorusSettings:FrequencyModulation
    static readonly int FrequencyModulation_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings FrequencyModulation;
    
    // StructProperty /Script/Synthesis.SourceEffectChorusSettings:FeedbackModulation
    static readonly int FeedbackModulation_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings FeedbackModulation;
    
    // StructProperty /Script/Synthesis.SourceEffectChorusSettings:WetModulation
    static readonly int WetModulation_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings WetModulation;
    
    // StructProperty /Script/Synthesis.SourceEffectChorusSettings:DryModulation
    static readonly int DryModulation_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings DryModulation;
    
    // StructProperty /Script/Synthesis.SourceEffectChorusSettings:SpreadModulation
    static readonly int SpreadModulation_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings SpreadModulation;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectChorusSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectChorusSettings");
        
        Depth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Depth");
        Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frequency");
        Feedback_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Feedback");
        WetLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetLevel");
        DryLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryLevel");
        Spread_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spread");
        DepthModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DepthModulation");
        FrequencyModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FrequencyModulation");
        FeedbackModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FeedbackModulation");
        WetModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetModulation");
        DryModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryModulation");
        SpreadModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpreadModulation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectChorusSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Depth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Depth_Offset), 0, null);
            Frequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Frequency_Offset), 0, null);
            Feedback = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Feedback_Offset), 0, null);
            WetLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WetLevel_Offset), 0, null);
            DryLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DryLevel_Offset), 0, null);
            Spread = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Spread_Offset), 0, null);
            DepthModulation = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DepthModulation_Offset), 0, null);
            FrequencyModulation = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, FrequencyModulation_Offset), 0, null);
            FeedbackModulation = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, FeedbackModulation_Offset), 0, null);
            WetModulation = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, WetModulation_Offset), 0, null);
            DryModulation = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DryModulation_Offset), 0, null);
            SpreadModulation = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, SpreadModulation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Depth_Offset), 0, null, Depth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Frequency_Offset), 0, null, Frequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Feedback_Offset), 0, null, Feedback);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WetLevel_Offset), 0, null, WetLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DryLevel_Offset), 0, null, DryLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Spread_Offset), 0, null, Spread);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DepthModulation_Offset), 0, null, DepthModulation);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, FrequencyModulation_Offset), 0, null, FrequencyModulation);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, FeedbackModulation_Offset), 0, null, FeedbackModulation);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, WetModulation_Offset), 0, null, WetModulation);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DryModulation_Offset), 0, null, DryModulation);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, SpreadModulation_Offset), 0, null, SpreadModulation);
        }
    }
}

public static class SourceEffectChorusSettingsMarshaler
{
    public static SourceEffectChorusSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectChorusSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectChorusSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectChorusSettings.NativeDataSize;
    }
}