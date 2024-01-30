using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_UnaryQuaternionOp
{
    // StructProperty /Script/ControlRig.RigUnit_UnaryQuaternionOp:Argument
    static readonly int Argument_Offset;
    public System.DoubleNumerics.Quaternion Argument;
    
    // StructProperty /Script/ControlRig.RigUnit_UnaryQuaternionOp:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_UnaryQuaternionOp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_UnaryQuaternionOp");
        
        Argument_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Argument");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_UnaryQuaternionOp(IntPtr InNativeStruct)
    {
        unsafe
        {
            Argument = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Argument_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Argument_Offset), 0, null, Argument);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_UnaryQuaternionOpMarshaler
{
    public static RigUnit_UnaryQuaternionOp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_UnaryQuaternionOp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_UnaryQuaternionOp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_UnaryQuaternionOp.NativeDataSize;
    }
}