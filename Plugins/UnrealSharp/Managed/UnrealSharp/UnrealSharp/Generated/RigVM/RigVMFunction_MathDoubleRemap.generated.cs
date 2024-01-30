using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathDoubleRemap
{
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleRemap:Value
    static readonly int Value_Offset;
    public double Value;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleRemap:SourceMinimum
    static readonly int SourceMinimum_Offset;
    public double SourceMinimum;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleRemap:SourceMaximum
    static readonly int SourceMaximum_Offset;
    public double SourceMaximum;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleRemap:TargetMinimum
    static readonly int TargetMinimum_Offset;
    public double TargetMinimum;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleRemap:TargetMaximum
    static readonly int TargetMaximum_Offset;
    public double TargetMaximum;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathDoubleRemap:bClamp
    static readonly int bClamp_Offset;
    public bool Clamp;
    
    // DoubleProperty /Script/RigVM.RigVMFunction_MathDoubleRemap:Result
    static readonly int Result_Offset;
    public double Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathDoubleRemap()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathDoubleRemap");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        SourceMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceMinimum");
        SourceMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceMaximum");
        TargetMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetMinimum");
        TargetMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetMaximum");
        bClamp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bClamp");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathDoubleRemap(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            SourceMinimum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, SourceMinimum_Offset), 0, null);
            SourceMaximum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, SourceMaximum_Offset), 0, null);
            TargetMinimum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, TargetMinimum_Offset), 0, null);
            TargetMaximum = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, TargetMaximum_Offset), 0, null);
            Clamp = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bClamp_Offset), 0, null);
            Result = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, SourceMinimum_Offset), 0, null, SourceMinimum);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, SourceMaximum_Offset), 0, null, SourceMaximum);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, TargetMinimum_Offset), 0, null, TargetMinimum);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, TargetMaximum_Offset), 0, null, TargetMaximum);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bClamp_Offset), 0, null, Clamp);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathDoubleRemapMarshaler
{
    public static RigVMFunction_MathDoubleRemap FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathDoubleRemap(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathDoubleRemap obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathDoubleRemap.NativeDataSize;
    }
}