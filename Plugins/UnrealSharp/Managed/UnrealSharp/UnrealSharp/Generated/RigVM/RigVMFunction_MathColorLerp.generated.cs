using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathColorLerp
{
    // StructProperty /Script/RigVM.RigVMFunction_MathColorLerp:A
    static readonly int A_Offset;
    public UnrealSharp.CoreUObject.LinearColor A;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathColorLerp:B
    static readonly int B_Offset;
    public UnrealSharp.CoreUObject.LinearColor B;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathColorLerp:T
    static readonly int T_Offset;
    public float T;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathColorLerp:Result
    static readonly int Result_Offset;
    public UnrealSharp.CoreUObject.LinearColor Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathColorLerp()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathColorLerp");
        
        A_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "A");
        B_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "B");
        T_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "T");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathColorLerp(IntPtr InNativeStruct)
    {
        unsafe
        {
            A = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, A_Offset), 0, null);
            B = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, B_Offset), 0, null);
            T = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, T_Offset), 0, null);
            Result = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, A_Offset), 0, null, A);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, B_Offset), 0, null, B);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, T_Offset), 0, null, T);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathColorLerpMarshaler
{
    public static RigVMFunction_MathColorLerp FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathColorLerp(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathColorLerp obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathColorLerp.NativeDataSize;
    }
}