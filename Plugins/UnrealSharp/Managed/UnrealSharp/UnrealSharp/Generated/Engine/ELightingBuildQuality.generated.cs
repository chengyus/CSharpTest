using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ELightingBuildQuality : byte
{
    Quality_Preview=0,
    Quality_Medium=1,
    Quality_High=2,
    Quality_Production=3,
}