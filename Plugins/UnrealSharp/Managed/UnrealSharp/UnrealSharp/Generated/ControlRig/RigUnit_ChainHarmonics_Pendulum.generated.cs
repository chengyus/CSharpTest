using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ChainHarmonics_Pendulum
{
    // BoolProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:PendulumStiffness
    static readonly int PendulumStiffness_Offset;
    public float PendulumStiffness;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:PendulumGravity
    static readonly int PendulumGravity_Offset;
    public System.DoubleNumerics.Vector3 PendulumGravity;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:PendulumBlend
    static readonly int PendulumBlend_Offset;
    public float PendulumBlend;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:PendulumDrag
    static readonly int PendulumDrag_Offset;
    public float PendulumDrag;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:PendulumMinimum
    static readonly int PendulumMinimum_Offset;
    public float PendulumMinimum;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:PendulumMaximum
    static readonly int PendulumMaximum_Offset;
    public float PendulumMaximum;
    
    // EnumProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:PendulumEase
    static readonly int PendulumEase_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType PendulumEase;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:UnwindAxis
    static readonly int UnwindAxis_Offset;
    public System.DoubleNumerics.Vector3 UnwindAxis;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:UnwindMinimum
    static readonly int UnwindMinimum_Offset;
    public float UnwindMinimum;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Pendulum:UnwindMaximum
    static readonly int UnwindMaximum_Offset;
    public float UnwindMaximum;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ChainHarmonics_Pendulum()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ChainHarmonics_Pendulum");
        
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        PendulumStiffness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PendulumStiffness");
        PendulumGravity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PendulumGravity");
        PendulumBlend_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PendulumBlend");
        PendulumDrag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PendulumDrag");
        PendulumMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PendulumMinimum");
        PendulumMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PendulumMaximum");
        PendulumEase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PendulumEase");
        UnwindAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UnwindAxis");
        UnwindMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UnwindMinimum");
        UnwindMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UnwindMaximum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ChainHarmonics_Pendulum(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            PendulumStiffness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PendulumStiffness_Offset), 0, null);
            PendulumGravity = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PendulumGravity_Offset), 0, null);
            PendulumBlend = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PendulumBlend_Offset), 0, null);
            PendulumDrag = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PendulumDrag_Offset), 0, null);
            PendulumMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PendulumMinimum_Offset), 0, null);
            PendulumMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PendulumMaximum_Offset), 0, null);
            PendulumEase = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, PendulumEase_Offset), 0, null);
            UnwindAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, UnwindAxis_Offset), 0, null);
            UnwindMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, UnwindMinimum_Offset), 0, null);
            UnwindMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, UnwindMaximum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PendulumStiffness_Offset), 0, null, PendulumStiffness);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PendulumGravity_Offset), 0, null, PendulumGravity);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PendulumBlend_Offset), 0, null, PendulumBlend);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PendulumDrag_Offset), 0, null, PendulumDrag);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PendulumMinimum_Offset), 0, null, PendulumMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PendulumMaximum_Offset), 0, null, PendulumMaximum);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, PendulumEase_Offset), 0, null, PendulumEase);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, UnwindAxis_Offset), 0, null, UnwindAxis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, UnwindMinimum_Offset), 0, null, UnwindMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, UnwindMaximum_Offset), 0, null, UnwindMaximum);
        }
    }
}

public static class RigUnit_ChainHarmonics_PendulumMarshaler
{
    public static RigUnit_ChainHarmonics_Pendulum FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ChainHarmonics_Pendulum(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ChainHarmonics_Pendulum obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ChainHarmonics_Pendulum.NativeDataSize;
    }
}