using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct SlateFontInfo
{
    // ObjectProperty /Script/SlateCore.SlateFontInfo:FontObject
    static readonly int FontObject_Offset;
    public UnrealSharp.CoreUObject.Object FontObject;
    
    // ObjectProperty /Script/SlateCore.SlateFontInfo:FontMaterial
    static readonly int FontMaterial_Offset;
    public UnrealSharp.CoreUObject.Object FontMaterial;
    
    // StructProperty /Script/SlateCore.SlateFontInfo:OutlineSettings
    static readonly int OutlineSettings_Offset;
    public UnrealSharp.SlateCore.FontOutlineSettings OutlineSettings;
    
    // NameProperty /Script/SlateCore.SlateFontInfo:TypefaceFontName
    static readonly int TypefaceFontName_Offset;
    public Name TypefaceFontName;
    
    // FloatProperty /Script/SlateCore.SlateFontInfo:Size
    static readonly int Size_Offset;
    public float Size;
    
    // IntProperty /Script/SlateCore.SlateFontInfo:LetterSpacing
    static readonly int LetterSpacing_Offset;
    public int LetterSpacing;
    
    // FloatProperty /Script/SlateCore.SlateFontInfo:SkewAmount
    static readonly int SkewAmount_Offset;
    public float SkewAmount;
    
    
    public static readonly int NativeDataSize;
    static SlateFontInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SlateFontInfo");
        
        FontObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FontObject");
        FontMaterial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FontMaterial");
        OutlineSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutlineSettings");
        TypefaceFontName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TypefaceFontName");
        Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Size");
        LetterSpacing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LetterSpacing");
        SkewAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SkewAmount");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SlateFontInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            FontObject = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, FontObject_Offset), 0, null);
            FontMaterial = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, FontMaterial_Offset), 0, null);
            OutlineSettings = UnrealSharp.SlateCore.FontOutlineSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, OutlineSettings_Offset), 0, null);
            TypefaceFontName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, TypefaceFontName_Offset), 0, null);
            Size = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Size_Offset), 0, null);
            LetterSpacing = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, LetterSpacing_Offset), 0, null);
            SkewAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SkewAmount_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, FontObject_Offset), 0, null, FontObject);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, FontMaterial_Offset), 0, null, FontMaterial);
            UnrealSharp.SlateCore.FontOutlineSettingsMarshaler.ToNative(IntPtr.Add(Buffer, OutlineSettings_Offset), 0, null, OutlineSettings);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, TypefaceFontName_Offset), 0, null, TypefaceFontName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Size_Offset), 0, null, Size);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, LetterSpacing_Offset), 0, null, LetterSpacing);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SkewAmount_Offset), 0, null, SkewAmount);
        }
    }
}

public static class SlateFontInfoMarshaler
{
    public static SlateFontInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SlateFontInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SlateFontInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SlateFontInfo.NativeDataSize;
    }
}