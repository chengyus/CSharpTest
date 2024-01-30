using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct]
public partial struct AudioSliderStyle
{
    // StructProperty /Script/AudioWidgets.AudioSliderStyle:SliderStyle
    static readonly int SliderStyle_Offset;
    public UnrealSharp.SlateCore.SliderStyle SliderStyle;
    
    // StructProperty /Script/AudioWidgets.AudioSliderStyle:TextBoxStyle
    static readonly int TextBoxStyle_Offset;
    public UnrealSharp.AudioWidgets.AudioTextBoxStyle TextBoxStyle;
    
    // StructProperty /Script/AudioWidgets.AudioSliderStyle:WidgetBackgroundImage
    static readonly int WidgetBackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush WidgetBackgroundImage;
    
    // StructProperty /Script/AudioWidgets.AudioSliderStyle:SliderBackgroundColor
    static readonly int SliderBackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor SliderBackgroundColor;
    
    // StructProperty /Script/AudioWidgets.AudioSliderStyle:SliderBackgroundSize
    static readonly int SliderBackgroundSize_Offset;
    public System.DoubleNumerics.Vector2 SliderBackgroundSize;
    
    // FloatProperty /Script/AudioWidgets.AudioSliderStyle:LabelPadding
    static readonly int LabelPadding_Offset;
    public float LabelPadding;
    
    // StructProperty /Script/AudioWidgets.AudioSliderStyle:SliderBarColor
    static readonly int SliderBarColor_Offset;
    public UnrealSharp.SlateCore.SlateColor SliderBarColor;
    
    // StructProperty /Script/AudioWidgets.AudioSliderStyle:SliderThumbColor
    static readonly int SliderThumbColor_Offset;
    public UnrealSharp.SlateCore.SlateColor SliderThumbColor;
    
    // StructProperty /Script/AudioWidgets.AudioSliderStyle:WidgetBackgroundColor
    static readonly int WidgetBackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor WidgetBackgroundColor;
    
    
    public static readonly int NativeDataSize;
    static AudioSliderStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioSliderStyle");
        
        SliderStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SliderStyle");
        TextBoxStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextBoxStyle");
        WidgetBackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WidgetBackgroundImage");
        SliderBackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SliderBackgroundColor");
        SliderBackgroundSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SliderBackgroundSize");
        LabelPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LabelPadding");
        SliderBarColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SliderBarColor");
        SliderThumbColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SliderThumbColor");
        WidgetBackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WidgetBackgroundColor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioSliderStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            SliderStyle = UnrealSharp.SlateCore.SliderStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, SliderStyle_Offset), 0, null);
            TextBoxStyle = UnrealSharp.AudioWidgets.AudioTextBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, TextBoxStyle_Offset), 0, null);
            WidgetBackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, WidgetBackgroundImage_Offset), 0, null);
            SliderBackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, SliderBackgroundColor_Offset), 0, null);
            SliderBackgroundSize = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, SliderBackgroundSize_Offset), 0, null);
            LabelPadding = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LabelPadding_Offset), 0, null);
            SliderBarColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, SliderBarColor_Offset), 0, null);
            SliderThumbColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, SliderThumbColor_Offset), 0, null);
            WidgetBackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, WidgetBackgroundColor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SliderStyleMarshaler.ToNative(IntPtr.Add(Buffer, SliderStyle_Offset), 0, null, SliderStyle);
            UnrealSharp.AudioWidgets.AudioTextBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, TextBoxStyle_Offset), 0, null, TextBoxStyle);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, WidgetBackgroundImage_Offset), 0, null, WidgetBackgroundImage);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, SliderBackgroundColor_Offset), 0, null, SliderBackgroundColor);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, SliderBackgroundSize_Offset), 0, null, SliderBackgroundSize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LabelPadding_Offset), 0, null, LabelPadding);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, SliderBarColor_Offset), 0, null, SliderBarColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, SliderThumbColor_Offset), 0, null, SliderThumbColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, WidgetBackgroundColor_Offset), 0, null, WidgetBackgroundColor);
        }
    }
}

public static class AudioSliderStyleMarshaler
{
    public static AudioSliderStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioSliderStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioSliderStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioSliderStyle.NativeDataSize;
    }
}