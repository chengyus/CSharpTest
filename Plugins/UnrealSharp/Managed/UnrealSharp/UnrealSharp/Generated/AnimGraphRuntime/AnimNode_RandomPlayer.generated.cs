using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_RandomPlayer
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_RandomPlayer:BlendWeight
    static readonly int BlendWeight_Offset;
    public float BlendWeight;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_RandomPlayer:bShuffleMode
    static readonly int bShuffleMode_Offset;
    public bool ShuffleMode;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_RandomPlayer()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_RandomPlayer");
        
        BlendWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendWeight");
        bShuffleMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShuffleMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_RandomPlayer(IntPtr InNativeStruct)
    {
        unsafe
        {
            BlendWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendWeight_Offset), 0, null);
            ShuffleMode = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShuffleMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendWeight_Offset), 0, null, BlendWeight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShuffleMode_Offset), 0, null, ShuffleMode);
        }
    }
}

public static class AnimNode_RandomPlayerMarshaler
{
    public static AnimNode_RandomPlayer FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_RandomPlayer(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_RandomPlayer obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_RandomPlayer.NativeDataSize;
    }
}