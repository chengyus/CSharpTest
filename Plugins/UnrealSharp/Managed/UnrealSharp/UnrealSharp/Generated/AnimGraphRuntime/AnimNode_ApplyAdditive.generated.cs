using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_ApplyAdditive
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:Base
    static readonly int Base_Offset;
    public UnrealSharp.Engine.PoseLink Base;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:Additive
    static readonly int Additive_Offset;
    public UnrealSharp.Engine.PoseLink Additive;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:Alpha
    static readonly int Alpha_Offset;
    public float Alpha;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaScaleBias
    static readonly int AlphaScaleBias_Offset;
    public UnrealSharp.Engine.InputScaleBias AlphaScaleBias;
    
    // IntProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:LODThreshold
    static readonly int LODThreshold_Offset;
    public int LODThreshold;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaBoolBlend
    static readonly int AlphaBoolBlend_Offset;
    public UnrealSharp.Engine.InputAlphaBoolBlend AlphaBoolBlend;
    
    // NameProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaCurveName
    static readonly int AlphaCurveName_Offset;
    public Name AlphaCurveName;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaScaleBiasClamp
    static readonly int AlphaScaleBiasClamp_Offset;
    public UnrealSharp.Engine.InputScaleBiasClamp AlphaScaleBiasClamp;
    
    // EnumProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaInputType
    static readonly int AlphaInputType_Offset;
    public UnrealSharp.Engine.EAnimAlphaInputType AlphaInputType;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_ApplyAdditive:bAlphaBoolEnabled
    static readonly int bAlphaBoolEnabled_Offset;
    public bool AlphaBoolEnabled;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_ApplyAdditive()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_ApplyAdditive");
        
        Base_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Base");
        Additive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Additive");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        AlphaScaleBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaScaleBias");
        LODThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LODThreshold");
        AlphaBoolBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaBoolBlend");
        AlphaCurveName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaCurveName");
        AlphaScaleBiasClamp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaScaleBiasClamp");
        AlphaInputType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaInputType");
        bAlphaBoolEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAlphaBoolEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_ApplyAdditive(IntPtr InNativeStruct)
    {
        unsafe
        {
            Base = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, Base_Offset), 0, null);
            Additive = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, Additive_Offset), 0, null);
            Alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Alpha_Offset), 0, null);
            AlphaScaleBias = BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.FromNative(IntPtr.Add(InNativeStruct, AlphaScaleBias_Offset), 0, null);
            LODThreshold = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, LODThreshold_Offset), 0, null);
            AlphaBoolBlend = UnrealSharp.Engine.InputAlphaBoolBlendMarshaler.FromNative(IntPtr.Add(InNativeStruct, AlphaBoolBlend_Offset), 0, null);
            AlphaCurveName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, AlphaCurveName_Offset), 0, null);
            AlphaScaleBiasClamp = UnrealSharp.Engine.InputScaleBiasClampMarshaler.FromNative(IntPtr.Add(InNativeStruct, AlphaScaleBiasClamp_Offset), 0, null);
            AlphaInputType = BlittableMarshaller<UnrealSharp.Engine.EAnimAlphaInputType>.FromNative(IntPtr.Add(InNativeStruct, AlphaInputType_Offset), 0, null);
            AlphaBoolEnabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAlphaBoolEnabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, Base_Offset), 0, null, Base);
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, Additive_Offset), 0, null, Additive);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Alpha_Offset), 0, null, Alpha);
            BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.ToNative(IntPtr.Add(Buffer, AlphaScaleBias_Offset), 0, null, AlphaScaleBias);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, LODThreshold_Offset), 0, null, LODThreshold);
            UnrealSharp.Engine.InputAlphaBoolBlendMarshaler.ToNative(IntPtr.Add(Buffer, AlphaBoolBlend_Offset), 0, null, AlphaBoolBlend);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, AlphaCurveName_Offset), 0, null, AlphaCurveName);
            UnrealSharp.Engine.InputScaleBiasClampMarshaler.ToNative(IntPtr.Add(Buffer, AlphaScaleBiasClamp_Offset), 0, null, AlphaScaleBiasClamp);
            BlittableMarshaller<UnrealSharp.Engine.EAnimAlphaInputType>.ToNative(IntPtr.Add(Buffer, AlphaInputType_Offset), 0, null, AlphaInputType);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAlphaBoolEnabled_Offset), 0, null, AlphaBoolEnabled);
        }
    }
}

public static class AnimNode_ApplyAdditiveMarshaler
{
    public static AnimNode_ApplyAdditive FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_ApplyAdditive(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_ApplyAdditive obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_ApplyAdditive.NativeDataSize;
    }
}