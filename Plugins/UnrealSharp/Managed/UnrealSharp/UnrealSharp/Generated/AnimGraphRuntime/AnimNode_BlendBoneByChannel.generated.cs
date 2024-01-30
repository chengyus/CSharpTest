using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_BlendBoneByChannel
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel:A
    static readonly int A_Offset;
    public UnrealSharp.Engine.PoseLink A;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel:B
    static readonly int B_Offset;
    public UnrealSharp.Engine.PoseLink B;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel:Alpha
    static readonly int Alpha_Offset;
    public float Alpha;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel:AlphaScaleBias
    static readonly int AlphaScaleBias_Offset;
    public UnrealSharp.Engine.InputScaleBias AlphaScaleBias;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_BlendBoneByChannel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_BlendBoneByChannel");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        AlphaScaleBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaScaleBias");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_BlendBoneByChannel(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            Alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Alpha_Offset), 0, null);
            AlphaScaleBias = BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.FromNative(IntPtr.Add(InNativeStruct, AlphaScaleBias_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Alpha_Offset), 0, null, Alpha);
            BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.ToNative(IntPtr.Add(Buffer, AlphaScaleBias_Offset), 0, null, AlphaScaleBias);
        }
    }
}

public static class AnimNode_BlendBoneByChannelMarshaler
{
    public static AnimNode_BlendBoneByChannel FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_BlendBoneByChannel(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_BlendBoneByChannel obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_BlendBoneByChannel.NativeDataSize;
    }
}