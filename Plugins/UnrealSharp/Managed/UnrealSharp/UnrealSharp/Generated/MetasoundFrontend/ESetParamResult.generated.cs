using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundFrontend;

[UEnum]
public enum ESetParamResult : byte
{
    Succeeded=0,
    Failed=1,
}