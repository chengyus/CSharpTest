using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimNode_SingleNode
{
    // StructProperty /Script/Engine.AnimNode_SingleNode:SourcePose
    static readonly int SourcePose_Offset;
    public UnrealSharp.Engine.PoseLink SourcePose;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_SingleNode()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_SingleNode");
        
        SourcePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourcePose");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_SingleNode(IntPtr InNativeStruct)
    {
        unsafe
        {
            SourcePose = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, SourcePose_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, SourcePose_Offset), 0, null, SourcePose);
        }
    }
}

public static class AnimNode_SingleNodeMarshaler
{
    public static AnimNode_SingleNode FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_SingleNode(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_SingleNode obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_SingleNode.NativeDataSize;
    }
}