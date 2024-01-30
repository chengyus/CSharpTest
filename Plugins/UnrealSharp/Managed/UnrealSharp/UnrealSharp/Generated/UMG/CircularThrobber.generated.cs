// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class CircularThrobber : UnrealSharp.UMG.Widget
{
    
    static CircularThrobber()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CircularThrobber");
        
        NumberOfPieces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NumberOfPieces");
        Period_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Period");
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        Image_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Image");
        
        SetRadius_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRadius");
        SetRadius_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRadius_NativeFunction);
        SetRadius_InRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRadius_NativeFunction, "InRadius");
        SetPeriod_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPeriod");
        SetPeriod_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPeriod_NativeFunction);
        SetPeriod_InPeriod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPeriod_NativeFunction, "InPeriod");
        SetNumberOfPieces_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNumberOfPieces");
        SetNumberOfPieces_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNumberOfPieces_NativeFunction);
        SetNumberOfPieces_InNumberOfPieces_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNumberOfPieces_NativeFunction, "InNumberOfPieces");
        
        
    }
    
    protected CircularThrobber(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // IntProperty /Script/UMG.CircularThrobber:NumberOfPieces
    static readonly int NumberOfPieces_Offset;
    
    public int NumberOfPieces
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, NumberOfPieces_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, NumberOfPieces_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.CircularThrobber:Period
    static readonly int Period_Offset;
    
    public float Period
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Period_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Period_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.CircularThrobber:Radius
    static readonly int Radius_Offset;
    
    public float Radius
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Radius_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Radius_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.CircularThrobber:Image
    static readonly int Image_Offset;
    
    public UnrealSharp.SlateCore.SlateBrush Image
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.SlateCore.SlateBrushMarshaler.FromNative(IntPtr.Add(NativeObject, Image_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.SlateCore.SlateBrushMarshaler.ToNative(IntPtr.Add(NativeObject, Image_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.CircularThrobber:SetRadius
    static readonly IntPtr SetRadius_NativeFunction;
    static readonly int SetRadius_ParamsSize;
    static readonly int SetRadius_InRadius_Offset;
    
    public void SetRadius(float inRadius)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRadius_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetRadius_InRadius_Offset), 0, null, inRadius);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRadius_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CircularThrobber:SetPeriod
    static readonly IntPtr SetPeriod_NativeFunction;
    static readonly int SetPeriod_ParamsSize;
    static readonly int SetPeriod_InPeriod_Offset;
    
    public void SetPeriod(float inPeriod)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPeriod_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetPeriod_InPeriod_Offset), 0, null, inPeriod);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPeriod_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CircularThrobber:SetNumberOfPieces
    static readonly IntPtr SetNumberOfPieces_NativeFunction;
    static readonly int SetNumberOfPieces_ParamsSize;
    static readonly int SetNumberOfPieces_InNumberOfPieces_Offset;
    
    public void SetNumberOfPieces(int inNumberOfPieces)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNumberOfPieces_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetNumberOfPieces_InNumberOfPieces_Offset), 0, null, inNumberOfPieces);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetNumberOfPieces_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}