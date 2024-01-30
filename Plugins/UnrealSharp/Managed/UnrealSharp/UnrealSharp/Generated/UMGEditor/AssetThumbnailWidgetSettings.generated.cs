using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMGEditor;

[UStruct]
public partial struct AssetThumbnailWidgetSettings
{
    // BoolProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:bForceGenericThumbnail
    static readonly int bForceGenericThumbnail_Offset;
    public bool ForceGenericThumbnail;
    
    // BoolProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:bAllowHintText
    static readonly int bAllowHintText_Offset;
    public bool AllowHintText;
    
    // BoolProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:bAllowRealTimeOnHovered
    static readonly int bAllowRealTimeOnHovered_Offset;
    public bool AllowRealTimeOnHovered;
    
    // BoolProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:bAllowAssetSpecificThumbnailOverlay
    static readonly int bAllowAssetSpecificThumbnailOverlay_Offset;
    public bool AllowAssetSpecificThumbnailOverlay;
    
    // EnumProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:ThumbnailLabel
    static readonly int ThumbnailLabel_Offset;
    public UnrealSharp.UMGEditor.EThumbnailLabelType_BlueprintType ThumbnailLabel;
    
    // StructProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:HintColorAndOpacity
    static readonly int HintColorAndOpacity_Offset;
    public UnrealSharp.CoreUObject.LinearColor HintColorAndOpacity;
    
    // BoolProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:bOverrideAssetTypeColor
    static readonly int bOverrideAssetTypeColor_Offset;
    public bool OverrideAssetTypeColor;
    
    // StructProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:AssetTypeColorOverride
    static readonly int AssetTypeColorOverride_Offset;
    public UnrealSharp.CoreUObject.LinearColor AssetTypeColorOverride;
    
    // StructProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:Padding
    static readonly int Padding_Offset;
    public UnrealSharp.SlateCore.Margin Padding;
    
    // IntProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:GenericThumbnailSize
    static readonly int GenericThumbnailSize_Offset;
    public int GenericThumbnailSize;
    
    // EnumProperty /Script/UMGEditor.AssetThumbnailWidgetSettings:ColorStripOrientation
    static readonly int ColorStripOrientation_Offset;
    public UnrealSharp.UMGEditor.EThumbnailColorStripOrientation_BlueprintType ColorStripOrientation;
    
    
    public static readonly int NativeDataSize;
    static AssetThumbnailWidgetSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AssetThumbnailWidgetSettings");
        
        bForceGenericThumbnail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceGenericThumbnail");
        bAllowHintText_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowHintText");
        bAllowRealTimeOnHovered_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowRealTimeOnHovered");
        bAllowAssetSpecificThumbnailOverlay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowAssetSpecificThumbnailOverlay");
        ThumbnailLabel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ThumbnailLabel");
        HintColorAndOpacity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HintColorAndOpacity");
        bOverrideAssetTypeColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOverrideAssetTypeColor");
        AssetTypeColorOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AssetTypeColorOverride");
        Padding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Padding");
        GenericThumbnailSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GenericThumbnailSize");
        ColorStripOrientation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorStripOrientation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AssetThumbnailWidgetSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ForceGenericThumbnail = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bForceGenericThumbnail_Offset), 0, null);
            AllowHintText = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowHintText_Offset), 0, null);
            AllowRealTimeOnHovered = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowRealTimeOnHovered_Offset), 0, null);
            AllowAssetSpecificThumbnailOverlay = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowAssetSpecificThumbnailOverlay_Offset), 0, null);
            ThumbnailLabel = BlittableMarshaller<UnrealSharp.UMGEditor.EThumbnailLabelType_BlueprintType>.FromNative(IntPtr.Add(InNativeStruct, ThumbnailLabel_Offset), 0, null);
            HintColorAndOpacity = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, HintColorAndOpacity_Offset), 0, null);
            OverrideAssetTypeColor = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOverrideAssetTypeColor_Offset), 0, null);
            AssetTypeColorOverride = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, AssetTypeColorOverride_Offset), 0, null);
            Padding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, Padding_Offset), 0, null);
            GenericThumbnailSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, GenericThumbnailSize_Offset), 0, null);
            ColorStripOrientation = BlittableMarshaller<UnrealSharp.UMGEditor.EThumbnailColorStripOrientation_BlueprintType>.FromNative(IntPtr.Add(InNativeStruct, ColorStripOrientation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bForceGenericThumbnail_Offset), 0, null, ForceGenericThumbnail);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowHintText_Offset), 0, null, AllowHintText);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowRealTimeOnHovered_Offset), 0, null, AllowRealTimeOnHovered);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowAssetSpecificThumbnailOverlay_Offset), 0, null, AllowAssetSpecificThumbnailOverlay);
            BlittableMarshaller<UnrealSharp.UMGEditor.EThumbnailLabelType_BlueprintType>.ToNative(IntPtr.Add(Buffer, ThumbnailLabel_Offset), 0, null, ThumbnailLabel);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, HintColorAndOpacity_Offset), 0, null, HintColorAndOpacity);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOverrideAssetTypeColor_Offset), 0, null, OverrideAssetTypeColor);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, AssetTypeColorOverride_Offset), 0, null, AssetTypeColorOverride);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, Padding_Offset), 0, null, Padding);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, GenericThumbnailSize_Offset), 0, null, GenericThumbnailSize);
            BlittableMarshaller<UnrealSharp.UMGEditor.EThumbnailColorStripOrientation_BlueprintType>.ToNative(IntPtr.Add(Buffer, ColorStripOrientation_Offset), 0, null, ColorStripOrientation);
        }
    }
}

public static class AssetThumbnailWidgetSettingsMarshaler
{
    public static AssetThumbnailWidgetSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AssetThumbnailWidgetSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AssetThumbnailWidgetSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AssetThumbnailWidgetSettings.NativeDataSize;
    }
}