using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Synthesis;

[UEnum]
public enum ESamplePlayerSeekType : byte
{
    FromBeginning=0,
    FromCurrentPosition=1,
    FromEnd=2,
}