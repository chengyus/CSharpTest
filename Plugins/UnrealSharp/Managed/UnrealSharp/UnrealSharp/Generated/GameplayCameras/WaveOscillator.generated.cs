using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UStruct]
public partial struct WaveOscillator
{
    // FloatProperty /Script/GameplayCameras.WaveOscillator:Amplitude
    static readonly int Amplitude_Offset;
    public float Amplitude;
    
    // FloatProperty /Script/GameplayCameras.WaveOscillator:Frequency
    static readonly int Frequency_Offset;
    public float Frequency;
    
    // EnumProperty /Script/GameplayCameras.WaveOscillator:InitialOffsetType
    static readonly int InitialOffsetType_Offset;
    public UnrealSharp.GameplayCameras.EInitialWaveOscillatorOffsetType InitialOffsetType;
    
    
    public static readonly int NativeDataSize;
    static WaveOscillator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WaveOscillator");
        
        Amplitude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Amplitude");
        Frequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Frequency");
        InitialOffsetType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialOffsetType");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WaveOscillator(IntPtr InNativeStruct)
    {
        unsafe
        {
            Amplitude = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Amplitude_Offset), 0, null);
            Frequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Frequency_Offset), 0, null);
            InitialOffsetType = BlittableMarshaller<UnrealSharp.GameplayCameras.EInitialWaveOscillatorOffsetType>.FromNative(IntPtr.Add(InNativeStruct, InitialOffsetType_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Amplitude_Offset), 0, null, Amplitude);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Frequency_Offset), 0, null, Frequency);
            BlittableMarshaller<UnrealSharp.GameplayCameras.EInitialWaveOscillatorOffsetType>.ToNative(IntPtr.Add(Buffer, InitialOffsetType_Offset), 0, null, InitialOffsetType);
        }
    }
}

public static class WaveOscillatorMarshaler
{
    public static WaveOscillator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WaveOscillator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WaveOscillator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WaveOscillator.NativeDataSize;
    }
}