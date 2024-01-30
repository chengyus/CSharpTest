using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UEnum]
public enum EXRTrackedDeviceType : byte
{
    HeadMountedDisplay=0,
    Controller=1,
    TrackingReference=2,
    Tracker=3,
    Other=4,
    Any=6,
}