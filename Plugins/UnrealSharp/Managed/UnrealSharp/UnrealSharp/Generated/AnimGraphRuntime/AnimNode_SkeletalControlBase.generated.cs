using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_SkeletalControlBase
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:ComponentPose
    static readonly int ComponentPose_Offset;
    public UnrealSharp.Engine.ComponentSpacePoseLink ComponentPose;
    
    // IntProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:LODThreshold
    static readonly int LODThreshold_Offset;
    public int LODThreshold;
    
    // EnumProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaInputType
    static readonly int AlphaInputType_Offset;
    public UnrealSharp.Engine.EAnimAlphaInputType AlphaInputType;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:bAlphaBoolEnabled
    static readonly int bAlphaBoolEnabled_Offset;
    public bool AlphaBoolEnabled;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:Alpha
    static readonly int Alpha_Offset;
    public float Alpha;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaScaleBias
    static readonly int AlphaScaleBias_Offset;
    public UnrealSharp.Engine.InputScaleBias AlphaScaleBias;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaBoolBlend
    static readonly int AlphaBoolBlend_Offset;
    public UnrealSharp.Engine.InputAlphaBoolBlend AlphaBoolBlend;
    
    // NameProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaCurveName
    static readonly int AlphaCurveName_Offset;
    public Name AlphaCurveName;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaScaleBiasClamp
    static readonly int AlphaScaleBiasClamp_Offset;
    public UnrealSharp.Engine.InputScaleBiasClamp AlphaScaleBiasClamp;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_SkeletalControlBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_SkeletalControlBase");
        
        ComponentPose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComponentPose");
        LODThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LODThreshold");
        AlphaInputType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaInputType");
        bAlphaBoolEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAlphaBoolEnabled");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        AlphaScaleBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaScaleBias");
        AlphaBoolBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaBoolBlend");
        AlphaCurveName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaCurveName");
        AlphaScaleBiasClamp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaScaleBiasClamp");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_SkeletalControlBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComponentPose = UnrealSharp.Engine.ComponentSpacePoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, ComponentPose_Offset), 0, null);
            LODThreshold = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, LODThreshold_Offset), 0, null);
            AlphaInputType = BlittableMarshaller<UnrealSharp.Engine.EAnimAlphaInputType>.FromNative(IntPtr.Add(InNativeStruct, AlphaInputType_Offset), 0, null);
            AlphaBoolEnabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAlphaBoolEnabled_Offset), 0, null);
            Alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Alpha_Offset), 0, null);
            AlphaScaleBias = BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.FromNative(IntPtr.Add(InNativeStruct, AlphaScaleBias_Offset), 0, null);
            AlphaBoolBlend = UnrealSharp.Engine.InputAlphaBoolBlendMarshaler.FromNative(IntPtr.Add(InNativeStruct, AlphaBoolBlend_Offset), 0, null);
            AlphaCurveName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, AlphaCurveName_Offset), 0, null);
            AlphaScaleBiasClamp = UnrealSharp.Engine.InputScaleBiasClampMarshaler.FromNative(IntPtr.Add(InNativeStruct, AlphaScaleBiasClamp_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.ComponentSpacePoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, ComponentPose_Offset), 0, null, ComponentPose);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, LODThreshold_Offset), 0, null, LODThreshold);
            BlittableMarshaller<UnrealSharp.Engine.EAnimAlphaInputType>.ToNative(IntPtr.Add(Buffer, AlphaInputType_Offset), 0, null, AlphaInputType);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAlphaBoolEnabled_Offset), 0, null, AlphaBoolEnabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Alpha_Offset), 0, null, Alpha);
            BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.ToNative(IntPtr.Add(Buffer, AlphaScaleBias_Offset), 0, null, AlphaScaleBias);
            UnrealSharp.Engine.InputAlphaBoolBlendMarshaler.ToNative(IntPtr.Add(Buffer, AlphaBoolBlend_Offset), 0, null, AlphaBoolBlend);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, AlphaCurveName_Offset), 0, null, AlphaCurveName);
            UnrealSharp.Engine.InputScaleBiasClampMarshaler.ToNative(IntPtr.Add(Buffer, AlphaScaleBiasClamp_Offset), 0, null, AlphaScaleBiasClamp);
        }
    }
}

public static class AnimNode_SkeletalControlBaseMarshaler
{
    public static AnimNode_SkeletalControlBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_SkeletalControlBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_SkeletalControlBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_SkeletalControlBase.NativeDataSize;
    }
}