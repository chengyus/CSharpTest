using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_AimBoneMath
{
    // StructProperty /Script/ControlRig.RigUnit_AimBoneMath:InputTransform
    static readonly int InputTransform_Offset;
    public UnrealSharp.Transform InputTransform;
    
    // StructProperty /Script/ControlRig.RigUnit_AimBoneMath:Primary
    static readonly int Primary_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimItem_Target Primary;
    
    // StructProperty /Script/ControlRig.RigUnit_AimBoneMath:Secondary
    static readonly int Secondary_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimItem_Target Secondary;
    
    // FloatProperty /Script/ControlRig.RigUnit_AimBoneMath:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // StructProperty /Script/ControlRig.RigUnit_AimBoneMath:Result
    static readonly int Result_Offset;
    public UnrealSharp.Transform Result;
    
    // StructProperty /Script/ControlRig.RigUnit_AimBoneMath:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettings DebugSettings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_AimBoneMath()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_AimBoneMath");
        
        InputTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InputTransform");
        Primary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Primary");
        Secondary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Secondary");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_AimBoneMath(IntPtr InNativeStruct)
    {
        unsafe
        {
            InputTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, InputTransform_Offset), 0, null);
            Primary = UnrealSharp.ControlRig.RigUnit_AimItem_TargetMarshaler.FromNative(IntPtr.Add(InNativeStruct, Primary_Offset), 0, null);
            Secondary = UnrealSharp.ControlRig.RigUnit_AimItem_TargetMarshaler.FromNative(IntPtr.Add(InNativeStruct, Secondary_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
            DebugSettings = UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, InputTransform_Offset), 0, null, InputTransform);
            UnrealSharp.ControlRig.RigUnit_AimItem_TargetMarshaler.ToNative(IntPtr.Add(Buffer, Primary_Offset), 0, null, Primary);
            UnrealSharp.ControlRig.RigUnit_AimItem_TargetMarshaler.ToNative(IntPtr.Add(Buffer, Secondary_Offset), 0, null, Secondary);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
            UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
        }
    }
}

public static class RigUnit_AimBoneMathMarshaler
{
    public static RigUnit_AimBoneMath FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_AimBoneMath(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_AimBoneMath obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_AimBoneMath.NativeDataSize;
    }
}