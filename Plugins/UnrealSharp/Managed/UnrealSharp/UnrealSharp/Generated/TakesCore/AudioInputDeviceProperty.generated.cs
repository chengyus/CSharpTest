using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakesCore;

[UStruct]
public partial struct AudioInputDeviceProperty
{
    // BoolProperty /Script/TakesCore.AudioInputDeviceProperty:bUseSystemDefaultAudioDevice
    static readonly int bUseSystemDefaultAudioDevice_Offset;
    public bool UseSystemDefaultAudioDevice;
    
    // IntProperty /Script/TakesCore.AudioInputDeviceProperty:AudioInputBufferSize
    static readonly int AudioInputBufferSize_Offset;
    public int AudioInputBufferSize;
    
    
    public static readonly int NativeDataSize;
    static AudioInputDeviceProperty()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioInputDeviceProperty");
        
        bUseSystemDefaultAudioDevice_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseSystemDefaultAudioDevice");
        AudioInputBufferSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AudioInputBufferSize");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioInputDeviceProperty(IntPtr InNativeStruct)
    {
        unsafe
        {
            UseSystemDefaultAudioDevice = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseSystemDefaultAudioDevice_Offset), 0, null);
            AudioInputBufferSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, AudioInputBufferSize_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseSystemDefaultAudioDevice_Offset), 0, null, UseSystemDefaultAudioDevice);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, AudioInputBufferSize_Offset), 0, null, AudioInputBufferSize);
        }
    }
}

public static class AudioInputDevicePropertyMarshaler
{
    public static AudioInputDeviceProperty FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioInputDeviceProperty(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioInputDeviceProperty obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioInputDeviceProperty.NativeDataSize;
    }
}