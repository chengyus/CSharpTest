using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UEnum]
public enum EAudioDeviceChangedRole : byte
{
    Invalid=0,
    Console=1,
    Multimedia=2,
    Communications=3,
}