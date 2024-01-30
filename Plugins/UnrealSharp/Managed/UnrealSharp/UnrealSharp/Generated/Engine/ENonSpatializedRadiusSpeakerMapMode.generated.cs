using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UEnum]
public enum ENonSpatializedRadiusSpeakerMapMode : byte
{
    OmniDirectional=0,
    Direct2D=1,
    Surround2D=2,
}