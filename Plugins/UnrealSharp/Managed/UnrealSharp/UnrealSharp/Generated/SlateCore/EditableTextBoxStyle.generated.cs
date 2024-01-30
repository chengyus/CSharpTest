using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct EditableTextBoxStyle
{
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:BackgroundImageNormal
    static readonly int BackgroundImageNormal_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImageNormal;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:BackgroundImageHovered
    static readonly int BackgroundImageHovered_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImageHovered;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:BackgroundImageFocused
    static readonly int BackgroundImageFocused_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImageFocused;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:BackgroundImageReadOnly
    static readonly int BackgroundImageReadOnly_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImageReadOnly;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:Padding
    static readonly int Padding_Offset;
    public UnrealSharp.SlateCore.Margin Padding;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:TextStyle
    static readonly int TextStyle_Offset;
    public UnrealSharp.SlateCore.TextBlockStyle TextStyle;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:ForegroundColor
    static readonly int ForegroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor ForegroundColor;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:BackgroundColor
    static readonly int BackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor BackgroundColor;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:ReadOnlyForegroundColor
    static readonly int ReadOnlyForegroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor ReadOnlyForegroundColor;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:FocusedForegroundColor
    static readonly int FocusedForegroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor FocusedForegroundColor;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:HScrollBarPadding
    static readonly int HScrollBarPadding_Offset;
    public UnrealSharp.SlateCore.Margin HScrollBarPadding;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:VScrollBarPadding
    static readonly int VScrollBarPadding_Offset;
    public UnrealSharp.SlateCore.Margin VScrollBarPadding;
    
    // StructProperty /Script/SlateCore.EditableTextBoxStyle:ScrollBarStyle
    static readonly int ScrollBarStyle_Offset;
    public UnrealSharp.SlateCore.ScrollBarStyle ScrollBarStyle;
    
    
    public static readonly int NativeDataSize;
    static EditableTextBoxStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EditableTextBoxStyle");
        
        BackgroundImageNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImageNormal");
        BackgroundImageHovered_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImageHovered");
        BackgroundImageFocused_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImageFocused");
        BackgroundImageReadOnly_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImageReadOnly");
        Padding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Padding");
        TextStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextStyle");
        ForegroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ForegroundColor");
        BackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundColor");
        ReadOnlyForegroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReadOnlyForegroundColor");
        FocusedForegroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FocusedForegroundColor");
        HScrollBarPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HScrollBarPadding");
        VScrollBarPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VScrollBarPadding");
        ScrollBarStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScrollBarStyle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EditableTextBoxStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            BackgroundImageNormal = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImageNormal_Offset), 0, null);
            BackgroundImageHovered = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImageHovered_Offset), 0, null);
            BackgroundImageFocused = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImageFocused_Offset), 0, null);
            BackgroundImageReadOnly = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImageReadOnly_Offset), 0, null);
            Padding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, Padding_Offset), 0, null);
            TextStyle = UnrealSharp.SlateCore.TextBlockStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, TextStyle_Offset), 0, null);
            ForegroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, ForegroundColor_Offset), 0, null);
            BackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundColor_Offset), 0, null);
            ReadOnlyForegroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, ReadOnlyForegroundColor_Offset), 0, null);
            FocusedForegroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, FocusedForegroundColor_Offset), 0, null);
            HScrollBarPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, HScrollBarPadding_Offset), 0, null);
            VScrollBarPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, VScrollBarPadding_Offset), 0, null);
            ScrollBarStyle = UnrealSharp.SlateCore.ScrollBarStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, ScrollBarStyle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImageNormal_Offset), 0, null, BackgroundImageNormal);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImageHovered_Offset), 0, null, BackgroundImageHovered);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImageFocused_Offset), 0, null, BackgroundImageFocused);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImageReadOnly_Offset), 0, null, BackgroundImageReadOnly);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, Padding_Offset), 0, null, Padding);
            UnrealSharp.SlateCore.TextBlockStyleMarshaler.ToNative(IntPtr.Add(Buffer, TextStyle_Offset), 0, null, TextStyle);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, ForegroundColor_Offset), 0, null, ForegroundColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundColor_Offset), 0, null, BackgroundColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, ReadOnlyForegroundColor_Offset), 0, null, ReadOnlyForegroundColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, FocusedForegroundColor_Offset), 0, null, FocusedForegroundColor);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, HScrollBarPadding_Offset), 0, null, HScrollBarPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, VScrollBarPadding_Offset), 0, null, VScrollBarPadding);
            UnrealSharp.SlateCore.ScrollBarStyleMarshaler.ToNative(IntPtr.Add(Buffer, ScrollBarStyle_Offset), 0, null, ScrollBarStyle);
        }
    }
}

public static class EditableTextBoxStyleMarshaler
{
    public static EditableTextBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EditableTextBoxStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EditableTextBoxStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EditableTextBoxStyle.NativeDataSize;
    }
}