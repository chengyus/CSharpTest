using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SwitchParent
{
    // EnumProperty /Script/ControlRig.RigUnit_SwitchParent:Mode
    static readonly int Mode_Offset;
    public UnrealSharp.ControlRig.ERigSwitchParentMode Mode;
    
    // StructProperty /Script/ControlRig.RigUnit_SwitchParent:Child
    static readonly int Child_Offset;
    public UnrealSharp.ControlRig.RigElementKey Child;
    
    // StructProperty /Script/ControlRig.RigUnit_SwitchParent:Parent
    static readonly int Parent_Offset;
    public UnrealSharp.ControlRig.RigElementKey Parent;
    
    // BoolProperty /Script/ControlRig.RigUnit_SwitchParent:bMaintainGlobal
    static readonly int bMaintainGlobal_Offset;
    public bool MaintainGlobal;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SwitchParent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SwitchParent");
        
        Mode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mode");
        Child_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Child");
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        bMaintainGlobal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMaintainGlobal");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SwitchParent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Mode = BlittableMarshaller<UnrealSharp.ControlRig.ERigSwitchParentMode>.FromNative(IntPtr.Add(InNativeStruct, Mode_Offset), 0, null);
            Child = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Child_Offset), 0, null);
            Parent = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            MaintainGlobal = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMaintainGlobal_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.ERigSwitchParentMode>.ToNative(IntPtr.Add(Buffer, Mode_Offset), 0, null, Mode);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Child_Offset), 0, null, Child);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Parent_Offset), 0, null, Parent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMaintainGlobal_Offset), 0, null, MaintainGlobal);
        }
    }
}

public static class RigUnit_SwitchParentMarshaler
{
    public static RigUnit_SwitchParent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SwitchParent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SwitchParent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SwitchParent.NativeDataSize;
    }
}