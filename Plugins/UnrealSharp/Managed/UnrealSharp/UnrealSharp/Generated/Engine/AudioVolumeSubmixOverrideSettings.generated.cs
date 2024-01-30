using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AudioVolumeSubmixOverrideSettings
{
    // ObjectProperty /Script/Engine.AudioVolumeSubmixOverrideSettings:Submix
    static readonly int Submix_Offset;
    public UnrealSharp.Engine.SoundSubmix Submix;
    
    // FloatProperty /Script/Engine.AudioVolumeSubmixOverrideSettings:CrossfadeTime
    static readonly int CrossfadeTime_Offset;
    public float CrossfadeTime;
    
    
    public static readonly int NativeDataSize;
    static AudioVolumeSubmixOverrideSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioVolumeSubmixOverrideSettings");
        
        Submix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Submix");
        CrossfadeTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CrossfadeTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioVolumeSubmixOverrideSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            Submix = ObjectMarshaller<UnrealSharp.Engine.SoundSubmix>.FromNative(IntPtr.Add(InNativeStruct, Submix_Offset), 0, null);
            CrossfadeTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CrossfadeTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SoundSubmix>.ToNative(IntPtr.Add(Buffer, Submix_Offset), 0, null, Submix);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CrossfadeTime_Offset), 0, null, CrossfadeTime);
        }
    }
}

public static class AudioVolumeSubmixOverrideSettingsMarshaler
{
    public static AudioVolumeSubmixOverrideSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioVolumeSubmixOverrideSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioVolumeSubmixOverrideSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioVolumeSubmixOverrideSettings.NativeDataSize;
    }
}