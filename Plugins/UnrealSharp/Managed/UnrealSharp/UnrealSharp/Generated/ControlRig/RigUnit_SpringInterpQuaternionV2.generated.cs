using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SpringInterpQuaternionV2
{
    // StructProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:Target
    static readonly int Target_Offset;
    public System.DoubleNumerics.Quaternion Target;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:Strength
    static readonly int Strength_Offset;
    public float Strength;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:CriticalDamping
    static readonly int CriticalDamping_Offset;
    public float CriticalDamping;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:Torque
    static readonly int Torque_Offset;
    public System.DoubleNumerics.Vector3 Torque;
    
    // BoolProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:bUseCurrentInput
    static readonly int bUseCurrentInput_Offset;
    public bool UseCurrentInput;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:Current
    static readonly int Current_Offset;
    public System.DoubleNumerics.Quaternion Current;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:TargetVelocityAmount
    static readonly int TargetVelocityAmount_Offset;
    public float TargetVelocityAmount;
    
    // BoolProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:bInitializeFromTarget
    static readonly int bInitializeFromTarget_Offset;
    public bool InitializeFromTarget;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringInterpQuaternionV2:AngularVelocity
    static readonly int AngularVelocity_Offset;
    public System.DoubleNumerics.Vector3 AngularVelocity;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SpringInterpQuaternionV2()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SpringInterpQuaternionV2");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Strength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Strength");
        CriticalDamping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CriticalDamping");
        Torque_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Torque");
        bUseCurrentInput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseCurrentInput");
        Current_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Current");
        TargetVelocityAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetVelocityAmount");
        bInitializeFromTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInitializeFromTarget");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        AngularVelocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AngularVelocity");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SpringInterpQuaternionV2(IntPtr InNativeStruct)
    {
        unsafe
        {
            Target = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Strength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Strength_Offset), 0, null);
            CriticalDamping = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CriticalDamping_Offset), 0, null);
            Torque = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Torque_Offset), 0, null);
            UseCurrentInput = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseCurrentInput_Offset), 0, null);
            Current = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Current_Offset), 0, null);
            TargetVelocityAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetVelocityAmount_Offset), 0, null);
            InitializeFromTarget = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bInitializeFromTarget_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
            AngularVelocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, AngularVelocity_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Strength_Offset), 0, null, Strength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CriticalDamping_Offset), 0, null, CriticalDamping);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Torque_Offset), 0, null, Torque);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseCurrentInput_Offset), 0, null, UseCurrentInput);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Current_Offset), 0, null, Current);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetVelocityAmount_Offset), 0, null, TargetVelocityAmount);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bInitializeFromTarget_Offset), 0, null, InitializeFromTarget);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, AngularVelocity_Offset), 0, null, AngularVelocity);
        }
    }
}

public static class RigUnit_SpringInterpQuaternionV2Marshaler
{
    public static RigUnit_SpringInterpQuaternionV2 FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SpringInterpQuaternionV2(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SpringInterpQuaternionV2 obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SpringInterpQuaternionV2.NativeDataSize;
    }
}