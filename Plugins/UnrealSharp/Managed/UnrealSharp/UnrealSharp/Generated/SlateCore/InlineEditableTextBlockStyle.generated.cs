using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct InlineEditableTextBlockStyle
{
    // StructProperty /Script/SlateCore.InlineEditableTextBlockStyle:EditableTextBoxStyle
    static readonly int EditableTextBoxStyle_Offset;
    public UnrealSharp.SlateCore.EditableTextBoxStyle EditableTextBoxStyle;
    
    // StructProperty /Script/SlateCore.InlineEditableTextBlockStyle:TextStyle
    static readonly int TextStyle_Offset;
    public UnrealSharp.SlateCore.TextBlockStyle TextStyle;
    
    
    public static readonly int NativeDataSize;
    static InlineEditableTextBlockStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InlineEditableTextBlockStyle");
        
        EditableTextBoxStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EditableTextBoxStyle");
        TextStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextStyle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InlineEditableTextBlockStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            EditableTextBoxStyle = UnrealSharp.SlateCore.EditableTextBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, EditableTextBoxStyle_Offset), 0, null);
            TextStyle = UnrealSharp.SlateCore.TextBlockStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, TextStyle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.EditableTextBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, EditableTextBoxStyle_Offset), 0, null, EditableTextBoxStyle);
            UnrealSharp.SlateCore.TextBlockStyleMarshaler.ToNative(IntPtr.Add(Buffer, TextStyle_Offset), 0, null, TextStyle);
        }
    }
}

public static class InlineEditableTextBlockStyleMarshaler
{
    public static InlineEditableTextBlockStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InlineEditableTextBlockStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InlineEditableTextBlockStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InlineEditableTextBlockStyle.NativeDataSize;
    }
}