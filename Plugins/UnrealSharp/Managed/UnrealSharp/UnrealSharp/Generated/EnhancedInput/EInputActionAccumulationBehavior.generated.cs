using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UEnum]
public enum EInputActionAccumulationBehavior : byte
{
    TakeHighestAbsoluteValue=0,
    Cumulative=1,
}