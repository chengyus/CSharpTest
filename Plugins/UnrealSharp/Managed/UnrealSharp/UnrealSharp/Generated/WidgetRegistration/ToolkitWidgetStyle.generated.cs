using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.WidgetRegistration;

[UStruct]
public partial struct ToolkitWidgetStyle
{
    // StructProperty /Script/WidgetRegistration.ToolkitWidgetStyle:TitleBackgroundBrush
    static readonly int TitleBackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush TitleBackgroundBrush;
    
    // StructProperty /Script/WidgetRegistration.ToolkitWidgetStyle:ToolDetailsBackgroundBrush
    static readonly int ToolDetailsBackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ToolDetailsBackgroundBrush;
    
    // StructProperty /Script/WidgetRegistration.ToolkitWidgetStyle:TitleForegroundColor
    static readonly int TitleForegroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor TitleForegroundColor;
    
    // StructProperty /Script/WidgetRegistration.ToolkitWidgetStyle:TitlePadding
    static readonly int TitlePadding_Offset;
    public UnrealSharp.SlateCore.Margin TitlePadding;
    
    // StructProperty /Script/WidgetRegistration.ToolkitWidgetStyle:ActiveToolTitleBorderPadding
    static readonly int ActiveToolTitleBorderPadding_Offset;
    public UnrealSharp.SlateCore.Margin ActiveToolTitleBorderPadding;
    
    // StructProperty /Script/WidgetRegistration.ToolkitWidgetStyle:ToolContextTextBlockPadding
    static readonly int ToolContextTextBlockPadding_Offset;
    public UnrealSharp.SlateCore.Margin ToolContextTextBlockPadding;
    
    // StructProperty /Script/WidgetRegistration.ToolkitWidgetStyle:TitleFont
    static readonly int TitleFont_Offset;
    public UnrealSharp.SlateCore.SlateFontInfo TitleFont;
    
    
    public static readonly int NativeDataSize;
    static ToolkitWidgetStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ToolkitWidgetStyle");
        
        TitleBackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TitleBackgroundBrush");
        ToolDetailsBackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ToolDetailsBackgroundBrush");
        TitleForegroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TitleForegroundColor");
        TitlePadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TitlePadding");
        ActiveToolTitleBorderPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveToolTitleBorderPadding");
        ToolContextTextBlockPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ToolContextTextBlockPadding");
        TitleFont_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TitleFont");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ToolkitWidgetStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            TitleBackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, TitleBackgroundBrush_Offset), 0, null);
            ToolDetailsBackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ToolDetailsBackgroundBrush_Offset), 0, null);
            TitleForegroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, TitleForegroundColor_Offset), 0, null);
            TitlePadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, TitlePadding_Offset), 0, null);
            ActiveToolTitleBorderPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, ActiveToolTitleBorderPadding_Offset), 0, null);
            ToolContextTextBlockPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, ToolContextTextBlockPadding_Offset), 0, null);
            TitleFont = UnrealSharp.SlateCore.SlateFontInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, TitleFont_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, TitleBackgroundBrush_Offset), 0, null, TitleBackgroundBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ToolDetailsBackgroundBrush_Offset), 0, null, ToolDetailsBackgroundBrush);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, TitleForegroundColor_Offset), 0, null, TitleForegroundColor);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, TitlePadding_Offset), 0, null, TitlePadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, ActiveToolTitleBorderPadding_Offset), 0, null, ActiveToolTitleBorderPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, ToolContextTextBlockPadding_Offset), 0, null, ToolContextTextBlockPadding);
            UnrealSharp.SlateCore.SlateFontInfoMarshaler.ToNative(IntPtr.Add(Buffer, TitleFont_Offset), 0, null, TitleFont);
        }
    }
}

public static class ToolkitWidgetStyleMarshaler
{
    public static ToolkitWidgetStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ToolkitWidgetStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ToolkitWidgetStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ToolkitWidgetStyle.NativeDataSize;
    }
}