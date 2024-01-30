using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayCameras;

[UEnum]
public enum ECameraAnimationPlaySpace : byte
{
    CameraLocal=0,
    World=1,
    UserDefined=2,
}