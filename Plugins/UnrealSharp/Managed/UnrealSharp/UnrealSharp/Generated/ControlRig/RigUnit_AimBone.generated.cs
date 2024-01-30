using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_AimBone
{
    // NameProperty /Script/ControlRig.RigUnit_AimBone:Bone
    static readonly int Bone_Offset;
    public Name Bone;
    
    // StructProperty /Script/ControlRig.RigUnit_AimBone:Primary
    static readonly int Primary_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimBone_Target Primary;
    
    // StructProperty /Script/ControlRig.RigUnit_AimBone:Secondary
    static readonly int Secondary_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimBone_Target Secondary;
    
    // FloatProperty /Script/ControlRig.RigUnit_AimBone:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // BoolProperty /Script/ControlRig.RigUnit_AimBone:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // StructProperty /Script/ControlRig.RigUnit_AimBone:DebugSettings
    static readonly int DebugSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettings DebugSettings;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_AimBone()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_AimBone");
        
        Bone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bone");
        Primary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Primary");
        Secondary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Secondary");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        DebugSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSettings");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_AimBone(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Bone_Offset), 0, null);
            Primary = UnrealSharp.ControlRig.RigUnit_AimBone_TargetMarshaler.FromNative(IntPtr.Add(InNativeStruct, Primary_Offset), 0, null);
            Secondary = UnrealSharp.ControlRig.RigUnit_AimBone_TargetMarshaler.FromNative(IntPtr.Add(InNativeStruct, Secondary_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            DebugSettings = UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettingsMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugSettings_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Bone_Offset), 0, null, Bone);
            UnrealSharp.ControlRig.RigUnit_AimBone_TargetMarshaler.ToNative(IntPtr.Add(Buffer, Primary_Offset), 0, null, Primary);
            UnrealSharp.ControlRig.RigUnit_AimBone_TargetMarshaler.ToNative(IntPtr.Add(Buffer, Secondary_Offset), 0, null, Secondary);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            UnrealSharp.ControlRig.RigUnit_AimBone_DebugSettingsMarshaler.ToNative(IntPtr.Add(Buffer, DebugSettings_Offset), 0, null, DebugSettings);
        }
    }
}

public static class RigUnit_AimBoneMarshaler
{
    public static RigUnit_AimBone FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_AimBone(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_AimBone obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_AimBone.NativeDataSize;
    }
}