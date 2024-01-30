using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimNode_ConvertLocalToComponentSpace
{
    // StructProperty /Script/Engine.AnimNode_ConvertLocalToComponentSpace:LocalPose
    static readonly int LocalPose_Offset;
    public UnrealSharp.Engine.PoseLink LocalPose;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_ConvertLocalToComponentSpace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_ConvertLocalToComponentSpace");
        
        LocalPose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalPose");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_ConvertLocalToComponentSpace(IntPtr InNativeStruct)
    {
        unsafe
        {
            LocalPose = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, LocalPose_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, LocalPose_Offset), 0, null, LocalPose);
        }
    }
}

public static class AnimNode_ConvertLocalToComponentSpaceMarshaler
{
    public static AnimNode_ConvertLocalToComponentSpace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_ConvertLocalToComponentSpace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_ConvertLocalToComponentSpace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_ConvertLocalToComponentSpace.NativeDataSize;
    }
}