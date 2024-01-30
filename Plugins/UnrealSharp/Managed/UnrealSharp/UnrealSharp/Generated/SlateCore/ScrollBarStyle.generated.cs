using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct ScrollBarStyle
{
    // StructProperty /Script/SlateCore.ScrollBarStyle:HorizontalBackgroundImage
    static readonly int HorizontalBackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush HorizontalBackgroundImage;
    
    // StructProperty /Script/SlateCore.ScrollBarStyle:VerticalBackgroundImage
    static readonly int VerticalBackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush VerticalBackgroundImage;
    
    // StructProperty /Script/SlateCore.ScrollBarStyle:VerticalTopSlotImage
    static readonly int VerticalTopSlotImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush VerticalTopSlotImage;
    
    // StructProperty /Script/SlateCore.ScrollBarStyle:HorizontalTopSlotImage
    static readonly int HorizontalTopSlotImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush HorizontalTopSlotImage;
    
    // StructProperty /Script/SlateCore.ScrollBarStyle:VerticalBottomSlotImage
    static readonly int VerticalBottomSlotImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush VerticalBottomSlotImage;
    
    // StructProperty /Script/SlateCore.ScrollBarStyle:HorizontalBottomSlotImage
    static readonly int HorizontalBottomSlotImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush HorizontalBottomSlotImage;
    
    // StructProperty /Script/SlateCore.ScrollBarStyle:NormalThumbImage
    static readonly int NormalThumbImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush NormalThumbImage;
    
    // StructProperty /Script/SlateCore.ScrollBarStyle:HoveredThumbImage
    static readonly int HoveredThumbImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush HoveredThumbImage;
    
    // StructProperty /Script/SlateCore.ScrollBarStyle:DraggedThumbImage
    static readonly int DraggedThumbImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush DraggedThumbImage;
    
    // FloatProperty /Script/SlateCore.ScrollBarStyle:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    
    public static readonly int NativeDataSize;
    static ScrollBarStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ScrollBarStyle");
        
        HorizontalBackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HorizontalBackgroundImage");
        VerticalBackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VerticalBackgroundImage");
        VerticalTopSlotImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VerticalTopSlotImage");
        HorizontalTopSlotImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HorizontalTopSlotImage");
        VerticalBottomSlotImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VerticalBottomSlotImage");
        HorizontalBottomSlotImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HorizontalBottomSlotImage");
        NormalThumbImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalThumbImage");
        HoveredThumbImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredThumbImage");
        DraggedThumbImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DraggedThumbImage");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ScrollBarStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            HorizontalBackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HorizontalBackgroundImage_Offset), 0, null);
            VerticalBackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, VerticalBackgroundImage_Offset), 0, null);
            VerticalTopSlotImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, VerticalTopSlotImage_Offset), 0, null);
            HorizontalTopSlotImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HorizontalTopSlotImage_Offset), 0, null);
            VerticalBottomSlotImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, VerticalBottomSlotImage_Offset), 0, null);
            HorizontalBottomSlotImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HorizontalBottomSlotImage_Offset), 0, null);
            NormalThumbImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, NormalThumbImage_Offset), 0, null);
            HoveredThumbImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredThumbImage_Offset), 0, null);
            DraggedThumbImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DraggedThumbImage_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HorizontalBackgroundImage_Offset), 0, null, HorizontalBackgroundImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, VerticalBackgroundImage_Offset), 0, null, VerticalBackgroundImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, VerticalTopSlotImage_Offset), 0, null, VerticalTopSlotImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HorizontalTopSlotImage_Offset), 0, null, HorizontalTopSlotImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, VerticalBottomSlotImage_Offset), 0, null, VerticalBottomSlotImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HorizontalBottomSlotImage_Offset), 0, null, HorizontalBottomSlotImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, NormalThumbImage_Offset), 0, null, NormalThumbImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HoveredThumbImage_Offset), 0, null, HoveredThumbImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DraggedThumbImage_Offset), 0, null, DraggedThumbImage);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
        }
    }
}

public static class ScrollBarStyleMarshaler
{
    public static ScrollBarStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ScrollBarStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ScrollBarStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ScrollBarStyle.NativeDataSize;
    }
}