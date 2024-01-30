using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SpinBoxStyle
{
    // StructProperty /Script/SlateCore.SpinBoxStyle:BackgroundBrush
    static readonly int BackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundBrush;
    
    // StructProperty /Script/SlateCore.SpinBoxStyle:ActiveBackgroundBrush
    static readonly int ActiveBackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ActiveBackgroundBrush;
    
    // StructProperty /Script/SlateCore.SpinBoxStyle:HoveredBackgroundBrush
    static readonly int HoveredBackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush HoveredBackgroundBrush;
    
    // StructProperty /Script/SlateCore.SpinBoxStyle:ActiveFillBrush
    static readonly int ActiveFillBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ActiveFillBrush;
    
    // StructProperty /Script/SlateCore.SpinBoxStyle:HoveredFillBrush
    static readonly int HoveredFillBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush HoveredFillBrush;
    
    // StructProperty /Script/SlateCore.SpinBoxStyle:InactiveFillBrush
    static readonly int InactiveFillBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush InactiveFillBrush;
    
    // StructProperty /Script/SlateCore.SpinBoxStyle:ArrowsImage
    static readonly int ArrowsImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush ArrowsImage;
    
    // StructProperty /Script/SlateCore.SpinBoxStyle:TextPadding
    static readonly int TextPadding_Offset;
    public UnrealSharp.SlateCore.Margin TextPadding;
    
    // StructProperty /Script/SlateCore.SpinBoxStyle:InsetPadding
    static readonly int InsetPadding_Offset;
    public UnrealSharp.SlateCore.Margin InsetPadding;
    
    
    public static readonly int NativeDataSize;
    static SpinBoxStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SpinBoxStyle");
        
        BackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundBrush");
        ActiveBackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveBackgroundBrush");
        HoveredBackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredBackgroundBrush");
        ActiveFillBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveFillBrush");
        HoveredFillBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredFillBrush");
        InactiveFillBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InactiveFillBrush");
        ArrowsImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArrowsImage");
        TextPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextPadding");
        InsetPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InsetPadding");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SpinBoxStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            BackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundBrush_Offset), 0, null);
            ActiveBackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ActiveBackgroundBrush_Offset), 0, null);
            HoveredBackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredBackgroundBrush_Offset), 0, null);
            ActiveFillBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ActiveFillBrush_Offset), 0, null);
            HoveredFillBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredFillBrush_Offset), 0, null);
            InactiveFillBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, InactiveFillBrush_Offset), 0, null);
            ArrowsImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ArrowsImage_Offset), 0, null);
            TextPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, TextPadding_Offset), 0, null);
            InsetPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, InsetPadding_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundBrush_Offset), 0, null, BackgroundBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ActiveBackgroundBrush_Offset), 0, null, ActiveBackgroundBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HoveredBackgroundBrush_Offset), 0, null, HoveredBackgroundBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ActiveFillBrush_Offset), 0, null, ActiveFillBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HoveredFillBrush_Offset), 0, null, HoveredFillBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, InactiveFillBrush_Offset), 0, null, InactiveFillBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ArrowsImage_Offset), 0, null, ArrowsImage);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, TextPadding_Offset), 0, null, TextPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, InsetPadding_Offset), 0, null, InsetPadding);
        }
    }
}

public static class SpinBoxStyleMarshaler
{
    public static SpinBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SpinBoxStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SpinBoxStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SpinBoxStyle.NativeDataSize;
    }
}