using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct FrameNumberRange
{
    // StructProperty /Script/CoreUObject.FrameNumberRange:LowerBound
    static readonly int LowerBound_Offset;
    public UnrealSharp.CoreUObject.FrameNumberRangeBound LowerBound;
    
    // StructProperty /Script/CoreUObject.FrameNumberRange:UpperBound
    static readonly int UpperBound_Offset;
    public UnrealSharp.CoreUObject.FrameNumberRangeBound UpperBound;
    
    
    public static readonly int NativeDataSize;
    static FrameNumberRange()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FrameNumberRange");
        
        LowerBound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowerBound");
        UpperBound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpperBound");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FrameNumberRange(IntPtr InNativeStruct)
    {
        unsafe
        {
            LowerBound = UnrealSharp.CoreUObject.FrameNumberRangeBoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, LowerBound_Offset), 0, null);
            UpperBound = UnrealSharp.CoreUObject.FrameNumberRangeBoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, UpperBound_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.FrameNumberRangeBoundMarshaler.ToNative(IntPtr.Add(Buffer, LowerBound_Offset), 0, null, LowerBound);
            UnrealSharp.CoreUObject.FrameNumberRangeBoundMarshaler.ToNative(IntPtr.Add(Buffer, UpperBound_Offset), 0, null, UpperBound);
        }
    }
}

public static class FrameNumberRangeMarshaler
{
    public static FrameNumberRange FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FrameNumberRange(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FrameNumberRange obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FrameNumberRange.NativeDataSize;
    }
}