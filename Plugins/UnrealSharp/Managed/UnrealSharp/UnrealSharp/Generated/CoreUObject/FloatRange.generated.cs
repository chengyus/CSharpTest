using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct FloatRange
{
    // StructProperty /Script/CoreUObject.FloatRange:LowerBound
    static readonly int LowerBound_Offset;
    public UnrealSharp.CoreUObject.FloatRangeBound LowerBound;
    
    // StructProperty /Script/CoreUObject.FloatRange:UpperBound
    static readonly int UpperBound_Offset;
    public UnrealSharp.CoreUObject.FloatRangeBound UpperBound;
    
    
    public static readonly int NativeDataSize;
    static FloatRange()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FloatRange");
        
        LowerBound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowerBound");
        UpperBound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpperBound");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FloatRange(IntPtr InNativeStruct)
    {
        unsafe
        {
            LowerBound = UnrealSharp.CoreUObject.FloatRangeBoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, LowerBound_Offset), 0, null);
            UpperBound = UnrealSharp.CoreUObject.FloatRangeBoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, UpperBound_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.FloatRangeBoundMarshaler.ToNative(IntPtr.Add(Buffer, LowerBound_Offset), 0, null, LowerBound);
            UnrealSharp.CoreUObject.FloatRangeBoundMarshaler.ToNative(IntPtr.Add(Buffer, UpperBound_Offset), 0, null, UpperBound);
        }
    }
}

public static class FloatRangeMarshaler
{
    public static FloatRange FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FloatRange(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FloatRange obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FloatRange.NativeDataSize;
    }
}