// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UClass]
public partial class IKRig_SetTransformEffector : UnrealSharp.CoreUObject.Object
{
    
    static IKRig_SetTransformEffector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("IKRig_SetTransformEffector");
        
        bEnablePosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnablePosition");
        bEnableRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableRotation");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        
        
        
    }
    
    protected IKRig_SetTransformEffector(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/IKRig.IKRig_SetTransformEffector:bEnablePosition
    static readonly int bEnablePosition_Offset;
    
    public bool bEnablePosition
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bEnablePosition_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bEnablePosition_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/IKRig.IKRig_SetTransformEffector:bEnableRotation
    static readonly int bEnableRotation_Offset;
    
    public bool bEnableRotation
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bEnableRotation_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bEnableRotation_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/IKRig.IKRig_SetTransformEffector:Alpha
    static readonly int Alpha_Offset;
    
    public float Alpha
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, Alpha_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, Alpha_Offset), 0, this, value);
        }
    }
    
    
}