using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct(IsBlittable = true)]
public partial struct SourceEffectFoldbackDistortionSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectFoldbackDistortionSettings:InputGainDb
    public float InputGainDb;
    
    // FloatProperty /Script/Synthesis.SourceEffectFoldbackDistortionSettings:ThresholdDb
    public float ThresholdDb;
    
    // FloatProperty /Script/Synthesis.SourceEffectFoldbackDistortionSettings:OutputGainDb
    public float OutputGainDb;
    
}