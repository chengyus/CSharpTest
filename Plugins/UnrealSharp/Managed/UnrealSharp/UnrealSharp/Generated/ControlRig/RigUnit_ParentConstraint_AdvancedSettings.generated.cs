using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct(IsBlittable = true)]
public partial struct RigUnit_ParentConstraint_AdvancedSettings
{
    // EnumProperty /Script/ControlRig.RigUnit_ParentConstraint_AdvancedSettings:InterpolationType
    public UnrealSharp.ControlRig.EConstraintInterpType InterpolationType;
    
    // EnumProperty /Script/ControlRig.RigUnit_ParentConstraint_AdvancedSettings:RotationOrderForFilter
    public UnrealSharp.AnimationCore.EEulerRotationOrder RotationOrderForFilter;
    
}