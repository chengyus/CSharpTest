using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AudioVolumeSubmixSendSettings
{
    // EnumProperty /Script/Engine.AudioVolumeSubmixSendSettings:ListenerLocationState
    static readonly int ListenerLocationState_Offset;
    public UnrealSharp.Engine.EAudioVolumeLocationState ListenerLocationState;
    
    
    public static readonly int NativeDataSize;
    static AudioVolumeSubmixSendSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioVolumeSubmixSendSettings");
        
        ListenerLocationState_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ListenerLocationState");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioVolumeSubmixSendSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ListenerLocationState = BlittableMarshaller<UnrealSharp.Engine.EAudioVolumeLocationState>.FromNative(IntPtr.Add(InNativeStruct, ListenerLocationState_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EAudioVolumeLocationState>.ToNative(IntPtr.Add(Buffer, ListenerLocationState_Offset), 0, null, ListenerLocationState);
        }
    }
}

public static class AudioVolumeSubmixSendSettingsMarshaler
{
    public static AudioVolumeSubmixSendSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioVolumeSubmixSendSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioVolumeSubmixSendSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioVolumeSubmixSendSettings.NativeDataSize;
    }
}