using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_BeginExecution
{
    // StructProperty /Script/ControlRig.RigUnit_BeginExecution:ExecuteContext
    static readonly int ExecuteContext_Offset;
    public UnrealSharp.ControlRig.ControlRigExecuteContext ExecuteContext;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_BeginExecution()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_BeginExecution");
        
        ExecuteContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExecuteContext");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_BeginExecution(IntPtr InNativeStruct)
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

public static class RigUnit_BeginExecutionMarshaler
{
    public static RigUnit_BeginExecution FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_BeginExecution(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_BeginExecution obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_BeginExecution.NativeDataSize;
    }
}