using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAudioComponentPlayState : byte
{
    Playing=0,
    Stopped=1,
    Paused=2,
    FadingIn=3,
    FadingOut=4,
}