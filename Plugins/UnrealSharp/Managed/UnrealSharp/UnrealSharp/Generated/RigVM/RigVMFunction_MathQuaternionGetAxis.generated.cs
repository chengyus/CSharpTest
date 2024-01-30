using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionGetAxis
{
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionGetAxis:Quaternion
    static readonly int Quaternion_Offset;
    public System.DoubleNumerics.Quaternion Quaternion;
    
    // ByteProperty /Script/RigVM.RigVMFunction_MathQuaternionGetAxis:Axis
    static readonly int Axis_Offset;
    public UnrealSharp.CoreUObject.EAxis Axis;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionGetAxis:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionGetAxis()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionGetAxis");
        
        Quaternion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Quaternion");
        Axis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Axis");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionGetAxis(IntPtr InNativeStruct)
    {
        unsafe
        {
            Quaternion = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Quaternion_Offset), 0, null);
            Axis = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, Axis_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Quaternion_Offset), 0, null, Quaternion);
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, Axis_Offset), 0, null, Axis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathQuaternionGetAxisMarshaler
{
    public static RigVMFunction_MathQuaternionGetAxis FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionGetAxis(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionGetAxis obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionGetAxis.NativeDataSize;
    }
}