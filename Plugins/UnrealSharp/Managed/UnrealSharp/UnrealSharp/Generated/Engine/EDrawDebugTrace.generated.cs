using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EDrawDebugTrace : byte
{
    None=0,
    ForOneFrame=1,
    ForDuration=2,
    Persistent=3,
}