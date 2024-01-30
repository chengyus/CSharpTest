using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ECastRayTracedShadow : byte
{
    Disabled=0,
    UseProjectSetting=1,
    Enabled=2,
}