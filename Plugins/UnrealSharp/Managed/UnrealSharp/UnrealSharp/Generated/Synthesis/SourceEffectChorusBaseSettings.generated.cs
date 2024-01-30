using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct(IsBlittable = true)]
public partial struct SourceEffectChorusBaseSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectChorusBaseSettings:Depth
    public float Depth;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusBaseSettings:Frequency
    public float Frequency;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusBaseSettings:Feedback
    public float Feedback;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusBaseSettings:WetLevel
    public float WetLevel;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusBaseSettings:DryLevel
    public float DryLevel;
    
    // FloatProperty /Script/Synthesis.SourceEffectChorusBaseSettings:Spread
    public float Spread;
    
}