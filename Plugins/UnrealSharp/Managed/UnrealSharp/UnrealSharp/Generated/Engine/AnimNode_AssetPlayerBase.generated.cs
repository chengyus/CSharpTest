using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimNode_AssetPlayerBase
{
    // FloatProperty /Script/Engine.AnimNode_AssetPlayerBase:BlendWeight
    static readonly int BlendWeight_Offset;
    public float BlendWeight;
    
    // FloatProperty /Script/Engine.AnimNode_AssetPlayerBase:InternalTimeAccumulator
    static readonly int InternalTimeAccumulator_Offset;
    public float InternalTimeAccumulator;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_AssetPlayerBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_AssetPlayerBase");
        
        BlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendWeight");
        InternalTimeAccumulator_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InternalTimeAccumulator");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_AssetPlayerBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            BlendWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendWeight_Offset), 0, null);
            InternalTimeAccumulator = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InternalTimeAccumulator_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendWeight_Offset), 0, null, BlendWeight);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InternalTimeAccumulator_Offset), 0, null, InternalTimeAccumulator);
        }
    }
}

public static class AnimNode_AssetPlayerBaseMarshaler
{
    public static AnimNode_AssetPlayerBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_AssetPlayerBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_AssetPlayerBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_AssetPlayerBase.NativeDataSize;
    }
}