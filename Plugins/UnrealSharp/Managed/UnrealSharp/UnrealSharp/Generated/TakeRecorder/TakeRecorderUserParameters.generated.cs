using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakeRecorder;

[UStruct]
public partial struct TakeRecorderUserParameters
{
    // BoolProperty /Script/TakeRecorder.TakeRecorderUserParameters:bMaximizeViewport
    static readonly int bMaximizeViewport_Offset;
    public bool MaximizeViewport;
    
    // FloatProperty /Script/TakeRecorder.TakeRecorderUserParameters:CountdownSeconds
    static readonly int CountdownSeconds_Offset;
    public float CountdownSeconds;
    
    // FloatProperty /Script/TakeRecorder.TakeRecorderUserParameters:EngineTimeDilation
    static readonly int EngineTimeDilation_Offset;
    public float EngineTimeDilation;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderUserParameters:bResetPlayhead
    static readonly int bResetPlayhead_Offset;
    public bool ResetPlayhead;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderUserParameters:bStopAtPlaybackEnd
    static readonly int bStopAtPlaybackEnd_Offset;
    public bool StopAtPlaybackEnd;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderUserParameters:bRemoveRedundantTracks
    static readonly int bRemoveRedundantTracks_Offset;
    public bool RemoveRedundantTracks;
    
    // FloatProperty /Script/TakeRecorder.TakeRecorderUserParameters:ReduceKeysTolerance
    static readonly int ReduceKeysTolerance_Offset;
    public float ReduceKeysTolerance;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderUserParameters:bSaveRecordedAssets
    static readonly int bSaveRecordedAssets_Offset;
    public bool SaveRecordedAssets;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderUserParameters:bAutoLock
    static readonly int bAutoLock_Offset;
    public bool AutoLock;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderUserParameters:bAutoSerialize
    static readonly int bAutoSerialize_Offset;
    public bool AutoSerialize;
    
    
    public static readonly int NativeDataSize;
    static TakeRecorderUserParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TakeRecorderUserParameters");
        
        bMaximizeViewport_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMaximizeViewport");
        CountdownSeconds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CountdownSeconds");
        EngineTimeDilation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EngineTimeDilation");
        bResetPlayhead_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bResetPlayhead");
        bStopAtPlaybackEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bStopAtPlaybackEnd");
        bRemoveRedundantTracks_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRemoveRedundantTracks");
        ReduceKeysTolerance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReduceKeysTolerance");
        bSaveRecordedAssets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSaveRecordedAssets");
        bAutoLock_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoLock");
        bAutoSerialize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoSerialize");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TakeRecorderUserParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            MaximizeViewport = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMaximizeViewport_Offset), 0, null);
            CountdownSeconds = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CountdownSeconds_Offset), 0, null);
            EngineTimeDilation = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, EngineTimeDilation_Offset), 0, null);
            ResetPlayhead = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bResetPlayhead_Offset), 0, null);
            StopAtPlaybackEnd = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bStopAtPlaybackEnd_Offset), 0, null);
            RemoveRedundantTracks = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRemoveRedundantTracks_Offset), 0, null);
            ReduceKeysTolerance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReduceKeysTolerance_Offset), 0, null);
            SaveRecordedAssets = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSaveRecordedAssets_Offset), 0, null);
            AutoLock = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAutoLock_Offset), 0, null);
            AutoSerialize = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAutoSerialize_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMaximizeViewport_Offset), 0, null, MaximizeViewport);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CountdownSeconds_Offset), 0, null, CountdownSeconds);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, EngineTimeDilation_Offset), 0, null, EngineTimeDilation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bResetPlayhead_Offset), 0, null, ResetPlayhead);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bStopAtPlaybackEnd_Offset), 0, null, StopAtPlaybackEnd);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRemoveRedundantTracks_Offset), 0, null, RemoveRedundantTracks);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReduceKeysTolerance_Offset), 0, null, ReduceKeysTolerance);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSaveRecordedAssets_Offset), 0, null, SaveRecordedAssets);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAutoLock_Offset), 0, null, AutoLock);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAutoSerialize_Offset), 0, null, AutoSerialize);
        }
    }
}

public static class TakeRecorderUserParametersMarshaler
{
    public static TakeRecorderUserParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TakeRecorderUserParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TakeRecorderUserParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TakeRecorderUserParameters.NativeDataSize;
    }
}