using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimNode_ConvertComponentToLocalSpace
{
    // StructProperty /Script/Engine.AnimNode_ConvertComponentToLocalSpace:ComponentPose
    static readonly int ComponentPose_Offset;
    public UnrealSharp.Engine.ComponentSpacePoseLink ComponentPose;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_ConvertComponentToLocalSpace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_ConvertComponentToLocalSpace");
        
        ComponentPose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComponentPose");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_ConvertComponentToLocalSpace(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComponentPose = UnrealSharp.Engine.ComponentSpacePoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, ComponentPose_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.ComponentSpacePoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, ComponentPose_Offset), 0, null, ComponentPose);
        }
    }
}

public static class AnimNode_ConvertComponentToLocalSpaceMarshaler
{
    public static AnimNode_ConvertComponentToLocalSpace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_ConvertComponentToLocalSpace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_ConvertComponentToLocalSpace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_ConvertComponentToLocalSpace.NativeDataSize;
    }
}