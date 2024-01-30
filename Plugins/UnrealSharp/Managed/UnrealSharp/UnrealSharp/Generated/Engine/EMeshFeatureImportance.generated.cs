using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMeshFeatureImportance : byte
{
    Off=0,
    Lowest=1,
    Low=2,
    Normal=3,
    High=4,
    Highest=5,
}