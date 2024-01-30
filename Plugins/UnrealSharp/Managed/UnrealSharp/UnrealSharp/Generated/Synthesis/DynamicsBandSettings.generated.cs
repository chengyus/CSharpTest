using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UStruct(IsBlittable = true)]
public partial struct DynamicsBandSettings
{
    // FloatProperty /Script/Synthesis.DynamicsBandSettings:CrossoverTopFrequency
    public float CrossoverTopFrequency;
    
    // FloatProperty /Script/Synthesis.DynamicsBandSettings:AttackTimeMsec
    public float AttackTimeMsec;
    
    // FloatProperty /Script/Synthesis.DynamicsBandSettings:ReleaseTimeMsec
    public float ReleaseTimeMsec;
    
    // FloatProperty /Script/Synthesis.DynamicsBandSettings:ThresholdDb
    public float ThresholdDb;
    
    // FloatProperty /Script/Synthesis.DynamicsBandSettings:Ratio
    public float Ratio;
    
    // FloatProperty /Script/Synthesis.DynamicsBandSettings:KneeBandwidthDb
    public float KneeBandwidthDb;
    
    // FloatProperty /Script/Synthesis.DynamicsBandSettings:InputGainDb
    public float InputGainDb;
    
    // FloatProperty /Script/Synthesis.DynamicsBandSettings:OutputGainDb
    public float OutputGainDb;
    
}