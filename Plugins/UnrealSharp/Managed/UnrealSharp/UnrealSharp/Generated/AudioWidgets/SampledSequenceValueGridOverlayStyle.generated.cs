using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct]
public partial struct SampledSequenceValueGridOverlayStyle
{
    // StructProperty /Script/AudioWidgets.SampledSequenceValueGridOverlayStyle:GridColor
    static readonly int GridColor_Offset;
    public UnrealSharp.SlateCore.SlateColor GridColor;
    
    // FloatProperty /Script/AudioWidgets.SampledSequenceValueGridOverlayStyle:GridThickness
    static readonly int GridThickness_Offset;
    public float GridThickness;
    
    // StructProperty /Script/AudioWidgets.SampledSequenceValueGridOverlayStyle:LabelTextColor
    static readonly int LabelTextColor_Offset;
    public UnrealSharp.SlateCore.SlateColor LabelTextColor;
    
    // StructProperty /Script/AudioWidgets.SampledSequenceValueGridOverlayStyle:LabelTextFont
    static readonly int LabelTextFont_Offset;
    public UnrealSharp.SlateCore.SlateFontInfo LabelTextFont;
    
    // FloatProperty /Script/AudioWidgets.SampledSequenceValueGridOverlayStyle:DesiredWidth
    static readonly int DesiredWidth_Offset;
    public float DesiredWidth;
    
    // FloatProperty /Script/AudioWidgets.SampledSequenceValueGridOverlayStyle:DesiredHeight
    static readonly int DesiredHeight_Offset;
    public float DesiredHeight;
    
    
    public static readonly int NativeDataSize;
    static SampledSequenceValueGridOverlayStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SampledSequenceValueGridOverlayStyle");
        
        GridColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GridColor");
        GridThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GridThickness");
        LabelTextColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LabelTextColor");
        LabelTextFont_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LabelTextFont");
        DesiredWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DesiredWidth");
        DesiredHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DesiredHeight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SampledSequenceValueGridOverlayStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            GridColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, GridColor_Offset), 0, null);
            GridThickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GridThickness_Offset), 0, null);
            LabelTextColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, LabelTextColor_Offset), 0, null);
            LabelTextFont = UnrealSharp.SlateCore.SlateFontInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, LabelTextFont_Offset), 0, null);
            DesiredWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DesiredWidth_Offset), 0, null);
            DesiredHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DesiredHeight_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, GridColor_Offset), 0, null, GridColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GridThickness_Offset), 0, null, GridThickness);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, LabelTextColor_Offset), 0, null, LabelTextColor);
            UnrealSharp.SlateCore.SlateFontInfoMarshaler.ToNative(IntPtr.Add(Buffer, LabelTextFont_Offset), 0, null, LabelTextFont);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DesiredWidth_Offset), 0, null, DesiredWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DesiredHeight_Offset), 0, null, DesiredHeight);
        }
    }
}

public static class SampledSequenceValueGridOverlayStyleMarshaler
{
    public static SampledSequenceValueGridOverlayStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SampledSequenceValueGridOverlayStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SampledSequenceValueGridOverlayStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SampledSequenceValueGridOverlayStyle.NativeDataSize;
    }
}