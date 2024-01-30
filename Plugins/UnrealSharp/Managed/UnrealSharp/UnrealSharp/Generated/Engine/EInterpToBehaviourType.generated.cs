using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EInterpToBehaviourType : byte
{
    OneShot=0,
    OneShot_Reverse=1,
    Loop_Reset=2,
    PingPong=3,
}