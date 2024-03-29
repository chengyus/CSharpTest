using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESubmixFilterAlgorithm : byte
{
    OnePole=0,
    StateVariable=1,
    Ladder=2,
}