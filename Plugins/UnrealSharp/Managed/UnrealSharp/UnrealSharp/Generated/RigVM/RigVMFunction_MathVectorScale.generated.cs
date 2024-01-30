using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorScale
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorScale:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathVectorScale:Factor
    static readonly int Factor_Offset;
    public float Factor;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorScale:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorScale()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorScale");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Factor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Factor");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorScale(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Factor = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Factor_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Factor_Offset), 0, null, Factor);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathVectorScaleMarshaler
{
    public static RigVMFunction_MathVectorScale FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorScale(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorScale obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorScale.NativeDataSize;
    }
}