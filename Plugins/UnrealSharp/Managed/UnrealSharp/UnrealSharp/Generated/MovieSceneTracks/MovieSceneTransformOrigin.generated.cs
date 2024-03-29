using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

public partial interface IMovieSceneTransformOrigin
{
    public UnrealSharp.Transform BP_GetTransformOrigin();
}