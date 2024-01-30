using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyAddControlRotator_LimitSettings
{
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlRotator_LimitSettings:LimitPitch
    static readonly int LimitPitch_Offset;
    public UnrealSharp.ControlRig.RigControlLimitEnabled LimitPitch;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlRotator_LimitSettings:LimitYaw
    static readonly int LimitYaw_Offset;
    public UnrealSharp.ControlRig.RigControlLimitEnabled LimitYaw;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlRotator_LimitSettings:LimitRoll
    static readonly int LimitRoll_Offset;
    public UnrealSharp.ControlRig.RigControlLimitEnabled LimitRoll;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlRotator_LimitSettings:MinValue
    static readonly int MinValue_Offset;
    public UnrealSharp.Rotator MinValue;
    
    // StructProperty /Script/ControlRig.RigUnit_HierarchyAddControlRotator_LimitSettings:MaxValue
    static readonly int MaxValue_Offset;
    public UnrealSharp.Rotator MaxValue;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyAddControlRotator_LimitSettings:bDrawLimits
    static readonly int bDrawLimits_Offset;
    public bool DrawLimits;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyAddControlRotator_LimitSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyAddControlRotator_LimitSettings");
        
        LimitPitch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LimitPitch");
        LimitYaw_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LimitYaw");
        LimitRoll_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LimitRoll");
        MinValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinValue");
        MaxValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxValue");
        bDrawLimits_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawLimits");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyAddControlRotator_LimitSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            LimitPitch = UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.FromNative(IntPtr.Add(InNativeStruct, LimitPitch_Offset), 0, null);
            LimitYaw = UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.FromNative(IntPtr.Add(InNativeStruct, LimitYaw_Offset), 0, null);
            LimitRoll = UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.FromNative(IntPtr.Add(InNativeStruct, LimitRoll_Offset), 0, null);
            MinValue = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, MinValue_Offset), 0, null);
            MaxValue = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, MaxValue_Offset), 0, null);
            DrawLimits = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawLimits_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.ToNative(IntPtr.Add(Buffer, LimitPitch_Offset), 0, null, LimitPitch);
            UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.ToNative(IntPtr.Add(Buffer, LimitYaw_Offset), 0, null, LimitYaw);
            UnrealSharp.ControlRig.RigControlLimitEnabledMarshaler.ToNative(IntPtr.Add(Buffer, LimitRoll_Offset), 0, null, LimitRoll);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, MinValue_Offset), 0, null, MinValue);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, MaxValue_Offset), 0, null, MaxValue);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawLimits_Offset), 0, null, DrawLimits);
        }
    }
}

public static class RigUnit_HierarchyAddControlRotator_LimitSettingsMarshaler
{
    public static RigUnit_HierarchyAddControlRotator_LimitSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyAddControlRotator_LimitSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyAddControlRotator_LimitSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyAddControlRotator_LimitSettings.NativeDataSize;
    }
}