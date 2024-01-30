// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FieldSystemEngine;

[UClass]
public partial class NoiseField : UnrealSharp.FieldSystemEngine.FieldNodeFloat
{
    
    static NoiseField()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("NoiseField");
        
        MinRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinRange");
        MaxRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxRange");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        
        SetNoiseField_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNoiseField");
        SetNoiseField_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNoiseField_NativeFunction);
        SetNoiseField_MinRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNoiseField_NativeFunction, "MinRange");
        SetNoiseField_MaxRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNoiseField_NativeFunction, "MaxRange");
        SetNoiseField_Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNoiseField_NativeFunction, "Transform");
        SetNoiseField_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNoiseField_NativeFunction, "ReturnValue");
        
        
    }
    
    protected NoiseField(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/FieldSystemEngine.NoiseField:MinRange
    static readonly int MinRange_Offset;
    
    public float MinRange
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinRange_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinRange_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/FieldSystemEngine.NoiseField:MaxRange
    static readonly int MaxRange_Offset;
    
    public float MaxRange
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MaxRange_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MaxRange_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/FieldSystemEngine.NoiseField:Transform
    static readonly int Transform_Offset;
    
    public UnrealSharp.Transform Transform
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(NativeObject, Transform_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(NativeObject, Transform_Offset), 0, this, value);
        }
    }
    
    // Function /Script/FieldSystemEngine.NoiseField:SetNoiseField
    static readonly IntPtr SetNoiseField_NativeFunction;
    static readonly int SetNoiseField_ParamsSize;
    static readonly int SetNoiseField_MinRange_Offset;
    static readonly int SetNoiseField_MaxRange_Offset;
    static readonly int SetNoiseField_Transform_Offset;
    static readonly int SetNoiseField_ReturnValue_Offset;
    
    public UnrealSharp.FieldSystemEngine.NoiseField SetNoiseField(float minRange, float maxRange, UnrealSharp.Transform transform)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNoiseField_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetNoiseField_MinRange_Offset), 0, null, minRange);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetNoiseField_MaxRange_Offset), 0, null, maxRange);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(ParamsBuffer, SetNoiseField_Transform_Offset), 0, null, transform);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetNoiseField_NativeFunction, ParamsBuffer);
            
            UnrealSharp.FieldSystemEngine.NoiseField returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.FieldSystemEngine.NoiseField>.FromNative(IntPtr.Add(ParamsBuffer, SetNoiseField_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}