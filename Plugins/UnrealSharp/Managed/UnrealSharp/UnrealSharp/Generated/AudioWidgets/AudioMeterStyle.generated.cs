using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioWidgets;

[UStruct]
public partial struct AudioMeterStyle
{
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:MeterValueImage
    static readonly int MeterValueImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush MeterValueImage;
    
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:BackgroundImage
    static readonly int BackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImage;
    
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:MeterBackgroundImage
    static readonly int MeterBackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush MeterBackgroundImage;
    
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:MeterValueBackgroundImage
    static readonly int MeterValueBackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush MeterValueBackgroundImage;
    
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:MeterPeakImage
    static readonly int MeterPeakImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush MeterPeakImage;
    
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:MeterSize
    static readonly int MeterSize_Offset;
    public System.DoubleNumerics.Vector2 MeterSize;
    
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:MeterPadding
    static readonly int MeterPadding_Offset;
    public System.DoubleNumerics.Vector2 MeterPadding;
    
    // FloatProperty /Script/AudioWidgets.AudioMeterStyle:MeterValuePadding
    static readonly int MeterValuePadding_Offset;
    public float MeterValuePadding;
    
    // FloatProperty /Script/AudioWidgets.AudioMeterStyle:PeakValueWidth
    static readonly int PeakValueWidth_Offset;
    public float PeakValueWidth;
    
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:ValueRangeDb
    static readonly int ValueRangeDb_Offset;
    public System.DoubleNumerics.Vector2 ValueRangeDb;
    
    // BoolProperty /Script/AudioWidgets.AudioMeterStyle:bShowScale
    static readonly int bShowScale_Offset;
    public bool ShowScale;
    
    // BoolProperty /Script/AudioWidgets.AudioMeterStyle:bScaleSide
    static readonly int bScaleSide_Offset;
    public bool ScaleSide;
    
    // FloatProperty /Script/AudioWidgets.AudioMeterStyle:ScaleHashOffset
    static readonly int ScaleHashOffset_Offset;
    public float ScaleHashOffset;
    
    // FloatProperty /Script/AudioWidgets.AudioMeterStyle:ScaleHashWidth
    static readonly int ScaleHashWidth_Offset;
    public float ScaleHashWidth;
    
    // FloatProperty /Script/AudioWidgets.AudioMeterStyle:ScaleHashHeight
    static readonly int ScaleHashHeight_Offset;
    public float ScaleHashHeight;
    
    // IntProperty /Script/AudioWidgets.AudioMeterStyle:DecibelsPerHash
    static readonly int DecibelsPerHash_Offset;
    public int DecibelsPerHash;
    
    // StructProperty /Script/AudioWidgets.AudioMeterStyle:Font
    static readonly int Font_Offset;
    public UnrealSharp.SlateCore.SlateFontInfo Font;
    
    
    public static readonly int NativeDataSize;
    static AudioMeterStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AudioMeterStyle");
        
        MeterValueImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeterValueImage");
        BackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImage");
        MeterBackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeterBackgroundImage");
        MeterValueBackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeterValueBackgroundImage");
        MeterPeakImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeterPeakImage");
        MeterSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeterSize");
        MeterPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeterPadding");
        MeterValuePadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MeterValuePadding");
        PeakValueWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PeakValueWidth");
        ValueRangeDb_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ValueRangeDb");
        bShowScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowScale");
        bScaleSide_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bScaleSide");
        ScaleHashOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleHashOffset");
        ScaleHashWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleHashWidth");
        ScaleHashHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleHashHeight");
        DecibelsPerHash_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DecibelsPerHash");
        Font_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Font");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AudioMeterStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            MeterValueImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, MeterValueImage_Offset), 0, null);
            BackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImage_Offset), 0, null);
            MeterBackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, MeterBackgroundImage_Offset), 0, null);
            MeterValueBackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, MeterValueBackgroundImage_Offset), 0, null);
            MeterPeakImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, MeterPeakImage_Offset), 0, null);
            MeterSize = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, MeterSize_Offset), 0, null);
            MeterPadding = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, MeterPadding_Offset), 0, null);
            MeterValuePadding = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MeterValuePadding_Offset), 0, null);
            PeakValueWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PeakValueWidth_Offset), 0, null);
            ValueRangeDb = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, ValueRangeDb_Offset), 0, null);
            ShowScale = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShowScale_Offset), 0, null);
            ScaleSide = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bScaleSide_Offset), 0, null);
            ScaleHashOffset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScaleHashOffset_Offset), 0, null);
            ScaleHashWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScaleHashWidth_Offset), 0, null);
            ScaleHashHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScaleHashHeight_Offset), 0, null);
            DecibelsPerHash = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, DecibelsPerHash_Offset), 0, null);
            Font = UnrealSharp.SlateCore.SlateFontInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, Font_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, MeterValueImage_Offset), 0, null, MeterValueImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImage_Offset), 0, null, BackgroundImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, MeterBackgroundImage_Offset), 0, null, MeterBackgroundImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, MeterValueBackgroundImage_Offset), 0, null, MeterValueBackgroundImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, MeterPeakImage_Offset), 0, null, MeterPeakImage);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, MeterSize_Offset), 0, null, MeterSize);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, MeterPadding_Offset), 0, null, MeterPadding);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MeterValuePadding_Offset), 0, null, MeterValuePadding);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PeakValueWidth_Offset), 0, null, PeakValueWidth);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, ValueRangeDb_Offset), 0, null, ValueRangeDb);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShowScale_Offset), 0, null, ShowScale);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bScaleSide_Offset), 0, null, ScaleSide);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScaleHashOffset_Offset), 0, null, ScaleHashOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScaleHashWidth_Offset), 0, null, ScaleHashWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScaleHashHeight_Offset), 0, null, ScaleHashHeight);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, DecibelsPerHash_Offset), 0, null, DecibelsPerHash);
            UnrealSharp.SlateCore.SlateFontInfoMarshaler.ToNative(IntPtr.Add(Buffer, Font_Offset), 0, null, Font);
        }
    }
}

public static class AudioMeterStyleMarshaler
{
    public static AudioMeterStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AudioMeterStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AudioMeterStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AudioMeterStyle.NativeDataSize;
    }
}