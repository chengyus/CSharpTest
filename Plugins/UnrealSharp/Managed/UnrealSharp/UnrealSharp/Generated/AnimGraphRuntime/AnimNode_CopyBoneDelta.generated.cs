using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_CopyBoneDelta
{
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:bCopyTranslation
    static readonly int bCopyTranslation_Offset;
    public bool CopyTranslation;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:bCopyRotation
    static readonly int bCopyRotation_Offset;
    public bool CopyRotation;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:bCopyScale
    static readonly int bCopyScale_Offset;
    public bool CopyScale;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:TranslationMultiplier
    static readonly int TranslationMultiplier_Offset;
    public float TranslationMultiplier;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:RotationMultiplier
    static readonly int RotationMultiplier_Offset;
    public float RotationMultiplier;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:ScaleMultiplier
    static readonly int ScaleMultiplier_Offset;
    public float ScaleMultiplier;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_CopyBoneDelta()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_CopyBoneDelta");
        
        bCopyTranslation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyTranslation");
        bCopyRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyRotation");
        bCopyScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCopyScale");
        TranslationMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TranslationMultiplier");
        RotationMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationMultiplier");
        ScaleMultiplier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleMultiplier");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_CopyBoneDelta(IntPtr InNativeStruct)
    {
        unsafe
        {
            CopyTranslation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCopyTranslation_Offset), 0, null);
            CopyRotation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCopyRotation_Offset), 0, null);
            CopyScale = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCopyScale_Offset), 0, null);
            TranslationMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TranslationMultiplier_Offset), 0, null);
            RotationMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RotationMultiplier_Offset), 0, null);
            ScaleMultiplier = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScaleMultiplier_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCopyTranslation_Offset), 0, null, CopyTranslation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCopyRotation_Offset), 0, null, CopyRotation);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCopyScale_Offset), 0, null, CopyScale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TranslationMultiplier_Offset), 0, null, TranslationMultiplier);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RotationMultiplier_Offset), 0, null, RotationMultiplier);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScaleMultiplier_Offset), 0, null, ScaleMultiplier);
        }
    }
}

public static class AnimNode_CopyBoneDeltaMarshaler
{
    public static AnimNode_CopyBoneDelta FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_CopyBoneDelta(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_CopyBoneDelta obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_CopyBoneDelta.NativeDataSize;
    }
}