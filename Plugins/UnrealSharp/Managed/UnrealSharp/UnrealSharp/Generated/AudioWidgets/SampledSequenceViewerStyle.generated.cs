using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct]
public partial struct SampledSequenceViewerStyle
{
    // StructProperty /Script/AudioWidgets.SampledSequenceViewerStyle:SequenceColor
    static readonly int SequenceColor_Offset;
    public UnrealSharp.SlateCore.SlateColor SequenceColor;
    
    // FloatProperty /Script/AudioWidgets.SampledSequenceViewerStyle:SequenceLineThickness
    static readonly int SequenceLineThickness_Offset;
    public float SequenceLineThickness;
    
    // StructProperty /Script/AudioWidgets.SampledSequenceViewerStyle:MajorGridLineColor
    static readonly int MajorGridLineColor_Offset;
    public UnrealSharp.SlateCore.SlateColor MajorGridLineColor;
    
    // StructProperty /Script/AudioWidgets.SampledSequenceViewerStyle:MinorGridLineColor
    static readonly int MinorGridLineColor_Offset;
    public UnrealSharp.SlateCore.SlateColor MinorGridLineColor;
    
    // StructProperty /Script/AudioWidgets.SampledSequenceViewerStyle:ZeroCrossingLineColor
    static readonly int ZeroCrossingLineColor_Offset;
    public UnrealSharp.SlateCore.SlateColor ZeroCrossingLineColor;
    
    // FloatProperty /Script/AudioWidgets.SampledSequenceViewerStyle:ZeroCrossingLineThickness
    static readonly int ZeroCrossingLineThickness_Offset;
    public float ZeroCrossingLineThickness;
    
    // FloatProperty /Script/AudioWidgets.SampledSequenceViewerStyle:SampleMarkersSize
    static readonly int SampleMarkersSize_Offset;
    public float SampleMarkersSize;
    
    // StructProperty /Script/AudioWidgets.SampledSequenceViewerStyle:SequenceBackgroundColor
    static readonly int SequenceBackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor SequenceBackgroundColor;
    
    // StructProperty /Script/AudioWidgets.SampledSequenceViewerStyle:BackgroundBrush
    static readonly int BackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundBrush;
    
    // FloatProperty /Script/AudioWidgets.SampledSequenceViewerStyle:DesiredWidth
    static readonly int DesiredWidth_Offset;
    public float DesiredWidth;
    
    // FloatProperty /Script/AudioWidgets.SampledSequenceViewerStyle:DesiredHeight
    static readonly int DesiredHeight_Offset;
    public float DesiredHeight;
    
    
    public static readonly int NativeDataSize;
    static SampledSequenceViewerStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SampledSequenceViewerStyle");
        
        SequenceColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SequenceColor");
        SequenceLineThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SequenceLineThickness");
        MajorGridLineColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MajorGridLineColor");
        MinorGridLineColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinorGridLineColor");
        ZeroCrossingLineColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ZeroCrossingLineColor");
        ZeroCrossingLineThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ZeroCrossingLineThickness");
        SampleMarkersSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SampleMarkersSize");
        SequenceBackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SequenceBackgroundColor");
        BackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundBrush");
        DesiredWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DesiredWidth");
        DesiredHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DesiredHeight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SampledSequenceViewerStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            SequenceColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, SequenceColor_Offset), 0, null);
            SequenceLineThickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SequenceLineThickness_Offset), 0, null);
            MajorGridLineColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, MajorGridLineColor_Offset), 0, null);
            MinorGridLineColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, MinorGridLineColor_Offset), 0, null);
            ZeroCrossingLineColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, ZeroCrossingLineColor_Offset), 0, null);
            ZeroCrossingLineThickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ZeroCrossingLineThickness_Offset), 0, null);
            SampleMarkersSize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SampleMarkersSize_Offset), 0, null);
            SequenceBackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, SequenceBackgroundColor_Offset), 0, null);
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
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, SequenceColor_Offset), 0, null, SequenceColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SequenceLineThickness_Offset), 0, null, SequenceLineThickness);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, MajorGridLineColor_Offset), 0, null, MajorGridLineColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, MinorGridLineColor_Offset), 0, null, MinorGridLineColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, ZeroCrossingLineColor_Offset), 0, null, ZeroCrossingLineColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ZeroCrossingLineThickness_Offset), 0, null, ZeroCrossingLineThickness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SampleMarkersSize_Offset), 0, null, SampleMarkersSize);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, SequenceBackgroundColor_Offset), 0, null, SequenceBackgroundColor);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundBrush_Offset), 0, null, BackgroundBrush);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DesiredWidth_Offset), 0, null, DesiredWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DesiredHeight_Offset), 0, null, DesiredHeight);
        }
    }
}

public static class SampledSequenceViewerStyleMarshaler
{
    public static SampledSequenceViewerStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SampledSequenceViewerStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SampledSequenceViewerStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SampledSequenceViewerStyle.NativeDataSize;
    }
}