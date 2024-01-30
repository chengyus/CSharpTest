using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AlphaInterpVector
{
    // StructProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:Value
    static readonly int Value_Offset;
    public System.DoubleNumerics.Vector3 Value;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:Bias
    static readonly int Bias_Offset;
    public float Bias;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:bMapRange
    static readonly int bMapRange_Offset;
    public bool MapRange;
    
    // StructProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:InRange
    static readonly int InRange_Offset;
    public UnrealSharp.Engine.InputRange Range;
    
    // StructProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:OutRange
    static readonly int OutRange_Offset;
    public UnrealSharp.Engine.InputRange OutRange;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:bClampResult
    static readonly int bClampResult_Offset;
    public bool ClampResult;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:ClampMin
    static readonly int ClampMin_Offset;
    public float ClampMin;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:ClampMax
    static readonly int ClampMax_Offset;
    public float ClampMax;
    
    // BoolProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:bInterpResult
    static readonly int bInterpResult_Offset;
    public bool InterpResult;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:InterpSpeedIncreasing
    static readonly int InterpSpeedIncreasing_Offset;
    public float InterpSpeedIncreasing;
    
    // FloatProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:InterpSpeedDecreasing
    static readonly int InterpSpeedDecreasing_Offset;
    public float InterpSpeedDecreasing;
    
    // StructProperty /Script/RigVM.RigVMFunction_AlphaInterpVector:Result
    static readonly int Result_Offset;
    public System.DoubleNumerics.Vector3 Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AlphaInterpVector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AlphaInterpVector");
        
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
    public RigVMFunction_AlphaInterpVector(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
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
            Result = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
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
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_AlphaInterpVectorMarshaler
{
    public static RigVMFunction_AlphaInterpVector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AlphaInterpVector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AlphaInterpVector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AlphaInterpVector.NativeDataSize;
    }
}