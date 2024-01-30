using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_DeltaFromPreviousTransform
{
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousTransform:Value
    static readonly int Value_Offset;
    public UnrealSharp.Transform Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousTransform:Delta
    static readonly int Delta_Offset;
    public UnrealSharp.Transform Delta;
    
    // StructProperty /Script/RigVM.RigVMFunction_DeltaFromPreviousTransform:PreviousValue
    static readonly int PreviousValue_Offset;
    public UnrealSharp.Transform PreviousValue;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_DeltaFromPreviousTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_DeltaFromPreviousTransform");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Delta_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Delta");
        PreviousValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreviousValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_DeltaFromPreviousTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Delta = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Delta_Offset), 0, null);
            PreviousValue = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, PreviousValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Delta_Offset), 0, null, Delta);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, PreviousValue_Offset), 0, null, PreviousValue);
        }
    }
}

public static class RigVMFunction_DeltaFromPreviousTransformMarshaler
{
    public static RigVMFunction_DeltaFromPreviousTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_DeltaFromPreviousTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_DeltaFromPreviousTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_DeltaFromPreviousTransform.NativeDataSize;
    }
}