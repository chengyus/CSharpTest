using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct TargetChainFKSettings
{
    // BoolProperty /Script/IKRig.TargetChainFKSettings:EnableFK
    static readonly int EnableFK_Offset;
    public bool EnableFK;
    
    // EnumProperty /Script/IKRig.TargetChainFKSettings:RotationMode
    static readonly int RotationMode_Offset;
    public UnrealSharp.IKRig.ERetargetRotationMode RotationMode;
    
    // FloatProperty /Script/IKRig.TargetChainFKSettings:RotationAlpha
    static readonly int RotationAlpha_Offset;
    public float RotationAlpha;
    
    // EnumProperty /Script/IKRig.TargetChainFKSettings:TranslationMode
    static readonly int TranslationMode_Offset;
    public UnrealSharp.IKRig.ERetargetTranslationMode TranslationMode;
    
    // FloatProperty /Script/IKRig.TargetChainFKSettings:TranslationAlpha
    static readonly int TranslationAlpha_Offset;
    public float TranslationAlpha;
    
    // FloatProperty /Script/IKRig.TargetChainFKSettings:PoleVectorMatching
    static readonly int PoleVectorMatching_Offset;
    public float PoleVectorMatching;
    
    // FloatProperty /Script/IKRig.TargetChainFKSettings:PoleVectorOffset
    static readonly int PoleVectorOffset_Offset;
    public float PoleVectorOffset;
    
    
    public static readonly int NativeDataSize;
    static TargetChainFKSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TargetChainFKSettings");
        
        EnableFK_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnableFK");
        RotationMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationMode");
        RotationAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationAlpha");
        TranslationMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TranslationMode");
        TranslationAlpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TranslationAlpha");
        PoleVectorMatching_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorMatching");
        PoleVectorOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleVectorOffset");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TargetChainFKSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            EnableFK = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, EnableFK_Offset), 0, null);
            RotationMode = BlittableMarshaller<UnrealSharp.IKRig.ERetargetRotationMode>.FromNative(IntPtr.Add(InNativeStruct, RotationMode_Offset), 0, null);
            RotationAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, RotationAlpha_Offset), 0, null);
            TranslationMode = BlittableMarshaller<UnrealSharp.IKRig.ERetargetTranslationMode>.FromNative(IntPtr.Add(InNativeStruct, TranslationMode_Offset), 0, null);
            TranslationAlpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TranslationAlpha_Offset), 0, null);
            PoleVectorMatching = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PoleVectorMatching_Offset), 0, null);
            PoleVectorOffset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PoleVectorOffset_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, EnableFK_Offset), 0, null, EnableFK);
            BlittableMarshaller<UnrealSharp.IKRig.ERetargetRotationMode>.ToNative(IntPtr.Add(Buffer, RotationMode_Offset), 0, null, RotationMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, RotationAlpha_Offset), 0, null, RotationAlpha);
            BlittableMarshaller<UnrealSharp.IKRig.ERetargetTranslationMode>.ToNative(IntPtr.Add(Buffer, TranslationMode_Offset), 0, null, TranslationMode);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TranslationAlpha_Offset), 0, null, TranslationAlpha);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PoleVectorMatching_Offset), 0, null, PoleVectorMatching);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PoleVectorOffset_Offset), 0, null, PoleVectorOffset);
        }
    }
}

public static class TargetChainFKSettingsMarshaler
{
    public static TargetChainFKSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TargetChainFKSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TargetChainFKSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TargetChainFKSettings.NativeDataSize;
    }
}