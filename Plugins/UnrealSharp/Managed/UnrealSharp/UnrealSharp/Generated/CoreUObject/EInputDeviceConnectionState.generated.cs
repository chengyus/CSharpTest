using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UEnum]
public enum EInputDeviceConnectionState : byte
{
    Invalid=0,
    Unknown=1,
    Disconnected=2,
    Connected=3,
}