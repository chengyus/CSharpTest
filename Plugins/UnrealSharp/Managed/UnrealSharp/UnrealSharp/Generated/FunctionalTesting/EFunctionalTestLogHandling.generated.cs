using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UEnum]
public enum EFunctionalTestLogHandling : byte
{
    ProjectDefault=0,
    OutputIsError=1,
    OutputIgnored=2,
}