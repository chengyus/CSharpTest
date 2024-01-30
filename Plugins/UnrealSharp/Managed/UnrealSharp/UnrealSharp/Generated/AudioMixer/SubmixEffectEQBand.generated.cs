using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UStruct]
public partial struct SubmixEffectEQBand
{
    // FloatProperty /Script/AudioMixer.SubmixEffectEQBand:Frequency
    static readonly int Frequency_Offset;
    public float Frequency;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectEQBand:Bandwidth
    static readonly int Bandwidth_Offset;
    public float Bandwidth;
    
    // FloatProperty /Script/AudioMixer.SubmixEffectEQBand:GainDb
    static readonly int GainDb_Offset;
    public float GainDb;
    
    // BoolProperty /Script/AudioMixer.SubmixEffectEQBand:bEnabled
    static readonly int bEnabled_Offset;
    static readonly IntPtr bEnabled_NativeProperty;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static SubmixEffectEQBand()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SubmixEffectEQBand");
        
        Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frequency");
        Bandwidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bandwidth");
        GainDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GainDb");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        bEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SubmixEffectEQBand(IntPtr InNativeStruct)
    {
        unsafe
        {
            Frequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Frequency_Offset), 0, null);
            Bandwidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bandwidth_Offset), 0, null);
            GainDb = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GainDb_Offset), 0, null);
            Enabled = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnabled_NativeProperty, bEnabled_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Frequency_Offset), 0, null, Frequency);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bandwidth_Offset), 0, null, Bandwidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GainDb_Offset), 0, null, GainDb);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnabled_NativeProperty, bEnabled_Offset, Enabled);
        }
    }
}

public static class SubmixEffectEQBandMarshaler
{
    public static SubmixEffectEQBand FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SubmixEffectEQBand(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SubmixEffectEQBand obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SubmixEffectEQBand.NativeDataSize;
    }
}