using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorMakeBezierFourPoint
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorMakeBezierFourPoint:Bezier
    static readonly int Bezier_Offset;
    public UnrealSharp.RigVM.RigVMFourPointBezier Bezier;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorMakeBezierFourPoint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorMakeBezierFourPoint");
        
        Bezier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bezier");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorMakeBezierFourPoint(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bezier = UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.FromNative(IntPtr.Add(InNativeStruct, Bezier_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.RigVM.RigVMFourPointBezierMarshaler.ToNative(IntPtr.Add(Buffer, Bezier_Offset), 0, null, Bezier);
        }
    }
}

public static class RigVMFunction_MathVectorMakeBezierFourPointMarshaler
{
    public static RigVMFunction_MathVectorMakeBezierFourPoint FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorMakeBezierFourPoint(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorMakeBezierFourPoint obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorMakeBezierFourPoint.NativeDataSize;
    }
}