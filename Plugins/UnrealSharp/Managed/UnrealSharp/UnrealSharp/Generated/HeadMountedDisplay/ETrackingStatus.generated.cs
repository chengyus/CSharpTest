using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UEnum]
public enum ETrackingStatus : byte
{
    NotTracked=0,
    InertialOnly=1,
    Tracked=2,
}