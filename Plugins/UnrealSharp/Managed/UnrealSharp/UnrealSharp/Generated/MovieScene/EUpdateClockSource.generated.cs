using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UEnum]
public enum EUpdateClockSource : byte
{
    Tick=0,
    Platform=1,
    Audio=2,
    RelativeTimecode=3,
    Timecode=4,
    PlayEveryFrame=5,
    Custom=6,
}