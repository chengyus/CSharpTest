using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct(IsBlittable = true)]
public partial struct SourceEffectWaveShaperSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectWaveShaperSettings:Amount
    public float Amount;
    
    // FloatProperty /Script/Synthesis.SourceEffectWaveShaperSettings:OutputGainDb
    public float OutputGainDb;
    
}