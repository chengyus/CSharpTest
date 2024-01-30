using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct WindowStyle
{
    // StructProperty /Script/SlateCore.WindowStyle:MinimizeButtonStyle
    static readonly int MinimizeButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle MinimizeButtonStyle;
    
    // StructProperty /Script/SlateCore.WindowStyle:MaximizeButtonStyle
    static readonly int MaximizeButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle MaximizeButtonStyle;
    
    // StructProperty /Script/SlateCore.WindowStyle:RestoreButtonStyle
    static readonly int RestoreButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle RestoreButtonStyle;
    
    // StructProperty /Script/SlateCore.WindowStyle:CloseButtonStyle
    static readonly int CloseButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle CloseButtonStyle;
    
    // StructProperty /Script/SlateCore.WindowStyle:TitleTextStyle
    static readonly int TitleTextStyle_Offset;
    public UnrealSharp.SlateCore.TextBlockStyle TitleTextStyle;
    
    // StructProperty /Script/SlateCore.WindowStyle:ActiveTitleBrush
    static readonly int ActiveTitleBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ActiveTitleBrush;
    
    // StructProperty /Script/SlateCore.WindowStyle:InactiveTitleBrush
    static readonly int InactiveTitleBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush InactiveTitleBrush;
    
    // StructProperty /Script/SlateCore.WindowStyle:FlashTitleBrush
    static readonly int FlashTitleBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush FlashTitleBrush;
    
    // StructProperty /Script/SlateCore.WindowStyle:BackgroundColor
    static readonly int BackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor BackgroundColor;
    
    // StructProperty /Script/SlateCore.WindowStyle:OutlineBrush
    static readonly int OutlineBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush OutlineBrush;
    
    // StructProperty /Script/SlateCore.WindowStyle:OutlineColor
    static readonly int OutlineColor_Offset;
    public UnrealSharp.SlateCore.SlateColor OutlineColor;
    
    // StructProperty /Script/SlateCore.WindowStyle:BorderBrush
    static readonly int BorderBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BorderBrush;
    
    // StructProperty /Script/SlateCore.WindowStyle:BorderColor
    static readonly int BorderColor_Offset;
    public UnrealSharp.SlateCore.SlateColor BorderColor;
    
    // StructProperty /Script/SlateCore.WindowStyle:BackgroundBrush
    static readonly int BackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundBrush;
    
    // StructProperty /Script/SlateCore.WindowStyle:ChildBackgroundBrush
    static readonly int ChildBackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ChildBackgroundBrush;
    
    // IntProperty /Script/SlateCore.WindowStyle:WindowCornerRadius
    static readonly int WindowCornerRadius_Offset;
    public int WindowCornerRadius;
    
    // StructProperty /Script/SlateCore.WindowStyle:BorderPadding
    static readonly int BorderPadding_Offset;
    public UnrealSharp.SlateCore.Margin BorderPadding;
    
    
    public static readonly int NativeDataSize;
    static WindowStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WindowStyle");
        
        MinimizeButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinimizeButtonStyle");
        MaximizeButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaximizeButtonStyle");
        RestoreButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RestoreButtonStyle");
        CloseButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CloseButtonStyle");
        TitleTextStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TitleTextStyle");
        ActiveTitleBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveTitleBrush");
        InactiveTitleBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InactiveTitleBrush");
        FlashTitleBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FlashTitleBrush");
        BackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundColor");
        OutlineBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutlineBrush");
        OutlineColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutlineColor");
        BorderBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BorderBrush");
        BorderColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BorderColor");
        BackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundBrush");
        ChildBackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChildBackgroundBrush");
        WindowCornerRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WindowCornerRadius");
        BorderPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BorderPadding");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WindowStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            MinimizeButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, MinimizeButtonStyle_Offset), 0, null);
            MaximizeButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, MaximizeButtonStyle_Offset), 0, null);
            RestoreButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, RestoreButtonStyle_Offset), 0, null);
            CloseButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, CloseButtonStyle_Offset), 0, null);
            TitleTextStyle = UnrealSharp.SlateCore.TextBlockStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, TitleTextStyle_Offset), 0, null);
            ActiveTitleBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ActiveTitleBrush_Offset), 0, null);
            InactiveTitleBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, InactiveTitleBrush_Offset), 0, null);
            FlashTitleBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, FlashTitleBrush_Offset), 0, null);
            BackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundColor_Offset), 0, null);
            OutlineBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, OutlineBrush_Offset), 0, null);
            OutlineColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, OutlineColor_Offset), 0, null);
            BorderBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BorderBrush_Offset), 0, null);
            BorderColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, BorderColor_Offset), 0, null);
            BackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundBrush_Offset), 0, null);
            ChildBackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ChildBackgroundBrush_Offset), 0, null);
            WindowCornerRadius = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, WindowCornerRadius_Offset), 0, null);
            BorderPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, BorderPadding_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, MinimizeButtonStyle_Offset), 0, null, MinimizeButtonStyle);
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, MaximizeButtonStyle_Offset), 0, null, MaximizeButtonStyle);
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, RestoreButtonStyle_Offset), 0, null, RestoreButtonStyle);
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, CloseButtonStyle_Offset), 0, null, CloseButtonStyle);
            UnrealSharp.SlateCore.TextBlockStyleMarshaler.ToNative(IntPtr.Add(Buffer, TitleTextStyle_Offset), 0, null, TitleTextStyle);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ActiveTitleBrush_Offset), 0, null, ActiveTitleBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, InactiveTitleBrush_Offset), 0, null, InactiveTitleBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, FlashTitleBrush_Offset), 0, null, FlashTitleBrush);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundColor_Offset), 0, null, BackgroundColor);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, OutlineBrush_Offset), 0, null, OutlineBrush);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, OutlineColor_Offset), 0, null, OutlineColor);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BorderBrush_Offset), 0, null, BorderBrush);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, BorderColor_Offset), 0, null, BorderColor);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundBrush_Offset), 0, null, BackgroundBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ChildBackgroundBrush_Offset), 0, null, ChildBackgroundBrush);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, WindowCornerRadius_Offset), 0, null, WindowCornerRadius);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, BorderPadding_Offset), 0, null, BorderPadding);
        }
    }
}

public static class WindowStyleMarshaler
{
    public static WindowStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WindowStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WindowStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WindowStyle.NativeDataSize;
    }
}