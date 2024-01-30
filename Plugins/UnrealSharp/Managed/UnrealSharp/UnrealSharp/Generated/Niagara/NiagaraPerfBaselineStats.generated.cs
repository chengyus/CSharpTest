using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UStruct(IsBlittable = true)]
public partial struct NiagaraPerfBaselineStats
{
    // FloatProperty /Script/Niagara.NiagaraPerfBaselineStats:PerInstanceAvg_GT
    public float PerInstanceAvg_GT;
    
    // FloatProperty /Script/Niagara.NiagaraPerfBaselineStats:PerInstanceAvg_RT
    public float PerInstanceAvg_RT;
    
    // FloatProperty /Script/Niagara.NiagaraPerfBaselineStats:PerInstanceMax_GT
    public float PerInstanceMax_GT;
    
    // FloatProperty /Script/Niagara.NiagaraPerfBaselineStats:PerInstanceMax_RT
    public float PerInstanceMax_RT;
    
}