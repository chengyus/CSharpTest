using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVMEditor;

[UStruct]
public partial struct RigVMEditorGraphMenuContext
{
    // ObjectProperty /Script/RigVMEditor.RigVMEditorGraphMenuContext:Graph
    static readonly int Graph_Offset;
    public UnrealSharp.RigVMDeveloper.RigVMGraph Graph;
    
    // ObjectProperty /Script/RigVMEditor.RigVMEditorGraphMenuContext:Node
    static readonly int Node_Offset;
    public UnrealSharp.RigVMDeveloper.RigVMNode Node;
    
    // ObjectProperty /Script/RigVMEditor.RigVMEditorGraphMenuContext:Pin
    static readonly int Pin_Offset;
    public UnrealSharp.RigVMDeveloper.RigVMPin Pin;
    
    
    public static readonly int NativeDataSize;
    static RigVMEditorGraphMenuContext()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMEditorGraphMenuContext");
        
        Graph_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Graph");
        Node_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Node");
        Pin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Pin");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMEditorGraphMenuContext(IntPtr InNativeStruct)
    {
        unsafe
        {
            Graph = ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMGraph>.FromNative(IntPtr.Add(InNativeStruct, Graph_Offset), 0, null);
            Node = ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMNode>.FromNative(IntPtr.Add(InNativeStruct, Node_Offset), 0, null);
            Pin = ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMPin>.FromNative(IntPtr.Add(InNativeStruct, Pin_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMGraph>.ToNative(IntPtr.Add(Buffer, Graph_Offset), 0, null, Graph);
            ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMNode>.ToNative(IntPtr.Add(Buffer, Node_Offset), 0, null, Node);
            ObjectMarshaller<UnrealSharp.RigVMDeveloper.RigVMPin>.ToNative(IntPtr.Add(Buffer, Pin_Offset), 0, null, Pin);
        }
    }
}

public static class RigVMEditorGraphMenuContextMarshaler
{
    public static RigVMEditorGraphMenuContext FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMEditorGraphMenuContext(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMEditorGraphMenuContext obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMEditorGraphMenuContext.NativeDataSize;
    }
}