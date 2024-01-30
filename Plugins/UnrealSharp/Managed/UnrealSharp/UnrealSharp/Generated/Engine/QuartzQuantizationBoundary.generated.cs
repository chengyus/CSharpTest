using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct QuartzQuantizationBoundary
{
    // EnumProperty /Script/Engine.QuartzQuantizationBoundary:Quantization
    static readonly int Quantization_Offset;
    public UnrealSharp.Engine.EQuartzCommandQuantization Quantization;
    
    // FloatProperty /Script/Engine.QuartzQuantizationBoundary:Multiplier
    static readonly int Multiplier_Offset;
    public float Multiplier;
    
    // EnumProperty /Script/Engine.QuartzQuantizationBoundary:CountingReferencePoint
    static readonly int CountingReferencePoint_Offset;
    public UnrealSharp.Engine.EQuarztQuantizationReference CountingReferencePoint;
    
    // BoolProperty /Script/Engine.QuartzQuantizationBoundary:bFireOnClockStart
    static readonly int bFireOnClockStart_Offset;
    public bool FireOnClockStart;
    
    // BoolProperty /Script/Engine.QuartzQuantizationBoundary:bCancelCommandIfClockIsNotRunning
    static readonly int bCancelCommandIfClockIsNotRunning_Offset;
    public bool CancelCommandIfClockIsNotRunning;
    
    // BoolProperty /Script/Engine.QuartzQuantizationBoundary:bResetClockOnQueued
    static readonly int bResetClockOnQueued_Offset;
    public bool ResetClockOnQueued;
    
    // BoolProperty /Script/Engine.QuartzQuantizationBoundary:bResumeClockOnQueued
    static readonly int bResumeClockOnQueued_Offset;
    public bool ResumeClockOnQueued;
    
    
    public static readonly int NativeDataSize;
    static QuartzQuantizationBoundary()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("QuartzQuantizationBoundary");
        
        Quantization_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Quantization");
        Multiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Multiplier");
        CountingReferencePoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CountingReferencePoint");
        bFireOnClockStart_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFireOnClockStart");
        bCancelCommandIfClockIsNotRunning_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCancelCommandIfClockIsNotRunning");
        bResetClockOnQueued_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bResetClockOnQueued");
        bResumeClockOnQueued_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bResumeClockOnQueued");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public QuartzQuantizationBoundary(IntPtr InNativeStruct)
    {
        unsafe
        {
            Quantization = BlittableMarshaller<UnrealSharp.Engine.EQuartzCommandQuantization>.FromNative(IntPtr.Add(InNativeStruct, Quantization_Offset), 0, null);
            Multiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Multiplier_Offset), 0, null);
            CountingReferencePoint = BlittableMarshaller<UnrealSharp.Engine.EQuarztQuantizationReference>.FromNative(IntPtr.Add(InNativeStruct, CountingReferencePoint_Offset), 0, null);
            FireOnClockStart = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bFireOnClockStart_Offset), 0, null);
            CancelCommandIfClockIsNotRunning = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCancelCommandIfClockIsNotRunning_Offset), 0, null);
            ResetClockOnQueued = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bResetClockOnQueued_Offset), 0, null);
            ResumeClockOnQueued = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bResumeClockOnQueued_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EQuartzCommandQuantization>.ToNative(IntPtr.Add(Buffer, Quantization_Offset), 0, null, Quantization);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Multiplier_Offset), 0, null, Multiplier);
            BlittableMarshaller<UnrealSharp.Engine.EQuarztQuantizationReference>.ToNative(IntPtr.Add(Buffer, CountingReferencePoint_Offset), 0, null, CountingReferencePoint);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bFireOnClockStart_Offset), 0, null, FireOnClockStart);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCancelCommandIfClockIsNotRunning_Offset), 0, null, CancelCommandIfClockIsNotRunning);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bResetClockOnQueued_Offset), 0, null, ResetClockOnQueued);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bResumeClockOnQueued_Offset), 0, null, ResumeClockOnQueued);
        }
    }
}

public static class QuartzQuantizationBoundaryMarshaler
{
    public static QuartzQuantizationBoundary FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new QuartzQuantizationBoundary(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, QuartzQuantizationBoundary obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return QuartzQuantizationBoundary.NativeDataSize;
    }
}