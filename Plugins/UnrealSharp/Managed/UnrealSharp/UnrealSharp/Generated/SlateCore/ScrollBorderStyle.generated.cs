using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct ScrollBorderStyle
{
    // StructProperty /Script/SlateCore.ScrollBorderStyle:TopShadowBrush
    static readonly int TopShadowBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush TopShadowBrush;
    
    // StructProperty /Script/SlateCore.ScrollBorderStyle:BottomShadowBrush
    static readonly int BottomShadowBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BottomShadowBrush;
    
    
    public static readonly int NativeDataSize;
    static ScrollBorderStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ScrollBorderStyle");
        
        TopShadowBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TopShadowBrush");
        BottomShadowBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BottomShadowBrush");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ScrollBorderStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            TopShadowBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, TopShadowBrush_Offset), 0, null);
            BottomShadowBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BottomShadowBrush_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, TopShadowBrush_Offset), 0, null, TopShadowBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BottomShadowBrush_Offset), 0, null, BottomShadowBrush);
        }
    }
}

public static class ScrollBorderStyleMarshaler
{
    public static ScrollBorderStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ScrollBorderStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ScrollBorderStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ScrollBorderStyle.NativeDataSize;
    }
}