using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_DeltaFromPreviousVector
{
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousVector:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousVector:Delta
    static readonly int Delta_Offset;
    public System.DoubleNumerics.Vector3 Delta;
    
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousVector:PreviousValue
    static readonly int PreviousValue_Offset;
    public System.DoubleNumerics.Vector3 PreviousValue;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_DeltaFromPreviousVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_DeltaFromPreviousVector");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Delta_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Delta");
        PreviousValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreviousValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_DeltaFromPreviousVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Delta = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Delta_Offset), 0, null);
            PreviousValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PreviousValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Delta_Offset), 0, null, Delta);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PreviousValue_Offset), 0, null, PreviousValue);
        }
    }
}

public static class RigVMFunction_DeltaFromPreviousVectorMarshaler
{
    public static RigVMFunction_DeltaFromPreviousVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_DeltaFromPreviousVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_DeltaFromPreviousVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_DeltaFromPreviousVector.NativeDataSize;
    }
}