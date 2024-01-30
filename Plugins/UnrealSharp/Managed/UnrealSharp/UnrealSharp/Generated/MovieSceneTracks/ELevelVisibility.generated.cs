using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTracks;

[UEnum]
public enum ELevelVisibility : byte
{
    Visible=0,
    Hidden=1,
}