using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct(IsBlittable = true)]
public partial struct SoundSubmixSpectralAnalysisBandSettings
{
    // FloatProperty /Script/Engine.SoundSubmixSpectralAnalysisBandSettings:BandFrequency
    public float BandFrequency;
    
    // IntProperty /Script/Engine.SoundSubmixSpectralAnalysisBandSettings:AttackTimeMsec
    public int AttackTimeMsec;
    
    // IntProperty /Script/Engine.SoundSubmixSpectralAnalysisBandSettings:ReleaseTimeMsec
    public int ReleaseTimeMsec;
    
    // FloatProperty /Script/Engine.SoundSubmixSpectralAnalysisBandSettings:QFactor
    public float QFactor;
    
}