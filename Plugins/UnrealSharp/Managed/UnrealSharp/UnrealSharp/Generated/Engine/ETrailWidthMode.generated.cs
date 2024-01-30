using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ETrailWidthMode : byte
{
    ETrailWidthMode_FromCentre=0,
    ETrailWidthMode_FromFirst=1,
    ETrailWidthMode_FromSecond=2,
}