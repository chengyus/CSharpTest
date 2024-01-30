// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class InputKeySelector : UnrealSharp.UMG.Widget
{
    
    static InputKeySelector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InputKeySelector");
        
        WidgetStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WidgetStyle");
        TextStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TextStyle");
        SelectedKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SelectedKey");
        Margin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Margin");
        KeySelectionText_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "KeySelectionText");
        KeySelectionText_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "KeySelectionText");
        NoKeySpecifiedText_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NoKeySpecifiedText");
        NoKeySpecifiedText_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "NoKeySpecifiedText");
        bAllowModifierKeys_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowModifierKeys");
        bAllowGamepadKeys_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowGamepadKeys");
        EscapeKeys_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EscapeKeys");
        EscapeKeys_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EscapeKeys");
        
        SetTextBlockVisibility_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetTextBlockVisibility");
        SetTextBlockVisibility_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetTextBlockVisibility_NativeFunction);
        SetTextBlockVisibility_InVisibility_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetTextBlockVisibility_NativeFunction, "InVisibility");
        SetSelectedKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSelectedKey");
        SetSelectedKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSelectedKey_NativeFunction);
        SetSelectedKey_InSelectedKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSelectedKey_NativeFunction, "InSelectedKey");
        SetEscapeKeys_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetEscapeKeys");
        SetEscapeKeys_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetEscapeKeys_NativeFunction);
        SetEscapeKeys_InKeys_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetEscapeKeys_NativeFunction, "InKeys");
        SetEscapeKeys_InKeys_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(SetEscapeKeys_NativeFunction, "InKeys");
        SetAllowModifierKeys_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAllowModifierKeys");
        SetAllowModifierKeys_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAllowModifierKeys_NativeFunction);
        SetAllowModifierKeys_bInAllowModifierKeys_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAllowModifierKeys_NativeFunction, "bInAllowModifierKeys");
        SetAllowGamepadKeys_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAllowGamepadKeys");
        SetAllowGamepadKeys_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAllowGamepadKeys_NativeFunction);
        SetAllowGamepadKeys_bInAllowGamepadKeys_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAllowGamepadKeys_NativeFunction, "bInAllowGamepadKeys");
        GetIsSelectingKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetIsSelectingKey");
        GetIsSelectingKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetIsSelectingKey_NativeFunction);
        GetIsSelectingKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetIsSelectingKey_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InputKeySelector(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.InputKeySelector:WidgetStyle
    static readonly int WidgetStyle_Offset;
    
    public UnrealSharp.SlateCore.ButtonStyle WidgetStyle
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.ButtonStyleMarshaler.FromNative(IntPtr.Add(NativeObject, WidgetStyle_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.SlateCore.ButtonStyleMarshaler.ToNative(IntPtr.Add(NativeObject, WidgetStyle_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.InputKeySelector:TextStyle
    static readonly int TextStyle_Offset;
    
    public UnrealSharp.SlateCore.TextBlockStyle TextStyle
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.TextBlockStyleMarshaler.FromNative(IntPtr.Add(NativeObject, TextStyle_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.SlateCore.TextBlockStyleMarshaler.ToNative(IntPtr.Add(NativeObject, TextStyle_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.InputKeySelector:SelectedKey
    static readonly int SelectedKey_Offset;
    
    public UnrealSharp.Slate.InputChord SelectedKey
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.Slate.InputChordMarshaler.FromNative(IntPtr.Add(NativeObject, SelectedKey_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.Slate.InputChordMarshaler.ToNative(IntPtr.Add(NativeObject, SelectedKey_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.InputKeySelector:Margin
    static readonly int Margin_Offset;
    
    public UnrealSharp.SlateCore.Margin Margin
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(NativeObject, Margin_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(NativeObject, Margin_Offset), 0, this, value);
        }
    }
    
    // TextProperty /Script/UMG.InputKeySelector:KeySelectionText
    static readonly int KeySelectionText_Offset;
    static readonly IntPtr KeySelectionText_NativeProperty;
    TextMarshaller KeySelectionText_Wrapper;
    
    public Text KeySelectionText
    {
        get
        {
            if (KeySelectionText_Wrapper == null)
            {
                KeySelectionText_Wrapper  = new TextMarshaller(1);
            }
            return KeySelectionText_Wrapper.FromNative(this.NativeObject + KeySelectionText_Offset, 0, this);
        }
    }
    
    // TextProperty /Script/UMG.InputKeySelector:NoKeySpecifiedText
    static readonly int NoKeySpecifiedText_Offset;
    static readonly IntPtr NoKeySpecifiedText_NativeProperty;
    TextMarshaller NoKeySpecifiedText_Wrapper;
    
    public Text NoKeySpecifiedText
    {
        get
        {
            if (NoKeySpecifiedText_Wrapper == null)
            {
                NoKeySpecifiedText_Wrapper  = new TextMarshaller(1);
            }
            return NoKeySpecifiedText_Wrapper.FromNative(this.NativeObject + NoKeySpecifiedText_Offset, 0, this);
        }
    }
    
    // BoolProperty /Script/UMG.InputKeySelector:bAllowModifierKeys
    static readonly int bAllowModifierKeys_Offset;
    
    public bool bAllowModifierKeys
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bAllowModifierKeys_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bAllowModifierKeys_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.InputKeySelector:bAllowGamepadKeys
    static readonly int bAllowGamepadKeys_Offset;
    
    public bool bAllowGamepadKeys
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bAllowGamepadKeys_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bAllowGamepadKeys_Offset), 0, this, value);
        }
    }
    
    // ArrayProperty /Script/UMG.InputKeySelector:EscapeKeys
    static readonly int EscapeKeys_Offset;
    static readonly IntPtr EscapeKeys_NativeProperty;
    UnrealArrayReadOnlyMarshaler<UnrealSharp.InputCore.Key> EscapeKeys_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.InputCore.Key> EscapeKeys
    {
        get
        {
            if(EscapeKeys_Wrapper == null)
            {
                EscapeKeys_Wrapper = new UnrealArrayReadOnlyMarshaler<UnrealSharp.InputCore.Key>(1, EscapeKeys_NativeProperty, UnrealSharp.InputCore.KeyMarshaler.ToNative, UnrealSharp.InputCore.KeyMarshaler.FromNative);
            }
            
            return EscapeKeys_Wrapper.FromNative(IntPtr.Add(NativeObject,EscapeKeys_Offset),0,this);
        }
    }
    
    // Function /Script/UMG.InputKeySelector:SetTextBlockVisibility
    static readonly IntPtr SetTextBlockVisibility_NativeFunction;
    static readonly int SetTextBlockVisibility_ParamsSize;
    static readonly int SetTextBlockVisibility_InVisibility_Offset;
    
    public void SetTextBlockVisibility(UnrealSharp.UMG.ESlateVisibility inVisibility)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetTextBlockVisibility_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.UMG.ESlateVisibility>.ToNative(IntPtr.Add(ParamsBuffer, SetTextBlockVisibility_InVisibility_Offset), 0, null, inVisibility);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetTextBlockVisibility_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.InputKeySelector:SetSelectedKey
    static readonly IntPtr SetSelectedKey_NativeFunction;
    static readonly int SetSelectedKey_ParamsSize;
    static readonly int SetSelectedKey_InSelectedKey_Offset;
    
    public void SetSelectedKey(UnrealSharp.Slate.InputChord inSelectedKey)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSelectedKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Slate.InputChordMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetSelectedKey_InSelectedKey_Offset), 0, null, inSelectedKey);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSelectedKey_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/UMG.InputKeySelector:SetEscapeKeys
    static readonly IntPtr SetEscapeKeys_NativeFunction;
    static readonly int SetEscapeKeys_ParamsSize;
    static readonly int SetEscapeKeys_InKeys_Offset;
    static readonly int SetEscapeKeys_InKeys_ElementSize;
    
    public void SetEscapeKeys(System.Collections.Generic.IList<UnrealSharp.InputCore.Key> inKeys)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetEscapeKeys_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr InKeys_NativeBuffer = IntPtr.Add(ParamsBuffer, SetEscapeKeys_InKeys_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InputCore.Key> InKeys_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InputCore.Key>(1, UnrealSharp.InputCore.KeyMarshaler.ToNative, UnrealSharp.InputCore.KeyMarshaler.FromNative, SetEscapeKeys_InKeys_ElementSize);
            InKeys_Marshaler.ToNative(InKeys_NativeBuffer, 0, null, inKeys);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetEscapeKeys_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/UMG.InputKeySelector:SetAllowModifierKeys
    static readonly IntPtr SetAllowModifierKeys_NativeFunction;
    static readonly int SetAllowModifierKeys_ParamsSize;
    static readonly int SetAllowModifierKeys_bInAllowModifierKeys_Offset;
    
    public void SetAllowModifierKeys(bool bInAllowModifierKeys)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAllowModifierKeys_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetAllowModifierKeys_bInAllowModifierKeys_Offset), 0, null, bInAllowModifierKeys);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAllowModifierKeys_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.InputKeySelector:SetAllowGamepadKeys
    static readonly IntPtr SetAllowGamepadKeys_NativeFunction;
    static readonly int SetAllowGamepadKeys_ParamsSize;
    static readonly int SetAllowGamepadKeys_bInAllowGamepadKeys_Offset;
    
    public void SetAllowGamepadKeys(bool bInAllowGamepadKeys)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAllowGamepadKeys_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetAllowGamepadKeys_bInAllowGamepadKeys_Offset), 0, null, bInAllowGamepadKeys);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAllowGamepadKeys_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.InputKeySelector:GetIsSelectingKey
    static readonly IntPtr GetIsSelectingKey_NativeFunction;
    static readonly int GetIsSelectingKey_ParamsSize;
    static readonly int GetIsSelectingKey_ReturnValue_Offset;
    
    public bool GetIsSelectingKey()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetIsSelectingKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetIsSelectingKey_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetIsSelectingKey_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}