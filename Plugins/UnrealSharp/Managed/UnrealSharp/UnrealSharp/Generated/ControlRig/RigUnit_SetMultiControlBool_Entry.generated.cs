using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetMultiControlBool_Entry
{
    // NameProperty /Script/ControlRig.RigUnit_SetMultiControlBool_Entry:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // BoolProperty /Script/ControlRig.RigUnit_SetMultiControlBool_Entry:BoolValue
    static readonly int BoolValue_Offset;
    public bool BoolValue;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetMultiControlBool_Entry()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetMultiControlBool_Entry");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        BoolValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoolValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetMultiControlBool_Entry(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            BoolValue = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, BoolValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, BoolValue_Offset), 0, null, BoolValue);
        }
    }
}

public static class RigUnit_SetMultiControlBool_EntryMarshaler
{
    public static RigUnit_SetMultiControlBool_Entry FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetMultiControlBool_Entry(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetMultiControlBool_Entry obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetMultiControlBool_Entry.NativeDataSize;
    }
}