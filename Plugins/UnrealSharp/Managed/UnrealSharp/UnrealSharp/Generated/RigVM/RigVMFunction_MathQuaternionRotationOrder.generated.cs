using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionRotationOrder
{
    // EnumProperty /Script/RigVM.RigVMFunction_MathQuaternionRotationOrder:RotationOrder
    static readonly int RotationOrder_Offset;
    public UnrealSharp.AnimationCore.EEulerRotationOrder RotationOrder;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionRotationOrder()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionRotationOrder");
        
        RotationOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationOrder");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionRotationOrder(IntPtr InNativeStruct)
    {
        unsafe
        {
            RotationOrder = BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.FromNative(IntPtr.Add(InNativeStruct, RotationOrder_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.ToNative(IntPtr.Add(Buffer, RotationOrder_Offset), 0, null, RotationOrder);
        }
    }
}

public static class RigVMFunction_MathQuaternionRotationOrderMarshaler
{
    public static RigVMFunction_MathQuaternionRotationOrder FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionRotationOrder(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionRotationOrder obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionRotationOrder.NativeDataSize;
    }
}