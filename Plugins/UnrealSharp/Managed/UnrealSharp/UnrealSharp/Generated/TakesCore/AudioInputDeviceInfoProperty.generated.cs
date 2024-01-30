using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakesCore;

[UStruct]
public partial struct AudioInputDeviceInfoProperty
{
    // IntProperty /Script/TakesCore.AudioInputDeviceInfoProperty:InputChannels
    static readonly int InputChannels_Offset;
    public int InputChannels;
    
    // IntProperty /Script/TakesCore.AudioInputDeviceInfoProperty:PreferredSampleRate
    static readonly int PreferredSampleRate_Offset;
    public int PreferredSampleRate;
    
    // BoolProperty /Script/TakesCore.AudioInputDeviceInfoProperty:bIsDefaultDevice
    static readonly int bIsDefaultDevice_Offset;
    public bool IsDefaultDevice;
    
    
    public static readonly int NativeDataSize;
    static AudioInputDeviceInfoProperty()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioInputDeviceInfoProperty");
        
        InputChannels_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InputChannels");
        PreferredSampleRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreferredSampleRate");
        bIsDefaultDevice_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsDefaultDevice");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioInputDeviceInfoProperty(IntPtr InNativeStruct)
    {
        unsafe
        {
            InputChannels = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, InputChannels_Offset), 0, null);
            PreferredSampleRate = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PreferredSampleRate_Offset), 0, null);
            IsDefaultDevice = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsDefaultDevice_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, InputChannels_Offset), 0, null, InputChannels);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PreferredSampleRate_Offset), 0, null, PreferredSampleRate);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsDefaultDevice_Offset), 0, null, IsDefaultDevice);
        }
    }
}

public static class AudioInputDeviceInfoPropertyMarshaler
{
    public static AudioInputDeviceInfoProperty FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioInputDeviceInfoProperty(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioInputDeviceInfoProperty obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioInputDeviceInfoProperty.NativeDataSize;
    }
}