using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.NiagaraAnimNotifies;

[UStruct(IsBlittable = true)]
public partial struct CurveParameterPair
{
    // NameProperty /Script/NiagaraAnimNotifies.CurveParameterPair:AnimCurveName
    public Name AnimCurveName;
    
    // NameProperty /Script/NiagaraAnimNotifies.CurveParameterPair:UserVariableName
    public Name UserVariableName;
    
}