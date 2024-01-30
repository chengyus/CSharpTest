using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathFloatLawOfCosine
{
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatLawOfCosine:A
    static readonly int A_Offset;
    public float A;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatLawOfCosine:B
    static readonly int B_Offset;
    public float B;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatLawOfCosine:C
    static readonly int C_Offset;
    public float C;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatLawOfCosine:AlphaAngle
    static readonly int AlphaAngle_Offset;
    public float AlphaAngle;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatLawOfCosine:BetaAngle
    static readonly int BetaAngle_Offset;
    public float BetaAngle;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatLawOfCosine:GammaAngle
    static readonly int GammaAngle_Offset;
    public float GammaAngle;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathFloatLawOfCosine:bValid
    static readonly int bValid_Offset;
    public bool Valid;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathFloatLawOfCosine()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathFloatLawOfCosine");
        
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
    public RigVMFunction_MathFloatLawOfCosine(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            C = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, C_Offset), 0, null);
            AlphaAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AlphaAngle_Offset), 0, null);
            BetaAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BetaAngle_Offset), 0, null);
            GammaAngle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, GammaAngle_Offset), 0, null);
            Valid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bValid_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, C_Offset), 0, null, C);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AlphaAngle_Offset), 0, null, AlphaAngle);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BetaAngle_Offset), 0, null, BetaAngle);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, GammaAngle_Offset), 0, null, GammaAngle);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bValid_Offset), 0, null, Valid);
        }
    }
}

public static class RigVMFunction_MathFloatLawOfCosineMarshaler
{
    public static RigVMFunction_MathFloatLawOfCosine FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathFloatLawOfCosine(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathFloatLawOfCosine obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathFloatLawOfCosine.NativeDataSize;
    }
}