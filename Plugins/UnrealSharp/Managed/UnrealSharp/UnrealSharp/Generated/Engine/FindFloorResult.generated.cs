using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct FindFloorResult
{
    // BoolProperty /Script/Engine.FindFloorResult:bBlockingHit
    static readonly int bBlockingHit_Offset;
    static readonly IntPtr bBlockingHit_NativeProperty;
    public bool BlockingHit;
    
    // BoolProperty /Script/Engine.FindFloorResult:bWalkableFloor
    static readonly int bWalkableFloor_Offset;
    static readonly IntPtr bWalkableFloor_NativeProperty;
    public bool WalkableFloor;
    
    // BoolProperty /Script/Engine.FindFloorResult:bLineTrace
    static readonly int bLineTrace_Offset;
    static readonly IntPtr bLineTrace_NativeProperty;
    public bool LineTrace;
    
    // FloatProperty /Script/Engine.FindFloorResult:FloorDist
    static readonly int FloorDist_Offset;
    public float FloorDist;
    
    // FloatProperty /Script/Engine.FindFloorResult:LineDist
    static readonly int LineDist_Offset;
    public float LineDist;
    
    // StructProperty /Script/Engine.FindFloorResult:HitResult
    static readonly int HitResult_Offset;
    public UnrealSharp.Engine.HitResult HitResult;
    
    
    public static readonly int NativeDataSize;
    static FindFloorResult()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FindFloorResult");
        
        bBlockingHit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bBlockingHit");
        bBlockingHit_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bBlockingHit");
        bWalkableFloor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bWalkableFloor");
        bWalkableFloor_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bWalkableFloor");
        bLineTrace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLineTrace");
        bLineTrace_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLineTrace");
        FloorDist_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FloorDist");
        LineDist_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LineDist");
        HitResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitResult");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FindFloorResult(IntPtr InNativeStruct)
    {
        unsafe
        {
            BlockingHit = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bBlockingHit_NativeProperty, bBlockingHit_Offset);
            WalkableFloor = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bWalkableFloor_NativeProperty, bWalkableFloor_Offset);
            LineTrace = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bLineTrace_NativeProperty, bLineTrace_Offset);
            FloorDist = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FloorDist_Offset), 0, null);
            LineDist = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LineDist_Offset), 0, null);
            HitResult = UnrealSharp.Engine.HitResultMarshaler.FromNative(IntPtr.Add(InNativeStruct, HitResult_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bBlockingHit_NativeProperty, bBlockingHit_Offset, BlockingHit);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bWalkableFloor_NativeProperty, bWalkableFloor_Offset, WalkableFloor);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bLineTrace_NativeProperty, bLineTrace_Offset, LineTrace);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FloorDist_Offset), 0, null, FloorDist);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LineDist_Offset), 0, null, LineDist);
            UnrealSharp.Engine.HitResultMarshaler.ToNative(IntPtr.Add(Buffer, HitResult_Offset), 0, null, HitResult);
        }
    }
}

public static class FindFloorResultMarshaler
{
    public static FindFloorResult FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FindFloorResult(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FindFloorResult obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FindFloorResult.NativeDataSize;
    }
}