using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathFloatRemap
{
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatRemap:Value
    static readonly int Value_Offset;
    public float Value;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatRemap:SourceMinimum
    static readonly int SourceMinimum_Offset;
    public float SourceMinimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatRemap:SourceMaximum
    static readonly int SourceMaximum_Offset;
    public float SourceMaximum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatRemap:TargetMinimum
    static readonly int TargetMinimum_Offset;
    public float TargetMinimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatRemap:TargetMaximum
    static readonly int TargetMaximum_Offset;
    public float TargetMaximum;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathFloatRemap:bClamp
    static readonly int bClamp_Offset;
    public bool Clamp;
    
    // FloatProperty /Script/RigVM.RigVMFunction_MathFloatRemap:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathFloatRemap()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathFloatRemap");
        
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
    public RigVMFunction_MathFloatRemap(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            SourceMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SourceMinimum_Offset), 0, null);
            SourceMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SourceMaximum_Offset), 0, null);
            TargetMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetMinimum_Offset), 0, null);
            TargetMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetMaximum_Offset), 0, null);
            Clamp = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bClamp_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SourceMinimum_Offset), 0, null, SourceMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SourceMaximum_Offset), 0, null, SourceMaximum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetMinimum_Offset), 0, null, TargetMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetMaximum_Offset), 0, null, TargetMaximum);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bClamp_Offset), 0, null, Clamp);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathFloatRemapMarshaler
{
    public static RigVMFunction_MathFloatRemap FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathFloatRemap(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathFloatRemap obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathFloatRemap.NativeDataSize;
    }
}