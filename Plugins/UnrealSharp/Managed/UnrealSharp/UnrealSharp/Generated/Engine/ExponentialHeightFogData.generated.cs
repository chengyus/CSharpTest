using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct ExponentialHeightFogData
{
    // FloatProperty /Script/Engine.ExponentialHeightFogData:FogDensity
    public float FogDensity;
    
    // FloatProperty /Script/Engine.ExponentialHeightFogData:FogHeightFalloff
    public float FogHeightFalloff;
    
    // FloatProperty /Script/Engine.ExponentialHeightFogData:FogHeightOffset
    public float FogHeightOffset;
    
}