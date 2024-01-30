using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EReflectedAndRefractedRayTracedShadows : byte
{
    Disabled=0,
    Hard_shadows=1,
    Area_shadows=2,
}