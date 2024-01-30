using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESoundSpatializationAlgorithm : byte
{
    SPATIALIZATION_Default=0,
    SPATIALIZATION_HRTF=1,
}