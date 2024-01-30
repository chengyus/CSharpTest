using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EDetailMode : byte
{
    DM_Low=0,
    DM_Medium=1,
    DM_High=2,
    DM_Epic=3,
}