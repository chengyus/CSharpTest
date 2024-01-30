using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct TargetChainIKSettings
{
    // BoolProperty /Script/IKRig.TargetChainIKSettings:EnableIK
    static readonly int EnableIK_Offset;
    public bool EnableIK;
    
    // FloatProperty /Script/IKRig.TargetChainIKSettings:BlendToSource
    static readonly int BlendToSource_Offset;
    public float BlendToSource;
    
    // StructProperty /Script/IKRig.TargetChainIKSettings:BlendToSourceWeights
    static readonly int BlendToSourceWeights_Offset;
    public System.DoubleNumerics.Vector3 BlendToSourceWeights;
    
    // StructProperty /Script/IKRig.TargetChainIKSettings:StaticOffset
    static readonly int StaticOffset_Offset;
    public System.DoubleNumerics.Vector3 StaticOffset;
    
    // StructProperty /Script/IKRig.TargetChainIKSettings:StaticLocalOffset
    static readonly int StaticLocalOffset_Offset;
    public System.DoubleNumerics.Vector3 StaticLocalOffset;
    
    // StructProperty /Script/IKRig.TargetChainIKSettings:StaticRotationOffset
    static readonly int StaticRotationOffset_Offset;
    public UnrealSharp.Rotator StaticRotationOffset;
    
    // FloatProperty /Script/IKRig.TargetChainIKSettings:ScaleVertical
    static readonly int ScaleVertical_Offset;
    public float ScaleVertical;
    
    // FloatProperty /Script/IKRig.TargetChainIKSettings:Extension
    static readonly int Extension_Offset;
    public float Extension;
    
    // BoolProperty /Script/IKRig.TargetChainIKSettings:bAffectedByIKWarping
    static readonly int bAffectedByIKWarping_Offset;
    public bool AffectedByIKWarping;
    
    
    public static readonly int NativeDataSize;
    static TargetChainIKSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TargetChainIKSettings");
        
        EnableIK_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnableIK");
        BlendToSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendToSource");
        BlendToSourceWeights_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendToSourceWeights");
        StaticOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticOffset");
        StaticLocalOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticLocalOffset");
        StaticRotationOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StaticRotationOffset");
        ScaleVertical_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScaleVertical");
        Extension_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Extension");
        bAffectedByIKWarping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAffectedByIKWarping");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TargetChainIKSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            EnableIK = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, EnableIK_Offset), 0, null);
            BlendToSource = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendToSource_Offset), 0, null);
            BlendToSourceWeights = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, BlendToSourceWeights_Offset), 0, null);
            StaticOffset = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, StaticOffset_Offset), 0, null);
            StaticLocalOffset = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, StaticLocalOffset_Offset), 0, null);
            StaticRotationOffset = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, StaticRotationOffset_Offset), 0, null);
            ScaleVertical = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ScaleVertical_Offset), 0, null);
            Extension = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Extension_Offset), 0, null);
            AffectedByIKWarping = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAffectedByIKWarping_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, EnableIK_Offset), 0, null, EnableIK);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendToSource_Offset), 0, null, BlendToSource);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, BlendToSourceWeights_Offset), 0, null, BlendToSourceWeights);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, StaticOffset_Offset), 0, null, StaticOffset);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, StaticLocalOffset_Offset), 0, null, StaticLocalOffset);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, StaticRotationOffset_Offset), 0, null, StaticRotationOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ScaleVertical_Offset), 0, null, ScaleVertical);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Extension_Offset), 0, null, Extension);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAffectedByIKWarping_Offset), 0, null, AffectedByIKWarping);
        }
    }
}

public static class TargetChainIKSettingsMarshaler
{
    public static TargetChainIKSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TargetChainIKSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TargetChainIKSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TargetChainIKSettings.NativeDataSize;
    }
}