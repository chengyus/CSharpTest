using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AudioMixer;

[UEnum]
public enum ESubmixEffectDynamicsKeySource : byte
{
    Default=0,
    AudioBus=1,
    Submix=2,
}