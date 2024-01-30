using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_RandomFloat
{
    // IntProperty /Script/RigVM.RigVMFunction_RandomFloat:Seed
    static readonly int Seed_Offset;
    public int Seed;
    
    // FloatProperty /Script/RigVM.RigVMFunction_RandomFloat:Minimum
    static readonly int Minimum_Offset;
    public float Minimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_RandomFloat:Maximum
    static readonly int Maximum_Offset;
    public float Maximum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_RandomFloat:Duration
    static readonly int Duration_Offset;
    public float Duration;
    
    // FloatProperty /Script/RigVM.RigVMFunction_RandomFloat:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_RandomFloat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_RandomFloat");
        
        Seed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Seed");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        Duration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Duration");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_RandomFloat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Seed = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Seed_Offset), 0, null);
            Minimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
            Duration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Duration_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
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
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_RandomFloatMarshaler
{
    public static RigVMFunction_RandomFloat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_RandomFloat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_RandomFloat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_RandomFloat.NativeDataSize;
    }
}