using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AlembicLibrary;

[UEnum]
public enum EBaseCalculationType : byte
{
    PercentageBased=1,
    FixedNumber=2,
    NoCompression=3,
}