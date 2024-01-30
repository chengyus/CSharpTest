using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct ComboButtonStyle
{
    // StructProperty /Script/SlateCore.ComboButtonStyle:ButtonStyle
    static readonly int ButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle ButtonStyle;
    
    // StructProperty /Script/SlateCore.ComboButtonStyle:DownArrowImage
    static readonly int DownArrowImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush DownArrowImage;
    
    // StructProperty /Script/SlateCore.ComboButtonStyle:ShadowOffset
    static readonly int ShadowOffset_Offset;
    public UnrealSharp.SlateCore.DeprecateSlateVector2D ShadowOffset;
    
    // StructProperty /Script/SlateCore.ComboButtonStyle:ShadowColorAndOpacity
    static readonly int ShadowColorAndOpacity_Offset;
    public UnrealSharp.CoreUObject.LinearColor ShadowColorAndOpacity;
    
    // StructProperty /Script/SlateCore.ComboButtonStyle:MenuBorderBrush
    static readonly int MenuBorderBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush MenuBorderBrush;
    
    // StructProperty /Script/SlateCore.ComboButtonStyle:MenuBorderPadding
    static readonly int MenuBorderPadding_Offset;
    public UnrealSharp.SlateCore.Margin MenuBorderPadding;
    
    // StructProperty /Script/SlateCore.ComboButtonStyle:ContentPadding
    static readonly int ContentPadding_Offset;
    public UnrealSharp.SlateCore.Margin ContentPadding;
    
    // StructProperty /Script/SlateCore.ComboButtonStyle:DownArrowPadding
    static readonly int DownArrowPadding_Offset;
    public UnrealSharp.SlateCore.Margin DownArrowPadding;
    
    // ByteProperty /Script/SlateCore.ComboButtonStyle:DownArrowAlign
    static readonly int DownArrowAlign_Offset;
    public UnrealSharp.SlateCore.EVerticalAlignment DownArrowAlign;
    
    
    public static readonly int NativeDataSize;
    static ComboButtonStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ComboButtonStyle");
        
        ButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ButtonStyle");
        DownArrowImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DownArrowImage");
        ShadowOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShadowOffset");
        ShadowColorAndOpacity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShadowColorAndOpacity");
        MenuBorderBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MenuBorderBrush");
        MenuBorderPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MenuBorderPadding");
        ContentPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ContentPadding");
        DownArrowPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DownArrowPadding");
        DownArrowAlign_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DownArrowAlign");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ComboButtonStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            ButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, ButtonStyle_Offset), 0, null);
            DownArrowImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DownArrowImage_Offset), 0, null);
            ShadowOffset = UnrealSharp.SlateCore.DeprecateSlateVector2DMarshaler.FromNative(IntPtr.Add(InNativeStruct, ShadowOffset_Offset), 0, null);
            ShadowColorAndOpacity = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, ShadowColorAndOpacity_Offset), 0, null);
            MenuBorderBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, MenuBorderBrush_Offset), 0, null);
            MenuBorderPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, MenuBorderPadding_Offset), 0, null);
            ContentPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, ContentPadding_Offset), 0, null);
            DownArrowPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, DownArrowPadding_Offset), 0, null);
            DownArrowAlign = BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.FromNative(IntPtr.Add(InNativeStruct, DownArrowAlign_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, ButtonStyle_Offset), 0, null, ButtonStyle);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DownArrowImage_Offset), 0, null, DownArrowImage);
            UnrealSharp.SlateCore.DeprecateSlateVector2DMarshaler.ToNative(IntPtr.Add(Buffer, ShadowOffset_Offset), 0, null, ShadowOffset);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, ShadowColorAndOpacity_Offset), 0, null, ShadowColorAndOpacity);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, MenuBorderBrush_Offset), 0, null, MenuBorderBrush);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, MenuBorderPadding_Offset), 0, null, MenuBorderPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, ContentPadding_Offset), 0, null, ContentPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, DownArrowPadding_Offset), 0, null, DownArrowPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.ToNative(IntPtr.Add(Buffer, DownArrowAlign_Offset), 0, null, DownArrowAlign);
        }
    }
}

public static class ComboButtonStyleMarshaler
{
    public static ComboButtonStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ComboButtonStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ComboButtonStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ComboButtonStyle.NativeDataSize;
    }
}