using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundWaveEnvelopeDataPerSound
{
    // FloatProperty /Script/Engine.SoundWaveEnvelopeDataPerSound:Envelope
    static readonly int Envelope_Offset;
    public float Envelope;
    
    // FloatProperty /Script/Engine.SoundWaveEnvelopeDataPerSound:PlaybackTime
    static readonly int PlaybackTime_Offset;
    public float PlaybackTime;
    
    // ObjectProperty /Script/Engine.SoundWaveEnvelopeDataPerSound:SoundWave
    static readonly int SoundWave_Offset;
    public UnrealSharp.Engine.SoundWave SoundWave;
    
    
    public static readonly int NativeDataSize;
    static SoundWaveEnvelopeDataPerSound()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundWaveEnvelopeDataPerSound");
        
        Envelope_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Envelope");
        PlaybackTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlaybackTime");
        SoundWave_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SoundWave");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundWaveEnvelopeDataPerSound(IntPtr InNativeStruct)
    {
        unsafe
        {
            Envelope = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Envelope_Offset), 0, null);
            PlaybackTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PlaybackTime_Offset), 0, null);
            SoundWave = ObjectMarshaller<UnrealSharp.Engine.SoundWave>.FromNative(IntPtr.Add(InNativeStruct, SoundWave_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Envelope_Offset), 0, null, Envelope);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PlaybackTime_Offset), 0, null, PlaybackTime);
            ObjectMarshaller<UnrealSharp.Engine.SoundWave>.ToNative(IntPtr.Add(Buffer, SoundWave_Offset), 0, null, SoundWave);
        }
    }
}

public static class SoundWaveEnvelopeDataPerSoundMarshaler
{
    public static SoundWaveEnvelopeDataPerSound FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundWaveEnvelopeDataPerSound(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundWaveEnvelopeDataPerSound obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundWaveEnvelopeDataPerSound.NativeDataSize;
    }
}