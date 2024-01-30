using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_VerletIntegrateVector
{
    // StructProperty /Script/RigVM.RigVMFunction_VerletIntegrateVector:Target
    static readonly int Target_Offset;
    public System.DoubleNumerics.Vector3 Target;
    
    // FloatProperty /Script/RigVM.RigVMFunction_VerletIntegrateVector:Strength
    static readonly int Strength_Offset;
    public float Strength;
    
    // FloatProperty /Script/RigVM.RigVMFunction_VerletIntegrateVector:Damp
    static readonly int Damp_Offset;
    public float Damp;
    
    // FloatProperty /Script/RigVM.RigVMFunction_VerletIntegrateVector:Blend
    static readonly int Blend_Offset;
    public float Blend;
    
    // StructProperty /Script/RigVM.RigVMFunction_VerletIntegrateVector:Force
    static readonly int Force_Offset;
    public System.DoubleNumerics.Vector3 Force;
    
    // StructProperty /Script/RigVM.RigVMFunction_VerletIntegrateVector:Position
    static readonly int Position_Offset;
    public System.DoubleNumerics.Vector3 Position;
    
    // StructProperty /Script/RigVM.RigVMFunction_VerletIntegrateVector:Velocity
    static readonly int Velocity_Offset;
    public System.DoubleNumerics.Vector3 Velocity;
    
    // StructProperty /Script/RigVM.RigVMFunction_VerletIntegrateVector:Acceleration
    static readonly int Acceleration_Offset;
    public System.DoubleNumerics.Vector3 Acceleration;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_VerletIntegrateVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_VerletIntegrateVector");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Strength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Strength");
        Damp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Damp");
        Blend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Blend");
        Force_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Force");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        Velocity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Velocity");
        Acceleration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Acceleration");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_VerletIntegrateVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Target = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Strength = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Strength_Offset), 0, null);
            Damp = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Damp_Offset), 0, null);
            Blend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Blend_Offset), 0, null);
            Force = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Force_Offset), 0, null);
            Position = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
            Velocity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Velocity_Offset), 0, null);
            Acceleration = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Acceleration_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Strength_Offset), 0, null, Strength);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Damp_Offset), 0, null, Damp);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Blend_Offset), 0, null, Blend);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Force_Offset), 0, null, Force);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Velocity_Offset), 0, null, Velocity);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Acceleration_Offset), 0, null, Acceleration);
        }
    }
}

public static class RigVMFunction_VerletIntegrateVectorMarshaler
{
    public static RigVMFunction_VerletIntegrateVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_VerletIntegrateVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_VerletIntegrateVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_VerletIntegrateVector.NativeDataSize;
    }
}