using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EDynamicGlobalIlluminationMethod : byte
{
    None=0,
    Lumen=1,
    ScreenSpace=2,
    RayTraced=3,
    Plugin=4,
}