using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UEnum]
public enum EMediaSoundComponentFFTSize : byte
{
    Min_64=0,
    Small_256=1,
    Medium_512=2,
    Large_1024=3,
}