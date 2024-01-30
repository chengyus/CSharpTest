using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct TargetChainSpeedPlantSettings
{
    // BoolProperty /Script/IKRig.TargetChainSpeedPlantSettings:EnableSpeedPlanting
    static readonly int EnableSpeedPlanting_Offset;
    public bool EnableSpeedPlanting;
    
    // NameProperty /Script/IKRig.TargetChainSpeedPlantSettings:SpeedCurveName
    static readonly int SpeedCurveName_Offset;
    public Name SpeedCurveName;
    
    // FloatProperty /Script/IKRig.TargetChainSpeedPlantSettings:SpeedThreshold
    static readonly int SpeedThreshold_Offset;
    public float SpeedThreshold;
    
    // FloatProperty /Script/IKRig.TargetChainSpeedPlantSettings:UnplantStiffness
    static readonly int UnplantStiffness_Offset;
    public float UnplantStiffness;
    
    // FloatProperty /Script/IKRig.TargetChainSpeedPlantSettings:UnplantCriticalDamping
    static readonly int UnplantCriticalDamping_Offset;
    public float UnplantCriticalDamping;
    
    
    public static readonly int NativeDataSize;
    static TargetChainSpeedPlantSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TargetChainSpeedPlantSettings");
        
        EnableSpeedPlanting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EnableSpeedPlanting");
        SpeedCurveName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpeedCurveName");
        SpeedThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpeedThreshold");
        UnplantStiffness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UnplantStiffness");
        UnplantCriticalDamping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UnplantCriticalDamping");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TargetChainSpeedPlantSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            EnableSpeedPlanting = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, EnableSpeedPlanting_Offset), 0, null);
            SpeedCurveName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SpeedCurveName_Offset), 0, null);
            SpeedThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SpeedThreshold_Offset), 0, null);
            UnplantStiffness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, UnplantStiffness_Offset), 0, null);
            UnplantCriticalDamping = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, UnplantCriticalDamping_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, EnableSpeedPlanting_Offset), 0, null, EnableSpeedPlanting);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SpeedCurveName_Offset), 0, null, SpeedCurveName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SpeedThreshold_Offset), 0, null, SpeedThreshold);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, UnplantStiffness_Offset), 0, null, UnplantStiffness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, UnplantCriticalDamping_Offset), 0, null, UnplantCriticalDamping);
        }
    }
}

public static class TargetChainSpeedPlantSettingsMarshaler
{
    public static TargetChainSpeedPlantSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TargetChainSpeedPlantSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TargetChainSpeedPlantSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TargetChainSpeedPlantSettings.NativeDataSize;
    }
}