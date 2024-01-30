using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EHLODLevelExclusion : byte
{
    HLOD0=0,
    HLOD1=1,
    HLOD2=2,
    HLOD3=3,
    HLOD4=4,
    HLOD5=5,
    HLOD6=6,
    HLOD7=7,
}