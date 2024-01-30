using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakeRecorder;

[UStruct]
public partial struct TakeRecorderProjectParameters
{
    // StructProperty /Script/TakeRecorder.TakeRecorderProjectParameters:RootTakeSaveDir
    static readonly int RootTakeSaveDir_Offset;
    public UnrealSharp.CoreUObject.DirectoryPath RootTakeSaveDir;
    
    // EnumProperty /Script/TakeRecorder.TakeRecorderProjectParameters:RecordingClockSource
    static readonly int RecordingClockSource_Offset;
    public UnrealSharp.MovieScene.EUpdateClockSource RecordingClockSource;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderProjectParameters:bStartAtCurrentTimecode
    static readonly int bStartAtCurrentTimecode_Offset;
    public bool StartAtCurrentTimecode;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderProjectParameters:bRecordTimecode
    static readonly int bRecordTimecode_Offset;
    public bool RecordTimecode;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderProjectParameters:bRecordSourcesIntoSubSequences
    static readonly int bRecordSourcesIntoSubSequences_Offset;
    public bool RecordSourcesIntoSubSequences;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderProjectParameters:bRecordToPossessable
    static readonly int bRecordToPossessable_Offset;
    public bool RecordToPossessable;
    
    // BoolProperty /Script/TakeRecorder.TakeRecorderProjectParameters:bShowNotifications
    static readonly int bShowNotifications_Offset;
    public bool ShowNotifications;
    
    
    public static readonly int NativeDataSize;
    static TakeRecorderProjectParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TakeRecorderProjectParameters");
        
        RootTakeSaveDir_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootTakeSaveDir");
        RecordingClockSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RecordingClockSource");
        bStartAtCurrentTimecode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bStartAtCurrentTimecode");
        bRecordTimecode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecordTimecode");
        bRecordSourcesIntoSubSequences_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecordSourcesIntoSubSequences");
        bRecordToPossessable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecordToPossessable");
        bShowNotifications_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowNotifications");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TakeRecorderProjectParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            RootTakeSaveDir = UnrealSharp.CoreUObject.DirectoryPathMarshaler.FromNative(IntPtr.Add(InNativeStruct, RootTakeSaveDir_Offset), 0, null);
            RecordingClockSource = BlittableMarshaller<UnrealSharp.MovieScene.EUpdateClockSource>.FromNative(IntPtr.Add(InNativeStruct, RecordingClockSource_Offset), 0, null);
            StartAtCurrentTimecode = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bStartAtCurrentTimecode_Offset), 0, null);
            RecordTimecode = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecordTimecode_Offset), 0, null);
            RecordSourcesIntoSubSequences = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecordSourcesIntoSubSequences_Offset), 0, null);
            RecordToPossessable = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecordToPossessable_Offset), 0, null);
            ShowNotifications = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShowNotifications_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.DirectoryPathMarshaler.ToNative(IntPtr.Add(Buffer, RootTakeSaveDir_Offset), 0, null, RootTakeSaveDir);
            BlittableMarshaller<UnrealSharp.MovieScene.EUpdateClockSource>.ToNative(IntPtr.Add(Buffer, RecordingClockSource_Offset), 0, null, RecordingClockSource);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bStartAtCurrentTimecode_Offset), 0, null, StartAtCurrentTimecode);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecordTimecode_Offset), 0, null, RecordTimecode);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecordSourcesIntoSubSequences_Offset), 0, null, RecordSourcesIntoSubSequences);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecordToPossessable_Offset), 0, null, RecordToPossessable);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShowNotifications_Offset), 0, null, ShowNotifications);
        }
    }
}

public static class TakeRecorderProjectParametersMarshaler
{
    public static TakeRecorderProjectParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TakeRecorderProjectParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TakeRecorderProjectParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TakeRecorderProjectParameters.NativeDataSize;
    }
}