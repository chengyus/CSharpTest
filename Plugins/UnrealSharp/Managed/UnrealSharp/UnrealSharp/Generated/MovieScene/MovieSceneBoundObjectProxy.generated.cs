using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

public partial interface IMovieSceneBoundObjectProxy
{
    public UnrealSharp.CoreUObject.Object BP_GetBoundObjectForSequencer(UnrealSharp.CoreUObject.Object resolvedObject);
}