using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AudioBasedVibrationData
{
    // ObjectProperty /Script/Engine.AudioBasedVibrationData:Sound
    static readonly int Sound_Offset;
    public UnrealSharp.Engine.SoundBase Sound;
    
    
    public static readonly int NativeDataSize;
    static AudioBasedVibrationData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioBasedVibrationData");
        
        Sound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sound");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioBasedVibrationData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Sound = ObjectMarshaller<UnrealSharp.Engine.SoundBase>.FromNative(IntPtr.Add(InNativeStruct, Sound_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SoundBase>.ToNative(IntPtr.Add(Buffer, Sound_Offset), 0, null, Sound);
        }
    }
}

public static class AudioBasedVibrationDataMarshaler
{
    public static AudioBasedVibrationData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioBasedVibrationData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioBasedVibrationData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioBasedVibrationData.NativeDataSize;
    }
}