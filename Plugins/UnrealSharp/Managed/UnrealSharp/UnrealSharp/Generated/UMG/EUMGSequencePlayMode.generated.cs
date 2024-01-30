using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UEnum]
public enum EUMGSequencePlayMode : byte
{
    Forward=0,
    Reverse=1,
    PingPong=2,
}