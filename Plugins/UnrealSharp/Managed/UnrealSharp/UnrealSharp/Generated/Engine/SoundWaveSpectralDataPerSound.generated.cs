using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundWaveSpectralDataPerSound
{
    // FloatProperty /Script/Engine.SoundWaveSpectralDataPerSound:PlaybackTime
    static readonly int PlaybackTime_Offset;
    public float PlaybackTime;
    
    // ObjectProperty /Script/Engine.SoundWaveSpectralDataPerSound:SoundWave
    static readonly int SoundWave_Offset;
    public UnrealSharp.Engine.SoundWave SoundWave;
    
    
    public static readonly int NativeDataSize;
    static SoundWaveSpectralDataPerSound()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundWaveSpectralDataPerSound");
        
        PlaybackTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaybackTime");
        SoundWave_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SoundWave");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundWaveSpectralDataPerSound(IntPtr InNativeStruct)
    {
        unsafe
        {
            PlaybackTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PlaybackTime_Offset), 0, null);
            SoundWave = ObjectMarshaller<UnrealSharp.Engine.SoundWave>.FromNative(IntPtr.Add(InNativeStruct, SoundWave_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PlaybackTime_Offset), 0, null, PlaybackTime);
            ObjectMarshaller<UnrealSharp.Engine.SoundWave>.ToNative(IntPtr.Add(Buffer, SoundWave_Offset), 0, null, SoundWave);
        }
    }
}

public static class SoundWaveSpectralDataPerSoundMarshaler
{
    public static SoundWaveSpectralDataPerSound FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundWaveSpectralDataPerSound(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundWaveSpectralDataPerSound obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundWaveSpectralDataPerSound.NativeDataSize;
    }
}