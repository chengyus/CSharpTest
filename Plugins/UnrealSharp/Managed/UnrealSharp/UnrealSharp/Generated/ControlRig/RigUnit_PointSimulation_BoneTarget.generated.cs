using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RigUnit_PointSimulation_BoneTarget
{
    // NameProperty /Script/ControlRig.RigUnit_PointSimulation_BoneTarget:Bone
    public Name Bone;
    
    // IntProperty /Script/ControlRig.RigUnit_PointSimulation_BoneTarget:TranslationPoint
    public int TranslationPoint;
    
    // IntProperty /Script/ControlRig.RigUnit_PointSimulation_BoneTarget:PrimaryAimPoint
    public int PrimaryAimPoint;
    
    // IntProperty /Script/ControlRig.RigUnit_PointSimulation_BoneTarget:SecondaryAimPoint
    public int SecondaryAimPoint;
    
}