using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_UnsetCurveValue
{
    // NameProperty /Script/ControlRig.RigUnit_UnsetCurveValue:Curve
    static readonly int Curve_Offset;
    public Name Curve;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_UnsetCurveValue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_UnsetCurveValue");
        
        Curve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Curve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_UnsetCurveValue(IntPtr InNativeStruct)
    {
        unsafe
        {
            Curve = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Curve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Curve_Offset), 0, null, Curve);
        }
    }
}

public static class RigUnit_UnsetCurveValueMarshaler
{
    public static RigUnit_UnsetCurveValue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_UnsetCurveValue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_UnsetCurveValue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_UnsetCurveValue.NativeDataSize;
    }
}