using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_TwoBoneIKFK
{
    // NameProperty /Script/ControlRig.RigUnit_TwoBoneIKFK:StartJoint
    static readonly int StartJoint_Offset;
    public Name StartJoint;
    
    // NameProperty /Script/ControlRig.RigUnit_TwoBoneIKFK:EndJoint
    static readonly int EndJoint_Offset;
    public Name EndJoint;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKFK:PoleTarget
    static readonly int PoleTarget_Offset;
    public System.DoubleNumerics.Vector3 PoleTarget;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKFK:Spin
    static readonly int Spin_Offset;
    public float Spin;
    
    // StructProperty /Script/ControlRig.RigUnit_TwoBoneIKFK:EndEffector
    static readonly int EndEffector_Offset;
    public UnrealSharp.Transform EndEffector;
    
    // FloatProperty /Script/ControlRig.RigUnit_TwoBoneIKFK:IKBlend
    static readonly int IKBlend_Offset;
    public float IKBlend;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_TwoBoneIKFK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_TwoBoneIKFK");
        
        StartJoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartJoint");
        EndJoint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndJoint");
        PoleTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoleTarget");
        Spin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spin");
        EndEffector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndEffector");
        IKBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IKBlend");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_TwoBoneIKFK(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartJoint = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StartJoint_Offset), 0, null);
            EndJoint = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EndJoint_Offset), 0, null);
            PoleTarget = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PoleTarget_Offset), 0, null);
            Spin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Spin_Offset), 0, null);
            EndEffector = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, EndEffector_Offset), 0, null);
            IKBlend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, IKBlend_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StartJoint_Offset), 0, null, StartJoint);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EndJoint_Offset), 0, null, EndJoint);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PoleTarget_Offset), 0, null, PoleTarget);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Spin_Offset), 0, null, Spin);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, EndEffector_Offset), 0, null, EndEffector);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, IKBlend_Offset), 0, null, IKBlend);
        }
    }
}

public static class RigUnit_TwoBoneIKFKMarshaler
{
    public static RigUnit_TwoBoneIKFK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_TwoBoneIKFK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_TwoBoneIKFK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_TwoBoneIKFK.NativeDataSize;
    }
}