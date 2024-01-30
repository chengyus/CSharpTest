using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectRingModulationSettings
{
    // EnumProperty /Script/Synthesis.SourceEffectRingModulationSettings:ModulatorType
    static readonly int ModulatorType_Offset;
    public UnrealSharp.Synthesis.ERingModulatorTypeSourceEffect ModulatorType;
    
    // FloatProperty /Script/Synthesis.SourceEffectRingModulationSettings:Frequency
    static readonly int Frequency_Offset;
    public float Frequency;
    
    // FloatProperty /Script/Synthesis.SourceEffectRingModulationSettings:Depth
    static readonly int Depth_Offset;
    public float Depth;
    
    // FloatProperty /Script/Synthesis.SourceEffectRingModulationSettings:DryLevel
    static readonly int DryLevel_Offset;
    public float DryLevel;
    
    // FloatProperty /Script/Synthesis.SourceEffectRingModulationSettings:WetLevel
    static readonly int WetLevel_Offset;
    public float WetLevel;
    
    // ObjectProperty /Script/Synthesis.SourceEffectRingModulationSettings:AudioBusModulator
    static readonly int AudioBusModulator_Offset;
    public UnrealSharp.Engine.AudioBus AudioBusModulator;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectRingModulationSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectRingModulationSettings");
        
        ModulatorType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ModulatorType");
        Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frequency");
        Depth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Depth");
        DryLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryLevel");
        WetLevel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetLevel");
        AudioBusModulator_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AudioBusModulator");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectRingModulationSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ModulatorType = BlittableMarshaller<UnrealSharp.Synthesis.ERingModulatorTypeSourceEffect>.FromNative(IntPtr.Add(InNativeStruct, ModulatorType_Offset), 0, null);
            Frequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Frequency_Offset), 0, null);
            Depth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Depth_Offset), 0, null);
            DryLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DryLevel_Offset), 0, null);
            WetLevel = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WetLevel_Offset), 0, null);
            AudioBusModulator = ObjectMarshaller<UnrealSharp.Engine.AudioBus>.FromNative(IntPtr.Add(InNativeStruct, AudioBusModulator_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Synthesis.ERingModulatorTypeSourceEffect>.ToNative(IntPtr.Add(Buffer, ModulatorType_Offset), 0, null, ModulatorType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Frequency_Offset), 0, null, Frequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Depth_Offset), 0, null, Depth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DryLevel_Offset), 0, null, DryLevel);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WetLevel_Offset), 0, null, WetLevel);
            ObjectMarshaller<UnrealSharp.Engine.AudioBus>.ToNative(IntPtr.Add(Buffer, AudioBusModulator_Offset), 0, null, AudioBusModulator);
        }
    }
}

public static class SourceEffectRingModulationSettingsMarshaler
{
    public static SourceEffectRingModulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectRingModulationSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectRingModulationSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectRingModulationSettings.NativeDataSize;
    }
}