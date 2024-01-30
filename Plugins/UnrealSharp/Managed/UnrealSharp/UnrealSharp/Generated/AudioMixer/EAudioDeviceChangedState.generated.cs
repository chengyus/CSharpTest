using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UEnum]
public enum EAudioDeviceChangedState : byte
{
    Invalid=0,
    Active=1,
    Disabled=2,
    NotPresent=3,
    Unplugged=4,
}