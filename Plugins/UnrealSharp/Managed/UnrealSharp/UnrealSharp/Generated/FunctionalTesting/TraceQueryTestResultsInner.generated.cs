using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct]
public partial struct TraceQueryTestResultsInner
{
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResultsInner:LineResults
    static readonly int LineResults_Offset;
    public UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMost LineResults;
    
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResultsInner:SphereResults
    static readonly int SphereResults_Offset;
    public UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMost SphereResults;
    
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResultsInner:CapsuleResults
    static readonly int CapsuleResults_Offset;
    public UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMost CapsuleResults;
    
    // StructProperty /Script/FunctionalTesting.TraceQueryTestResultsInner:BoxResults
    static readonly int BoxResults_Offset;
    public UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMost BoxResults;
    
    
    public static readonly int NativeDataSize;
    static TraceQueryTestResultsInner()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TraceQueryTestResultsInner");
        
        LineResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LineResults");
        SphereResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SphereResults");
        CapsuleResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CapsuleResults");
        BoxResults_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoxResults");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TraceQueryTestResultsInner(IntPtr InNativeStruct)
    {
        unsafe
        {
            LineResults = UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMostMarshaler.FromNative(IntPtr.Add(InNativeStruct, LineResults_Offset), 0, null);
            SphereResults = UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMostMarshaler.FromNative(IntPtr.Add(InNativeStruct, SphereResults_Offset), 0, null);
            CapsuleResults = UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMostMarshaler.FromNative(IntPtr.Add(InNativeStruct, CapsuleResults_Offset), 0, null);
            BoxResults = UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMostMarshaler.FromNative(IntPtr.Add(InNativeStruct, BoxResults_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMostMarshaler.ToNative(IntPtr.Add(Buffer, LineResults_Offset), 0, null, LineResults);
            UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMostMarshaler.ToNative(IntPtr.Add(Buffer, SphereResults_Offset), 0, null, SphereResults);
            UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMostMarshaler.ToNative(IntPtr.Add(Buffer, CapsuleResults_Offset), 0, null, CapsuleResults);
            UnrealSharp.FunctionalTesting.TraceQueryTestResultsInnerMostMarshaler.ToNative(IntPtr.Add(Buffer, BoxResults_Offset), 0, null, BoxResults);
        }
    }
}

public static class TraceQueryTestResultsInnerMarshaler
{
    public static TraceQueryTestResultsInner FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TraceQueryTestResultsInner(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TraceQueryTestResultsInner obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TraceQueryTestResultsInner.NativeDataSize;
    }
}