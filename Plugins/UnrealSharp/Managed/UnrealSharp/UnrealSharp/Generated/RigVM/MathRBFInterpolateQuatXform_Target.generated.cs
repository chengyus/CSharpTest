using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct(IsBlittable = true)]
public partial struct MathRBFInterpolateQuatXform_Target
{
    // StructProperty /Script/RigVM.MathRBFInterpolateQuatXform_Target:Target
    public System.DoubleNumerics.Quaternion Target;
    
    // StructProperty /Script/RigVM.MathRBFInterpolateQuatXform_Target:Value
    public UnrealSharp.Transform Value;
    
}