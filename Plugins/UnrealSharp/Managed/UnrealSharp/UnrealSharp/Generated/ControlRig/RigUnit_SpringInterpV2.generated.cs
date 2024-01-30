using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SpringInterpV2
{
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpV2:Target
    static readonly int Target_Offset;
    public float Target;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpV2:Strength
    static readonly int Strength_Offset;
    public float Strength;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpV2:CriticalDamping
    static readonly int CriticalDamping_Offset;
    public float CriticalDamping;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpV2:Force
    static readonly int Force_Offset;
    public float Force;
    
    // BoolProperty /Script/ControlRig.RigUnit_SpringInterpV2:bUseCurrentInput
    static readonly int bUseCurrentInput_Offset;
    public bool UseCurrentInput;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpV2:Current
    static readonly int Current_Offset;
    public float Current;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpV2:TargetVelocityAmount
    static readonly int TargetVelocityAmount_Offset;
    public float TargetVelocityAmount;
    
    // BoolProperty /Script/ControlRig.RigUnit_SpringInterpV2:bInitializeFromTarget
    static readonly int bInitializeFromTarget_Offset;
    public bool InitializeFromTarget;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpV2:Result
    static readonly int Result_Offset;
    public float Result;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpV2:Velocity
    static readonly int Velocity_Offset;
    public float Velocity;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SpringInterpV2()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SpringInterpV2");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Strength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Strength");
        CriticalDamping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CriticalDamping");
        Force_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Force");
        bUseCurrentInput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseCurrentInput");
        Current_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Current");
        TargetVelocityAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetVelocityAmount");
        bInitializeFromTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInitializeFromTarget");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        Velocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Velocity");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SpringInterpV2(IntPtr InNativeStruct)
    {
        unsafe
        {
            Target = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Strength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Strength_Offset), 0, null);
            CriticalDamping = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CriticalDamping_Offset), 0, null);
            Force = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Force_Offset), 0, null);
            UseCurrentInput = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseCurrentInput_Offset), 0, null);
            Current = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Current_Offset), 0, null);
            TargetVelocityAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetVelocityAmount_Offset), 0, null);
            InitializeFromTarget = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bInitializeFromTarget_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
            Velocity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Velocity_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Strength_Offset), 0, null, Strength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CriticalDamping_Offset), 0, null, CriticalDamping);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Force_Offset), 0, null, Force);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseCurrentInput_Offset), 0, null, UseCurrentInput);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Current_Offset), 0, null, Current);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetVelocityAmount_Offset), 0, null, TargetVelocityAmount);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bInitializeFromTarget_Offset), 0, null, InitializeFromTarget);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Velocity_Offset), 0, null, Velocity);
        }
    }
}

public static class RigUnit_SpringInterpV2Marshaler
{
    public static RigUnit_SpringInterpV2 FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SpringInterpV2(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SpringInterpV2 obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SpringInterpV2.NativeDataSize;
    }
}