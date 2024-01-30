using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct ScrollBoxStyle
{
    // FloatProperty /Script/SlateCore.ScrollBoxStyle:BarThickness
    static readonly int BarThickness_Offset;
    public float BarThickness;
    
    // StructProperty /Script/SlateCore.ScrollBoxStyle:TopShadowBrush
    static readonly int TopShadowBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush TopShadowBrush;
    
    // StructProperty /Script/SlateCore.ScrollBoxStyle:BottomShadowBrush
    static readonly int BottomShadowBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BottomShadowBrush;
    
    // StructProperty /Script/SlateCore.ScrollBoxStyle:LeftShadowBrush
    static readonly int LeftShadowBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush LeftShadowBrush;
    
    // StructProperty /Script/SlateCore.ScrollBoxStyle:RightShadowBrush
    static readonly int RightShadowBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush RightShadowBrush;
    
    // StructProperty /Script/SlateCore.ScrollBoxStyle:HorizontalScrolledContentPadding
    static readonly int HorizontalScrolledContentPadding_Offset;
    public UnrealSharp.SlateCore.Margin HorizontalScrolledContentPadding;
    
    // StructProperty /Script/SlateCore.ScrollBoxStyle:VerticalScrolledContentPadding
    static readonly int VerticalScrolledContentPadding_Offset;
    public UnrealSharp.SlateCore.Margin VerticalScrolledContentPadding;
    
    
    public static readonly int NativeDataSize;
    static ScrollBoxStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ScrollBoxStyle");
        
        BarThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BarThickness");
        TopShadowBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TopShadowBrush");
        BottomShadowBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BottomShadowBrush");
        LeftShadowBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeftShadowBrush");
        RightShadowBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RightShadowBrush");
        HorizontalScrolledContentPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HorizontalScrolledContentPadding");
        VerticalScrolledContentPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VerticalScrolledContentPadding");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ScrollBoxStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            BarThickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BarThickness_Offset), 0, null);
            TopShadowBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, TopShadowBrush_Offset), 0, null);
            BottomShadowBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BottomShadowBrush_Offset), 0, null);
            LeftShadowBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, LeftShadowBrush_Offset), 0, null);
            RightShadowBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, RightShadowBrush_Offset), 0, null);
            HorizontalScrolledContentPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, HorizontalScrolledContentPadding_Offset), 0, null);
            VerticalScrolledContentPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, VerticalScrolledContentPadding_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BarThickness_Offset), 0, null, BarThickness);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, TopShadowBrush_Offset), 0, null, TopShadowBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BottomShadowBrush_Offset), 0, null, BottomShadowBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, LeftShadowBrush_Offset), 0, null, LeftShadowBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, RightShadowBrush_Offset), 0, null, RightShadowBrush);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, HorizontalScrolledContentPadding_Offset), 0, null, HorizontalScrolledContentPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, VerticalScrolledContentPadding_Offset), 0, null, VerticalScrolledContentPadding);
        }
    }
}

public static class ScrollBoxStyleMarshaler
{
    public static ScrollBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ScrollBoxStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ScrollBoxStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ScrollBoxStyle.NativeDataSize;
    }
}