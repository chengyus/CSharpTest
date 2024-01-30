using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct(IsBlittable = true)]
public partial struct MathRBFInterpolateVectorVector_Target
{
    // StructProperty /Script/RigVM.MathRBFInterpolateVectorVector_Target:Target
    public System.DoubleNumerics.Vector3 Target;
    
    // StructProperty /Script/RigVM.MathRBFInterpolateVectorVector_Target:Value
    public System.DoubleNumerics.Vector3 Value;
    
}