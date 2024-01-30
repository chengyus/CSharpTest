// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class ComboBoxString : UnrealSharp.UMG.Widget
{
    
    static ComboBoxString()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ComboBoxString");
        
        WidgetStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WidgetStyle");
        ItemStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemStyle");
        ScrollBarStyle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScrollBarStyle");
        ContentPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ContentPadding");
        MaxListHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxListHeight");
        HasDownArrow_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HasDownArrow");
        EnableGamepadNavigationMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnableGamepadNavigationMode");
        Font_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Font");
        ForegroundColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ForegroundColor");
        bIsFocusable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsFocusable");
        
        SetSelectedOption_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSelectedOption");
        SetSelectedOption_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSelectedOption_NativeFunction);
        SetSelectedOption_Option_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSelectedOption_NativeFunction, "Option");
        SetSelectedIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSelectedIndex");
        SetSelectedIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSelectedIndex_NativeFunction);
        SetSelectedIndex_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSelectedIndex_NativeFunction, "Index");
        RemoveOption_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveOption");
        RemoveOption_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveOption_NativeFunction);
        RemoveOption_Option_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveOption_NativeFunction, "Option");
        RemoveOption_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveOption_NativeFunction, "ReturnValue");
        RefreshOptions_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RefreshOptions");
        IsOpen_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsOpen");
        IsOpen_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsOpen_NativeFunction);
        IsOpen_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsOpen_NativeFunction, "ReturnValue");
        GetSelectedOption_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSelectedOption");
        GetSelectedOption_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSelectedOption_NativeFunction);
        GetSelectedOption_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSelectedOption_NativeFunction, "ReturnValue");
        GetSelectedIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSelectedIndex");
        GetSelectedIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSelectedIndex_NativeFunction);
        GetSelectedIndex_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSelectedIndex_NativeFunction, "ReturnValue");
        GetOptionCount_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOptionCount");
        GetOptionCount_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOptionCount_NativeFunction);
        GetOptionCount_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOptionCount_NativeFunction, "ReturnValue");
        GetOptionAtIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOptionAtIndex");
        GetOptionAtIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOptionAtIndex_NativeFunction);
        GetOptionAtIndex_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOptionAtIndex_NativeFunction, "Index");
        GetOptionAtIndex_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOptionAtIndex_NativeFunction, "ReturnValue");
        FindOptionIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "FindOptionIndex");
        FindOptionIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(FindOptionIndex_NativeFunction);
        FindOptionIndex_Option_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindOptionIndex_NativeFunction, "Option");
        FindOptionIndex_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(FindOptionIndex_NativeFunction, "ReturnValue");
        ClearSelection_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearSelection");
        ClearOptions_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearOptions");
        AddOption_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddOption");
        AddOption_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddOption_NativeFunction);
        AddOption_Option_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddOption_NativeFunction, "Option");
        
        
    }
    
    protected ComboBoxString(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.ComboBoxString:WidgetStyle
    static readonly int WidgetStyle_Offset;
    
    public UnrealSharp.SlateCore.ComboBoxStyle WidgetStyle
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.ComboBoxStyleMarshaler.FromNative(IntPtr.Add(NativeObject, WidgetStyle_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.SlateCore.ComboBoxStyleMarshaler.ToNative(IntPtr.Add(NativeObject, WidgetStyle_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.ComboBoxString:ItemStyle
    static readonly int ItemStyle_Offset;
    
    public UnrealSharp.SlateCore.TableRowStyle ItemStyle
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.TableRowStyleMarshaler.FromNative(IntPtr.Add(NativeObject, ItemStyle_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.SlateCore.TableRowStyleMarshaler.ToNative(IntPtr.Add(NativeObject, ItemStyle_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.ComboBoxString:ScrollBarStyle
    static readonly int ScrollBarStyle_Offset;
    
    public UnrealSharp.SlateCore.ScrollBarStyle ScrollBarStyle
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.ScrollBarStyleMarshaler.FromNative(IntPtr.Add(NativeObject, ScrollBarStyle_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/UMG.ComboBoxString:ContentPadding
    static readonly int ContentPadding_Offset;
    
    public UnrealSharp.SlateCore.Margin ContentPadding
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(NativeObject, ContentPadding_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(NativeObject, ContentPadding_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.ComboBoxString:MaxListHeight
    static readonly int MaxListHeight_Offset;
    
    public float MaxListHeight
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxListHeight_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxListHeight_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.ComboBoxString:HasDownArrow
    static readonly int HasDownArrow_Offset;
    
    public bool HasDownArrow
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, HasDownArrow_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, HasDownArrow_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.ComboBoxString:EnableGamepadNavigationMode
    static readonly int EnableGamepadNavigationMode_Offset;
    
    public bool EnableGamepadNavigationMode
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, EnableGamepadNavigationMode_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, EnableGamepadNavigationMode_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.ComboBoxString:Font
    static readonly int Font_Offset;
    
    public UnrealSharp.SlateCore.SlateFontInfo Font
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.SlateFontInfoMarshaler.FromNative(IntPtr.Add(NativeObject, Font_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/UMG.ComboBoxString:ForegroundColor
    static readonly int ForegroundColor_Offset;
    
    public UnrealSharp.SlateCore.SlateColor ForegroundColor
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.SlateColorMarshaler.FromNative(IntPtr.Add(NativeObject, ForegroundColor_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/UMG.ComboBoxString:bIsFocusable
    static readonly int bIsFocusable_Offset;
    
    public bool bIsFocusable
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bIsFocusable_Offset), 0, this);
        }
    }
    
    // Function /Script/UMG.ComboBoxString:SetSelectedOption
    static readonly IntPtr SetSelectedOption_NativeFunction;
    static readonly int SetSelectedOption_ParamsSize;
    static readonly int SetSelectedOption_Option_Offset;
    
    public void SetSelectedOption(string option)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSelectedOption_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Option_NativePtr = IntPtr.Add(ParamsBuffer,SetSelectedOption_Option_Offset);
            StringMarshaller.ToNative(Option_NativePtr,0,null,option);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSelectedOption_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Option_NativePtr, 0);
        }
    }
    
    // Function /Script/UMG.ComboBoxString:SetSelectedIndex
    static readonly IntPtr SetSelectedIndex_NativeFunction;
    static readonly int SetSelectedIndex_ParamsSize;
    static readonly int SetSelectedIndex_Index_Offset;
    
    public void SetSelectedIndex(int index)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSelectedIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetSelectedIndex_Index_Offset), 0, null, index);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSelectedIndex_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.ComboBoxString:RemoveOption
    static readonly IntPtr RemoveOption_NativeFunction;
    static readonly int RemoveOption_ParamsSize;
    static readonly int RemoveOption_Option_Offset;
    static readonly int RemoveOption_ReturnValue_Offset;
    
    public bool RemoveOption(string option)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveOption_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Option_NativePtr = IntPtr.Add(ParamsBuffer,RemoveOption_Option_Offset);
            StringMarshaller.ToNative(Option_NativePtr,0,null,option);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveOption_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, RemoveOption_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(Option_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/UMG.ComboBoxString:RefreshOptions
    static readonly IntPtr RefreshOptions_NativeFunction;
    
    public void RefreshOptions()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RefreshOptions_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.ComboBoxString:IsOpen
    static readonly IntPtr IsOpen_NativeFunction;
    static readonly int IsOpen_ParamsSize;
    static readonly int IsOpen_ReturnValue_Offset;
    
    public bool IsOpen()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsOpen_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsOpen_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsOpen_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.ComboBoxString:GetSelectedOption
    static readonly IntPtr GetSelectedOption_NativeFunction;
    static readonly int GetSelectedOption_ParamsSize;
    static readonly int GetSelectedOption_ReturnValue_Offset;
    
    public string GetSelectedOption()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSelectedOption_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSelectedOption_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetSelectedOption_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.ComboBoxString:GetSelectedIndex
    static readonly IntPtr GetSelectedIndex_NativeFunction;
    static readonly int GetSelectedIndex_ParamsSize;
    static readonly int GetSelectedIndex_ReturnValue_Offset;
    
    public int GetSelectedIndex()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSelectedIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSelectedIndex_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetSelectedIndex_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.ComboBoxString:GetOptionCount
    static readonly IntPtr GetOptionCount_NativeFunction;
    static readonly int GetOptionCount_ParamsSize;
    static readonly int GetOptionCount_ReturnValue_Offset;
    
    public int GetOptionCount()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetOptionCount_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOptionCount_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetOptionCount_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.ComboBoxString:GetOptionAtIndex
    static readonly IntPtr GetOptionAtIndex_NativeFunction;
    static readonly int GetOptionAtIndex_ParamsSize;
    static readonly int GetOptionAtIndex_Index_Offset;
    static readonly int GetOptionAtIndex_ReturnValue_Offset;
    
    public string GetOptionAtIndex(int index)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetOptionAtIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetOptionAtIndex_Index_Offset), 0, null, index);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOptionAtIndex_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetOptionAtIndex_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.ComboBoxString:FindOptionIndex
    static readonly IntPtr FindOptionIndex_NativeFunction;
    static readonly int FindOptionIndex_ParamsSize;
    static readonly int FindOptionIndex_Option_Offset;
    static readonly int FindOptionIndex_ReturnValue_Offset;
    
    public int FindOptionIndex(string option)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[FindOptionIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Option_NativePtr = IntPtr.Add(ParamsBuffer,FindOptionIndex_Option_Offset);
            StringMarshaller.ToNative(Option_NativePtr,0,null,option);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, FindOptionIndex_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, FindOptionIndex_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(Option_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/UMG.ComboBoxString:ClearSelection
    static readonly IntPtr ClearSelection_NativeFunction;
    
    public void ClearSelection()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearSelection_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.ComboBoxString:ClearOptions
    static readonly IntPtr ClearOptions_NativeFunction;
    
    public void ClearOptions()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearOptions_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.ComboBoxString:AddOption
    static readonly IntPtr AddOption_NativeFunction;
    static readonly int AddOption_ParamsSize;
    static readonly int AddOption_Option_Offset;
    
    public void AddOption(string option)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddOption_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Option_NativePtr = IntPtr.Add(ParamsBuffer,AddOption_Option_Offset);
            StringMarshaller.ToNative(Option_NativePtr,0,null,option);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddOption_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(Option_NativePtr, 0);
        }
    }
    
    
}