using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundEngine;

[UEnum]
public enum EMetaSoundOutputAudioFormat : byte
{
    Mono=0,
    Stereo=1,
    Quad=2,
    FiveDotOne=3,
    SevenDotOne=4,
}