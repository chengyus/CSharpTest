using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SlateCore;

[UStruct]
public partial struct ToolBarStyle
{
    // StructProperty /Script/SlateCore.ToolBarStyle:BackgroundBrush
    static readonly int BackgroundBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush BackgroundBrush;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:ExpandBrush
    static readonly int ExpandBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush ExpandBrush;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:SeparatorBrush
    static readonly int SeparatorBrush_Offset;
    public UnrealSharp.SlateCore.SlateBrush SeparatorBrush;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:LabelStyle
    static readonly int LabelStyle_Offset;
    public UnrealSharp.SlateCore.TextBlockStyle LabelStyle;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:EditableTextStyle
    static readonly int EditableTextStyle_Offset;
    public UnrealSharp.SlateCore.EditableTextBoxStyle EditableTextStyle;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:ToggleButton
    static readonly int ToggleButton_Offset;
    public UnrealSharp.SlateCore.CheckBoxStyle ToggleButton;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:ComboButtonStyle
    static readonly int ComboButtonStyle_Offset;
    public UnrealSharp.SlateCore.ComboButtonStyle ComboButtonStyle;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:SettingsButtonStyle
    static readonly int SettingsButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle SettingsButtonStyle;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:SettingsComboButton
    static readonly int SettingsComboButton_Offset;
    public UnrealSharp.SlateCore.ComboButtonStyle SettingsComboButton;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:SettingsToggleButton
    static readonly int SettingsToggleButton_Offset;
    public UnrealSharp.SlateCore.CheckBoxStyle SettingsToggleButton;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:ButtonStyle
    static readonly int ButtonStyle_Offset;
    public UnrealSharp.SlateCore.ButtonStyle ButtonStyle;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:LabelPadding
    static readonly int LabelPadding_Offset;
    public UnrealSharp.SlateCore.Margin LabelPadding;
    
    // FloatProperty /Script/SlateCore.ToolBarStyle:UniformBlockWidth
    static readonly int UniformBlockWidth_Offset;
    public float UniformBlockWidth;
    
    // FloatProperty /Script/SlateCore.ToolBarStyle:UniformBlockHeight
    static readonly int UniformBlockHeight_Offset;
    public float UniformBlockHeight;
    
    // IntProperty /Script/SlateCore.ToolBarStyle:NumColumns
    static readonly int NumColumns_Offset;
    public int NumColumns;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:IconPadding
    static readonly int IconPadding_Offset;
    public UnrealSharp.SlateCore.Margin IconPadding;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:SeparatorPadding
    static readonly int SeparatorPadding_Offset;
    public UnrealSharp.SlateCore.Margin SeparatorPadding;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:ComboButtonPadding
    static readonly int ComboButtonPadding_Offset;
    public UnrealSharp.SlateCore.Margin ComboButtonPadding;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:ButtonPadding
    static readonly int ButtonPadding_Offset;
    public UnrealSharp.SlateCore.Margin ButtonPadding;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:CheckBoxPadding
    static readonly int CheckBoxPadding_Offset;
    public UnrealSharp.SlateCore.Margin CheckBoxPadding;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:BlockPadding
    static readonly int BlockPadding_Offset;
    public UnrealSharp.SlateCore.Margin BlockPadding;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:IndentedBlockPadding
    static readonly int IndentedBlockPadding_Offset;
    public UnrealSharp.SlateCore.Margin IndentedBlockPadding;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:BackgroundPadding
    static readonly int BackgroundPadding_Offset;
    public UnrealSharp.SlateCore.Margin BackgroundPadding;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:IconSize
    static readonly int IconSize_Offset;
    public UnrealSharp.SlateCore.DeprecateSlateVector2D IconSize;
    
    // BoolProperty /Script/SlateCore.ToolBarStyle:bShowLabels
    static readonly int bShowLabels_Offset;
    public bool ShowLabels;
    
