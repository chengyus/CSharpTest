using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SpringInterpVector
{
    // StructProperty /Script/ControlRig.RigUnit_SpringInterpVector:Current
    static readonly int Current_Offset;
    public System.DoubleNumerics.Vector3 Current;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringInterpVector:Target
    static readonly int Target_Offset;
    public System.DoubleNumerics.Vector3 Target;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpVector:Stiffness
    static readonly int Stiffness_Offset;
    public float Stiffness;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpVector:CriticalDamping
    static readonly int CriticalDamping_Offset;
    public float CriticalDamping;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterpVector:Mass
    static readonly int Mass_Offset;
    public float Mass;
    
    // StructProperty /Script/ControlRig.RigUnit_SpringInterpVector:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SpringInterpVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SpringInterpVector");
        
        Current_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Current");
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Stiffness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Stiffness");
        CriticalDamping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CriticalDamping");
        Mass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mass");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SpringInterpVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Current = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Current_Offset), 0, null);
            Target = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Stiffness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Stiffness_Offset), 0, null);
            CriticalDamping = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CriticalDamping_Offset), 0, null);
            Mass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Mass_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Current_Offset), 0, null, Current);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Stiffness_Offset), 0, null, Stiffness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CriticalDamping_Offset), 0, null, CriticalDamping);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Mass_Offset), 0, null, Mass);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_SpringInterpVectorMarshaler
{
    public static RigUnit_SpringInterpVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SpringInterpVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SpringInterpVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SpringInterpVector.NativeDataSize;
    }
}