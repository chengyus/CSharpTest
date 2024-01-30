using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UEnum]
public enum EAudioMixerStreamDataFormatType : byte
{
    Unknown=0,
    Float=1,
    Int16=2,
    Unsupported=3,
}