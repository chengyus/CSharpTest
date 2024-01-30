// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
abstract public partial class TextLayoutWidget : UnrealSharp.UMG.Widget
{
    
    static TextLayoutWidget()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TextLayoutWidget");
        
        ShapedTextOptions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShapedTextOptions");
        Justification_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Justification");
        WrappingPolicy_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WrappingPolicy");
        AutoWrapText_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutoWrapText");
        AutoWrapText_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AutoWrapText");
        WrapTextAt_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WrapTextAt");
        Margin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Margin");
        LineHeightPercentage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LineHeightPercentage");
        
        
        
    }
    
    protected TextLayoutWidget(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.TextLayoutWidget:ShapedTextOptions
    static readonly int ShapedTextOptions_Offset;
    
    public UnrealSharp.UMG.ShapedTextOptions ShapedTextOptions
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.UMG.ShapedTextOptionsMarshaler.FromNative(IntPtr.Add(NativeObject, ShapedTextOptions_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/UMG.TextLayoutWidget:Justification
    static readonly int Justification_Offset;
    
    public UnrealSharp.Slate.ETextJustify Justification
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Slate.ETextJustify>.FromNative(IntPtr.Add(NativeObject, Justification_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Slate.ETextJustify>.ToNative(IntPtr.Add(NativeObject, Justification_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/UMG.TextLayoutWidget:WrappingPolicy
    static readonly int WrappingPolicy_Offset;
    
    public UnrealSharp.Slate.ETextWrappingPolicy WrappingPolicy
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Slate.ETextWrappingPolicy>.FromNative(IntPtr.Add(NativeObject, WrappingPolicy_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/UMG.TextLayoutWidget:AutoWrapText
    static readonly int AutoWrapText_Offset;
    static readonly IntPtr AutoWrapText_NativeProperty;
    
    public bool AutoWrapText
    {
        get
        {
            CheckObjectForValidity();
            return FBoolPropertyExporter.CallGetBitfieldValueFromProperty(NativeObject, AutoWrapText_NativeProperty, AutoWrapText_Offset);
        }
    }
    
    // FloatProperty /Script/UMG.TextLayoutWidget:WrapTextAt
    static readonly int WrapTextAt_Offset;
    
    public float WrapTextAt
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, WrapTextAt_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/UMG.TextLayoutWidget:Margin
    static readonly int Margin_Offset;
    
    public UnrealSharp.SlateCore.Margin Margin
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(NativeObject, Margin_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/UMG.TextLayoutWidget:LineHeightPercentage
    static readonly int LineHeightPercentage_Offset;
    
    public float LineHeightPercentage
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, LineHeightPercentage_Offset), 0, this);
        }
    }
    
    
}