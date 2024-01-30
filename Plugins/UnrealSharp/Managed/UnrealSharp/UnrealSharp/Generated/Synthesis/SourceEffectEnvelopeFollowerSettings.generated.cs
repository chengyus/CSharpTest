using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectEnvelopeFollowerSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectEnvelopeFollowerSettings:AttackTime
    static readonly int AttackTime_Offset;
    public float AttackTime;
    
    // FloatProperty /Script/Synthesis.SourceEffectEnvelopeFollowerSettings:ReleaseTime
    static readonly int ReleaseTime_Offset;
    public float ReleaseTime;
    
    // EnumProperty /Script/Synthesis.SourceEffectEnvelopeFollowerSettings:PeakMode
    static readonly int PeakMode_Offset;
    public UnrealSharp.Synthesis.EEnvelopeFollowerPeakMode PeakMode;
    
    // BoolProperty /Script/Synthesis.SourceEffectEnvelopeFollowerSettings:bIsAnalogMode
    static readonly int bIsAnalogMode_Offset;
    public bool IsAnalogMode;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectEnvelopeFollowerSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectEnvelopeFollowerSettings");
        
        AttackTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AttackTime");
        ReleaseTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReleaseTime");
        PeakMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PeakMode");
        bIsAnalogMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsAnalogMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectEnvelopeFollowerSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            AttackTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AttackTime_Offset), 0, null);
            ReleaseTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReleaseTime_Offset), 0, null);
            PeakMode = BlittableMarshaller<UnrealSharp.Synthesis.EEnvelopeFollowerPeakMode>.FromNative(IntPtr.Add(InNativeStruct, PeakMode_Offset), 0, null);
            IsAnalogMode = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsAnalogMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AttackTime_Offset), 0, null, AttackTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReleaseTime_Offset), 0, null, ReleaseTime);
            BlittableMarshaller<UnrealSharp.Synthesis.EEnvelopeFollowerPeakMode>.ToNative(IntPtr.Add(Buffer, PeakMode_Offset), 0, null, PeakMode);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsAnalogMode_Offset), 0, null, IsAnalogMode);
        }
    }
}

public static class SourceEffectEnvelopeFollowerSettingsMarshaler
{
    public static SourceEffectEnvelopeFollowerSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectEnvelopeFollowerSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectEnvelopeFollowerSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectEnvelopeFollowerSettings.NativeDataSize;
    }
}