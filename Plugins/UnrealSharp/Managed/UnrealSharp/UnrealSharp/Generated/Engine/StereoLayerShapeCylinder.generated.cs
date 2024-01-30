// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class StereoLayerShapeCylinder : UnrealSharp.Engine.StereoLayerShape
{
    
    static StereoLayerShapeCylinder()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("StereoLayerShapeCylinder");
        
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        OverlayArc_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OverlayArc");
        Height_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Height");
        
        SetRadius_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRadius");
        SetRadius_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRadius_NativeFunction);
        SetRadius_InRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRadius_NativeFunction, "InRadius");
        SetOverlayArc_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOverlayArc");
        SetOverlayArc_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOverlayArc_NativeFunction);
        SetOverlayArc_InOverlayArc_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOverlayArc_NativeFunction, "InOverlayArc");
        SetHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetHeight");
        SetHeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetHeight_NativeFunction);
        SetHeight_InHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetHeight_NativeFunction, "InHeight");
        
        
    }
    
    protected StereoLayerShapeCylinder(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/Engine.StereoLayerShapeCylinder:Radius
    static readonly int Radius_Offset;
    
    public float Radius
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Radius_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Engine.StereoLayerShapeCylinder:OverlayArc
    static readonly int OverlayArc_Offset;
    
    public float OverlayArc
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, OverlayArc_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/Engine.StereoLayerShapeCylinder:Height
    static readonly int Height_Offset;
    
    public int Height
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, Height_Offset), 0, this);
        }
    }
    
    // Function /Script/Engine.StereoLayerShapeCylinder:SetRadius
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
    
    // Function /Script/Engine.StereoLayerShapeCylinder:SetOverlayArc
    static readonly IntPtr SetOverlayArc_NativeFunction;
    static readonly int SetOverlayArc_ParamsSize;
    static readonly int SetOverlayArc_InOverlayArc_Offset;
    
    public void SetOverlayArc(float inOverlayArc)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOverlayArc_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetOverlayArc_InOverlayArc_Offset), 0, null, inOverlayArc);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOverlayArc_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.StereoLayerShapeCylinder:SetHeight
    static readonly IntPtr SetHeight_NativeFunction;
    static readonly int SetHeight_ParamsSize;
    static readonly int SetHeight_InHeight_Offset;
    
    public void SetHeight(int inHeight)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetHeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetHeight_InHeight_Offset), 0, null, inHeight);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetHeight_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}