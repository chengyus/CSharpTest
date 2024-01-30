using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum EStereoLayerType : byte
{
    SLT_WorldLocked=0,
    SLT_TrackerLocked=1,
    SLT_FaceLocked=2,
}