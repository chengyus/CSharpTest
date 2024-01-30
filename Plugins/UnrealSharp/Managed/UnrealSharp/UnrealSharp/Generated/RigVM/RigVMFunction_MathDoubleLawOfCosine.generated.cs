using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleLawOfCosine
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleLawOfCosine:A
    static readonly int A_Offset;
    public double A;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleLawOfCosine:B
    static readonly int B_Offset;
    public double B;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleLawOfCosine:C
    static readonly int C_Offset;
    public double C;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleLawOfCosine:AlphaAngle
    static readonly int AlphaAngle_Offset;
    public double AlphaAngle;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleLawOfCosine:BetaAngle
    static readonly int BetaAngle_Offset;
    public double BetaAngle;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleLawOfCosine:GammaAngle
    static readonly int GammaAngle_Offset;
    public double GammaAngle;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathDoubleLawOfCosine:bValid
    static readonly int bValid_Offset;
    public bool Valid;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleLawOfCosine()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleLawOfCosine");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        C_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "C");
        AlphaAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AlphaAngle");
        BetaAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BetaAngle");
        GammaAngle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GammaAngle");
        bValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bValid");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleLawOfCosine(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            C = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, C_Offset), 0, null);
            AlphaAngle = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, AlphaAngle_Offset), 0, null);
            BetaAngle = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, BetaAngle_Offset), 0, null);
            GammaAngle = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, GammaAngle_Offset), 0, null);
            Valid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bValid_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, C_Offset), 0, null, C);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, AlphaAngle_Offset), 0, null, AlphaAngle);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, BetaAngle_Offset), 0, null, BetaAngle);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, GammaAngle_Offset), 0, null, GammaAngle);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bValid_Offset), 0, null, Valid);
        }
    }
}

public static class RigVMFunction_MathDoubleLawOfCosineMarshaler
{
    public static RigVMFunction_MathDoubleLawOfCosine FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleLawOfCosine(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleLawOfCosine obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleLawOfCosine.NativeDataSize;
    }
}