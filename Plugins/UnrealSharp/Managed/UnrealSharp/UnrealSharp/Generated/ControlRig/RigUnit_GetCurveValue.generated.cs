using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetCurveValue
{
    // NameProperty /Script/ControlRig.RigUnit_GetCurveValue:Curve
    static readonly int Curve_Offset;
    public Name Curve;
    
    // BoolProperty /Script/ControlRig.RigUnit_GetCurveValue:Valid
    static readonly int Valid_Offset;
    public bool Valid;
    
    // FloatProperty /Script/ControlRig.RigUnit_GetCurveValue:Value
    static readonly int Value_Offset;
    public float Value;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetCurveValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetCurveValue");
        
        Curve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Curve");
        Valid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Valid");
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetCurveValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            Curve = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Curve_Offset), 0, null);
            Valid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Valid_Offset), 0, null);
            Value = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Curve_Offset), 0, null, Curve);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Valid_Offset), 0, null, Valid);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
        }
    }
}

public static class RigUnit_GetCurveValueMarshaler
{
    public static RigUnit_GetCurveValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetCurveValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetCurveValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetCurveValue.NativeDataSize;
    }
}