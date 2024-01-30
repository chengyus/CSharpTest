using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AudioComponentParam
{
    // ObjectProperty /Script/Engine.AudioComponentParam:SoundWaveParam
    static readonly int SoundWaveParam_Offset;
    public UnrealSharp.Engine.SoundWave SoundWaveParam;
    
    
    public static readonly int NativeDataSize;
    static AudioComponentParam()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioComponentParam");
        
        SoundWaveParam_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SoundWaveParam");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioComponentParam(IntPtr InNativeStruct)
    {
        unsafe
        {
            SoundWaveParam = ObjectMarshaller<UnrealSharp.Engine.SoundWave>.FromNative(IntPtr.Add(InNativeStruct, SoundWaveParam_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SoundWave>.ToNative(IntPtr.Add(Buffer, SoundWaveParam_Offset), 0, null, SoundWaveParam);
        }
    }
}

public static class AudioComponentParamMarshaler
{
    public static AudioComponentParam FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioComponentParam(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioComponentParam obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioComponentParam.NativeDataSize;
    }
}