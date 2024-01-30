using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum ERBFNormalizeMethod : byte
{
    OnlyNormalizeAboveOne=0,
    AlwaysNormalize=1,
    NormalizeWithinMedian=2,
    NoNormalization=3,
}