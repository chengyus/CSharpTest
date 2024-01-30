using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct FractureEffect
{
    // ObjectProperty /Script/Engine.FractureEffect:ParticleSystem
    static readonly int ParticleSystem_Offset;
    public UnrealSharp.Engine.ParticleSystem ParticleSystem;
    
    // ObjectProperty /Script/Engine.FractureEffect:Sound
    static readonly int Sound_Offset;
    public UnrealSharp.Engine.SoundBase Sound;
    
    
    public static readonly int NativeDataSize;
    static FractureEffect()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FractureEffect");
        
        ParticleSystem_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParticleSystem");
        Sound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Sound");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FractureEffect(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParticleSystem = ObjectMarshaller<UnrealSharp.Engine.ParticleSystem>.FromNative(IntPtr.Add(InNativeStruct, ParticleSystem_Offset), 0, null);
            Sound = ObjectMarshaller<UnrealSharp.Engine.SoundBase>.FromNative(IntPtr.Add(InNativeStruct, Sound_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.ParticleSystem>.ToNative(IntPtr.Add(Buffer, ParticleSystem_Offset), 0, null, ParticleSystem);
            ObjectMarshaller<UnrealSharp.Engine.SoundBase>.ToNative(IntPtr.Add(Buffer, Sound_Offset), 0, null, Sound);
        }
    }
}

public static class FractureEffectMarshaler
{
    public static FractureEffect FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FractureEffect(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FractureEffect obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FractureEffect.NativeDataSize;
    }
}