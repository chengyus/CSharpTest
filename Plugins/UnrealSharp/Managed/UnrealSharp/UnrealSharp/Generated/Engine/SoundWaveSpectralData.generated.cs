using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct SoundWaveSpectralData
{
    // FloatProperty /Script/Engine.SoundWaveSpectralData:FrequencyHz
    public float FrequencyHz;
    
    // FloatProperty /Script/Engine.SoundWaveSpectralData:Magnitude
    public float Magnitude;
    
    // FloatProperty /Script/Engine.SoundWaveSpectralData:NormalizedMagnitude
    public float NormalizedMagnitude;
    
}