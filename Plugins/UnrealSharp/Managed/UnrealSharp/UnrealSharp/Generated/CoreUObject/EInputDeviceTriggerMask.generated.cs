using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UEnum]
public enum EInputDeviceTriggerMask : byte
{
    None=0,
    Left=1,
    Right=2,
    All=3,
}