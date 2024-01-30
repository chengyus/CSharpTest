using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationCore;

[UStruct]
public partial struct FilterOptionPerAxis
{
    // BoolProperty /Script/AnimationCore.FilterOptionPerAxis:bX
    static readonly int bX_Offset;
    public bool X;
    
    // BoolProperty /Script/AnimationCore.FilterOptionPerAxis:bY
    static readonly int bY_Offset;
    public bool Y;
    
    // BoolProperty /Script/AnimationCore.FilterOptionPerAxis:bZ
    static readonly int bZ_Offset;
    public bool Z;
    
    
    public static readonly int NativeDataSize;
    static FilterOptionPerAxis()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FilterOptionPerAxis");
        
        bX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bX");
        bY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bY");
        bZ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bZ");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FilterOptionPerAxis(IntPtr InNativeStruct)
    {
        unsafe
        {
            X = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bX_Offset), 0, null);
            Y = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bY_Offset), 0, null);
            Z = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bZ_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bX_Offset), 0, null, X);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bY_Offset), 0, null, Y);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bZ_Offset), 0, null, Z);
        }
    }
}

public static class FilterOptionPerAxisMarshaler
{
    public static FilterOptionPerAxis FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FilterOptionPerAxis(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FilterOptionPerAxis obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FilterOptionPerAxis.NativeDataSize;
    }
}