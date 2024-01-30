using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UEnum]
public enum EParticleAllocationMode : byte
{
    AutomaticEstimate=0,
    ManualEstimate=1,
    FixedCount=2,
}