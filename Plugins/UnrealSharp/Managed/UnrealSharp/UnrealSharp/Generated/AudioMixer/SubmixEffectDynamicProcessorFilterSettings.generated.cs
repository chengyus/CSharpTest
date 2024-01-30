using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UStruct]
public partial struct SubmixEffectDynamicProcessorFilterSettings
{
    // BoolProperty /Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings:bEnabled
    static readonly int bEnabled_Offset;
    static readonly IntPtr bEnabled_NativeProperty;
    public bool Enabled;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings:Cutoff
    static readonly int Cutoff_Offset;
    public float Cutoff;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings:GainDb
    static readonly int GainDb_Offset;
    public float GainDb;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectDynamicProcessorFilterSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectDynamicProcessorFilterSettings");
        
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        bEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnabled");
        Cutoff_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Cutoff");
        GainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GainDb");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectDynamicProcessorFilterSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnabled_NativeProperty, bEnabled_Offset);
            Cutoff = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Cutoff_Offset), 0, null);
            GainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GainDb_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnabled_NativeProperty, bEnabled_Offset, Enabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Cutoff_Offset), 0, null, Cutoff);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GainDb_Offset), 0, null, GainDb);
        }
    }
}

public static class SubmixEffectDynamicProcessorFilterSettingsMarshaler
{
    public static SubmixEffectDynamicProcessorFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectDynamicProcessorFilterSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectDynamicProcessorFilterSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectDynamicProcessorFilterSettings.NativeDataSize;
    }
}