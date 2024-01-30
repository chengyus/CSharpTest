using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SegmentedControlStyle
{
    // StructProperty /Script/SlateCore.SegmentedControlStyle:ControlStyle
    static readonly int ControlStyle_Offset;
    public UnrealSharp.SlateCore.CheckBoxStyle ControlStyle;
    
    // StructProperty /Script/SlateCore.SegmentedControlStyle:FirstControlStyle
    static readonly int FirstControlStyle_Offset;
    public UnrealSharp.SlateCore.CheckBoxStyle FirstControlStyle;
    
    // StructProperty /Script/SlateCore.SegmentedControlStyle:LastControlStyle
    static readonly int LastControlStyle_Offset;
    public UnrealSharp.SlateCore.CheckBoxStyle LastControlStyle;
    
    // StructProperty /Script/SlateCore.SegmentedControlStyle:BackgroundBrush
    static readonly int BackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundBrush;
    
    // StructProperty /Script/SlateCore.SegmentedControlStyle:UniformPadding
    static readonly int UniformPadding_Offset;
    public UnrealSharp.SlateCore.Margin UniformPadding;
    
    
    public static readonly int NativeDataSize;
    static SegmentedControlStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SegmentedControlStyle");
        
        ControlStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlStyle");
        FirstControlStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FirstControlStyle");
        LastControlStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LastControlStyle");
        BackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundBrush");
        UniformPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UniformPadding");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SegmentedControlStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            ControlStyle = UnrealSharp.SlateCore.CheckBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, ControlStyle_Offset), 0, null);
            FirstControlStyle = UnrealSharp.SlateCore.CheckBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, FirstControlStyle_Offset), 0, null);
            LastControlStyle = UnrealSharp.SlateCore.CheckBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, LastControlStyle_Offset), 0, null);
            BackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundBrush_Offset), 0, null);
            UniformPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, UniformPadding_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.CheckBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, ControlStyle_Offset), 0, null, ControlStyle);
            UnrealSharp.SlateCore.CheckBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, FirstControlStyle_Offset), 0, null, FirstControlStyle);
            UnrealSharp.SlateCore.CheckBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, LastControlStyle_Offset), 0, null, LastControlStyle);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundBrush_Offset), 0, null, BackgroundBrush);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, UniformPadding_Offset), 0, null, UniformPadding);
        }
    }
}

public static class SegmentedControlStyleMarshaler
{
    public static SegmentedControlStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SegmentedControlStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SegmentedControlStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SegmentedControlStyle.NativeDataSize;
    }
}