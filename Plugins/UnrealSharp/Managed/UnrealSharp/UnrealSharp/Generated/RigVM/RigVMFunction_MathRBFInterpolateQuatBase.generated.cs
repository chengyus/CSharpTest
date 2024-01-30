using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathRBFInterpolateQuatBase
{
    // StructProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatBase:Input
    static readonly int Input_Offset;
    public System.DoubleNumerics.Quaternion Input;
    
    // EnumProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatBase:DistanceFunction
    static readonly int DistanceFunction_Offset;
    public UnrealSharp.RigVM.ERBFQuatDistanceType DistanceFunction;
    
    // EnumProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatBase:SmoothingFunction
    static readonly int SmoothingFunction_Offset;
    public UnrealSharp.RigVM.ERBFKernelType SmoothingFunction;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatBase:SmoothingAngle
    static readonly int SmoothingAngle_Offset;
    public float SmoothingAngle;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatBase:bNormalizeOutput
    static readonly int bNormalizeOutput_Offset;
    public bool NormalizeOutput;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateQuatBase:TwistAxis
    static readonly int TwistAxis_Offset;
    public System.DoubleNumerics.Vector3 TwistAxis;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathRBFInterpolateQuatBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathRBFInterpolateQuatBase");
        
        Input_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Input");
        DistanceFunction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceFunction");
        SmoothingFunction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SmoothingFunction");
        SmoothingAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SmoothingAngle");
        bNormalizeOutput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNormalizeOutput");
        TwistAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistAxis");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathRBFInterpolateQuatBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            Input = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Input_Offset), 0, null);
            DistanceFunction = BlittableMarshaller<UnrealSharp.RigVM.ERBFQuatDistanceType>.FromNative(IntPtr.Add(InNativeStruct, DistanceFunction_Offset), 0, null);
            SmoothingFunction = BlittableMarshaller<UnrealSharp.RigVM.ERBFKernelType>.FromNative(IntPtr.Add(InNativeStruct, SmoothingFunction_Offset), 0, null);
            SmoothingAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SmoothingAngle_Offset), 0, null);
            NormalizeOutput = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bNormalizeOutput_Offset), 0, null);
            TwistAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TwistAxis_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Input_Offset), 0, null, Input);
            BlittableMarshaller<UnrealSharp.RigVM.ERBFQuatDistanceType>.ToNative(IntPtr.Add(Buffer, DistanceFunction_Offset), 0, null, DistanceFunction);
            BlittableMarshaller<UnrealSharp.RigVM.ERBFKernelType>.ToNative(IntPtr.Add(Buffer, SmoothingFunction_Offset), 0, null, SmoothingFunction);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SmoothingAngle_Offset), 0, null, SmoothingAngle);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bNormalizeOutput_Offset), 0, null, NormalizeOutput);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TwistAxis_Offset), 0, null, TwistAxis);
        }
    }
}

public static class RigVMFunction_MathRBFInterpolateQuatBaseMarshaler
{
    public static RigVMFunction_MathRBFInterpolateQuatBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathRBFInterpolateQuatBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathRBFInterpolateQuatBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathRBFInterpolateQuatBase.NativeDataSize;
    }
}