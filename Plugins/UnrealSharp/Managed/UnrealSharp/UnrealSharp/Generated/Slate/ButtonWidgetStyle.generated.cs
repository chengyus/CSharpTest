// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UClass]
public partial class ButtonWidgetStyle : UnrealSharp.SlateCore.SlateWidgetStyleContainerBase
{
    
    static ButtonWidgetStyle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ButtonWidgetStyle");
        
        ButtonStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ButtonStyle");
        
        
        
    }
    
    protected ButtonWidgetStyle(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Slate.ButtonWidgetStyle:ButtonStyle
    static readonly int ButtonStyle_Offset;
    
    public UnrealSharp.SlateCore.ButtonStyle ButtonStyle
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(NativeObject, ButtonStyle_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(NativeObject, ButtonStyle_Offset), 0, this, value);
        }
    }
    
    
}