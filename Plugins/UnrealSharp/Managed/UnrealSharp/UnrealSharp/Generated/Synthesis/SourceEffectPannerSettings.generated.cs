using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct(IsBlittable = true)]
public partial struct SourceEffectPannerSettings
{
    // FloatProperty /Script/Synthesis.SourceEffectPannerSettings:Spread
    public float Spread;
    
    // FloatProperty /Script/Synthesis.SourceEffectPannerSettings:Pan
    public float Pan;
    
}