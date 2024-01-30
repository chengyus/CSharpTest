using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EScreenOrientation : byte
{
    Unknown=0,
    Portrait=1,
    PortraitUpsideDown=2,
    LandscapeLeft=3,
    LandscapeRight=4,
    FaceUp=5,
    FaceDown=6,
    PortraitSensor=7,
    LandscapeSensor=8,
    FullSensor=9,
}