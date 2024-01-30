using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct]
public partial struct FixedSampleSequenceRulerStyle
{
    // FloatProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:HandleWidth
    static readonly int HandleWidth_Offset;
    public float HandleWidth;
    
    // StructProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:HandleColor
    static readonly int HandleColor_Offset;
    public UnrealSharp.SlateCore.SlateColor HandleColor;
    
    // StructProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:HandleBrush
    static readonly int HandleBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush HandleBrush;
    
    // StructProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:TicksColor
    static readonly int TicksColor_Offset;
    public UnrealSharp.SlateCore.SlateColor TicksColor;
    
    // StructProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:TicksTextColor
    static readonly int TicksTextColor_Offset;
    public UnrealSharp.SlateCore.SlateColor TicksTextColor;
    
    // StructProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:TicksTextFont
    static readonly int TicksTextFont_Offset;
    public UnrealSharp.SlateCore.SlateFontInfo TicksTextFont;
    
    // FloatProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:TicksTextOffset
    static readonly int TicksTextOffset_Offset;
    public float TicksTextOffset;
    
    // StructProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:BackgroundColor
    static readonly int BackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor BackgroundColor;
    
    // StructProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:BackgroundBrush
    static readonly int BackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundBrush;
    
    // FloatProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:DesiredWidth
    static readonly int DesiredWidth_Offset;
    public float DesiredWidth;
    
    // FloatProperty /Script/AudioWidgets.FixedSampleSequenceRulerStyle:DesiredHeight
    static readonly int DesiredHeight_Offset;
    public float DesiredHeight;
    
    
    public static readonly int NativeDataSize;
    static FixedSampleSequenceRulerStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FixedSampleSequenceRulerStyle");
        
        HandleWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HandleWidth");
        HandleColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HandleColor");
        HandleBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HandleBrush");
        TicksColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TicksColor");
        TicksTextColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TicksTextColor");
        TicksTextFont_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TicksTextFont");
        TicksTextOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TicksTextOffset");
        BackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundColor");
        BackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundBrush");
        DesiredWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DesiredWidth");
        DesiredHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DesiredHeight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FixedSampleSequenceRulerStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            HandleWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HandleWidth_Offset), 0, null);
            HandleColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, HandleColor_Offset), 0, null);
            HandleBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HandleBrush_Offset), 0, null);
            TicksColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, TicksColor_Offset), 0, null);
            TicksTextColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, TicksTextColor_Offset), 0, null);
            TicksTextFont = UnrealSharp.SlateCore.SlateFontInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, TicksTextFont_Offset), 0, null);
            TicksTextOffset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TicksTextOffset_Offset), 0, null);
            BackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundColor_Offset), 0, null);
            BackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundBrush_Offset), 0, null);
            DesiredWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DesiredWidth_Offset), 0, null);
            DesiredHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DesiredHeight_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HandleWidth_Offset), 0, null, HandleWidth);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, HandleColor_Offset), 0, null, HandleColor);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HandleBrush_Offset), 0, null, HandleBrush);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, TicksColor_Offset), 0, null, TicksColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, TicksTextColor_Offset), 0, null, TicksTextColor);
            UnrealSharp.SlateCore.SlateFontInfoMarshaler.ToNative(IntPtr.Add(Buffer, TicksTextFont_Offset), 0, null, TicksTextFont);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TicksTextOffset_Offset), 0, null, TicksTextOffset);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundColor_Offset), 0, null, BackgroundColor);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundBrush_Offset), 0, null, BackgroundBrush);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DesiredWidth_Offset), 0, null, DesiredWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DesiredHeight_Offset), 0, null, DesiredHeight);
        }
    }
}

public static class FixedSampleSequenceRulerStyleMarshaler
{
    public static FixedSampleSequenceRulerStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FixedSampleSequenceRulerStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FixedSampleSequenceRulerStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FixedSampleSequenceRulerStyle.NativeDataSize;
    }
}