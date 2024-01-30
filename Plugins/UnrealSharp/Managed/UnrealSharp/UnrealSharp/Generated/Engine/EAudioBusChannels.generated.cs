using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAudioBusChannels : byte
{
    Mono=0,
    Stereo=1,
    Quad=2,
    FivePointOne=3,
    SevenPointOne=4,
}