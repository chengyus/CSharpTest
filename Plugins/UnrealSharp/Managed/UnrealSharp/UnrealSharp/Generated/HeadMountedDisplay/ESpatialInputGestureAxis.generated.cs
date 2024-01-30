using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UEnum]
public enum ESpatialInputGestureAxis : byte
{
    None=0,
    Manipulation=1,
    Navigation=2,
    NavigationRails=3,
}