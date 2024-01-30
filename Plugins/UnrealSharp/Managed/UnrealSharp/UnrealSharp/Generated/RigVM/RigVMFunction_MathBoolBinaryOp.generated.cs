using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathBoolBinaryOp
{
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolBinaryOp:A
    static readonly int A_Offset;
    public bool A;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolBinaryOp:B
    static readonly int B_Offset;
    public bool B;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolBinaryOp:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathBoolBinaryOp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathBoolBinaryOp");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathBoolBinaryOp(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathBoolBinaryOpMarshaler
{
    public static RigVMFunction_MathBoolBinaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathBoolBinaryOp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathBoolBinaryOp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathBoolBinaryOp.NativeDataSize;
    }
}