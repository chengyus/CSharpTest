using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ResonanceAudio;

[UEnum]
public enum ERaDistanceRolloffModel : byte
{
    LOGARITHMIC=0,
    LINEAR=1,
    NONE=2,
}