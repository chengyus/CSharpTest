using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct(IsBlittable = true)]
public partial struct MathRBFInterpolateVectorColor_Target
{
    // StructProperty /Script/RigVM.MathRBFInterpolateVectorColor_Target:Target
    public System.DoubleNumerics.Vector3 Target;
    
    // StructProperty /Script/RigVM.MathRBFInterpolateVectorColor_Target:Value
    public UnrealSharp.CoreUObject.LinearColor Value;
    
}