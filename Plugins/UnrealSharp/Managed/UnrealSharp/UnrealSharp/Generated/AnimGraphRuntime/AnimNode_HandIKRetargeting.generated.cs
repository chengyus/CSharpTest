using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_HandIKRetargeting
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_HandIKRetargeting:HandFKWeight
    static readonly int HandFKWeight_Offset;
    public float HandFKWeight;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_HandIKRetargeting()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_HandIKRetargeting");
        
        HandFKWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HandFKWeight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_HandIKRetargeting(IntPtr InNativeStruct)
    {
        unsafe
        {
            HandFKWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, HandFKWeight_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, HandFKWeight_Offset), 0, null, HandFKWeight);
        }
    }
}

public static class AnimNode_HandIKRetargetingMarshaler
{
    public static AnimNode_HandIKRetargeting FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_HandIKRetargeting(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_HandIKRetargeting obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_HandIKRetargeting.NativeDataSize;
    }
}