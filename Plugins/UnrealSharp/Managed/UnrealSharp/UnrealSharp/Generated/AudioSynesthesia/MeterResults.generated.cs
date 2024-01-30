using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioSynesthesia;

[UStruct(IsBlittable = true)]
public partial struct MeterResults
{
    // FloatProperty /Script/AudioSynesthesia.MeterResults:TimeSeconds
    public float TimeSeconds;
    
    // FloatProperty /Script/AudioSynesthesia.MeterResults:MeterValue
    public float MeterValue;
    
    // FloatProperty /Script/AudioSynesthesia.MeterResults:PeakValue
    public float PeakValue;
    
    // IntProperty /Script/AudioSynesthesia.MeterResults:NumSamplesClipping
    public int NumSamplesClipping;
    
    // FloatProperty /Script/AudioSynesthesia.MeterResults:ClippingValue
    public float ClippingValue;
    
}