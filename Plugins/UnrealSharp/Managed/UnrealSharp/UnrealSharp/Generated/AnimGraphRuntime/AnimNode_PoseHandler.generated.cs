using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_PoseHandler
{
    // ObjectProperty /Script/AnimGraphRuntime.AnimNode_PoseHandler:PoseAsset
    static readonly int PoseAsset_Offset;
    public UnrealSharp.Engine.PoseAsset PoseAsset;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_PoseHandler()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_PoseHandler");
        
        PoseAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoseAsset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_PoseHandler(IntPtr InNativeStruct)
    {
        unsafe
        {
            PoseAsset = ObjectMarshaller<UnrealSharp.Engine.PoseAsset>.FromNative(IntPtr.Add(InNativeStruct, PoseAsset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.PoseAsset>.ToNative(IntPtr.Add(Buffer, PoseAsset_Offset), 0, null, PoseAsset);
        }
    }
}

public static class AnimNode_PoseHandlerMarshaler
{
    public static AnimNode_PoseHandler FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_PoseHandler(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_PoseHandler obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_PoseHandler.NativeDataSize;
    }
}