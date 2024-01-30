// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FieldSystemEngine;

[UClass]
public partial class UniformVector : UnrealSharp.FieldSystemEngine.FieldNodeVector
{
    
    static UniformVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("UniformVector");
        
        Magnitude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Magnitude");
        Direction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Direction");
        
        SetUniformVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetUniformVector");
        SetUniformVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetUniformVector_NativeFunction);
        SetUniformVector_Magnitude_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetUniformVector_NativeFunction, "Magnitude");
        SetUniformVector_Direction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetUniformVector_NativeFunction, "Direction");
        SetUniformVector_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetUniformVector_NativeFunction, "ReturnValue");
        
        
    }
    
    protected UniformVector(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/FieldSystemEngine.UniformVector:Magnitude
    static readonly int Magnitude_Offset;
    
    public float Magnitude
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Magnitude_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Magnitude_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/FieldSystemEngine.UniformVector:Direction
    static readonly int Direction_Offset;
    
    public System.DoubleNumerics.Vector3 Direction
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(NativeObject, Direction_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(NativeObject, Direction_Offset), 0, this, value);
        }
    }
    
    // Function /Script/FieldSystemEngine.UniformVector:SetUniformVector
    static readonly IntPtr SetUniformVector_NativeFunction;
    static readonly int SetUniformVector_ParamsSize;
    static readonly int SetUniformVector_Magnitude_Offset;
    static readonly int SetUniformVector_Direction_Offset;
    static readonly int SetUniformVector_ReturnValue_Offset;
    
    public UnrealSharp.FieldSystemEngine.UniformVector SetUniformVector(float magnitude, System.DoubleNumerics.Vector3 direction)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetUniformVector_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetUniformVector_Magnitude_Offset), 0, null, magnitude);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, SetUniformVector_Direction_Offset), 0, null, direction);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetUniformVector_NativeFunction, ParamsBuffer);
            
            UnrealSharp.FieldSystemEngine.UniformVector returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.FieldSystemEngine.UniformVector>.FromNative(IntPtr.Add(ParamsBuffer, SetUniformVector_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}