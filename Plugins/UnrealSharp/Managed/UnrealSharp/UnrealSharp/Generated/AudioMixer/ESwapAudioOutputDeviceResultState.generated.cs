using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UEnum]
public enum ESwapAudioOutputDeviceResultState : byte
{
    Failure=0,
    Success=1,
    None=2,
}