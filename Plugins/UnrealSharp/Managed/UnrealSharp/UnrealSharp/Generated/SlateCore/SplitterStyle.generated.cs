using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SplitterStyle
{
    // StructProperty /Script/SlateCore.SplitterStyle:HandleNormalBrush
    static readonly int HandleNormalBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush HandleNormalBrush;
    
    // StructProperty /Script/SlateCore.SplitterStyle:HandleHighlightBrush
    static readonly int HandleHighlightBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush HandleHighlightBrush;
    
    
    public static readonly int NativeDataSize;
    static SplitterStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SplitterStyle");
        
        HandleNormalBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HandleNormalBrush");
        HandleHighlightBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HandleHighlightBrush");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SplitterStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            HandleNormalBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HandleNormalBrush_Offset), 0, null);
            HandleHighlightBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HandleHighlightBrush_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HandleNormalBrush_Offset), 0, null, HandleNormalBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HandleHighlightBrush_Offset), 0, null, HandleHighlightBrush);
        }
    }
}

public static class SplitterStyleMarshaler
{
    public static SplitterStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SplitterStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SplitterStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SplitterStyle.NativeDataSize;
    }
}