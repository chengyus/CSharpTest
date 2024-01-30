using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct TargetRootSettings
{
    // FloatProperty /Script/IKRig.TargetRootSettings:RotationAlpha
    static readonly int RotationAlpha_Offset;
    public float RotationAlpha;
    
    // FloatProperty /Script/IKRig.TargetRootSettings:TranslationAlpha
    static readonly int TranslationAlpha_Offset;
    public float TranslationAlpha;
    
    // FloatProperty /Script/IKRig.TargetRootSettings:BlendToSource
    static readonly int BlendToSource_Offset;
    public float BlendToSource;
    
    // StructProperty /Script/IKRig.TargetRootSettings:BlendToSourceWeights
    static readonly int BlendToSourceWeights_Offset;
    public System.DoubleNumerics.Vector3 BlendToSourceWeights;
    
    // FloatProperty /Script/IKRig.TargetRootSettings:ScaleHorizontal
    static readonly int ScaleHorizontal_Offset;
    public float ScaleHorizontal;
    
    // FloatProperty /Script/IKRig.TargetRootSettings:ScaleVertical
    static readonly int ScaleVertical_Offset;
    public float ScaleVertical;
    
    // StructProperty /Script/IKRig.TargetRootSettings:TranslationOffset
    static readonly int TranslationOffset_Offset;
    public System.DoubleNumerics.Vector3 TranslationOffset;
    
    // StructProperty /Script/IKRig.TargetRootSettings:RotationOffset
    static readonly int RotationOffset_Offset;
    public UnrealSharp.Rotator RotationOffset;
    
    // FloatProperty /Script/IKRig.TargetRootSettings:AffectIKHorizontal
    static readonly int AffectIKHorizontal_Offset;
    public float AffectIKHorizontal;
    
    // FloatProperty /Script/IKRig.TargetRootSettings:AffectIKVertical
    static readonly int AffectIKVertical_Offset;
    public float AffectIKVertical;
    
    
    public static readonly int NativeDataSize;
    static TargetRootSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TargetRootSettings");
        
        RotationAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationAlpha");
        TranslationAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TranslationAlpha");
        BlendToSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendToSource");
        BlendToSourceWeights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendToSourceWeights");
        ScaleHorizontal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleHorizontal");
        ScaleVertical_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleVertical");
        TranslationOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TranslationOffset");
        RotationOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationOffset");
        AffectIKHorizontal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AffectIKHorizontal");
        AffectIKVertical_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AffectIKVertical");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TargetRootSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            RotationAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RotationAlpha_Offset), 0, null);
            TranslationAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TranslationAlpha_Offset), 0, null);
            BlendToSource = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendToSource_Offset), 0, null);
            BlendToSourceWeights = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, BlendToSourceWeights_Offset), 0, null);
            ScaleHorizontal = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScaleHorizontal_Offset), 0, null);
            ScaleVertical = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScaleVertical_Offset), 0, null);
            TranslationOffset = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TranslationOffset_Offset), 0, null);
            RotationOffset = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, RotationOffset_Offset), 0, null);
            AffectIKHorizontal = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AffectIKHorizontal_Offset), 0, null);
            AffectIKVertical = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AffectIKVertical_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RotationAlpha_Offset), 0, null, RotationAlpha);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TranslationAlpha_Offset), 0, null, TranslationAlpha);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendToSource_Offset), 0, null, BlendToSource);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, BlendToSourceWeights_Offset), 0, null, BlendToSourceWeights);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScaleHorizontal_Offset), 0, null, ScaleHorizontal);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScaleVertical_Offset), 0, null, ScaleVertical);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TranslationOffset_Offset), 0, null, TranslationOffset);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, RotationOffset_Offset), 0, null, RotationOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AffectIKHorizontal_Offset), 0, null, AffectIKHorizontal);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AffectIKVertical_Offset), 0, null, AffectIKVertical);
        }
    }
}

public static class TargetRootSettingsMarshaler
{
    public static TargetRootSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TargetRootSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TargetRootSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TargetRootSettings.NativeDataSize;
    }
}