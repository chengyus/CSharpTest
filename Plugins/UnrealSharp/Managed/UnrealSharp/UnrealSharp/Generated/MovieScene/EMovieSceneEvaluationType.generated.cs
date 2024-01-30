using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UEnum]
public enum EMovieSceneEvaluationType : byte
{
    FrameLocked=0,
    WithSubFrames=1,
}