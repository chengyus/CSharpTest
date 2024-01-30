using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathColorFromDouble
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathColorFromDouble:Value
    static readonly int Value_Offset;
    public double Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathColorFromDouble:Result
    static readonly int Result_Offset;
    public UnrealSharp.CoreUObject.LinearColor Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathColorFromDouble()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathColorFromDouble");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathColorFromDouble(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathColorFromDoubleMarshaler
{
    public static RigVMFunction_MathColorFromDouble FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathColorFromDouble(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathColorFromDouble obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathColorFromDouble.NativeDataSize;
    }
}