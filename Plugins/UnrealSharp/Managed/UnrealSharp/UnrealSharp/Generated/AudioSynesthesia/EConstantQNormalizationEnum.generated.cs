using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioSynesthesia;

[UEnum]
public enum EConstantQNormalizationEnum : byte
{
    EqualEuclideanNorm=0,
    EqualEnergy=1,
    EqualAmplitude=2,
}