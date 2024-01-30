using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct RadialDamageParams
{
    // FloatProperty /Script/Engine.RadialDamageParams:BaseDamage
    public float BaseDamage;
    
    // FloatProperty /Script/Engine.RadialDamageParams:MinimumDamage
    public float MinimumDamage;
    
    // FloatProperty /Script/Engine.RadialDamageParams:InnerRadius
    public float InnerRadius;
    
    // FloatProperty /Script/Engine.RadialDamageParams:OuterRadius
    public float OuterRadius;
    
    // FloatProperty /Script/Engine.RadialDamageParams:DamageFalloff
    public float DamageFalloff;
    
}