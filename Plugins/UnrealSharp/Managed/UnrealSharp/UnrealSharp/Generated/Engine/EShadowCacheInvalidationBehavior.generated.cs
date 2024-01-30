using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EShadowCacheInvalidationBehavior : byte
{
    Auto=0,
    Always=1,
    Rigid=2,
    Static=3,
}