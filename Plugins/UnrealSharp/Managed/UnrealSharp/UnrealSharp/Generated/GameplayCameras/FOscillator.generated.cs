using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UStruct]
public partial struct FOscillator
{
    // FloatProperty /Script/GameplayCameras.FOscillator:Amplitude
    static readonly int Amplitude_Offset;
    public float Amplitude;
    
    // FloatProperty /Script/GameplayCameras.FOscillator:Frequency
    static readonly int Frequency_Offset;
    public float Frequency;
    
    // EnumProperty /Script/GameplayCameras.FOscillator:Waveform
    static readonly int Waveform_Offset;
    public UnrealSharp.GameplayCameras.EOscillatorWaveform Waveform;
    
    
    public static readonly int NativeDataSize;
    static FOscillator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FOscillator");
        
        Amplitude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Amplitude");
        Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frequency");
        Waveform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Waveform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FOscillator(IntPtr InNativeStruct)
    {
        unsafe
        {
            Amplitude = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Amplitude_Offset), 0, null);
            Frequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Frequency_Offset), 0, null);
            Waveform = BlittableMarshaller<UnrealSharp.GameplayCameras.EOscillatorWaveform>.FromNative(IntPtr.Add(InNativeStruct, Waveform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Amplitude_Offset), 0, null, Amplitude);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Frequency_Offset), 0, null, Frequency);
            BlittableMarshaller<UnrealSharp.GameplayCameras.EOscillatorWaveform>.ToNative(IntPtr.Add(Buffer, Waveform_Offset), 0, null, Waveform);
        }
    }
}

public static class FOscillatorMarshaler
{
    public static FOscillator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FOscillator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FOscillator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FOscillator.NativeDataSize;
    }
}