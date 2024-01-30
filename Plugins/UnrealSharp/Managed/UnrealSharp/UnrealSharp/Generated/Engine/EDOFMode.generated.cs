using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EDOFMode : byte
{
    Default=0,
    SixDOF=1,
    YZPlane=2,
    XZPlane=3,
    XYPlane=4,
    CustomPlane=5,
    None=6,
}