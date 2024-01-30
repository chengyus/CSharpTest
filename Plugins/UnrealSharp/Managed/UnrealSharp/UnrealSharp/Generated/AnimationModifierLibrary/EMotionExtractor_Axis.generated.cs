using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimationModifierLibrary;

[UEnum]
public enum EMotionExtractor_Axis : byte
{
    X=0,
    Y=1,
    Z=2,
    XY=3,
    XZ=4,
    YZ=5,
    XYZ=6,
}