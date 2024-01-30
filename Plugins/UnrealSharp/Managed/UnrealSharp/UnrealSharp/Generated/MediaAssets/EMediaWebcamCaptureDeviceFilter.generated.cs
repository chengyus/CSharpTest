using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UEnum]
public enum EMediaWebcamCaptureDeviceFilter : byte
{
    DepthSensor=1,
    Front=2,
    Rear=3,
    Unknown=4,
}