using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EIndirectLightingCacheQuality : byte
{
    ILCQ_Off=0,
    ILCQ_Point=1,
    ILCQ_Volume=2,
}