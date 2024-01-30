using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UEnum]
public enum EControlRigTestDataPlaybackMode : byte
{
    Live=0,
    ReplayInputs=1,
    GroundTruth=2,
}