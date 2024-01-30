using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UEnum]
public enum ESubmixEffectDynamicsChannelLinkMode : byte
{
    Disabled=0,
    Average=1,
    Peak=2,
}