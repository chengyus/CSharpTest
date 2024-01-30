using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UEnum]
public enum EMediaVideoCaptureDeviceFilter : byte
{
    Card=1,
    Software=2,
    Unknown=3,
    Webcam=4,
}