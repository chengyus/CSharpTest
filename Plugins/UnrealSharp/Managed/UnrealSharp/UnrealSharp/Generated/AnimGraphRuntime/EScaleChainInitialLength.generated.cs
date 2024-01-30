using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UEnum]
public enum EScaleChainInitialLength : byte
{
    FixedDefaultLengthValue=0,
    Distance=1,
    ChainLength=2,
}