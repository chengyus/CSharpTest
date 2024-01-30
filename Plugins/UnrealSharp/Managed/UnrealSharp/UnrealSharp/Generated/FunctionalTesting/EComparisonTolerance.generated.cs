using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UEnum]
public enum EComparisonTolerance : byte
{
    Zero=0,
    Low=1,
    Medium=2,
    High=3,
    Custom=4,
}