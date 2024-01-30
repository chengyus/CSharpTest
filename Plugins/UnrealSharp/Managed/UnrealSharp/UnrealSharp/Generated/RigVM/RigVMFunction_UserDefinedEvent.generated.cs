using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_UserDefinedEvent
{
    // StructProperty /Script/RigVM.RigVMFunction_UserDefinedEvent:ExecuteContext
    static readonly int ExecuteContext_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext ExecuteContext;
    
    // NameProperty /Script/RigVM.RigVMFunction_UserDefinedEvent:EventName
    static readonly int EventName_Offset;
    public Name EventName;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_UserDefinedEvent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_UserDefinedEvent");
        
        ExecuteContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExecuteContext");
        EventName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EventName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_UserDefinedEvent(IntPtr InNativeStruct)
    {
        unsafe
        {
            ExecuteContext = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, ExecuteContext_Offset), 0, null);
            EventName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EventName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, ExecuteContext_Offset), 0, null, ExecuteContext);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EventName_Offset), 0, null, EventName);
        }
    }
}

public static class RigVMFunction_UserDefinedEventMarshaler
{
    public static RigVMFunction_UserDefinedEvent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_UserDefinedEvent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_UserDefinedEvent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_UserDefinedEvent.NativeDataSize;
    }
}