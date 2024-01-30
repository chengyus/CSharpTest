using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AlphaInterpQuat
{
    // StructProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Quaternion Value;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:Bias
    static readonly int Bias_Offset;
    public float Bias;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:bMapRange
    static readonly int bMapRange_Offset;
    public bool MapRange;
    
    // StructProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:InRange
    static readonly int InRange_Offset;
    public UnrealSharp.Engine.InputRange Range;
    
    // StructProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:OutRange
    static readonly int OutRange_Offset;
    public UnrealSharp.Engine.InputRange OutRange;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:bClampResult
    static readonly int bClampResult_Offset;
    public bool ClampResult;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:ClampMin
    static readonly int ClampMin_Offset;
    public float ClampMin;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:ClampMax
    static readonly int ClampMax_Offset;
    public float ClampMax;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:bInterpResult
    static readonly int bInterpResult_Offset;
    public bool InterpResult;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:InterpSpeedIncreasing
    static readonly int InterpSpeedIncreasing_Offset;
    public float InterpSpeedIncreasing;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:InterpSpeedDecreasing
    static readonly int InterpSpeedDecreasing_Offset;
    public float InterpSpeedDecreasing;
    
    // StructProperty /Script/RigVM.RigVMFunction_AlphaInterpQuat:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Quaternion Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AlphaInterpQuat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AlphaInterpQuat");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Bias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bias");
        bMapRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMapRange");
        InRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InRange");
        OutRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutRange");
        bClampResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bClampResult");
        ClampMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ClampMin");
        ClampMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ClampMax");
        bInterpResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInterpResult");
        InterpSpeedIncreasing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpSpeedIncreasing");
        InterpSpeedDecreasing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpSpeedDecreasing");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AlphaInterpQuat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            Bias = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bias_Offset), 0, null);
            MapRange = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMapRange_Offset), 0, null);
            Range = BlittableMarshaller<UnrealSharp.Engine.InputRange>.FromNative(IntPtr.Add(InNativeStruct, InRange_Offset), 0, null);
            OutRange = BlittableMarshaller<UnrealSharp.Engine.InputRange>.FromNative(IntPtr.Add(InNativeStruct, OutRange_Offset), 0, null);
            ClampResult = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bClampResult_Offset), 0, null);
            ClampMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ClampMin_Offset), 0, null);
            ClampMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ClampMax_Offset), 0, null);
            InterpResult = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bInterpResult_Offset), 0, null);
            InterpSpeedIncreasing = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InterpSpeedIncreasing_Offset), 0, null);
            InterpSpeedDecreasing = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InterpSpeedDecreasing_Offset), 0, null);
            Result = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bias_Offset), 0, null, Bias);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMapRange_Offset), 0, null, MapRange);
            BlittableMarshaller<UnrealSharp.Engine.InputRange>.ToNative(IntPtr.Add(Buffer, InRange_Offset), 0, null, Range);
            BlittableMarshaller<UnrealSharp.Engine.InputRange>.ToNative(IntPtr.Add(Buffer, OutRange_Offset), 0, null, OutRange);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bClampResult_Offset), 0, null, ClampResult);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ClampMin_Offset), 0, null, ClampMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ClampMax_Offset), 0, null, ClampMax);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bInterpResult_Offset), 0, null, InterpResult);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InterpSpeedIncreasing_Offset), 0, null, InterpSpeedIncreasing);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InterpSpeedDecreasing_Offset), 0, null, InterpSpeedDecreasing);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AlphaInterpQuatMarshaler
{
    public static RigVMFunction_AlphaInterpQuat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AlphaInterpQuat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AlphaInterpQuat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AlphaInterpQuat.NativeDataSize;
    }
}