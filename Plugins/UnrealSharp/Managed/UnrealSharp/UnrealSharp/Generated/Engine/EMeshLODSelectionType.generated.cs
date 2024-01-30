using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMeshLODSelectionType : byte
{
    AllLODs=0,
    SpecificLOD=1,
    CalculateLOD=2,
    LowestDetailLOD=3,
}