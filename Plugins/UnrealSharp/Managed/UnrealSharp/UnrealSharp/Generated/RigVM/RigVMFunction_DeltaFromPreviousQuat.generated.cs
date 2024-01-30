using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_DeltaFromPreviousQuat
{
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousQuat:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Quaternion Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousQuat:Delta
    static readonly int Delta_Offset;
    public System.DoubleNumerics.Quaternion Delta;
    
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousQuat:PreviousValue
    static readonly int PreviousValue_Offset;
    public System.DoubleNumerics.Quaternion PreviousValue;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_DeltaFromPreviousQuat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_DeltaFromPreviousQuat");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Delta_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Delta");
        PreviousValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreviousValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_DeltaFromPreviousQuat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Delta = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Delta_Offset), 0, null);
            PreviousValue = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, PreviousValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Delta_Offset), 0, null, Delta);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, PreviousValue_Offset), 0, null, PreviousValue);
        }
    }
}

public static class RigVMFunction_DeltaFromPreviousQuatMarshaler
{
    public static RigVMFunction_DeltaFromPreviousQuat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_DeltaFromPreviousQuat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_DeltaFromPreviousQuat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_DeltaFromPreviousQuat.NativeDataSize;
    }
}