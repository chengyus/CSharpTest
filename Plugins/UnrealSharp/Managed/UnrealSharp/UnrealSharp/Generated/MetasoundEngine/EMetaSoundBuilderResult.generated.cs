using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MetasoundEngine;

[UEnum]
public enum EMetaSoundBuilderResult : byte
{
    Succeeded=0,
    Failed=1,
}