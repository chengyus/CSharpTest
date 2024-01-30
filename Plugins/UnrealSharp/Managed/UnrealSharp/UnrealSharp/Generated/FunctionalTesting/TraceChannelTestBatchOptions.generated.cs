using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct]
public partial struct TraceChannelTestBatchOptions
{
    // BoolProperty /Script/FunctionalTesting.TraceChannelTestBatchOptions:bLineTrace
    static readonly int bLineTrace_Offset;
    public bool LineTrace;
    
    // BoolProperty /Script/FunctionalTesting.TraceChannelTestBatchOptions:bSphereTrace
    static readonly int bSphereTrace_Offset;
    public bool SphereTrace;
    
    // BoolProperty /Script/FunctionalTesting.TraceChannelTestBatchOptions:bCapsuleTrace
    static readonly int bCapsuleTrace_Offset;
    public bool CapsuleTrace;
    
    // BoolProperty /Script/FunctionalTesting.TraceChannelTestBatchOptions:bBoxTrace
    static readonly int bBoxTrace_Offset;
    public bool BoxTrace;
    
    // BoolProperty /Script/FunctionalTesting.TraceChannelTestBatchOptions:bChannelTrace
    static readonly int bChannelTrace_Offset;
    public bool ChannelTrace;
    
    // BoolProperty /Script/FunctionalTesting.TraceChannelTestBatchOptions:bObjectsTrace
    static readonly int bObjectsTrace_Offset;
    public bool ObjectsTrace;
    
    // BoolProperty /Script/FunctionalTesting.TraceChannelTestBatchOptions:bProfileTrace
    static readonly int bProfileTrace_Offset;
    public bool ProfileTrace;
    
    
    public static readonly int NativeDataSize;
    static TraceChannelTestBatchOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TraceChannelTestBatchOptions");
        
        bLineTrace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLineTrace");
        bSphereTrace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSphereTrace");
        bCapsuleTrace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCapsuleTrace");
        bBoxTrace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBoxTrace");
        bChannelTrace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bChannelTrace");
        bObjectsTrace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bObjectsTrace");
        bProfileTrace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bProfileTrace");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TraceChannelTestBatchOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            LineTrace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bLineTrace_Offset), 0, null);
            SphereTrace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSphereTrace_Offset), 0, null);
            CapsuleTrace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCapsuleTrace_Offset), 0, null);
            BoxTrace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bBoxTrace_Offset), 0, null);
            ChannelTrace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bChannelTrace_Offset), 0, null);
            ObjectsTrace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bObjectsTrace_Offset), 0, null);
            ProfileTrace = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bProfileTrace_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bLineTrace_Offset), 0, null, LineTrace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSphereTrace_Offset), 0, null, SphereTrace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCapsuleTrace_Offset), 0, null, CapsuleTrace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bBoxTrace_Offset), 0, null, BoxTrace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bChannelTrace_Offset), 0, null, ChannelTrace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bObjectsTrace_Offset), 0, null, ObjectsTrace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bProfileTrace_Offset), 0, null, ProfileTrace);
        }
    }
}

public static class TraceChannelTestBatchOptionsMarshaler
{
    public static TraceChannelTestBatchOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TraceChannelTestBatchOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TraceChannelTestBatchOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TraceChannelTestBatchOptions.NativeDataSize;
    }
}