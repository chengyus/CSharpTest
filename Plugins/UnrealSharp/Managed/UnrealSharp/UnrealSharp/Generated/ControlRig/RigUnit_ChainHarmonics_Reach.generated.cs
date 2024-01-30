using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ChainHarmonics_Reach
{
    // BoolProperty /Script/ControlRig.RigUnit_ChainHarmonics_Reach:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics_Reach:ReachTarget
    static readonly int ReachTarget_Offset;
    public System.DoubleNumerics.Vector3 ReachTarget;
    
    // StructProperty /Script/ControlRig.RigUnit_ChainHarmonics_Reach:ReachAxis
    static readonly int ReachAxis_Offset;
    public System.DoubleNumerics.Vector3 ReachAxis;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Reach:ReachMinimum
    static readonly int ReachMinimum_Offset;
    public float ReachMinimum;
    
    // FloatProperty /Script/ControlRig.RigUnit_ChainHarmonics_Reach:ReachMaximum
    static readonly int ReachMaximum_Offset;
    public float ReachMaximum;
    
    // EnumProperty /Script/ControlRig.RigUnit_ChainHarmonics_Reach:ReachEase
    static readonly int ReachEase_Offset;
    public UnrealSharp.RigVM.ERigVMAnimEasingType ReachEase;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ChainHarmonics_Reach()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ChainHarmonics_Reach");
        
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        ReachTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReachTarget");
        ReachAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReachAxis");
        ReachMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReachMinimum");
        ReachMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReachMaximum");
        ReachEase_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ReachEase");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ChainHarmonics_Reach(IntPtr InNativeStruct)
    {
        unsafe
        {
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
            ReachTarget = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, ReachTarget_Offset), 0, null);
            ReachAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, ReachAxis_Offset), 0, null);
            ReachMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReachMinimum_Offset), 0, null);
            ReachMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ReachMaximum_Offset), 0, null);
            ReachEase = BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.FromNative(IntPtr.Add(InNativeStruct, ReachEase_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, ReachTarget_Offset), 0, null, ReachTarget);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, ReachAxis_Offset), 0, null, ReachAxis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReachMinimum_Offset), 0, null, ReachMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ReachMaximum_Offset), 0, null, ReachMaximum);
            BlittableMarshaller<UnrealSharp.RigVM.ERigVMAnimEasingType>.ToNative(IntPtr.Add(Buffer, ReachEase_Offset), 0, null, ReachEase);
        }
    }
}

public static class RigUnit_ChainHarmonics_ReachMarshaler
{
    public static RigUnit_ChainHarmonics_Reach FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ChainHarmonics_Reach(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ChainHarmonics_Reach obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ChainHarmonics_Reach.NativeDataSize;
    }
}