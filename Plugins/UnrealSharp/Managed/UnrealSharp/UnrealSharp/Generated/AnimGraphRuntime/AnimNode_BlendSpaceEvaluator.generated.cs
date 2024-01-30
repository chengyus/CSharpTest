using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_BlendSpaceEvaluator
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator:NormalizedTime
    static readonly int NormalizedTime_Offset;
    public float NormalizedTime;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_BlendSpaceEvaluator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_BlendSpaceEvaluator");
        
        NormalizedTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalizedTime");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_BlendSpaceEvaluator(IntPtr InNativeStruct)
    {
        unsafe
        {
            NormalizedTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NormalizedTime_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NormalizedTime_Offset), 0, null, NormalizedTime);
        }
    }
}

public static class AnimNode_BlendSpaceEvaluatorMarshaler
{
    public static AnimNode_BlendSpaceEvaluator FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_BlendSpaceEvaluator(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_BlendSpaceEvaluator obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_BlendSpaceEvaluator.NativeDataSize;
    }
}