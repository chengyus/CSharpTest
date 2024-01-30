using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigEditor;

[UStruct]
public partial struct ControlRigRigHierarchyDragAndDropContext
{
    // StructProperty /Script/ControlRigEditor.ControlRigRigHierarchyDragAndDropContext:TargetElementKey
    static readonly int TargetElementKey_Offset;
    public UnrealSharp.ControlRig.RigElementKey TargetElementKey;
    
    
    public static readonly int NativeDataSize;
    static ControlRigRigHierarchyDragAndDropContext()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigRigHierarchyDragAndDropContext");
        
        TargetElementKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetElementKey");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigRigHierarchyDragAndDropContext(IntPtr InNativeStruct)
    {
        unsafe
        {
            TargetElementKey = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, TargetElementKey_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, TargetElementKey_Offset), 0, null, TargetElementKey);
        }
    }
}

public static class ControlRigRigHierarchyDragAndDropContextMarshaler
{
    public static ControlRigRigHierarchyDragAndDropContext FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigRigHierarchyDragAndDropContext(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigRigHierarchyDragAndDropContext obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigRigHierarchyDragAndDropContext.NativeDataSize;
    }
}