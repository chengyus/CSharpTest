using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EHardwareDevicePrimaryType : byte
{
    Unspecified=0,
    KeyboardAndMouse=1,
    Gamepad=2,
    Touch=3,
    MotionTracking=4,
    RacingWheel=5,
    FlightStick=6,
    Camera=7,
    Instrument=8,
    CustomTypeA=9,
    CustomTypeB=10,
    CustomTypeC=11,
    CustomTypeD=12,
}