using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_AimConstraint_WorldUp
{
    // StructProperty /Script/ControlRig.RigUnit_AimConstraint_WorldUp:Target
    static readonly int Target_Offset;
    public System.DoubleNumerics.Vector3 Target;
    
    // EnumProperty /Script/ControlRig.RigUnit_AimConstraint_WorldUp:Kind
    static readonly int Kind_Offset;
    public UnrealSharp.ControlRig.EControlRigVectorKind Kind;
    
    // StructProperty /Script/ControlRig.RigUnit_AimConstraint_WorldUp:Space
    static readonly int Space_Offset;
    public UnrealSharp.ControlRig.RigElementKey Space;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_AimConstraint_WorldUp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_AimConstraint_WorldUp");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Kind_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Kind");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_AimConstraint_WorldUp(IntPtr InNativeStruct)
    {
        unsafe
        {
            Target = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Kind = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigVectorKind>.FromNative(IntPtr.Add(InNativeStruct, Kind_Offset), 0, null);
            Space = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigVectorKind>.ToNative(IntPtr.Add(Buffer, Kind_Offset), 0, null, Kind);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
        }
    }
}

public static class RigUnit_AimConstraint_WorldUpMarshaler
{
    public static RigUnit_AimConstraint_WorldUp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_AimConstraint_WorldUp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_AimConstraint_WorldUp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_AimConstraint_WorldUp.NativeDataSize;
    }
}