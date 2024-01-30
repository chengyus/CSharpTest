using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EHardwareDeviceSupportedFeatures : byte
{
    Unspecified=0,
    Keypress=1,
    Pointer=2,
    Gamepad=3,
    Touch=4,
    Camera=5,
    MotionTracking=6,
    Lights=7,
    TriggerHaptics=8,
    ForceFeedback=9,
    AudioBasedVibrations=10,
    Acceleration=11,
    Virtual=12,
    Microphone=13,
    Orientation=14,
    CustomA=15,
    CustomB=16,
    CustomC=17,
    CustomD=18,
}