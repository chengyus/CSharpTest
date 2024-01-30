using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct QuartzPulseOverrideStep
{
    // IntProperty /Script/Engine.QuartzPulseOverrideStep:NumberOfPulses
    static readonly int NumberOfPulses_Offset;
    public int NumberOfPulses;
    
    // EnumProperty /Script/Engine.QuartzPulseOverrideStep:PulseDuration
    static readonly int PulseDuration_Offset;
    public UnrealSharp.Engine.EQuartzCommandQuantization PulseDuration;
    
    
    public static readonly int NativeDataSize;
    static QuartzPulseOverrideStep()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("QuartzPulseOverrideStep");
        
        NumberOfPulses_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumberOfPulses");
        PulseDuration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PulseDuration");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public QuartzPulseOverrideStep(IntPtr InNativeStruct)
    {
        unsafe
        {
            NumberOfPulses = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumberOfPulses_Offset), 0, null);
            PulseDuration = BlittableMarshaller<UnrealSharp.Engine.EQuartzCommandQuantization>.FromNative(IntPtr.Add(InNativeStruct, PulseDuration_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumberOfPulses_Offset), 0, null, NumberOfPulses);
            BlittableMarshaller<UnrealSharp.Engine.EQuartzCommandQuantization>.ToNative(IntPtr.Add(Buffer, PulseDuration_Offset), 0, null, PulseDuration);
        }
    }
}

public static class QuartzPulseOverrideStepMarshaler
{
    public static QuartzPulseOverrideStep FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new QuartzPulseOverrideStep(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, QuartzPulseOverrideStep obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return QuartzPulseOverrideStep.NativeDataSize;
    }
}