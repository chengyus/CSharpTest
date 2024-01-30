// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class WrapBoxSlot : UnrealSharp.UMG.PanelSlot
{
    
    static WrapBoxSlot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("WrapBoxSlot");
        
        Padding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Padding");
        FillSpanWhenLessThan_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FillSpanWhenLessThan");
        HorizontalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HorizontalAlignment");
        VerticalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VerticalAlignment");
        bFillEmptySpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bFillEmptySpace");
        bForceNewLine_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceNewLine");
        
        SetVerticalAlignment_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetVerticalAlignment");
        SetVerticalAlignment_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetVerticalAlignment_NativeFunction);
        SetVerticalAlignment_InVerticalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVerticalAlignment_NativeFunction, "InVerticalAlignment");
        SetPadding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPadding");
        SetPadding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPadding_NativeFunction);
        SetPadding_InPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPadding_NativeFunction, "InPadding");
        SetNewLine_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNewLine");
        SetNewLine_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNewLine_NativeFunction);
        SetNewLine_InForceNewLine_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNewLine_NativeFunction, "InForceNewLine");
        SetHorizontalAlignment_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetHorizontalAlignment");
        SetHorizontalAlignment_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetHorizontalAlignment_NativeFunction);
        SetHorizontalAlignment_InHorizontalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetHorizontalAlignment_NativeFunction, "InHorizontalAlignment");
        SetFillSpanWhenLessThan_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFillSpanWhenLessThan");
        SetFillSpanWhenLessThan_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFillSpanWhenLessThan_NativeFunction);
        SetFillSpanWhenLessThan_InFillSpanWhenLessThan_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFillSpanWhenLessThan_NativeFunction, "InFillSpanWhenLessThan");
        SetFillEmptySpace_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFillEmptySpace");
        SetFillEmptySpace_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFillEmptySpace_NativeFunction);
        SetFillEmptySpace_InbFillEmptySpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFillEmptySpace_NativeFunction, "InbFillEmptySpace");
        
        
    }
    
    protected WrapBoxSlot(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.WrapBoxSlot:Padding
    static readonly int Padding_Offset;
    
    public UnrealSharp.SlateCore.Margin Padding
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(NativeObject, Padding_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(NativeObject, Padding_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.WrapBoxSlot:FillSpanWhenLessThan
    static readonly int FillSpanWhenLessThan_Offset;
    
    public float FillSpanWhenLessThan
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, FillSpanWhenLessThan_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, FillSpanWhenLessThan_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/UMG.WrapBoxSlot:HorizontalAlignment
    static readonly int HorizontalAlignment_Offset;
    
    public UnrealSharp.SlateCore.EHorizontalAlignment HorizontalAlignment
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.EHorizontalAlignment>.FromNative(IntPtr.Add(NativeObject, HorizontalAlignment_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.EHorizontalAlignment>.ToNative(IntPtr.Add(NativeObject, HorizontalAlignment_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/UMG.WrapBoxSlot:VerticalAlignment
    static readonly int VerticalAlignment_Offset;
    
    public UnrealSharp.SlateCore.EVerticalAlignment VerticalAlignment
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.FromNative(IntPtr.Add(NativeObject, VerticalAlignment_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.ToNative(IntPtr.Add(NativeObject, VerticalAlignment_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.WrapBoxSlot:bFillEmptySpace
    static readonly int bFillEmptySpace_Offset;
    
    public bool bFillEmptySpace
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bFillEmptySpace_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bFillEmptySpace_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.WrapBoxSlot:bForceNewLine
    static readonly int bForceNewLine_Offset;
    
    public bool bForceNewLine
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bForceNewLine_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bForceNewLine_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.WrapBoxSlot:SetVerticalAlignment
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
    
    // Function /Script/UMG.WrapBoxSlot:SetPadding
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
    
    // Function /Script/UMG.WrapBoxSlot:SetNewLine
    static readonly IntPtr SetNewLine_NativeFunction;
    static readonly int SetNewLine_ParamsSize;
    static readonly int SetNewLine_InForceNewLine_Offset;
    
    public void SetNewLine(bool inForceNewLine)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNewLine_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetNewLine_InForceNewLine_Offset), 0, null, inForceNewLine);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetNewLine_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.WrapBoxSlot:SetHorizontalAlignment
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
    
    // Function /Script/UMG.WrapBoxSlot:SetFillSpanWhenLessThan
    static readonly IntPtr SetFillSpanWhenLessThan_NativeFunction;
    static readonly int SetFillSpanWhenLessThan_ParamsSize;
    static readonly int SetFillSpanWhenLessThan_InFillSpanWhenLessThan_Offset;
    
    public void SetFillSpanWhenLessThan(float inFillSpanWhenLessThan)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFillSpanWhenLessThan_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetFillSpanWhenLessThan_InFillSpanWhenLessThan_Offset), 0, null, inFillSpanWhenLessThan);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFillSpanWhenLessThan_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.WrapBoxSlot:SetFillEmptySpace
    static readonly IntPtr SetFillEmptySpace_NativeFunction;
    static readonly int SetFillEmptySpace_ParamsSize;
    static readonly int SetFillEmptySpace_InbFillEmptySpace_Offset;
    
    public void SetFillEmptySpace(bool inbFillEmptySpace)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFillEmptySpace_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetFillEmptySpace_InbFillEmptySpace_Offset), 0, null, inbFillEmptySpace);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFillEmptySpace_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}