using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UStruct]
public partial struct AudioOutputDeviceInfo
{
    // IntProperty /Script/AudioMixer.AudioOutputDeviceInfo:NumChannels
    static readonly int NumChannels_Offset;
    public int NumChannels;
    
    // IntProperty /Script/AudioMixer.AudioOutputDeviceInfo:SampleRate
    static readonly int SampleRate_Offset;
    public int SampleRate;
    
    // EnumProperty /Script/AudioMixer.AudioOutputDeviceInfo:Format
    static readonly int Format_Offset;
    public UnrealSharp.AudioMixer.EAudioMixerStreamDataFormatType Format;
    
    // BoolProperty /Script/AudioMixer.AudioOutputDeviceInfo:bIsSystemDefault
    static readonly int bIsSystemDefault_Offset;
    static readonly IntPtr bIsSystemDefault_NativeProperty;
    public bool IsSystemDefault;
    
    // BoolProperty /Script/AudioMixer.AudioOutputDeviceInfo:bIsCurrentDevice
    static readonly int bIsCurrentDevice_Offset;
    static readonly IntPtr bIsCurrentDevice_NativeProperty;
    public bool IsCurrentDevice;
    
    
    public static readonly int NativeDataSize;
    static AudioOutputDeviceInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioOutputDeviceInfo");
        
        NumChannels_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumChannels");
        SampleRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SampleRate");
        Format_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Format");
        bIsSystemDefault_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSystemDefault");
        bIsSystemDefault_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsSystemDefault");
        bIsCurrentDevice_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsCurrentDevice");
        bIsCurrentDevice_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bIsCurrentDevice");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioOutputDeviceInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            NumChannels = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumChannels_Offset), 0, null);
            SampleRate = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SampleRate_Offset), 0, null);
            Format = BlittableMarshaller<UnrealSharp.AudioMixer.EAudioMixerStreamDataFormatType>.FromNative(IntPtr.Add(InNativeStruct, Format_Offset), 0, null);
            IsSystemDefault = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIsSystemDefault_NativeProperty, bIsSystemDefault_Offset);
            IsCurrentDevice = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bIsCurrentDevice_NativeProperty, bIsCurrentDevice_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumChannels_Offset), 0, null, NumChannels);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SampleRate_Offset), 0, null, SampleRate);
            BlittableMarshaller<UnrealSharp.AudioMixer.EAudioMixerStreamDataFormatType>.ToNative(IntPtr.Add(Buffer, Format_Offset), 0, null, Format);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIsSystemDefault_NativeProperty, bIsSystemDefault_Offset, IsSystemDefault);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bIsCurrentDevice_NativeProperty, bIsCurrentDevice_Offset, IsCurrentDevice);
        }
    }
}

public static class AudioOutputDeviceInfoMarshaler
{
    public static AudioOutputDeviceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioOutputDeviceInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioOutputDeviceInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioOutputDeviceInfo.NativeDataSize;
    }
}