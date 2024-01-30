using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct FontOutlineSettings
{
    // IntProperty /Script/SlateCore.FontOutlineSettings:OutlineSize
    static readonly int OutlineSize_Offset;
    public int OutlineSize;
    
    // BoolProperty /Script/SlateCore.FontOutlineSettings:bSeparateFillAlpha
    static readonly int bSeparateFillAlpha_Offset;
    public bool SeparateFillAlpha;
    
    // BoolProperty /Script/SlateCore.FontOutlineSettings:bApplyOutlineToDropShadows
    static readonly int bApplyOutlineToDropShadows_Offset;
    public bool ApplyOutlineToDropShadows;
    
    // ObjectProperty /Script/SlateCore.FontOutlineSettings:OutlineMaterial
    static readonly int OutlineMaterial_Offset;
    public UnrealSharp.CoreUObject.Object OutlineMaterial;
    
    // StructProperty /Script/SlateCore.FontOutlineSettings:OutlineColor
    static readonly int OutlineColor_Offset;
    public UnrealSharp.CoreUObject.LinearColor OutlineColor;
    
    
    public static readonly int NativeDataSize;
    static FontOutlineSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FontOutlineSettings");
        
        OutlineSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutlineSize");
        bSeparateFillAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSeparateFillAlpha");
        bApplyOutlineToDropShadows_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyOutlineToDropShadows");
        OutlineMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutlineMaterial");
        OutlineColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutlineColor");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FontOutlineSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            OutlineSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, OutlineSize_Offset), 0, null);
            SeparateFillAlpha = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSeparateFillAlpha_Offset), 0, null);
            ApplyOutlineToDropShadows = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplyOutlineToDropShadows_Offset), 0, null);
            OutlineMaterial = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, OutlineMaterial_Offset), 0, null);
            OutlineColor = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, OutlineColor_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, OutlineSize_Offset), 0, null, OutlineSize);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSeparateFillAlpha_Offset), 0, null, SeparateFillAlpha);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplyOutlineToDropShadows_Offset), 0, null, ApplyOutlineToDropShadows);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, OutlineMaterial_Offset), 0, null, OutlineMaterial);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, OutlineColor_Offset), 0, null, OutlineColor);
        }
    }
}

public static class FontOutlineSettingsMarshaler
{
    public static FontOutlineSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FontOutlineSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FontOutlineSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FontOutlineSettings.NativeDataSize;
    }
}