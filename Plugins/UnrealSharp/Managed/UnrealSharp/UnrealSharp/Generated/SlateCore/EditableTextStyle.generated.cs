using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct EditableTextStyle
{
    // StructProperty /Script/SlateCore.EditableTextStyle:Font
    static readonly int Font_Offset;
    public UnrealSharp.SlateCore.SlateFontInfo Font;
    
    // StructProperty /Script/SlateCore.EditableTextStyle:ColorAndOpacity
    static readonly int ColorAndOpacity_Offset;
    public UnrealSharp.SlateCore.SlateColor ColorAndOpacity;
    
    // StructProperty /Script/SlateCore.EditableTextStyle:BackgroundImageSelected
    static readonly int BackgroundImageSelected_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImageSelected;
    
    // StructProperty /Script/SlateCore.EditableTextStyle:BackgroundImageComposing
    static readonly int BackgroundImageComposing_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImageComposing;
    
    // StructProperty /Script/SlateCore.EditableTextStyle:CaretImage
    static readonly int CaretImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush CaretImage;
    
    
    public static readonly int NativeDataSize;
    static EditableTextStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EditableTextStyle");
        
        Font_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Font");
        ColorAndOpacity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorAndOpacity");
        BackgroundImageSelected_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImageSelected");
        BackgroundImageComposing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImageComposing");
        CaretImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CaretImage");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EditableTextStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            Font = UnrealSharp.SlateCore.SlateFontInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, Font_Offset), 0, null);
            ColorAndOpacity = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, ColorAndOpacity_Offset), 0, null);
            BackgroundImageSelected = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImageSelected_Offset), 0, null);
            BackgroundImageComposing = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImageComposing_Offset), 0, null);
            CaretImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, CaretImage_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateFontInfoMarshaler.ToNative(IntPtr.Add(Buffer, Font_Offset), 0, null, Font);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, ColorAndOpacity_Offset), 0, null, ColorAndOpacity);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImageSelected_Offset), 0, null, BackgroundImageSelected);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImageComposing_Offset), 0, null, BackgroundImageComposing);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, CaretImage_Offset), 0, null, CaretImage);
        }
    }
}

public static class EditableTextStyleMarshaler
{
    public static EditableTextStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EditableTextStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EditableTextStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EditableTextStyle.NativeDataSize;
    }
}