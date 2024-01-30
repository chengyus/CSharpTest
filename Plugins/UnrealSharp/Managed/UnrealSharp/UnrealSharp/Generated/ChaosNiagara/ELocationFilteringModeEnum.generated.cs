using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ChaosNiagara;

[UEnum]
public enum ELocationFilteringModeEnum : byte
{
    ChaosNiagara_LocationFilteringMode_Inclusive=0,
    ChaosNiagara_LocationFilteringMode_Exclusive=1,
}