using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ESkyLightSourceType : byte
{
    SLS_CapturedScene=0,
    SLS_SpecifiedCubemap=1,
}