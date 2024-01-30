using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RigUnit_BoneHarmonics_BoneTarget
{
    // NameProperty /Script/ControlRig.RigUnit_BoneHarmonics_BoneTarget:Bone
    public Name Bone;
    
    // FloatProperty /Script/ControlRig.RigUnit_BoneHarmonics_BoneTarget:Ratio
    public float Ratio;
    
}