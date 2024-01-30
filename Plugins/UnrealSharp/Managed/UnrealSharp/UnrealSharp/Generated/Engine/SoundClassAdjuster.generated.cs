using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SoundClassAdjuster
{
    // ObjectProperty /Script/Engine.SoundClassAdjuster:SoundClassObject
    static readonly int SoundClassObject_Offset;
    public UnrealSharp.Engine.SoundClass SoundClassObject;
    
    // FloatProperty /Script/Engine.SoundClassAdjuster:VolumeAdjuster
    static readonly int VolumeAdjuster_Offset;
    public float VolumeAdjuster;
    
    // FloatProperty /Script/Engine.SoundClassAdjuster:PitchAdjuster
    static readonly int PitchAdjuster_Offset;
    public float PitchAdjuster;
    
    // FloatProperty /Script/Engine.SoundClassAdjuster:LowPassFilterFrequency
    static readonly int LowPassFilterFrequency_Offset;
    public float LowPassFilterFrequency;
    
    // BoolProperty /Script/Engine.SoundClassAdjuster:bApplyToChildren
    static readonly int bApplyToChildren_Offset;
    static readonly IntPtr bApplyToChildren_NativeProperty;
    public bool ApplyToChildren;
    
    // FloatProperty /Script/Engine.SoundClassAdjuster:VoiceCenterChannelVolumeAdjuster
    static readonly int VoiceCenterChannelVolumeAdjuster_Offset;
    public float VoiceCenterChannelVolumeAdjuster;
    
    
    public static readonly int NativeDataSize;
    static SoundClassAdjuster()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SoundClassAdjuster");
        
        SoundClassObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SoundClassObject");
        VolumeAdjuster_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VolumeAdjuster");
        PitchAdjuster_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PitchAdjuster");
        LowPassFilterFrequency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowPassFilterFrequency");
        bApplyToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyToChildren");
        bApplyToChildren_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bApplyToChildren");
        VoiceCenterChannelVolumeAdjuster_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VoiceCenterChannelVolumeAdjuster");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SoundClassAdjuster(IntPtr InNativeStruct)
    {
        unsafe
        {
            SoundClassObject = ObjectMarshaller<UnrealSharp.Engine.SoundClass>.FromNative(IntPtr.Add(InNativeStruct, SoundClassObject_Offset), 0, null);
            VolumeAdjuster = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VolumeAdjuster_Offset), 0, null);
            PitchAdjuster = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PitchAdjuster_Offset), 0, null);
            LowPassFilterFrequency = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LowPassFilterFrequency_Offset), 0, null);
            ApplyToChildren = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bApplyToChildren_NativeProperty, bApplyToChildren_Offset);
            VoiceCenterChannelVolumeAdjuster = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VoiceCenterChannelVolumeAdjuster_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SoundClass>.ToNative(IntPtr.Add(Buffer, SoundClassObject_Offset), 0, null, SoundClassObject);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VolumeAdjuster_Offset), 0, null, VolumeAdjuster);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PitchAdjuster_Offset), 0, null, PitchAdjuster);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LowPassFilterFrequency_Offset), 0, null, LowPassFilterFrequency);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bApplyToChildren_NativeProperty, bApplyToChildren_Offset, ApplyToChildren);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VoiceCenterChannelVolumeAdjuster_Offset), 0, null, VoiceCenterChannelVolumeAdjuster);
        }
    }
}

public static class SoundClassAdjusterMarshaler
{
    public static SoundClassAdjuster FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SoundClassAdjuster(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SoundClassAdjuster obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SoundClassAdjuster.NativeDataSize;
    }
}