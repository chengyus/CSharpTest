using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_AimConstraintLocalSpaceOffset
{
    // StructProperty /Script/ControlRig.RigUnit_AimConstraintLocalSpaceOffset:Child
    static readonly int Child_Offset;
    public UnrealSharp.ControlRig.RigElementKey Child;
    
    // BoolProperty /Script/ControlRig.RigUnit_AimConstraintLocalSpaceOffset:bMaintainOffset
    static readonly int bMaintainOffset_Offset;
    public bool MaintainOffset;
    
    // StructProperty /Script/ControlRig.RigUnit_AimConstraintLocalSpaceOffset:Filter
    static readonly int Filter_Offset;
    public UnrealSharp.AnimationCore.FilterOptionPerAxis Filter;
    
    // StructProperty /Script/ControlRig.RigUnit_AimConstraintLocalSpaceOffset:AimAxis
    static readonly int AimAxis_Offset;
    public System.DoubleNumerics.Vector3 AimAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_AimConstraintLocalSpaceOffset:UpAxis
    static readonly int UpAxis_Offset;
    public System.DoubleNumerics.Vector3 UpAxis;
    
    // StructProperty /Script/ControlRig.RigUnit_AimConstraintLocalSpaceOffset:WorldUp
    static readonly int WorldUp_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimConstraint_WorldUp WorldUp;
    
    // StructProperty /Script/ControlRig.RigUnit_AimConstraintLocalSpaceOffset:AdvancedSettings
    static readonly int AdvancedSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimConstraint_AdvancedSettings AdvancedSettings;
    
    // FloatProperty /Script/ControlRig.RigUnit_AimConstraintLocalSpaceOffset:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_AimConstraintLocalSpaceOffset()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_AimConstraintLocalSpaceOffset");
        
        Child_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Child");
        bMaintainOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMaintainOffset");
        Filter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Filter");
        AimAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AimAxis");
        UpAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpAxis");
        WorldUp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldUp");
        AdvancedSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AdvancedSettings");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_AimConstraintLocalSpaceOffset(IntPtr InNativeStruct)
    {
        unsafe
        {
            Child = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Child_Offset), 0, null);
            MaintainOffset = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMaintainOffset_Offset), 0, null);
            Filter = UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.FromNative(IntPtr.Add(InNativeStruct, Filter_Offset), 0, null);
            AimAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AimAxis_Offset), 0, null);
            UpAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, UpAxis_Offset), 0, null);
            WorldUp = UnrealSharp.ControlRig.RigUnit_AimConstraint_WorldUpMarshaler.FromNative(IntPtr.Add(InNativeStruct, WorldUp_Offset), 0, null);
            AdvancedSettings = UnrealSharp.ControlRig.RigUnit_AimConstraint_AdvancedSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, AdvancedSettings_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Child_Offset), 0, null, Child);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMaintainOffset_Offset), 0, null, MaintainOffset);
            UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.ToNative(IntPtr.Add(Buffer, Filter_Offset), 0, null, Filter);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AimAxis_Offset), 0, null, AimAxis);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, UpAxis_Offset), 0, null, UpAxis);
            UnrealSharp.ControlRig.RigUnit_AimConstraint_WorldUpMarshaler.ToNative(IntPtr.Add(Buffer, WorldUp_Offset), 0, null, WorldUp);
            UnrealSharp.ControlRig.RigUnit_AimConstraint_AdvancedSettingsMarshaler.ToNative(IntPtr.Add(Buffer, AdvancedSettings_Offset), 0, null, AdvancedSettings);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
        }
    }
}

public static class RigUnit_AimConstraintLocalSpaceOffsetMarshaler
{
    public static RigUnit_AimConstraintLocalSpaceOffset FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_AimConstraintLocalSpaceOffset(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_AimConstraintLocalSpaceOffset obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_AimConstraintLocalSpaceOffset.NativeDataSize;
    }
}