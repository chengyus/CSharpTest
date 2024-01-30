using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleBinaryAggregateOp
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleBinaryAggregateOp:A
    static readonly int A_Offset;
    public double A;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleBinaryAggregateOp:B
    static readonly int B_Offset;
    public double B;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleBinaryAggregateOp:Result
    static readonly int Result_Offset;
    public double Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleBinaryAggregateOp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleBinaryAggregateOp");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleBinaryAggregateOp(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Result = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathDoubleBinaryAggregateOpMarshaler
{
    public static RigVMFunction_MathDoubleBinaryAggregateOp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleBinaryAggregateOp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleBinaryAggregateOp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleBinaryAggregateOp.NativeDataSize;
    }
}