using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_TimeLoop
{
    // FloatProperty /Script/RigVM.RigVMFunction_TimeLoop:Speed
    static readonly int Speed_Offset;
    public float Speed;
    
    // FloatProperty /Script/RigVM.RigVMFunction_TimeLoop:Duration
    static readonly int Duration_Offset;
    public float Duration;
    
    // BoolProperty /Script/RigVM.RigVMFunction_TimeLoop:Normalize
    static readonly int Normalize_Offset;
    public bool Normalize;
    
    // FloatProperty /Script/RigVM.RigVMFunction_TimeLoop:Absolute
    static readonly int Absolute_Offset;
    public float Absolute;
    
    // FloatProperty /Script/RigVM.RigVMFunction_TimeLoop:Relative
    static readonly int Relative_Offset;
    public float Relative;
    
    // FloatProperty /Script/RigVM.RigVMFunction_TimeLoop:FlipFlop
    static readonly int FlipFlop_Offset;
    public float FlipFlop;
    
    // BoolProperty /Script/RigVM.RigVMFunction_TimeLoop:Even
    static readonly int Even_Offset;
    public bool Even;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_TimeLoop()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_TimeLoop");
        
        Speed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Speed");
        Duration_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Duration");
        Normalize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Normalize");
        Absolute_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Absolute");
        Relative_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Relative");
        FlipFlop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FlipFlop");
        Even_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Even");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_TimeLoop(IntPtr InNativeStruct)
    {
        unsafe
        {
            Speed = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Speed_Offset), 0, null);
            Duration = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Duration_Offset), 0, null);
            Normalize = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Normalize_Offset), 0, null);
            Absolute = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Absolute_Offset), 0, null);
            Relative = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Relative_Offset), 0, null);
            FlipFlop = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, FlipFlop_Offset), 0, null);
            Even = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Even_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Speed_Offset), 0, null, Speed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Duration_Offset), 0, null, Duration);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Normalize_Offset), 0, null, Normalize);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Absolute_Offset), 0, null, Absolute);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Relative_Offset), 0, null, Relative);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, FlipFlop_Offset), 0, null, FlipFlop);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Even_Offset), 0, null, Even);
        }
    }
}

public static class RigVMFunction_TimeLoopMarshaler
{
    public static RigVMFunction_TimeLoop FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_TimeLoop(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_TimeLoop obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_TimeLoop.NativeDataSize;
    }
}