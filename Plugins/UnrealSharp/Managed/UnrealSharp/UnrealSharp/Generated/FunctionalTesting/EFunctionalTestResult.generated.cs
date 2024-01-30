using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UEnum]
public enum EFunctionalTestResult : byte
{
    Default=0,
    Invalid=1,
    Error=2,
    Running=3,
    Failed=4,
    Succeeded=5,
}