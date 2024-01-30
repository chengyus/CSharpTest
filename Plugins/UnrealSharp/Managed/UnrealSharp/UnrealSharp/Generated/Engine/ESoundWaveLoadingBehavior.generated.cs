using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESoundWaveLoadingBehavior : byte
{
    Inherited=0,
    RetainOnLoad=1,
    PrimeOnLoad=2,
    LoadOnDemand=3,
    ForceInline=4,
}