// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PhysicsThrusterComponent : UnrealSharp.Engine.SceneComponent
{
    
    static PhysicsThrusterComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PhysicsThrusterComponent");
        
        ThrustStrength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ThrustStrength");
        
        
        
    }
    
    protected PhysicsThrusterComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // FloatProperty /Script/Engine.PhysicsThrusterComponent:ThrustStrength
    static readonly int ThrustStrength_Offset;
    
    public float ThrustStrength
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, ThrustStrength_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, ThrustStrength_Offset), 0, this, value);
        }
    }
    
    
}