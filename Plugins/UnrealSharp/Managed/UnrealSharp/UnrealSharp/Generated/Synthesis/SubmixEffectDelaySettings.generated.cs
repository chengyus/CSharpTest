using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct(IsBlittable = true)]
public partial struct SubmixEffectDelaySettings
{
    // FloatProperty /Script/Synthesis.SubmixEffectDelaySettings:MaximumDelayLength
    public float MaximumDelayLength;
    
    // FloatProperty /Script/Synthesis.SubmixEffectDelaySettings:InterpolationTime
    public float InterpolationTime;
    
    // FloatProperty /Script/Synthesis.SubmixEffectDelaySettings:DelayLength
    public float DelayLength;
    
}