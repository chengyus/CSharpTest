using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SequenceExecution
{
    // StructProperty /Script/ControlRig.RigUnit_SequenceExecution:ExecuteContext
    static readonly int ExecuteContext_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext ExecuteContext;
    
    // StructProperty /Script/ControlRig.RigUnit_SequenceExecution:A
    static readonly int A_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext A;
    
    // StructProperty /Script/ControlRig.RigUnit_SequenceExecution:B
    static readonly int B_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext B;
    
    // StructProperty /Script/ControlRig.RigUnit_SequenceExecution:C
    static readonly int C_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext C;
    
    // StructProperty /Script/ControlRig.RigUnit_SequenceExecution:D
    static readonly int D_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext D;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SequenceExecution()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SequenceExecution");
        
        ExecuteContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExecuteContext");
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        C_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "C");
        D_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "D");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SequenceExecution(IntPtr InNativeStruct)
    {
        unsafe
        {
            ExecuteContext = UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, ExecuteContext_Offset), 0, null);
            A = UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            C = UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, C_Offset), 0, null);
            D = UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, D_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, ExecuteContext_Offset), 0, null, ExecuteContext);
            UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, C_Offset), 0, null, C);
            UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, D_Offset), 0, null, D);
        }
    }
}

public static class RigUnit_SequenceExecutionMarshaler
{
    public static RigUnit_SequenceExecution FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SequenceExecution(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SequenceExecution obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SequenceExecution.NativeDataSize;
    }
}