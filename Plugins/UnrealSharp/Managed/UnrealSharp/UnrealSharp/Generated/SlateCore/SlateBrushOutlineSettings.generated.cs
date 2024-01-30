using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SlateBrushOutlineSettings
{
    // StructProperty /Script/SlateCore.SlateBrushOutlineSettings:CornerRadii
    static readonly int CornerRadii_Offset;
    public System.DoubleNumerics.Vector4 CornerRadii;
    
    // StructProperty /Script/SlateCore.SlateBrushOutlineSettings:Color
    static readonly int Color_Offset;
    public UnrealSharp.SlateCore.SlateColor Color;
    
    // FloatProperty /Script/SlateCore.SlateBrushOutlineSettings:Width
    static readonly int Width_Offset;
    public float Width;
    
    // ByteProperty /Script/SlateCore.SlateBrushOutlineSettings:RoundingType
    static readonly int RoundingType_Offset;
    public UnrealSharp.SlateCore.ESlateBrushRoundingType RoundingType;
    
    // BoolProperty /Script/SlateCore.SlateBrushOutlineSettings:bUseBrushTransparency
    static readonly int bUseBrushTransparency_Offset;
    public bool UseBrushTransparency;
    
    
    public static readonly int NativeDataSize;
    static SlateBrushOutlineSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SlateBrushOutlineSettings");
        
        CornerRadii_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CornerRadii");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        Width_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Width");
        RoundingType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RoundingType");
        bUseBrushTransparency_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseBrushTransparency");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SlateBrushOutlineSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            CornerRadii = BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(InNativeStruct, CornerRadii_Offset), 0, null);
            Color = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            Width = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Width_Offset), 0, null);
            RoundingType = BlittableMarshaller<UnrealSharp.SlateCore.ESlateBrushRoundingType>.FromNative(IntPtr.Add(InNativeStruct, RoundingType_Offset), 0, null);
            UseBrushTransparency = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseBrushTransparency_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(Buffer, CornerRadii_Offset), 0, null, CornerRadii);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Width_Offset), 0, null, Width);
            BlittableMarshaller<UnrealSharp.SlateCore.ESlateBrushRoundingType>.ToNative(IntPtr.Add(Buffer, RoundingType_Offset), 0, null, RoundingType);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseBrushTransparency_Offset), 0, null, UseBrushTransparency);
        }
    }
}

public static class SlateBrushOutlineSettingsMarshaler
{
    public static SlateBrushOutlineSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SlateBrushOutlineSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SlateBrushOutlineSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SlateBrushOutlineSettings.NativeDataSize;
    }
}