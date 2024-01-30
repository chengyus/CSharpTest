using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RigUnit_CCDIK_RotationLimit
{
    // NameProperty /Script/ControlRig.RigUnit_CCDIK_RotationLimit:Bone
    public Name Bone;
    
    // FloatProperty /Script/ControlRig.RigUnit_CCDIK_RotationLimit:Limit
    public float Limit;
    
}