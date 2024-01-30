using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigSpline;

[UStruct]
public partial struct RigUnit_FitSplineCurveToChain
{
    // StructProperty /Script/ControlRigSpline.RigUnit_FitSplineCurveToChain:Items
    static readonly int Items_Offset;
    public UnrealSharp.ControlRig.RigElementKeyCollection Items;
    
    // StructProperty /Script/ControlRigSpline.RigUnit_FitSplineCurveToChain:Spline
    static readonly int Spline_Offset;
    public UnrealSharp.ControlRigSpline.ControlRigSpline Spline;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FitSplineCurveToChain()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FitSplineCurveToChain");
        
        Items_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Items");
        Spline_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Spline");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_FitSplineCurveToChain(IntPtr InNativeStruct)
    {
        unsafe
        {
            Items = UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.FromNative(IntPtr.Add(InNativeStruct, Items_Offset), 0, null);
            Spline = UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.FromNative(IntPtr.Add(InNativeStruct, Spline_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyCollectionMarshaler.ToNative(IntPtr.Add(Buffer, Items_Offset), 0, null, Items);
            UnrealSharp.ControlRigSpline.ControlRigSplineMarshaler.ToNative(IntPtr.Add(Buffer, Spline_Offset), 0, null, Spline);
        }
    }
}

public static class RigUnit_FitSplineCurveToChainMarshaler
{
    public static RigUnit_FitSplineCurveToChain FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FitSplineCurveToChain(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FitSplineCurveToChain obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FitSplineCurveToChain.NativeDataSize;
    }
}