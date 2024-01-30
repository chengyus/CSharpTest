using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.HeadMountedDisplay;

[UEnum]
public enum EXRSystemFlags : byte
{
    IsAR=1,
    IsTablet=2,
    IsHeadMounted=3,
    SupportsHandTracking=4,
}