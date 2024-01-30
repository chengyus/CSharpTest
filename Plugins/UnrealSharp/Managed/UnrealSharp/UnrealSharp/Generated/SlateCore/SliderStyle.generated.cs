using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SliderStyle
{
    // StructProperty /Script/SlateCore.SliderStyle:NormalBarImage
    static readonly int NormalBarImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush NormalBarImage;
    
    // StructProperty /Script/SlateCore.SliderStyle:HoveredBarImage
    static readonly int HoveredBarImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush HoveredBarImage;
    
    // StructProperty /Script/SlateCore.SliderStyle:DisabledBarImage
    static readonly int DisabledBarImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush DisabledBarImage;
    
    // StructProperty /Script/SlateCore.SliderStyle:NormalThumbImage
    static readonly int NormalThumbImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush NormalThumbImage;
    
    // StructProperty /Script/SlateCore.SliderStyle:HoveredThumbImage
    static readonly int HoveredThumbImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush HoveredThumbImage;
    
    // StructProperty /Script/SlateCore.SliderStyle:DisabledThumbImage
    static readonly int DisabledThumbImage_Offset;
    public UnrealSharp.SlateCore.SlateBrush DisabledThumbImage;
    
    // FloatProperty /Script/SlateCore.SliderStyle:BarThickness
    static readonly int BarThickness_Offset;
    public float BarThickness;
    
    
    public static readonly int NativeDataSize;
    static SliderStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SliderStyle");
        
        NormalBarImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalBarImage");
        HoveredBarImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredBarImage");
        DisabledBarImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisabledBarImage");
        NormalThumbImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalThumbImage");
        HoveredThumbImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HoveredThumbImage");
        DisabledThumbImage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DisabledThumbImage");
        BarThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BarThickness");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SliderStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            NormalBarImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, NormalBarImage_Offset), 0, null);
            HoveredBarImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredBarImage_Offset), 0, null);
            DisabledBarImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DisabledBarImage_Offset), 0, null);
            NormalThumbImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, NormalThumbImage_Offset), 0, null);
            HoveredThumbImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, HoveredThumbImage_Offset), 0, null);
            DisabledThumbImage = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DisabledThumbImage_Offset), 0, null);
            BarThickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BarThickness_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, NormalBarImage_Offset), 0, null, NormalBarImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HoveredBarImage_Offset), 0, null, HoveredBarImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DisabledBarImage_Offset), 0, null, DisabledBarImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, NormalThumbImage_Offset), 0, null, NormalThumbImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, HoveredThumbImage_Offset), 0, null, HoveredThumbImage);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DisabledThumbImage_Offset), 0, null, DisabledThumbImage);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BarThickness_Offset), 0, null, BarThickness);
        }
    }
}

public static class SliderStyleMarshaler
{
    public static SliderStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SliderStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SliderStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SliderStyle.NativeDataSize;
    }
}