using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.WidgetCarousel;

[UStruct]
public partial struct WidgetCarouselNavigationBarStyle
{
    // StructProperty /Script/WidgetCarousel.WidgetCarouselNavigationBarStyle:HighlightBrush
    static readonly int HighlightBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush HighlightBrush;
    
    // StructProperty /Script/WidgetCarousel.WidgetCarouselNavigationBarStyle:LeftButtonStyle
    static readonly int LeftButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle LeftButtonStyle;
    
    // StructProperty /Script/WidgetCarousel.WidgetCarouselNavigationBarStyle:CenterButtonStyle
    static readonly int CenterButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle CenterButtonStyle;
    
    // StructProperty /Script/WidgetCarousel.WidgetCarouselNavigationBarStyle:RightButtonStyle
    static readonly int RightButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle RightButtonStyle;
    
    
    public static readonly int NativeDataSize;
    static WidgetCarouselNavigationBarStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WidgetCarouselNavigationBarStyle");
        
        HighlightBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HighlightBrush");
        LeftButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeftButtonStyle");
        CenterButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CenterButtonStyle");
        RightButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RightButtonStyle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WidgetCarouselNavigationBarStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            HighlightBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HighlightBrush_Offset), 0, null);
            LeftButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, LeftButtonStyle_Offset), 0, null);
            CenterButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, CenterButtonStyle_Offset), 0, null);
            RightButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, RightButtonStyle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HighlightBrush_Offset), 0, null, HighlightBrush);
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, LeftButtonStyle_Offset), 0, null, LeftButtonStyle);
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, CenterButtonStyle_Offset), 0, null, CenterButtonStyle);
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, RightButtonStyle_Offset), 0, null, RightButtonStyle);
        }
    }
}

public static class WidgetCarouselNavigationBarStyleMarshaler
{
    public static WidgetCarouselNavigationBarStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WidgetCarouselNavigationBarStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WidgetCarouselNavigationBarStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WidgetCarouselNavigationBarStyle.NativeDataSize;
    }
}