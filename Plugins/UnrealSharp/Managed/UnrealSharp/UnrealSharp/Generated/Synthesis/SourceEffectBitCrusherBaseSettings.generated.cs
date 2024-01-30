using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct(IsBlittable = true)]
public partial struct SourceEffectBitCrusherBaseSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectBitCrusherBaseSettings:SampleRate
    public float SampleRate;
    
    // FloatProperty /Script/Synthesis.SourceEffectBitCrusherBaseSettings:BitDepth
    public float BitDepth;
    
}