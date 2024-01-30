using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ResonanceAudio;

[UEnum]
public enum ERaSpatializationMethod : byte
{
    STEREO_PANNING=0,
    HRTF=1,
}