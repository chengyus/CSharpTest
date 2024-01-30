using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UEnum]
public enum EStretch : byte
{
    None=0,
    Fill=1,
    ScaleToFit=2,
    ScaleToFitX=3,
    ScaleToFitY=4,
    ScaleToFill=5,
    ScaleBySafeZone=6,
    UserSpecified=7,
    UserSpecifiedWithClipping=8,
}