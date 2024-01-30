using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SlateBrush
{
    // ByteProperty /Script/SlateCore.SlateBrush:DrawAs
    static readonly int DrawAs_Offset;
    public UnrealSharp.SlateCore.ESlateBrushDrawType DrawAs;
    
    // ByteProperty /Script/SlateCore.SlateBrush:Tiling
    static readonly int Tiling_Offset;
    public UnrealSharp.SlateCore.ESlateBrushTileType Tiling;
    
    // ByteProperty /Script/SlateCore.SlateBrush:Mirroring
    static readonly int Mirroring_Offset;
    public UnrealSharp.SlateCore.ESlateBrushMirrorType Mirroring;
    
    // StructProperty /Script/SlateCore.SlateBrush:ImageSize
    static readonly int ImageSize_Offset;
    public UnrealSharp.SlateCore.DeprecateSlateVector2D ImageSize;
    
    // StructProperty /Script/SlateCore.SlateBrush:Margin
    static readonly int Margin_Offset;
    public UnrealSharp.SlateCore.Margin Margin;
    
    // StructProperty /Script/SlateCore.SlateBrush:TintColor
    static readonly int TintColor_Offset;
    public UnrealSharp.SlateCore.SlateColor TintColor;
    
    // StructProperty /Script/SlateCore.SlateBrush:OutlineSettings
    static readonly int OutlineSettings_Offset;
    public UnrealSharp.SlateCore.SlateBrushOutlineSettings OutlineSettings;
    
    // ObjectProperty /Script/SlateCore.SlateBrush:ResourceObject
    static readonly int ResourceObject_Offset;
    public UnrealSharp.CoreUObject.Object ResourceObject;
    
    
    public static readonly int NativeDataSize;
    static SlateBrush()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SlateBrush");
        
        DrawAs_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DrawAs");
        Tiling_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tiling");
        Mirroring_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mirroring");
        ImageSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ImageSize");
        Margin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Margin");
        TintColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TintColor");
        OutlineSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutlineSettings");
        ResourceObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ResourceObject");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SlateBrush(IntPtr InNativeStruct)
    {
        unsafe
        {
            DrawAs = BlittableMarshaller<UnrealSharp.SlateCore.ESlateBrushDrawType>.FromNative(IntPtr.Add(InNativeStruct, DrawAs_Offset), 0, null);
            Tiling = BlittableMarshaller<UnrealSharp.SlateCore.ESlateBrushTileType>.FromNative(IntPtr.Add(InNativeStruct, Tiling_Offset), 0, null);
            Mirroring = BlittableMarshaller<UnrealSharp.SlateCore.ESlateBrushMirrorType>.FromNative(IntPtr.Add(InNativeStruct, Mirroring_Offset), 0, null);
            ImageSize = UnrealSharp.SlateCore.DeprecateSlateVector2DMarshaler.FromNative(IntPtr.Add(InNativeStruct, ImageSize_Offset), 0, null);
            Margin = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, Margin_Offset), 0, null);
            TintColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, TintColor_Offset), 0, null);
            OutlineSettings = UnrealSharp.SlateCore.SlateBrushOutlineSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, OutlineSettings_Offset), 0, null);
            ResourceObject = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, ResourceObject_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.SlateCore.ESlateBrushDrawType>.ToNative(IntPtr.Add(Buffer, DrawAs_Offset), 0, null, DrawAs);
            BlittableMarshaller<UnrealSharp.SlateCore.ESlateBrushTileType>.ToNative(IntPtr.Add(Buffer, Tiling_Offset), 0, null, Tiling);
            BlittableMarshaller<UnrealSharp.SlateCore.ESlateBrushMirrorType>.ToNative(IntPtr.Add(Buffer, Mirroring_Offset), 0, null, Mirroring);
            UnrealSharp.SlateCore.DeprecateSlateVector2DMarshaler.ToNative(IntPtr.Add(Buffer, ImageSize_Offset), 0, null, ImageSize);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, Margin_Offset), 0, null, Margin);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, TintColor_Offset), 0, null, TintColor);
            UnrealSharp.SlateCore.SlateBrushOutlineSettingsMarshaler.ToNative(IntPtr.Add(Buffer, OutlineSettings_Offset), 0, null, OutlineSettings);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, ResourceObject_Offset), 0, null, ResourceObject);
        }
    }
}

public static class SlateBrushMarshaler
{
    public static SlateBrush FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SlateBrush(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SlateBrush obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SlateBrush.NativeDataSize;
    }
}