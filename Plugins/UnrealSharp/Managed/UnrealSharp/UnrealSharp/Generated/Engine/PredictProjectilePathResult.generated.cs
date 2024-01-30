using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct PredictProjectilePathResult
{
    // StructProperty /Script/Engine.PredictProjectilePathResult:LastTraceDestination
    static readonly int LastTraceDestination_Offset;
    public UnrealSharp.Engine.PredictProjectilePathPointData LastTraceDestination;
    
    // StructProperty /Script/Engine.PredictProjectilePathResult:HitResult
    static readonly int HitResult_Offset;
    public UnrealSharp.Engine.HitResult HitResult;
    
    
    public static readonly int NativeDataSize;
    static PredictProjectilePathResult()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PredictProjectilePathResult");
        
        LastTraceDestination_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LastTraceDestination");
        HitResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitResult");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PredictProjectilePathResult(IntPtr InNativeStruct)
    {
        unsafe
        {
            LastTraceDestination = UnrealSharp.Engine.PredictProjectilePathPointDataMarshaler.FromNative(IntPtr.Add(InNativeStruct, LastTraceDestination_Offset), 0, null);
            HitResult = UnrealSharp.Engine.HitResultMarshaler.FromNative(IntPtr.Add(InNativeStruct, HitResult_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PredictProjectilePathPointDataMarshaler.ToNative(IntPtr.Add(Buffer, LastTraceDestination_Offset), 0, null, LastTraceDestination);
            UnrealSharp.Engine.HitResultMarshaler.ToNative(IntPtr.Add(Buffer, HitResult_Offset), 0, null, HitResult);
        }
    }
}

public static class PredictProjectilePathResultMarshaler
{
    public static PredictProjectilePathResult FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PredictProjectilePathResult(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PredictProjectilePathResult obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PredictProjectilePathResult.NativeDataSize;
    }
}