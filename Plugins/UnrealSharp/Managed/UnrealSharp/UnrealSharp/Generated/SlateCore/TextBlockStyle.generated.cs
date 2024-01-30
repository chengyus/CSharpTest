using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct TextBlockStyle
{
    // StructProperty /Script/SlateCore.TextBlockStyle:Font
    static readonly int Font_Offset;
    public UnrealSharp.SlateCore.SlateFontInfo Font;
    
    // StructProperty /Script/SlateCore.TextBlockStyle:ColorAndOpacity
    static readonly int ColorAndOpacity_Offset;
    public UnrealSharp.SlateCore.SlateColor ColorAndOpacity;
    
    // StructProperty /Script/SlateCore.TextBlockStyle:ShadowOffset
    static readonly int ShadowOffset_Offset;
    public UnrealSharp.SlateCore.DeprecateSlateVector2D ShadowOffset;
    
    // StructProperty /Script/SlateCore.TextBlockStyle:ShadowColorAndOpacity
    static readonly int ShadowColorAndOpacity_Offset;
    public UnrealSharp.CoreUObject.LinearColor ShadowColorAndOpacity;
    
    // StructProperty /Script/SlateCore.TextBlockStyle:HighlightColor
    static readonly int HighlightColor_Offset;
    public UnrealSharp.SlateCore.SlateColor HighlightColor;
    
    // StructProperty /Script/SlateCore.TextBlockStyle:HighlightShape
    static readonly int HighlightShape_Offset;
    public UnrealSharp.SlateCore.SlateBrush HighlightShape;
    
    // StructProperty /Script/SlateCore.TextBlockStyle:StrikeBrush
    static readonly int StrikeBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush StrikeBrush;
    
    // StructProperty /Script/SlateCore.TextBlockStyle:UnderlineBrush
    static readonly int UnderlineBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush UnderlineBrush;
    
    // EnumProperty /Script/SlateCore.TextBlockStyle:TransformPolicy
    static readonly int TransformPolicy_Offset;
    public UnrealSharp.SlateCore.ETextTransformPolicy TransformPolicy;
    
    // EnumProperty /Script/SlateCore.TextBlockStyle:OverflowPolicy
    static readonly int OverflowPolicy_Offset;
    public UnrealSharp.SlateCore.ETextOverflowPolicy OverflowPolicy;
    
    
    public static readonly int NativeDataSize;
    static TextBlockStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TextBlockStyle");
        
        Font_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Font");
        ColorAndOpacity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorAndOpacity");
        ShadowOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShadowOffset");
        ShadowColorAndOpacity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShadowColorAndOpacity");
        HighlightColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HighlightColor");
        HighlightShape_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HighlightShape");
        StrikeBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StrikeBrush");
        UnderlineBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UnderlineBrush");
        TransformPolicy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TransformPolicy");
        OverflowPolicy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverflowPolicy");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TextBlockStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            Font = UnrealSharp.SlateCore.SlateFontInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, Font_Offset), 0, null);
            ColorAndOpacity = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, ColorAndOpacity_Offset), 0, null);
            ShadowOffset = UnrealSharp.SlateCore.DeprecateSlateVector2DMarshaler.FromNative(IntPtr.Add(InNativeStruct, ShadowOffset_Offset), 0, null);
            ShadowColorAndOpacity = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, ShadowColorAndOpacity_Offset), 0, null);
            HighlightColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, HighlightColor_Offset), 0, null);
            HighlightShape = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HighlightShape_Offset), 0, null);
            StrikeBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, StrikeBrush_Offset), 0, null);
            UnderlineBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, UnderlineBrush_Offset), 0, null);
            TransformPolicy = BlittableMarshaller<UnrealSharp.SlateCore.ETextTransformPolicy>.FromNative(IntPtr.Add(InNativeStruct, TransformPolicy_Offset), 0, null);
            OverflowPolicy = BlittableMarshaller<UnrealSharp.SlateCore.ETextOverflowPolicy>.FromNative(IntPtr.Add(InNativeStruct, OverflowPolicy_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateFontInfoMarshaler.ToNative(IntPtr.Add(Buffer, Font_Offset), 0, null, Font);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, ColorAndOpacity_Offset), 0, null, ColorAndOpacity);
            UnrealSharp.SlateCore.DeprecateSlateVector2DMarshaler.ToNative(IntPtr.Add(Buffer, ShadowOffset_Offset), 0, null, ShadowOffset);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, ShadowColorAndOpacity_Offset), 0, null, ShadowColorAndOpacity);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, HighlightColor_Offset), 0, null, HighlightColor);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HighlightShape_Offset), 0, null, HighlightShape);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, StrikeBrush_Offset), 0, null, StrikeBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, UnderlineBrush_Offset), 0, null, UnderlineBrush);
            BlittableMarshaller<UnrealSharp.SlateCore.ETextTransformPolicy>.ToNative(IntPtr.Add(Buffer, TransformPolicy_Offset), 0, null, TransformPolicy);
            BlittableMarshaller<UnrealSharp.SlateCore.ETextOverflowPolicy>.ToNative(IntPtr.Add(Buffer, OverflowPolicy_Offset), 0, null, OverflowPolicy);
        }
    }
}

public static class TextBlockStyleMarshaler
{
    public static TextBlockStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TextBlockStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TextBlockStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TextBlockStyle.NativeDataSize;
    }
}