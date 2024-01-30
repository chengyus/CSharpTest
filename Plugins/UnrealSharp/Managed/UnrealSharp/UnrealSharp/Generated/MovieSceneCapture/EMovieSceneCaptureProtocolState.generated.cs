using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneCapture;

[UEnum]
public enum EMovieSceneCaptureProtocolState : byte
{
    Idle=0,
    Initialized=1,
    Capturing=2,
    Finalizing=3,
}