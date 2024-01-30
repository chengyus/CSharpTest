using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_AimConstraint_AdvancedSettings
{
    // StructProperty /Script/ControlRig.RigUnit_AimConstraint_AdvancedSettings:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettings DebugSettings;
    
    // EnumProperty /Script/ControlRig.RigUnit_AimConstraint_AdvancedSettings:RotationOrderForFilter
    static readonly int RotationOrderForFilter_Offset;
    public UnrealSharp.AnimationCore.EEulerRotationOrder RotationOrderForFilter;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_AimConstraint_AdvancedSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_AimConstraint_AdvancedSettings");
        
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        RotationOrderForFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RotationOrderForFilter");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_AimConstraint_AdvancedSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DebugSettings = UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
            RotationOrderForFilter = BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.FromNative(IntPtr.Add(InNativeStruct, RotationOrderForFilter_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
            BlittableMarshaller<UnrealSharp.AnimationCore.EEulerRotationOrder>.ToNative(IntPtr.Add(Buffer, RotationOrderForFilter_Offset), 0, null, RotationOrderForFilter);
        }
    }
}

public static class RigUnit_AimConstraint_AdvancedSettingsMarshaler
{
    public static RigUnit_AimConstraint_AdvancedSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_AimConstraint_AdvancedSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_AimConstraint_AdvancedSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_AimConstraint_AdvancedSettings.NativeDataSize;
    }
}