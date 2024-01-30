using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

[UEnum]
public enum MovieScene3DPathSection_Axis : byte
{
    X=0,
    Y=1,
    Z=2,
    NEG_X=3,
    NEG_Y=4,
    NEG_Z=5,
}