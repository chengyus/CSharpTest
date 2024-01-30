// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
abstract public partial class CameraShakeBase : UnrealSharp.CoreUObject.Object
{
    
    static CameraShakeBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CameraShakeBase");
        
        ShakeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShakeScale");
        
        SetRootShakePattern_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRootShakePattern");
        SetRootShakePattern_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRootShakePattern_NativeFunction);
        SetRootShakePattern_InPattern_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRootShakePattern_NativeFunction, "InPattern");
        GetRootShakePattern_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRootShakePattern");
        GetRootShakePattern_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRootShakePattern_NativeFunction);
        GetRootShakePattern_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRootShakePattern_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CameraShakeBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/Engine.CameraShakeBase:ShakeScale
    static readonly int ShakeScale_Offset;
    
    public float ShakeScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, ShakeScale_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, ShakeScale_Offset), 0, this, value);
        }
    }
    
    // Function /Script/Engine.CameraShakeBase:SetRootShakePattern
    static readonly IntPtr SetRootShakePattern_NativeFunction;
    static readonly int SetRootShakePattern_ParamsSize;
    static readonly int SetRootShakePattern_InPattern_Offset;
    
    public void SetRootShakePattern(UnrealSharp.Engine.CameraShakePattern inPattern)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRootShakePattern_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.CameraShakePattern>.ToNative(IntPtr.Add(ParamsBuffer, SetRootShakePattern_InPattern_Offset), 0, null, inPattern);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRootShakePattern_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.CameraShakeBase:GetRootShakePattern
    static readonly IntPtr GetRootShakePattern_NativeFunction;
    static readonly int GetRootShakePattern_ParamsSize;
    static readonly int GetRootShakePattern_ReturnValue_Offset;
    
    public UnrealSharp.Engine.CameraShakePattern GetRootShakePattern()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetRootShakePattern_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRootShakePattern_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.CameraShakePattern returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.CameraShakePattern>.FromNative(IntPtr.Add(ParamsBuffer, GetRootShakePattern_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}