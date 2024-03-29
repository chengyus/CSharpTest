using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetControlDrivenList
{
    // NameProperty /Script/ControlRig.RigUnit_SetControlDrivenList:Control
    static readonly int Control_Offset;
    public Name Control;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetControlDrivenList()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetControlDrivenList");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetControlDrivenList(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
        }
    }
}

public static class RigUnit_SetControlDrivenListMarshaler
{
    public static RigUnit_SetControlDrivenList FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetControlDrivenList(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetControlDrivenList obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetControlDrivenList.NativeDataSize;
    }
}