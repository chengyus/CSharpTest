using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct]
public partial struct AudioRadialSliderStyle
{
    // StructProperty /Script/AudioWidgets.AudioRadialSliderStyle:TextBoxStyle
    static readonly int TextBoxStyle_Offset;
    public UnrealSharp.AudioWidgets.AudioTextBoxStyle TextBoxStyle;
    
    // StructProperty /Script/AudioWidgets.AudioRadialSliderStyle:CenterBackgroundColor
    static readonly int CenterBackgroundColor_Offset;
    public UnrealSharp.SlateCore.SlateColor CenterBackgroundColor;
    
    // StructProperty /Script/AudioWidgets.AudioRadialSliderStyle:SliderBarColor
    static readonly int SliderBarColor_Offset;
    public UnrealSharp.SlateCore.SlateColor SliderBarColor;
    
    // StructProperty /Script/AudioWidgets.AudioRadialSliderStyle:SliderProgressColor
    static readonly int SliderProgressColor_Offset;
    public UnrealSharp.SlateCore.SlateColor SliderProgressColor;
    
    // FloatProperty /Script/AudioWidgets.AudioRadialSliderStyle:LabelPadding
    static readonly int LabelPadding_Offset;
    public float LabelPadding;
    
    // FloatProperty /Script/AudioWidgets.AudioRadialSliderStyle:DefaultSliderRadius
    static readonly int DefaultSliderRadius_Offset;
    public float DefaultSliderRadius;
    
    
    public static readonly int NativeDataSize;
    static AudioRadialSliderStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioRadialSliderStyle");
        
        TextBoxStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextBoxStyle");
        CenterBackgroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CenterBackgroundColor");
        SliderBarColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SliderBarColor");
        SliderProgressColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SliderProgressColor");
        LabelPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LabelPadding");
        DefaultSliderRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultSliderRadius");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioRadialSliderStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            TextBoxStyle = UnrealSharp.AudioWidgets.AudioTextBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, TextBoxStyle_Offset), 0, null);
            CenterBackgroundColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, CenterBackgroundColor_Offset), 0, null);
            SliderBarColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, SliderBarColor_Offset), 0, null);
            SliderProgressColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, SliderProgressColor_Offset), 0, null);
            LabelPadding = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, LabelPadding_Offset), 0, null);
            DefaultSliderRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DefaultSliderRadius_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.AudioWidgets.AudioTextBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, TextBoxStyle_Offset), 0, null, TextBoxStyle);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, CenterBackgroundColor_Offset), 0, null, CenterBackgroundColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, SliderBarColor_Offset), 0, null, SliderBarColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, SliderProgressColor_Offset), 0, null, SliderProgressColor);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, LabelPadding_Offset), 0, null, LabelPadding);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DefaultSliderRadius_Offset), 0, null, DefaultSliderRadius);
        }
    }
}

public static class AudioRadialSliderStyleMarshaler
{
    public static AudioRadialSliderStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioRadialSliderStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioRadialSliderStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioRadialSliderStyle.NativeDataSize;
    }
}