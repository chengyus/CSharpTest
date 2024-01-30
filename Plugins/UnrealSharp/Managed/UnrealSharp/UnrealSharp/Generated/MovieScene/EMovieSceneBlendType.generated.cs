using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UEnum]
public enum EMovieSceneBlendType : byte
{
    Absolute=1,
    Additive=2,
    Relative=3,
    AdditiveFromBase=4,
}