using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct Int32Range
{
    // StructProperty /Script/CoreUObject.Int32Range:LowerBound
    static readonly int LowerBound_Offset;
    public UnrealSharp.CoreUObject.Int32RangeBound LowerBound;
    
    // StructProperty /Script/CoreUObject.Int32Range:UpperBound
    static readonly int UpperBound_Offset;
    public UnrealSharp.CoreUObject.Int32RangeBound UpperBound;
    
    
    public static readonly int NativeDataSize;
    static Int32Range()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("Int32Range");
        
        LowerBound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowerBound");
        UpperBound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpperBound");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public Int32Range(IntPtr InNativeStruct)
    {
        unsafe
        {
            LowerBound = UnrealSharp.CoreUObject.Int32RangeBoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, LowerBound_Offset), 0, null);
            UpperBound = UnrealSharp.CoreUObject.Int32RangeBoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, UpperBound_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.Int32RangeBoundMarshaler.ToNative(IntPtr.Add(Buffer, LowerBound_Offset), 0, null, LowerBound);
            UnrealSharp.CoreUObject.Int32RangeBoundMarshaler.ToNative(IntPtr.Add(Buffer, UpperBound_Offset), 0, null, UpperBound);
        }
    }
}

public static class Int32RangeMarshaler
{
    public static Int32Range FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new Int32Range(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, Int32Range obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return Int32Range.NativeDataSize;
    }
}