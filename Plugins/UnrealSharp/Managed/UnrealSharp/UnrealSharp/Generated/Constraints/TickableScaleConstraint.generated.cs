// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Constraints;

[UClass]
public partial class TickableScaleConstraint : UnrealSharp.Constraints.TickableTransformConstraint
{
    
    static TickableScaleConstraint()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("TickableScaleConstraint");
        
        OffsetScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OffsetScale");
        AxisFilter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AxisFilter");
        
        
        
    }
    
    protected TickableScaleConstraint(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/Constraints.TickableScaleConstraint:OffsetScale
    static readonly int OffsetScale_Offset;
    
    public System.DoubleNumerics.Vector3 OffsetScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(NativeObject, OffsetScale_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(NativeObject, OffsetScale_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/Constraints.TickableScaleConstraint:AxisFilter
    static readonly int AxisFilter_Offset;
    
    public UnrealSharp.AnimationCore.FilterOptionPerAxis AxisFilter
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.FromNative(IntPtr.Add(NativeObject, AxisFilter_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.AnimationCore.FilterOptionPerAxisMarshaler.ToNative(IntPtr.Add(NativeObject, AxisFilter_Offset), 0, this, value);
        }
    }
    
    
}