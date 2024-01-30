using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EAudioOutputTarget : byte
{
    Speaker=0,
    Controller=1,
    ControllerFallbackToSpeaker=2,
}