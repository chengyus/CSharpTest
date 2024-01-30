using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathRBFInterpolateVectorBase
{
    // StructProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateVectorBase:Input
    static readonly int Input_Offset;
    public System.DoubleNumerics.Vector3 Input;
    
    // EnumProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateVectorBase:DistanceFunction
    static readonly int DistanceFunction_Offset;
    public UnrealSharp.RigVM.ERBFVectorDistanceType DistanceFunction;
    
    // EnumProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateVectorBase:SmoothingFunction
    static readonly int SmoothingFunction_Offset;
    public UnrealSharp.RigVM.ERBFKernelType SmoothingFunction;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateVectorBase:SmoothingRadius
    static readonly int SmoothingRadius_Offset;
    public float SmoothingRadius;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathRBFInterpolateVectorBase:bNormalizeOutput
    static readonly int bNormalizeOutput_Offset;
    public bool NormalizeOutput;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathRBFInterpolateVectorBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathRBFInterpolateVectorBase");
        
        Input_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Input");
        DistanceFunction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceFunction");
        SmoothingFunction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SmoothingFunction");
        SmoothingRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SmoothingRadius");
        bNormalizeOutput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNormalizeOutput");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathRBFInterpolateVectorBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            Input = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Input_Offset), 0, null);
            DistanceFunction = BlittableMarshaller<UnrealSharp.RigVM.ERBFVectorDistanceType>.FromNative(IntPtr.Add(InNativeStruct, DistanceFunction_Offset), 0, null);
            SmoothingFunction = BlittableMarshaller<UnrealSharp.RigVM.ERBFKernelType>.FromNative(IntPtr.Add(InNativeStruct, SmoothingFunction_Offset), 0, null);
            SmoothingRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SmoothingRadius_Offset), 0, null);
            NormalizeOutput = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bNormalizeOutput_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Input_Offset), 0, null, Input);
            BlittableMarshaller<UnrealSharp.RigVM.ERBFVectorDistanceType>.ToNative(IntPtr.Add(Buffer, DistanceFunction_Offset), 0, null, DistanceFunction);
            BlittableMarshaller<UnrealSharp.RigVM.ERBFKernelType>.ToNative(IntPtr.Add(Buffer, SmoothingFunction_Offset), 0, null, SmoothingFunction);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SmoothingRadius_Offset), 0, null, SmoothingRadius);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bNormalizeOutput_Offset), 0, null, NormalizeOutput);
        }
    }
}

public static class RigVMFunction_MathRBFInterpolateVectorBaseMarshaler
{
    public static RigVMFunction_MathRBFInterpolateVectorBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathRBFInterpolateVectorBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathRBFInterpolateVectorBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathRBFInterpolateVectorBase.NativeDataSize;
    }
}