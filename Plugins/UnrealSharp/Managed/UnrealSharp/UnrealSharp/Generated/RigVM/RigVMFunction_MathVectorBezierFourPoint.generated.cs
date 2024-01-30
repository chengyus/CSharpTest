using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorBezierFourPoint
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorBezierFourPoint:Bezier
    static readonly int Bezier_Offset;
    public UnrealSharp.RigVM.RigVMFourPointBezier Bezier;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathVectorBezierFourPoint:T
    static readonly int T_Offset;
    public float T;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorBezierFourPoint:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorBezierFourPoint:Tangent
    static readonly int Tangent_Offset;
    public System.DoubleNumerics.Vector3 Tangent;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorBezierFourPoint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorBezierFourPoint");
        
        Bezier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bezier");
        T_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "T");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        Tangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tangent");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorBezierFourPoint(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bezier = UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.FromNative(IntPtr.Add(InNativeStruct, Bezier_Offset), 0, null);
            T = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, T_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
            Tangent = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Tangent_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.ToNative(IntPtr.Add(Buffer, Bezier_Offset), 0, null, Bezier);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, T_Offset), 0, null, T);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Tangent_Offset), 0, null, Tangent);
        }
    }
}

public static class RigVMFunction_MathVectorBezierFourPointMarshaler
{
    public static RigVMFunction_MathVectorBezierFourPoint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorBezierFourPoint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorBezierFourPoint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorBezierFourPoint.NativeDataSize;
    }
}