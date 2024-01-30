using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct PassiveSoundMixModifier
{
    // ObjectProperty /Script/Engine.PassiveSoundMixModifier:SoundMix
    static readonly int SoundMix_Offset;
    public UnrealSharp.Engine.SoundMix SoundMix;
    
    // FloatProperty /Script/Engine.PassiveSoundMixModifier:MinVolumeThreshold
    static readonly int MinVolumeThreshold_Offset;
    public float MinVolumeThreshold;
    
    // FloatProperty /Script/Engine.PassiveSoundMixModifier:MaxVolumeThreshold
    static readonly int MaxVolumeThreshold_Offset;
    public float MaxVolumeThreshold;
    
    
    public static readonly int NativeDataSize;
    static PassiveSoundMixModifier()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PassiveSoundMixModifier");
        
        SoundMix_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SoundMix");
        MinVolumeThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinVolumeThreshold");
        MaxVolumeThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxVolumeThreshold");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PassiveSoundMixModifier(IntPtr InNativeStruct)
    {
        unsafe
        {
            SoundMix = ObjectMarshaller<UnrealSharp.Engine.SoundMix>.FromNative(IntPtr.Add(InNativeStruct, SoundMix_Offset), 0, null);
            MinVolumeThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MinVolumeThreshold_Offset), 0, null);
            MaxVolumeThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MaxVolumeThreshold_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SoundMix>.ToNative(IntPtr.Add(Buffer, SoundMix_Offset), 0, null, SoundMix);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MinVolumeThreshold_Offset), 0, null, MinVolumeThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MaxVolumeThreshold_Offset), 0, null, MaxVolumeThreshold);
        }
    }
}

public static class PassiveSoundMixModifierMarshaler
{
    public static PassiveSoundMixModifier FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PassiveSoundMixModifier(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PassiveSoundMixModifier obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PassiveSoundMixModifier.NativeDataSize;
    }
}