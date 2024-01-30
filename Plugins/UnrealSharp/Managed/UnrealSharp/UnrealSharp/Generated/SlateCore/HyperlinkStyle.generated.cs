using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct HyperlinkStyle
{
    // StructProperty /Script/SlateCore.HyperlinkStyle:UnderlineStyle
    static readonly int UnderlineStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle UnderlineStyle;
    
    // StructProperty /Script/SlateCore.HyperlinkStyle:TextStyle
    static readonly int TextStyle_Offset;
    public UnrealSharp.SlateCore.TextBlockStyle TextStyle;
    
    // StructProperty /Script/SlateCore.HyperlinkStyle:Padding
    static readonly int Padding_Offset;
    public UnrealSharp.SlateCore.Margin Padding;
    
    
    public static readonly int NativeDataSize;
    static HyperlinkStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("HyperlinkStyle");
        
        UnderlineStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UnderlineStyle");
        TextStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextStyle");
        Padding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Padding");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public HyperlinkStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            UnderlineStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, UnderlineStyle_Offset), 0, null);
            TextStyle = UnrealSharp.SlateCore.TextBlockStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, TextStyle_Offset), 0, null);
            Padding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, Padding_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, UnderlineStyle_Offset), 0, null, UnderlineStyle);
            UnrealSharp.SlateCore.TextBlockStyleMarshaler.ToNative(IntPtr.Add(Buffer, TextStyle_Offset), 0, null, TextStyle);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, Padding_Offset), 0, null, Padding);
        }
    }
}

public static class HyperlinkStyleMarshaler
{
    public static HyperlinkStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new HyperlinkStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, HyperlinkStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return HyperlinkStyle.NativeDataSize;
    }
}