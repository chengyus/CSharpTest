using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UEnum]
public enum EMovieSceneSubSectionFlags : byte
{
    None=0,
    OverrideKeepState=1,
    OverrideRestoreState=2,
    IgnoreHierarchicalBias=3,
    BlendHierarchicalBias=4,
    AnyRestoreStateOverride=5,
}