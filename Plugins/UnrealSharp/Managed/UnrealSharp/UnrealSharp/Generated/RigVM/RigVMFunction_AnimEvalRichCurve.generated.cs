using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AnimEvalRichCurve
{
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEvalRichCurve:Value
    static readonly int Value_Offset;
    public float Value;
    
    // StructProperty /Script/RigVM.RigVMFunction_AnimEvalRichCurve:Curve
    static readonly int Curve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve Curve;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEvalRichCurve:SourceMinimum
    static readonly int SourceMinimum_Offset;
    public float SourceMinimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEvalRichCurve:SourceMaximum
    static readonly int SourceMaximum_Offset;
    public float SourceMaximum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEvalRichCurve:TargetMinimum
    static readonly int TargetMinimum_Offset;
    public float TargetMinimum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEvalRichCurve:TargetMaximum
    static readonly int TargetMaximum_Offset;
    public float TargetMaximum;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AnimEvalRichCurve:Result
    static readonly int Result_Offset;
    public float Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AnimEvalRichCurve()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AnimEvalRichCurve");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Curve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Curve");
        SourceMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceMinimum");
        SourceMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceMaximum");
        TargetMinimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetMinimum");
        TargetMaximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TargetMaximum");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AnimEvalRichCurve(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Curve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, Curve_Offset), 0, null);
            SourceMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SourceMinimum_Offset), 0, null);
            SourceMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SourceMaximum_Offset), 0, null);
            TargetMinimum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetMinimum_Offset), 0, null);
            TargetMaximum = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, TargetMaximum_Offset), 0, null);
            Result = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, Curve_Offset), 0, null, Curve);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SourceMinimum_Offset), 0, null, SourceMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SourceMaximum_Offset), 0, null, SourceMaximum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetMinimum_Offset), 0, null, TargetMinimum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, TargetMaximum_Offset), 0, null, TargetMaximum);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AnimEvalRichCurveMarshaler
{
    public static RigVMFunction_AnimEvalRichCurve FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AnimEvalRichCurve(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AnimEvalRichCurve obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AnimEvalRichCurve.NativeDataSize;
    }
}