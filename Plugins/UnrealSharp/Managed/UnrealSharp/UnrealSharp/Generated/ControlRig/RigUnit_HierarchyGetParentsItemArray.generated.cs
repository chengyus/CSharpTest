using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyGetParentsItemArray
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyGetParentsItemArray:Child
    static readonly int Child_Offset;
    public UnrealSharp.ControlRig.RigElementKey Child;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyGetParentsItemArray:bIncludeChild
    static readonly int bIncludeChild_Offset;
    public bool IncludeChild;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyGetParentsItemArray:bReverse
    static readonly int bReverse_Offset;
    public bool Reverse;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyGetParentsItemArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyGetParentsItemArray");
        
        Child_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Child");
        bIncludeChild_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeChild");
        bReverse_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bReverse");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyGetParentsItemArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            Child = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Child_Offset), 0, null);
            IncludeChild = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeChild_Offset), 0, null);
            Reverse = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bReverse_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Child_Offset), 0, null, Child);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeChild_Offset), 0, null, IncludeChild);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bReverse_Offset), 0, null, Reverse);
        }
    }
}

public static class RigUnit_HierarchyGetParentsItemArrayMarshaler
{
    public static RigUnit_HierarchyGetParentsItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyGetParentsItemArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyGetParentsItemArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyGetParentsItemArray.NativeDataSize;
    }
}