using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioCapture;

[UStruct]
public partial struct AudioInputDeviceInfo
{
    // IntProperty /Script/AudioCapture.AudioInputDeviceInfo:InputChannels
    static readonly int InputChannels_Offset;
    public int InputChannels;
    
    // IntProperty /Script/AudioCapture.AudioInputDeviceInfo:PreferredSampleRate
    static readonly int PreferredSampleRate_Offset;
    public int PreferredSampleRate;
    
    // BoolProperty /Script/AudioCapture.AudioInputDeviceInfo:bSupportsHardwareAEC
    static readonly int bSupportsHardwareAEC_Offset;
    static readonly IntPtr bSupportsHardwareAEC_NativeProperty;
    public bool SupportsHardwareAEC;
    
    
    public static readonly int NativeDataSize;
    static AudioInputDeviceInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioInputDeviceInfo");
        
        InputChannels_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InputChannels");
        PreferredSampleRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreferredSampleRate");
        bSupportsHardwareAEC_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSupportsHardwareAEC");
        bSupportsHardwareAEC_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSupportsHardwareAEC");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioInputDeviceInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            InputChannels = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, InputChannels_Offset), 0, null);
            PreferredSampleRate = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PreferredSampleRate_Offset), 0, null);
            SupportsHardwareAEC = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSupportsHardwareAEC_NativeProperty, bSupportsHardwareAEC_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, InputChannels_Offset), 0, null, InputChannels);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PreferredSampleRate_Offset), 0, null, PreferredSampleRate);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSupportsHardwareAEC_NativeProperty, bSupportsHardwareAEC_Offset, SupportsHardwareAEC);
        }
    }
}

public static class AudioInputDeviceInfoMarshaler
{
    public static AudioInputDeviceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioInputDeviceInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioInputDeviceInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioInputDeviceInfo.NativeDataSize;
    }
}