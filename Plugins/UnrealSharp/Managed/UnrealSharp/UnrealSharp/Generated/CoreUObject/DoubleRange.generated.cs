using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct DoubleRange
{
    // StructProperty /Script/CoreUObject.DoubleRange:LowerBound
    static readonly int LowerBound_Offset;
    public UnrealSharp.CoreUObject.DoubleRangeBound LowerBound;
    
    // StructProperty /Script/CoreUObject.DoubleRange:UpperBound
    static readonly int UpperBound_Offset;
    public UnrealSharp.CoreUObject.DoubleRangeBound UpperBound;
    
    
    public static readonly int NativeDataSize;
    static DoubleRange()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DoubleRange");
        
        LowerBound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowerBound");
        UpperBound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpperBound");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DoubleRange(IntPtr InNativeStruct)
    {
        unsafe
        {
            LowerBound = UnrealSharp.CoreUObject.DoubleRangeBoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, LowerBound_Offset), 0, null);
            UpperBound = UnrealSharp.CoreUObject.DoubleRangeBoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, UpperBound_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.DoubleRangeBoundMarshaler.ToNative(IntPtr.Add(Buffer, LowerBound_Offset), 0, null, LowerBound);
            UnrealSharp.CoreUObject.DoubleRangeBoundMarshaler.ToNative(IntPtr.Add(Buffer, UpperBound_Offset), 0, null, UpperBound);
        }
    }
}

public static class DoubleRangeMarshaler
{
    public static DoubleRange FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DoubleRange(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DoubleRange obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DoubleRange.NativeDataSize;
    }
}