// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UClass]
public partial class CameraRig_Rail : UnrealSharp.Engine.Actor
{
    
    static CameraRig_Rail()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CameraRig_Rail");
        
        CurrentPositionOnRail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurrentPositionOnRail");
        bLockOrientationToRail_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLockOrientationToRail");
        
        GetRailSplineComponent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRailSplineComponent");
        GetRailSplineComponent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRailSplineComponent_NativeFunction);
        GetRailSplineComponent_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRailSplineComponent_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CameraRig_Rail(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/CinematicCamera.CameraRig_Rail:CurrentPositionOnRail
    static readonly int CurrentPositionOnRail_Offset;
    
    public float CurrentPositionOnRail
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CurrentPositionOnRail_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, CurrentPositionOnRail_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/CinematicCamera.CameraRig_Rail:bLockOrientationToRail
    static readonly int bLockOrientationToRail_Offset;
    
    public bool bLockOrientationToRail
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bLockOrientationToRail_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bLockOrientationToRail_Offset), 0, this, value);
        }
    }
    
    // Function /Script/CinematicCamera.CameraRig_Rail:GetRailSplineComponent
    static readonly IntPtr GetRailSplineComponent_NativeFunction;
    static readonly int GetRailSplineComponent_ParamsSize;
    static readonly int GetRailSplineComponent_ReturnValue_Offset;
    
    public UnrealSharp.Engine.SplineComponent GetRailSplineComponent()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetRailSplineComponent_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRailSplineComponent_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.SplineComponent returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.SplineComponent>.FromNative(IntPtr.Add(ParamsBuffer, GetRailSplineComponent_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}