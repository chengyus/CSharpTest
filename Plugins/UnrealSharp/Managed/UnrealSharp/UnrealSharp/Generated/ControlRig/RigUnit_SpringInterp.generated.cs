using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SpringInterp
{
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterp:Current
    static readonly int Current_Offset;
    public float Current;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterp:Target
    static readonly int Target_Offset;
    public float Target;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterp:Stiffness
    static readonly int Stiffness_Offset;
    public float Stiffness;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterp:CriticalDamping
    static readonly int CriticalDamping_Offset;
    public float CriticalDamping;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterp:Mass
    static readonly int Mass_Offset;
    public float Mass;
    
    // FloatProperty /Script/ControlRig.RigUnit_SpringInterp:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SpringInterp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SpringInterp");
        
        Current_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Current");
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        Stiffness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Stiffness");
        CriticalDamping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CriticalDamping");
        Mass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Mass");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SpringInterp(IntPtr InNativeStruct)
    {
        unsafe
        {
            Current = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Current_Offset), 0, null);
            Target = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            Stiffness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Stiffness_Offset), 0, null);
            CriticalDamping = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, CriticalDamping_Offset), 0, null);
            Mass = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Mass_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Current_Offset), 0, null, Current);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Stiffness_Offset), 0, null, Stiffness);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, CriticalDamping_Offset), 0, null, CriticalDamping);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Mass_Offset), 0, null, Mass);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_SpringInterpMarshaler
{
    public static RigUnit_SpringInterp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SpringInterp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SpringInterp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SpringInterp.NativeDataSize;
    }
}