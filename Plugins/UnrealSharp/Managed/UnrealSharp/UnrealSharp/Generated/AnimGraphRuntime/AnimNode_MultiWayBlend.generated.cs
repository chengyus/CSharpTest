using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_MultiWayBlend
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_MultiWayBlend:AlphaScaleBias
    static readonly int AlphaScaleBias_Offset;
    public UnrealSharp.Engine.InputScaleBias AlphaScaleBias;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_MultiWayBlend:bAdditiveNode
    static readonly int bAdditiveNode_Offset;
    public bool AdditiveNode;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_MultiWayBlend:bNormalizeAlpha
    static readonly int bNormalizeAlpha_Offset;
    public bool NormalizeAlpha;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_MultiWayBlend()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_MultiWayBlend");
        
        AlphaScaleBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaScaleBias");
        bAdditiveNode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAdditiveNode");
        bNormalizeAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNormalizeAlpha");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_MultiWayBlend(IntPtr InNativeStruct)
    {
        unsafe
        {
            AlphaScaleBias = BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.FromNative(IntPtr.Add(InNativeStruct, AlphaScaleBias_Offset), 0, null);
            AdditiveNode = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAdditiveNode_Offset), 0, null);
            NormalizeAlpha = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bNormalizeAlpha_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.ToNative(IntPtr.Add(Buffer, AlphaScaleBias_Offset), 0, null, AlphaScaleBias);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAdditiveNode_Offset), 0, null, AdditiveNode);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bNormalizeAlpha_Offset), 0, null, NormalizeAlpha);
        }
    }
}

public static class AnimNode_MultiWayBlendMarshaler
{
    public static AnimNode_MultiWayBlend FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_MultiWayBlend(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_MultiWayBlend obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_MultiWayBlend.NativeDataSize;
    }
}