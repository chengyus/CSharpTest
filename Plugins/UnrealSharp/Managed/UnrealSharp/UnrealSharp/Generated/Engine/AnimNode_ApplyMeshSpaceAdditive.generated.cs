using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimNode_ApplyMeshSpaceAdditive
{
    // StructProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:Base
    static readonly int Base_Offset;
    public UnrealSharp.Engine.PoseLink Base;
    
    // StructProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:Additive
    static readonly int Additive_Offset;
    public UnrealSharp.Engine.PoseLink Additive;
    
    // EnumProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaInputType
    static readonly int AlphaInputType_Offset;
    public UnrealSharp.Engine.EAnimAlphaInputType AlphaInputType;
    
    // FloatProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:Alpha
    static readonly int Alpha_Offset;
    public float Alpha;
    
    // BoolProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:bAlphaBoolEnabled
    static readonly int bAlphaBoolEnabled_Offset;
    static readonly IntPtr bAlphaBoolEnabled_NativeProperty;
    public bool AlphaBoolEnabled;
    
    // StructProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaBoolBlend
    static readonly int AlphaBoolBlend_Offset;
    public UnrealSharp.Engine.InputAlphaBoolBlend AlphaBoolBlend;
    
    // NameProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaCurveName
    static readonly int AlphaCurveName_Offset;
    public Name AlphaCurveName;
    
    // StructProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaScaleBias
    static readonly int AlphaScaleBias_Offset;
    public UnrealSharp.Engine.InputScaleBias AlphaScaleBias;
    
    // StructProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaScaleBiasClamp
    static readonly int AlphaScaleBiasClamp_Offset;
    public UnrealSharp.Engine.InputScaleBiasClamp AlphaScaleBiasClamp;
    
    // IntProperty /Script/Engine.AnimNode_ApplyMeshSpaceAdditive:LODThreshold
    static readonly int LODThreshold_Offset;
    public int LODThreshold;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_ApplyMeshSpaceAdditive()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_ApplyMeshSpaceAdditive");
        
        Base_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Base");
        Additive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Additive");
        AlphaInputType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaInputType");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        bAlphaBoolEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAlphaBoolEnabled");
        bAlphaBoolEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAlphaBoolEnabled");
        AlphaBoolBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaBoolBlend");
        AlphaCurveName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaCurveName");
        AlphaScaleBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaScaleBias");
        AlphaScaleBiasClamp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaScaleBiasClamp");
        LODThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LODThreshold");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_ApplyMeshSpaceAdditive(IntPtr InNativeStruct)
    {
        unsafe
        {
            Base = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, Base_Offset), 0, null);
            Additive = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, Additive_Offset), 0, null);
            AlphaInputType = BlittableMarshaller<UnrealSharp.Engine.EAnimAlphaInputType>.FromNative(IntPtr.Add(InNativeStruct, AlphaInputType_Offset), 0, null);
            Alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Alpha_Offset), 0, null);
            AlphaBoolEnabled = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAlphaBoolEnabled_NativeProperty, bAlphaBoolEnabled_Offset);
            AlphaBoolBlend = UnrealSharp.Engine.InputAlphaBoolBlendMarshaler.FromNative(IntPtr.Add(InNativeStruct, AlphaBoolBlend_Offset), 0, null);
            AlphaCurveName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, AlphaCurveName_Offset), 0, null);
            AlphaScaleBias = BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.FromNative(IntPtr.Add(InNativeStruct, AlphaScaleBias_Offset), 0, null);
            AlphaScaleBiasClamp = UnrealSharp.Engine.InputScaleBiasClampMarshaler.FromNative(IntPtr.Add(InNativeStruct, AlphaScaleBiasClamp_Offset), 0, null);
            LODThreshold = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, LODThreshold_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, Base_Offset), 0, null, Base);
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, Additive_Offset), 0, null, Additive);
            BlittableMarshaller<UnrealSharp.Engine.EAnimAlphaInputType>.ToNative(IntPtr.Add(Buffer, AlphaInputType_Offset), 0, null, AlphaInputType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Alpha_Offset), 0, null, Alpha);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAlphaBoolEnabled_NativeProperty, bAlphaBoolEnabled_Offset, AlphaBoolEnabled);
            UnrealSharp.Engine.InputAlphaBoolBlendMarshaler.ToNative(IntPtr.Add(Buffer, AlphaBoolBlend_Offset), 0, null, AlphaBoolBlend);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, AlphaCurveName_Offset), 0, null, AlphaCurveName);
            BlittableMarshaller<UnrealSharp.Engine.InputScaleBias>.ToNative(IntPtr.Add(Buffer, AlphaScaleBias_Offset), 0, null, AlphaScaleBias);
            UnrealSharp.Engine.InputScaleBiasClampMarshaler.ToNative(IntPtr.Add(Buffer, AlphaScaleBiasClamp_Offset), 0, null, AlphaScaleBiasClamp);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, LODThreshold_Offset), 0, null, LODThreshold);
        }
    }
}

public static class AnimNode_ApplyMeshSpaceAdditiveMarshaler
{
    public static AnimNode_ApplyMeshSpaceAdditive FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_ApplyMeshSpaceAdditive(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_ApplyMeshSpaceAdditive obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_ApplyMeshSpaceAdditive.NativeDataSize;
    }
}