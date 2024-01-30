using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UEnum]
public enum EMovieSceneKeyInterpolation : byte
{
    Auto=0,
    User=1,
    Break=2,
    Linear=3,
    Constant=4,
    SmartAuto=5,
}