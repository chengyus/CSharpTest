using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UEnum]
public enum EMediaAudioCaptureDeviceFilter : byte
{
    Card=1,
    Microphone=2,
    Software=3,
    Unknown=4,
}