using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaUtils;

[UEnum]
public enum EMediaPlayerOptionBooleanOverride : byte
{
    UseMediaPlayerSetting=0,
    Enabled=1,
    Disabled=2,
}