using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_ScaleChainLength
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_ScaleChainLength:DefaultChainLength
    static readonly int DefaultChainLength_Offset;
    public float DefaultChainLength;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ScaleChainLength:TargetLocation
    static readonly int TargetLocation_Offset;
    public System.DoubleNumerics.Vector3 TargetLocation;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_ScaleChainLength:Alpha
    static readonly int Alpha_Offset;
    public float Alpha;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_ScaleChainLength()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_ScaleChainLength");
        
        DefaultChainLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultChainLength");
        TargetLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetLocation");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_ScaleChainLength(IntPtr InNativeStruct)
    {
        unsafe
        {
            DefaultChainLength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DefaultChainLength_Offset), 0, null);
            TargetLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TargetLocation_Offset), 0, null);
            Alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Alpha_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DefaultChainLength_Offset), 0, null, DefaultChainLength);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TargetLocation_Offset), 0, null, TargetLocation);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Alpha_Offset), 0, null, Alpha);
        }
    }
}

public static class AnimNode_ScaleChainLengthMarshaler
{
    public static AnimNode_ScaleChainLength FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_ScaleChainLength(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_ScaleChainLength obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_ScaleChainLength.NativeDataSize;
    }
}