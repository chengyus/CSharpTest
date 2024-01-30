using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_ControlFlowBranch
{
    // StructProperty /Script/RigVM.RigVMFunction_ControlFlowBranch:ExecuteContext
    static readonly int ExecuteContext_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext ExecuteContext;
    
    // BoolProperty /Script/RigVM.RigVMFunction_ControlFlowBranch:Condition
    static readonly int Condition_Offset;
    public bool Condition;
    
    // StructProperty /Script/RigVM.RigVMFunction_ControlFlowBranch:True
    static readonly int True_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext True;
    
    // StructProperty /Script/RigVM.RigVMFunction_ControlFlowBranch:False
    static readonly int False_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext False;
    
    // StructProperty /Script/RigVM.RigVMFunction_ControlFlowBranch:Completed
    static readonly int Completed_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext Completed;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_ControlFlowBranch()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_ControlFlowBranch");
        
        ExecuteContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExecuteContext");
        Condition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Condition");
        True_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "True");
        False_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "False");
        Completed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Completed");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_ControlFlowBranch(IntPtr InNativeStruct)
    {
        unsafe
        {
            ExecuteContext = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, ExecuteContext_Offset), 0, null);
            Condition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Condition_Offset), 0, null);
            True = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, True_Offset), 0, null);
            False = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, False_Offset), 0, null);
            Completed = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, Completed_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, ExecuteContext_Offset), 0, null, ExecuteContext);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Condition_Offset), 0, null, Condition);
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, True_Offset), 0, null, True);
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, False_Offset), 0, null, False);
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, Completed_Offset), 0, null, Completed);
        }
    }
}

public static class RigVMFunction_ControlFlowBranchMarshaler
{
    public static RigVMFunction_ControlFlowBranch FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_ControlFlowBranch(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_ControlFlowBranch obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_ControlFlowBranch.NativeDataSize;
    }
}