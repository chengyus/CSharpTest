using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct(IsBlittable = true)]
public partial struct MathRBFInterpolateQuatColor_Target
{
    // StructProperty /Script/RigVM.MathRBFInterpolateQuatColor_Target:Target
    public System.DoubleNumerics.Quaternion Target;
    
    // StructProperty /Script/RigVM.MathRBFInterpolateQuatColor_Target:Value
    public UnrealSharp.CoreUObject.LinearColor Value;
    
}