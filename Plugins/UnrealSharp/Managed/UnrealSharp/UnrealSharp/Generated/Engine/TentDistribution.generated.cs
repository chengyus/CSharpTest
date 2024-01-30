using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct TentDistribution
{
    // FloatProperty /Script/Engine.TentDistribution:TipAltitude
    public float TipAltitude;
    
    // FloatProperty /Script/Engine.TentDistribution:TipValue
    public float TipValue;
    
    // FloatProperty /Script/Engine.TentDistribution:Width
    public float Width;
    
}