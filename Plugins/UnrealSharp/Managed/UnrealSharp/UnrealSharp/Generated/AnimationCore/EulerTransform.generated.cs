using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationCore;

[UStruct(IsBlittable = true)]
public partial struct EulerTransform
{
    // StructProperty /Script/AnimationCore.EulerTransform:Location
    public System.DoubleNumerics.Vector3 Location;
    
    // StructProperty /Script/AnimationCore.EulerTransform:Rotation
    public UnrealSharp.Rotator Rotation;
    
    // StructProperty /Script/AnimationCore.EulerTransform:Scale
    public System.DoubleNumerics.Vector3 Scale;
    
}