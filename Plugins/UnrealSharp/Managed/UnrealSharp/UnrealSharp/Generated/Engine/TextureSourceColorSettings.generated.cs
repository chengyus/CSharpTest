using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct TextureSourceColorSettings
{
    // EnumProperty /Script/Engine.TextureSourceColorSettings:EncodingOverride
    static readonly int EncodingOverride_Offset;
    public UnrealSharp.Engine.ETextureSourceEncoding EncodingOverride;
    
    // EnumProperty /Script/Engine.TextureSourceColorSettings:ColorSpace
    static readonly int ColorSpace_Offset;
    public UnrealSharp.Engine.ETextureColorSpace ColorSpace;
    
    // StructProperty /Script/Engine.TextureSourceColorSettings:RedChromaticityCoordinate
    static readonly int RedChromaticityCoordinate_Offset;
    public System.DoubleNumerics.Vector2 RedChromaticityCoordinate;
    
    // StructProperty /Script/Engine.TextureSourceColorSettings:GreenChromaticityCoordinate
    static readonly int GreenChromaticityCoordinate_Offset;
    public System.DoubleNumerics.Vector2 GreenChromaticityCoordinate;
    
    // StructProperty /Script/Engine.TextureSourceColorSettings:BlueChromaticityCoordinate
    static readonly int BlueChromaticityCoordinate_Offset;
    public System.DoubleNumerics.Vector2 BlueChromaticityCoordinate;
    
    // StructProperty /Script/Engine.TextureSourceColorSettings:WhiteChromaticityCoordinate
    static readonly int WhiteChromaticityCoordinate_Offset;
    public System.DoubleNumerics.Vector2 WhiteChromaticityCoordinate;
    
    // EnumProperty /Script/Engine.TextureSourceColorSettings:ChromaticAdaptationMethod
    static readonly int ChromaticAdaptationMethod_Offset;
    public UnrealSharp.Engine.ETextureChromaticAdaptationMethod ChromaticAdaptationMethod;
    
    
    public static readonly int NativeDataSize;
    static TextureSourceColorSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TextureSourceColorSettings");
        
        EncodingOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EncodingOverride");
        ColorSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColorSpace");
        RedChromaticityCoordinate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RedChromaticityCoordinate");
        GreenChromaticityCoordinate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GreenChromaticityCoordinate");
        BlueChromaticityCoordinate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlueChromaticityCoordinate");
        WhiteChromaticityCoordinate_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WhiteChromaticityCoordinate");
        ChromaticAdaptationMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChromaticAdaptationMethod");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TextureSourceColorSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            EncodingOverride = BlittableMarshaller<UnrealSharp.Engine.ETextureSourceEncoding>.FromNative(IntPtr.Add(InNativeStruct, EncodingOverride_Offset), 0, null);
            ColorSpace = BlittableMarshaller<UnrealSharp.Engine.ETextureColorSpace>.FromNative(IntPtr.Add(InNativeStruct, ColorSpace_Offset), 0, null);
            RedChromaticityCoordinate = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, RedChromaticityCoordinate_Offset), 0, null);
            GreenChromaticityCoordinate = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, GreenChromaticityCoordinate_Offset), 0, null);
            BlueChromaticityCoordinate = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, BlueChromaticityCoordinate_Offset), 0, null);
            WhiteChromaticityCoordinate = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, WhiteChromaticityCoordinate_Offset), 0, null);
            ChromaticAdaptationMethod = BlittableMarshaller<UnrealSharp.Engine.ETextureChromaticAdaptationMethod>.FromNative(IntPtr.Add(InNativeStruct, ChromaticAdaptationMethod_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.ETextureSourceEncoding>.ToNative(IntPtr.Add(Buffer, EncodingOverride_Offset), 0, null, EncodingOverride);
            BlittableMarshaller<UnrealSharp.Engine.ETextureColorSpace>.ToNative(IntPtr.Add(Buffer, ColorSpace_Offset), 0, null, ColorSpace);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, RedChromaticityCoordinate_Offset), 0, null, RedChromaticityCoordinate);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, GreenChromaticityCoordinate_Offset), 0, null, GreenChromaticityCoordinate);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, BlueChromaticityCoordinate_Offset), 0, null, BlueChromaticityCoordinate);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, WhiteChromaticityCoordinate_Offset), 0, null, WhiteChromaticityCoordinate);
            BlittableMarshaller<UnrealSharp.Engine.ETextureChromaticAdaptationMethod>.ToNative(IntPtr.Add(Buffer, ChromaticAdaptationMethod_Offset), 0, null, ChromaticAdaptationMethod);
        }
    }
}

public static class TextureSourceColorSettingsMarshaler
{
    public static TextureSourceColorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TextureSourceColorSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TextureSourceColorSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TextureSourceColorSettings.NativeDataSize;
    }
}