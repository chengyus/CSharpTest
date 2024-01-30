using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectBitCrusherSettings
{
    // StructProperty /Script/Synthesis.SourceEffectBitCrusherSettings:SampleRateModulation
    static readonly int SampleRateModulation_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings SampleRateModulation;
    
    // StructProperty /Script/Synthesis.SourceEffectBitCrusherSettings:BitModulation
    static readonly int BitModulation_Offset;
    public UnrealSharp.Engine.SoundModulationDestinationSettings BitModulation;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectBitCrusherSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectBitCrusherSettings");
        
        SampleRateModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SampleRateModulation");
        BitModulation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BitModulation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectBitCrusherSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            SampleRateModulation = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, SampleRateModulation_Offset), 0, null);
            BitModulation = UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, BitModulation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, SampleRateModulation_Offset), 0, null, SampleRateModulation);
            UnrealSharp.Engine.SoundModulationDestinationSettingsMarshaler.ToNative(IntPtr.Add(Buffer, BitModulation_Offset), 0, null, BitModulation);
        }
    }
}

public static class SourceEffectBitCrusherSettingsMarshaler
{
    public static SourceEffectBitCrusherSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectBitCrusherSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectBitCrusherSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectBitCrusherSettings.NativeDataSize;
    }
}