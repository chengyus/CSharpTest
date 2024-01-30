using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAudioSpectrumBandPresetType : byte
{
    KickDrum=0,
    SnareDrum=1,
    Voice=2,
    Cymbals=3,
}