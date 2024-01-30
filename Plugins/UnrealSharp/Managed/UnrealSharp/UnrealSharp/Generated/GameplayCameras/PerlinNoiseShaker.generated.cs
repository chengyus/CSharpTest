using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UStruct(IsBlittable = true)]
public partial struct PerlinNoiseShaker
{
    // FloatProperty /Script/GameplayCameras.PerlinNoiseShaker:Amplitude
    public float Amplitude;
    
    // FloatProperty /Script/GameplayCameras.PerlinNoiseShaker:Frequency
    public float Frequency;
    
}