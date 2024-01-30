using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum ERBFFunctionType : byte
{
    Gaussian=0,
    Exponential=1,
    Linear=2,
    Cubic=3,
    Quintic=4,
    DefaultFunction=5,
}