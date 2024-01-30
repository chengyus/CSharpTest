using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioSynesthesia;

[UStruct(IsBlittable = true)]
public partial struct LoudnessResults
{
    // FloatProperty /Script/AudioSynesthesia.LoudnessResults:Loudness
    public float Loudness;
    
    // FloatProperty /Script/AudioSynesthesia.LoudnessResults:NormalizedLoudness
    public float NormalizedLoudness;
    
    // FloatProperty /Script/AudioSynesthesia.LoudnessResults:PerceptualEnergy
    public float PerceptualEnergy;
    
    // FloatProperty /Script/AudioSynesthesia.LoudnessResults:TimeSeconds
    public float TimeSeconds;
    
}