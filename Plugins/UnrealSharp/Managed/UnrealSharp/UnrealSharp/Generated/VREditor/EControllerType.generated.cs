using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.VREditor;

[UEnum]
public enum EControllerType : byte
{
    Laser=0,
    AssistingLaser=1,
    UI=2,
    Navigation=3,
    Unknown=4,
}