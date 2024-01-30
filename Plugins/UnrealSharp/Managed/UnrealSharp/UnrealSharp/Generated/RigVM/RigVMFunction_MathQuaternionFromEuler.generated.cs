using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionFromEuler
{
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionFromEuler:Euler
    static readonly int Euler_Offset;
    public System.DoubleNumerics.Vector3 Euler;
    
    // EnumProperty /Script/RigVM.RigVMFunction_MathQuaternionFromEuler:RotationOrder
    static readonly int RotationOrder_Offset;
    public UnrealSharp.AnimationCore.EEulerRotationOrder RotationOrder;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionFromEuler:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionFromEuler()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionFromEuler");
        
        Euler_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Euler");
        RotationOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationOrder");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionFromEuler(IntPtr InNativeStruct)
    {
        unsafe
        {
            Euler = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Euler_Offset), 0, null);
            RotationOrder = BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.FromNative(IntPtr.Add(InNativeStruct, RotationOrder_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Euler_Offset), 0, null, Euler);
            BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.ToNative(IntPtr.Add(Buffer, RotationOrder_Offset), 0, null, RotationOrder);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathQuaternionFromEulerMarshaler
{
    public static RigVMFunction_MathQuaternionFromEuler FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionFromEuler(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionFromEuler obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionFromEuler.NativeDataSize;
    }
}