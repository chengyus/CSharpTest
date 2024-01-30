using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_Sequence
{
    // StructProperty /Script/RigVM.RigVMFunction_Sequence:ExecuteContext
    static readonly int ExecuteContext_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext ExecuteContext;
    
    // StructProperty /Script/RigVM.RigVMFunction_Sequence:A
    static readonly int A_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext A;
    
    // StructProperty /Script/RigVM.RigVMFunction_Sequence:B
    static readonly int B_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext B;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_Sequence()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_Sequence");
        
        ExecuteContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExecuteContext");
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_Sequence(IntPtr InNativeStruct)
    {
        unsafe
        {
            ExecuteContext = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, ExecuteContext_Offset), 0, null);
            A = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, ExecuteContext_Offset), 0, null, ExecuteContext);
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
        }
    }
}

public static class RigVMFunction_SequenceMarshaler
{
    public static RigVMFunction_Sequence FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_Sequence(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_Sequence obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_Sequence.NativeDataSize;
    }
}