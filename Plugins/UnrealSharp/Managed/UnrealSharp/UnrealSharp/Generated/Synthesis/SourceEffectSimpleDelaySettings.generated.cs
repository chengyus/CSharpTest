using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct SourceEffectSimpleDelaySettings
{
    // FloatProperty /Script/Synthesis.SourceEffectSimpleDelaySettings:SpeedOfSound
    static readonly int SpeedOfSound_Offset;
    public float SpeedOfSound;
    
    // FloatProperty /Script/Synthesis.SourceEffectSimpleDelaySettings:DelayAmount
    static readonly int DelayAmount_Offset;
    public float DelayAmount;
    
    // FloatProperty /Script/Synthesis.SourceEffectSimpleDelaySettings:DryAmount
    static readonly int DryAmount_Offset;
    public float DryAmount;
    
    // FloatProperty /Script/Synthesis.SourceEffectSimpleDelaySettings:WetAmount
    static readonly int WetAmount_Offset;
    public float WetAmount;
    
    // FloatProperty /Script/Synthesis.SourceEffectSimpleDelaySettings:Feedback
    static readonly int Feedback_Offset;
    public float Feedback;
    
    // BoolProperty /Script/Synthesis.SourceEffectSimpleDelaySettings:bDelayBasedOnDistance
    static readonly int bDelayBasedOnDistance_Offset;
    static readonly IntPtr bDelayBasedOnDistance_NativeProperty;
    public bool DelayBasedOnDistance;
    
    // BoolProperty /Script/Synthesis.SourceEffectSimpleDelaySettings:bUseDistanceOverride
    static readonly int bUseDistanceOverride_Offset;
    static readonly IntPtr bUseDistanceOverride_NativeProperty;
    public bool UseDistanceOverride;
    
    
    public static readonly int NativeDataSize;
    static SourceEffectSimpleDelaySettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceEffectSimpleDelaySettings");
        
        SpeedOfSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpeedOfSound");
        DelayAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DelayAmount");
        DryAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DryAmount");
        WetAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WetAmount");
        Feedback_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Feedback");
        bDelayBasedOnDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDelayBasedOnDistance");
        bDelayBasedOnDistance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDelayBasedOnDistance");
        bUseDistanceOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseDistanceOverride");
        bUseDistanceOverride_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseDistanceOverride");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceEffectSimpleDelaySettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            SpeedOfSound = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SpeedOfSound_Offset), 0, null);
            DelayAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DelayAmount_Offset), 0, null);
            DryAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DryAmount_Offset), 0, null);
            WetAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WetAmount_Offset), 0, null);
            Feedback = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Feedback_Offset), 0, null);
            DelayBasedOnDistance = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDelayBasedOnDistance_NativeProperty, bDelayBasedOnDistance_Offset);
            UseDistanceOverride = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseDistanceOverride_NativeProperty, bUseDistanceOverride_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SpeedOfSound_Offset), 0, null, SpeedOfSound);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DelayAmount_Offset), 0, null, DelayAmount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DryAmount_Offset), 0, null, DryAmount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WetAmount_Offset), 0, null, WetAmount);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Feedback_Offset), 0, null, Feedback);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDelayBasedOnDistance_NativeProperty, bDelayBasedOnDistance_Offset, DelayBasedOnDistance);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseDistanceOverride_NativeProperty, bUseDistanceOverride_Offset, UseDistanceOverride);
        }
    }
}

public static class SourceEffectSimpleDelaySettingsMarshaler
{
    public static SourceEffectSimpleDelaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceEffectSimpleDelaySettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceEffectSimpleDelaySettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceEffectSimpleDelaySettings.NativeDataSize;
    }
}