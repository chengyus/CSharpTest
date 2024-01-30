// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class SizeBox : UnrealSharp.UMG.ContentWidget
{
    
    static SizeBox()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SizeBox");
        
        WidthOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WidthOverride");
        HeightOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HeightOverride");
        MinDesiredWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinDesiredWidth");
        MinDesiredHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinDesiredHeight");
        MaxDesiredWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDesiredWidth");
        MaxDesiredHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxDesiredHeight");
        MinAspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinAspectRatio");
        MaxAspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxAspectRatio");
        
        SetWidthOverride_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetWidthOverride");
        SetWidthOverride_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetWidthOverride_NativeFunction);
        SetWidthOverride_InWidthOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetWidthOverride_NativeFunction, "InWidthOverride");
        SetMinDesiredWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMinDesiredWidth");
        SetMinDesiredWidth_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMinDesiredWidth_NativeFunction);
        SetMinDesiredWidth_InMinDesiredWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMinDesiredWidth_NativeFunction, "InMinDesiredWidth");
        SetMinDesiredHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMinDesiredHeight");
        SetMinDesiredHeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMinDesiredHeight_NativeFunction);
        SetMinDesiredHeight_InMinDesiredHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMinDesiredHeight_NativeFunction, "InMinDesiredHeight");
        SetMinAspectRatio_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMinAspectRatio");
        SetMinAspectRatio_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMinAspectRatio_NativeFunction);
        SetMinAspectRatio_InMinAspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMinAspectRatio_NativeFunction, "InMinAspectRatio");
        SetMaxDesiredWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMaxDesiredWidth");
        SetMaxDesiredWidth_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMaxDesiredWidth_NativeFunction);
        SetMaxDesiredWidth_InMaxDesiredWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMaxDesiredWidth_NativeFunction, "InMaxDesiredWidth");
        SetMaxDesiredHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMaxDesiredHeight");
        SetMaxDesiredHeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMaxDesiredHeight_NativeFunction);
        SetMaxDesiredHeight_InMaxDesiredHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMaxDesiredHeight_NativeFunction, "InMaxDesiredHeight");
        SetMaxAspectRatio_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMaxAspectRatio");
        SetMaxAspectRatio_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMaxAspectRatio_NativeFunction);
        SetMaxAspectRatio_InMaxAspectRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMaxAspectRatio_NativeFunction, "InMaxAspectRatio");
        SetHeightOverride_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetHeightOverride");
        SetHeightOverride_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetHeightOverride_NativeFunction);
        SetHeightOverride_InHeightOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetHeightOverride_NativeFunction, "InHeightOverride");
        ClearWidthOverride_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearWidthOverride");
        ClearMinDesiredWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearMinDesiredWidth");
        ClearMinDesiredHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearMinDesiredHeight");
        ClearMinAspectRatio_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearMinAspectRatio");
        ClearMaxDesiredWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearMaxDesiredWidth");
        ClearMaxDesiredHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearMaxDesiredHeight");
        ClearMaxAspectRatio_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearMaxAspectRatio");
        ClearHeightOverride_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ClearHeightOverride");
        
        
    }
    
    protected SizeBox(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/UMG.SizeBox:WidthOverride
    static readonly int WidthOverride_Offset;
    
    public float WidthOverride
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, WidthOverride_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, WidthOverride_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.SizeBox:HeightOverride
    static readonly int HeightOverride_Offset;
    
    public float HeightOverride
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, HeightOverride_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, HeightOverride_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.SizeBox:MinDesiredWidth
    static readonly int MinDesiredWidth_Offset;
    
    public float MinDesiredWidth
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinDesiredWidth_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinDesiredWidth_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.SizeBox:MinDesiredHeight
    static readonly int MinDesiredHeight_Offset;
    
    public float MinDesiredHeight
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinDesiredHeight_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinDesiredHeight_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.SizeBox:MaxDesiredWidth
    static readonly int MaxDesiredWidth_Offset;
    
    public float MaxDesiredWidth
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxDesiredWidth_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxDesiredWidth_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.SizeBox:MaxDesiredHeight
    static readonly int MaxDesiredHeight_Offset;
    
    public float MaxDesiredHeight
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxDesiredHeight_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxDesiredHeight_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.SizeBox:MinAspectRatio
    static readonly int MinAspectRatio_Offset;
    
    public float MinAspectRatio
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinAspectRatio_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinAspectRatio_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.SizeBox:MaxAspectRatio
    static readonly int MaxAspectRatio_Offset;
    
    public float MaxAspectRatio
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxAspectRatio_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxAspectRatio_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.SizeBox:SetWidthOverride
    static readonly IntPtr SetWidthOverride_NativeFunction;
    static readonly int SetWidthOverride_ParamsSize;
    static readonly int SetWidthOverride_InWidthOverride_Offset;
    
    public void SetWidthOverride(float inWidthOverride)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetWidthOverride_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetWidthOverride_InWidthOverride_Offset), 0, null, inWidthOverride);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetWidthOverride_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.SizeBox:SetMinDesiredWidth
    static readonly IntPtr SetMinDesiredWidth_NativeFunction;
    static readonly int SetMinDesiredWidth_ParamsSize;
    static readonly int SetMinDesiredWidth_InMinDesiredWidth_Offset;
    
    public void SetMinDesiredWidth(float inMinDesiredWidth)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMinDesiredWidth_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMinDesiredWidth_InMinDesiredWidth_Offset), 0, null, inMinDesiredWidth);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMinDesiredWidth_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.SizeBox:SetMinDesiredHeight
    static readonly IntPtr SetMinDesiredHeight_NativeFunction;
    static readonly int SetMinDesiredHeight_ParamsSize;
    static readonly int SetMinDesiredHeight_InMinDesiredHeight_Offset;
    
    public void SetMinDesiredHeight(float inMinDesiredHeight)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMinDesiredHeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMinDesiredHeight_InMinDesiredHeight_Offset), 0, null, inMinDesiredHeight);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMinDesiredHeight_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.SizeBox:SetMinAspectRatio
    static readonly IntPtr SetMinAspectRatio_NativeFunction;
    static readonly int SetMinAspectRatio_ParamsSize;
    static readonly int SetMinAspectRatio_InMinAspectRatio_Offset;
    
    public void SetMinAspectRatio(float inMinAspectRatio)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMinAspectRatio_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMinAspectRatio_InMinAspectRatio_Offset), 0, null, inMinAspectRatio);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMinAspectRatio_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.SizeBox:SetMaxDesiredWidth
    static readonly IntPtr SetMaxDesiredWidth_NativeFunction;
    static readonly int SetMaxDesiredWidth_ParamsSize;
    static readonly int SetMaxDesiredWidth_InMaxDesiredWidth_Offset;
    
    public void SetMaxDesiredWidth(float inMaxDesiredWidth)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMaxDesiredWidth_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMaxDesiredWidth_InMaxDesiredWidth_Offset), 0, null, inMaxDesiredWidth);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMaxDesiredWidth_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.SizeBox:SetMaxDesiredHeight
    static readonly IntPtr SetMaxDesiredHeight_NativeFunction;
    static readonly int SetMaxDesiredHeight_ParamsSize;
    static readonly int SetMaxDesiredHeight_InMaxDesiredHeight_Offset;
    
    public void SetMaxDesiredHeight(float inMaxDesiredHeight)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMaxDesiredHeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMaxDesiredHeight_InMaxDesiredHeight_Offset), 0, null, inMaxDesiredHeight);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMaxDesiredHeight_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.SizeBox:SetMaxAspectRatio
    static readonly IntPtr SetMaxAspectRatio_NativeFunction;
    static readonly int SetMaxAspectRatio_ParamsSize;
    static readonly int SetMaxAspectRatio_InMaxAspectRatio_Offset;
    
    public void SetMaxAspectRatio(float inMaxAspectRatio)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMaxAspectRatio_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMaxAspectRatio_InMaxAspectRatio_Offset), 0, null, inMaxAspectRatio);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMaxAspectRatio_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.SizeBox:SetHeightOverride
    static readonly IntPtr SetHeightOverride_NativeFunction;
    static readonly int SetHeightOverride_ParamsSize;
    static readonly int SetHeightOverride_InHeightOverride_Offset;
    
    public void SetHeightOverride(float inHeightOverride)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetHeightOverride_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetHeightOverride_InHeightOverride_Offset), 0, null, inHeightOverride);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetHeightOverride_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.SizeBox:ClearWidthOverride
    static readonly IntPtr ClearWidthOverride_NativeFunction;
    
    public void ClearWidthOverride()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearWidthOverride_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.SizeBox:ClearMinDesiredWidth
    static readonly IntPtr ClearMinDesiredWidth_NativeFunction;
    
    public void ClearMinDesiredWidth()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearMinDesiredWidth_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.SizeBox:ClearMinDesiredHeight
    static readonly IntPtr ClearMinDesiredHeight_NativeFunction;
    
    public void ClearMinDesiredHeight()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearMinDesiredHeight_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.SizeBox:ClearMinAspectRatio
    static readonly IntPtr ClearMinAspectRatio_NativeFunction;
    
    public void ClearMinAspectRatio()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearMinAspectRatio_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.SizeBox:ClearMaxDesiredWidth
    static readonly IntPtr ClearMaxDesiredWidth_NativeFunction;
    
    public void ClearMaxDesiredWidth()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearMaxDesiredWidth_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.SizeBox:ClearMaxDesiredHeight
    static readonly IntPtr ClearMaxDesiredHeight_NativeFunction;
    
    public void ClearMaxDesiredHeight()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearMaxDesiredHeight_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.SizeBox:ClearMaxAspectRatio
    static readonly IntPtr ClearMaxAspectRatio_NativeFunction;
    
    public void ClearMaxAspectRatio()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearMaxAspectRatio_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/UMG.SizeBox:ClearHeightOverride
    static readonly IntPtr ClearHeightOverride_NativeFunction;
    
    public void ClearHeightOverride()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ClearHeightOverride_NativeFunction, IntPtr.Zero);
        }
    }
    
    
}