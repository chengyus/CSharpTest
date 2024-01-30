using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CurveEditorTools;

[UEnum]
public enum ECurveEditorFFTFilterClass : byte
{
    Butterworth=0,
    Chebyshev=1,
}