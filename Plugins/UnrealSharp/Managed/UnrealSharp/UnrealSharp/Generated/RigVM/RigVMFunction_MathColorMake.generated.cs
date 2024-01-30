using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathColorMake
{
    // FloatProperty /Script/RigVM.RigVMFunction_MathColorMake:R
    static readonly int R_Offset;
    public float R;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathColorMake:G
    static readonly int G_Offset;
    public float G;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathColorMake:B
    static readonly int B_Offset;
    public float B;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathColorMake:A
    static readonly int A_Offset;
    public float A;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathColorMake:Result
    static readonly int Result_Offset;
    public UnrealSharp.CoreUObject.LinearColor Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathColorMake()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathColorMake");
        
        R_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "R");
        G_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "G");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathColorMake(IntPtr InNativeStruct)
    {
        unsafe
        {
            R = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, R_Offset), 0, null);
            G = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, G_Offset), 0, null);
            B = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            A = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, R_Offset), 0, null, R);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, G_Offset), 0, null, G);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathColorMakeMarshaler
{
    public static RigVMFunction_MathColorMake FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathColorMake(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathColorMake obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathColorMake.NativeDataSize;
    }
}