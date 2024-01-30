using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMUserWorkflow
{
    // EnumProperty /Script/RigVM.RigVMUserWorkflow:Type
    static readonly int Type_Offset;
    public UnrealSharp.RigVM.ERigVMUserWorkflowType Type;
    
    
    public static readonly int NativeDataSize;
    static RigVMUserWorkflow()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMUserWorkflow");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMUserWorkflow(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<UnrealSharp.RigVM.ERigVMUserWorkflowType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMUserWorkflowType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
        }
    }
}

public static class RigVMUserWorkflowMarshaler
{
    public static RigVMUserWorkflow FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMUserWorkflow(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMUserWorkflow obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMUserWorkflow.NativeDataSize;
    }
}