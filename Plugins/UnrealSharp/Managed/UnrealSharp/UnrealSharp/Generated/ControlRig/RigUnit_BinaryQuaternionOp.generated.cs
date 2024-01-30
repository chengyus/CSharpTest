using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_BinaryQuaternionOp
{
    // StructProperty /Script/ControlRig.RigUnit_BinaryQuaternionOp:Argument0
    static readonly int Argument0_Offset;
    public System.DoubleNumerics.Quaternion Argument0;
    
    // StructProperty /Script/ControlRig.RigUnit_BinaryQuaternionOp:Argument1
    static readonly int Argument1_Offset;
    public System.DoubleNumerics.Quaternion Argument1;
    
    // StructProperty /Script/ControlRig.RigUnit_BinaryQuaternionOp:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_BinaryQuaternionOp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_BinaryQuaternionOp");
        
        Argument0_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Argument0");
        Argument1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Argument1");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_BinaryQuaternionOp(IntPtr InNativeStruct)
    {
        unsafe
        {
            Argument0 = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Argument0_Offset), 0, null);
            Argument1 = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Argument1_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Argument0_Offset), 0, null, Argument0);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Argument1_Offset), 0, null, Argument1);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_BinaryQuaternionOpMarshaler
{
    public static RigUnit_BinaryQuaternionOp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_BinaryQuaternionOp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_BinaryQuaternionOp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_BinaryQuaternionOp.NativeDataSize;
    }
}