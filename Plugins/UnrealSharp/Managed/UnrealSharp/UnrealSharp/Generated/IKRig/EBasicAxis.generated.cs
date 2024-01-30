using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UEnum]
public enum EBasicAxis : byte
{
    X=0,
    Y=1,
    Z=2,
    NegX=3,
    NegY=4,
    NegZ=5,
}