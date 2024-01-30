using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct]
public partial struct Synth2DSliderStyle
{
    // StructProperty /Script/Synthesis.Synth2DSliderStyle:NormalThumbImage
    static readonly int NormalThumbImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush NormalThumbImage;
    
    // StructProperty /Script/Synthesis.Synth2DSliderStyle:DisabledThumbImage
    static readonly int DisabledThumbImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush DisabledThumbImage;
    
    // StructProperty /Script/Synthesis.Synth2DSliderStyle:NormalBarImage
    static readonly int NormalBarImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush NormalBarImage;
    
    // StructProperty /Script/Synthesis.Synth2DSliderStyle:DisabledBarImage
    static readonly int DisabledBarImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush DisabledBarImage;
    
    // StructProperty /Script/Synthesis.Synth2DSliderStyle:BackgroundImage
    static readonly int BackgroundImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundImage;
    
    // FloatProperty /Script/Synthesis.Synth2DSliderStyle:BarThickness
    static readonly int BarThickness_Offset;
    public float BarThickness;
    
    
    public static readonly int NativeDataSize;
    static Synth2DSliderStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("Synth2DSliderStyle");
        
        NormalThumbImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalThumbImage");
        DisabledThumbImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisabledThumbImage");
        NormalBarImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalBarImage");
        DisabledBarImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisabledBarImage");
        BackgroundImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundImage");
        BarThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BarThickness");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public Synth2DSliderStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            NormalThumbImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, NormalThumbImage_Offset), 0, null);
            DisabledThumbImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DisabledThumbImage_Offset), 0, null);
            NormalBarImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, NormalBarImage_Offset), 0, null);
            DisabledBarImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DisabledBarImage_Offset), 0, null);
            BackgroundImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundImage_Offset), 0, null);
            BarThickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BarThickness_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, NormalThumbImage_Offset), 0, null, NormalThumbImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DisabledThumbImage_Offset), 0, null, DisabledThumbImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, NormalBarImage_Offset), 0, null, NormalBarImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DisabledBarImage_Offset), 0, null, DisabledBarImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundImage_Offset), 0, null, BackgroundImage);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BarThickness_Offset), 0, null, BarThickness);
        }
    }
}

public static class Synth2DSliderStyleMarshaler
{
    public static Synth2DSliderStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new Synth2DSliderStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, Synth2DSliderStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return Synth2DSliderStyle.NativeDataSize;
    }
}