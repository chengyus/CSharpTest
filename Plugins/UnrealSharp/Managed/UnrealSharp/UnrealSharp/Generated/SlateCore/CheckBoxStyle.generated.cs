using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct CheckBoxStyle
{
    // ByteProperty /Script/SlateCore.CheckBoxStyle:CheckBoxType
    static readonly int CheckBoxType_Offset;
    public UnrealSharp.SlateCore.ESlateCheckBoxType CheckBoxType;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:UncheckedImage
    static readonly int UncheckedImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush UncheckedImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:UncheckedHoveredImage
    static readonly int UncheckedHoveredImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush UncheckedHoveredImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:UncheckedPressedImage
    static readonly int UncheckedPressedImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush UncheckedPressedImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:CheckedImage
    static readonly int CheckedImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush CheckedImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:CheckedHoveredImage
    static readonly int CheckedHoveredImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush CheckedHoveredImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:CheckedPressedImage
    static readonly int CheckedPressedImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush CheckedPressedImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:UndeterminedImage
    static readonly int UndeterminedImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush UndeterminedImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:UndeterminedHoveredImage
    static readonly int UndeterminedHoveredImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush UndeterminedHoveredImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:UndeterminedPressedImage
    static readonly int UndeterminedPressedImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush UndeterminedPressedImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:Padding
    static readonly int Padding_Offset;
    public UnrealSharp.SlateCore.Margin Padding;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:BackgroundImage
    static readonly int BackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:BackgroundHoveredImage
    static readonly int BackgroundHoveredImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundHoveredImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:BackgroundPressedImage
    static readonly int BackgroundPressedImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundPressedImage;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:ForegroundColor
    static readonly int ForegroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor ForegroundColor;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:HoveredForeground
    static readonly int HoveredForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor HoveredForeground;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:PressedForeground
    static readonly int PressedForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor PressedForeground;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:CheckedForeground
    static readonly int CheckedForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor CheckedForeground;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:CheckedHoveredForeground
    static readonly int CheckedHoveredForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor CheckedHoveredForeground;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:CheckedPressedForeground
    static readonly int CheckedPressedForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor CheckedPressedForeground;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:UndeterminedForeground
    static readonly int UndeterminedForeground_Offset;
    public UnrealSharp.SlateCore.SlateColor UndeterminedForeground;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:BorderBackgroundColor
    static readonly int BorderBackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor BorderBackgroundColor;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:CheckedSlateSound
    static readonly int CheckedSlateSound_Offset;
    public UnrealSharp.SlateCore.SlateSound CheckedSlateSound;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:UncheckedSlateSound
    static readonly int UncheckedSlateSound_Offset;
    public UnrealSharp.SlateCore.SlateSound UncheckedSlateSound;
    
    // StructProperty /Script/SlateCore.CheckBoxStyle:HoveredSlateSound
    static readonly int HoveredSlateSound_Offset;
    public UnrealSharp.SlateCore.SlateSound HoveredSlateSound;
    
    
    public static readonly int NativeDataSize;
    static CheckBoxStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CheckBoxStyle");
        
        CheckBoxType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckBoxType");
        UncheckedImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UncheckedImage");
        UncheckedHoveredImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UncheckedHoveredImage");
        UncheckedPressedImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UncheckedPressedImage");
        CheckedImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckedImage");
        CheckedHoveredImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckedHoveredImage");
        CheckedPressedImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckedPressedImage");
        UndeterminedImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UndeterminedImage");
        UndeterminedHoveredImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UndeterminedHoveredImage");
        UndeterminedPressedImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UndeterminedPressedImage");
        Padding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Padding");
        BackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImage");
        BackgroundHoveredImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundHoveredImage");
        BackgroundPressedImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundPressedImage");
        ForegroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ForegroundColor");
        HoveredForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredForeground");
        PressedForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PressedForeground");
        CheckedForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckedForeground");
        CheckedHoveredForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckedHoveredForeground");
        CheckedPressedForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckedPressedForeground");
        UndeterminedForeground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UndeterminedForeground");
        BorderBackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BorderBackgroundColor");
        CheckedSlateSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckedSlateSound");
        UncheckedSlateSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UncheckedSlateSound");
        HoveredSlateSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredSlateSound");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CheckBoxStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            CheckBoxType = BlittableMarshaller<UnrealSharp.SlateCore.ESlateCheckBoxType>.FromNative(IntPtr.Add(InNativeStruct, CheckBoxType_Offset), 0, null);
            UncheckedImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, UncheckedImage_Offset), 0, null);
            UncheckedHoveredImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, UncheckedHoveredImage_Offset), 0, null);
            UncheckedPressedImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, UncheckedPressedImage_Offset), 0, null);
            CheckedImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, CheckedImage_Offset), 0, null);
            CheckedHoveredImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, CheckedHoveredImage_Offset), 0, null);
            CheckedPressedImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, CheckedPressedImage_Offset), 0, null);
            UndeterminedImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, UndeterminedImage_Offset), 0, null);
            UndeterminedHoveredImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, UndeterminedHoveredImage_Offset), 0, null);
            UndeterminedPressedImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, UndeterminedPressedImage_Offset), 0, null);
            Padding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, Padding_Offset), 0, null);
            BackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImage_Offset), 0, null);
            BackgroundHoveredImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundHoveredImage_Offset), 0, null);
            BackgroundPressedImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundPressedImage_Offset), 0, null);
            ForegroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, ForegroundColor_Offset), 0, null);
            HoveredForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredForeground_Offset), 0, null);
            PressedForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, PressedForeground_Offset), 0, null);
            CheckedForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, CheckedForeground_Offset), 0, null);
            CheckedHoveredForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, CheckedHoveredForeground_Offset), 0, null);
            CheckedPressedForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, CheckedPressedForeground_Offset), 0, null);
            UndeterminedForeground = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, UndeterminedForeground_Offset), 0, null);
            BorderBackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, BorderBackgroundColor_Offset), 0, null);
            CheckedSlateSound = UnrealSharp.SlateCore.SlateSoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, CheckedSlateSound_Offset), 0, null);
            UncheckedSlateSound = UnrealSharp.SlateCore.SlateSoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, UncheckedSlateSound_Offset), 0, null);
            HoveredSlateSound = UnrealSharp.SlateCore.SlateSoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredSlateSound_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.SlateCore.ESlateCheckBoxType>.ToNative(IntPtr.Add(Buffer, CheckBoxType_Offset), 0, null, CheckBoxType);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, UncheckedImage_Offset), 0, null, UncheckedImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, UncheckedHoveredImage_Offset), 0, null, UncheckedHoveredImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, UncheckedPressedImage_Offset), 0, null, UncheckedPressedImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, CheckedImage_Offset), 0, null, CheckedImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, CheckedHoveredImage_Offset), 0, null, CheckedHoveredImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, CheckedPressedImage_Offset), 0, null, CheckedPressedImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, UndeterminedImage_Offset), 0, null, UndeterminedImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, UndeterminedHoveredImage_Offset), 0, null, UndeterminedHoveredImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, UndeterminedPressedImage_Offset), 0, null, UndeterminedPressedImage);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, Padding_Offset), 0, null, Padding);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImage_Offset), 0, null, BackgroundImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundHoveredImage_Offset), 0, null, BackgroundHoveredImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundPressedImage_Offset), 0, null, BackgroundPressedImage);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, ForegroundColor_Offset), 0, null, ForegroundColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, HoveredForeground_Offset), 0, null, HoveredForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, PressedForeground_Offset), 0, null, PressedForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, CheckedForeground_Offset), 0, null, CheckedForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, CheckedHoveredForeground_Offset), 0, null, CheckedHoveredForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, CheckedPressedForeground_Offset), 0, null, CheckedPressedForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, UndeterminedForeground_Offset), 0, null, UndeterminedForeground);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, BorderBackgroundColor_Offset), 0, null, BorderBackgroundColor);
            UnrealSharp.SlateCore.SlateSoundMarshaler.ToNative(IntPtr.Add(Buffer, CheckedSlateSound_Offset), 0, null, CheckedSlateSound);
            UnrealSharp.SlateCore.SlateSoundMarshaler.ToNative(IntPtr.Add(Buffer, UncheckedSlateSound_Offset), 0, null, UncheckedSlateSound);
            UnrealSharp.SlateCore.SlateSoundMarshaler.ToNative(IntPtr.Add(Buffer, HoveredSlateSound_Offset), 0, null, HoveredSlateSound);
        }
    }
}

public static class CheckBoxStyleMarshaler
{
    public static CheckBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CheckBoxStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CheckBoxStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CheckBoxStyle.NativeDataSize;
    }
}