    // FloatProperty /Script/SlateCore.ToolBarStyle:ButtonContentMaxWidth
    static readonly int ButtonContentMaxWidth_Offset;
    public float ButtonContentMaxWidth;
    
    // FloatProperty /Script/SlateCore.ToolBarStyle:ButtonContentFillWidth
    static readonly int ButtonContentFillWidth_Offset;
    public float ButtonContentFillWidth;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:IconPaddingWithVisibleLabel
    static readonly int IconPaddingWithVisibleLabel_Offset;
    public UnrealSharp.SlateCore.Margin IconPaddingWithVisibleLabel;
    
    // StructProperty /Script/SlateCore.ToolBarStyle:IconPaddingWithCollapsedLabel
    static readonly int IconPaddingWithCollapsedLabel_Offset;
    public UnrealSharp.SlateCore.Margin IconPaddingWithCollapsedLabel;
    
    
    public static readonly int NativeDataSize;
    static ToolBarStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ToolBarStyle");
        
        BackgroundBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundBrush");
        ExpandBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExpandBrush");
        SeparatorBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SeparatorBrush");
        LabelStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LabelStyle");
        EditableTextStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EditableTextStyle");
        ToggleButton_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ToggleButton");
        ComboButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComboButtonStyle");
        SettingsButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SettingsButtonStyle");
        SettingsComboButton_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SettingsComboButton");
        SettingsToggleButton_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SettingsToggleButton");
        ButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ButtonStyle");
        LabelPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LabelPadding");
        UniformBlockWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UniformBlockWidth");
        UniformBlockHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UniformBlockHeight");
        NumColumns_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumColumns");
        IconPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IconPadding");
        SeparatorPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SeparatorPadding");
        ComboButtonPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComboButtonPadding");
        ButtonPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ButtonPadding");
        CheckBoxPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CheckBoxPadding");
        BlockPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlockPadding");
        IndentedBlockPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IndentedBlockPadding");
        BackgroundPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BackgroundPadding");
        IconSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IconSize");
        bShowLabels_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowLabels");
        ButtonContentMaxWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ButtonContentMaxWidth");
        ButtonContentFillWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ButtonContentFillWidth");
        IconPaddingWithVisibleLabel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IconPaddingWithVisibleLabel");
        IconPaddingWithCollapsedLabel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IconPaddingWithCollapsedLabel");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ToolBarStyle(IntPtr InNativeStruct)
    {
        unsafe
        {
            BackgroundBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, BackgroundBrush_Offset), 0, null);
            ExpandBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, ExpandBrush_Offset), 0, null);
            SeparatorBrush = UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(InNativeStruct, SeparatorBrush_Offset), 0, null);
            LabelStyle = UnrealSharp.SlateCore.TextBlockStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, LabelStyle_Offset), 0, null);
            EditableTextStyle = UnrealSharp.SlateCore.EditableTextBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, EditableTextStyle_Offset), 0, null);
            ToggleButton = UnrealSharp.SlateCore.CheckBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, ToggleButton_Offset), 0, null);
            ComboButtonStyle = UnrealSharp.SlateCore.ComboButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, ComboButtonStyle_Offset), 0, null);
            SettingsButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, SettingsButtonStyle_Offset), 0, null);
            SettingsComboButton = UnrealSharp.SlateCore.ComboButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, SettingsComboButton_Offset), 0, null);
            SettingsToggleButton = UnrealSharp.SlateCore.CheckBoxStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, SettingsToggleButton_Offset), 0, null);
            ButtonStyle = UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(InNativeStruct, ButtonStyle_Offset), 0, null);
            LabelPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, LabelPadding_Offset), 0, null);
            UniformBlockWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, UniformBlockWidth_Offset), 0, null);
            UniformBlockHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, UniformBlockHeight_Offset), 0, null);
            NumColumns = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, NumColumns_Offset), 0, null);
            IconPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, IconPadding_Offset), 0, null);
            SeparatorPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, SeparatorPadding_Offset), 0, null);
            ComboButtonPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, ComboButtonPadding_Offset), 0, null);
            ButtonPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, ButtonPadding_Offset), 0, null);
            CheckBoxPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, CheckBoxPadding_Offset), 0, null);
            BlockPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, BlockPadding_Offset), 0, null);
            IndentedBlockPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, IndentedBlockPadding_Offset), 0, null);
            BackgroundPadding = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, BackgroundPadding_Offset), 0, null);
            IconSize = UnrealSharp.SlateCore.DeprecateSlateVector2DMarshaler.FromNative(IntPtr.Add(InNativeStruct, IconSize_Offset), 0, null);
            ShowLabels = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShowLabels_Offset), 0, null);
            ButtonContentMaxWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ButtonContentMaxWidth_Offset), 0, null);
            ButtonContentFillWidth = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ButtonContentFillWidth_Offset), 0, null);
            IconPaddingWithVisibleLabel = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, IconPaddingWithVisibleLabel_Offset), 0, null);
            IconPaddingWithCollapsedLabel = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(InNativeStruct, IconPaddingWithCollapsedLabel_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, BackgroundBrush_Offset), 0, null, BackgroundBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, ExpandBrush_Offset), 0, null, ExpandBrush);
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(Buffer, SeparatorBrush_Offset), 0, null, SeparatorBrush);
            UnrealSharp.SlateCore.TextBlockStyleMarshaler.ToNative(IntPtr.Add(Buffer, LabelStyle_Offset), 0, null, LabelStyle);
            UnrealSharp.SlateCore.EditableTextBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, EditableTextStyle_Offset), 0, null, EditableTextStyle);
            UnrealSharp.SlateCore.CheckBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, ToggleButton_Offset), 0, null, ToggleButton);
            UnrealSharp.SlateCore.ComboButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, ComboButtonStyle_Offset), 0, null, ComboButtonStyle);
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, SettingsButtonStyle_Offset), 0, null, SettingsButtonStyle);
            UnrealSharp.SlateCore.ComboButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, SettingsComboButton_Offset), 0, null, SettingsComboButton);
            UnrealSharp.SlateCore.CheckBoxStyleMarshaler.ToNative(IntPtr.Add(Buffer, SettingsToggleButton_Offset), 0, null, SettingsToggleButton);
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(Buffer, ButtonStyle_Offset), 0, null, ButtonStyle);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, LabelPadding_Offset), 0, null, LabelPadding);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, UniformBlockWidth_Offset), 0, null, UniformBlockWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, UniformBlockHeight_Offset), 0, null, UniformBlockHeight);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, NumColumns_Offset), 0, null, NumColumns);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, IconPadding_Offset), 0, null, IconPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, SeparatorPadding_Offset), 0, null, SeparatorPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, ComboButtonPadding_Offset), 0, null, ComboButtonPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, ButtonPadding_Offset), 0, null, ButtonPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, CheckBoxPadding_Offset), 0, null, CheckBoxPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, BlockPadding_Offset), 0, null, BlockPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, IndentedBlockPadding_Offset), 0, null, IndentedBlockPadding);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, BackgroundPadding_Offset), 0, null, BackgroundPadding);
            UnrealSharp.SlateCore.DeprecateSlateVector2DMarshaler.ToNative(IntPtr.Add(Buffer, IconSize_Offset), 0, null, IconSize);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShowLabels_Offset), 0, null, ShowLabels);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ButtonContentMaxWidth_Offset), 0, null, ButtonContentMaxWidth);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ButtonContentFillWidth_Offset), 0, null, ButtonContentFillWidth);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, IconPaddingWithVisibleLabel_Offset), 0, null, IconPaddingWithVisibleLabel);
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(Buffer, IconPaddingWithCollapsedLabel_Offset), 0, null, IconPaddingWithCollapsedLabel);
        }
    }
}

public static class ToolBarStyleMarshaler
{
    public static ToolBarStyle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ToolBarStyle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ToolBarStyle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ToolBarStyle.NativeDataSize;
    }
}