using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct ComboBoxStyle
{
    // StructProperty /Script/SlateCore.ComboBoxStyle:ComboButtonStyle
    static readonly int ComboButtonStyle_Offset;
    public UnrealSharp.SlateCore.ComboButtonStyle ComboButtonStyle;
    
    // StructProperty /Script/SlateCore.ComboBoxStyle:PressedSlateSound
    static readonly int PressedSlateSound_Offset;
    public UnrealSharp.SlateCore.SlateSound PressedSlateSound;
    
    // StructProperty /Script/SlateCore.ComboBoxStyle:SelectionChangeSlateSound
    static readonly int SelectionChangeSlateSound_Offset;
    public UnrealSharp.SlateCore.SlateSound SelectionChangeSlateSound;
    
    // StructProperty /Script/SlateCore.ComboBoxStyle:ContentPadding
    static readonly int ContentPadding_Offset;
    public UnrealSharp.SlateCore.Margin ContentPadding;
    
    // StructProperty /Script/SlateCore.ComboBoxStyle:MenuRowPadding
    static readonly int MenuRowPadding_Offset;
    public UnrealSharp.SlateCore.Margin MenuRowPadding;
    
    
    public static readonly int NativeDataSize;
    static ComboBoxStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ComboBoxStyle");
        
        ComboButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComboButtonStyle");
        PressedSlateSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PressedSlateSound");
        SelectionChangeSlateSound_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SelectionChangeSlateSound");
        ContentPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ContentPadding");
        MenuRowPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MenuRowPadding");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ComboBoxStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComboButtonStyle = UnrealSharp.SlateCore.ComboButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, ComboButtonStyle_Offset), 0, null);
            PressedSlateSound = UnrealSharp.SlateCore.SlateSoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, PressedSlateSound_Offset), 0, null);
            SelectionChangeSlateSound = UnrealSharp.SlateCore.SlateSoundMarshaler.FromNative(IntPtr.Add(InNativeStruct, SelectionChangeSlateSound_Offset), 0, null);
            ContentPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, ContentPadding_Offset), 0, null);
            MenuRowPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, MenuRowPadding_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.ComboButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, ComboButtonStyle_Offset), 0, null, ComboButtonStyle);
            UnrealSharp.SlateCore.SlateSoundMarshaler.ToNative(IntPtr.Add(Buffer, PressedSlateSound_Offset), 0, null, PressedSlateSound);
            UnrealSharp.SlateCore.SlateSoundMarshaler.ToNative(IntPtr.Add(Buffer, SelectionChangeSlateSound_Offset), 0, null, SelectionChangeSlateSound);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, ContentPadding_Offset), 0, null, ContentPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, MenuRowPadding_Offset), 0, null, MenuRowPadding);
        }
    }
}

public static class ComboBoxStyleMarshaler
{
    public static ComboBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ComboBoxStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ComboBoxStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ComboBoxStyle.NativeDataSize;
    }
}