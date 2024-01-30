using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathBoolFlipFlop
{
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolFlipFlop:StartValue
    static readonly int StartValue_Offset;
    public bool StartValue;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathBoolFlipFlop:Duration
    static readonly int Duration_Offset;
    public float Duration;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolFlipFlop:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathBoolFlipFlop()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathBoolFlipFlop");
        
        StartValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartValue");
        Duration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Duration");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathBoolFlipFlop(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartValue = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, StartValue_Offset), 0, null);
            Duration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Duration_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, StartValue_Offset), 0, null, StartValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Duration_Offset), 0, null, Duration);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathBoolFlipFlopMarshaler
{
    public static RigVMFunction_MathBoolFlipFlop FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathBoolFlipFlop(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathBoolFlipFlop obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathBoolFlipFlop.NativeDataSize;
    }
}