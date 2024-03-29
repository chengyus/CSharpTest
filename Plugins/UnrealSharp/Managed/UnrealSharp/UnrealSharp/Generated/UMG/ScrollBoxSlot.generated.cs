// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class ScrollBoxSlot : UnrealSharp.UMG.PanelSlot
{
    
    static ScrollBoxSlot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ScrollBoxSlot");
        
        Size_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Size");
        Padding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Padding");
        HorizontalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HorizontalAlignment");
        VerticalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VerticalAlignment");
        
        SetVerticalAlignment_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetVerticalAlignment");
        SetVerticalAlignment_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetVerticalAlignment_NativeFunction);
        SetVerticalAlignment_InVerticalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVerticalAlignment_NativeFunction, "InVerticalAlignment");
        SetPadding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPadding");
        SetPadding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPadding_NativeFunction);
        SetPadding_InPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPadding_NativeFunction, "InPadding");
        SetHorizontalAlignment_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetHorizontalAlignment");
        SetHorizontalAlignment_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetHorizontalAlignment_NativeFunction);
        SetHorizontalAlignment_InHorizontalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetHorizontalAlignment_NativeFunction, "InHorizontalAlignment");
        
        
    }
    
    protected ScrollBoxSlot(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.ScrollBoxSlot:Size
    static readonly int Size_Offset;
    
    public UnrealSharp.UMG.SlateChildSize Size
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.UMG.SlateChildSizeMarshaler.FromNative(IntPtr.Add(NativeObject, Size_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.UMG.SlateChildSizeMarshaler.ToNative(IntPtr.Add(NativeObject, Size_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.ScrollBoxSlot:Padding
    static readonly int Padding_Offset;
    
    public UnrealSharp.SlateCore.Margin Padding
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(NativeObject, Padding_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/UMG.ScrollBoxSlot:HorizontalAlignment
    static readonly int HorizontalAlignment_Offset;
    
    public UnrealSharp.SlateCore.EHorizontalAlignment HorizontalAlignment
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.EHorizontalAlignment>.FromNative(IntPtr.Add(NativeObject, HorizontalAlignment_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/UMG.ScrollBoxSlot:VerticalAlignment
    static readonly int VerticalAlignment_Offset;
    
    public UnrealSharp.SlateCore.EVerticalAlignment VerticalAlignment
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.FromNative(IntPtr.Add(NativeObject, VerticalAlignment_Offset), 0, this);
        }
    }
    
    // Function /Script/UMG.ScrollBoxSlot:SetVerticalAlignment
    static readonly IntPtr SetVerticalAlignment_NativeFunction;
    static readonly int SetVerticalAlignment_ParamsSize;
    static readonly int SetVerticalAlignment_InVerticalAlignment_Offset;
    
    public void SetVerticalAlignment(UnrealSharp.SlateCore.EVerticalAlignment inVerticalAlignment)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetVerticalAlignment_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.ToNative(IntPtr.Add(ParamsBuffer, SetVerticalAlignment_InVerticalAlignment_Offset), 0, null, inVerticalAlignment);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetVerticalAlignment_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.ScrollBoxSlot:SetPadding
    static readonly IntPtr SetPadding_NativeFunction;
    static readonly int SetPadding_ParamsSize;
    static readonly int SetPadding_InPadding_Offset;
    
    public void SetPadding(UnrealSharp.SlateCore.Margin inPadding)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPadding_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(ParamsBuffer, SetPadding_InPadding_Offset), 0, null, inPadding);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPadding_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.ScrollBoxSlot:SetHorizontalAlignment
    static readonly IntPtr SetHorizontalAlignment_NativeFunction;
    static readonly int SetHorizontalAlignment_ParamsSize;
    static readonly int SetHorizontalAlignment_InHorizontalAlignment_Offset;
    
    public void SetHorizontalAlignment(UnrealSharp.SlateCore.EHorizontalAlignment inHorizontalAlignment)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetHorizontalAlignment_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.SlateCore.EHorizontalAlignment>.ToNative(IntPtr.Add(ParamsBuffer, SetHorizontalAlignment_InHorizontalAlignment_Offset), 0, null, inHorizontalAlignment);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetHorizontalAlignment_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}