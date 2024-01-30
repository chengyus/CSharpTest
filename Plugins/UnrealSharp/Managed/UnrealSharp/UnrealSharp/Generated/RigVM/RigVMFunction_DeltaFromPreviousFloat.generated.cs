using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_DeltaFromPreviousFloat
{
    // FloatProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousFloat:Value
    static readonly int Value_Offset;
    public float Value;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousFloat:Delta
    static readonly int Delta_Offset;
    public float Delta;
    
    // FloatProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousFloat:PreviousValue
    static readonly int PreviousValue_Offset;
    public float PreviousValue;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_DeltaFromPreviousFloat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_DeltaFromPreviousFloat");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Delta_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Delta");
        PreviousValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreviousValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_DeltaFromPreviousFloat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Delta = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Delta_Offset), 0, null);
            PreviousValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PreviousValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Delta_Offset), 0, null, Delta);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PreviousValue_Offset), 0, null, PreviousValue);
        }
    }
}

public static class RigVMFunction_DeltaFromPreviousFloatMarshaler
{
    public static RigVMFunction_DeltaFromPreviousFloat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_DeltaFromPreviousFloat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_DeltaFromPreviousFloat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_DeltaFromPreviousFloat.NativeDataSize;
    }
}