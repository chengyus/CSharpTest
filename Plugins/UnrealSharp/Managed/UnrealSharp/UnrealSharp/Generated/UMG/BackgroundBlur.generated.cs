// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class BackgroundBlur : UnrealSharp.UMG.ContentWidget
{
    
    static BackgroundBlur()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("BackgroundBlur");
        
        Padding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Padding");
        HorizontalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HorizontalAlignment");
        VerticalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VerticalAlignment");
        bApplyAlphaToBlur_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyAlphaToBlur");
        BlurStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlurStrength");
        BlurRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlurRadius");
        CornerRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CornerRadius");
        LowQualityFallbackBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LowQualityFallbackBrush");
        
        SetVerticalAlignment_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetVerticalAlignment");
        SetVerticalAlignment_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetVerticalAlignment_NativeFunction);
        SetVerticalAlignment_InVerticalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVerticalAlignment_NativeFunction, "InVerticalAlignment");
        SetPadding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPadding");
        SetPadding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPadding_NativeFunction);
        SetPadding_InPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPadding_NativeFunction, "InPadding");
        SetLowQualityFallbackBrush_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLowQualityFallbackBrush");
        SetLowQualityFallbackBrush_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLowQualityFallbackBrush_NativeFunction);
        SetLowQualityFallbackBrush_InBrush_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLowQualityFallbackBrush_NativeFunction, "InBrush");
        SetHorizontalAlignment_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetHorizontalAlignment");
        SetHorizontalAlignment_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetHorizontalAlignment_NativeFunction);
        SetHorizontalAlignment_InHorizontalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetHorizontalAlignment_NativeFunction, "InHorizontalAlignment");
        SetCornerRadius_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCornerRadius");
        SetCornerRadius_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCornerRadius_NativeFunction);
        SetCornerRadius_InCornerRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCornerRadius_NativeFunction, "InCornerRadius");
        SetBlurStrength_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBlurStrength");
        SetBlurStrength_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBlurStrength_NativeFunction);
        SetBlurStrength_InStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBlurStrength_NativeFunction, "InStrength");
        SetBlurRadius_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBlurRadius");
        SetBlurRadius_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBlurRadius_NativeFunction);
        SetBlurRadius_InBlurRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBlurRadius_NativeFunction, "InBlurRadius");
        SetApplyAlphaToBlur_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetApplyAlphaToBlur");
        SetApplyAlphaToBlur_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetApplyAlphaToBlur_NativeFunction);
        SetApplyAlphaToBlur_bInApplyAlphaToBlur_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetApplyAlphaToBlur_NativeFunction, "bInApplyAlphaToBlur");
        
        
    }
    
    protected BackgroundBlur(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.BackgroundBlur:Padding
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
    
    // ByteProperty /Script/UMG.BackgroundBlur:HorizontalAlignment
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
    
    // ByteProperty /Script/UMG.BackgroundBlur:VerticalAlignment
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
    
    // BoolProperty /Script/UMG.BackgroundBlur:bApplyAlphaToBlur
    static readonly int bApplyAlphaToBlur_Offset;
    
    public bool bApplyAlphaToBlur
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bApplyAlphaToBlur_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bApplyAlphaToBlur_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.BackgroundBlur:BlurStrength
    static readonly int BlurStrength_Offset;
    
    public float BlurStrength
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, BlurStrength_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, BlurStrength_Offset), 0, this, value);
        }
    }
    
    // IntProperty /Script/UMG.BackgroundBlur:BlurRadius
    static readonly int BlurRadius_Offset;
    
    public int BlurRadius
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, BlurRadius_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, BlurRadius_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.BackgroundBlur:CornerRadius
    static readonly int CornerRadius_Offset;
    
    public System.DoubleNumerics.Vector4 CornerRadius
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector4>.FromNative(IntPtr.Add(NativeObject, CornerRadius_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(NativeObject, CornerRadius_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.BackgroundBlur:LowQualityFallbackBrush
    static readonly int LowQualityFallbackBrush_Offset;
    
    public UnrealSharp.SlateCore.SlateBrush LowQualityFallbackBrush
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(NativeObject, LowQualityFallbackBrush_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(NativeObject, LowQualityFallbackBrush_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.BackgroundBlur:SetVerticalAlignment
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
    
    // Function /Script/UMG.BackgroundBlur:SetPadding
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
    
    // Function /Script/UMG.BackgroundBlur:SetLowQualityFallbackBrush
    static readonly IntPtr SetLowQualityFallbackBrush_NativeFunction;
    static readonly int SetLowQualityFallbackBrush_ParamsSize;
    static readonly int SetLowQualityFallbackBrush_InBrush_Offset;
    
    public void SetLowQualityFallbackBrush(UnrealSharp.SlateCore.SlateBrush inBrush)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLowQualityFallbackBrush_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetLowQualityFallbackBrush_InBrush_Offset), 0, null, inBrush);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLowQualityFallbackBrush_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/UMG.BackgroundBlur:SetHorizontalAlignment
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
    
    // Function /Script/UMG.BackgroundBlur:SetCornerRadius
    static readonly IntPtr SetCornerRadius_NativeFunction;
    static readonly int SetCornerRadius_ParamsSize;
    static readonly int SetCornerRadius_InCornerRadius_Offset;
    
    public void SetCornerRadius(System.DoubleNumerics.Vector4 inCornerRadius)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCornerRadius_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector4>.ToNative(IntPtr.Add(ParamsBuffer, SetCornerRadius_InCornerRadius_Offset), 0, null, inCornerRadius);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCornerRadius_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.BackgroundBlur:SetBlurStrength
    static readonly IntPtr SetBlurStrength_NativeFunction;
    static readonly int SetBlurStrength_ParamsSize;
    static readonly int SetBlurStrength_InStrength_Offset;
    
    public void SetBlurStrength(float inStrength)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBlurStrength_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetBlurStrength_InStrength_Offset), 0, null, inStrength);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBlurStrength_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.BackgroundBlur:SetBlurRadius
    static readonly IntPtr SetBlurRadius_NativeFunction;
    static readonly int SetBlurRadius_ParamsSize;
    static readonly int SetBlurRadius_InBlurRadius_Offset;
    
    public void SetBlurRadius(int inBlurRadius)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBlurRadius_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetBlurRadius_InBlurRadius_Offset), 0, null, inBlurRadius);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBlurRadius_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.BackgroundBlur:SetApplyAlphaToBlur
    static readonly IntPtr SetApplyAlphaToBlur_NativeFunction;
    static readonly int SetApplyAlphaToBlur_ParamsSize;
    static readonly int SetApplyAlphaToBlur_bInApplyAlphaToBlur_Offset;
    
    public void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetApplyAlphaToBlur_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetApplyAlphaToBlur_bInApplyAlphaToBlur_Offset), 0, null, bInApplyAlphaToBlur);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetApplyAlphaToBlur_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}