using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UEnum]
public enum EMovieSceneCompletionMode : byte
{
    KeepState=0,
    RestoreState=1,
    ProjectDefault=2,
}