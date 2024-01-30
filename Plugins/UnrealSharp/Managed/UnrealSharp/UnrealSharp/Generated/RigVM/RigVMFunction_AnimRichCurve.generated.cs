using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_AnimRichCurve
{
    // StructProperty /Script/RigVM.RigVMFunction_AnimRichCurve:Curve
    static readonly int Curve_Offset;
    public UnrealSharp.Engine.RuntimeFloatCurve Curve;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_AnimRichCurve()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_AnimRichCurve");
        
        Curve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Curve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_AnimRichCurve(IntPtr InNativeStruct)
    {
        unsafe
        {
            Curve = UnrealSharp.Engine.RuntimeFloatCurveMarshaler.FromNative(IntPtr.Add(InNativeStruct, Curve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.RuntimeFloatCurveMarshaler.ToNative(IntPtr.Add(Buffer, Curve_Offset), 0, null, Curve);
        }
    }
}

public static class RigVMFunction_AnimRichCurveMarshaler
{
    public static RigVMFunction_AnimRichCurve FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_AnimRichCurve(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_AnimRichCurve obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_AnimRichCurve.NativeDataSize;
    }
}