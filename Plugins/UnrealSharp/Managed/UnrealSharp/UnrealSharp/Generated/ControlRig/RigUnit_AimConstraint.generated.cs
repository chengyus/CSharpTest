using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_AimConstraint
{
    // NameProperty /Script/ControlRig.RigUnit_AimConstraint:Joint
    static readonly int Joint_Offset;
    public Name Joint;
    
    // EnumProperty /Script/ControlRig.RigUnit_AimConstraint:AimMode
    static readonly int AimMode_Offset;
    public UnrealSharp.ControlRig.EAimMode AimMode;
    
    // EnumProperty /Script/ControlRig.RigUnit_AimConstraint:UpMode
    static readonly int UpMode_Offset;
    public UnrealSharp.ControlRig.EAimMode UpMode;
    
    // StructProperty /Script/ControlRig.RigUnit_AimConstraint:AimVector
    static readonly int AimVector_Offset;
    public System.DoubleNumerics.Vector3 AimVector;
    
    // StructProperty /Script/ControlRig.RigUnit_AimConstraint:UpVector
    static readonly int UpVector_Offset;
    public System.DoubleNumerics.Vector3 UpVector;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_AimConstraint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_AimConstraint");
        
        Joint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Joint");
        AimMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AimMode");
        UpMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpMode");
        AimVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AimVector");
        UpVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UpVector");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_AimConstraint(IntPtr InNativeStruct)
    {
        unsafe
        {
            Joint = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Joint_Offset), 0, null);
            AimMode = BlittableMarshaller<UnrealSharp.ControlRig.EAimMode>.FromNative(IntPtr.Add(InNativeStruct, AimMode_Offset), 0, null);
            UpMode = BlittableMarshaller<UnrealSharp.ControlRig.EAimMode>.FromNative(IntPtr.Add(InNativeStruct, UpMode_Offset), 0, null);
            AimVector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AimVector_Offset), 0, null);
            UpVector = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, UpVector_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Joint_Offset), 0, null, Joint);
            BlittableMarshaller<UnrealSharp.ControlRig.EAimMode>.ToNative(IntPtr.Add(Buffer, AimMode_Offset), 0, null, AimMode);
            BlittableMarshaller<UnrealSharp.ControlRig.EAimMode>.ToNative(IntPtr.Add(Buffer, UpMode_Offset), 0, null, UpMode);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AimVector_Offset), 0, null, AimVector);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, UpVector_Offset), 0, null, UpVector);
        }
    }
}

public static class RigUnit_AimConstraintMarshaler
{
    public static RigUnit_AimConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_AimConstraint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_AimConstraint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_AimConstraint.NativeDataSize;
    }
}