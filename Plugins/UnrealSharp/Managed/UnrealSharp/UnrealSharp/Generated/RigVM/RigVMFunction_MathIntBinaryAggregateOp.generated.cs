using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathIntBinaryAggregateOp
{
    // IntProperty /Script/RigVM.RigVMFunction_MathIntBinaryAggregateOp:A
    static readonly int A_Offset;
    public int A;
    
    // IntProperty /Script/RigVM.RigVMFunction_MathIntBinaryAggregateOp:B
    static readonly int B_Offset;
    public int B;
    
    // IntProperty /Script/RigVM.RigVMFunction_MathIntBinaryAggregateOp:Result
    static readonly int Result_Offset;
    public int Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathIntBinaryAggregateOp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathIntBinaryAggregateOp");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathIntBinaryAggregateOp(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Result = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathIntBinaryAggregateOpMarshaler
{
    public static RigVMFunction_MathIntBinaryAggregateOp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathIntBinaryAggregateOp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathIntBinaryAggregateOp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathIntBinaryAggregateOp.NativeDataSize;
    }
}