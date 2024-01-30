using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EListItemAlignment : byte
{
    EvenlyDistributed=0,
    EvenlySize=1,
    EvenlyWide=2,
    LeftAligned=3,
    RightAligned=4,
    CenterAligned=5,
    Fill=6,
}