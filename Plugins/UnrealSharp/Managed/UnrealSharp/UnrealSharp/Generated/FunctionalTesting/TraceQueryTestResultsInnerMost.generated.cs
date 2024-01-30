using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct]
public partial struct TraceQueryTestResultsInnerMost
{
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResultsInnerMost:SingleHit
    static readonly int SingleHit_Offset;
    public UnrealSharp.Engine.HitResult SingleHit;
    
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResultsInnerMost:SingleNames
    static readonly int SingleNames_Offset;
    public UnrealSharp.FunctionalTesting.TraceQueryTestNames SingleNames;
    
    // BoolProperty /Script/FunctionalTesting.TraceQueryTestResultsInnerMost:bSingleResult
    static readonly int bSingleResult_Offset;
    public bool SingleResult;
    
    // BoolProperty /Script/FunctionalTesting.TraceQueryTestResultsInnerMost:bMultiResult
    static readonly int bMultiResult_Offset;
    public bool MultiResult;
    
    
    public static readonly int NativeDataSize;
    static TraceQueryTestResultsInnerMost()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TraceQueryTestResultsInnerMost");
        
        SingleHit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SingleHit");
        SingleNames_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SingleNames");
        bSingleResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSingleResult");
        bMultiResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMultiResult");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TraceQueryTestResultsInnerMost(IntPtr InNativeStruct)
    {
        unsafe
        {
            SingleHit = UnrealSharp.Engine.HitResultMarshaler.FromNative(IntPtr.Add(InNativeStruct, SingleHit_Offset), 0, null);
            SingleNames = BlittableMarshaller<UnrealSharp.FunctionalTesting.TraceQueryTestNames>.FromNative(IntPtr.Add(InNativeStruct, SingleNames_Offset), 0, null);
            SingleResult = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSingleResult_Offset), 0, null);
            MultiResult = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMultiResult_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.HitResultMarshaler.ToNative(IntPtr.Add(Buffer, SingleHit_Offset), 0, null, SingleHit);
            BlittableMarshaller<UnrealSharp.FunctionalTesting.TraceQueryTestNames>.ToNative(IntPtr.Add(Buffer, SingleNames_Offset), 0, null, SingleNames);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSingleResult_Offset), 0, null, SingleResult);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMultiResult_Offset), 0, null, MultiResult);
        }
    }
}

public static class TraceQueryTestResultsInnerMostMarshaler
{
    public static TraceQueryTestResultsInnerMost FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TraceQueryTestResultsInnerMost(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TraceQueryTestResultsInnerMost obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TraceQueryTestResultsInnerMost.NativeDataSize;
    }
}