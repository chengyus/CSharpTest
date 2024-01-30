using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorRemap
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorRemap:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorRemap:SourceMinimum
    static readonly int SourceMinimum_Offset;
    public System.DoubleNumerics.Vector3 SourceMinimum;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorRemap:SourceMaximum
    static readonly int SourceMaximum_Offset;
    public System.DoubleNumerics.Vector3 SourceMaximum;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorRemap:TargetMinimum
    static readonly int TargetMinimum_Offset;
    public System.DoubleNumerics.Vector3 TargetMinimum;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorRemap:TargetMaximum
    static readonly int TargetMaximum_Offset;
    public System.DoubleNumerics.Vector3 TargetMaximum;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathVectorRemap:bClamp
    static readonly int bClamp_Offset;
    public bool Clamp;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorRemap:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorRemap()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorRemap");
        
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
    public RigVMFunction_MathVectorRemap(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            SourceMinimum = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SourceMinimum_Offset), 0, null);
            SourceMaximum = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SourceMaximum_Offset), 0, null);
            TargetMinimum = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TargetMinimum_Offset), 0, null);
            TargetMaximum = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, TargetMaximum_Offset), 0, null);
            Clamp = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bClamp_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SourceMinimum_Offset), 0, null, SourceMinimum);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SourceMaximum_Offset), 0, null, SourceMaximum);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TargetMinimum_Offset), 0, null, TargetMinimum);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, TargetMaximum_Offset), 0, null, TargetMaximum);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bClamp_Offset), 0, null, Clamp);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathVectorRemapMarshaler
{
    public static RigVMFunction_MathVectorRemap FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorRemap(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorRemap obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorRemap.NativeDataSize;
    }
}