using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_PoseDriver
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_PoseDriver:SourcePose
    static readonly int SourcePose_Offset;
    public UnrealSharp.Engine.PoseLink SourcePose;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_PoseDriver()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_PoseDriver");
        
        SourcePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourcePose");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_PoseDriver(IntPtr InNativeStruct)
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

public static class AnimNode_PoseDriverMarshaler
{
    public static AnimNode_PoseDriver FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_PoseDriver(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_PoseDriver obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_PoseDriver.NativeDataSize;
    }
}