using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PrepareForExecution
{
    // StructProperty /Script/ControlRig.RigUnit_PrepareForExecution:ExecuteContext
    static readonly int ExecuteContext_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext ExecuteContext;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PrepareForExecution()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PrepareForExecution");
        
        ExecuteContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExecuteContext");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PrepareForExecution(IntPtr InNativeStruct)
    {
        unsafe
        {
            ExecuteContext = UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, ExecuteContext_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.ControlRigExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, ExecuteContext_Offset), 0, null, ExecuteContext);
        }
    }
}

public static class RigUnit_PrepareForExecutionMarshaler
{
    public static RigUnit_PrepareForExecution FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PrepareForExecution(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PrepareForExecution obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PrepareForExecution.NativeDataSize;
    }
}