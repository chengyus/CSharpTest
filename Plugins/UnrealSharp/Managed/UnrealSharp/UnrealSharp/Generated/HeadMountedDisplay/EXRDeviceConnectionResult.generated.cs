using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UEnum]
public enum EXRDeviceConnectionResult : byte
{
    NoTrackingSystem=0,
    FeatureNotSupported=1,
    NoValidViewport=2,
    MiscFailure=3,
    Success=4,
}