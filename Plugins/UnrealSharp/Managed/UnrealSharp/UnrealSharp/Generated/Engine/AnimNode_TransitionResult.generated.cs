using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimNode_TransitionResult
{
    // BoolProperty /Script/Engine.AnimNode_TransitionResult:bCanEnterTransition
    static readonly int bCanEnterTransition_Offset;
    public bool CanEnterTransition;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_TransitionResult()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_TransitionResult");
        
        bCanEnterTransition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanEnterTransition");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_TransitionResult(IntPtr InNativeStruct)
    {
        unsafe
        {
            CanEnterTransition = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCanEnterTransition_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCanEnterTransition_Offset), 0, null, CanEnterTransition);
        }
    }
}

public static class AnimNode_TransitionResultMarshaler
{
    public static AnimNode_TransitionResult FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_TransitionResult(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_TransitionResult obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_TransitionResult.NativeDataSize;
    }
}