using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EEasingFunc : byte
{
    Linear=0,
    Step=1,
    SinusoidalIn=2,
    SinusoidalOut=3,
    SinusoidalInOut=4,
    EaseIn=5,
    EaseOut=6,
    EaseInOut=7,
    ExpoIn=8,
    ExpoOut=9,
    ExpoInOut=10,
    CircularIn=11,
    CircularOut=12,
    CircularInOut=13,
}