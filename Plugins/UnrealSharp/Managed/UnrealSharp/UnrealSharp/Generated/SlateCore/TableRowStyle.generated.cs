using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct TableRowStyle
{
    // StructProperty /Script/SlateCore.TableRowStyle:SelectorFocusedBrush
    static readonly int SelectorFocusedBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush SelectorFocusedBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:ActiveHoveredBrush
    static readonly int ActiveHoveredBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ActiveHoveredBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:ActiveBrush
    static readonly int ActiveBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ActiveBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:InactiveHoveredBrush
    static readonly int InactiveHoveredBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush InactiveHoveredBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:InactiveBrush
    static readonly int InactiveBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush InactiveBrush;
    
    // BoolProperty /Script/SlateCore.TableRowStyle:bUseParentRowBrush
    static readonly int bUseParentRowBrush_Offset;
    public bool UseParentRowBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:ParentRowBackgroundBrush
    static readonly int ParentRowBackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ParentRowBackgroundBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:ParentRowBackgroundHoveredBrush
    static readonly int ParentRowBackgroundHoveredBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ParentRowBackgroundHoveredBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:EvenRowBackgroundHoveredBrush
    static readonly int EvenRowBackgroundHoveredBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush EvenRowBackgroundHoveredBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:EvenRowBackgroundBrush
    static readonly int EvenRowBackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush EvenRowBackgroundBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:OddRowBackgroundHoveredBrush
    static readonly int OddRowBackgroundHoveredBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush OddRowBackgroundHoveredBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:OddRowBackgroundBrush
    static readonly int OddRowBackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush OddRowBackgroundBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:TextColor
    static readonly int TextColor_Offset;
    public UnrealSharp.SlateCore.SlateColor TextColor;
    
    // StructProperty /Script/SlateCore.TableRowStyle:SelectedTextColor
    static readonly int SelectedTextColor_Offset;
    public UnrealSharp.SlateCore.SlateColor SelectedTextColor;
    
    // StructProperty /Script/SlateCore.TableRowStyle:DropIndicator_Above
    static readonly int DropIndicator_Above_Offset;
    public UnrealSharp.SlateCore.SlateBrush DropIndicator_Above;
    
    // StructProperty /Script/SlateCore.TableRowStyle:DropIndicator_Onto
    static readonly int DropIndicator_Onto_Offset;
    public UnrealSharp.SlateCore.SlateBrush DropIndicator_Onto;
    
    // StructProperty /Script/SlateCore.TableRowStyle:DropIndicator_Below
    static readonly int DropIndicator_Below_Offset;
    public UnrealSharp.SlateCore.SlateBrush DropIndicator_Below;
    
    // StructProperty /Script/SlateCore.TableRowStyle:ActiveHighlightedBrush
    static readonly int ActiveHighlightedBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ActiveHighlightedBrush;
    
    // StructProperty /Script/SlateCore.TableRowStyle:InactiveHighlightedBrush
    static readonly int InactiveHighlightedBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush InactiveHighlightedBrush;
    
    
    public static readonly int NativeDataSize;
    static TableRowStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TableRowStyle");
        
        SelectorFocusedBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SelectorFocusedBrush");
        ActiveHoveredBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveHoveredBrush");
        ActiveBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveBrush");
        InactiveHoveredBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InactiveHoveredBrush");
        InactiveBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InactiveBrush");
        bUseParentRowBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseParentRowBrush");
        ParentRowBackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentRowBackgroundBrush");
        ParentRowBackgroundHoveredBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentRowBackgroundHoveredBrush");
        EvenRowBackgroundHoveredBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EvenRowBackgroundHoveredBrush");
        EvenRowBackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EvenRowBackgroundBrush");
        OddRowBackgroundHoveredBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OddRowBackgroundHoveredBrush");
        OddRowBackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OddRowBackgroundBrush");
        TextColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextColor");
        SelectedTextColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SelectedTextColor");
        DropIndicator_Above_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DropIndicator_Above");
        DropIndicator_Onto_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DropIndicator_Onto");
        DropIndicator_Below_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DropIndicator_Below");
        ActiveHighlightedBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActiveHighlightedBrush");
        InactiveHighlightedBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InactiveHighlightedBrush");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TableRowStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            SelectorFocusedBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, SelectorFocusedBrush_Offset), 0, null);
            ActiveHoveredBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ActiveHoveredBrush_Offset), 0, null);
            ActiveBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ActiveBrush_Offset), 0, null);
            InactiveHoveredBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, InactiveHoveredBrush_Offset), 0, null);
            InactiveBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, InactiveBrush_Offset), 0, null);
            UseParentRowBrush = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseParentRowBrush_Offset), 0, null);
            ParentRowBackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParentRowBackgroundBrush_Offset), 0, null);
            ParentRowBackgroundHoveredBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParentRowBackgroundHoveredBrush_Offset), 0, null);
            EvenRowBackgroundHoveredBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, EvenRowBackgroundHoveredBrush_Offset), 0, null);
            EvenRowBackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, EvenRowBackgroundBrush_Offset), 0, null);
            OddRowBackgroundHoveredBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, OddRowBackgroundHoveredBrush_Offset), 0, null);
            OddRowBackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, OddRowBackgroundBrush_Offset), 0, null);
            TextColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, TextColor_Offset), 0, null);
            SelectedTextColor = UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(InNativeStruct, SelectedTextColor_Offset), 0, null);
            DropIndicator_Above = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DropIndicator_Above_Offset), 0, null);
            DropIndicator_Onto = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DropIndicator_Onto_Offset), 0, null);
            DropIndicator_Below = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, DropIndicator_Below_Offset), 0, null);
            ActiveHighlightedBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ActiveHighlightedBrush_Offset), 0, null);
            InactiveHighlightedBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, InactiveHighlightedBrush_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, SelectorFocusedBrush_Offset), 0, null, SelectorFocusedBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ActiveHoveredBrush_Offset), 0, null, ActiveHoveredBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ActiveBrush_Offset), 0, null, ActiveBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, InactiveHoveredBrush_Offset), 0, null, InactiveHoveredBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, InactiveBrush_Offset), 0, null, InactiveBrush);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseParentRowBrush_Offset), 0, null, UseParentRowBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ParentRowBackgroundBrush_Offset), 0, null, ParentRowBackgroundBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ParentRowBackgroundHoveredBrush_Offset), 0, null, ParentRowBackgroundHoveredBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, EvenRowBackgroundHoveredBrush_Offset), 0, null, EvenRowBackgroundHoveredBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, EvenRowBackgroundBrush_Offset), 0, null, EvenRowBackgroundBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, OddRowBackgroundHoveredBrush_Offset), 0, null, OddRowBackgroundHoveredBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, OddRowBackgroundBrush_Offset), 0, null, OddRowBackgroundBrush);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, TextColor_Offset), 0, null, TextColor);
            UnrealSharp.SlateCore.SlateColorMarshaler.ToNative(IntPtr.Add(Buffer, SelectedTextColor_Offset), 0, null, SelectedTextColor);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DropIndicator_Above_Offset), 0, null, DropIndicator_Above);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DropIndicator_Onto_Offset), 0, null, DropIndicator_Onto);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, DropIndicator_Below_Offset), 0, null, DropIndicator_Below);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ActiveHighlightedBrush_Offset), 0, null, ActiveHighlightedBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, InactiveHighlightedBrush_Offset), 0, null, InactiveHighlightedBrush);
        }
    }
}

public static class TableRowStyleMarshaler
{
    public static TableRowStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TableRowStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TableRowStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TableRowStyle.NativeDataSize;
    }
}