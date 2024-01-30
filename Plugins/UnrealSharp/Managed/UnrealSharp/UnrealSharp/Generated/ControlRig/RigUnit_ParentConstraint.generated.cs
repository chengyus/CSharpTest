using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ParentConstraint
{
    // StructProperty /Script/ControlRig.RigUnit_ParentConstraint:Child
    static readonly int Child_Offset;
    public UnrealSharp.ControlRig.RigElementKey Child;
    
    // BoolProperty /Script/ControlRig.RigUnit_ParentConstraint:bMaintainOffset
    static readonly int bMaintainOffset_Offset;
    public bool MaintainOffset;
    
    // StructProperty /Script/ControlRig.RigUnit_ParentConstraint:Filter
    static readonly int Filter_Offset;
    public UnrealSharp.AnimationCore.TransformFilter Filter;
    
    // StructProperty /Script/ControlRig.RigUnit_ParentConstraint:AdvancedSettings
    static readonly int AdvancedSettings_Offset;
    public UnrealSharp.ControlRig.RigUnit_ParentConstraint_AdvancedSettings AdvancedSettings;
    
    // FloatProperty /Script/ControlRig.RigUnit_ParentConstraint:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ParentConstraint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ParentConstraint");
        
        Child_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Child");
        bMaintainOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMaintainOffset");
        Filter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Filter");
        AdvancedSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AdvancedSettings");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ParentConstraint(IntPtr InNativeStruct)
    {
        unsafe
        {
            Child = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Child_Offset), 0, null);
            MaintainOffset = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMaintainOffset_Offset), 0, null);
            Filter = UnrealSharp.AnimationCore.TransformFilterMarshaler.FromNative(IntPtr.Add(InNativeStruct, Filter_Offset), 0, null);
            AdvancedSettings = BlittableMarshaller<UnrealSharp.ControlRig.RigUnit_ParentConstraint_AdvancedSettings>.FromNative(IntPtr.Add(InNativeStruct, AdvancedSettings_Offset), 0, null);
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
            UnrealSharp.AnimationCore.TransformFilterMarshaler.ToNative(IntPtr.Add(Buffer, Filter_Offset), 0, null, Filter);
            BlittableMarshaller<UnrealSharp.ControlRig.RigUnit_ParentConstraint_AdvancedSettings>.ToNative(IntPtr.Add(Buffer, AdvancedSettings_Offset), 0, null, AdvancedSettings);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
        }
    }
}

public static class RigUnit_ParentConstraintMarshaler
{
    public static RigUnit_ParentConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ParentConstraint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ParentConstraint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ParentConstraint.NativeDataSize;
    }
}