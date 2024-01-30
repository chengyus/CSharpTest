using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct(IsBlittable = true)]
public partial struct SubmixEffectFlexiverbSettings
{
    // FloatProperty /Script/Synthesis.SubmixEffectFlexiverbSettings:PreDelay
    public float PreDelay;
    
    // FloatProperty /Script/Synthesis.SubmixEffectFlexiverbSettings:DecayTime
    public float DecayTime;
    
    // FloatProperty /Script/Synthesis.SubmixEffectFlexiverbSettings:RoomDampening
    public float RoomDampening;
    
    // IntProperty /Script/Synthesis.SubmixEffectFlexiverbSettings:Complexity
    public int Complexity;
    
}