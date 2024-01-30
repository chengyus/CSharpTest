using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InputCore;

[UEnum]
public enum EControllerHand : byte
{
    Left=0,
    Right=1,
    AnyHand=2,
    Pad=3,
    ExternalCamera=4,
    Gun=5,
    HMD=6,
    Chest=7,
    LeftShoulder=8,
    RightShoulder=9,
    LeftElbow=10,
    RightElbow=11,
    Waist=12,
    LeftKnee=13,
    RightKnee=14,
    LeftFoot=15,
    RightFoot=16,
    Special=17,
}