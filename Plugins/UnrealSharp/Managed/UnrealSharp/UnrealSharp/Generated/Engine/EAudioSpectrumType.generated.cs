using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAudioSpectrumType : byte
{
    MagnitudeSpectrum=0,
    PowerSpectrum=1,
    Decibel=2,
}