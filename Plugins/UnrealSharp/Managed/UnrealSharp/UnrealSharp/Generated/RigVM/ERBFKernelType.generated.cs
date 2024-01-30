using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UEnum]
public enum ERBFKernelType : byte
{
    Gaussian=0,
    Exponential=1,
    Linear=2,
    Cubic=3,
    Quintic=4,
}