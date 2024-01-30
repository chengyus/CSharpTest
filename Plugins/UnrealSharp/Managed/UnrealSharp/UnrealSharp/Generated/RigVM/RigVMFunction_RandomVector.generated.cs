using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_RandomVector
{
    // IntProperty /Script/RigVM.RigVMFunction_RandomVector:Seed
    static readonly int Seed_Offset;
    public int Seed;
    
    // FloatProperty /Script/RigVM.RigVMFunction_RandomVector:Minimum
    static readonly int Minimum_Offset;
    public float Minimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_RandomVector:Maximum
    static readonly int Maximum_Offset;
    public float Maximum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_RandomVector:Duration
    static readonly int Duration_Offset;
    public float Duration;
    
    // StructProperty /Script/RigVM.RigVMFunction_RandomVector:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_RandomVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_RandomVector");
        
        Seed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Seed");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        Duration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Duration");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_RandomVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Seed = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Seed_Offset), 0, null);
            Minimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
            Duration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Duration_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Seed_Offset), 0, null, Seed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Duration_Offset), 0, null, Duration);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_RandomVectorMarshaler
{
    public static RigVMFunction_RandomVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_RandomVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_RandomVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_RandomVector.NativeDataSize;
    }
}