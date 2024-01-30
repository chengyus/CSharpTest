using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EMouseCaptureMode : byte
{
    NoCapture=0,
    CapturePermanently=1,
    CapturePermanently_IncludingInitialMouseDown=2,
    CaptureDuringMouseDown=3,
    CaptureDuringRightMouseDown=4,
}