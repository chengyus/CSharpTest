using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UStruct]
public partial struct NiagaraSimCacheCaptureParameters
{
    // BoolProperty /Script/Niagara.NiagaraSimCacheCaptureParameters:bAppendToSimCache
    static readonly int bAppendToSimCache_Offset;
    static readonly IntPtr bAppendToSimCache_NativeProperty;
    public bool AppendToSimCache;
    
    // BoolProperty /Script/Niagara.NiagaraSimCacheCaptureParameters:bCaptureFixedNumberOfFrames
    static readonly int bCaptureFixedNumberOfFrames_Offset;
    static readonly IntPtr bCaptureFixedNumberOfFrames_NativeProperty;
    public bool CaptureFixedNumberOfFrames;
    
    // IntProperty /Script/Niagara.NiagaraSimCacheCaptureParameters:NumFrames
    static readonly int NumFrames_Offset;
    public int NumFrames;
    
    // IntProperty /Script/Niagara.NiagaraSimCacheCaptureParameters:CaptureRate
    static readonly int CaptureRate_Offset;
    public int CaptureRate;
    
    // BoolProperty /Script/Niagara.NiagaraSimCacheCaptureParameters:bUseTimeout
    static readonly int bUseTimeout_Offset;
    static readonly IntPtr bUseTimeout_NativeProperty;
    public bool UseTimeout;
    
    // IntProperty /Script/Niagara.NiagaraSimCacheCaptureParameters:TimeoutFrameCount
    static readonly int TimeoutFrameCount_Offset;
    public int TimeoutFrameCount;
    
    // BoolProperty /Script/Niagara.NiagaraSimCacheCaptureParameters:bCaptureAllFramesImmediatly
    static readonly int bCaptureAllFramesImmediatly_Offset;
    static readonly IntPtr bCaptureAllFramesImmediatly_NativeProperty;
    public bool CaptureAllFramesImmediatly;
    
    // FloatProperty /Script/Niagara.NiagaraSimCacheCaptureParameters:ImmediateCaptureDeltaTime
    static readonly int ImmediateCaptureDeltaTime_Offset;
    public float ImmediateCaptureDeltaTime;
    
    
    public static readonly int NativeDataSize;
    static NiagaraSimCacheCaptureParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NiagaraSimCacheCaptureParameters");
        
        bAppendToSimCache_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAppendToSimCache");
        bAppendToSimCache_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAppendToSimCache");
        bCaptureFixedNumberOfFrames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCaptureFixedNumberOfFrames");
        bCaptureFixedNumberOfFrames_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCaptureFixedNumberOfFrames");
        NumFrames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumFrames");
        CaptureRate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CaptureRate");
        bUseTimeout_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseTimeout");
        bUseTimeout_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bUseTimeout");
        TimeoutFrameCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TimeoutFrameCount");
        bCaptureAllFramesImmediatly_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCaptureAllFramesImmediatly");
        bCaptureAllFramesImmediatly_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCaptureAllFramesImmediatly");
        ImmediateCaptureDeltaTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ImmediateCaptureDeltaTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NiagaraSimCacheCaptureParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            AppendToSimCache = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAppendToSimCache_NativeProperty, bAppendToSimCache_Offset);
            CaptureFixedNumberOfFrames = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCaptureFixedNumberOfFrames_NativeProperty, bCaptureFixedNumberOfFrames_Offset);
            NumFrames = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumFrames_Offset), 0, null);
            CaptureRate = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, CaptureRate_Offset), 0, null);
            UseTimeout = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bUseTimeout_NativeProperty, bUseTimeout_Offset);
            TimeoutFrameCount = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, TimeoutFrameCount_Offset), 0, null);
            CaptureAllFramesImmediatly = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCaptureAllFramesImmediatly_NativeProperty, bCaptureAllFramesImmediatly_Offset);
            ImmediateCaptureDeltaTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ImmediateCaptureDeltaTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAppendToSimCache_NativeProperty, bAppendToSimCache_Offset, AppendToSimCache);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCaptureFixedNumberOfFrames_NativeProperty, bCaptureFixedNumberOfFrames_Offset, CaptureFixedNumberOfFrames);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumFrames_Offset), 0, null, NumFrames);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, CaptureRate_Offset), 0, null, CaptureRate);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bUseTimeout_NativeProperty, bUseTimeout_Offset, UseTimeout);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, TimeoutFrameCount_Offset), 0, null, TimeoutFrameCount);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCaptureAllFramesImmediatly_NativeProperty, bCaptureAllFramesImmediatly_Offset, CaptureAllFramesImmediatly);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ImmediateCaptureDeltaTime_Offset), 0, null, ImmediateCaptureDeltaTime);
        }
    }
}

public static class NiagaraSimCacheCaptureParametersMarshaler
{
    public static NiagaraSimCacheCaptureParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NiagaraSimCacheCaptureParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NiagaraSimCacheCaptureParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NiagaraSimCacheCaptureParameters.NativeDataSize;
    }
}