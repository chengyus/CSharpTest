using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CurveEditorTools;

[UEnum]
public enum ECurveEditorFFTFilterType : byte
{
    Lowpass=0,
    Highpass=1,
}