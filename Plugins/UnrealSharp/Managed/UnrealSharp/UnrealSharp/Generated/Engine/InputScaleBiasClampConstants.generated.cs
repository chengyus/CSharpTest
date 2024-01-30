using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct InputScaleBiasClampConstants
{
    // BoolProperty /Script/Engine.InputScaleBiasClampConstants:bMapRange
    static readonly int bMapRange_Offset;
    public bool MapRange;
    
    // BoolProperty /Script/Engine.InputScaleBiasClampConstants:bClampResult
    static readonly int bClampResult_Offset;
    public bool ClampResult;
    
    // BoolProperty /Script/Engine.InputScaleBiasClampConstants:bInterpResult
    static readonly int bInterpResult_Offset;
    public bool InterpResult;
    
    // StructProperty /Script/Engine.InputScaleBiasClampConstants:InRange
    static readonly int InRange_Offset;
    public UnrealSharp.Engine.InputRange Range;
    
    // StructProperty /Script/Engine.InputScaleBiasClampConstants:OutRange
    static readonly int OutRange_Offset;
    public UnrealSharp.Engine.InputRange OutRange;
    
    // FloatProperty /Script/Engine.InputScaleBiasClampConstants:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // FloatProperty /Script/Engine.InputScaleBiasClampConstants:Bias
    static readonly int Bias_Offset;
    public float Bias;
    
    // FloatProperty /Script/Engine.InputScaleBiasClampConstants:ClampMin
    static readonly int ClampMin_Offset;
    public float ClampMin;
    
    // FloatProperty /Script/Engine.InputScaleBiasClampConstants:ClampMax
    static readonly int ClampMax_Offset;
    public float ClampMax;
    
    // FloatProperty /Script/Engine.InputScaleBiasClampConstants:InterpSpeedIncreasing
    static readonly int InterpSpeedIncreasing_Offset;
    public float InterpSpeedIncreasing;
    
    // FloatProperty /Script/Engine.InputScaleBiasClampConstants:InterpSpeedDecreasing
    static readonly int InterpSpeedDecreasing_Offset;
    public float InterpSpeedDecreasing;
    
    
    public static readonly int NativeDataSize;
    static InputScaleBiasClampConstants()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputScaleBiasClampConstants");
        
        bMapRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMapRange");
        bClampResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bClampResult");
        bInterpResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bInterpResult");
        InRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InRange");
        OutRange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutRange");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Bias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bias");
        ClampMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ClampMin");
        ClampMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ClampMax");
        InterpSpeedIncreasing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpSpeedIncreasing");
        InterpSpeedDecreasing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpSpeedDecreasing");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputScaleBiasClampConstants(IntPtr InNativeStruct)
    {
        unsafe
        {
            MapRange = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMapRange_Offset), 0, null);
            ClampResult = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bClampResult_Offset), 0, null);
            InterpResult = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bInterpResult_Offset), 0, null);
            Range = BlittableMarshaller<UnrealSharp.Engine.InputRange>.FromNative(IntPtr.Add(InNativeStruct, InRange_Offset), 0, null);
            OutRange = BlittableMarshaller<UnrealSharp.Engine.InputRange>.FromNative(IntPtr.Add(InNativeStruct, OutRange_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            Bias = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Bias_Offset), 0, null);
            ClampMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ClampMin_Offset), 0, null);
            ClampMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ClampMax_Offset), 0, null);
            InterpSpeedIncreasing = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InterpSpeedIncreasing_Offset), 0, null);
            InterpSpeedDecreasing = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InterpSpeedDecreasing_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMapRange_Offset), 0, null, MapRange);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bClampResult_Offset), 0, null, ClampResult);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bInterpResult_Offset), 0, null, InterpResult);
            BlittableMarshaller<UnrealSharp.Engine.InputRange>.ToNative(IntPtr.Add(Buffer, InRange_Offset), 0, null, Range);
            BlittableMarshaller<UnrealSharp.Engine.InputRange>.ToNative(IntPtr.Add(Buffer, OutRange_Offset), 0, null, OutRange);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Bias_Offset), 0, null, Bias);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ClampMin_Offset), 0, null, ClampMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ClampMax_Offset), 0, null, ClampMax);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InterpSpeedIncreasing_Offset), 0, null, InterpSpeedIncreasing);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InterpSpeedDecreasing_Offset), 0, null, InterpSpeedDecreasing);
        }
    }
}

public static class InputScaleBiasClampConstantsMarshaler
{
    public static InputScaleBiasClampConstants FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputScaleBiasClampConstants(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputScaleBiasClampConstants obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputScaleBiasClampConstants.NativeDataSize;
    }
}