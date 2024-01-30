using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionMirrorTransform
{
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionMirrorTransform:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Quaternion Value;
    
    // ByteProperty /Script/RigVM.RigVMFunction_MathQuaternionMirrorTransform:MirrorAxis
    static readonly int MirrorAxis_Offset;
    public UnrealSharp.CoreUObject.EAxis MirrorAxis;
    
    // ByteProperty /Script/RigVM.RigVMFunction_MathQuaternionMirrorTransform:AxisToFlip
    static readonly int AxisToFlip_Offset;
    public UnrealSharp.CoreUObject.EAxis AxisToFlip;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionMirrorTransform:CentralTransform
    static readonly int CentralTransform_Offset;
    public UnrealSharp.Transform CentralTransform;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionMirrorTransform:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionMirrorTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionMirrorTransform");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        MirrorAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MirrorAxis");
        AxisToFlip_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AxisToFlip");
        CentralTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CentralTransform");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionMirrorTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            MirrorAxis = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, MirrorAxis_Offset), 0, null);
            AxisToFlip = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, AxisToFlip_Offset), 0, null);
            CentralTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, CentralTransform_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, MirrorAxis_Offset), 0, null, MirrorAxis);
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, AxisToFlip_Offset), 0, null, AxisToFlip);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, CentralTransform_Offset), 0, null, CentralTransform);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathQuaternionMirrorTransformMarshaler
{
    public static RigVMFunction_MathQuaternionMirrorTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionMirrorTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionMirrorTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionMirrorTransform.NativeDataSize;
    }
}