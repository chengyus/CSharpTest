using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigEditor;

[UStruct]
public partial struct ControlRigRigHierarchyToGraphDragAndDropContext
{
    
    public static readonly int NativeDataSize;
    static ControlRigRigHierarchyToGraphDragAndDropContext()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigRigHierarchyToGraphDragAndDropContext");
        
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigRigHierarchyToGraphDragAndDropContext(IntPtr InNativeStruct)
    {
        unsafe
        {
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
        }
    }
}

public static class ControlRigRigHierarchyToGraphDragAndDropContextMarshaler
{
    public static ControlRigRigHierarchyToGraphDragAndDropContext FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigRigHierarchyToGraphDragAndDropContext(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigRigHierarchyToGraphDragAndDropContext obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigRigHierarchyToGraphDragAndDropContext.NativeDataSize;
    }
}