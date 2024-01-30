using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ERichCurveTangentWeightMode : byte
{
    RCTWM_WeightedNone=0,
    RCTWM_WeightedArrive=1,
    RCTWM_WeightedLeave=2,
    RCTWM_WeightedBoth=3,
}