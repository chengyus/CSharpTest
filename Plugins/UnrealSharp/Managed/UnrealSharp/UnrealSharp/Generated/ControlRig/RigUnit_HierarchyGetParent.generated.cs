using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyGetParent
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetParent:Child
    static readonly int Child_Offset;
    public UnrealSharp.ControlRig.RigElementKey Child;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetParent:Parent
    static readonly int Parent_Offset;
    public UnrealSharp.ControlRig.RigElementKey Parent;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyGetParent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyGetParent");
        
        Child_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Child");
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyGetParent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Child = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Child_Offset), 0, null);
            Parent = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Child_Offset), 0, null, Child);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Parent_Offset), 0, null, Parent);
        }
    }
}

public static class RigUnit_HierarchyGetParentMarshaler
{
    public static RigUnit_HierarchyGetParent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyGetParent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyGetParent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyGetParent.NativeDataSize;
    }
}